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
using System.Text;
using System.Runtime.InteropServices;

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.Core.Enums
{


    /// <summary>
    /// Specifies how a video stream is interlaced.
    /// <para/>
    /// In the descriptions that follow, upper field refers to the field that contains the leading half
    /// scan line. Lower field refers to the field that contains the first full scan line.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/10A3D7B1-74ED-46CD-B10E-59A8F01726D5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/10A3D7B1-74ED-46CD-B10E-59A8F01726D5(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFVideoInterlaceMode")]
    internal enum MFVideoInterlaceMode
    {
        /// <summary>
        /// Interlaced frames. Each frame contains two fields. The field lines are interleaved, with the lower
        /// field appearing on the first line. 
        /// </summary>
        FieldInterleavedLowerFirst = 4,
        /// <summary>
        /// Interlaced frames. Each frame contains two fields. The field lines are interleaved, with the upper
        /// field appearing on the first line. 
        /// </summary>
        FieldInterleavedUpperFirst = 3,
        /// <summary>
        /// Interlaced frames. Each frame contains one field, with the lower field appearing first. 
        /// </summary>
        FieldSingleLower = 6,
        /// <summary>
        /// Interlaced frames. Each frame contains one field, with the upper field appearing first. 
        /// </summary>
        FieldSingleUpper = 5,
        /// <summary>
        /// Reserved. This member forces the enumeration type to compile as a <strong>DWORD</strong> value. 
        /// </summary>
        ForceDWORD = 0x7fffffff,
        /// <summary>
        /// Reserved. 
        /// </summary>
        Last = 8,
        /// <summary>
        /// The stream contains a mix of interlaced and progressive modes. 
        /// </summary>
        MixedInterlaceOrProgressive = 7,
        /// <summary>
        /// Progressive frames. 
        /// </summary>
        Progressive = 2,
        /// <summary>
        /// The type of interlacing is not known. 
        /// </summary>
        Unknown = 0
    }

}
