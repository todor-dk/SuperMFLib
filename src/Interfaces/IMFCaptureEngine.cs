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
    /// Controls one or more capture devices. The capture engine implements this interface. To get a
    /// pointer to this interface, call either <see cref="MFExtern.MFCreateCaptureEngine"/> or 
    /// <see cref="IMFCaptureEngineClassFactory.CreateInstance"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/4A2A0536-4255-40AB-BCAB-228B09343583(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4A2A0536-4255-40AB-BCAB-228B09343583(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("a6bba433-176b-48b2-b375-53aa03473207"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFCaptureEngine
    {
        /// <summary>
        /// Initializes the capture engine.
        /// </summary>
        /// <param name="pEventCallback">
        /// A pointer to the <see cref="IMFCaptureEngineOnEventCallback"/> interface. The caller must implement
        /// this interface. The capture engine uses this interface to send asynchronous events to the caller. 
        /// </param>
        /// <param name="pAttributes">
        /// A pointer to the <see cref="IMFAttributes"/> interface. This parameter can be <strong>NULL</strong>
        /// . 
        /// <para/>
        /// You can use this parameter to configure the capture engine. Call 
        /// <see cref="MFExtern.MFCreateAttributes"/> to create an attribute store, and then set any of the
        /// following attributes. 
        /// <para/>
        /// <para>* <see cref="MF_CAPTURE_ENGINE.D3D_MANAGER"/></para><para>* 
        /// <see cref="MF_CAPTURE_ENGINE.DISABLE_DXVA"/></para><para>* 
        /// <see cref="MF_CAPTURE_ENGINE.DISABLE_HARDWARE_TRANSFORMS"/></para><para>* 
        /// <see cref="MF_CAPTURE_ENGINE.ENCODER_MFT_FIELDOFUSE_UNLOCK_Attribute"/></para><para>* 
        /// <see cref="MF_CAPTURE_ENGINE.EVENT_GENERATOR_GUID"/></para><para>* 
        /// <see cref="MF_CAPTURE_ENGINE.EVENT_STREAM_INDEX"/></para><para>* 
        /// <see cref="MF_CAPTURE_ENGINE.MEDIASOURCE_CONFIG"/></para><para>* 
        /// <see cref="MF_CAPTURE_ENGINE.RECORD_SINK_AUDIO_MAX_PROCESSED_SAMPLES"/></para><para>* 
        /// <see cref="MF_CAPTURE_ENGINE.RECORD_SINK_AUDIO_MAX_UNPROCESSED_SAMPLES"/></para><para>* 
        /// <see cref="MF_CAPTURE_ENGINE.RECORD_SINK_VIDEO_MAX_PROCESSED_SAMPLES"/></para><para>* 
        /// <see cref="MF_CAPTURE_ENGINE.RECORD_SINK_VIDEO_MAX_UNPROCESSED_SAMPLES"/></para><para>* 
        /// <see cref="MF_CAPTURE_ENGINE.USE_AUDIO_DEVICE_ONLY"/></para><para>* 
        /// <see cref="MF_CAPTURE_ENGINE.USE_VIDEO_DEVICE_ONLY"/></para>
        /// </param>
        /// <param name="pAudioSource">
        /// An <c>IUnknown</c> pointer that specifies an audio-capture device. This parameter can be <strong>
        /// NULL</strong>. 
        /// <para/>
        /// If you set the <see cref="MF_CAPTURE_ENGINE.USE_VIDEO_DEVICE_ONLY"/> attribute to <strong>TRUE
        /// </strong> in <em>pAttributes</em>, the capture engine does not use an audio device, and the <em>
        /// pAudioSource</em> parameter is ignored. 
        /// <para/>
        /// Otherwise, if <em>pAudioSource</em> is <strong>NULL</strong>, the capture engine selects the
        /// microphone that is built into the video camera specified by <em>pVideoSource</em>. If the video
        /// camera does not have a microphone, the capture engine enumerates the audio-capture devices on the
        /// system and selects the first one. 
        /// <para/>
        /// To override the default audio device, set <em>pAudioSource</em> to an <see cref="IMFMediaSource"/>
        /// or <see cref="IMFActivate"/> pointer for the device. For more information, see 
        /// <c>Audio/Video Capture in Media Foundation</c>. 
        /// </param>
        /// <param name="pVideoSource">
        /// An <c>IUnknown</c> pointer that specifies a video-capture device. This parameter can be <strong>
        /// NULL</strong>. 
        /// <para/>
        /// If you set the <see cref="MF_CAPTURE_ENGINE.USE_AUDIO_DEVICE_ONLY"/> attribute to <strong>TRUE
        /// </strong> in <em>pAttributes</em>, the capture engine does not use a video device, and the <em>
        /// pVideoSource</em> parameter is ignored. 
        /// <para/>
        /// Otherwise, if <em>pVideoSource</em> is <strong>NULL</strong>, the capture engine enumerates the
        /// video-capture devices on the system and selects the first one. 
        /// <para/>
        /// To override the default video device, set <em>pVideoSource</em> to an <see cref="IMFMediaSource"/>
        /// or <see cref="IMFActivate"/> pointer for the device. For more information, see 
        /// <c>Enumerating Video Capture Devices</c>. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The <c>Initialize</c> method was already called. </description></item>
        /// <item><term><strong>MF_E_NO_CAPTURE_DEVICES_AVAILABLE</strong></term><description>No capture devices are available.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Initialize(
        ///   [in]            IMFCaptureEngineOnEventCallback *pEventCallback,
        ///   [in, optional]  IMFAttributes *pAttributes,
        ///   [in, optional]  IUnknown *pAudioSource,
        ///   [in, optional]  IUnknown *pVideoSource
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23EC8B49-2F67-4FB8-AFFA-409823ACCF59(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23EC8B49-2F67-4FB8-AFFA-409823ACCF59(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Initialize(
            IMFCaptureEngineOnEventCallback pEventCallback,
            IMFAttributes pAttributes,
            [MarshalAs(UnmanagedType.IUnknown)] object pAudioSource,
            [MarshalAs(UnmanagedType.IUnknown)] object pVideoSource
            );

        /// <summary>
        /// Starts preview.
        /// </summary>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The preview sink was not initialized.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT StartPreview();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C5BCF990-E7F9-48E9-B082-79953F5ED27C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C5BCF990-E7F9-48E9-B082-79953F5ED27C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int StartPreview();

        /// <summary>
        /// Stops preview.
        /// </summary>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The capture engine is not currently previewing.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT StopPreview();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/36DE5079-D4D5-4FC5-8CF6-1F5B3F9E8B66(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/36DE5079-D4D5-4FC5-8CF6-1F5B3F9E8B66(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int StopPreview();

        /// <summary>
        /// Starts recording audio and/or video to a file.
        /// </summary>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The recording sink was not initialized.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT StartRecord();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/22084409-B2E6-47EF-A59B-A762E9A9191D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/22084409-B2E6-47EF-A59B-A762E9A9191D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int StartRecord();

        /// <summary>
        /// Stops recording.
        /// </summary>
        /// <param name="bFinalize">
        /// A Boolean value that specifies whether to finalize the output file. To create a valid output file,
        /// specify <strong>TRUE</strong>. Specify <strong>FALSE</strong> only if you want to interrupt the
        /// recording and discard the output file. If the value is <strong>FALSE</strong>, the operation
        /// completes more quickly, but the file will not be playable. 
        /// </param>
        /// <param name="bFlushUnprocessedSamples">
        /// A Boolean value that specifies if the unprocessed samples waiting to be encoded should be flushed.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT StopRecord(
        ///   [in]  BOOL bFinalize,
        ///   [in]  BOOL bFlushUnprocessedSamples
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/737C23E0-D4EF-4630-A460-2AE56FE50A12(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/737C23E0-D4EF-4630-A460-2AE56FE50A12(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int StopRecord(
            bool bFinalize,
            bool bFlushUnprocessedSamples
            );

        /// <summary>
        /// Captures a still image from the video stream.
        /// </summary>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT TakePhoto();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6E633E90-9C8B-44B6-9149-704872143147(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6E633E90-9C8B-44B6-9149-704872143147(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int TakePhoto();

        /// <summary>
        /// Gets a pointer to one of the capture sink objects. You can use the capture sinks to configure
        /// preview, recording, or still-image capture.
        /// </summary>
        /// <param name="mfCaptureEngineSinkType">
        /// An <see cref="MF_CAPTURE_ENGINE_SINK_TYPE"/> value that specifies the capture sink to retrieve. 
        /// </param>
        /// <param name="ppSink">
        /// Receives a pointer to the <see cref="IMFCaptureSink"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>Invalid argument.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetSink(
        ///   [in]   MF_CAPTURE_ENGINE_SINK_TYPE mfCaptureEngineSinkType,
        ///   [out]  IMFCaptureSink **ppSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7DAF5EA3-BA65-4CF9-B7BA-B427A48BF3BC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7DAF5EA3-BA65-4CF9-B7BA-B427A48BF3BC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetSink(
            MF_CAPTURE_ENGINE_SINK_TYPE mfCaptureEngineSinkType,
            out IMFCaptureSink ppSink
            );

        /// <summary>
        /// Gets a pointer to the capture source object. Use the capture source to configure the capture
        /// devices.
        /// </summary>
        /// <param name="ppSource">
        /// Receives a pointer to the <see cref="IMFCaptureSource"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetSource(
        ///   [out]  IMFCaptureSource **ppSource
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9DED11CA-BDBB-4E1A-BAD1-2EB6216543F9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9DED11CA-BDBB-4E1A-BAD1-2EB6216543F9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetSource(
            out IMFCaptureSource ppSource
            );
    }

#endif

}
