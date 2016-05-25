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

namespace MediaFoundation.Core.Interfaces
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Determines the proxy to use when connecting to a server. The network source uses this interface.
    /// <para/>
    /// Applications can create the proxy locator configured by the application by implementing the 
    /// <see cref="IMFNetProxyLocatorFactory"/> interface and setting the 
    /// <see cref="MFProperties.MFNETSOURCE_PROXYLOCATORFACTORY"/> property on the source resolver.
    /// Otherwise, the network source uses the default Media Foundation implementation. 
    /// <para/>
    /// To create the default proxy locator, call <see cref="MFExtern.MFCreateProxyLocator"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/2906B998-F1CA-4C65-B810-CBC360390653(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2906B998-F1CA-4C65-B810-CBC360390653(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("E9CD0383-A268-4BB4-82DE-658D53574D41")]
    internal interface IMFNetProxyLocator
    {
        /// <summary>
        /// Initializes the proxy locator object.
        /// </summary>
        /// <param name="pszHost">
        /// Null-terminated wide-character string containing the hostname of the destination server.
        /// </param>
        /// <param name="pszUrl">
        /// Null-terminated wide-character string containing the destination URL.
        /// </param>
        /// <param name="fReserved">
        /// Reserved. Set to <strong>FALSE</strong>. 
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
        /// HRESULT FindFirstProxy(
        ///   [in]  LPCWSTR pszHost,
        ///   [in]  LPCWSTR pszUrl,
        ///   [in]  BOOL fReserved
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/48EBA170-EEED-4EDF-B8D3-2F4541637129(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/48EBA170-EEED-4EDF-B8D3-2F4541637129(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int FindFirstProxy(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszHost,
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl,
            [In, MarshalAs(UnmanagedType.Bool)] bool fReserved
            );

        /// <summary>
        /// Determines the next proxy to use.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>S_FALSE</strong></term><description>There are no more proxy objects.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT FindNextProxy();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/91A6046F-F5C3-4239-AF71-D25E9D5B5838(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/91A6046F-F5C3-4239-AF71-D25E9D5B5838(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int FindNextProxy();

        /// <summary>
        /// Keeps a record of the success or failure of using the current proxy.
        /// </summary>
        /// <param name="hrOp">
        /// <strong>HRESULT</strong> specifying the result of using the current proxy for connection. 
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
        /// HRESULT RegisterProxyResult(
        ///   [in]  HRESULT hrOp
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2B1A55C6-7D78-47CC-9098-6504D11A4EEF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2B1A55C6-7D78-47CC-9098-6504D11A4EEF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RegisterProxyResult(
            [In, MarshalAs(UnmanagedType.Error)] int hrOp
            );

        /// <summary>
        /// Retrieves the current proxy information including hostname and port.
        /// </summary>
        /// <param name="pszStr">
        /// Pointer to a buffer that receives a null-terminated string containing the proxy hostname and port.
        /// This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pcchStr">
        /// On input, specifies the number of elements in the <em>pszStr</em> array. On output, receives the
        /// required size of the buffer. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_NOT_SUFFICIENT_BUFFER</strong></term><description>The buffer specified in <em>pszStr</em> is too small. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCurrentProxy(
        ///   [out]      LPWSTR pszStr,
        ///   [in, out]  DWORD *pcchStr
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5BC9A87B-A6D5-4AE0-A3A2-9CEF2DF79272(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5BC9A87B-A6D5-4AE0-A3A2-9CEF2DF79272(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCurrentProxy(
            [Out, MarshalAs(UnmanagedType.LPWStr)] string pszStr,
            [In, Out] ref int pcchStr
            );

        /// <summary>
        /// Creates a new instance of the default proxy locator.
        /// </summary>
        /// <param name="ppProxyLocator">
        /// Receives a pointer to the new proxy locator object's <see cref="IMFNetProxyLocator"/> interface.
        /// The caller must release the interface. 
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
        /// HRESULT Clone(
        ///   [out]  IMFNetProxyLocator **ppProxyLocator
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/551372B3-B9AA-4057-8C14-19E582053E00(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/551372B3-B9AA-4057-8C14-19E582053E00(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Clone(
            [MarshalAs(UnmanagedType.Interface)] out IMFNetProxyLocator ppProxyLocator
            );
    }

#endif

}
