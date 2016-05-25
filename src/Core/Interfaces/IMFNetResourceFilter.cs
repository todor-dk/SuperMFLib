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
    /// Notifies the application when a byte stream requests a URL, and enables the application to block
    /// URL redirection.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/AC8FBD93-B39B-4530-8475-275D3D0DA512(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC8FBD93-B39B-4530-8475-275D3D0DA512(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("091878a3-bf11-4a5c-bc9f-33995b06ef2d")]
    internal interface IMFNetResourceFilter
    {
        /// <summary>
        /// Called when the byte stream redirects to a URL.
        /// </summary>
        /// <param name="pszUrl">The PSZ URL.</param>
        /// <param name="pvbCancel">
        /// To cancel the redirection, set this parameter to <strong>VARIANT_TRUE</strong>. To allow the
        /// redirection, set this parameter to <strong>VARIANT_FALSE</strong>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnRedirect(
        ///   [in]   LPCWSTR ,
        ///   [out]  VARIANT_BOOL *pvbCancel
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/418EA3E0-9732-43B7-BF80-A85ECB7A9485(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/418EA3E0-9732-43B7-BF80-A85ECB7A9485(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnRedirect( 
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl,
            [MarshalAs(UnmanagedType.VariantBool)] out bool pvbCancel
        );

        /// <summary>
        /// Called when the byte stream requests a URL.
        /// </summary>
        /// <param name="pszUrl">
        /// The URL that the byte stream is requesting.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnSendingRequest(
        ///   [in]  LPCWSTR pszUrl
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4FE6BBE8-A8EC-4304-BC4B-4D49F8EADC25(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4FE6BBE8-A8EC-4304-BC4B-4D49F8EADC25(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnSendingRequest( 
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl
        );
    }

#endif

}
