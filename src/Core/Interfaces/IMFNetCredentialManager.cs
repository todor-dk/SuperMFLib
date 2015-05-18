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
    /// Implemented by applications to provide user credentials for a network source.
    /// <para/>
    /// To use this interface, implement it in your application. Then create a property store object and
    /// set the <see cref="MFProperties.MFNETSOURCE_CREDENTIAL_MANAGER"/> property. The value of the
    /// property is a pointer to your application's <strong>IMFNetCredentialManager</strong> interface.
    /// Then pass the property store to one of the source resolver's creation functions, such as 
    /// <see cref="IMFSourceResolver.CreateObjectFromURL"/>, in the <em>pProps</em> parameter. 
    /// <para/>
    /// Media Foundation does not provide a default implementation of this interface. Applications that
    /// support authentication must implement this interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/002D8608-4EF9-40FD-8DCC-FE6ADE34478E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/002D8608-4EF9-40FD-8DCC-FE6ADE34478E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("5B87EF6B-7ED8-434F-BA0E-184FAC1628D1"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFNetCredentialManager
    {
        /// <summary>
        /// Begins an asynchronous request to retrieve the user's credentials.
        /// </summary>
        /// <param name="pParam">
        /// Pointer to an <see cref="MFNetCredentialManagerGetParam"/> structure. 
        /// </param>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface. 
        /// </param>
        /// <param name="pState">
        /// Pointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. The object is returned to the caller when the callback is
        /// invoked. 
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
        /// HRESULT BeginGetCredentials(
        ///   [in]  MFNetCredentialManagerGetParam *pParam,
        ///   [in]  IMFAsyncCallback *pCallback,
        ///   [in]  IUnknown *pState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FF11FF99-18BF-4C4C-93FD-31C06309F105(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FF11FF99-18BF-4C4C-93FD-31C06309F105(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginGetCredentials(
            [In] ref MFNetCredentialManagerGetParam pParam,
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pState
            );

        /// <summary>
        /// Completes an asynchronous request to retrieve the user's credentials.
        /// </summary>
        /// <param name="pResult">
        /// Pointer to an <see cref="IMFAsyncResult"/> interface that contains the asynchronous result. 
        /// </param>
        /// <param name="ppCred">
        /// Receives a pointer to the <see cref="IMFNetCredential"/> interface, which is used to retrieve the
        /// credentials. The caller must release the interface. 
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
        /// HRESULT EndGetCredentials(
        ///   [in]   IMFAsyncResult *pResult,
        ///   [out]  IMFNetCredential **ppCred
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/99914DED-1B9A-4373-9974-E1D1B1ABD4E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/99914DED-1B9A-4373-9974-E1D1B1ABD4E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndGetCredentials(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncResult pResult,
            [MarshalAs(UnmanagedType.Interface)] out IMFNetCredential ppCred
            );

        /// <summary>
        /// Specifies whether the user's credentials succeeded in the authentication challenge. The network
        /// source calls this method to informs the application whether the user's credentials were
        /// authenticated.
        /// </summary>
        /// <param name="pCred">
        /// Pointer to the <see cref="IMFNetCredential"/> interface. 
        /// </param>
        /// <param name="fGood">
        /// Boolean value. The value is <strong>TRUE</strong> if the credentials succeeded in the
        /// authentication challenge. Otherwise, the value is <strong>FALSE</strong>. 
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
        /// <a href="http://msdn.microsoft.com/en-US/library/F58E30BA-3E9B-41B5-9C13-0F9DAC541033(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F58E30BA-3E9B-41B5-9C13-0F9DAC541033(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetGood(
            [In, MarshalAs(UnmanagedType.Interface)] IMFNetCredential pCred,
            [In] bool fGood
            );
    }

#endif

}
