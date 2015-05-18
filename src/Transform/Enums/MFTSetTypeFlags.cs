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
    /// Defines flags for the setting or testing the media type on a Media Foundation transform (MFT).
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/DD7E97FB-80AB-4E6B-AC2A-A257D7E8EC63(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DD7E97FB-80AB-4E6B-AC2A-A257D7E8EC63(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("_MFT_SET_TYPE_FLAGS")]
    internal enum MFTSetTypeFlags
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// Test the proposed media type, but do not set it.
        /// </summary>
        TestOnly = 0x00000001
    }

#endif
}
