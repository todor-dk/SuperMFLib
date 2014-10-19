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

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation
{


    /// <summary>
    /// Contains information about an uncompressed video format. This structure is used in the
    /// <see cref="MFVideoFormat" /> structure.
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _MFVideoSurfaceInfo {
    ///   DWORD          Format;
    ///   DWORD          PaletteEntries;
    ///   MFPaletteEntry Palette[];
    /// } MFVideoSurfaceInfo;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B48099A2-8427-496C-9A60-ACE5B89D81E9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B48099A2-8427-496C-9A60-ACE5B89D81E9(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 4), UnmanagedName("MFVideoSurfaceInfo")]
    public struct MFVideoSurfaceInfo
    {
        /// <summary>
        /// For compressed formats, this value must be zero. For uncompressed formats, the value is a FOURCC or
        /// <strong>D3DFORMAT</strong> value that identifies the format. Use the <strong>Data1</strong> field
        /// from the subtype GUID. See <c>Video Subtype GUIDs</c>.
        /// </summary>
        public int Format;
        /// <summary>
        /// Number of palette entries. The value must be between 0 and 256.
        /// </summary>
        public int PaletteEntries;
        /// <summary>
        /// Array of <c>MFPaletteEntry Union</c>s that contains the color table for a palettized format. The
        /// size of the array is given in the <strong>PaletteEntries</strong> member. If the format is not
        /// palettized, set <strong>PaletteEntries</strong> to zero.
        /// </summary>
        public MFPaletteEntry[] Palette;
    }

}
