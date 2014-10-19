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
    /// Specifies image filters for Microsoft DirectX Video Acceleration High Definition (DXVA-HD) video
    /// processing.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E6ABAC04-C8CB-4130-B48E-FB5D25794D62(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E6ABAC04-C8CB-4130-B48E-FB5D25794D62(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("DXVAHD_FILTER")]
    public enum DXVAHD_FILTER
    {
        /// <summary>
        /// Adjusts brightness.
        /// </summary>
        Brightness = 0,
        /// <summary>
        /// Adjusts contrast.
        /// </summary>
        Contrast = 1,
        /// <summary>
        /// Adjusts hue.
        /// </summary>
        Hue = 2,
        /// <summary>
        /// Adjusts saturation.
        /// </summary>
        Saturation = 3,
        /// <summary>
        /// Applies noise reduction.
        /// </summary>
        NoiseReduction = 4,
        /// <summary>
        /// Applies edge enhancement.
        /// </summary>
        EdgeEnhancement = 5,
        /// <summary>
        /// Performs <em>anamorphic scaling</em>. Anamorphic scaling can be used to stretch 4:3 content to a
        /// widescreen 16:9 aspect ratio. 
        /// </summary>
        AnamorphicScaling = 6
    }

#endif

}
