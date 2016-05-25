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
    /// Specifies the luma key for an input stream, when using Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD).
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_STREAM_STATE_LUMA_KEY_DATA {
    ///   BOOL  Enable;
    ///   FLOAT Lower;
    ///   FLOAT Upper;
    /// } DXVAHD_STREAM_STATE_LUMA_KEY_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D94B04D9-9D94-4392-A0BF-A33210AEEF1F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D94B04D9-9D94-4392-A0BF-A33210AEEF1F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_STREAM_STATE_LUMA_KEY_DATA")]
    internal struct DXVAHD_STREAM_STATE_LUMA_KEY_DATA
    {
        /// <summary>
        /// If <strong>TRUE</strong>, luma keying is enabled. Otherwise, luma keying is disabled. The default
        /// value is <strong>FALSE</strong>. 
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool Enable;
        /// <summary>
        /// The lower bound for the luma key. The range is [0…1]. The default state value is 0.0. 
        /// </summary>
        public float Lower;
        /// <summary>
        /// The upper bound for the luma key. The range is [0…1]. The default state value is 0.0. 
        /// </summary>
        public float Upper;
    }

#endif

}
