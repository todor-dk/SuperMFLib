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

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("eb533d5d-2db6-40f8-97a9-494692014f07"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFDXGIDeviceManager
    {
        [PreserveSig]
        int CloseDeviceHandle(
            IntPtr hDevice
        );

        [PreserveSig]
        int GetVideoService(
            IntPtr hDevice,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppService
        );

        [PreserveSig]
        int LockDevice(
            IntPtr hDevice,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppUnkDevice,
            [MarshalAs(UnmanagedType.Bool)] bool fBlock
        );

        [PreserveSig]
        int OpenDeviceHandle(
            out IntPtr phDevice
        );

        [PreserveSig]
        int ResetDevice(
            [MarshalAs(UnmanagedType.IUnknown)] object pUnkDevice,
            int resetToken
        );

        [PreserveSig]
        int TestDevice(
            IntPtr hDevice
        );

        [PreserveSig]
        int UnlockDevice(
            IntPtr hDevice,
            [MarshalAs(UnmanagedType.Bool)]  bool fSaveState
        );
    }

#endif

}
