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
    /// Specifies the color space for a Microsoft DirectX Video Acceleration High Definition (DXVA-HD)
    /// input stream.
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _DXVAHD_STREAM_STATE_INPUT_COLOR_SPACE_DATA {
    ///   UINT Type  :1;
    ///   UINT RGB_Range  :1;
    ///   UINT YCbCr_Matrix  :1;
    ///   UINT YCbCr_xvYCC  :1;
    /// } DXVAHD_STREAM_STATE_INPUT_COLOR_SPACE_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/54B53E4D-990B-4496-AAE6-039F443337AE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/54B53E4D-990B-4496-AAE6-039F443337AE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_STREAM_STATE_INPUT_COLOR_SPACE_DATA")]
    public struct DXVAHD_STREAM_STATE_INPUT_COLOR_SPACE_DATA
    {
        public int Value;
    }

#endif

}
