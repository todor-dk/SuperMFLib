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

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("24E0485F-A33E-4aa1-B564-6019B1D14F65"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAdvancedMediaCaptureSettings
    {
        [PreserveSig]
        int GetDirectxDeviceManager(
            out IMFDXGIDeviceManager value
            );

        [PreserveSig]
        int SetDirectCompositionVisual(
            [MarshalAs(UnmanagedType.IUnknown)] object value
            );

        [PreserveSig]
        int UpdateVideo(
             [In] MfFloat pSrcNormalizedTop,
             [In] MfFloat pSrcNormalizedBottom,
             [In] MfFloat pSrcNormalizedRight,
             [In] MfFloat pSrcNormalizedLeft,
             [In] MFRect pDstSize,
             [In] MFInt pBorderClr
            );
    }

#endif

}
