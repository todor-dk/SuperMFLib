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

namespace MediaFoundation.Dxvahd.Enums
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Defines video processing capabilities for a Microsoft DirectX Video Acceleration High Definition
    /// (DXVA-HD) device.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1F3DDE4C-CD9D-4361-B2B2-DB3C9D2EA146(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1F3DDE4C-CD9D-4361-B2B2-DB3C9D2EA146(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("DXVAHD_DEVICE_CAPS")]
    internal enum DXVAHD_DEVICE_CAPS
    {
        /// <summary>
        /// The device can blend video content in linear color space. Most video content is gamma corrected,
        /// resulting in nonlinear values. If the DXVA-HD device sets this flag, it means the device converts
        /// colors to linear space before blending, which produces better results. 
        /// </summary>
        LinearSpace = 0x1,
        /// <summary>
        /// The device supports the xvYCC color space for YCbCr data.
        /// </summary>
        xvYCC = 0x2,
        /// <summary>
        /// The device can perform range conversion when the input and output are both RGB but use different
        /// color ranges (0-255 or 16-235, for 8-bit RGB).
        /// </summary>
        RGBRangeConversion = 0x4,
        /// <summary>
        /// The device can apply a matrix conversion to YCbCr values when the input and output are both YCbCr.
        /// For example, the driver can convert colors from BT.601 to BT.709.
        /// </summary>
        YCbCrMatrixConversion = 0x8
    }

#endif

}
