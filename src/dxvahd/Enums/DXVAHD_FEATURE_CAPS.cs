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
    /// Defines features that a Microsoft DirectX Video Acceleration High Definition (DXVA-HD) device can
    /// support.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6014780B-3B8A-48D6-AE30-B48127A2C274(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6014780B-3B8A-48D6-AE30-B48127A2C274(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("DXVAHD_FEATURE_CAPS")]
    internal enum DXVAHD_FEATURE_CAPS
    {
        /// <summary>
        /// The device can set the alpha values on the video output. See 
        /// <see cref="dxvahd.DXVAHD_BLT_STATE_ALPHA_FILL_DATA"/>. 
        /// </summary>
        AlphaFill = 0x1,
        /// <summary>
        /// The device can downsample the video output. See 
        /// <see cref="dxvahd.DXVAHD_BLT_STATE_CONSTRICTION_DATA"/>. 
        /// </summary>
        Constriction = 0x2,
        /// <summary>
        /// The device can perform luma keying. See <see cref="dxvahd.DXVAHD_STREAM_STATE_LUMA_KEY_DATA"/>. 
        /// </summary>
        LumaKey = 0x4,
        /// <summary>
        /// The device can apply alpha values from color palette entries. See 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_ALPHA_DATA"/>. 
        /// </summary>
        AlphaPalette = 0x8
    }

#endif

}
