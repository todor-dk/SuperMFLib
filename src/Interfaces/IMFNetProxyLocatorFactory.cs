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

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Creates a proxy locator object, which determines the proxy to use.
    /// <para/>
    /// The network source uses this interface to create the proxy locator object. Applications can provide
    /// their own implementation of this interface by setting the 
    /// <see cref="MFProperties.MFNETSOURCE_PROXYLOCATORFACTORY"/> property. on the source resolver. If the
    /// application does not set this property, the network source uses the default proxy locator provided
    /// by Media Foundation. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6DD5BF50-2D07-47C7-869E-035D7E92A6BC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6DD5BF50-2D07-47C7-869E-035D7E92A6BC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("E9CD0384-A268-4BB4-82DE-658D53574D41"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFNetProxyLocatorFactory
    {
        /// <summary>
        /// Creates an <see cref="IMFNetProxyLocator"/> interface proxy locator object based on the protocol
        /// name. 
        /// </summary>
        /// <param name="pszProtocol">
        /// Null-terminated wide-character string containing the protocol name (for example, RTSP or HTTP).
        /// </param>
        /// <param name="ppProxyLocator">
        /// Receives a pointer to the <see cref="IMFNetProxyLocator"/> interface. The caller must release the
        /// interface. 
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CreateProxyLocator(
        ///   [in]   LPCWSTR pszProtocol,
        ///   [out]  IMFNetProxyLocator **ppProxyLocator
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0BDC03A8-A01D-453B-92B9-B39D8028B314(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0BDC03A8-A01D-453B-92B9-B39D8028B314(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateProxyLocator(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszProtocol,
            [MarshalAs(UnmanagedType.Interface)] out IMFNetProxyLocator ppProxyLocator
            );
    }

#endif

}
