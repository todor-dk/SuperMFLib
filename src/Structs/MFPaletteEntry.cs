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
using System.Runtime.InteropServices.ComTypes;

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation
{

    /// <summary>
    /// Contains one palette entry in a color table.
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef union _MFPaletteEntry {
    ///   MFARGB       ARGB;
    ///   MFAYUVSample AYCbCr;
    /// } MFPaletteEntry;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/72E45756-B1AA-4DB0-A6E7-2E6EA97211B4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/72E45756-B1AA-4DB0-A6E7-2E6EA97211B4(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Pack = 1), UnmanagedName("MFPaletteEntry")]
    public struct MFPaletteEntry
    {
        /// <summary>
        /// <see cref="MFARGB" /> structure that contains an RGB color.
        /// </summary>
        [FieldOffset(0)]
        public MFARGB ARGB;
        /// <summary>
        /// <see cref="MFAYUVSample" /> structure that contains a Y'Cb'Cr' color.
        /// </summary>
        [FieldOffset(0)]
        public MFAYUVSample AYCbCr;
    }

}
