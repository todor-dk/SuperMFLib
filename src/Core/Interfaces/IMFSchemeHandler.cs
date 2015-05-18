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
    /// Creates a media source or a byte stream from a URL. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A342054E-2CB5-494A-A2F7-D144C72D1FA5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A342054E-2CB5-494A-A2F7-D144C72D1FA5(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("6D4C7B74-52A0-4BB7-B0DB-55F29F47A668")]
    internal interface IMFSchemeHandler
    {
        /// <summary>
        /// Begins an asynchronous request to create an object from a URL.
        /// <para/>
        /// When the <c>Source Resolver</c> creates a media source from a URL, it passes the request to a
        /// scheme handler. The scheme handler might create a media source directly from the URL, or it might
        /// return a byte stream. If it returns a byte stream, the source resolver use a byte-stream handler to
        /// create the media source from the byte stream. 
        /// </summary>
        /// <param name="pwszURL">
        /// A null-terminated string that contains the URL to resolve. 
        /// </param>
        /// <param name="dwFlags">
        /// A bitwise <strong>OR</strong> of one or more flags. See <c>Source Resolver Flags</c>. 
        /// </param>
        /// <param name="pProps">
        /// A pointer to the <strong>IPropertyStore</strong> interface of a property store. The scheme handler
        /// can use this property store to configure the object. This parameter can be <strong>NULL</strong>.
        /// For more information, see <c>Configuring a Media Source</c>. 
        /// </param>
        /// <param name="ppIUnknownCancelCookie">
        /// Receives an <strong>IUnknown</strong> pointer or the value <strong>NULL</strong>. If the value is
        /// not <strong>NULL</strong>, you can cancel the asynchronous operation by passing this pointer to the
        /// <see cref="IMFSchemeHandler.CancelObjectCreation"/> method. The caller must release the interface.
        /// This parameter can be <strong>NULL</strong>, in which case the <strong>IUnknown</strong> pointer is
        /// not returned to the caller. 
        /// </param>
        /// <param name="pCallback">
        /// A pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface. 
        /// </param>
        /// <param name="pUnkState">The p unk state.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_ACCESSDENIED</strong></term><description> Cannot open the URL with the requested access (read or write). </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_BYTESTREAM_TYPE</strong></term><description> Unsupported byte stream type. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginCreateObject(
        ///   [in]   LPCWSTR pwszURL,
        ///   [in]   DWORD dwFlags,
        ///   [in]   IPropertyStore *pProps,
        ///   [out]  IUnknown **ppIUnknownCancelCookie,
        ///   [in]   IMFAsyncCallback *pCallback,
        ///   [in]   IUnknown *punkState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/78858E8C-0EB3-4B62-84F0-76E9DFF0E3CE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/78858E8C-0EB3-4B62-84F0-76E9DFF0E3CE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginCreateObject(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszURL,
            [In] MFResolution dwFlags,
            [In, MarshalAs(UnmanagedType.Interface)] IPropertyStore pProps,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknownCancelCookie,
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkState
            );

        /// <summary>
        /// Completes an asynchronous request to create an object from a URL.
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your callback
        /// object received in the Invoke method. 
        /// </param>
        /// <param name="pObjectType">
        /// Receives a member of the <see cref="MFObjectType"/> enumeration, specifying the type of object that
        /// was created. 
        /// </param>
        /// <param name="ppObject">
        /// Receives a pointer to the <strong>IUnknown</strong> interface of the object. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_ABORT</strong></term><description>The operation was canceled.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EndCreateObject(
        ///   [in]   IMFAsyncResult *pResult,
        ///   [out]  MF_OBJECT_TYPE *pObjectType,
        ///   [out]  IUnknown **ppObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E3F88904-C30F-4D40-AC79-C83B0A06F1FA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E3F88904-C30F-4D40-AC79-C83B0A06F1FA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndCreateObject(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncResult pResult,
            out MFObjectType pObjectType,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppObject
            );

        /// <summary>
        /// Cancels the current request to create an object from a URL.
        /// </summary>
        /// <param name="pIUnknownCancelCookie">
        /// Pointer to the <strong>IUnknown</strong> interface that was returned in the <em>
        /// ppIUnknownCancelCookie</em> parameter of the <see cref="IMFSchemeHandler.BeginCreateObject"/>
        /// method. 
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
        /// HRESULT CancelObjectCreation(
        ///   [in]  IUnknown *pIUnknownCancelCookie
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/662A4C47-95F8-4A84-AB2B-96E51D13906C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/662A4C47-95F8-4A84-AB2B-96E51D13906C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CancelObjectCreation(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pIUnknownCancelCookie
            );
    }

#endif

}
