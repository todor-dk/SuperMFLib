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
    /// Specifies the target rectangle for blitting, when using Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD).
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _DXVAHD_BLT_STATE_TARGET_RECT_DATA {
    ///   BOOL Enable;
    ///   RECT TargetRect;
    /// } DXVAHD_BLT_STATE_TARGET_RECT_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/2A810071-B5F7-4216-8108-83DCE5C12836(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2A810071-B5F7-4216-8108-83DCE5C12836(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_BLT_STATE_TARGET_RECT_DATA")]
    public struct DXVAHD_BLT_STATE_TARGET_RECT_DATA
    {
        /// <summary>
        /// Specifies whether to use the target rectangle. The default state value is <strong>FALSE</strong>.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term><strong>TRUE</strong></term><description>Use the target rectangle specified by the <strong>TargetRect</strong> member. </description></item><item><term><strong>FALSE</strong></term><description>Use the entire destination surface as the target rectangle. Ignore the <strong>TargetRect</strong> member. </description></item></list>
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool Enable;
        /// <summary>
        /// Specifies the <em>target rectangle</em>. The target rectangle is the area within the destination
        /// surface where the output will be drawn. The target rectangle is given in pixel coordinates,
        /// relative to the destination surface. The default state value is an empty rectangle, (0, 0, 0, 0).
        /// <para />
        /// If the <strong>Enable</strong> member is <strong>FALSE</strong>, the <strong>TargetRect</strong>
        /// member is ignored.
        /// </summary>
        public MFRect TargetRect;
    }

#endif

}
