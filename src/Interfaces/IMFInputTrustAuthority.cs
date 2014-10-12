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

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("D19F8E98-B126-4446-890C-5DCB7AD71453"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFInputTrustAuthority
    {
        [PreserveSig]
        int GetDecrypter(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.Interface)] out object ppv
            );

        [PreserveSig]
        int RequestAccess(
            [In] MFPolicyManagerAction Action,
            [MarshalAs(UnmanagedType.Interface)] out IMFActivate ppContentEnablerActivate
            );

        [PreserveSig]
        int GetPolicy(
            [In] MFPolicyManagerAction Action,
            [MarshalAs(UnmanagedType.Interface)] out IMFOutputPolicy ppPolicy
            );

        [PreserveSig]
        int BindAccess(
            [In] ref MFInputTrustAuthorityAccessParams pParam
            );

        [PreserveSig]
        int UpdateAccess(
            [In] ref MFInputTrustAuthorityAccessParams pParam
            );

        [PreserveSig]
        int Reset();
    }

#endif

}
