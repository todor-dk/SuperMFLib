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
    Guid("33ae5ea6-4316-436f-8ddd-d73d22f829ec"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMF2DBuffer2 : IMF2DBuffer
    {
        #region IMF2DBuffer Methods

        [PreserveSig]
        new int Lock2D(
            [Out] out IntPtr pbScanline0,
            out int plPitch
            );

        [PreserveSig]
        new int Unlock2D();

        [PreserveSig]
        new int GetScanline0AndPitch(
            out IntPtr pbScanline0,
            out int plPitch
            );

        [PreserveSig]
        new int IsContiguousFormat(
            [MarshalAs(UnmanagedType.Bool)] out bool pfIsContiguous
            );

        [PreserveSig]
        new int GetContiguousLength(
            out int pcbLength
            );

        [PreserveSig]
        new int ContiguousCopyTo(
            IntPtr pbDestBuffer,
            [In] int cbDestBuffer
            );

        [PreserveSig]
        new int ContiguousCopyFrom(
            [In] IntPtr pbSrcBuffer,
            [In] int cbSrcBuffer
            );

#endregion

        [PreserveSig]
        int Lock2DSize(
            MF2DBuffer_LockFlags lockFlags,
            out IntPtr ppbScanline0,
            out int plPitch,
            out IntPtr ppbBufferStart,
            out int pcbBufferLength
        );

        [PreserveSig]
        int Copy2DTo(
            IMF2DBuffer2 pDestBuffer
        );
    }

#endif

}
