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
#if NOT_IN_USE

    /// <summary>
    /// Creates a media source from a byte stream. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/80C402D4-8246-42EE-A981-69C8D605CB0F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/80C402D4-8246-42EE-A981-69C8D605CB0F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("BB420AA4-765B-4A1F-91FE-D6A8A143924C"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFByteStreamHandler
    {
        /// <summary>
        /// Begins an asynchronous request to create a media source from a byte stream.
        /// </summary>
        /// <param name="pByteStream">
        /// Pointer to the byte stream's <see cref="IMFByteStream"/> interface. 
        /// </param>
        /// <param name="pwszURL">
        /// String that contains the original URL of the byte stream. This parameter can be <strong>NULL
        /// </strong>. 
        /// </param>
        /// <param name="dwFlags">
        /// Bitwise OR of zero or more flags. See <c>Source Resolver Flags</c>. 
        /// </param>
        /// <param name="pProps">
        /// Pointer to the <strong>IPropertyStore</strong> interface of a property store. The byte-stream
        /// handler can use this property store to configure the object. This parameter can be <strong>NULL
        /// </strong>. For more information, see <c>Configuring a Media Source</c>. 
        /// </param>
        /// <param name="ppIUnknownCancelCookie">
        /// Receives an <strong>IUnknown</strong> pointer or the value <strong>NULL</strong>. If the value is
        /// not <strong>NULL</strong>, you can cancel the asynchronous operation by passing this pointer to the
        /// <see cref="IMFByteStreamHandler.CancelObjectCreation"/> method. The caller must release the
        /// interface. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The caller must
        /// implement this interface. 
        /// </param>
        /// <param name="pUnkState">The p unk state.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_CANNOT_PARSE_BYTESTREAM</strong></term><description>Unable to parse the byte stream.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginCreateObject(
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
        /// <a href="http://msdn.microsoft.com/en-US/library/31DFFADD-4A5A-4306-80E9-9002782F092C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/31DFFADD-4A5A-4306-80E9-9002782F092C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginCreateObject(
            [In, MarshalAs(UnmanagedType.Interface)] IMFByteStream pByteStream,
            [In, MarshalAs(UnmanagedType.LPWStr)] string pwszURL,
            [In] MFResolution dwFlags,
            [In, MarshalAs(UnmanagedType.Interface)] IPropertyStore pProps,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknownCancelCookie,
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkState
            );

        /// <summary>
        /// Completes an asynchronous request to create a media source.
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
        /// Receives a pointer to the <strong>IUnknown</strong> interface of the media source. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_ABORT</strong></term><description>The operation was canceled. See <see cref="IMFByteStreamHandler.CancelObjectCreation"/>. </description></item>
        /// <item><term><strong>MF_E_CANNOT_PARSE_BYTESTREAM</strong></term><description>Unable to parse the byte stream.</description></item>
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
        /// <a href="http://msdn.microsoft.com/en-US/library/8FD9797A-8DFB-4E59-8BCB-52DC53B5BB2E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8FD9797A-8DFB-4E59-8BCB-52DC53B5BB2E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndCreateObject(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncResult pResult,
            out MFObjectType pObjectType,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppObject
            );

        /// <summary>
        /// Cancels the current request to create a media source.
        /// </summary>
        /// <param name="pIUnknownCancelCookie">
        /// Pointer to the <strong>IUnknown</strong> interface that was returned in the <em>
        /// ppIUnknownCancelCookie</em> parameter of the <see cref="IMFByteStreamHandler.BeginCreateObject"/>
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
        /// <a href="http://msdn.microsoft.com/en-US/library/9731DAC4-879C-4CBC-97B4-FA596B20C033(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9731DAC4-879C-4CBC-97B4-FA596B20C033(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CancelObjectCreation(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pIUnknownCancelCookie
            );

        /// <summary>
        /// Retrieves the maximum number of bytes needed to create the media source or determine that the byte
        /// stream handler cannot parse this stream.
        /// </summary>
        /// <param name="pqwBytes">
        /// Receives the maximum number of bytes that are required.
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
        /// HRESULT GetMaxNumberOfBytesRequiredForResolution(
        ///   [out]  QWORD *pqwBytes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E90C5BC6-FC0A-4478-AA65-9DC6618F46F0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E90C5BC6-FC0A-4478-AA65-9DC6618F46F0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMaxNumberOfBytesRequiredForResolution(
            out long pqwBytes
            );
    }

#endif
}
