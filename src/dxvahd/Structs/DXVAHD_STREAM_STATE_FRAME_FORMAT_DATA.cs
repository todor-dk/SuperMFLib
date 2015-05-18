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
    /// Specifies how a Microsoft DirectX Video Acceleration High Definition (DXVA-HD) input stream is
    /// interlaced.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_STREAM_STATE_FRAME_FORMAT_DATA {
    ///   DXVAHD_FRAME_FORMAT FrameFormat;
    /// } DXVAHD_STREAM_STATE_FRAME_FORMAT_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/4FA6A7F7-DF9F-4E38-884C-81A01F913DF0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4FA6A7F7-DF9F-4E38-884C-81A01F913DF0(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_STREAM_STATE_FRAME_FORMAT_DATA")]
    internal struct DXVAHD_STREAM_STATE_FRAME_FORMAT_DATA
    {
        /// <summary>
        /// The video interlacing, specified as a <see cref="dxvahd.DXVAHD_FRAME_FORMAT"/> value. 
        /// <para/>
        /// The default state value is <strong>DXVAHD_FRAME_FORMAT_PROGRESSIVE</strong> (progressive frames). 
        /// </summary>
        public DXVAHD_FRAME_FORMAT FrameFormat;
    }

#endif

}
