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

namespace MediaFoundation.Dxvahd.Interfaces
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Represents a Microsoft DirectX Video Acceleration High Definition (DXVA-HD) device.
    /// <para/>
    /// To get a pointer to this interface, call the <see cref="dxvahd.OPMExtern.DXVAHD_CreateDevice"/>
    /// function. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3F79AC9C-2AED-4E1C-BF6F-02F9C54D59CD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3F79AC9C-2AED-4E1C-BF6F-02F9C54D59CD(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("95f12dfd-d77e-49be-815f-57d579634d6d"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IDXVAHD_Device
    {
        /// <summary>
        /// Creates one or more Microsoft Direct3D video surfaces.
        /// </summary>
        /// <param name="Width">
        /// The width of each surface, in pixels.
        /// </param>
        /// <param name="Height">
        /// The height of each surface, in pixels.
        /// </param>
        /// <param name="Format">
        /// The pixel format, specified as a <strong>D3DFORMAT</strong> value or FOURCC code. For more
        /// information, see <c>Video FOURCCs</c>. 
        /// </param>
        /// <param name="Pool">
        /// The memory pool in which the surface is created. This parameter must equal the <strong>InputPool
        /// </strong> member of the <see cref="dxvahd.DXVAHD_VPDEVCAPS"/> structure. Call the 
        /// <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorDeviceCaps"/> method to get this value. 
        /// </param>
        /// <param name="Usage">
        /// Reserved. Set to 0.
        /// </param>
        /// <param name="Type">
        /// The type of surface to create, specified as a member of the 
        /// <see cref="dxvahd.DXVAHD_SURFACE_TYPE"/> enumeration. 
        /// </param>
        /// <param name="NumSurfaces">
        /// The number of surfaces to create.
        /// </param>
        /// <param name="ppSurfaces">
        /// A pointer to an array of <strong>IDirect3DSurface9</strong> pointers. The <em>NumSurfaces</em>
        /// parameter specifies the number of elements in the array. The method fills the array with pointers
        /// to the new video surfaces. The caller must release the pointers. 
        /// </param>
        /// <param name="pSharedHandle">
        /// Reserved. Set to <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreateVideoSurface(
        ///   [in]       UINT Width,
        ///   [in]       UINT Height,
        ///   [in]       D3DFORMAT Format,
        ///   [in]       D3DPOOL Pool,
        ///   [in]       DWORD Usage,
        ///   [in]       DXVAHD_SURFACE_TYPE Type,
        ///   [in]       UINT NumSurfaces,
        ///   [out]      IDirect3DSurface9 **ppSurfaces,
        ///   [in, out]  HANDLE *pSharedHandle
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C467A077-104C-443D-896B-D69441AA5160(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C467A077-104C-443D-896B-D69441AA5160(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
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

        /// <summary>
        /// Gets the capabilities of the Microsoft DirectX Video Acceleration High Definition (DXVA-HD) device.
        /// </summary>
        /// <param name="pCaps">
        /// A pointer to a <see cref="dxvahd.DXVAHD_VPDEVCAPS"/> structure that receives the device
        /// capabilities. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoProcessorDeviceCaps(
        ///   [out]  DXVAHD_VPDEVCAPS *pCaps
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/93ACAD97-FEEE-46A5-95BF-51E560F91057(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/93ACAD97-FEEE-46A5-95BF-51E560F91057(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoProcessorDeviceCaps(
            out DXVAHD_VPDEVCAPS pCaps
            );

        /// <summary>
        /// Gets a list of the output formats supported by the Microsoft DirectX Video Acceleration High
        /// Definition (DXVA-HD) device.
        /// </summary>
        /// <param name="Count">
        /// The number of formats to retrieve. This parameter must equal the <strong>OutputFormatCount</strong>
        /// member of the <see cref="dxvahd.DXVAHD_VPDEVCAPS"/> structure. Call the 
        /// <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorDeviceCaps"/> method to get this value. 
        /// </param>
        /// <param name="pFormats">
        /// A pointer to an array of <strong>D3DFORMAT</strong> values. The <em>Count</em> parameter specifies
        /// the number of elements in the array. The method fills the array with a list of output formats. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoProcessorOutputFormats(
        ///   [in]   UINT Count,
        ///   [out]  D3DFORMAT *pFormats
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E701014D-C112-42FA-9BF5-88CB31424006(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E701014D-C112-42FA-9BF5-88CB31424006(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoProcessorOutputFormats(
            int Count,
            out int[] pFormats // D3DFORMAT 
            );

        /// <summary>
        /// Gets a list of the input formats supported by the Microsoft DirectX Video Acceleration High
        /// Definition (DXVA-HD) device.
        /// </summary>
        /// <param name="Count">
        /// The number of formats to retrieve. This parameter must equal the <strong>InputFormatCount</strong>
        /// member of the <see cref="dxvahd.DXVAHD_VPDEVCAPS"/> structure. Call the 
        /// <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorDeviceCaps"/> method to get this value. 
        /// </param>
        /// <param name="pFormats">
        /// A pointer to an array of <strong>D3DFORMAT</strong> values. The <em>Count</em> parameter specifies
        /// the number of elements in the array. The method fills the array with a list of input formats. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoProcessorInputFormats(
        ///   [in]   UINT Count,
        ///   [out]  D3DFORMAT *pFormats
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B660D111-7BD1-4345-B229-1825D830BAB4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B660D111-7BD1-4345-B229-1825D830BAB4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoProcessorInputFormats(
            int Count,
            out int[] pFormats // D3DFORMAT 
            );

        /// <summary>
        /// Gets the capabilities of one or more Microsoft DirectX Video Acceleration High Definition (DXVA-HD)
        /// video processors.
        /// </summary>
        /// <param name="Count">
        /// The number of elements in the <em>pCaps</em> array. This parameter must equal the <strong>
        /// VideoProcessorCount</strong> member of the <see cref="dxvahd.DXVAHD_VPDEVCAPS"/> structure. Call
        /// the <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorDeviceCaps"/> method to get this value. 
        /// </param>
        /// <param name="pCaps">
        /// A pointer to an array of <see cref="dxvahd.DXVAHD_VPCAPS"/> structures. The method fills the
        /// structures with the capabilities of the video processors supported by the driver. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoProcessorCaps(
        ///   [in]   UINT Count,
        ///   [out]  DXVAHD_VPCAPS *pCaps
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D9423B3F-4A4B-49F0-8018-C19A7B663300(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D9423B3F-4A4B-49F0-8018-C19A7B663300(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoProcessorCaps(
            int Count,
            out DXVAHD_VPCAPS[] pCaps
            );

        /// <summary>
        /// Gets a list of custom rates that a Microsoft DirectX Video Acceleration High Definition (DXVA-HD)
        /// video processor supports. Custom rates are used for frame-rate conversion and inverse telecine
        /// (IVTC).
        /// </summary>
        /// <param name="pVPGuid">
        /// A GUID that identifies the video processor to query. This GUID must equal the valud of the <strong>
        /// VPGuid</strong> member from one of the <see cref="dxvahd.DXVAHD_VPCAPS"/> structures retrieved by
        /// the <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorCaps"/> method. 
        /// </param>
        /// <param name="Count">
        /// The number of rates to retrieve. This parameter must equal the <strong>CustomRateCount</strong>
        /// member of the <see cref="dxvahd.DXVAHD_VPCAPS"/> structure for the video processor. 
        /// </param>
        /// <param name="pRates">
        /// A pointer to an array of <see cref="dxvahd.DXVAHD_CUSTOM_RATE_DATA"/> structures. The <em>Count
        /// </em> parameter specifies the number of elements in the array. The method fills the array with a
        /// list of custom rates. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoProcessorCustomRates(
        ///   [in]   const GUID *pVPGuid,
        ///   [in]   UINT Count,
        ///   [out]  DXVAHD_CUSTOM_RATE_DATA *pRates
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/63E835BB-DDA2-4449-8474-219A373DA82D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/63E835BB-DDA2-4449-8474-219A373DA82D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoProcessorCustomRates(
            Guid pVPGuid,
            int Count,
            out DXVAHD_CUSTOM_RATE_DATA[] pRates
            );

        /// <summary>
        /// Gets the range of values for an image filter that the Microsoft DirectX Video Acceleration High
        /// Definition (DXVA-HD) device supports. 
        /// </summary>
        /// <param name="Filter">
        /// The type of image filter, specified as a member of the <see cref="dxvahd.DXVAHD_FILTER"/>
        /// enumeration. 
        /// </param>
        /// <param name="pRange">
        /// A pointer to a <see cref="dxvahd.DXVAHD_FILTER_RANGE_DATA"/> structure. The method fills the
        /// structure with the range of values for the specified filter. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The <em>Filter</em> parameter is invalid or the device does not support the specified filter. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoProcessorFilterRange(
        ///   [in]   DXVAHD_FILTER Filter,
        ///   [out]  DXVAHD_FILTER_RANGE_DATA *pRange
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CFF587A5-04ED-4F3E-BD05-0CB8D83FFFB7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CFF587A5-04ED-4F3E-BD05-0CB8D83FFFB7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoProcessorFilterRange(
            DXVAHD_FILTER Filter,
            out DXVAHD_FILTER_RANGE_DATA pRange
            );

        /// <summary>
        /// Creates a Microsoft DirectX Video Acceleration High Definition (DXVA-HD) video processor.
        /// </summary>
        /// <param name="pVPGuid">
        /// A GUID that identifies the video processor to create. This GUID must equal the value of the 
        /// <strong>VPGuid</strong> member from one of the <see cref="dxvahd.DXVAHD_VPCAPS"/> structures
        /// retrieved by the <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorCaps"/> method. 
        /// </param>
        /// <param name="ppVideoProcessor">
        /// Receives a pointer to the <see cref="dxvahd.IDXVAHD_VideoProcessor"/> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreateVideoProcessor(
        ///   [in]   const GUID *pVPGuid,
        ///   [out]  IDXVAHD_VideoProcessor **ppVideoProcessor
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/903E2C05-E4D4-42CA-A28D-6D4738AE6CFC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/903E2C05-E4D4-42CA-A28D-6D4738AE6CFC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateVideoProcessor(
            Guid pVPGuid,
            out IDXVAHD_VideoProcessor ppVideoProcessor
            );
    }

#endif

}
