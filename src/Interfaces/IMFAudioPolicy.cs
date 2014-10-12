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
    Guid("A0638C2B-6465-4395-9AE7-A321A9FD2856")]
    public interface IMFAudioPolicy
    {
        [PreserveSig]
        int SetGroupingParam(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid rguidClass
            );

        [PreserveSig]
        int GetGroupingParam(
            out Guid pguidClass
            );

        [PreserveSig]
        int SetDisplayName(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszName
            );

        [PreserveSig]
        int GetDisplayName(
            [MarshalAs(UnmanagedType.LPWStr)] out string pszName
            );

        [PreserveSig]
        int SetIconPath(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszPath
            );

        [PreserveSig]
        int GetIconPath(
            [MarshalAs(UnmanagedType.LPWStr)] out string pszPath
            );
    }

#endif

}
