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


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("F88CFB8C-EF16-4991-B450-CB8C69E51704"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMetadata
    {
        [PreserveSig]
        int SetLanguage(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszRFC1766
            );

        [PreserveSig]
        int GetLanguage(
            [MarshalAs(UnmanagedType.LPWStr)] out string ppwszRFC1766
            );

        [PreserveSig]
        int GetAllLanguages(
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant ppvLanguages
            );

        [PreserveSig]
        int SetProperty(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszName,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant ppvValue
            );

        [PreserveSig]
        int GetProperty(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszName,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant ppvValue
            );

        [PreserveSig]
        int DeleteProperty(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszName
            );

        [PreserveSig]
        int GetAllPropertyNames(
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant ppvNames
            );
    }

}
