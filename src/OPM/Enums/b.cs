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
    /// OPM Status Flags.
    /// <para/>
    /// The flags in the following table specify the status of an Output Protection Manager (OPM) session.
    /// <para/>
    /// </summary>
    /// <remarks>
    /// Some of these constants are equivalent to values from the <strong>COPP_StatusFlags</strong>
    /// enumeration used in Certified Output Protection Protocol (COPP). 
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D6D85FD4-E735-4610-93E0-BB2B1782F11B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D6D85FD4-E735-4610-93E0-BB2B1782F11B(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public enum b
    {
        /// <summary>
        /// Normal status.
        /// </summary>
        OPM_STATUS_NORMAL = 0,
        /// <summary>
        /// The integrity of the connection has been compromised. 
        /// Examples of events that cause the driver to set this flag include:
        /// <list type="bullet">
        /// <item><description>The driver can no longer enforce the current protection level.</description></item>
        /// <item><description>The driver detected an internal integrity error.</description></item>
        /// <item><description>The connector between the computer and the display device was unplugged.</description></item>
        /// </list>
        /// </summary>
        OPM_STATUS_LINK_LOST = 0x1,
        /// <summary>
        /// The connection configuration has changed. For example, 
        /// the user has changed the desktop display mode.
        /// </summary>
        OPM_STATUS_RENEGOTIATION_REQUIRED = 0x2,
        /// <summary>
        /// The graphics adapter or the driver has been tampered with.
        /// <para/>
        /// This flag is not used in COPP emulation mode. Instead, the video output 
        /// will set the OPM_STATUS_LINK_LOST flag if it detects tampering.
        /// </summary>
        OPM_STATUS_TAMPERING_DETECTED = 0x4,
        /// <summary>
        /// A revoked High-Bandwidth Digital Content Protection (HDCP) device is attached to the video output.
        /// <para/>
        /// This status flag can be returned from an OPM_GET_VIRTUAL_PROTECTION_LEVEL or OPM_GET_ACTUAL_PROTECTION_LEVEL query. 
        /// <para/>
        /// The revoked device might be attached directly to the video output, or indirectly through an HDCP repeater. 
        /// A video output is required to detect this condition while HDCP is enabled, but not otherwise.
        /// <para/>
        /// This flag is not used in COPP emulation mode, because the video output does not detect revoked devices in that mode.
        /// </summary>
        OPM_STATUS_REVOKED_HDCP_DEVICE_ATTACHED = 0x8
    }

#endif

}
