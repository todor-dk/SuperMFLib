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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.dxvahd
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Specifies the intended use for a Microsoft DirectX Video Acceleration High Definition (DXVA-HD)
    /// device.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D071DEA8-2BAB-4768-BDBE-86AF08A65DC5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D071DEA8-2BAB-4768-BDBE-86AF08A65DC5(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("DXVAHD_DEVICE_USAGE")]
    public enum DXVAHD_DEVICE_USAGE
    {
        /// <summary>
        /// Normal video playback. The graphics driver should expose a set of capabilities that are appropriate
        /// for real-time video playback.
        /// </summary>
        PlaybackNormal = 0,
        /// <summary>
        /// Optimal speed.  The graphics driver should expose a minimal set of capabilities that are optimized
        /// for performance.
        /// <para/>
        /// Use this setting if you want better performance and can accept some reduction in video quality. For
        /// example, you might use this setting in power-saving mode or to play video thumbnails.
        /// </summary>
        OptimalSpeed = 1,
        /// <summary>
        /// Optimal quality. The grahics driver should expose its maximum set of capabilities.
        /// <para/>
        /// Specify this setting to get the best video quality possible. It is appropriate for tasks such as
        /// video editing, when quality is more important than speed. It is not appropriate for real-time
        /// playback.
        /// </summary>
        OptimalQuality = 2
    }

#endif

}
