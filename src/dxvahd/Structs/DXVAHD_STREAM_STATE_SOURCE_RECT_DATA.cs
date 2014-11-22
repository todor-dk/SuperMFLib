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
    /// Specifies the source rectangle for an input stream when using Microsoft DirectX Video Acceleration
    /// High Definition (DXVA-HD)
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_STREAM_STATE_SOURCE_RECT_DATA {
    ///   BOOL Enable;
    ///   RECT SourceRect;
    /// } DXVAHD_STREAM_STATE_SOURCE_RECT_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/51F2CFE6-722B-4273-ABF6-E1B8FDEC9808(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/51F2CFE6-722B-4273-ABF6-E1B8FDEC9808(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_STREAM_STATE_SOURCE_RECT_DATA")]
    public struct DXVAHD_STREAM_STATE_SOURCE_RECT_DATA
    {
        /// <summary>
        /// <strong></strong>Specifies whether to blit the entire input surface or just the source rectangle.
        /// The default state value is <strong>FALSE</strong>. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>TRUE</strong></term><description>Use the source rectangle specified in the <strong>SourceRect</strong> member. </description></item>
        /// <item><term><strong>FALSE</strong></term><description>Blit the entire input surface. Ignore the <strong>SourceRect</strong> member. </description></item>
        /// </list>
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool Enable;
        /// <summary>
        /// The <em>source rectangle</em>, which defines the portion of the input sample that is blitted to the
        /// destination surface. The source rectangle is given in pixel coordinates, relative to the input
        /// surface. The default state value is an empty rectangle, (0, 0, 0, 0). 
        /// <para/>
        /// If the <strong>Enable</strong> member is <strong>FALSE</strong>, the <strong>SourceRect</strong>
        /// member is ignored. 
        /// </summary>
        public MFRect SourceRect;
    }

#endif

}
