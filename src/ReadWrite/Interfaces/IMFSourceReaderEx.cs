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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation.ReadWrite
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Extends the <see cref="ReadWrite.IMFSourceReader"/> interface. 
    /// <para/>
    /// The <c>Source Reader</c> implements this interface in Windows 8. To get a pointer to this
    /// interface, call <c>QueryInterface</c> on the Source Reader. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/59888F9B-C464-4045-AA77-03EE16E2B598(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/59888F9B-C464-4045-AA77-03EE16E2B598(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("7b981cf0-560e-4116-9875-b099895f23d7")]
    public interface IMFSourceReaderEx : IMFSourceReader
    {
        #region IMFSourceReader Methods

        /// <summary>
        /// Queries whether a stream is selected.
        /// </summary>
        /// <param name="dwStreamIndex">The stream to query. The value can be any of the following.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item></list></param>
        /// <param name="pfSelected">Receives <strong>TRUE</strong> if the stream is selected and will generate data. Receives <strong>
        /// FALSE</strong> if the stream is not selected and will not generate data.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamSelection(
        /// [in]   DWORD dwStreamIndex,
        /// [out]  BOOL *pfSelected
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/40301426-4BF2-442C-91B5-9916D1314617(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/40301426-4BF2-442C-91B5-9916D1314617(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetStreamSelection(
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.Bool)] out bool pfSelected
        );

        /// <summary>
        /// Selects or deselects one or more streams.
        /// </summary>
        /// <param name="dwStreamIndex">The stream to set. The value can be any of the following.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_ALL_STREAMS</strong></strong>0xFFFFFFFE</term><description>All streams.</description></item></list></param>
        /// <param name="fSelected">Specify <strong>TRUE</strong> to select streams or <strong>FALSE</strong> to deselect streams. If a
        /// stream is deselected, it will not generate data.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetStreamSelection(
        /// [in]  DWORD dwStreamIndex,
        /// [in]  BOOL fSelected
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/5EFADCE6-347C-48CF-B42C-D461922B2523(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5EFADCE6-347C-48CF-B42C-D461922B2523(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetStreamSelection(
            int dwStreamIndex,
            bool fSelected
        );

        /// <summary>
        /// Gets a format that is supported natively by the media source.
        /// </summary>
        /// <param name="dwStreamIndex">Specifies which stream to query. The value can be any of the following.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item></list></param>
        /// <param name="dwMediaTypeIndex">The zero-based index of the media type to retrieve.</param>
        /// <param name="ppMediaType">Receives a pointer to the <see cref="IMFMediaType" /> interface. The caller must release the
        /// interface.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDSTREAMNUMBER</strong></strong></term><description>The <em>dwStreamIndex</em> parameter is invalid. </description></item>
        /// <item><term><strong><strong>MF_E_NO_MORE_TYPES</strong></strong></term><description>The <em>dwMediaTypeIndex</em> parameter is out of range. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetNativeMediaType(
        /// [in]   DWORD dwStreamIndex,
        /// [in]   DWORD dwMediaTypeIndex,
        /// [out]  IMFMediaType **ppMediaType
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/4B514F8D-082F-4E84-B512-D4A59706A6D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4B514F8D-082F-4E84-B512-D4A59706A6D8(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetNativeMediaType(
            int dwStreamIndex,
            int dwMediaTypeIndex,
            out IMFMediaType ppMediaType
        );

        /// <summary>
        /// Gets the current media type for a stream.
        /// </summary>
        /// <param name="dwStreamIndex">The stream to query. The value can be any of the following.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item></list></param>
        /// <param name="ppMediaType">Receives a pointer to the <see cref="IMFMediaType" /> interface. The caller must release the
        /// interface.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDSTREAMNUMBER</strong></strong></term><description>The <em>dwStreamIndex</em> parameter is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCurrentMediaType(
        /// [in]   DWORD dwStreamIndex,
        /// [out]  IMFMediaType **ppMediaType
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/C0FE3B34-42AD-45E4-812D-679BBE01A200(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C0FE3B34-42AD-45E4-812D-679BBE01A200(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetCurrentMediaType(
            int dwStreamIndex,
            out IMFMediaType ppMediaType
        );

        /// <summary>
        /// Sets the media type for a stream.
        /// <para/>
        /// This media type defines that format that the <c>Source Reader</c> produces as output. It can differ
        /// from the native format provided by the media source. See Remarks for more information. 
        /// </summary>
        /// <param name="dwStreamIndex">The stream to configure. The value can be any of the following.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item></list></param>
        /// <param name="pdwReserved">Reserved. Set to <strong>NULL</strong>.</param>
        /// <param name="pMediaType">A pointer to the <see cref="IMFMediaType" /> interface of the media type.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDMEDIATYPE</strong></strong></term><description>At least one decoder was found for the native stream type, but the type specified by <em>pMediaType</em> was rejected. </description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>One or more sample requests are still pending.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDSTREAMNUMBER</strong></strong></term><description>The <em>dwStreamIndex</em> parameter is invalid. </description></item>
        /// <item><term><strong><strong>MF_E_TOPO_CODEC_NOT_FOUND</strong></strong></term><description>Could not find a decoder for the native stream type.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetCurrentMediaType(
        /// [in]       DWORD dwStreamIndex,
        /// [in, out]  DWORD *pdwReserved,
        /// [in]       IMFMediaType *pMediaType
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/54CAEC4D-1393-487B-94EE-78563B2B4645(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/54CAEC4D-1393-487B-94EE-78563B2B4645(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetCurrentMediaType(
            int dwStreamIndex,
			IntPtr pdwReserved,
            IMFMediaType pMediaType
        );

        /// <summary>
        /// Seeks to a new position in the media source.
        /// </summary>
        /// <param name="guidTimeFormat">A GUID that specifies the <em>time format</em>. The time format defines the units for the <em>
        /// varPosition</em> parameter. The following value is defined for all media sources:
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term><strong>GUID_NULL</strong></term><description>100-nanosecond units.</description></item></list><para />
        /// Some media sources might support additional values.</param>
        /// <param name="varPosition">The position from which playback will be started. The units are specified by the <em>guidTimeFormat
        /// </em> parameter. If the <em>guidTimeFormat</em> parameter is <strong>GUID_NULL</strong>, set the
        /// variant type to <strong>VT_I8</strong>.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>One or more sample requests are still pending.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetCurrentPosition(
        /// [in]  REFGUID guidTimeFormat,
        /// [in]  REFPROPVARIANT varPosition
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/FB9412F5-4F2F-463D-9988-80E706AFD9C4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FB9412F5-4F2F-463D-9988-80E706AFD9C4(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetCurrentPosition(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidTimeFormat,
            [In] PropVariant varPosition
        );

        /// <summary>
        /// Reads the next sample from the media source.
        /// </summary>
        /// <param name="dwStreamIndex">The stream to pull data from. The value can be any of the following.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_ANY_STREAM</strong></strong>0xFFFFFFFE</term><description>Get the next available sample, regardless of which stream.</description></item></list></param>
        /// <param name="dwControlFlags">A bitwise <strong>OR</strong> of zero or more flags from the
        /// <see cref="ReadWrite.MF_SOURCE_READER_CONTROL_FLAG" /> enumeration.</param>
        /// <param name="pdwActualStreamIndex">Receives the zero-based index of the stream.</param>
        /// <param name="pdwStreamFlags">Receives a bitwise <strong>OR</strong> of zero or more flags from the
        /// <see cref="ReadWrite.MF_SOURCE_READER_FLAG" /> enumeration.</param>
        /// <param name="pllTimestamp">Receives the time stamp of the sample, or the time of the stream event indicated in <em>
        /// pdwStreamFlags</em>. The time is given in 100-nanosecond units.</param>
        /// <param name="ppSample">Receives a pointer to the <see cref="IMFSample" /> interface or the value <strong>NULL</strong> (see
        /// Remarks). If this parameter receives a non- <strong>NULL</strong> pointer, the caller must release
        /// the interface.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>Invalid request.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDSTREAMNUMBER</strong></strong></term><description>The <em>dwStreamIndex</em> parameter is invalid. </description></item>
        /// <item><term><strong><strong>MF_E_NOTACCEPTING</strong></strong></term><description>A flush operation is pending. See <see cref="ReadWrite.IMFSourceReader.Flush"/>. </description></item>
        /// <item><term><strong><strong>E_INVALIDARG</strong></strong></term><description>Invalid argument. See Remarks.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ReadSample(
        /// [in]   DWORD dwStreamIndex,
        /// [in]   DWORD dwControlFlags,
        /// [out]  DWORD *pdwActualStreamIndex,
        /// [out]  DWORD *pdwStreamFlags,
        /// [out]  LONGLONG *pllTimestamp,
        /// [out]  IMFSample **ppSample
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/99BD9BD7-D8D1-433A-BC5A-4B9761DE5048(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/99BD9BD7-D8D1-433A-BC5A-4B9761DE5048(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int ReadSample(
            int dwStreamIndex,
            int dwControlFlags,
            out int pdwActualStreamIndex,
            out int pdwStreamFlags,
            out long pllTimestamp,
            out IMFSample ppSample
        );

        /// <summary>
        /// Flushes one or more streams.
        /// </summary>
        /// <param name="dwStreamIndex">The stream to flush. The value can be any of the following.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_ALL_STREAMS</strong></strong>0xFFFFFFFE</term><description>All streams.</description></item></list></param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Flush(
        /// [in]  DWORD dwStreamIndex
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/34992C64-9956-4B23-A979-DF7F678405B5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/34992C64-9956-4B23-A979-DF7F678405B5(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int Flush(
            int dwStreamIndex
        );

        /// <summary>
        /// Queries the underlying media source or decoder for an interface.
        /// </summary>
        /// <param name="dwStreamIndex">The stream or object to query. If the value is <strong>MF_SOURCE_READER_MEDIASOURCE</strong>, the
        /// method queries the media source. Otherwise, it queries the decoder that is associated with the
        /// specified stream. The following values are possible.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_MEDIASOURCE</strong></strong>0xFFFFFFFF</term><description>The media source. </description></item></list></param>
        /// <param name="guidService">A service identifier GUID. If the value is <strong>GUID_NULL</strong>, the method calls <strong>
        /// QueryInterface</strong> to get the requested interface. Otherwise, the method calls the
        /// <see cref="IMFGetService.GetService" /> method. For a list of service identifiers, see
        /// <c>Service Interfaces</c>.</param>
        /// <param name="riid">The interface identifier (IID) of the interface being requested.</param>
        /// <param name="ppvObject">Receives a pointer to the requested interface. The caller must release the interface.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetServiceForStream(
        /// [in]   DWORD dwStreamIndex,
        /// [in]   REFGUID guidService,
        /// [in]   REFIID riid,
        /// [out]  LPVOID *ppvObject
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/D8868E4D-EEDD-4FBD-B870-D3AF48890C92(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D8868E4D-EEDD-4FBD-B870-D3AF48890C92(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetServiceForStream(
            int dwStreamIndex,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidService,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject
        );

        /// <summary>
        /// Gets an attribute from the underlying media source.
        /// </summary>
        /// <param name="dwStreamIndex">The stream or object to query. The value can be any of the following.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_FIRST_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item><item><term><strong><strong>MF_SOURCE_READER_MEDIASOURCE</strong></strong>0xFFFFFFFF</term><description>The media source. </description></item></list></param>
        /// <param name="guidAttribute">A GUID that identifies the attribute to retrieve. If the <em>dwStreamIndex</em> parameter equals
        /// <strong>MF_SOURCE_READER_MEDIASOURCE</strong>, <em>guidAttribute</em> can specify one of the
        /// following:
        /// <para /><para>* A presentation descriptor attribute. For a list of values, see
        /// <c>Presentation Descriptor Attributes</c>. </para><para>*
        /// <see cref="MFAttributesClsid.MF_SOURCE_READER_MEDIASOURCE_CHARACTERISTICS" />. Use this value to get
        /// characteristics flags from the media source. </para><para />
        /// Otherwise, if the <em>dwStreamIndex</em> parameter specifies a stream, <em>guidAttribute</em>
        /// specifies a stream descriptor attribute. For a list of values, see
        /// <c>Stream Descriptor Attributes</c>.</param>
        /// <param name="pvarAttribute">A pointer to a <strong>PROPVARIANT</strong> that receives the value of the attribute. Call the
        /// <strong>PropVariantClear</strong> function to free the <strong>PROPVARIANT</strong>.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetPresentationAttribute(
        /// [in]   DWORD dwStreamIndex,
        /// [in]   REFGUID guidAttribute,
        /// [out]  PROPVARIANT *pvarAttribute
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/40544E1E-CCE2-4860-AEB2-B60696B09145(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/40544E1E-CCE2-4860-AEB2-B60696B09145(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetPresentationAttribute(
            int dwStreamIndex,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidAttribute,
            [In, Out, MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(PVMarshaler))] PropVariant pvarAttribute
        );

#endregion

        /// <summary>
        /// Sets the native media type for a stream on the media source.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// </param>
        /// <param name="pMediaType">
        /// A pointer to the <see cref="IMFMediaType"/> interface of the media type. 
        /// </param>
        /// <param name="pdwStreamFlags">
        /// Receives a bitwise <strong>OR</strong> of zero or more of the following flags. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>MF_SOURCE_READERF_ALLEFFECTSREMOVED</strong></term><description>All effects were removed from the stream.</description></item>
        /// <item><term><strong>MF_SOURCE_READERF_CURRENTMEDIATYPECHANGED</strong></term><description>The current output type changed.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>Invalid request.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDSTREAMNUMBER</strong></strong></term><description>The <em>dwStreamIndex</em> parameter is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetNativeMediaType(
        ///   [in]   DWORD dwStreamIndex,
        ///   [in]   IMFMediaType *pMediaType,
        ///   [out]  DWORD *pdwStreamFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/532E8F28-16F4-442E-83D9-C247E8FA7E2A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/532E8F28-16F4-442E-83D9-C247E8FA7E2A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetNativeMediaType(
            int dwStreamIndex,
            IMFMediaType pMediaType,
            out MF_SOURCE_READER_FLAG pdwStreamFlags);

        /// <summary>
        /// Adds a transform, such as an audio or video effect, to a stream.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The stream to configure. The value can be any of the following.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream.</description></item>
        /// <item><term><strong><strong>MF_SOURCE_READER_FIRST_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item>
        /// <item><term><strong><strong>MF_SOURCE_READER_FIRST_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item>
        /// </list>
        /// </param>
        /// <param name="pTransformOrActivate">
        /// A pointer to one of the following:
        /// <para/>
        /// <para>* A Media Foundation transform (MFT) that exposes the <see cref="Transform.IMFTransform"/>
        /// interface. </para><para>* An MFT activation object that exposes the <see cref="IMFActivate"/>
        /// interface. </para>
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDMEDIATYPE</strong></term><description>The transform does not support the current stream format, and no conversion was possible. See Remarks for more information.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>Invalid request.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDSTREAMNUMBER</strong></strong></term><description>The <em>dwStreamIndex</em> parameter is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AddTransformForStream(
        ///   [in]  DWORD dwStreamIndex,
        ///   [in]  IUnknown *pTransformOrActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/493BB3CF-044D-4E83-9FF7-BD2039358501(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/493BB3CF-044D-4E83-9FF7-BD2039358501(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AddTransformForStream(
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.IUnknown)] out object pTransformOrActivate);

        /// <summary>
        /// Removes all of the Media Foundation transforms (MFTs) for a specified stream, with the exception of
        /// the decoder.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The stream for which to remove the MFTs. The value can be any of the following.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream.</description></item>
        /// <item><term><strong><strong>MF_SOURCE_READER_FIRST_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item>
        /// <item><term><strong><strong>MF_SOURCE_READER_FIRST_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>Invalid request.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDSTREAMNUMBER</strong></strong></term><description>The <em>dwStreamIndex</em> parameter is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT RemoveAllTransformsForStream(
        ///   [in]  DWORD dwStreamIndex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6C0617CA-8F85-4854-9E4B-8F4300FAE8E3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6C0617CA-8F85-4854-9E4B-8F4300FAE8E3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveAllTransformsForStream(
            int dwStreamIndex);

        /// <summary>
        /// Gets a pointer to a Media Foundation transform (MFT) for a specified stream.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The stream to query for the MFT. The value can be any of the following.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream.</description></item>
        /// <item><term><strong><strong>MF_SOURCE_READER_FIRST_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item>
        /// <item><term><strong><strong>MF_SOURCE_READER_FIRST_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item>
        /// </list>
        /// </param>
        /// <param name="dwTransformIndex">
        /// The zero-based index of the MFT to retreive.
        /// </param>
        /// <param name="pGuidCategory">
        /// Receives a GUID that specifies the category of the MFT. For a list of possible values, see 
        /// <c>MFT_CATEGORY</c>. 
        /// </param>
        /// <param name="ppTransform">
        /// Receives a pointer to the <see cref="Transform.IMFTransform"/> interface of the MFT. The caller
        /// must release the interface. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDINDEX</strong></term><description>The <em>dwTransformIndex</em> parameter is out of range. </description></item>
        /// <item><term><strong><strong>MF_E_INVALIDSTREAMNUMBER</strong></strong></term><description>The <em>dwStreamIndex</em> parameter is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetTransformForStream(
        ///   [in]   DWORD dwStreamIndex,
        ///   [in]   DWORD dwTransformIndex,
        ///   [out]  GUID *pGuidCategory,
        ///   [out]  IMFTransform **ppTransform
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/39F2D132-5D2B-4389-AB30-FE2942EC3965(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/39F2D132-5D2B-4389-AB30-FE2942EC3965(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetTransformForStream(
            int dwStreamIndex,
            int dwTransformIndex,
            out Guid pGuidCategory,
            out IMFTransform ppTransform);
    }

#endif

}
