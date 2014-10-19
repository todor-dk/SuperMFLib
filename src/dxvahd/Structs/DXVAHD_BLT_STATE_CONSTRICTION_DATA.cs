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
    /// Specifies whether the output is downsampled in a  blit operation, when using Microsoft DirectX
    /// Video Acceleration High Definition (DXVA-HD).
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _DXVAHD_BLT_STATE_CONSTRICTION_DATA {
    ///   BOOL Enable;
    ///   SIZE Size;
    /// } DXVAHD_BLT_STATE_CONSTRICTION_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/962A99BD-060D-4101-B65A-D0406E136BF7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/962A99BD-060D-4101-B65A-D0406E136BF7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_BLT_STATE_CONSTRICTION_DATA")]
    public struct DXVAHD_BLT_STATE_CONSTRICTION_DATA
    {
        /// <summary>
        /// If <strong>TRUE</strong>, downsampling is enabled <strong></strong>. Otherwise, downsampling is
        /// disabled and the <strong>Size</strong> member is ignored. The default state value is <strong>FALSE
        /// </strong> (downsampling is disabled).
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool Enable;
        /// <summary>
        /// The x size
        /// </summary>
        public MFSize xSize;
    }

#endif

}
