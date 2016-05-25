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
    /// Specifies the format for an input stream, when using Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD).
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_STREAM_STATE_D3DFORMAT_DATA {
    ///   D3DFORMAT Format;
    /// } DXVAHD_STREAM_STATE_D3DFORMAT_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A1BA825B-0574-4657-8A10-447A3CAF8149(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A1BA825B-0574-4657-8A10-447A3CAF8149(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_STREAM_STATE_D3DFORMAT_DATA")]
    internal struct DXVAHD_STREAM_STATE_D3DFORMAT_DATA
    {
        /// <summary>
        /// The surface format, specified as a <strong>D3DFORMAT</strong> value. You can also use a FOURCC code
        /// to specify a format that is not defined in the <strong>D3DFORMAT</strong> enumeration. For more
        /// information, see <c>Video FOURCCs</c>. 
        /// <para/>
        /// The default state value is <strong>D3DFMT_UNKNOWN</strong>. 
        /// </summary>
        public int Format; // D3DFORMAT
    }

#endif

}
