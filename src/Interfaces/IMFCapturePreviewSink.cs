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

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Controls the preview sink. The preview sink enables the application to preview audio and video from
    /// the camera.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/5E64C24D-D6EC-419B-9DC8-309EBCE0077E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5E64C24D-D6EC-419B-9DC8-309EBCE0077E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("77346cfd-5b49-4d73-ace0-5b52a859f2e0"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFCapturePreviewSink : IMFCaptureSink
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
        /// Specifies a window for preview.
        /// </summary>
        /// <param name="handle">
        /// A handle to the window. The preview sink draws the video frames inside this window.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetRenderHandle(
        ///   [in]  HANDLE handle
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/98D3EFC4-841D-41EC-BC5C-E67029663864(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/98D3EFC4-841D-41EC-BC5C-E67029663864(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetRenderHandle(
            IntPtr handle
            );

        /// <summary>
        /// Specifies a Microsoft DirectComposition visual for preview.
        /// </summary>
        /// <param name="pSurface">
        /// A pointer to a DirectComposition visual that implements the <c>IDCompositionVisual</c> interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetRenderSurface(
        ///   [in]  IUnknown *pSurface
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AC50EB86-A39D-4ACA-9582-A8DB0232E056(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC50EB86-A39D-4ACA-9582-A8DB0232E056(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetRenderSurface(
            [MarshalAs(UnmanagedType.IUnknown)] object pSurface
            );

        /// <summary>
        /// Updates the video frame. Call this method when the preview window receives a <c>WM_PAINT</c> or 
        /// <c>WM_SIZE</c> message. 
        /// </summary>
        /// <param name="pSrc">
        /// A pointer to an <see cref="EVR.MFVideoNormalizedRect"/> structure that specifies the source
        /// rectangle. The source rectangle defines the area of the video frame that is displayed. If this
        /// parameter is <strong>NULL</strong>, the entire video frame is displayed. 
        /// </param>
        /// <param name="pDst">
        /// A pointer to a <c>RECT</c> structure that specifies the destination rectangle. The destination
        /// rectangle defines the area of the window or DirectComposition visual where the video is drawn. 
        /// </param>
        /// <param name="pBorderClr">
        /// The border color. Use the <c>RGB</c> macro to create this value. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT UpdateVideo(
        ///   [in]  const MFVideoNormalizedRect *pSrc,
        ///   [in]  const RECT *pDst,
        ///   [in]  const COLORREF *pBorderClr
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B541D209-BB03-4FCF-834C-82002037C357(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B541D209-BB03-4FCF-834C-82002037C357(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int UpdateVideo(
            MFVideoNormalizedRect pSrc,
            MFRect pDst,
            MFARGB pBorderClr
            );

        /// <summary>
        /// Sets a callback to receive the preview data for one stream.
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
        /// <a href="http://msdn.microsoft.com/en-US/library/0E14E3E4-25C7-4FCA-B220-20E346E66933(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0E14E3E4-25C7-4FCA-B220-20E346E66933(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetSampleCallback(
            int dwStreamSinkIndex,
            IMFCaptureEngineOnSampleCallback pCallback
            );

        /// <summary>
        /// Gets the current mirroring state of the video preview stream.
        /// </summary>
        /// <param name="pfMirrorState">
        /// Receives the value <strong>TRUE</strong> if mirroring is enabled, or <strong>FALSE</strong> if
        /// mirroring is disabled. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetMirrorState(
        ///   [out]   *pfMirrorState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6EFC9DFF-4029-46F0-9357-983FE528D4FE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6EFC9DFF-4029-46F0-9357-983FE528D4FE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMirrorState(
            [MarshalAs(UnmanagedType.Bool)] out bool pfMirrorState
            );

        /// <summary>
        /// Enables or disables mirroring of the video preview stream.
        /// </summary>
        /// <param name="fMirrorState">
        /// If <strong>TRUE</strong>, mirroring is enabled. If <strong>FALSE</strong>, mirror is disabled. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetMirrorState(
        ///   [in]  BOOL fMirrorState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F7F04E29-E7AD-46BD-AAF9-5B7BA68822EE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F7F04E29-E7AD-46BD-AAF9-5B7BA68822EE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetMirrorState(
            bool fMirrorState
            );

        /// <summary>
        /// Gets the rotation of the video preview stream.
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
        /// <a href="http://msdn.microsoft.com/en-US/library/5C750060-762B-42EE-92AD-8497B83E5D51(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5C750060-762B-42EE-92AD-8497B83E5D51(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetRotation(
            int dwStreamIndex,
            out int pdwRotationValue
            );

        /// <summary>
        /// Rotates the video preview stream.
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
        /// <a href="http://msdn.microsoft.com/en-US/library/84C53A34-B2FB-4D13-9A45-5172E9E3CEE8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/84C53A34-B2FB-4D13-9A45-5172E9E3CEE8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetRotation(
            int dwStreamIndex,
            int dwRotationValue
            );

        /// <summary>
        /// Sets a custom media sink for preview.
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
        /// <a href="http://msdn.microsoft.com/en-US/library/98D6F026-408F-4C22-B4A3-68C1B0EFD1E9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/98D6F026-408F-4C22-B4A3-68C1B0EFD1E9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetCustomSink(
            IMFMediaSink pMediaSink
            );
    }

#endif

}
