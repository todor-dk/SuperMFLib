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
    /// Specifies the protection level for DisplayPort Content Protection (DPCP).
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C761F3C1-F18E-4AE9-9AA1-1BA440A6C8DF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C761F3C1-F18E-4AE9-9AA1-1BA440A6C8DF(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public enum OPM_DPCP_PROTECTION_LEVEL
    {
        /// <summary>
        /// DPCP is disabled.
        /// </summary>
        OPM_DPCP_OFF = 0,
        /// <summary>
        /// DPCP is enabled.
        /// </summary>
        OPM_DPCP_ON = 1,
        /// <summary>
        /// Reserved.
        /// </summary>
        OPM_DPCP_FORCE_ULONG = 0x7fffffff
    }

#endif

}
