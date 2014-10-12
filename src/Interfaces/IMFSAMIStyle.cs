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
    Guid("A7E025DD-5303-4A62-89D6-E747E1EFAC73"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFSAMIStyle
    {
        [PreserveSig]
        int GetStyleCount(
            out int pdwCount
            );

        [PreserveSig]
        int GetStyles(
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pPropVarStyleArray
            );

        [PreserveSig]
        int SetSelectedStyle(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszStyle
            );

        [PreserveSig]
        int GetSelectedStyle(
            [MarshalAs(UnmanagedType.LPWStr)] out string ppwszStyle
            );
    }

#endif

}
