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

namespace MediaFoundation.dxvahd.Enums
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Defines capabilities related to input formats for a Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD) device.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/DDFFF29C-3A40-4238-93E7-821C4FFC27AF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DDFFF29C-3A40-4238-93E7-821C4FFC27AF(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("DXVAHD_INPUT_FORMAT_CAPS")]
    internal enum DXVAHD_INPUT_FORMAT_CAPS
    {
        /// <summary>
        /// The device can deinterlace an input stream that contains interlaced RGB video.
        /// </summary>
        RGBInterlaced = 0x1,
        /// <summary>
        /// The device can perform color adjustment on RGB video.
        /// </summary>
        RGBProcAmp = 0x2,
        /// <summary>
        /// The device can perform luma keying on RGB video.
        /// </summary>
        RGBLumaKey = 0x4,
        /// <summary>
        /// The device can deinterlace input streams with palettized color formats.
        /// </summary>
        PaletteInterlaced = 0x8
    }

#endif

}
