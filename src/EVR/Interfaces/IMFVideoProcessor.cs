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

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.Transform;
using System.Drawing;

namespace MediaFoundation.EVR
{


    /// <summary>
    /// Controls video processing in the <c>Enhanced Video Renderer</c> (EVR). The operations controlled
    /// through this interface include color adjustment (ProcAmp), noise filters, and detail filters. 
    /// <para/>
    /// The EVR mixer implements this interface. To get a pointer to the interface, call 
    /// <see cref="IMFGetService.GetService"/>. The service identifier is GUID MR_VIDEO_MIXER_SERVICE. Call
    /// <strong>GetService</strong> on any of the following objects: 
    /// <para/>
    /// If you implement a custom mixer for the EVR, the mixer can optionally expose this interface as a
    /// service.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/0A63C4F8-EB32-4F0C-B69B-0C16243F2F21(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0A63C4F8-EB32-4F0C-B69B-0C16243F2F21(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("6AB0000C-FECE-4d1f-A2AC-A9573530656E")]
    public interface IMFVideoProcessor
    {
        /// <summary>
        /// Retrieves the video processor modes that the video driver supports.
        /// </summary>
        /// <param name="lpdwNumProcessingModes">
        /// Receives the number of video processor modes.
        /// </param>
        /// <param name="ppVideoProcessingModes">
        /// Receives a pointer to an array of GUIDs. The number of elements in the array is returned in the 
        /// <em>lpdwNumProcessingModes</em> parameter. The caller must release the memory for the array by
        /// calling <c>CoTaskMemFree</c>. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description>The media type for the reference stream is not set.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetAvailableVideoProcessorModes(
        ///   [in, out]  UINT *lpdwNumProcessingModes,
        ///   [out]      GUID **ppVideoProcessingModes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1004341D-D39B-4032-A027-39E35ECAB635(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1004341D-D39B-4032-A027-39E35ECAB635(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAvailableVideoProcessorModes(
            out int lpdwNumProcessingModes,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(GMarshaler))] Guid[] ppVideoProcessingModes);

        /// <summary>
        /// Retrieves the capabilities of a video processor mode.
        /// </summary>
        /// <param name="lpVideoProcessorMode">
        /// Pointer to a GUID that identifies the video processor mode. To get a list of available modes, call 
        /// <see cref="EVR.IMFVideoProcessor.GetAvailableVideoProcessorModes"/>. 
        /// </param>
        /// <param name="lpVideoProcessorCaps">
        /// Pointer to a <see cref="EVR.DXVA2VideoProcessorCaps"/> structure that receives the capabilities. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description>The media type for the reference stream is not set.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoProcessorCaps(
        ///   [in]   LPGUID lpVideoProcessorMode,
        ///   [out]  DXVA2_VideoProcessorCaps *lpVideoProcessorCaps
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9A02AED2-8225-4416-AE54-7ED51C67A149(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9A02AED2-8225-4416-AE54-7ED51C67A149(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoProcessorCaps(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid lpVideoProcessorMode,
            out DXVA2VideoProcessorCaps lpVideoProcessorCaps);

        /// <summary>
        /// Retrieves the application's preferred video processor mode. To set the preferred mode, call 
        /// <see cref="EVR.IMFVideoProcessor.SetVideoProcessorMode"/>. 
        /// </summary>
        /// <param name="lpMode">
        /// Receives a GUID that identifies the preferred video processor mode.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description>The media type for the reference stream is not set.</description></item>
        /// <item><term><strong>S_FALSE</strong></term><description>The application has not specified a preferred video processor mode.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetVideoProcessorMode(
        ///   [out]  LPGUID lpMode
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DF45C379-F525-4018-B2C2-88A52B13DFF5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DF45C379-F525-4018-B2C2-88A52B13DFF5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetVideoProcessorMode(
            out Guid lpMode);

        /// <summary>
        /// Sets the preferred video processor mode. The EVR will attempt to use this mode when playback
        /// starts.
        /// </summary>
        /// <param name="lpMode">
        /// Pointer to a GUID that identifies the video processor mode. To get a list of available modes, call 
        /// <see cref="EVR.IMFVideoProcessor.GetAvailableVideoProcessorModes"/>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>D3DERR_INVALIDCALL</strong></term><description>The requested mode is not valid.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The mixer has already allocated Direct3D resources and cannot change modes.</description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description>The media type for the reference stream is not set.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetVideoProcessorMode(
        ///   [in]  LPGUID lpMode
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4B353576-C8EE-4F73-9EE6-BA4545A6F4FC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4B353576-C8EE-4F73-9EE6-BA4545A6F4FC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetVideoProcessorMode(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid lpMode);

        /// <summary>
        /// Retrieves the range of values for a color adjustment (ProcAmp) setting.
        /// </summary>
        /// <param name="dwProperty">
        /// The ProcAmp setting to query. For a list of possible values, see <c>ProcAmp Settings</c>. 
        /// </param>
        /// <param name="pPropRange">
        /// Pointer to a <see cref="EVR.DXVA2ValueRange"/> structure that receives range of values for the
        /// specified ProcAmp setting. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid value for <em>dwProperty</em>. </description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>No video processor mode has been set.</description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description>The media type for the reference stream is not set.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetProcAmpRange(
        ///   [in]   DWORD dwProperty,
        ///   [out]  DXVA2_ValueRange *pPropRange
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/03894BFE-020A-4478-AF6F-88521D4BBB6D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/03894BFE-020A-4478-AF6F-88521D4BBB6D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetProcAmpRange(
            DXVA2ProcAmp dwProperty,
            out DXVA2ValueRange pPropRange);

        /// <summary>
        /// Retrieves the current settings for one or more color adjustment (ProcAmp) settings.
        /// </summary>
        /// <param name="dwFlags">
        /// Bitwise <strong>OR</strong> of one or more flags, specifying which operations to query. For a list
        /// of flags, see <c>ProcAmp Settings</c>. 
        /// </param>
        /// <param name="Values">The values.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description>The media type for the reference stream is not set.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetProcAmpValues(
        ///   [in]   DWORD dwFlags,
        ///   [out]  DXVA2_ProcAmpValues *pValues
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D1D6F6A4-FE3B-4ACF-A004-D02ECE41A302(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D1D6F6A4-FE3B-4ACF-A004-D02ECE41A302(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetProcAmpValues(
            DXVA2ProcAmp dwFlags,
            [Out, MarshalAs(UnmanagedType.LPStruct)] DXVA2ProcAmpValues Values);

        /// <summary>
        /// Sets one or more color adjustment (ProcAmp) settings.
        /// </summary>
        /// <param name="dwFlags">
        /// Bitwise <strong>OR</strong> of one or more flags, specifying which ProcAmp values to set. For a
        /// list of flags, see <c>ProcAmp Settings</c>. 
        /// </param>
        /// <param name="pValues">
        /// Pointer to a <see cref="EVR.DXVA2ProcAmpValues"/> structure. For each flag that you set in <em>
        /// dwFlags</em>, set the corresponding structure member to the desired value. To get the valid range
        /// of values for each operation, call <see cref="EVR.IMFVideoProcessor.GetProcAmpRange"/>. The method
        /// ignores any structure members for which the corresponding flag is not set in <em>dwFlags</em>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The <em>dwFlags</em> parameter is invalid, or one or more values in <em>pValues</em> is not within the correct range. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description>The media type for the reference stream is not set.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetProcAmpValues(
        ///   [in]  DWORD dwFlags,
        ///   [in]  DXVA2_ProcAmpValues *pValues
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/84A5E022-773C-483B-ADB5-5883B25B716F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/84A5E022-773C-483B-ADB5-5883B25B716F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetProcAmpValues(
            DXVA2ProcAmp dwFlags,
            [In] DXVA2ProcAmpValues pValues);

        /// <summary>
        /// Retrieves the range of values for a specified image filter setting.
        /// </summary>
        /// <param name="dwProperty">
        /// The image filtering parameter to query. For a list of possible values, see 
        /// <c>DXVA Image Filter Settings</c>. 
        /// </param>
        /// <param name="pPropRange">
        /// Pointer to a <see cref="EVR.DXVA2ValueRange"/> structure that receives range of values for the
        /// specified image filtering parameter. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>DDERR_UNSUPPORTED</strong></term><description>The driver does not support this filter setting.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid value for <em>dwProperty</em>. </description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>No video processor mode has been set.</description></item>
        /// <item><term><strong>MF_E_NOT_AVAILABLE</strong></term><description>The specified operation is not available.</description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description>The media type for the reference stream is not set.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetFilteringRange(
        ///   [in]   DWORD dwProperty,
        ///   [out]  DXVA2_ValueRange *pPropRange
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1E5F1635-51FE-4394-8A25-DCEE3F55C711(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1E5F1635-51FE-4394-8A25-DCEE3F55C711(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetFilteringRange(
            DXVA2Filters dwProperty,
            out DXVA2ValueRange pPropRange);

        /// <summary>
        /// Retrieves the current setting for an image filter.
        /// </summary>
        /// <param name="dwProperty">
        /// The filter setting to query. For a list of possible values, see <c>DXVA Image Filter Settings</c>. 
        /// </param>
        /// <param name="pValue">
        /// Pointer to a <c>DXVA2_Fixed32</c> structure that receives the current value. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The value of <em>dwProperty</em> is invalid. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description>The media type for the reference stream is not set.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetFilteringValue(
        ///   [in]   DWORD dwProperty,
        ///   [out]  DXVA2_Fixed32 *pValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1C8D6836-CA62-4D26-BE4E-572DC6FF994D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1C8D6836-CA62-4D26-BE4E-572DC6FF994D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetFilteringValue(
            DXVA2Filters dwProperty,
            out int pValue);

        /// <summary>
        /// Sets a parameter for an image filter.
        /// </summary>
        /// <param name="dwProperty">
        /// The image filtering parameter to set. For a list of possible values, see 
        /// <c>DXVA Image Filter Settings</c>. 
        /// </param>
        /// <param name="pValue">
        /// Pointer to a <c>DXVA2_Fixed32</c> structure that specifies the new value. To get the valid range of
        /// values for each parameter, call <see cref="EVR.IMFVideoProcessor.GetFilteringRange"/>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The value of <em>dwProperty</em> is invalid. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description>The media type for the reference stream is not set.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetFilteringValue(
        ///   [in]  DWORD dwProperty,
        ///   [in]  DXVA2_Fixed32 *pValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CB3C9516-2083-4C9D-B583-FC561F977ED5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CB3C9516-2083-4C9D-B583-FC561F977ED5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetFilteringValue(
            DXVA2Filters dwProperty,
            [In] ref int pValue);

        /// <summary>
        /// Retrieves the background color for the composition rectangle. The background color is used for
        /// letterboxing the video image.
        /// </summary>
        /// <param name="lpClrBkg">
        /// Pointer to a <strong>COLORREF</strong> value that receives the background color. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetBackgroundColor(
        ///   [out]  COLORREF *lpClrBkg
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D9068346-F0B3-4361-A56B-2360ECC3B9D9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D9068346-F0B3-4361-A56B-2360ECC3B9D9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetBackgroundColor(
            out int lpClrBkg);

        /// <summary>
        /// Sets the background color for the composition rectangle. The background color is used for
        /// letterboxing the video image.
        /// </summary>
        /// <param name="ClrBkg">
        /// Background color, specified as a <strong>COLORREF</strong> value. Use the <strong>RGB</strong>
        /// macro to create this value. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetBackgroundColor(
        ///   [in]  COLORREF ClrBkg
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FB654DBA-1F03-48A7-AC8E-FA0C82F29849(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FB654DBA-1F03-48A7-AC8E-FA0C82F29849(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetBackgroundColor(
            int ClrBkg);
    }

}
