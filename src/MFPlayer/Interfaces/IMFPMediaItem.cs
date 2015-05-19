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
using System.Runtime.InteropServices.ComTypes;
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;

namespace MediaFoundation.MFPlayer.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// <strong>Note</strong> Deprecated. This API may be removed from future releases of Windows.
    /// Applications should use the <c>Media Session</c> for playback. 
    /// <para/>
    /// Represents a media item. A <em>media item</em> is an abstraction for a source of media data, such
    /// as a video file. Use this interface to get information about the source, or to change certain
    /// playback settings, such as the start and stop times. To get a pointer to this interface, call one
    /// of the following methods: 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/2839D256-BDAF-40CF-9F9D-46F9E2CE59E8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2839D256-BDAF-40CF-9F9D-46F9E2CE59E8(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Obsolete("Applications should use the Media Session for playback.")]
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("90EB3E6B-ECBF-45cc-B1DA-C6FE3EA70D57")]
    internal interface IMFPMediaItem
    {
        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets a pointer to the MFPlay player object that created the media item.
        /// </summary>
        /// <param name="ppMediaPlayer">
        /// Receives a pointer to the player object's <see cref="MFPlayer.IMFPMediaPlayer"/> interface. The
        /// caller must release the interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetMediaPlayer(
        ///   [out]  IMFPMediaPlayer **ppMediaPlayer
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6D6F822A-D599-437E-A73A-2242D4D3FE3A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6D6F822A-D599-437E-A73A-2242D4D3FE3A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMediaPlayer(
            out IMFPMediaPlayer ppMediaPlayer
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the URL that was used to create the media item.
        /// </summary>
        /// <param name="ppwszURL">
        /// Receives a pointer to a null-terminated string that contains the URL. The caller must free the
        /// string by calling <c>CoTaskMemFree</c>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOTFOUND</strong></term><description>No URL is associated with this media item.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The <see cref="MFPlayer.IMFPMediaPlayer.Shutdown"/> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetURL(
        ///   [out]  LPWSTR *ppwszURL
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2598534C-28CC-4F4C-BF87-17AB7044E0C1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2598534C-28CC-4F4C-BF87-17AB7044E0C1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetURL(
            [MarshalAs(UnmanagedType.LPWStr)] out string ppwszURL
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the object that was used to create the media item.
        /// </summary>
        /// <param name="ppIUnknown">
        /// Receives a pointer to the object's <strong>IUnknown</strong> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOTFOUND</strong></term><description>The media item was created from a URL, not from an object.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The <see cref="MFPlayer.IMFPMediaPlayer.Shutdown"/> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetObject(
        ///   [out]  IUnknown **ppIUnknown
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6A6ABC57-149D-4E4B-A29F-7B712D24E6DF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6A6ABC57-149D-4E4B-A29F-7B712D24E6DF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetObject(
            [MarshalAs(UnmanagedType.IUnknown)] out object ppIUnknown
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the application-defined value stored in the media item.
        /// </summary>
        /// <param name="pdwUserData">
        /// Receives the application-defined value for the media item.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetUserData(
        ///   [out]  DWORD_PTR *pdwUserData
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AA99CED1-C32B-4BF5-B29A-E16ECEDDFED1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AA99CED1-C32B-4BF5-B29A-E16ECEDDFED1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetUserData(
            out IntPtr pdwUserData
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Stores an application-defined value in the media item.
        /// </summary>
        /// <param name="dwUserData">
        /// The application-defined value.
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetUserData(
        ///   [in]  DWORD_PTR dwUserData
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/17A10427-F13A-494C-BB68-A7722E8D9B6E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/17A10427-F13A-494C-BB68-A7722E8D9B6E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetUserData(
            IntPtr dwUserData
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the start and stop times for the media item.
        /// </summary>
        /// <param name="pguidStartPositionType">
        /// Receives the unit of time for the start position. See Remarks. This parameter can be <strong>NULL
        /// </strong>. 
        /// </param>
        /// <param name="pvStartValue">
        /// Receives the start position. The meaning and data type of this parameter are indicated by the <em>
        /// pguidStartPositionType</em> parameter. The <em>pvStartValue</em> parameter must be <strong>NULL
        /// </strong> if <em>pguidStartPositionType</em> is <strong>NULL</strong>, and cannot be <strong>NULL
        /// </strong> otherwise. 
        /// </param>
        /// <param name="pguidStopPositionType">
        /// Receives the unit of time for the stop position. See Remarks. This parameter can be <strong>NULL
        /// </strong>. 
        /// </param>
        /// <param name="pvStopValue">
        /// Stop position. The meaning and data type of this parameter are indicated by the <em>
        /// pguidStopPositionType</em> parameter. The <em>pvStopValue</em> parameter must be <strong>NULL
        /// </strong> if <em>pguidStopPositionType</em> is <strong>NULL</strong>, and cannot be <strong>NULL
        /// </strong> otherwise. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStartStopPosition(
        ///   [out]  GUID *pguidStartPositionType,
        ///   [out]  PROPVARIANT *pvStartValue,
        ///   [out]  GUID *pguidStopPositionType,
        ///   [out]  PROPVARIANT *pvStopValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C992BBEC-A5CA-4ECE-A883-2A7D7B5D49B3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C992BBEC-A5CA-4ECE-A883-2A7D7B5D49B3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStartStopPosition(
            out Guid pguidStartPositionType,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PropVariantMarshaler))] PropVariant pvStartValue,
            out Guid pguidStopPositionType,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PropVariantMarshaler))] PropVariant pvStopValue
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Sets the start and stop time for the media item.
        /// </summary>
        /// <param name="pguidStartPositionType">
        /// Unit of time for the start position. See Remarks. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pvStartValue">
        /// Start position. The meaning and data type of this parameter are indicated by the <em>
        /// pguidStartPositionType</em> parameter. The <em>pvStartValue</em> parameter must be <strong>NULL
        /// </strong> if <em>pguidStartPositionType</em> is <strong>NULL</strong>, and cannot be <strong>NULL
        /// </strong> otherwise. 
        /// </param>
        /// <param name="pguidStopPositionType">
        /// Unit of time for the stop position. See Remarks. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pvStopValue">
        /// Stop position. The meaning and data type of this parameter are indicated by the <em>
        /// pguidStopPositionType</em> parameter. The <em>pvStopValue</em> parameter must be <strong>NULL
        /// </strong> if <em>pguidStopPositionType</em> is <strong>NULL</strong>, and cannot be <strong>NULL
        /// </strong> otherwise. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid argument.</description></item>
        /// <item><term><strong>MF_E_OUT_OF_RANGE</strong></term><description>Invalid start or stop time. Any of the following can cause this error:<para>* Time less than zero.</para><para>* Time greater than the total duration of the media item.</para><para>* Stop time less than start time.</para></description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetStartStopPosition(
        ///   [in]  const GUID *pguidStartPositionType,
        ///   [in]  const PROPVARIANT *pvStartValue,
        ///   [in]  const GUID *pguidStopPositionType,
        ///   [in]  const PROPVARIANT *pvStopValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8F0409A6-1911-47EE-AC65-68B87D6B1DB5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8F0409A6-1911-47EE-AC65-68B87D6B1DB5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetStartStopPosition(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid pguidStartPositionType,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvStartValue,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid pguidStopPositionType,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvStopValue
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Queries whether the media item contains a video stream.
        /// </summary>
        /// <param name="pfHasVideo">
        /// Receives the value <strong>TRUE</strong> if the media item contains at least one video stream, or 
        /// <strong>FALSE</strong> otherwise. 
        /// </param>
        /// <param name="pfSelected">
        /// Receives the value <strong>TRUE</strong> if at least one video stream is selected, or <strong>FALSE
        /// </strong> otherwise. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT HasVideo(
        ///   [out]  BOOL *pfHasVideo,
        ///   [out]  BOOL *pfSelected
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6DC8A85C-25E4-4DA7-965D-C8882514FC7D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6DC8A85C-25E4-4DA7-965D-C8882514FC7D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int HasVideo(
            [MarshalAs(UnmanagedType.Bool)] out bool pfHasVideo,
            [MarshalAs(UnmanagedType.Bool)] out bool pfSelected
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Queries whether the media item contains an audio stream.
        /// </summary>
        /// <param name="pfHasAudio">
        /// Receives the value <strong>TRUE</strong> if the media item contains at least one audio stream, or 
        /// <strong>FALSE</strong> otherwise. 
        /// </param>
        /// <param name="pfSelected">
        /// Receives the value <strong>TRUE</strong> if at least one audio stream is selected, or <strong>FALSE
        /// </strong> otherwise. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT HasAudio(
        ///   [out]  BOOL *pfHasAudio,
        ///   [out]  BOOL *pfSelected
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/38D308D7-77E3-4F13-82E7-677AC94234E7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/38D308D7-77E3-4F13-82E7-677AC94234E7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int HasAudio(
            [MarshalAs(UnmanagedType.Bool)] out bool pfHasAudio,
            [MarshalAs(UnmanagedType.Bool)] out bool pfSelected
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Queries whether the media item contains protected content.
        /// <para/>
        /// <strong>Note</strong> Currently <see cref="MFPlayer.IMFPMediaPlayer"/> does not support playing
        /// protected content. 
        /// </summary>
        /// <param name="pfProtected">
        /// Receives one of the following values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>TRUE</strong></term><description>The media item contains protected content. Attempting to play this media item will cause a playback error.</description></item>
        /// <item><term><strong>FALSE</strong></term><description>The media item does not contain protected content.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT IsProtected(
        ///   [out]  BOOL *pfProtected
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E4AE8B5E-7657-476C-83F9-C27DE858E328(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E4AE8B5E-7657-476C-83F9-C27DE858E328(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int IsProtected(
            [MarshalAs(UnmanagedType.Bool)] out bool pfProtected
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the duration of the media item.
        /// </summary>
        /// <param name="guidPositionType">
        /// Specifies the unit of time for the duration value. The following value is defined.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>MFP_POSITIONTYPE_100NS</strong></term><description>100-nanosecond units. The value returned in <em>pvDurationValue</em> is a <strong>LARGE_INTEGER</strong>. <para>* Variant type ( <strong>vt</strong>): VT_I8 </para><para>* Variant member: <strong>hVal</strong></para></description></item>
        /// </list>
        /// </param>
        /// <param name="pvDurationValue">
        /// Pointer to a <strong>PROPVARIANT</strong> that receives the duration. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetDuration(
        ///   [in]   REFGUID guidPositionType,
        ///   [out]  PROPVARIANT *pvDurationValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/831F023B-C06F-4099-9F4C-DF38F3D1382F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/831F023B-C06F-4099-9F4C-DF38F3D1382F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetDuration(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidPositionType,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PropVariantMarshaler))] PropVariant pvDurationValue
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets the number of streams (audio, video, and other) in the media item.
        /// </summary>
        /// <param name="pdwStreamCount">
        /// Receives the number of streams.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetNumberOfStreams(
        ///   [out]  DWORD *pdwStreamCount
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/65A3CFC8-9171-4206-B1B6-54BB0D3ECDD1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/65A3CFC8-9171-4206-B1B6-54BB0D3ECDD1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetNumberOfStreams(
            out int pdwStreamCount
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Queries whether a stream is selected to play.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// Zero-based index of the stream. To get the number of streams, call 
        /// <see cref="MFPlayer.IMFPMediaItem.GetNumberOfStreams"/>. 
        /// </param>
        /// <param name="pfEnabled">
        /// Receives a Boolean value.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>TRUE</strong></term><description>The stream is selected. During playback, this stream will play.</description></item>
        /// <item><term><strong>FALSE</strong></term><description>The stream is not selected. During playback, this stream will not play.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamSelection(
        ///   [in]   DWORD dwStreamIndex,
        ///   [out]  BOOL *pfEnabled
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/808DE13B-123F-4B9C-B2E6-6C0A6F4339FC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/808DE13B-123F-4B9C-B2E6-6C0A6F4339FC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamSelection(
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.Bool)] out bool pfEnabled
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Selects or deselects a stream.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// Zero-based index of the stream. To get the number of streams, call 
        /// <see cref="MFPlayer.IMFPMediaItem.GetNumberOfStreams"/>. 
        /// </param>
        /// <param name="fEnabled">
        /// Specify whether to select or deselect the stream.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>TRUE</strong></term><description>The stream is selected. During playback, this stream will play.</description></item>
        /// <item><term><strong>FALSE</strong></term><description>The stream is not selected. During playback, this stream will not play.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetStreamSelection(
        ///   [in]  DWORD dwStreamIndex,
        ///   [in]  BOOL fEnabled
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/739190A5-60A7-4B50-9919-F68D2CD6DA8D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/739190A5-60A7-4B50-9919-F68D2CD6DA8D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetStreamSelection(
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.Bool)] bool fEnabled
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Queries the media item for a stream attribute.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// Zero-based index of the stream. To get the number of streams, call 
        /// <see cref="MFPlayer.IMFPMediaItem.GetNumberOfStreams"/>. 
        /// </param>
        /// <param name="guidMFAttribute">
        /// GUID that identifies the attribute value to query. Possible values are listed in the following
        /// topics:
        /// <para/>
        /// <para>* <c>Stream Descriptor Attributes</c></para><para>* <c>Media Type Attributes</c></para>
        /// </param>
        /// <param name="pvValue">
        /// Pointer to a <strong>PROPVARIANT</strong> that receives the value. The method fills the <strong>
        /// PROPVARIANT</strong> with a copy of the stored value. Call <strong>PropVariantClear</strong> to
        /// free the memory allocated by this method. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamAttribute(
        ///   [in]   DWORD dwStreamIndex,
        ///   [in]   REFGUID guidMFAttribute,
        ///   [out]  PROPVARIANT *pvValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8C40CE33-2077-4E7B-8A1C-C080E82DF078(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8C40CE33-2077-4E7B-8A1C-C080E82DF078(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamAttribute(
            int dwStreamIndex,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidMFAttribute,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PropVariantMarshaler))] PropVariant pvValue
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Queries the media item for a presentation attribute.
        /// </summary>
        /// <param name="guidMFAttribute">
        /// GUID that identifies the attribute value to query.
        /// <para/>
        /// For a list of presentation attributes, see <c>Presentation Descriptor Attributes</c>. 
        /// </param>
        /// <param name="pvValue">
        /// Pointer to a <strong>PROPVARIANT</strong> that receives the value. The method fills the <strong>
        /// PROPVARIANT</strong> with a copy of the stored value. Call <strong>PropVariantClear</strong> to
        /// free the memory allocated by the method. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetPresentationAttribute(
        ///   [in]   REFGUID guidMFAttribute,
        ///   [out]  PROPVARIANT *pvValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D6600009-A8DA-4464-9DF7-08F20A1A6B15(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D6600009-A8DA-4464-9DF7-08F20A1A6B15(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetPresentationAttribute(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidMFAttribute,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PropVariantMarshaler))] PropVariant pvValue
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets various flags that describe the media item.
        /// </summary>
        /// <param name="pCharacteristics">
        /// Receives a bitwise <strong>OR</strong> of flags from the <c>_MFP_MEDIAITEM_CHARACTERISTICS</c>
        /// enumeration. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCharacteristics(
        ///   [out]  MFP_MEDIAITEM_CHARACTERISTICS *pCharacteristics
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9FE65644-C7A0-4AF5-9765-F933215F5F83(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9FE65644-C7A0-4AF5-9765-F933215F5F83(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCharacteristics(
            out MFP_MEDIAITEM_CHARACTERISTICS pCharacteristics
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Sets a media sink for the media item. A <em>media sink</em> is an object that consumes the data
        /// from one or more streams. 
        /// </summary>
        /// <param name="dwStreamIndex">
        /// Zero-based index of a stream on the media source. The media sink will receive the data from this
        /// stream.
        /// </param>
        /// <param name="pMediaSink">
        /// <strong>IUnknown</strong> pointer that specifies the media sink. Pass in one of the following: 
        /// <para/>
        /// <para>* A pointer to a stream sink. Every media sink contains one or more <em>stream sinks</em>.
        /// Each stream sink receives the data from one stream. The stream sink must expose the 
        /// <see cref="IMFStreamSink"/> interface. </para><para>* A pointer to an activation object that
        /// creates the media sink. The activation object must expose the <see cref="IMFActivate"/> interface.
        /// The media item uses the first stream sink on the media sink (that is, the stream sink at index 0). 
        /// </para><para>* <strong>NULL</strong>. If you set <em>pMediaSink</em> to <strong>NULL</strong>, the
        /// default media sink for the stream type is used. </para>
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetStreamSink(
        ///   [in]  DWORD dwStreamIndex,
        ///   [in]  IUnknown *pMediaSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/97ED9CC0-5F69-4ECB-98C7-C58130B91D7C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/97ED9CC0-5F69-4ECB-98C7-C58130B91D7C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetStreamSink(
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.IUnknown)] object pMediaSink
        );

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Gets a property store that contains metadata for the source, such as author or title.
        /// </summary>
        /// <param name="ppMetadataStore">
        /// Receives a pointer to the <strong>IPropertyStore</strong> interface of a read-only property store.
        /// The caller must release the interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetMetadata(
        ///   [out]  IPropertyStore **ppMetadataStore
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/212D468F-DE5E-4A55-AAA4-ED487BBF6A00(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/212D468F-DE5E-4A55-AAA4-ED487BBF6A00(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMetadata(
            out IPropertyStore ppMetadataStore
        );
    }

#endif

}
