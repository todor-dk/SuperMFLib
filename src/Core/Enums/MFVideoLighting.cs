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
    /// Describes the optimal lighting for viewing a particular set of video content.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/2EECA357-B7E2-40B1-B19F-2E12A833C1CA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2EECA357-B7E2-40B1-B19F-2E12A833C1CA(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFVideoLighting")]
    public enum MFVideoLighting
    {
        /// <summary>
        /// Bright lighting; for example, outdoors.
        /// </summary>
        Bright = 1,

        /// <summary>
        /// Dark; for example, a movie theater.
        /// </summary>
        Dark = 4,

        /// <summary>
        /// Dim; for example, a living room with a television and additional low lighting.
        /// </summary>
        Dim = 3,

        /// <summary>
        /// Reserved. This member forces the enumeration type to compile as a <strong>DWORD</strong> value.
        /// </summary>
        ForceDWORD = 0x7fffffff,

        /// <summary>
        /// Reserved.
        /// </summary>
        Last = 5,

        /// <summary>
        /// Medium brightness; for example, normal office lighting.
        /// </summary>
        Office = 2,

        /// <summary>
        /// The optimal lighting is unknown.
        /// </summary>
        Unknown = 0
    }
}
