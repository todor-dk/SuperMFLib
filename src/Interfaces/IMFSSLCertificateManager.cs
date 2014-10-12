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
    Guid("61F7D887-1230-4A8B-AEBA-8AD434D1A64D")]
    public interface IMFSSLCertificateManager
    {
        [PreserveSig]
        int GetClientCertificate(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl,
            [Out] IntPtr ppbData,
            out int pcbData
        );

        [PreserveSig]
        int BeginGetClientCertificate(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl,
            IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pState
        );

        [PreserveSig]
        int EndGetClientCertificate(
            IMFAsyncResult pResult,
            [Out] IntPtr ppbData,
            out int pcbData
        );

        [PreserveSig]
        int GetCertificatePolicy(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl,
            [MarshalAs(UnmanagedType.Bool)] out bool pfOverrideAutomaticCheck,
            [MarshalAs(UnmanagedType.Bool)] out bool pfClientCertificateAvailable
        );

        [PreserveSig]
        int OnServerCertificate(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl,
            [In] IntPtr pbData,
            [In] int cbData,
            [MarshalAs(UnmanagedType.Bool)] out bool pfIsGood
        );
    }

#endif

}
