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

namespace MediaFoundation.dxvahd.Structs
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Specifies the destination rectangle for an input stream, when using Microsoft DirectX Video
    /// Acceleration High Definition (DXVA-HD).
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_STREAM_STATE_DESTINATION_RECT_DATA {
    ///   BOOL Enable;
    ///   RECT DestinationRect;
    /// } DXVAHD_STREAM_STATE_DESTINATION_RECT_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F850531B-EEE0-4943-8C41-050EC78EAB63(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F850531B-EEE0-4943-8C41-050EC78EAB63(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_STREAM_STATE_DESTINATION_RECT_DATA")]
    internal struct DXVAHD_STREAM_STATE_DESTINATION_RECT_DATA
    {
        /// <summary>
        /// Specifies whether to use the destination rectangle, or use the entire output surface. The default
        /// state value is <strong>FALSE</strong>. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>TRUE</strong></term><description>Use the destination rectangle given in the <strong>DestinationRect</strong> member. </description></item>
        /// <item><term><strong>FALSE</strong></term><description>Use the entire output surface as the destination rectangle.</description></item>
        /// </list>
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool Enable;
        /// <summary>
        /// The <em>destination rectangle</em>, which defines the portion of the output surface where the
        /// source rectangle is blitted. The destination rectangle is given in pixel coordinates, relative to
        /// the output surface. The default value is an empty rectangle, (0, 0, 0, 0). 
        /// <para/>
        /// If the <strong>Enable</strong> member is <strong>FALSE</strong>, the <strong>DestinationRect
        /// </strong> member is ignored. 
        /// </summary>
        public MFRect DestinationRect;
    }

#endif

}
