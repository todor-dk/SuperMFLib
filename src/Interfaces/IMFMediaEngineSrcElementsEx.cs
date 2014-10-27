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
using System.Runtime.InteropServices;

using MediaFoundation.Misc;
using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation
{
#if ALLOW_UNTESTED_INTERFACES

    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
        Guid("654a6bb3-e1a3-424a-9908-53a43a0dfda0"),
        InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaEngineSrcElementsEx : IMFMediaEngineSrcElements
    {
        #region IMFMediaEngineSrcElements methods

        [PreserveSig]
        new int GetLength();

        [PreserveSig]
        new int GetURL(
            int index,
            [MarshalAs(UnmanagedType.BStr)] out string pURL
            );

        [PreserveSig]
        new int GetType(
            int index,
            [MarshalAs(UnmanagedType.BStr)] out string pType
            );

        [PreserveSig]
        new int GetMedia(
            int index,
            [MarshalAs(UnmanagedType.BStr)] out string pMedia
            );

        [PreserveSig]
        new int AddElement(
            [MarshalAs(UnmanagedType.BStr)] string pURL,
            [MarshalAs(UnmanagedType.BStr)] string pType,
            [MarshalAs(UnmanagedType.BStr)] string pMedia
            );

        [PreserveSig]
        new int RemoveAllElements();

        #endregion

        [PreserveSig]
        int AddElementEx(
            [MarshalAs(UnmanagedType.BStr)] string pURL,
            [MarshalAs(UnmanagedType.BStr)] string pType,
            [MarshalAs(UnmanagedType.BStr)] string pMedia,
            [MarshalAs(UnmanagedType.BStr)] string keySystem
            );

        [PreserveSig]
        int GetKeySystem(
            int index,
            [MarshalAs(UnmanagedType.BStr)] out string pType
            );
    }

#endif
}