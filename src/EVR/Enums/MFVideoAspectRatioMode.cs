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

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.Transform;
using System.Drawing;

namespace MediaFoundation.EVR
{
    /// <summary>
    /// Specifies the aspect-ratio mode.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C0A34CFF-F86F-4005-9320-5DADFDDE5808(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C0A34CFF-F86F-4005-9320-5DADFDDE5808(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MFVideoAspectRatioMode")]
    public enum MFVideoAspectRatioMode
    {
        /// <summary>
        /// Do not maintain the aspect ratio of the video. Stretch the video to fit the output rectangle.
        /// </summary>
        None = 0x00000000,
        /// <summary>
        /// Preserve the aspect ratio of the video by letterboxing or within the output rectangle.
        /// </summary>
        PreservePicture = 0x00000001,
        /// <summary>
        /// <strong>Note</strong> Currently the EVR ignores this flag. 
        /// <para/>
        /// Correct the aspect ratio if the physical size of the display device does not match the display
        /// resolution. For example, if the native resolution of the monitor is 1600 by 1200 (4:3) but the
        /// display resolution is 1280 by 1024 (5:4), the monitor will display non-square pixels.
        /// <para/>
        /// If this flag is set, you must also set the <strong>MFVideoARMode_PreservePicture</strong> flag. 
        /// </summary>
        PreservePixel = 0x00000002,
        /// <summary>
        /// Apply a non-linear horizontal stretch if the aspect ratio of the destination rectangle does not
        /// match the aspect ratio of the source rectangle.
        /// <para/>
        /// The non-linear stretch algorithm preserves the aspect ratio in the middle of the picture and
        /// stretches (or shrinks) the image progressively more toward the left and right. This mode is useful
        /// when viewing 4:3 content full-screen on a 16:9 display, instead of pillar-boxing. Non-linear
        /// vertical stretch is not supported, because the visual results are generally poor.
        /// <para/>
        /// This mode may cause performance degradation.
        /// <para/>
        /// If this flag is set, you must also set the <strong>MFVideoARMode_PreservePixel</strong> and 
        /// <strong>MFVideoARMode_PreservePicture</strong> flags. 
        /// </summary>
        NonLinearStretch = 0x00000004,
        /// <summary>
        /// Bitmask to validate flag values. This value is not a valid flag.
        /// </summary>
        Mask = 0x00000007
    }
}
