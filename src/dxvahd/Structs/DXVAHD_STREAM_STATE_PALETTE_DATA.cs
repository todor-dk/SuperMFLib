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
    /// Contains the color palette entries for an input stream, when using Microsoft DirectX Video
    /// Acceleration High Definition (DXVA-HD).
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_STREAM_STATE_PALETTE_DATA {
    ///   UINT     Count;
    ///   D3DCOLOR *pEntries;
    /// } DXVAHD_STREAM_STATE_PALETTE_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/91F69451-72E6-4028-92D5-555DCF834CF7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/91F69451-72E6-4028-92D5-555DCF834CF7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_STREAM_STATE_PALETTE_DATA")]
    internal struct DXVAHD_STREAM_STATE_PALETTE_DATA
    {
        /// <summary>
        /// The number of palette entries. The default state value is 0.
        /// </summary>
        public int Count;
        /// <summary>
        /// A pointer to an array of <strong>D3DCOLOR</strong> values. For RGB streams, the palette entries use
        /// a D3DFMT_A8R8G8B8 (ARGB-32) representation. For YCbCr streams, the palette entries use an AYUV
        /// representation. The alpha channel is used for alpha blending; see 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_ALPHA_DATA"/>. 
        /// </summary>
        public int[] pEntries; // D3DCOLOR
    }

#endif

}
