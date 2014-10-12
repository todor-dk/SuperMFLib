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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.dxvahd
{

#if ALLOW_UNTESTED_INTERFACES


    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("95f12dfd-d77e-49be-815f-57d579634d6d"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDXVAHD_Device
    {
        [PreserveSig]
        int CreateVideoSurface(
            int Width,
            int Height,
            int Format, // D3DFORMAT 
            int Pool, // D3DPOOL
            int Usage,
            DXVAHD_SURFACE_TYPE Type,
            int NumSurfaces,
            out IDirect3DSurface9[] ppSurfaces,
            ref  IntPtr pSharedHandle
            );

        [PreserveSig]
        int GetVideoProcessorDeviceCaps(
            out DXVAHD_VPDEVCAPS pCaps
            );

        [PreserveSig]
        int GetVideoProcessorOutputFormats(
            int Count,
            out int[] pFormats // D3DFORMAT 
            );

        [PreserveSig]
        int GetVideoProcessorInputFormats(
            int Count,
            out int[] pFormats // D3DFORMAT 
            );

        [PreserveSig]
        int GetVideoProcessorCaps(
            int Count,
            out DXVAHD_VPCAPS[] pCaps
            );

        [PreserveSig]
        int GetVideoProcessorCustomRates(
            Guid pVPGuid,
            int Count,
            out DXVAHD_CUSTOM_RATE_DATA[] pRates
            );

        [PreserveSig]
        int GetVideoProcessorFilterRange(
            DXVAHD_FILTER Filter,
            out DXVAHD_FILTER_RANGE_DATA pRange
            );

        [PreserveSig]
        int CreateVideoProcessor(
            Guid pVPGuid,
            out IDXVAHD_VideoProcessor ppVideoProcessor
            );
    }

#endif

}
