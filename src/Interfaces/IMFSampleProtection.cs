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
    Guid("8E36395F-C7B9-43C4-A54D-512B4AF63C95")]
    public interface IMFSampleProtection
    {
        [PreserveSig]
        int GetInputProtectionVersion(
            out int pdwVersion
            );

        [PreserveSig]
        int GetOutputProtectionVersion(
            out int pdwVersion
            );

        [PreserveSig]
        int GetProtectionCertificate(
            [In] int dwVersion,
            [Out] IntPtr ppCert,
            out int pcbCert
            );

        [PreserveSig]
        int InitOutputProtection(
            [In] int dwVersion,
            [In] int dwOutputId,
            [In] ref byte pbCert,
            [In] int cbCert,
            [Out] IntPtr ppbSeed,
            out int pcbSeed
            );

        [PreserveSig]
        int InitInputProtection(
            [In] int dwVersion,
            [In] int dwInputId,
            [In] ref byte pbSeed,
            [In] int cbSeed
            );
    }

#endif

}
