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

// This file is a mess.  While technically part of MF, I'm in no hurry 
// to try to get this to work.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MediaFoundation.OPM
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Specifies the protection level for Analog Copy Protection (ACP).
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F52B4EE6-1AB3-4153-86E3-5AE69FD8A958(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F52B4EE6-1AB3-4153-86E3-5AE69FD8A958(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public enum OPM_ACP_PROTECTION_LEVEL
    {
        /// <summary>
        /// ACP is disabled.
        /// </summary>
        OPM_ACP_OFF = 0,
        /// <summary>
        /// ACP protection level 1.
        /// </summary>
        OPM_ACP_LEVEL_ONE = 1,
        /// <summary>
        /// ACP protection level 2.
        /// </summary>
        OPM_ACP_LEVEL_TWO = 2,
        /// <summary>
        /// ACP protection level 3.
        /// </summary>
        OPM_ACP_LEVEL_THREE = 3,
        /// <summary>
        /// Reserved.
        /// </summary>
        OPM_ACP_FORCE_ULONG = 0x7fffffff
    }

#endif

}
