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

namespace MediaFoundation.OPM.Enums
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// OPM Protection Type Flags.
    /// <para/>
    /// The flags in the following table specify output protection mechanisms for Output Protection Manager
    /// (OPM).
    /// <para/>
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/484DFEA9-301D-4B2B-B5D1-D785EBAA8C8F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/484DFEA9-301D-4B2B-B5D1-D785EBAA8C8F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    internal enum g
    {
        /// <summary>
        /// Unknown protection mechanism.
        /// </summary>
        OPM_PROTECTION_TYPE_OTHER = unchecked((int)0x80000000),
        /// <summary>
        /// No protection mechanisms.
        /// </summary>
        OPM_PROTECTION_TYPE_NONE = 0,
        /// <summary>
        /// High-Bandwidth Digital Content Protection (HDCP). 
        /// This flag is used when emulating Certified Output Protection Protocol (COPP). 
        /// For more information, see Remarks. This flag is not supported for OPM semantics.
        /// </summary>
        OPM_PROTECTION_TYPE_COPP_COMPATIBLE_HDCP = 0x1,
        /// <summary>
        /// Analog Copy Protection (ACP).
        /// </summary>
        OPM_PROTECTION_TYPE_ACP = 0x2,
        /// <summary>
        /// Copy Generation Management System—Analog (CGMS-A).
        /// </summary>
        OPM_PROTECTION_TYPE_CGMSA = 0x4,
        /// <summary>
        /// HDCP. This flag is used when the OPM object has OPM semantics. 
        /// It is not supported for COPP semantics.
        /// </summary>
        OPM_PROTECTION_TYPE_HDCP = 0x8,
        /// <summary>
        /// DisplayPort Content Protection (DPCP).
        /// </summary>
        OPM_PROTECTION_TYPE_DPCP = 0x10
    }

#endif

}
