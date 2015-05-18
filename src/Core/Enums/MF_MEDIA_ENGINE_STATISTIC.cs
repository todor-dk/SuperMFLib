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

namespace MediaFoundation.Core.Enums
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Identifies statistics that the Media Engine tracks during playback. To get a playback statistic
    /// from the Media Engine, call <see cref="IMFMediaEngineEx.GetStatistics"/>. 
    /// <para/>
    /// In the descriptions that follow, the data type and value-type tag for the <c>PROPVARIANT</c> are
    /// listed in parentheses. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/EB431C2F-69A3-4376-BEC7-A5AE0329AD15(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EB431C2F-69A3-4376-BEC7-A5AE0329AD15(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_MEDIA_ENGINE_STATISTIC")]
    internal enum MF_MEDIA_ENGINE_STATISTIC
    {
        /// <summary>
        /// The number of rendered video frames. ( <strong>ULONG</strong>, <strong>VT_UI4</strong>) 
        /// </summary>
        FramesRendered = 0,
        /// <summary>
        /// The number of dropped video frames. ( <strong>ULONG</strong>, <strong>VT_UI4</strong>) 
        /// </summary>
        FramesDropped = 1,
        /// <summary>
        /// The number of bytes that have been downloaded since the last HTTP range request. ( <strong>
        /// ULARGE_INTEGER</strong>, <strong>VT_UI8</strong>). 
        /// </summary>
        BytesDownloaded = 2,
        /// <summary>
        /// The percentage of the playout buffer filled during buffering. The value is an integer in the range
        /// 0–100. ( <strong>LONG</strong>, <strong>VT_I4</strong>) 
        /// </summary>
        BufferProgress = 3,
        /// <summary>
        /// The frames per second. (<strong>FLOAT</strong>, <strong>VT_R4</strong>)
        /// </summary>
        FramesPerSecond = 4,
        /// <summary>
        /// The amount of playback jitter. (<strong>DOUBLE</strong>, <strong>VT_R8</strong>)
        /// <para/>
        /// Supported in Windows 8.1 and later.
        /// </summary>
        PlaybackJitter = 5,
        /// <summary>
        /// The number of corrupted frames. (<strong>ULONG</strong>, <strong>VT_UI4</strong>)
        /// <para/>
        /// Supported in Windows 8.1 and later.
        /// </summary>
        FramesCorrupted = 6,
        /// <summary>
        /// The total amount of frame delay. (<strong>DOUBLE</strong>, <strong>VT_R8</strong>)
        /// <para/>
        /// Supported in Windows 8.1 and later.
        /// </summary>
        TotalFrameDelay = 7,

    }

#endif

}
