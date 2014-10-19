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

namespace MediaFoundation
{


    /// <summary>
    /// Describes the conversion matrices between Y'PbPr (component video) and studio R'G'B'.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/08A05EE8-B053-4480-B7F9-6D96E541CCD9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/08A05EE8-B053-4480-B7F9-6D96E541CCD9(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFVideoTransferMatrix")]
    public enum MFVideoTransferMatrix
    {
        /// <summary>
        /// ITU-R BT.601 transfer matrix. Also used for SMPTE 170 and ITU-R BT.470-2 System B,G.
        /// </summary>
        BT601 = 2,
        /// <summary>
        /// ITU-R BT.709 transfer matrix.
        /// </summary>
        BT709 = 1,
        /// <summary>
        /// Reserved. This member forces the enumeration type to compile as a <strong>DWORD</strong> value. 
        /// </summary>
        ForceDWORD = 0x7fffffff,
        /// <summary>
        /// Reserved.
        /// </summary>
        Last = 4,
        /// <summary>
        /// SMPTE 240M transfer matrix.
        /// </summary>
        SMPTE240M = 3,
        /// <summary>
        /// Unknown transfer matrix. Treat as MFVideoTransferMatrix_BT709.
        /// </summary>
        Unknown = 0
    }

}
