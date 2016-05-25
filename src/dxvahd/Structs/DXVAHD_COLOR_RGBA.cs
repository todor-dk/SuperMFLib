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

namespace MediaFoundation.Dxvahd.Structs
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Specifies an RGB color value.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_COLOR_RGBA {
    ///   FLOAT R;
    ///   FLOAT G;
    ///   FLOAT B;
    ///   FLOAT A;
    /// } DXVAHD_COLOR_RGBA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/60A167CB-F95E-4EB5-995F-BE4CCEAEE47D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/60A167CB-F95E-4EB5-995F-BE4CCEAEE47D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("DXVAHD_COLOR_RGBA")]
    internal struct DXVAHD_COLOR_RGBA
    {
        /// <summary>
        /// The red value.
        /// </summary>
        public float R;
        /// <summary>
        /// The green value.
        /// </summary>
        public float G;
        /// <summary>
        /// The blue value.
        /// </summary>
        public float B;
        /// <summary>
        /// The alpha value. Values range from 0 (transparent) to 1 (opaque).
        /// </summary>
        public float A;
    }

#endif

}
