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
    /// Gets credentials from the credential cache.
    /// <para/>
    /// This interface is implemented by the credential cache object. Applications that implement the 
    /// <see cref="IMFNetCredentialManager"/> interface can use this object to store the user's
    /// credentials. To create the credential cache object, call 
    /// <see cref="MFExtern.MFCreateCredentialCache"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D02E26E7-E99C-4BE7-8495-830EFF2F1554(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D02E26E7-E99C-4BE7-8495-830EFF2F1554(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("5B87EF6C-7ED8-434F-BA0E-184FAC1628D1")]
    internal interface IMFNetCredentialCache
    {
        /// <summary>
        /// Retrieves the credential object for the specified URL.
        /// </summary>
        /// <param name="pszUrl">
        /// A null-terminated wide-character string containing the URL for which the credential is needed.
        /// </param>
        /// <param name="pszRealm">
        /// A null-terminated wide-character string containing the realm for the authentication.
        /// </param>
        /// <param name="dwAuthenticationFlags">
        /// Bitwise <strong>OR</strong> of zero or more flags from the <see cref="MFNetAuthenticationFlags"/>
        /// enumeration. 
        /// </param>
        /// <param name="ppCred">
        /// Receives a pointer to the <see cref="IMFNetCredential"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <param name="pdwRequirementsFlags">The PDW requirements flags.</param>
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
        /// HRESULT GetCredential(
        ///   [in]   LPCWSTR pszUrl,
        ///   [in]   LPCWSTR pszRealm,
        ///   [in]   DWORD dwAuthenticationFlags,
        ///   [out]  IMFNetCredential **ppCred,
        ///   [out]  DWORD *pdwFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7E095445-354A-4FBB-B354-BF87EB77552F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7E095445-354A-4FBB-B354-BF87EB77552F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCredential(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl,
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszRealm,
            [In] MFNetAuthenticationFlags dwAuthenticationFlags,
            [MarshalAs(UnmanagedType.Interface)] out IMFNetCredential ppCred,
            out MFNetCredentialRequirements pdwRequirementsFlags
            );

        /// <summary>
        /// Reports whether the credential object provided successfully passed the authentication challenge.
        /// </summary>
        /// <param name="pCred">
        /// Pointer to the <see cref="IMFNetCredential"/> interface. 
        /// </param>
        /// <param name="fGood">
        /// <strong>TRUE</strong> if the credential object succeeded in the authentication challenge;
        /// otherwise, <strong>FALSE</strong>. 
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
        /// HRESULT SetGood(
        ///   [in]  IMFNetCredential *pCred,
        ///   [in]  BOOL fGood
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E2E9D87A-6238-49A0-9A19-FE213749D627(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E2E9D87A-6238-49A0-9A19-FE213749D627(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetGood(
            [In, MarshalAs(UnmanagedType.Interface)] IMFNetCredential pCred,
            [In] bool fGood
            );

        /// <summary>
        /// Specifies how user credentials are stored.
        /// </summary>
        /// <param name="pCred">
        /// Pointer to the <see cref="IMFNetCredential"/> interface. Obtain this pointer by calling 
        /// <see cref="IMFNetCredentialCache.GetCredential"/>. 
        /// </param>
        /// <param name="dwOptionsFlags">
        /// Bitwise <strong>OR</strong> of zero or more flags from the <see cref="MFNetCredentialOptions"/>
        /// enumeration. 
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
        /// HRESULT SetUserOptions(
        ///   [in]  IMFNetCredential *pCred,
        ///   [in]  DWORD dwOptionsFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/024EEA57-E7C8-495D-9959-AB37DD45873D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/024EEA57-E7C8-495D-9959-AB37DD45873D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetUserOptions(
            [In, MarshalAs(UnmanagedType.Interface)] IMFNetCredential pCred,
            [In] MFNetCredentialOptions dwOptionsFlags
            );
    }

#endif

}
