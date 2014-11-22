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
    /// Specifies the planar alpha value for an input stream, when using Microsoft DirectX Video
    /// Acceleration High Definition (DXVA-HD).
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_STREAM_STATE_ALPHA_DATA {
    ///   BOOL  Enable;
    ///   FLOAT Alpha;
    /// } DXVAHD_STREAM_STATE_ALPHA_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/51135D6E-4F97-44D9-B1D5-F7D2095EE6F1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/51135D6E-4F97-44D9-B1D5-F7D2095EE6F1(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_STREAM_STATE_ALPHA_DATA")]
    public struct DXVAHD_STREAM_STATE_ALPHA_DATA
    {
        /// <summary>
        /// <strong>If TRUE</strong>, alpha blending is enabled. Otherwise, alpha blending is disabled. The
        /// default state value is <strong>FALSE</strong>. 
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool Enable;
        /// <summary>
        /// Specifies the planar alpha value as a floating-point number from 0.0 (transparent) to 1.0 (opaque).
        /// <para/>
        /// If the <strong>Enable</strong> member is <strong>FALSE</strong>, this member is ignored. 
        /// </summary>
        public float Alpha;
    }

#endif

}
