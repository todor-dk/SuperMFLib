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

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Configures Windows Media Digital Rights Management (DRM) for Network Devices on a network sink.
    /// <para/>
    /// The Advanced Systems Format (ASF) streaming media sink exposes this interface. To get a pointer to
    /// the <strong>IMFDRMNetHelper</strong> interface, perform the following tasks. 
    /// <para/>
    /// For more information, see Remarks.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6F4AC19A-0972-4152-A64C-6C719EFB396C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6F4AC19A-0972-4152-A64C-6C719EFB396C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("3D1FF0EA-679A-4190-8D46-7FA69E8C7E15")]
    public interface IMFDRMNetHelper
    {
        /// <summary>
        /// Gets the license response for the specified request.
        /// </summary>
        /// <param name="pLicenseRequest">
        /// Pointer to a byte array that contains the license request.
        /// </param>
        /// <param name="cbLicenseRequest">
        /// Size, in bytes, of the license request.
        /// </param>
        /// <param name="ppLicenseResponse">
        /// Receives a pointer to a byte array that contains the license response. The caller must free the
        /// array by calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <param name="pcbLicenseResponse">
        /// Receives the size, in bytes, of the license response.
        /// </param>
        /// <param name="pbstrKID">
        /// Receives the key identifier. The caller must release the string by calling <strong>SysFreeString
        /// </strong>. 
        /// </param>
        /// <returns>
        /// The function returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media sink was shut down. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ProcessLicenseRequest(
        ///   [in]   BYTE *pLicenseRequest,
        ///   [in]   DWORD cbLicenseRequest,
        ///   [out]  BYTE **ppLicenseResponse,
        ///   [out]  DWORD *pcbLicenseResponse,
        ///   [out]  BSTR *pbstrKID
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E60F9831-F59D-46FF-B685-B26D6484A70D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E60F9831-F59D-46FF-B685-B26D6484A70D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ProcessLicenseRequest(
            [In] IntPtr pLicenseRequest,
            [In] int cbLicenseRequest,
            [Out] IntPtr ppLicenseResponse,
            out int pcbLicenseResponse,
            [MarshalAs(UnmanagedType.BStr)] out string pbstrKID
        );

        /// <summary>
        /// Not implemented in this release.
        /// </summary>
        /// <param name="ppLicenseResponse">
        /// Receives a pointer to a byte array that contains the license response. The caller must free the
        /// array by calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <param name="pcbLicenseResponse">
        /// Receives the size, in bytes, of the license response.
        /// </param>
        /// <returns>
        /// The method returns <strong>E_NOTIMPL</strong>. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetChainedLicenseResponse(
        ///   [out]  BYTE **ppLicenseResponse,
        ///   [out]  DWORD *pcbLicenseResponse
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EEDBEFD8-8540-4BF9-B602-6BEBF089FCF7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EEDBEFD8-8540-4BF9-B602-6BEBF089FCF7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetChainedLicenseResponse(
            [Out] IntPtr ppLicenseResponse,
            out int pcbLicenseResponse
        );
    }

#endif

}
