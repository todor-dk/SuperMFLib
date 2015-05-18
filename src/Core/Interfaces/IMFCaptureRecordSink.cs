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
using MediaFoundation.EVR;

namespace MediaFoundation.Core.Interfaces
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Controls the recording sink. The recording sink creates compressed audio/video files or compressed
    /// audio/video streams.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/AEF5923D-C4ED-4BEA-A969-163ED837A5BD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AEF5923D-C4ED-4BEA-A969-163ED837A5BD(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("3323b55a-f92a-4fe2-8edc-e9bfc0634d77"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFCaptureRecordSink : IMFCaptureSink
    {
        #region IMFCaptureSink Methods

        /// <summary>
        /// Gets the output format for a stream on this capture sink.
        /// </summary>
        /// <param name="dwSinkStreamIndex">
        /// The zero-based index of the stream to query. The index is returned in the <em>pdwSinkStreamIndex
        /// </em> parameter of the <see cref="IMFCaptureSink.AddStream"/> method. 
        /// </param>
        /// <param name="ppMediaType">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface. The caller must release the
        /// pointer. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>The <em>dwSinkStreamIndex</em> parameter is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetOutputMediaType(
        ///   [in]   DWORD dwSinkStreamIndex,
        ///   [out]  IMFMediaType **ppMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3F050964-9E71-45FC-9553-A2E7A397217E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3F050964-9E71-45FC-9553-A2E7A397217E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetOutputMediaType(
            int dwSinkStreamIndex, out IMFMediaType ppMediaType
            );

        /// <summary>
        /// Queries the underlying <c>Sink Writer</c> object for an interface. 
        /// </summary>
        /// <param name="dwSinkStreamIndex">
        /// The zero-based index of the stream to query. The index is returned in the <em>pdwSinkStreamIndex
        /// </em> parameter of the <see cref="IMFCaptureSink.AddStream"/> method. 
        /// </param>
        /// <param name="rguidService">
        /// A service identifier GUID. Currently, the value must be <strong>GUID_NULL</strong>. 
        /// </param>
        /// <param name="riid">
        /// A service identifier GUID. Currently, the value must be <strong>IID_IMFSinkWriter</strong>. 
        /// </param>
        /// <param name="ppUnknown">
        /// Receives a pointer to the <c>IUnknown</c> interface. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid argument.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>Invalid request.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>Invalid stream number.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetService(
        ///   [in]   DWORD dwSinkStreamIndex,
        ///   [in]   REFGUID rguidService,
        ///   [in]   REFIID riid,
        ///   [out]  IUnknown **ppUnknown
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/591F0E3D-01A8-420F-86C6-2C610643EB69(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/591F0E3D-01A8-420F-86C6-2C610643EB69(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int GetService(
            int dwSinkStreamIndex,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid rguidService,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppUnknown
            );

        /// <summary>
        /// Connects a stream from the capture source to this capture sink.
        /// </summary>
        /// <param name="dwSourceStreamIndex">
        /// The source stream to connect. The value can be any of the following.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream. To get the number of streams, call <see cref="IMFCaptureSource.GetDeviceStreamCount"/>. </description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_PHOTO_STREAM</strong></strong>0xFFFFFFFB</term><description>The first image stream.</description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item>
        /// </list>
        /// </param>
        /// <param name="pMediaType">
        /// An <see cref="IMFMediaType"/> pointer that specifies the desired format of the output stream. The
        /// details of the format will depend on the capture sink. 
        /// <para/>
        /// <para>* Photo sink: A still image format compatible with <c>Windows Imaging Component</c> (WIC). 
        /// </para><para>* Preview sink: An uncompressed audio or video format.</para><para>* Record sink: The
        /// audio or video format that will be written to the output file.</para>
        /// </param>
        /// <param name="pAttributes">
        /// A pointer to the <see cref="IMFAttributes"/> interface. For compressed streams, you can use this
        /// parameter to configure the encoder. This parameter can also be <strong>NULL</strong>. For the
        /// preview sink, set this parameter to <strong>NULL</strong>. 
        /// </param>
        /// <param name="pdwSinkStreamIndex">
        /// Receives the index of the new stream on the capture sink. Note that this index will not necessarily
        /// match the value of <em>dwSourceStreamIndex</em>. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDMEDIATYPE</strong></term><description>The format specified in <em>pMediaType</em> is not valid for this capture sink. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>The <em>dwSourceStreamIndex</em> parameter is invalid, or the specified source stream was already connected to this sink. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AddStream(
        ///   [in]   DWORD dwSourceStreamIndex,
        ///   [in]   IMFMediaType *pMediaType,
        ///   [in]   IMFAttributes *pAttributes,
        ///   [out]  DWORD *pdwSinkStreamIndex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5D7A1FE0-92B9-4CC4-A268-17FA848055A9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5D7A1FE0-92B9-4CC4-A268-17FA848055A9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int AddStream(
            int dwSourceStreamIndex,
            IMFMediaType pMediaType,
            IMFAttributes pAttributes,
            out int pdwSinkStreamIndex
            );

        /// <summary>
        /// Prepares the capture sink by loading any required pipeline components, such as encoders, video
        /// processors, and media sinks.
        /// </summary>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>Invalid request.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Prepare();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/244FD291-AD1D-4A51-87C3-C98B33978AA1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/244FD291-AD1D-4A51-87C3-C98B33978AA1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int Prepare();

        /// <summary>
        /// Removes all streams from the capture sink.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT RemoveAllStreams();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7E05D04F-BDE8-4053-A7C4-B74AC5FA76B7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7E05D04F-BDE8-4053-A7C4-B74AC5FA76B7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        new int RemoveAllStreams();

        #endregion

        /// <summary>
        /// Specifies a byte stream that will receive the data for the recording.
        /// </summary>
        /// <param name="pByteStream">
        /// A pointer to the <see cref="IMFByteStream"/> interface of a byte stream. The byte stream must be
        /// writable. 
        /// </param>
        /// <param name="guidContainerType">
        /// A GUID that specifies the file container type. Possible values are documented in the 
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_CONTAINERTYPE"/> attribute. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetOutputByteStream(
        ///   [in]  IMFByteStream *pByteStream,
        ///   [in]  REFGUID guidContainerType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C33357C8-882A-4350-8638-46C2220FC445(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C33357C8-882A-4350-8638-46C2220FC445(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetOutputByteStream(
            IMFByteStream pByteStream,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidContainerType
            );

        /// <summary>
        /// Specifies the name of the output file for the recording.
        /// </summary>
        /// <param name="fileName">
        /// A null-terminated string that contains the URL of the output file. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetOutputFileName(
        ///   [in]  LPCWSTR fileName
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/96BEE09C-1B17-4857-B0DC-553D14B908E7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/96BEE09C-1B17-4857-B0DC-553D14B908E7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetOutputFileName(
            [MarshalAs(UnmanagedType.LPWStr)] string fileName
            );

        /// <summary>
        /// Sets a callback to receive the recording data for one stream.
        /// </summary>
        /// <param name="dwStreamSinkIndex">
        /// The zero-based index of the stream. The index is returned in the <em>pdwSinkStreamIndex</em>
        /// parameter of the <see cref="IMFCaptureSink.AddStream"/> method. 
        /// </param>
        /// <param name="pCallback">
        /// A pointer to the <see cref="IMFCaptureEngineOnSampleCallback"/> interface. The caller must
        /// implement this interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetSampleCallback(
        ///   [in]  DWORD dwStreamSinkIndex,
        ///   [in]  IMFCaptureEngineOnSampleCallback *pCallback
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1D7BB0D1-3F77-4AF3-9624-73EE4D0D0BCE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1D7BB0D1-3F77-4AF3-9624-73EE4D0D0BCE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetSampleCallback(
            int dwStreamSinkIndex,
            IMFCaptureEngineOnSampleCallback pCallback
            );

        /// <summary>
        /// Sets a custom media sink for recording.
        /// </summary>
        /// <param name="pMediaSink">
        /// A pointer to the <see cref="IMFMediaSink"/> interface of the media sink. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetCustomSink(
        ///   [in]  IMFMediaSink *pMediaSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/76140ECF-E7A2-4C41-A710-813B2DF8F52C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/76140ECF-E7A2-4C41-A710-813B2DF8F52C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetCustomSink(
            IMFMediaSink pMediaSink
            );

        /// <summary>
        /// Gets the rotation that is currently being applied to the recorded video stream.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The zero-based index of the stream. You must specify a video stream.
        /// </param>
        /// <param name="pdwRotationValue">
        /// Receives the image rotation, in degrees.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetRotation(
        ///   [in]   DWORD dwStreamIndex,
        ///   [out]  DWORD *pdwRotationValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E582ED9C-D7B8-4DF9-B72F-361E682DB93F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E582ED9C-D7B8-4DF9-B72F-361E682DB93F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetRotation(
            int dwStreamIndex,
            out int pdwRotationValue
            );

        /// <summary>
        /// Rotates the recorded video stream.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The zero-based index of the stream to rotate. You must specify a video stream.
        /// </param>
        /// <param name="dwRotationValue">
        /// The amount to rotate the video, in degrees. Valid values are 0, 90, 180, and 270. The value zero
        /// restores the video to its original orientation.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetRotation(
        ///   [in]  DWORD dwStreamIndex,
        ///   [in]  DWORD dwRotationValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3C451FF9-F5CD-48C6-A7FE-88BD3E82DA83(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3C451FF9-F5CD-48C6-A7FE-88BD3E82DA83(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetRotation(
            int dwStreamIndex,
            int dwRotationValue
        );
    }

#endif

}
