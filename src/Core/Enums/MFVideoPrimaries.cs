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

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation
{


    /// <summary>
    /// Specifies the color primaries of a video source. The color primaries define how to convert colors
    /// from RGB color space to CIE XYZ color space.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A1D6A60C-823C-46C3-A751-18E55FBC52A1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A1D6A60C-823C-46C3-A751-18E55FBC52A1(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFVideoPrimaries")]
    public enum MFVideoPrimaries
    {
        /// <summary>
        /// ITU-R BT.470-4 System B,G (NTSC). 
        /// </summary>
        BT470_2_SysBG = 4,
        /// <summary>
        /// ITU-R BT.470-4 System M (NTSC). 
        /// </summary>
        BT470_2_SysM = 3,
        /// <summary>
        /// ITU-R BT.709. Also used for sRGB and scRGB. 
        /// </summary>
        BT709 = 2,
        /// <summary>
        /// EBU 3213. 
        /// </summary>
        EBU3213 = 7,
        /// <summary>
        /// Reserved. This member forces the enumeration type to compile as a <strong>DWORD</strong> value. 
        /// </summary>
        ForceDWORD = 0x7fffffff,
        /// <summary>
        /// Reserved. 
        /// </summary>
        Last = 9,
        /// <summary>
        /// Reserved. 
        /// </summary>
        reserved = 1,
        /// <summary>
        /// SMPTE C (SMPTE RP 145). 
        /// </summary>
        SMPTE_C = 8,
        /// <summary>
        /// SMPTE 170M. 
        /// </summary>
        SMPTE170M = 5,
        /// <summary>
        /// SMPTE 240M. 
        /// </summary>
        SMPTE240M = 6,
        /// <summary>
        /// The color primaries are unknown. 
        /// </summary>
        Unknown = 0
    }

}
