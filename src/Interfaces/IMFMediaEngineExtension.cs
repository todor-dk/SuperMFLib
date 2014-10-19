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
using System.Runtime.InteropServices;

using MediaFoundation.Misc;
using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Enables an application to load media resources in the Media Engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A032E0D0-2201-4B81-9FE0-8E9CE2707FDB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A032E0D0-2201-4B81-9FE0-8E9CE2707FDB(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("2f69d622-20b5-41e9-afdf-89ced1dda04e"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaEngineExtension
    {
        /// <summary>
        /// Queries whether the object can load a specified type of media resource.
        /// </summary>
        /// <param name="AudioOnly">
        /// If <strong>TRUE</strong>, the Media Engine is set to audio-only mode. Otherwise, the Media Engine
        /// is set to audio-video mode. 
        /// </param>
        /// <param name="MimeType">
        /// A string that contains a MIME type with an optional codecs parameter, as defined in RFC 4281.
        /// </param>
        /// <param name="pAnswer">
        /// Receives a member of the <see cref="MF_MEDIA_ENGINE_CANPLAY"/> enumeration. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CanPlayType(
        ///   [in]   BOOL AudioOnly,
        ///   [in]   BSTR MimeType,
        ///   [out]  MF_MEDIA_ENGINE_CANPLAY *pAnswer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F715B4CB-363E-4EF2-962C-C0AFB26B088E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F715B4CB-363E-4EF2-962C-C0AFB26B088E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CanPlayType(
            [MarshalAs(UnmanagedType.Bool)] bool AudioOnly,
            [MarshalAs(UnmanagedType.BStr)] string MimeType,
            out MF_MEDIA_ENGINE_CANPLAY pAnswer
            );

        /// <summary>
        /// Begins an asynchronous request to create either a byte stream or a media source.
        /// </summary>
        /// <param name="bstrURL">
        /// The URL of the media resource.
        /// </param>
        /// <param name="pByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface. 
        /// <para/>
        /// If the <em>type</em> parameter equals <strong>MF_OBJECT_BYTESTREAM</strong>, this parameter is 
        /// <strong>NULL</strong>. 
        /// <para/>
        /// If <em>type</em> equals <strong>MF_OBJECT_MEDIASOURCE</strong>, this parameter either contains a
        /// pointer to a byte stream or is <strong>NULL</strong>. See Remarks for more information. 
        /// </param>
        /// <param name="type">
        /// A member of the <see cref="MFObjectType"/> enumeration that specifies which type of object to
        /// create. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>MF_OBJECT_BYTESTREAM</strong></term><description>Create a byte stream. The byte stream must support the <see cref="IMFByteStream"/> interface. </description></item>
        /// <item><term><strong>MF_OBJECT_MEDIASOURCE</strong></term><description>Create a media source. The media source must support the <see cref="IMFMediaSource"/> interface. </description></item>
        /// </list>
        /// </param>
        /// <param name="ppIUnknownCancelCookie">
        /// Receives a pointer to the <c>IUnknown</c> interface. This pointer can be used to cancel the
        /// asynchronous operation, by passing the pointer to the 
        /// <see cref="IMFMediaEngineExtension.CancelObjectCreation"/> method. 
        /// <para/>
        /// The caller must release the interface. This parameter can be NULL.
        /// </param>
        /// <param name="pCallback">
        /// A pointer to the <see cref="IMFAsyncCallback"/> interface. This interface is used to signal the
        /// completion of the asynchronous operation. 
        /// </param>
        /// <param name="punkState">
        /// A pointer to the <c>IUnknown</c> interface of an object impemented by the caller. You can use this
        /// object to hold state information for the callback. The object is returned to the caller when the
        /// callback is invoked. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT BeginCreateObject(
        ///   [in]            BSTR bstrURL,
        ///   [in]            IMFByteStream *pByteStream,
        ///   [in]            MF_OBJECT_TYPE type,
        ///   [out]           IUnknown **ppIUnknownCancelCookie,
        ///   [in]            IMFAsyncCallback *pCallback,
        ///   [in, optional]  IUnknown *punkState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/804E9F16-E4C9-41F6-8913-950A569FB835(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/804E9F16-E4C9-41F6-8913-950A569FB835(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginCreateObject(
            [MarshalAs(UnmanagedType.BStr)] string bstrURL,
            IMFByteStream pByteStream,
            MFObjectType type,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknownCancelCookie,
            IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object punkState
            );

        /// <summary>
        /// Cancels the current request to create an object.
        /// </summary>
        /// <param name="pIUnknownCancelCookie">
        /// The pointer that was returned in the the <em>ppIUnknownCancelCookie</em> parameter of the 
        /// <see cref="IMFMediaEngineExtension.BeginCreateObject"/> method. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT CancelObjectCreation(
        ///   [in]  IUnknown *pIUnknownCancelCookie
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E2FEC865-221E-41B5-8271-32A53D60619E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E2FEC865-221E-41B5-8271-32A53D60619E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CancelObjectCreation(
            [In, MarshalAs(UnmanagedType.IUnknown)] object pIUnknownCancelCookie
            );

        /// <summary>
        /// Completes an asynchronous request to create a byte stream or media source.
        /// </summary>
        /// <param name="pResult">
        /// A pointer to the <see cref="IMFAsyncResult"/> interface. 
        /// </param>
        /// <param name="ppObject">
        /// Receives a pointer to the <c>IUnknown</c> interface of the byte stream or media source. The caller
        /// must release the interface 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT EndCreateObject(
        ///   [in]   IMFAsyncResult *pResult,
        ///   [out]  IUnknown **ppObject
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F2B19870-7529-4C8C-9FE6-B312F6A2D2ED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F2B19870-7529-4C8C-9FE6-B312F6A2D2ED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndCreateObject(
            IMFAsyncResult pResult,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppObject
            );
    }

#endif

}
