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
    /// Defines a color value for Microsoft DirectX Video Acceleration High Definition (DXVA-HD).
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef union _DXVAHD_COLOR {
    ///   DXVAHD_COLOR_RGBA   RGB;
    ///   DXVAHD_COLOR_YCbCrA YCbCr;
    /// } DXVAHD_COLOR;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/833BB91B-D891-4C3F-BE20-367B0A23E97E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/833BB91B-D891-4C3F-BE20-367B0A23E97E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit), UnmanagedName("DXVAHD_COLOR")]
    internal struct DXVAHD_COLOR
    {
        /// <summary>
        /// A <see cref="dxvahd.DXVAHD_COLOR_RGBA" /> structure that contains an RGB color value.
        /// </summary>
        [FieldOffset(0)]
        public DXVAHD_COLOR_RGBA RGB;
        /// <summary>
        /// A <see cref="dxvahd.DXVAHD_COLOR_YCbCrA" /> structure that contains a YCbCr color value.
        /// </summary>
        [FieldOffset(0)]
        public DXVAHD_COLOR_YCbCrA YCbCr;
    }

#endif

}
