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
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Contains values that specify common video formats.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/559EA2E9-308B-428A-AE24-BF3FDC27E24E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/559EA2E9-308B-428A-AE24-BF3FDC27E24E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFStandardVideoFormat")]
    public enum MFStandardVideoFormat
    {
        /// <summary>
        /// Reserved; do not use.
        /// </summary>
        reserved = 0,
        /// <summary>
        /// NTSC television (720 x 480i).
        /// </summary>
        NTSC = (reserved + 1),
        /// <summary>
        /// PAL television (720 x 576i).
        /// </summary>
        PAL = (NTSC + 1),
        /// <summary>
        /// DVD, NTSC standard (720 x 480).
        /// </summary>
        DVD_NTSC = (PAL + 1),
        /// <summary>
        /// DVD, PAL standard (720 x 576).
        /// </summary>
        DVD_PAL = (DVD_NTSC + 1),
        /// <summary>
        /// DV video, PAL standard.
        /// </summary>
        DV_PAL = (DVD_PAL + 1),
        /// <summary>
        /// DV video, NTSC standard.
        /// </summary>
        DV_NTSC = (DV_PAL + 1),
        /// <summary>
        /// ATSC digital television, SD (480i).
        /// </summary>
        ATSC_SD480i = (DV_NTSC + 1),
        /// <summary>
        /// ATSC digital television, HD interlaced (1080i)
        /// </summary>
        ATSC_HD1080i = (ATSC_SD480i + 1),
        /// <summary>
        /// ATSC digital television, HD progressive (720p)
        /// </summary>
        ATSC_HD720p = (ATSC_HD1080i + 1)
    }

#endif

}
