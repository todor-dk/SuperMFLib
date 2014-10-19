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
    /// Creates a media source from a URL or a byte stream. The <c>Source Resolver</c> implements this
    /// interface. To create the source resolver, call <see cref="MFExtern.MFCreateSourceResolver"/>
    /// function. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/079C61C5-7A29-4411-840E-9349190726AC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/079C61C5-7A29-4411-840E-9349190726AC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("FBE5A32D-A497-4B61-BB85-97B1A848A6E3"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFSourceResolver
    {
        /// <summary>
        /// Creates a media source or a byte stream from a URL. This method is synchronous. 
        /// </summary>
        /// <param name="pwszURL">
        /// Null-terminated string that contains the URL to resolve. 
        /// </param>
        /// <param name="dwFlags">
        /// Bitwise OR of one or more flags. See <c>Source Resolver Flags</c>. 
        /// </param>
        /// <param name="pProps">
        /// Pointer to the <strong>IPropertyStore</strong> interface of a property store. The method passes the
        /// property store to the scheme handler or byte-stream handler that creates the object. The handler
        /// can use the property store to configure the object. This parameter can be <strong>NULL</strong>.
        /// For more information, see <c>Configuring a Media Source</c>. 
        /// </param>
        /// <param name="pObjectType">
        /// Receives a member of the <see cref="MFObjectType"/> enumeration, specifying the type of object that
        /// was created. 
        /// </param>
        /// <param name="ppObject">
        /// Receives a pointer to the object's <strong>IUnknown</strong> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_SOURCERESOLVER_MUTUALLY_EXCLUSIVE_FLAGS</strong></term><description> The <em>dwFlags</em> parameter contains mutually exclusive flags. </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_SCHEME</strong></term><description> The URL scheme is not supported. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CreateObjectFromURL(
        ///   [in]   LPCWSTR pwszURL,
        ///   [in]   DWORD dwFlags,
        ///   [in]   IPropertyStore *pProps,
        ///   [out]  MF_OBJECT_TYPE *pObjectType,
        ///   [out]  IUnknown **ppObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B8F751B1-6456-4D67-839D-ECFA388E8D71(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B8F751B1-6456-4D67-839D-ECFA388E8D71(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateObjectFromURL(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszURL,
            [In] MFResolution dwFlags,
            IPropertyStore pProps,
            out MFObjectType pObjectType,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppObject
            );

        /// <summary>
        /// Creates a media source from a byte stream. This method is synchronous. 
        /// </summary>
        /// <param name="pByteStream">
        /// Pointer to the byte stream's <see cref="IMFByteStream"/> interface. 
        /// </param>
        /// <param name="pwszURL">
        /// Null-terminated string that contains the URL of the byte stream. The URL is optional and can be 
        /// <strong>NULL</strong>. See Remarks for more information. 
        /// </param>
        /// <param name="dwFlags">
        /// Bitwise <strong>OR</strong> of flags. See <c>Source Resolver Flags</c>. 
        /// </param>
        /// <param name="pProps">
        /// Pointer to the <strong>IPropertyStore</strong> interface of a property store. The method passes the
        /// property store to the byte-stream handler. The byte-stream handler can use the property store to
        /// configure the media source. This parameter can be <strong>NULL</strong>. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// </param>
        /// <param name="pObjectType">
        /// Receives a member of the <see cref="MFObjectType"/> enumeration, specifying the type of object that
        /// was created. 
        /// </param>
        /// <param name="ppObject">
        /// Receives a pointer to the media source's <strong>IUnknown</strong> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_SOURCERESOLVER_MUTUALLY_EXCLUSIVE_FLAGS</strong></term><description> The <em>dwFlags</em> parameter contains mutually exclusive flags. </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_BYTESTREAM_TYPE</strong></term><description> This byte stream is not supported. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CreateObjectFromByteStream(
        ///   [in]   IMFByteStream *pByteStream,
        ///   [in]   LPCWSTR pwszURL,
        ///   [in]   DWORD dwFlags,
        ///   [in]   IPropertyStore *pProps,
        ///   [out]  MF_OBJECT_TYPE *pObjectType,
        ///   [out]  IUnknown **ppObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E4A4AAD5-0924-4251-B0DA-6919AE010BF0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E4A4AAD5-0924-4251-B0DA-6919AE010BF0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CreateObjectFromByteStream(
            [In, MarshalAs(UnmanagedType.Interface)] IMFByteStream pByteStream,
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszURL,
            [In] MFResolution dwFlags,
            [In, MarshalAs(UnmanagedType.Interface)] IPropertyStore pProps,
            out MFObjectType pObjectType,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppObject
            );

        /// <summary>
        /// Begins an asynchronous request to create a media source or a byte stream from a URL.
        /// </summary>
        /// <param name="pwszURL">
        /// Null-terminated string that contains the URL to resolve.
        /// </param>
        /// <param name="dwFlags">
        /// Bitwise OR of flags. See <c>Source Resolver Flags</c>. 
        /// </param>
        /// <param name="pProps">
        /// Pointer to the <strong>IPropertyStore</strong> interface of a property store. The method passes the
        /// property store to the scheme handler or byte-stream handler that creates the object. The handler
        /// can use the property store to configure the object. This parameter can be <strong>NULL</strong>.
        /// For more information, see <c>Configuring a Media Source</c>. 
        /// </param>
        /// <param name="ppIUnknownCancelCookie">
        /// Receives an <strong>IUnknown</strong> pointer or the value <strong>NULL</strong>. If the value is
        /// not <strong>NULL</strong>, you can cancel the asynchronous operation by passing this pointer to the
        /// <see cref="IMFSourceResolver.CancelObjectCreation"/> method. The caller must release the interface.
        /// This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface. 
        /// </param>
        /// <param name="punkState">
        /// Pointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SOURCERESOLVER_MUTUALLY_EXCLUSIVE_FLAGS</strong></term><description>The <em>dwFlags</em> parameter contains mutually exclusive flags. </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_SCHEME</strong></term><description>The URL scheme is not supported.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT BeginCreateObjectFromURL(
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
        /// <a href="http://msdn.microsoft.com/en-US/library/BC97C1FB-D23A-4887-B6AC-0751C254A405(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BC97C1FB-D23A-4887-B6AC-0751C254A405(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginCreateObjectFromURL(
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszURL,
            MFResolution dwFlags,
            IPropertyStore pProps,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknownCancelCookie,
            IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object punkState
            );

        /// <summary>
        /// Completes an asynchronous request to create an object from a URL. 
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your callback
        /// object received in the <c>Invoke</c> method. 
        /// </param>
        /// <param name="pObjectType">
        /// Receives a member of the <see cref="MFObjectType"/> enumeration, specifying the type of object that
        /// was created. 
        /// </param>
        /// <param name="ppObject">
        /// Receives a pointer to the media source's <strong>IUnknown</strong> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_ABORT</strong></term><description> The operation was canceled. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT EndCreateObjectFromURL(
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
        /// <a href="http://msdn.microsoft.com/en-US/library/AF50A76D-B083-4815-BBFF-820B21FF8D1B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AF50A76D-B083-4815-BBFF-820B21FF8D1B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndCreateObjectFromURL(
            IMFAsyncResult pResult,
            out MFObjectType pObjectType,
            [MarshalAs(UnmanagedType.Interface)] out object ppObject
            );

        /// <summary>
        /// Begins an asynchronous request to create a media source from a byte stream.
        /// </summary>
        /// <param name="pByteStream">
        /// A pointer to the byte stream's <see cref="IMFByteStream"/> interface. 
        /// </param>
        /// <param name="pwszURL">
        /// A null-terminated string that contains the original URL of the byte stream. This parameter can be 
        /// <strong>NULL</strong>. 
        /// </param>
        /// <param name="dwFlags">
        /// A bitwise <strong>OR</strong> of one or more flags. See <c>Source Resolver Flags</c>. 
        /// </param>
        /// <param name="pProps">
        /// A pointer to the <strong>IPropertyStore</strong> interface of a property store. The method passes
        /// the property store to the byte-stream handler. The byte-stream handler can use the property store
        /// to configure the media source. This parameter can be <strong>NULL</strong>. For more information,
        /// see <c>Configuring a Media Source</c>. 
        /// </param>
        /// <param name="ppIUnknownCancelCookie">
        /// Receives an <strong>IUnknown</strong> pointer or the value <strong>NULL</strong>. If the value is
        /// not <strong>NULL</strong>, you can cancel the asynchronous operation by passing this pointer to the
        /// <see cref="IMFSourceResolver.CancelObjectCreation"/> method. The caller must release the interface.
        /// This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pCallback">
        /// A pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface. 
        /// </param>
        /// <param name="punkState">
        /// A oointer to the <strong>IUnknown</strong> interface of a state object, defined by the caller. This
        /// parameter can be <strong>NULL</strong>. You can use this object to hold state information. The
        /// object is returned to the caller when the callback is invoked. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SOURCERESOLVER_MUTUALLY_EXCLUSIVE_FLAGS</strong></term><description>The <em>dwFlags</em> parameter contains mutually exclusive flags. </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_BYTESTREAM_TYPE</strong></term><description>The byte stream is not supported.</description></item>
        /// <item><term><strong>MF_E_BYTESTREAM_NOT_SEEKABLE</strong></term><description>The byte stream does not support seeking.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT BeginCreateObjectFromByteStream(
        ///   [in]   IMFByteStream *pByteStream,
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
        /// <a href="http://msdn.microsoft.com/en-US/library/6E218B93-4855-40DD-96CC-C4EE02792C14(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6E218B93-4855-40DD-96CC-C4EE02792C14(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginCreateObjectFromByteStream(
            [In, MarshalAs(UnmanagedType.Interface)] IMFByteStream pByteStream,
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszURL,
            [In] MFResolution dwFlags,
            IPropertyStore pProps,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknownCancelCookie,
            IMFAsyncCallback pCallback,
            [MarshalAs(UnmanagedType.IUnknown)] object punkState
           );

        /// <summary>
        /// Completes an asynchronous request to create a media source from a byte stream.
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your callback
        /// object received in the <c>Invoke</c> method. 
        /// </param>
        /// <param name="pObjectType">
        /// Receives a member of the <see cref="MFObjectType"/> enumeration, specifying the type of object that
        /// was created. 
        /// </param>
        /// <param name="ppObject">
        /// Receives a pointer to the media source's <strong>IUnknown</strong> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_ABORT</strong></term><description>The application canceled the operation.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT EndCreateObjectFromByteStream(
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
        /// <a href="http://msdn.microsoft.com/en-US/library/54532C0E-772B-45B6-95A3-5959023B9BC8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/54532C0E-772B-45B6-95A3-5959023B9BC8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndCreateObjectFromByteStream(
            IMFAsyncResult pResult,
            out MFObjectType pObjectType,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppObject
            );

        /// <summary>
        /// Cancels an asynchronous request to create an object. 
        /// </summary>
        /// <param name="pIUnknownCancelCookie">The p i unknown cancel cookie.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CancelObjectCreation(
        ///   [in]  IUnknown **ppIUnknownCancelCookie
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6A30AC92-A281-4293-8975-987FA25A5318(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6A30AC92-A281-4293-8975-987FA25A5318(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CancelObjectCreation(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pIUnknownCancelCookie
            );
    }

}
