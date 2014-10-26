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
    /// CGMS-A Protection Flags.
    /// <para/>
    /// The constants in the following table specify the protection levels for Copy Generation Management
    /// System—Analog (CGMS-A).
    /// <para/>
    /// </summary>
    /// <remarks>
    /// These flags are equivalent to the <strong>COPP_CGMSA_Protection_Level</strong> enumeration
    /// constants used in the Certified Output Protection Protocol (COPP). 
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/739E2F9E-B8F1-4EE1-8706-9A069773A3DE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/739E2F9E-B8F1-4EE1-8706-9A069773A3DE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public enum f
    {
        /// <summary>
        /// CGMS-A is disabled. 
        /// </summary>
        OPM_CGMSA_OFF = 0,
        /// <summary>
        /// The protection level is Copy Freely.
        /// </summary>
        OPM_CGMSA_COPY_FREELY = 0x1,
        /// <summary>
        /// The protection level is Copy No More. 
        /// </summary>
        OPM_CGMSA_COPY_NO_MORE = 0x2,
        /// <summary>
        /// The protection level is Copy One Generation. 
        /// </summary>
        OPM_CGMSA_COPY_ONE_GENERATION = 0x3,
        /// <summary>
        /// The protection level is Copy Never.
        /// </summary>
        OPM_CGMSA_COPY_NEVER = 0x4,
        /// <summary>
        /// Redistribution control (also called the broadcast flag) is required. 
        /// This flag can be combined with the other flags.
        /// </summary>
        OPM_CGMSA_REDISTRIBUTION_CONTROL_REQUIRED = 0x8
    }

#endif

}
