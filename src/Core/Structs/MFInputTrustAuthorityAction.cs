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
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation.Core.Structs
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Describes an action requested by an output trust authority (OTA). The request is sent to an input
    /// trust authority (ITA).
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MFINPUTTRUSTAUTHORITY_ACTION {
    ///   MFPOLICYMANAGER_ACTION Action;
    ///   BYTE                   *pbTicket;
    ///   DWORD                  cbTicket;
    /// } MFINPUTTRUSTAUTHORITY_ACCESS_ACTION;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/24E74739-054C-46EF-8DF7-B29A9A2EA94A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/24E74739-054C-46EF-8DF7-B29A9A2EA94A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MFINPUTTRUSTAUTHORITY_ACCESS_ACTION")]
    internal struct MFInputTrustAuthorityAction
    {
        /// <summary>
        /// Specifies the action as a member of the <c>MFPOLICYMANAGER_ACTION</c> enumeration.
        /// </summary>
        public MFPolicyManagerAction Action;
        /// <summary>
        /// Pointer to a buffer that contains a ticket object, provided by the OTA.
        /// </summary>
        public IntPtr pbTicket;
        /// <summary>
        /// Size of the ticket object, in bytes.
        /// </summary>
        public int cbTicket;
    }

#endif

}
