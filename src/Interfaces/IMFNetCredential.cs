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
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("5B87EF6A-7ED8-434F-BA0E-184FAC1628D1")]
    public interface IMFNetCredential
    {
        [PreserveSig]
        int SetUser(
            [In] ref byte pbData,
            [In] int cbData,
            [In] int fDataIsEncrypted
            );

        [PreserveSig]
        int SetPassword(
            [In] ref byte pbData,
            [In] int cbData,
            [In] int fDataIsEncrypted
            );

        [PreserveSig]
        int GetUser(
            out byte pbData,
            [In, Out] ref int pcbData,
            [In] int fEncryptData
            );

        [PreserveSig]
        int GetPassword(
            out byte pbData,
            [In, Out] ref int pcbData,
            [In, MarshalAs(UnmanagedType.Bool)] bool fEncryptData
            );

        [PreserveSig]
        int LoggedOnUser(
            [MarshalAs(UnmanagedType.Bool)] out bool pfLoggedOnUser
            );
    }

#endif

}
