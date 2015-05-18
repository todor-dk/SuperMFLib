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

namespace MediaFoundation.dxvahd.Enums
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Specifies the type of video surface created by a Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD) device.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/06DF2D2F-9163-4672-8EA4-57F1942320C5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/06DF2D2F-9163-4672-8EA4-57F1942320C5(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("DXVAHD_SURFACE_TYPE")]
    internal enum DXVAHD_SURFACE_TYPE
    {
        /// <summary>
        /// A surface for an input stream. This surface type is equivalent to an off-screen plain surface in
        /// Microsoft Direct3D. The application can use the surface in Direct3D calls.
        /// </summary>
        VideoInput = 0,
        /// <summary>
        /// A private surface for an input stream. This surface type is equivalent to an off-screen plain
        /// surface, except that the application cannot use the surface in Direct3D calls.
        /// </summary>
        VideoInputPrivate = 1,
        /// <summary>
        /// A surface for an output stream. This surface type is equivalent to an off-screen plain surface in
        /// Direct3D. The application can use the surface in Direct3D calls. 
        /// <para/>
        /// This surface type is recommended for video processing applications that need to lock the surface
        /// and access the surface memory. For video playback with optimal performance, a render-target surface
        /// or swap chain is recommended instead.
        /// </summary>
        VideoOutput = 2
    }

#endif

}
