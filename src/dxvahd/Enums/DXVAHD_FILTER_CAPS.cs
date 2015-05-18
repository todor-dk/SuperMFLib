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
    /// Defines capabilities related to image adjustment and filtering for a Microsoft DirectX Video
    /// Acceleration High Definition (DXVA-HD) device.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/2F4E0B48-FBCE-49E8-9EA8-1B6F0A022D60(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2F4E0B48-FBCE-49E8-9EA8-1B6F0A022D60(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("DXVAHD_FILTER_CAPS")]
    internal enum DXVAHD_FILTER_CAPS
    {
        /// <summary>
        /// The device can adjust the brightness level.
        /// </summary>
        Brightness = 0x1,
        /// <summary>
        /// The device can adjust the contrast level.
        /// </summary>
        Contrast = 0x2,
        /// <summary>
        /// The device can adjust hue.
        /// </summary>
        Hue = 0x4,
        /// <summary>
        /// The device can adjust the saturation level.
        /// </summary>
        Saturation = 0x8,
        /// <summary>
        /// The device can perform noise reduction.
        /// </summary>
        NoiseReduction = 0x10,
        /// <summary>
        /// The device can perform edge enhancement.
        /// </summary>
        EdgeEnhancement = 0x20,
        /// <summary>
        /// The device can perform <em>anamorphic scaling</em>. Anamorphic scaling can be used to stretch 4:3
        /// content to a widescreen 16:9 aspect ratio. 
        /// </summary>
        AnamorphicScaling = 0x40
    }

#endif

}
