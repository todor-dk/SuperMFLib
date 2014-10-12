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
    Guid("E9CD0383-A268-4BB4-82DE-658D53574D41")]
    public interface IMFNetProxyLocator
    {
        [PreserveSig]
        int FindFirstProxy(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszHost,
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl,
            [In, MarshalAs(UnmanagedType.Bool)] bool fReserved
            );

        [PreserveSig]
        int FindNextProxy();

        [PreserveSig]
        int RegisterProxyResult(
            [In, MarshalAs(UnmanagedType.Error)] int hrOp
            );

        [PreserveSig]
        int GetCurrentProxy(
            [Out, MarshalAs(UnmanagedType.LPWStr)] string pszStr,
            [In, Out] ref int pcchStr
            );

        [PreserveSig]
        int Clone(
            [MarshalAs(UnmanagedType.Interface)] out IMFNetProxyLocator ppProxyLocator
            );
    }

#endif

}
