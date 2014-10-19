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
    /// Contains the result of an <c>Output Protection Manager</c> (OPM) status request.
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _OPM_REQUESTED_INFORMATION {
    ///   OPM_OMAC omac;
    ///   ULONG    cbRequestedInformationSize;
    ///   BYTE     abRequestedInformation[OPM_REQUESTED_INFORMATION_SIZE];
    /// } OPM_REQUESTED_INFORMATION;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/84FFA808-1BDB-47C8-A18C-6DFA6FCF90DE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/84FFA808-1BDB-47C8-A18C-6DFA6FCF90DE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public struct OPM_REQUESTED_INFORMATION
    {
        /// <summary>
        /// An <see cref="OPM.OPM_OMAC" /> structure that contains a Message Authentication Code (MAC) of the
        /// status data. The driver will use AES-based one-key CBC MAC (OMAC) to calculate this value.
        /// </summary>
        public OPM_OMAC omac;
        /// <summary>
        /// The size of the valid data in the <strong>abRequestedInformation</strong> member, in bytes.
        /// </summary>
        public int cbRequestedInformationSize;
        /// <summary>
        /// A buffer that contains the result of the status request. The meaning of the data depends on the
        /// status request. For more information, see <c>OPM Status Requests</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4076)]
        public byte[] abRequestedInformation;
    }

#endif

}
