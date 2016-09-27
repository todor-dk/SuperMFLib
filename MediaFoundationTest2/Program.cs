using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MediaFoundation;
using MediaFoundation.Core.Classes;
using MediaFoundation.ReadWrite;
using MediaFoundation.ReadWrite.Classes;

namespace MediaFoundationTest
{
    class Program
    {
        private static Framework MultimediaFramework;

        static void Main(string[] args)
        {
            MultimediaFramework = Framework.Startup(MFStartup.NoSocket); // We'll never dispose this as long as the process is running

            using (Attributes attribs = Attributes.Create(1))
            {
                attribs.SetGuid(MFAttribute.SinkWriter.MF_TRANSCODE_CONTAINERTYPE, MFTranscodeContainerType.MPEG4);

                using (SinkWriter sink = SinkWriter.CreateFromURL(@"c:\temp\test.mov", attribs))
                {
                    int stream;

                    // Set the output media type.
                    using (MediaType outputType = MediaType.Create())
                    {
                        outputType.MajorType = MFMediaType.MajorType.Video;
                        outputType.Subtype = MFMediaType.SubType.Video.H264;
                        outputType.SetInt32(MFAttribute.MediaTypes.Video.MF_MT_INTERLACE_MODE, (int)MFVideoInterlaceMode.Progressive);
                        outputType.SetUpperLowerInt32(MFAttribute.MediaTypes.Video.MF_MT_FRAME_SIZE, new Int32Int32(640, 480));
                        outputType.SetUpperLowerInt32(MFAttribute.MediaTypes.Video.MF_MT_FRAME_RATE, new Int32Int32(25, 1));
                        outputType.SetUpperLowerInt32(MFAttribute.MediaTypes.Video.MF_MT_PIXEL_ASPECT_RATIO, new Int32Int32(1, 1));
                        outputType.SetInt32(MFAttribute.MediaTypes.Video.MF_MT_AVG_BITRATE, 500000);
                        stream = sink.AddStream(outputType);
                    }

                    // Set the output media type.
                    using (MediaType inputType = MediaType.Create())
                    {
                        inputType.MajorType = MFMediaType.MajorType.Video;
                        inputType.Subtype = MFMediaType.SubType.Video.RGB32;
                        inputType.SetInt32(MFAttribute.MediaTypes.Video.MF_MT_INTERLACE_MODE, (int)MFVideoInterlaceMode.Progressive);
                        inputType.SetUpperLowerInt32(MFAttribute.MediaTypes.Video.MF_MT_FRAME_SIZE, new Int32Int32(640, 480));
                        inputType.SetUpperLowerInt32(MFAttribute.MediaTypes.Video.MF_MT_FRAME_RATE, new Int32Int32(25, 1));
                        inputType.SetUpperLowerInt32(MFAttribute.MediaTypes.Video.MF_MT_PIXEL_ASPECT_RATIO, new Int32Int32(1, 1));
                        sink.SetInputMediaType(stream, inputType);
                    }

                    MF_SINK_WRITER_STATISTICS stats;
                    //stats = sink.GetStatistics();
                    //stats = sink.GetStatistics(stream);

                    // Tell the sink writer to start accepting data.
                    sink.BeginWriting();

                    stats = sink.GetStatistics();
                    stats = sink.GetStatistics(stream);

                    // Send frames to the sink writer.
                    Time time = Time.Zero;
                    for (int i = 0; i < 250; i++)
                    {
                        if (i == 100)
                        {
                            stats = sink.GetStatistics();
                            stats = sink.GetStatistics(stream);
                            time = time + (Time.OneSecondValue / 25);
                        }
                        WriteFrame(sink, stream, time);
                    }

                    sink.Finalize();

                    stats = sink.GetStatistics();
                    stats = sink.GetStatistics(stream);
                }
            }

            System.Diagnostics.Debug.WriteLine("OK!");
        }

        private static void WriteFrame(SinkWriter sink, int stream, Time time)
        {
            // Create a new memory buffer.
            int bufferSize = 640 * 480 * 4;
            using (MediaBuffer buffer = MediaBuffer.CreateMemoryBuffer(bufferSize))
            {
                // Lock the buffer and copy the video frame to the buffer.
                IntPtr data = buffer.Lock();
                try
                {
                    for (int i = 0; i < bufferSize; i = i + 4)
                    {
                        Marshal.WriteInt32(data, i, 0x0000FF00); // Fill green
                    }
                }
                finally
                {
                    buffer.Unlock();
                }

                // Set the data length of the buffer.
                buffer.CurrentLength = bufferSize;

                // Create a media sample and add the buffer to the sample.
                using (Sample sample = Sample.Create())
                {
                    sample.AddBuffer(buffer);

                    // Set the time stamp and the duration.
                    sample.SampleTime = time;
                    sample.SampleDuration = (Time.OneSecond / 25);

                    // Send the sample to the Sink Writer.
                    sink.WriteSample(stream, sample);
                }
            }
        }

        //static void Main(string[] args)
        //{
        //    MultimediaFramework = Framework.Startup(MFStartup.NoSocket); // We'll never dispose this as long as the process is running

        //    var d = GetDurationStreamReader(@"c:\temp\emirates2.mp4");

        //    string[] files = Directory.GetFiles(@"C:\Temp\Server\DirectShow");

        //    files.AsParallel().ForAll(file => GetDurationStreamReader(file));

        //    System.Diagnostics.Debug.WriteLine("OK!");
        //}

        private static Time? GetDuration(string path)
        {
            try
            {
                return GetDurationWorker(path);
            }
            catch (COMException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }

        private static Time? GetDurationWorker(string path)
        {
            MediaSource source = null;
            // Create the source resolver.
            using (SourceResolver resolver = SourceResolver.Create())
            {
                // Use the source resolver to create the media source.
                using (PropertyStore properties = PropertyStore.Create())   // Optional property store.
                {

                    //using (PropVariant value = new PropVariant(false))
                    //{
                    //    properties.SetValue(MFPKEY.ASFMediaSource_ApproxSeek, value);
                    //}
                    //using (PropVariant value = new PropVariant(true))
                    //{
                    //    properties.SetValue(MFPKEY.ASFMediaSource_IterativeSeekIfNoIndex, value);
                    //}
                    //using (PropVariant value = new PropVariant(50))
                    //{
                    //    properties.SetValue(MFPKEY.ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecond, value);
                    //}
                    //using (PropVariant value = new PropVariant(10))
                    //{
                    //    properties.SetValue(MFPKEY.ASFMediaSource_IterativeSeek_Max_Count, value);
                    //}

                    MFObjectType type;
                    MFResolution flags = MFResolution.MediaSource;
                    flags = flags | MFResolution.ContentDoesNotHaveToMatchExtensionOrMimeType;
                    // Note: For simplicity this sample uses the synchronous method to create 
                    // the media source. However, creating a media source can take a noticeable
                    // amount of time, especially for a network source. For a more responsive 
                    // UI, use the asynchronous BeginCreateObjectFromURL method.
                    object obj = resolver.CreateObjectFromURL(path, flags, properties, out type);

                    // Get the IMFMediaSource interface from the media source.
                    if (type == MFObjectType.MediaSource)
                        source = obj as MediaSource;
                    else
                        COM.SafeRelease(ref obj);
                }
            }

            if (source == null)
                return null;

            using (PresentationDescriptor presentationDescriptor = source.CreatePresentationDescriptor())
            {
                Time? duration = presentationDescriptor.GetTimeOrNull(MFAttribute.PresentationDescriptor.MF_PD_DURATION);
                return duration;
            }
        }


        private static Time? GetDurationStreamReader(string path)
        {
            try
            {
                return GetDurationStreamReaderWorker(path);
            }
            catch (COMException ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
                return null;
            }
        }


        private static Time? GetDurationStreamReaderWorker(string path)
        {
            MediaSource source = null;
            // Create the source resolver.
            using (SourceResolver resolver = SourceResolver.Create())
            {
                // Use the source resolver to create the media source.
                using (PropertyStore properties = PropertyStore.Create())   // Optional property store.
                {

                    //using (PropVariant value = new PropVariant(false))
                    //{
                    //    properties.SetValue(MFPKEY.ASFMediaSource_ApproxSeek, value);
                    //}
                    //using (PropVariant value = new PropVariant(true))
                    //{
                    //    properties.SetValue(MFPKEY.ASFMediaSource_IterativeSeekIfNoIndex, value);
                    //}
                    //using (PropVariant value = new PropVariant(50))
                    //{
                    //    properties.SetValue(MFPKEY.ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecond, value);
                    //}
                    //using (PropVariant value = new PropVariant(10))
                    //{
                    //    properties.SetValue(MFPKEY.ASFMediaSource_IterativeSeek_Max_Count, value);
                    //}

                    MFObjectType type;
                    MFResolution flags = MFResolution.MediaSource;
                    flags = flags | MFResolution.ContentDoesNotHaveToMatchExtensionOrMimeType;
                    // Note: For simplicity this sample uses the synchronous method to create 
                    // the media source. However, creating a media source can take a noticeable
                    // amount of time, especially for a network source. For a more responsive 
                    // UI, use the asynchronous BeginCreateObjectFromURL method.
                    object obj = resolver.CreateObjectFromURL(path, flags, properties, out type);

                    // Get the IMFMediaSource interface from the media source.
                    if (type == MFObjectType.MediaSource)
                        source = obj as MediaSource;
                    else
                        COM.SafeRelease(ref obj);
                }
            }

            if (source == null)
                return null;

            using (source)
            {
                using (Attributes attribs = Attributes.Create(1))
                {
                    // Configure the source reader to perform video processing. This includes:
                    //   - YUV to RGB-32
                    //   - Software deinterlace
                    attribs.SetBoolean(MFAttribute.SourceReader.MF_SOURCE_READER_ENABLE_VIDEO_PROCESSING, true);

                    using (SourceReader reader = SourceReader.CreateFromMediaSource(source, attribs))
                    { 
                        // Deselect all streams
                        reader.SetStreamSelection(SourceReader.StreamAVA.AllStreams, false);

                        using (MediaType type = MediaType.Create())
                        {
                            type.SetGuid(MFAttribute.MediaType.MF_MT_MAJOR_TYPE, MFMediaType.MajorType.Video);
                            type.SetGuid(MFAttribute.MediaType.MF_MT_SUBTYPE, MFMediaType.SubType.Video.RGB32);

                            reader.SetCurrentMediaType(SourceReader.StreamAV.FirstVideoStream, type);
                            reader.SetStreamSelection(SourceReader.StreamAVA.FirstVideoStream, true);
                        }

                        object val = reader.GetPresentationAttributeValue(SourceReader.StreamAVMS.MediaSource, MFAttribute.PresentationDescriptor.MF_PD_DURATION);
                        ulong time = (ulong)val;
                        return new Time(unchecked((long)time));
                    }
                }
            }
        }
    }
}
