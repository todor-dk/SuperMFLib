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
        Guid("5cb31c05-61ff-418f-afda-caaf41421a38"),
        InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaKeys
    {
        [PreserveSig]
        int CreateSession(
           [MarshalAs(UnmanagedType.BStr)] string mimeType,
           IntPtr initData,
           int cb,
           IntPtr customData,
           int cbCustomData,
           IMFMediaKeySessionNotify notify,
           out IMFMediaKeySession ppSession
           );

        [PreserveSig]
        int get_KeySystem(
           [MarshalAs(UnmanagedType.BStr)] out string keySystem
           );

        [PreserveSig]
        int Shutdown();

        [PreserveSig]
        int GetSuspendNotify(
           out IMFCdmSuspendNotify notify
           );
    }

#endif
}