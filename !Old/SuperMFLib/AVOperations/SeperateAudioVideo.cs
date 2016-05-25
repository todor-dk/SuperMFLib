﻿using MediaFoundation.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFoundation.Net
{
    public partial class AVOperations
    {
        public static ProcessSample SeperateAudioVideo(ProcessSample audioStreams, ProcessSample videoStreams)
        {
            return sample =>
            {
                if (sample.Stream.NativeMediaType.IsVideo)
                    return videoStreams(sample);

                if (sample.Stream.NativeMediaType.IsAudio)
                    return audioStreams(sample);

                throw new Exception("Unknown stream type");
            };
        }

    }
}
