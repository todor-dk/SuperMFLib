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
    /// Implemented by a client and called by Microsoft Media Foundation to get the client Secure Sockets
    /// Layer (SSL) certificate requested by the server. 
    /// <para/>
    /// In most HTTPS connections the server provides a certificate so that the client can ensure the
    /// identity of the server. However, in certain cases the server might wants to verify the identity of
    /// the client by requesting the client to send a certificate. For this scenario, a client application
    /// must provide a mechanism for Media Foundation to retrieve the client side certificate while opening
    /// an HTTPS URL with the source resolver or the scheme handler. The application must implement 
    /// <strong>IMFSSLCertificateManager</strong>, set the <strong>IUnknown</strong> pointer of the
    /// implemented object in the <see cref="MFProperties.MFNETSOURCE_SSLCERTIFICATE_MANAGER"/> property,
    /// and pass the property store to the source resolver. While opening the URL, Media Foundation calls
    /// the <strong>IMFSSLCertificateManager</strong> methods to get the certificate information. If the
    /// application needs to connect to HTTPS URL that requires a client-side certificate, or the
    /// application wants customized control over the type of server certificates to accept, then they can
    /// implement this interface. This interface can also be used by the application to validate the server
    /// SSL certificate. 
    /// <para/>
    /// If the <strong>IUnknown</strong> pointer is not provided by the application and the HTTPS URL does
    /// not require the client to provide a certificate, Media Foundation uses the default implementation
    /// to open the URL. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/62E4227D-6BC9-4011-ACEE-6278FE388830(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/62E4227D-6BC9-4011-ACEE-6278FE388830(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("61F7D887-1230-4A8B-AEBA-8AD434D1A64D")]
    internal interface IMFSSLCertificateManager
    {
        /// <summary>
        /// Gets the client SSL certificate synchronously.
        /// </summary>
        /// <param name="pszUrl">The PSZ URL.</param>
        /// <param name="ppbData">
        /// Pointer to the buffer that stores the certificate. This caller must free the buffer by calling 
        /// <strong>CoTaskMemFree</strong>. 
        /// </param>
        /// <param name="pcbData">
        /// Pointer to a <strong>DWORD</strong> variable that receives the number of bytes required to hold the
        /// certificate data in the buffer pointed by <em>*ppbData</em>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetClientCertificate(
        ///   [in]   LPCWSTR pszURL,
        ///   [out]  BYTE **ppbData,
        ///   [out]  DWORD *pcbData
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/11A575E8-5EB2-4CBB-A460-F1EA5D54D324(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/11A575E8-5EB2-4CBB-A460-F1EA5D54D324(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetClientCertificate(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl,
            [Out] IntPtr ppbData,
            out int pcbData
        );

        /// <summary>
        /// Starts an asynchronous call to get the client SSL certificate.
        /// </summary>
        /// <param name="pszUrl">The PSZ URL.</param>
        /// <param name="pCallback">
        /// A pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface. 
        /// </param>
        /// <param name="pState">
        /// A pointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginGetClientCertificate(
        ///   [in]  LPCWSTR pszURL,
        ///   [in]  IMFAsyncCallback *pCallback,
        ///   [in]  IUnknown *pState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E375CB97-BB43-4852-9671-DD8FDEA34CEF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E375CB97-BB43-4852-9671-DD8FDEA34CEF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginGetClientCertificate(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl,
            IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pState
        );

        /// <summary>
        /// Completes an asynchronous request to get the client SSL certificate. 
        /// </summary>
        /// <param name="pResult">
        /// A pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your
        /// callback object received in the <see cref="IMFAsyncCallback.Invoke"/> method. 
        /// </param>
        /// <param name="ppbData">
        /// Receives a pointer to the buffer that stores the certificate. The caller must free the buffer by
        /// calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <param name="pcbData">
        /// Receives the size of the <em>ppbData</em> buffer, in bytes. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EndGetClientCertificate(
        ///   [in]   IMFAsyncResult *pResult,
        ///   [out]  BYTE **ppbData,
        ///   [out]  DWORD *pcbData
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/25CD2AB0-7F58-4BD5-B594-75A3ACBDC2D9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/25CD2AB0-7F58-4BD5-B594-75A3ACBDC2D9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndGetClientCertificate(
            IMFAsyncResult pResult,
            [Out] IntPtr ppbData,
            out int pcbData
        );

        /// <summary>
        /// Indicates whether the server SSL certificate must be verified by the caller, Media Foundation, or
        /// the <strong>IMFSSLCertificateManager</strong> implementation class. 
        /// </summary>
        /// <param name="pszUrl">The PSZ URL.</param>
        /// <param name="pfOverrideAutomaticCheck">
        /// Pointer to a <strong>BOOL</strong> value. Set to <strong>TRUE</strong> if 
        /// <see cref="IMFSSLCertificateManager.OnServerCertificate"/> is used to verify the server
        /// certificate. Set to <strong>FALSE</strong> if Media Foundation verifies the server certificate by
        /// using the certificates in the Windows certificate store. 
        /// </param>
        /// <param name="pfClientCertificateAvailable">
        /// Pointer to a <strong>BOOL</strong> value. Set to <strong>TRUE</strong> if the SSL certificate for
        /// the client is available for immediate retrieval. Media Foundation calls 
        /// <see cref="IMFSSLCertificateManager.GetClientCertificate"/> to obtain the client certificate
        /// synchronously. If the value is set to <strong>FALSE</strong>, Media Foundation obtains the client
        /// SSL certificate with an asynchronous call to 
        /// <see cref="IMFSSLCertificateManager.BeginGetClientCertificate"/>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCertificatePolicy(
        ///   [in]   LPCWSTR pszURL,
        ///   [out]  BOOL *pfOverrideAutomaticCheck,
        ///   [out]  BOOL *pfClientCertificateAvailable
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/343F86CA-0036-4324-B3CA-4DBA8FBC26A8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/343F86CA-0036-4324-B3CA-4DBA8FBC26A8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCertificatePolicy(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl,
            [MarshalAs(UnmanagedType.Bool)] out bool pfOverrideAutomaticCheck,
            [MarshalAs(UnmanagedType.Bool)] out bool pfClientCertificateAvailable
        );

        /// <summary>
        /// Called by Media Foundation when the server SSL certificate has been received; indicates whether the
        /// server certificate is accepted.
        /// </summary>
        /// <param name="pszUrl">The PSZ URL.</param>
        /// <param name="pbData">
        /// Pointer to a buffer that contains the server SSL certificate.
        /// </param>
        /// <param name="cbData">
        /// Pointer to a <strong>DWORD</strong> variable that indicates the size of <em>pbData</em> in bytes. 
        /// </param>
        /// <param name="pfIsGood">
        /// Pointer to a <strong>BOOL</strong> variable that indicates whether the certificate is accepted. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnServerCertificate(
        ///   [in]   LPCWSTR pszURL,
        ///   [in]   BYTE *pbData,
        ///   [in]   DWORD cbData,
        ///   [out]  BOOL *pfIsGood
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4BA43175-4429-437D-ACFB-E0EA8D300651(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4BA43175-4429-437D-ACFB-E0EA8D300651(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnServerCertificate(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pszUrl,
            [In] IntPtr pbData,
            [In] int cbData,
            [MarshalAs(UnmanagedType.Bool)] out bool pfIsGood
        );
    }

#endif

}
