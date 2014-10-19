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
    /// Contains the result from an
    /// <see cref="OPM.MFOpmStatusRequests.OPM_GET_CONNECTED_HDCP_DEVICE_INFORMATION" /> query.
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _OPM_CONNECTED_HDCP_DEVICE_INFORMATION {
    ///   OPM_RANDOM_NUMBER             rnRandomNumber;
    ///   ULONG                         ulStatusFlags;
    ///   ULONG                         ulHDCPFlags;
    ///   OPM_HDCP_KEY_SELECTION_VECTOR ksvB;
    ///   BYTE                          Reserved[11];
    ///   BYTE                          Reserved2[16];
    ///   BYTE                          Reserved3[16];
    /// } OPM_CONNECTED_HDCP_DEVICE_INFORMATION;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1FB59959-782B-44E8-81B1-ECA3C32A0783(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1FB59959-782B-44E8-81B1-ECA3C32A0783(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public struct OPM_CONNECTED_HDCP_DEVICE_INFORMATION
    {
        /// <summary>
        /// An <see cref="OPM.OPM_RANDOM_NUMBER" /> structure. This structure contains the same 128-bit random
        /// number that the application sent to the driver in the <see cref="OPM.OPM_GET_INFO_PARAMETERS" /> or
        /// <see cref="OPM.OPM_COPP_COMPATIBLE_GET_INFO_PARAMETERS" /> structure.
        /// </summary>
        public OPM_RANDOM_NUMBER rnRandomNumber;
        /// <summary>
        /// A bitwise <strong>OR</strong> of <c>OPM Status Flags</c>.
        /// </summary>
        public int ulStatusFlags;
        /// <summary>
        /// A value that indicates whether the connected device is an HDCP repeater.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term><strong>OPM_HDCP_FLAG_NONE</strong>0x00</term><description>The device is not an HDCP repeater.</description></item><item><term><strong>OPM_HDCP_FLAG_REPEATER</strong>0x01</term><description>The device is an HDCP repeater.</description></item></list>
        /// </summary>
        public int ulHDCPFlags;
        /// <summary>
        /// An <see cref="OPM.OPM_HDCP_KEY_SELECTION_VECTOR" /> structure that contains the device's key
        /// selection vector (KSV). This is the value named <em>Bksv</em> in the HDCP specification.
        /// </summary>
        public OPM_HDCP_KEY_SELECTION_VECTOR ksvB;
        /// <summary>
        /// Reserved for future use. Fill this array with zeros.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
        public byte[] Reserved;
        /// <summary>
        /// Reserved for future use. Fill this array with zeros.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] Reserved2;
        /// <summary>
        /// Reserved for future use. Fill this array with zeros.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] Reserved3;
    }

#endif

}
