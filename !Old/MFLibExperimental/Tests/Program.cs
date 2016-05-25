using MediaFoundation;
using MediaFoundation.Core.Classes;
using MediaFoundation.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        [MTAThread]
        public static void Main(string[] args)
        {
            Program.PrintTransforms();
            //string inputFile = @"C:\Development\Customers\Atlas.ti\DirectShow\WikiLeaks _ Apache helicopter _ Attack _ Iraq.avi";
            //string outputFile = @"c:\temp\transcoded.mp4";
            //using(Framework fw = Framework.Startup())
            //{
            //    Program.EncodeFile(inputFile, outputFile);
            //}
        }

        private static void PrintTransforms()
        {
            Program.PrintTransforms(MFTransformCategory.AudioDecoder, "AudioDecoder");
            Program.PrintTransforms(MFTransformCategory.AudioEffect, "AudioEffect");
            Program.PrintTransforms(MFTransformCategory.AudioEncoder, "AudioEncoder");
            Program.PrintTransforms(MFTransformCategory.Demultiplexer, "Demultiplexer");
            Program.PrintTransforms(MFTransformCategory.Multiplexer, "Multiplexer");
            Program.PrintTransforms(MFTransformCategory.Other, "Other");
            Program.PrintTransforms(MFTransformCategory.VideoDecoder, "VideoDecoder");
            Program.PrintTransforms(MFTransformCategory.VideoEffect, "VideoEffect");
            Program.PrintTransforms(MFTransformCategory.VideoEncoder, "VideoEncoder");
            Program.PrintTransforms(MFTransformCategory.VideoProcessor, "VideoProcessor");
        }

        private static void PrintTransforms(MFTransformCategory category, string categoryName)
        {
            Console.WriteLine(categoryName);

            Activate[] activates = MFTransformCategory.GetTransforms(category, MediaFoundation.Transform.Enums.MFT_EnumFlag.TranscodeOnly);
            foreach (Activate  activate in activates)
            {
                Guid clsid = activate.GetGuid(MFAttribute.Transform.MFT_TRANSFORM_CLSID_Attribute);
                string name = activate.GetStringOrNull(MFAttribute.Transform.MFT_FRIENDLY_NAME_Attribute);
                Console.WriteLine(" - {0} : {1}", clsid, name);
            }

            foreach (Activate  activate in activates)
                activate.Dispose();
        }

        private static void EncodeFile(string inputFile, string outputFile)
        {
            // SEE: https://msdn.microsoft.com/en-us/library/windows/desktop/ff819476(v=vs.85).aspx
            using(SourceResolver resolver = SourceResolver.Create())
            {
                using(MediaSource source = resolver.CreateObjectFromURL(inputFile, MFResolution.MediaSource, null) as MediaSource)
                {
                    Time duration;
                    using(PresentationDescriptor pd = source.CreatePresentationDescriptor())
                    {
                        duration = pd.GetTime(MFAttribute.PresentationDescriptor.MF_PD_DURATION);
                    }

                    using(TranscodeProfile profile = TranscodeProfile.Create())
                    {
                        using(Attributes audio = Program.CreateAACProfile())
                        {
                            profile.AudioAttributes = audio;
                        }
                        using (Attributes video = Program.CreateH264Profile())
                        {
                            profile.VideoAttributes = video;
                        }
                        using(Attributes container = Attributes.Create(1))
                        {
                            container.SetGuid(MFAttribute.Transcode.MF_TRANSCODE_CONTAINERTYPE, MFTranscodeContainerType.MPEG4);
                            profile.ContainerAttributes = container;
                        }

                        using(Topology topology = profile.CreateTranscodeTopology(source, outputFile))
                        {
                            using (SessionHelper session = new SessionHelper())
                            {
                                session.StartEncodingSession(topology);
                                Program.RunEncodingSession(session, duration);
                            }
                        }
                    }
                }
            }
        }

        private static void RunEncodingSession(SessionHelper session, Time duration)
        {
            long prevPct = 0;
            while(true)
            {
                bool pending = session.Wait(5000);
                if (pending)
                {
                    Time pos = session.GetEncodingPosition();
                    long pct = pos.Value * 100 / duration.Value;
                    if (pct >= (prevPct + 5))
                    {
                        prevPct = pct;
                        Console.WriteLine("Encoded {0} %", pct);
                    }
                }
                else
                {
                    break;
                }
            }
        }

        private class SessionHelper : MediaFoundation.AsyncCallback, IDisposable
        {
            private readonly MediaSession Session;
            private readonly PresentationClock Clock;
            private readonly AutoResetEvent WaitEvent;

            public SessionHelper()
            {
                this.WaitEvent = new AutoResetEvent(false);
                this.Session = MediaSession.Create();
                using (Clock clock = this.Session.Clock)
                {
                    this.Clock = clock.GetComObject(PresentationClock.FromUnknown);
                }
                this.Session.BeginGetEvent(this);
            }

            public void StartEncodingSession(Topology topology)
            {
                this.Session.SetTopology(MFSessionSetTopologyFlags.None, topology);
                this.Session.Start();
            }

            public bool Wait(int milliseconds)
            {
                return !this.WaitEvent.WaitOne(milliseconds);
            }

            public Time GetEncodingPosition()
            {
                return this.Clock.Time;
            }

            protected override int Invoke(AsyncResult asyncResult)
            {
                using(MediaEvent evt = this.Session.EndGetEvent(asyncResult))
                {
                    MediaEventType type = evt.Type;
                    int hr = evt.GetStatus();
                    if (COM.Failed(hr))
                    {
                        this.Session.Close();
                        return hr;
                    }

                    if (type == MediaEventType.MESessionEnded)
                        this.Session.Close();
                    else if (type == MediaEventType.MESessionClosed)
                        this.WaitEvent.Set();

                    if (type != MediaEventType.MESessionClosed)
                        this.Session.BeginGetEvent(this);
                }

                return COM.S_OK;
            }



            public void Dispose()
            {
                this.Clock.Dispose();
                this.Session.Close();
                this.Session.Dispose();
                this.WaitEvent.Close();
                this.WaitEvent.Dispose();
            }
        }

        private static Attributes CreateAACProfile()
        {
            Attributes attribs = Attributes.Create(7);

            attribs.SetGuid(MFAttribute.MediaType.MF_MT_SUBTYPE, MFMediaType.SubType.Audio.AAC);
            attribs.SetInt32(MFAttribute.MediaTypes.Audio.MF_MT_AUDIO_BITS_PER_SAMPLE, 16);
            attribs.SetInt32(MFAttribute.MediaTypes.Audio.MF_MT_AUDIO_SAMPLES_PER_SECOND, 44100);
            attribs.SetInt32(MFAttribute.MediaTypes.Audio.MF_MT_AUDIO_NUM_CHANNELS, 2);
            attribs.SetInt32(MFAttribute.MediaTypes.Audio.MF_MT_AUDIO_AVG_BYTES_PER_SECOND, 16000);
            attribs.SetInt32(MFAttribute.MediaTypes.Audio.MF_MT_AUDIO_BLOCK_ALIGNMENT, 1);
            attribs.SetInt32(MFAttribute.MediaTypes.Audio.MF_MT_AAC_AUDIO_PROFILE_LEVEL_INDICATION, 0x29);

            return attribs;
        }

        private static Attributes CreateH264Profile()
        {
            Attributes attribs = Attributes.Create(5);

            //attribs.SetGuid(MFAttribute.MediaType.MF_MT_SUBTYPE, MFMediaType.SubType.Video.H264);
            //attribs.SetInt32(MFAttribute.MediaTypes.Video.MF_MT_MPEG2_PROFILE, (int)eAVEncH264VProfile.Base);
            //attribs.SetUpperLowerInt32(MFAttribute.MediaTypes.Video.MF_MT_FRAME_SIZE, new Int32Int32(640, 480));
            //attribs.SetUpperLowerInt32(MFAttribute.MediaTypes.Video.MF_MT_FRAME_RATE, new Int32Int32(30, 1));
            //attribs.SetInt32(MFAttribute.MediaTypes.Video.MF_MT_AVG_BITRATE, 1000000);

            attribs.SetGuid(MFAttribute.MediaType.MF_MT_SUBTYPE, MFMediaType.SubType.Video.H264);
            attribs.SetInt32(MFAttribute.MediaTypes.Video.MF_MT_MPEG2_PROFILE, (int)eAVEncH264VProfile.Base);
            attribs.SetUpperLowerInt32(MFAttribute.MediaTypes.Video.MF_MT_FRAME_SIZE, new Int32Int32(100, 100));
            attribs.SetUpperLowerInt32(MFAttribute.MediaTypes.Video.MF_MT_FRAME_RATE, new Int32Int32(1, 1));
            attribs.SetInt32(MFAttribute.MediaTypes.Video.MF_MT_AVG_BITRATE, 100000);

            return attribs;
        }
    }
}
