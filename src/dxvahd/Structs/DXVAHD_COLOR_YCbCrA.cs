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
    /// Specifies a YCbCr color value.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_COLOR_YCbCrA {
    ///   FLOAT Y;
    ///   FLOAT Cb;
    ///   FLOAT Cr;
    ///   FLOAT A;
    /// } DXVAHD_COLOR_YCbCrA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3E37DAF1-5529-4042-AB6E-89A7F77D5E15(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3E37DAF1-5529-4042-AB6E-89A7F77D5E15(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("DXVAHD_COLOR_YCbCrA")]
    public struct DXVAHD_COLOR_YCbCrA
    {
        /// <summary>
        /// The Y (luma) value.
        /// </summary>
        public float Y;
        /// <summary>
        /// The Cb chroma value.
        /// </summary>
        public float Cb;
        /// <summary>
        /// The Cr chroma value.
        /// </summary>
        public float Cr;
        /// <summary>
        /// The alpha value. Values range from 0 (transparent) to 1 (opaque).
        /// </summary>
        public float A;
    }

#endif

}
