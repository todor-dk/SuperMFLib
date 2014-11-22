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

    /// <summary>
    /// Creates an instance of a software plug-in Microsoft DirectX Video Acceleration High Definition
    /// (DXVA-HD) device.
    /// </summary>
    /// <param name="pD3DDevice">
    /// A pointer to the <strong>IDirect3DDevice9Ex</strong> interface of the Direct3D device. 
    /// </param>
    /// <param name="phDevice">
    /// Receives a handle to the plug-in DXVA-HD device.
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_CreateDevice)(
    ///   _In_   IDirect3DDevice9Ex *pD3DDevice,
    ///   _Out_  HANDLE *phDevice
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F76539C8-13A8-4608-87A6-4947F5DEBB02(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F76539C8-13A8-4608-87A6-4947F5DEBB02(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_CreateDevice(
        IDirect3DDevice9Ex pD3DDevice,
        out IntPtr phDevice
        );

    /// <summary>
    /// Gets a private surface format from a software plug-in Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD) device.
    /// </summary>
    /// <param name="hDevice">
    /// A handle to the plug-in DXVA-HD device.
    /// </param>
    /// <param name="pFormat">
    /// A pointer to a <strong>D3DFORMAT</strong> value. On input, specifies the surface format that is
    /// requested by the application. On output, specifies the private surface format that the plug-in
    /// device proposes. 
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_ProposeVideoPrivateFormat)(
    ///   _In_     HANDLE hDevice,
    ///   _Inout_  D3DFORMAT *pFormat
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B543F05F-40FC-4BDF-AE53-9A451D3BDF2A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B543F05F-40FC-4BDF-AE53-9A451D3BDF2A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_ProposeVideoPrivateFormat(
        IntPtr hDevice,
        ref int pFormat // D3DFORMAT
        );

    /// <summary>
    /// Gets the capabilities of a software plug-in Microsoft DirectX Video Acceleration High Definition
    /// (DXVA-HD) device.
    /// </summary>
    /// <param name="hDevice">
    /// A handle to the plug-in DXVA-HD device.
    /// </param>
    /// <param name="pContentDesc">
    /// A pointer to a <see cref="dxvahd.DXVAHD_CONTENT_DESC"/> structure that describes the video content.
    /// </param>
    /// <param name="Usage">
    /// A member of the <see cref="dxvahd.DXVAHD_DEVICE_USAGE"/> enumeration, describing how the device
    /// will be used. The value indicates the desired trade-off between speed and video quality. 
    /// </param>
    /// <param name="pCaps">
    /// A pointer to a <see cref="dxvahd.DXVAHD_VPDEVCAPS"/> structure that receives the device
    /// capabilities. 
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_GetVideoProcessorDeviceCaps)(
    ///   _In_   HANDLE hDevice,
    ///   _In_   const DXVAHD_CONTENT_DESC *pContentDesc,
    ///   _In_   DXVAHD_DEVICE_USAGE Usage,
    ///   _Out_  DXVAHD_VPDEVCAPS *pCaps
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/09753E3B-7235-4204-AD08-A083A7DB4A2B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/09753E3B-7235-4204-AD08-A083A7DB4A2B(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_GetVideoProcessorDeviceCaps(
        IntPtr hDevice,
        DXVAHD_CONTENT_DESC pContentDesc,
        DXVAHD_DEVICE_USAGE Usage,
        out DXVAHD_VPDEVCAPS pCaps
        );

    /// <summary>
    /// Gets the output formats that are supported by a software plug-in Microsoft DirectX Video
    /// Acceleration High Definition (DXVA-HD) device.
    /// </summary>
    /// <param name="hDevice">
    /// A handle to the plug-in DXVA-HD device.
    /// </param>
    /// <param name="pContentDesc">
    /// A pointer to a <see cref="dxvahd.DXVAHD_CONTENT_DESC"/> structure that describes the video content.
    /// </param>
    /// <param name="Usage">
    /// A member of the <see cref="dxvahd.DXVAHD_DEVICE_USAGE"/> enumeration, describing how the device
    /// will be used. 
    /// </param>
    /// <param name="Count">
    /// The number of formats to retrieve.
    /// </param>
    /// <param name="pFormats">
    /// A pointer to an array of <strong>D3DFORMAT</strong> values. The <em>Count</em> parameter specifies
    /// the number of elements in the array. The function fills the array with a list of output formats. 
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_GetVideoProcessorOutputFormats)(
    ///   _In_   HANDLE hDevice,
    ///   _In_   const DXVAHD_CONTENT_DESC *pContentDesc,
    ///   _In_   DXVAHD_DEVICE_USAGE Usage,
    ///   _In_   UINT Count,
    ///   _Out_  D3DFORMAT *pFormats
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D7F767D2-C645-4ADE-9B0C-0D5436CF0CFE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D7F767D2-C645-4ADE-9B0C-0D5436CF0CFE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_GetVideoProcessorOutputFormats(
        IntPtr hDevice,
        DXVAHD_CONTENT_DESC pContentDesc,
        DXVAHD_DEVICE_USAGE Usage,
        int Count,
        int[] pFormats // D3DFORMAT
        );

    /// <summary>
    /// Gets the input formats that are supported by a software plug-in Microsoft DirectX Video
    /// Acceleration High Definition (DXVA-HD) device. 
    /// </summary>
    /// <param name="hDevice">
    /// A handle to the plug-in DXVA-HD device.
    /// </param>
    /// <param name="pContentDesc">
    /// A pointer to a <see cref="dxvahd.DXVAHD_CONTENT_DESC"/> structure that describes the video content.
    /// </param>
    /// <param name="Usage">
    /// A member of the <see cref="dxvahd.DXVAHD_DEVICE_USAGE"/> enumeration, describing how the device
    /// will be used. 
    /// </param>
    /// <param name="Count">
    /// The number of formats to retrieve. 
    /// </param>
    /// <param name="pFormats">
    /// A pointer to an array of <strong>D3DFORMAT</strong> values. The <em>Count</em> parameter specifies
    /// the number of elements in the array. The method fills the array with a list of input formats. 
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_GetVideoProcessorInputFormats)(
    ///   _In_   HANDLE hDevice,
    ///   _In_   const DXVAHD_CONTENT_DESC *pContentDesc,
    ///   _In_   DXVAHD_DEVICE_USAGE Usage,
    ///   _In_   UINT Count,
    ///   _Out_  D3DFORMAT *pFormats
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3D24DA29-0FDB-4084-9810-1A0C9B04768B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3D24DA29-0FDB-4084-9810-1A0C9B04768B(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_GetVideoProcessorInputFormats(
        IntPtr hDevice,
        DXVAHD_CONTENT_DESC pContentDesc,
        DXVAHD_DEVICE_USAGE Usage,
        int Count,
        int[] pFormats // D3DFORMAT
        );

    /// <summary>
    /// Gets the capabilities of one or more software Microsoft DirectX Video Acceleration High Definition
    /// (DXVA-HD) video processors.
    /// </summary>
    /// <param name="hDevice">
    /// A handle to the plug-in DXVA-HD device.
    /// </param>
    /// <param name="pContentDesc">
    /// A pointer to a <see cref="dxvahd.DXVAHD_CONTENT_DESC"/> structure that describes the video content.
    /// </param>
    /// <param name="Usage">
    /// A member of the <see cref="dxvahd.DXVAHD_DEVICE_USAGE"/> enumeration, describing how the video
    /// processor will be used. 
    /// </param>
    /// <param name="Count">
    /// The number of elements in the <em>pCaps</em> array. 
    /// </param>
    /// <param name="pCaps">
    /// A pointer to an array of <see cref="dxvahd.DXVAHD_VPCAPS"/> structures. The function fills the
    /// structures with the capabilities of the plug-in video processors. 
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_GetVideoProcessorCaps)(
    ///   _In_   HANDLE hDevice,
    ///   _In_   const DXVAHD_CONTENT_DESC *pContentDesc,
    ///   _In_   DXVAHD_DEVICE_USAGE Usage,
    ///   _In_   UINT Count,
    ///   _Out_  DXVAHD_VPCAPS *pCaps
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D32FD5E7-B8E8-431F-BC74-B75288CEB01F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D32FD5E7-B8E8-431F-BC74-B75288CEB01F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_GetVideoProcessorCaps(
        IntPtr hDevice,
        DXVAHD_CONTENT_DESC pContentDesc,
        DXVAHD_DEVICE_USAGE Usage,
        int Count,
        DXVAHD_VPCAPS[] pCaps
        );

    /// <summary>
    /// Gets the custom rates that a software Microsoft DirectX Video Acceleration High Definition
    /// (DXVA-HD) video processor supports.
    /// </summary>
    /// <param name="hDevice">
    /// A handle to the plug-in DXVA-HD device.
    /// </param>
    /// <param name="pVPGuid">
    /// A GUID that identifies the video processor to query.
    /// </param>
    /// <param name="Count">
    /// The number of rates to retrieve.
    /// </param>
    /// <param name="pRates">
    /// A pointer to an array of <see cref="dxvahd.DXVAHD_CUSTOM_RATE_DATA"/> structures. The <em>Count
    /// </em> parameter specifies the number of elements in the array. The function fills the array with a
    /// list of custom rates. 
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_GetVideoProcessorCustomRates)(
    ///   _In_   HANDLE hDevice,
    ///   _In_   const GUID *pVPGuid,
    ///   _In_   UINT Count,
    ///   _Out_  DXVAHD_CUSTOM_RATE_DATA *pRates
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/0B633DCC-C6EB-47E5-B43B-B2A6CB66ABF6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0B633DCC-C6EB-47E5-B43B-B2A6CB66ABF6(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_GetVideoProcessorCustomRates(
        IntPtr hDevice,
        Guid pVPGuid,
        int Count,
        DXVAHD_CUSTOM_RATE_DATA[] pRates
        );

    /// <summary>
    /// Gets the supported range of image filter values from a software plug-in Microsoft DirectX Video
    /// Acceleration High Definition (DXVA-HD) device.
    /// </summary>
    /// <param name="hDevice">
    /// A handle to the plug-in DXVA-HD device.
    /// </param>
    /// <param name="Filter">
    /// The type of image filter, specified as a member of the <see cref="dxvahd.DXVAHD_FILTER"/>
    /// enumeration. 
    /// </param>
    /// <param name="pRange">
    /// A pointer to a <see cref="dxvahd.DXVAHD_FILTER_RANGE_DATA"/> structure. The function fills the
    /// structure with the range of values for the specified filter. 
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_GetVideoProcessorFilterRange)(
    ///   _In_   HANDLE hDevice,
    ///   _In_   DXVAHD_FILTER Filter,
    ///   _Out_  DXVAHD_FILTER_RANGE_DATA *pRange
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3C28FFCF-DAD5-4ED1-8B04-12E22FD566A4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3C28FFCF-DAD5-4ED1-8B04-12E22FD566A4(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_GetVideoProcessorFilterRange(
        IntPtr hDevice,
        DXVAHD_FILTER Filter,
        out DXVAHD_FILTER_RANGE_DATA pRange
        );

    /// <summary>
    /// Destroys an instance of a software plug-in Microsoft DirectX Video Acceleration High Definition
    /// (DXVA-HD) device.
    /// </summary>
    /// <param name="hDevice">
    /// A handle to the plug-in DXVA-HD device.
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_DestroyDevice)(
    ///   _In_  HANDLE hDevice
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1D0CC0A4-EFFB-4DEA-B6BA-CA1A4E1E394E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1D0CC0A4-EFFB-4DEA-B6BA-CA1A4E1E394E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_DestroyDevice(
        IntPtr hDevice
        );

    /// <summary>
    /// Creates a software Microsoft DirectX Video Acceleration High Definition (DXVA-HD) video processor
    /// plug-in.
    /// </summary>
    /// <param name="hDevice">
    /// A handle to the plug-in DXVA-HD device that creates the video processor.
    /// </param>
    /// <param name="pVPGuid">
    /// A GUID that identifies the video processor to create.
    /// </param>
    /// <param name="phVideoProcessor">
    /// Receives a handle to the software video processor.
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_CreateVideoProcessor)(
    ///   _In_   HANDLE hDevice,
    ///   _In_   const GUID *pVPGuid,
    ///   _Out_  HANDLE *phVideoProcessor
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/69DDCFC4-E91A-4AD5-AC0F-41683352D55A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/69DDCFC4-E91A-4AD5-AC0F-41683352D55A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_CreateVideoProcessor(
        IntPtr hDevice,
        Guid pVPGuid,
        out IntPtr phVideoProcessor
        );

    /// <summary>
    /// Sets a state parameter for blit operations by a software Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD) video processor.
    /// </summary>
    /// <param name="hVideoProcessor">
    /// A handle to the software DXVA-HD video processor.
    /// </param>
    /// <param name="State">
    /// The state parameter to set, specified as a member of the <see cref="dxvahd.DXVAHD_BLT_STATE"/>
    /// enumeration. 
    /// </param>
    /// <param name="DataSize">
    /// The size of the buffer pointed to by <em>pData</em>, in bytes. 
    /// </param>
    /// <param name="pData">
    /// A pointer to a buffer that contains the state data. 
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_SetVideoProcessBltState)(
    ///   _In_  HANDLE hVideoProcessor,
    ///   _In_  DXVAHD_BLT_STATE State,
    ///   _In_  UINT DataSize,
    ///   _In_  const void *pData
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/604AF2F8-42E8-465C-A49F-8C6C9BCC84DD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/604AF2F8-42E8-465C-A49F-8C6C9BCC84DD(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_SetVideoProcessBltState(
        IntPtr hVideoProcessor,
        DXVAHD_BLT_STATE State,
        int DataSize,
        IntPtr pData
        );

    /// <summary>
    /// Gets a private blit state from a software Microsoft DirectX Video Acceleration High Definition
    /// (DXVA-HD) video processor.
    /// </summary>
    /// <param name="hVideoProcessor">
    /// A handle to the software DXVA-HD video processor.
    /// </param>
    /// <param name="pData">
    /// A pointer to a <see cref="dxvahd.DXVAHD_BLT_STATE_PRIVATE_DATA"/> structure. On input, the <strong>
    /// Guid</strong> member specifies the private state to query. On output, the structure contains the
    /// state information. 
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_GetVideoProcessBltStatePrivate)(
    ///   _In_     HANDLE hVideoProcessor,
    ///   _Inout_  DXVAHD_BLT_STATE_PRIVATE_DATA *pData
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/32154457-5270-4E60-A16C-BCA72C6A9673(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/32154457-5270-4E60-A16C-BCA72C6A9673(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_GetVideoProcessBltStatePrivate(
        IntPtr hVideoProcessor,
        ref DXVAHD_BLT_STATE_PRIVATE_DATA pData
        );

    /// <summary>
    /// Sets a state parameter for an input stream on a software Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD) video processor.
    /// </summary>
    /// <param name="hVideoProcessor">
    /// A handle to the software DXVA-HD video processor.
    /// </param>
    /// <param name="StreamNumber">
    /// The zero-based index of the input stream.
    /// </param>
    /// <param name="State">
    /// The state parameter to set, specified as a member of the <see cref="dxvahd.DXVAHD_STREAM_STATE"/>
    /// enumeration. 
    /// </param>
    /// <param name="DataSize">
    /// The size of the buffer pointed to by <em>pData</em>, in bytes. 
    /// </param>
    /// <param name="pData">
    /// A pointer to a buffer that contains the state data.
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_SetVideoProcessStreamState)(
    ///   _In_  HANDLE hVideoProcessor,
    ///   _In_  UINT StreamNumber,
    ///   _In_  DXVAHD_STREAM_STATE State,
    ///   _In_  UINT DataSize,
    ///   _In_  const void *pData
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1FBECDBD-9F04-4D1E-82A6-4C6CE522CDAF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1FBECDBD-9F04-4D1E-82A6-4C6CE522CDAF(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_SetVideoProcessStreamState(
        IntPtr hVideoProcessor,
        int StreamNumber,
        DXVAHD_STREAM_STATE State,
        int DataSize,
        IntPtr pData
        );

    /// <summary>
    /// Gets a private stream state from a software Microsoft DirectX Video Acceleration High Definition
    /// (DXVA-HD) video processor.
    /// </summary>
    /// <param name="hVideoProcessor">
    /// A handle to the software DXVA-HD video processor.
    /// </param>
    /// <param name="StreamNumber">
    /// The zero-based index of the input stream.
    /// </param>
    /// <param name="pData">
    /// A pointer to a <see cref="dxvahd.DXVAHD_STREAM_STATE_PRIVATE_DATA"/> structure. On input, the 
    /// <strong>Guid</strong> member specifies the private state to query. On output, the structure
    /// contains the state information. 
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_GetVideoProcessStreamStatePrivate)(
    ///   _In_     HANDLE hVideoProcessor,
    ///   _In_     UINT StreamNumber,
    ///   _Inout_  DXVAHD_STREAM_STATE_PRIVATE_DATA *pData
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/DB751314-8C3C-4969-87C4-0B2B2201CE20(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DB751314-8C3C-4969-87C4-0B2B2201CE20(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_GetVideoProcessStreamStatePrivate(
        IntPtr hVideoProcessor,
        int StreamNumber,
        ref DXVAHD_STREAM_STATE_PRIVATE_DATA pData
        );

    /// <summary>
    /// Performs a video processing blit.
    /// </summary>
    /// <param name="hVideoProcessor">
    /// A handle to the software DXVA-HD video processor.
    /// </param>
    /// <param name="pOutputSurface">
    /// A pointer to the <strong>IDirect3DSurface9</strong> interface of a Direct3D surface that receives
    /// the blit. 
    /// </param>
    /// <param name="OutputFrame">
    /// The frame number of the output video frame, indexed from zero.
    /// </param>
    /// <param name="StreamCount">
    /// The number of input streams to process. 
    /// </param>
    /// <param name="pStreams">
    /// A pointer to an array of <see cref="dxvahd.DXVAHD_STREAM_DATA"/> structures that contain
    /// information about the input streams. The number of elements in the array is given in the <em>
    /// StreamCount</em> parameter. 
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_VideoProcessBltHD)(
    ///   _In_  HANDLE hVideoProcessor,
    ///   _In_  IDirect3DSurface9 *pOutputSurface,
    ///   _In_  UINT OutputFrame,
    ///   _In_  UINT StreamCount,
    ///   _In_  const DXVAHD_STREAM_DATA *pStreams
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/94E6B59F-DD00-4D32-B1CA-A592A67CD0EC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/94E6B59F-DD00-4D32-B1CA-A592A67CD0EC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_VideoProcessBltHD(
        IntPtr hVideoProcessor,
        IDirect3DSurface9 pOutputSurface,
        int OutputFrame,
        int StreamCount,
        DXVAHD_STREAM_DATA[] pStreams
        );

    /// <summary>
    /// Destroys a sofware Microsoft DirectX Video Acceleration High Definition (DXVA-HD) video processor.
    /// </summary>
    /// <param name="hVideoProcessor">
    /// A handle to the software DXVA-HD video processor.
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_DestroyVideoProcessor)(
    ///   _In_  HANDLE hVideoProcessor
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/46667A66-3638-4CF0-9966-3E659D00F914(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/46667A66-3638-4CF0-9966-3E659D00F914(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_DestroyVideoProcessor(
        IntPtr hVideoProcessor
        );

    /// <summary>
    /// Pointer to a function that initializes a software plug-in device for Microsoft DirectX Video
    /// Acceleration High Definition (DXVA-HD).
    /// </summary>
    /// <param name="Size">
    /// The size of the structure pointed to by the <em>pCallbacks</em> parameter, in bytes. 
    /// </param>
    /// <param name="pCallbacks">
    /// A pointer to an uninitialized <see cref="dxvahd.DXVAHDSW_CALLBACKS"/> structure. The function fills
    /// this structure with pointers to the plug-in device's callback functions. 
    /// </param>
    /// <returns>
    /// If this function pointer succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an 
    /// <strong>HRESULT</strong> error code. 
    /// </returns>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef HRESULT ( CALLBACK *PDXVAHDSW_Plugin)(
    ///   _In_   UINT Size,
    ///   _Out_  void *pCallbacks
    /// );
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1290DAA0-A2DD-4067-B74D-E1B3E3EDB321(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1290DAA0-A2DD-4067-B74D-E1B3E3EDB321(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public delegate int PDXVAHDSW_Plugin(
        int Size,
        IntPtr[] pCallbacks
        );

    //DEFINE_GUID(DXVAHDControlGuid, 0xa0386e75,0xf70c,0x464c,0xa9,0xce,0x33,0xc4,0x4e,0x09,0x16,0x23); 

    /// <summary>
    /// <i>***** Documentation Missing *****</i>.
    /// </summary>
    /// <param name="pD3DDevice"><i>***** Documentation Missing *****</i>.</param>
    /// <param name="pContentDesc"><i>***** Documentation Missing *****</i>.</param>
    /// <param name="Usage"><i>***** Documentation Missing *****</i>.</param>
    /// <param name="pPlugin"><i>***** Documentation Missing *****</i>.</param>
    /// <param name="ppDevice"><i>***** Documentation Missing *****</i>.</param>
    /// <returns><i>***** Documentation Missing *****</i>.</returns>
    public delegate int PDXVAHD_CreateDevice(
        IDirect3DDevice9Ex pD3DDevice,
        DXVAHD_CONTENT_DESC pContentDesc,
        DXVAHD_DEVICE_USAGE Usage,
        PDXVAHDSW_Plugin pPlugin,
        out IDXVAHD_Device ppDevice
        );

#endif

}
