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
    /// Specifies the pixel aspect ratio (PAR) for the source and destination rectangles.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_STREAM_STATE_ASPECT_RATIO_DATA {
    ///   BOOL            Enable;
    ///   DXVAHD_RATIONAL SourceAspectRatio;
    ///   DXVAHD_RATIONAL DestinationAspectRatio;
    /// } DXVAHD_STREAM_STATE_ASPECT_RATIO_DATA, *PDXVAHD_STREAM_STATE_ASPECT_RATIO_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/DD7AB16E-2DC6-462E-B55D-B93A14C362CF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DD7AB16E-2DC6-462E-B55D-B93A14C362CF(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_STREAM_STATE_ASPECT_RATIO_DATA")]
    internal struct DXVAHD_STREAM_STATE_ASPECT_RATIO_DATA
    {
        /// <summary>
        /// <strong>If TRUE</strong>, the <strong>SourceAspectRatio</strong> and <strong>DestinationAspectRatio
        /// </strong> members contain valid values <strong></strong>. Otherwise, the pixel aspect ratios are
        /// unspecified. 
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool Enable;
        /// <summary>
        /// A <see cref="dxvahd.DXVAHD_RATIONAL"/> structure that contains the source PAR. The default state
        /// value is 1:1 (square pixels). 
        /// </summary>
        public DXVAHD_RATIONAL SourceAspectRatio;
        /// <summary>
        /// A <see cref="dxvahd.DXVAHD_RATIONAL"/> structure that contains the destination PAR. The default
        /// state value is 1:1 (square pixels). 
        /// </summary>
        public DXVAHD_RATIONAL DestinationAspectRatio;
    }

#endif

}
