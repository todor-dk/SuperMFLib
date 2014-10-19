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
    /// Contains parameters for the <see cref="OPM.IOPMVideoOutput.GetInformation" /> method.
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _OPM_GET_INFO_PARAMETERS {
    ///   OPM_OMAC          omac;
    ///   OPM_RANDOM_NUMBER rnRandomNumber;
    ///   GUID              guidInformation;
    ///   ULONG             ulSequenceNumber;
    ///   ULONG             cbParametersSize;
    ///   BYTE              abParameters[OPM_GET_INFORMATION_PARAMETERS_SIZE];
    /// } OPM_GET_INFO_PARAMETERS;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8959C7D1-9A78-497F-8841-D3E61E9DB6A3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8959C7D1-9A78-497F-8841-D3E61E9DB6A3(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public struct OPM_GET_INFO_PARAMETERS
    {
        /// <summary>
        /// An <see cref="OPM.OPM_OMAC" /> structure that contains a message authentication code (MAC) for the
        /// data in the rest of the structure.
        /// </summary>
        public OPM_OMAC omac;
        /// <summary>
        /// An <see cref="OPM.OPM_RANDOM_NUMBER" /> structure that contains a cryptographically secure 128-bit
        /// random number.
        /// </summary>
        public OPM_RANDOM_NUMBER rnRandomNumber;
        /// <summary>
        /// A GUID that defines the status request. For more information, see <c>OPM Status Requests</c>.
        /// </summary>
        public Guid guidInformation;
        /// <summary>
        /// The status sequence number. The application must keep a running count of status requests. For each
        /// request, increment the sequence number by 1.
        /// <para />
        /// On the first call to <c>GetInformation</c>, set <strong>ulSequenceNumber</strong> equal to the
        /// starting status sequence number, which is specified when the application calls
        /// <see cref="OPM.IOPMVideoOutput.FinishInitialization" />. On each subsequent call, increment <strong>
        /// ulSequenceNumber</strong> by 1.
        /// <para />
        /// Exception: If the status request fails, do not increment the sequence number. Instead, re-use the
        /// same number for the next status request.
        /// </summary>
        public int ulSequenceNumber;
        /// <summary>
        /// The number of bytes of valid data in the <strong>abParameters</strong> member.
        /// </summary>
        public int cbParametersSize;
        /// <summary>
        /// The data for the status request. The meaning of the data depends on the request. For more
        /// information, see <c>OPM Status Requests</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4056)]
        public byte[] abParameters;
    }

#endif

}
