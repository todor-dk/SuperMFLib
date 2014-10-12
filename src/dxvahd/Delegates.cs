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

    //DEFINE_GUID(DXVAHD_STREAM_STATE_PRIVATE_IVTC, 0x9c601e3c,0x0f33,0x414c,0xa7,0x39,0x99,0x54,0x0e,0xe4,0x2d,0xa5);

    public delegate int PDXVAHDSW_CreateDevice(
        IDirect3DDevice9Ex pD3DDevice,
        out IntPtr phDevice
        );

    public delegate int PDXVAHDSW_ProposeVideoPrivateFormat(
        IntPtr hDevice,
        ref int pFormat // D3DFORMAT
        );

    public delegate int PDXVAHDSW_GetVideoProcessorDeviceCaps(
        IntPtr hDevice,
        DXVAHD_CONTENT_DESC pContentDesc,
        DXVAHD_DEVICE_USAGE Usage,
        out DXVAHD_VPDEVCAPS pCaps
        );

    public delegate int PDXVAHDSW_GetVideoProcessorOutputFormats(
        IntPtr hDevice,
        DXVAHD_CONTENT_DESC pContentDesc,
        DXVAHD_DEVICE_USAGE Usage,
        int Count,
        int[] pFormats // D3DFORMAT
        );

    public delegate int PDXVAHDSW_GetVideoProcessorInputFormats(
        IntPtr hDevice,
        DXVAHD_CONTENT_DESC pContentDesc,
        DXVAHD_DEVICE_USAGE Usage,
        int Count,
        int[] pFormats // D3DFORMAT
        );

    public delegate int PDXVAHDSW_GetVideoProcessorCaps(
        IntPtr hDevice,
        DXVAHD_CONTENT_DESC pContentDesc,
        DXVAHD_DEVICE_USAGE Usage,
        int Count,
        DXVAHD_VPCAPS[] pCaps
        );

    public delegate int PDXVAHDSW_GetVideoProcessorCustomRates(
        IntPtr hDevice,
        Guid pVPGuid,
        int Count,
        DXVAHD_CUSTOM_RATE_DATA[] pRates
        );

    public delegate int PDXVAHDSW_GetVideoProcessorFilterRange(
        IntPtr hDevice,
        DXVAHD_FILTER Filter,
        out DXVAHD_FILTER_RANGE_DATA pRange
        );

    public delegate int PDXVAHDSW_DestroyDevice(
        IntPtr hDevice
        );

    public delegate int PDXVAHDSW_CreateVideoProcessor(
        IntPtr hDevice,
        Guid pVPGuid,
        out IntPtr phVideoProcessor
        );

    public delegate int PDXVAHDSW_SetVideoProcessBltState(
        IntPtr hVideoProcessor,
        DXVAHD_BLT_STATE State,
        int DataSize,
        IntPtr pData
        );

    public delegate int PDXVAHDSW_GetVideoProcessBltStatePrivate(
        IntPtr hVideoProcessor,
        ref DXVAHD_BLT_STATE_PRIVATE_DATA pData
        );

    public delegate int PDXVAHDSW_SetVideoProcessStreamState(
        IntPtr hVideoProcessor,
        int StreamNumber,
        DXVAHD_STREAM_STATE State,
        int DataSize,
        IntPtr pData
        );

    public delegate int PDXVAHDSW_GetVideoProcessStreamStatePrivate(
        IntPtr hVideoProcessor,
        int StreamNumber,
        ref DXVAHD_STREAM_STATE_PRIVATE_DATA pData
        );

    public delegate int PDXVAHDSW_VideoProcessBltHD(
        IntPtr hVideoProcessor,
        IDirect3DSurface9 pOutputSurface,
        int OutputFrame,
        int StreamCount,
        DXVAHD_STREAM_DATA[] pStreams
        );

    public delegate int PDXVAHDSW_DestroyVideoProcessor(
        IntPtr hVideoProcessor
        );

    public delegate int PDXVAHDSW_Plugin(
        int Size,
        IntPtr[] pCallbacks
        );

    //DEFINE_GUID(DXVAHDControlGuid, 0xa0386e75,0xf70c,0x464c,0xa9,0xce,0x33,0xc4,0x4e,0x09,0x16,0x23); 

    public delegate int PDXVAHD_CreateDevice(
        IDirect3DDevice9Ex pD3DDevice,
        DXVAHD_CONTENT_DESC pContentDesc,
        DXVAHD_DEVICE_USAGE Usage,
        PDXVAHDSW_Plugin pPlugin,
        out IDXVAHD_Device ppDevice
        );

#endif

}
