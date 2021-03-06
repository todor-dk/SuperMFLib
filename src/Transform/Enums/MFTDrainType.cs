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

using MediaFoundation.Misc;

namespace MediaFoundation.Transform.Enums
{
#if NOT_IN_USE

    /// <summary>
    /// Not supported.
    /// <para/>
    /// <strong>Note</strong> Earlier versions of this documentation described the <strong>_MFT_DRAIN_TYPE
    /// </strong> enumeration incorrectly. The enumeration is not supported. For more information, see 
    /// <see cref="Transform.MFTMessageType"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is � Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8243B154-BE93-4A81-9990-F022DC8CB736(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8243B154-BE93-4A81-9990-F022DC8CB736(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("_MFT_DRAIN_TYPE")]
    internal enum MFTDrainType
    {
        /// <summary>
        /// Reserved. 
        /// </summary>
        ProduceTails = 0x00000000,
        /// <summary>
        /// Reserved. 
        /// </summary>
        NoTails = 0x00000001
    }

#endif
}
