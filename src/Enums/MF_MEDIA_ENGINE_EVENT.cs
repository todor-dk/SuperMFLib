#region license

/*
MediaFoundationLib - Provide access to MediaFoundation interfaces via .NET
Copyright (C) 2007
http://mfnet.sourceforge.net

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

#endregion

using System;
using System.Runtime.InteropServices;

using MediaFoundation.Misc;
using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    [UnmanagedName("MF_MEDIA_ENGINE_EVENT")]
    public enum MF_MEDIA_ENGINE_EVENT
    {
        LoadStart = 1,
        Progress = 2,
        Suspend = 3,
        Abort = 4,
        Error = 5,
        Emptied = 6,
        Stalled = 7,
        Play = 8,
        Pause = 9,
        LoadedMetadata = 10,
        LoadedData = 11,
        Waiting = 12,
        Playing = 13,
        CanPlay = 14,
        CanPlayThrough = 15,
        Seeking = 16,
        Seeked = 17,
        TimeUpdate = 18,
        Ended = 19,
        RateChange = 20,
        DurationChange = 21,
        VolumeChange = 22,

        FormatChange = 1000,
        PurgeQueuedEvents = 1001,
        TimelineMarker = 1002,
        BalanceChange = 1003,
        DownloadComplete = 1004,
        BufferingStarted = 1005,
        BufferingEnded = 1006,
        FrameStepCompleted = 1007,
        NotifyStableState = 1008
    }

#endif

}
