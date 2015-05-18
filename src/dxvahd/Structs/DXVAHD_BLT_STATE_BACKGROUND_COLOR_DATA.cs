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

namespace MediaFoundation.dxvahd.Structs
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Specifies the background color for blit operations, when using Microsoft DirectX Video Acceleration
    /// High Definition (DXVA-HD).
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_BLT_STATE_BACKGROUND_COLOR_DATA {
    ///   BOOL         YCbCr;
    ///   DXVAHD_COLOR BackgroundColor;
    /// } DXVAHD_BLT_STATE_BACKGROUND_COLOR_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/34B8C29E-A183-4E68-BD46-802C43D554F7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/34B8C29E-A183-4E68-BD46-802C43D554F7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_BLT_STATE_BACKGROUND_COLOR_DATA")]
    internal struct DXVAHD_BLT_STATE_BACKGROUND_COLOR_DATA
    {
        /// <summary>
        /// If <strong>TRUE</strong>, the <strong>BackgroundColor</strong> member specifies a YCbCr color.
        /// Otherwise, it specifies an RGB color. The default device state is <strong>FALSE</strong> (RGB
        /// color).
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool YCbCr;
        /// <summary>
        /// A <see cref="dxvahd.DXVAHD_COLOR" /> union that specifies the background color. The default state
        /// value is (0.0, 0.0, 0.0, 1.0).
        /// </summary>
        public DXVAHD_COLOR BackgroundColor;
    }

#endif

}
