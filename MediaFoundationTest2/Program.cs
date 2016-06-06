using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MediaFoundation;
using MediaFoundation.ReadWrite;

namespace MediaFoundationTest
{
    class Program
    {
        private static Framework MultimediaFramework;

        static void Main(string[] args)
        {
            MultimediaFramework = Framework.Startup(MFStartup.NoSocket); // We'll never dispose this as long as the process is running

            var d = GetDurationStreamReader(@"c:\temp\emirates2.mp4");

            string[] files = Directory.GetFiles(@"C:\Temp\Server\DirectShow");

            files.AsParallel().ForAll(file => GetDurationStreamReader(file));

            System.Diagnostics.Debug.WriteLine("OK!");
        }

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
