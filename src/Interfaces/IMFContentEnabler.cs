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
using System.Runtime.InteropServices.ComTypes;

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation
{


    /// <summary>
    /// Implements one step that must be performed for the user to access media content. For example, the
    /// steps might be individualization followed by license acquisition. Each of these steps would be
    /// encapsulated by a content enabler object that exposes the <strong>IMFContentEnabler</strong>
    /// interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/45D02BD0-1104-47EC-8559-8CC51590FC62(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/45D02BD0-1104-47EC-8559-8CC51590FC62(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("D3C4EF59-49CE-4381-9071-D5BCD044C770"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFContentEnabler
    {
        /// <summary>
        /// Retrieves the type of operation that this content enabler performs.
        /// </summary>
        /// <param name="pType">
        /// Receives a GUID that identifies the type of operation. An application can tailor its user interface
        /// (UI) strings for known operation types. See Remarks.
        /// </param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetEnableType(
        ///   [out]  GUID *pType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9FE597D8-788C-48C4-A21A-0B91A890710F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9FE597D8-788C-48C4-A21A-0B91A890710F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetEnableType(out Guid pType);

        /// <summary>
        /// Retrieves a URL for performing a manual content enabling action.
        /// </summary>
        /// <param name="ppwszURL">
        /// Receives a pointer to a buffer that contains the URL. The caller must release the memory for the
        /// buffer by calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <param name="pcchURL">
        /// Receives the number of characters returned in <em>ppwszURL</em>, including the terminating NULL
        /// character. 
        /// </param>
        /// <param name="pTrustStatus">
        /// Receives a member of the <see cref="MFURLTrustStatus"/> enumeration indicating whether the URL is
        /// trusted. 
        /// </param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOT_AVAILABLE</strong></term><description>No URL is available.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetEnableURL(
        ///   [out]      LPWSTR *ppwszURL,
        ///   [out]      DWORD *pcchURL,
        ///   [in, out]  MF_URL_TRUST_STATUS *pTrustStatus
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1A44216D-36E5-4B5C-9585-5297D5E429F9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1A44216D-36E5-4B5C-9585-5297D5E429F9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetEnableURL(
            [MarshalAs(UnmanagedType.LPWStr)] out string ppwszURL,
            out int pcchURL,
            out MFURLTrustStatus pTrustStatus
            );

        /// <summary>
        /// Retrieves the data for a manual content enabling action.
        /// </summary>
        /// <param name="ppbData">
        /// Receives a pointer to a buffer that contains the data. The caller must free the buffer by calling 
        /// <c>CoTaskMemFree</c>. 
        /// </param>
        /// <param name="pcbData">
        /// Receives the size of the <em>ppbData</em> buffer. 
        /// </param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOT_AVAILABLE</strong></term><description>No data is available.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetEnableData(
        ///   [out]  BYTE **ppbData,
        ///   [out]  DWORD *pcbData
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D1859037-7A33-4943-8CA9-6782FC8B0B92(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D1859037-7A33-4943-8CA9-6782FC8B0B92(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetEnableData(
            [Out] out IntPtr ppbData,
            out int pcbData);

        /// <summary>
        /// Queries whether the content enabler can perform all of its actions automatically.
        /// </summary>
        /// <param name="pfAutomatic">
        /// Receives a Boolean value. If <strong>TRUE</strong>, the content enabler can perform the enabing
        /// action automatically. 
        /// </param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT IsAutomaticSupported(
        ///   [out]  BOOL *pfAutomatic
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/144470CE-2849-4464-8596-FAC216529145(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/144470CE-2849-4464-8596-FAC216529145(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int IsAutomaticSupported(
            [MarshalAs(UnmanagedType.Bool)] out bool pfAutomatic
            );

        /// <summary>
        /// Performs a content enabling action without any user interaction.
        /// </summary>
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT AutomaticEnable();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7BE4C32F-D116-4A08-857F-1A59B5CCFB12(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7BE4C32F-D116-4A08-857F-1A59B5CCFB12(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AutomaticEnable();

        /// <summary>
        /// Requests notification when the enabling action is completed.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>S_FALSE</strong></term><description>The method succeeded and no action was required.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT MonitorEnable();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/78FC4A17-F58C-4654-B37E-6B988848FF0D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/78FC4A17-F58C-4654-B37E-6B988848FF0D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int MonitorEnable();

        /// <summary>
        /// Cancels a pending content enabling action.
        /// </summary>
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Cancel();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E273B702-1F42-4AEB-9259-778D3F206682(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E273B702-1F42-4AEB-9259-778D3F206682(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Cancel();
    }

}
