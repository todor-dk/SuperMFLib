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
    /// Controls the capture source object. The capture source manages the audio and video capture devices.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/864B6B5D-EB7E-4C49-A326-9B6704A27635(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/864B6B5D-EB7E-4C49-A326-9B6704A27635(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("439a42a8-0d2c-4505-be83-f79b2a05d5c4"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFCaptureSource
    {
        /// <summary>
        /// Gets the current capture device's <see cref="IMFMediaSource"/> object pointer. 
        /// </summary>
        /// <param name="mfCaptureEngineDeviceType">
        /// The capture engine device type.
        /// </param>
        /// <param name="ppMediaSource">
        /// Receives a pointer to the <see cref="IMFMediaSource"/> that represent the device. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCaptureDeviceSource(
        ///   [in]   MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType,
        ///   [out]  IMFMediaSource **ppMediaSource
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/98BCE6E3-02F2-449E-ABA4-4BFC9DE6D1DB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/98BCE6E3-02F2-449E-ABA4-4BFC9DE6D1DB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCaptureDeviceSource(
            MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType,
            out IMFMediaSource ppMediaSource
            );

        /// <summary>
        /// Gets the current capture device's <see cref="IMFActivate"/> object pointer. 
        /// </summary>
        /// <param name="mfCaptureEngineDeviceType">
        /// The capture engine device type.
        /// </param>
        /// <param name="ppActivate">
        /// Receives the pointer to a <see cref="IMFActivate"/> that represents a device. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCaptureDeviceActivate(
        ///   [in]   MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType,
        ///   [out]  IMFActivate **ppActivate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5F69321F-67DF-4D6C-A98A-51A9859F8A22(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5F69321F-67DF-4D6C-A98A-51A9859F8A22(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCaptureDeviceActivate(
            MF_CAPTURE_ENGINE_DEVICE_TYPE mfCaptureEngineDeviceType,
            out IMFActivate ppActivate
            );

        /// <summary>
        /// Gets a pointer to the underlying <c>Source Reader</c> object. 
        /// </summary>
        /// <param name="rguidService">
        /// A service identifier GUID. Currently the value must be <strong>IID_IMFSourceReader</strong> or 
        /// <strong>GUID_NULL</strong>. 
        /// </param>
        /// <param name="riid">
        /// The interface identifier (IID) of the interface being requested. The value must be <strong>
        /// IID_IMFSourceReader</strong>. If the value is not set to <strong>IID_IMFSourceReader</strong>, the
        /// call will fail and return <strong>E_INVALIDARG</strong>. 
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
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The capture source was not initialized. Possibly there is no capture device on the system.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetService(
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
        /// <a href="http://msdn.microsoft.com/en-US/library/67A77196-A499-4C28-8A35-CFB130B85D79(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/67A77196-A499-4C28-8A35-CFB130B85D79(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetService(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid rguidService,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppUnknown
            );

        /// <summary>
        /// Adds an effect to a capture stream.
        /// </summary>
        /// <param name="dwSourceStreamIndex">
        /// The capture stream. The value can be any of the following.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream. To get the number of streams, call <see cref="IMFCaptureSource.GetDeviceStreamCount"/>. </description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_PHOTO_STREAM</strong></strong>0xFFFFFFFB</term><description>The first image stream.</description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item>
        /// </list>
        /// </param>
        /// <param name="pUnknown">
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
        /// <item><term><strong>MF_E_INVALIDMEDIATYPE</strong></term><description>No compatible media type could be found.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>The <em>dwSourceStreamIndex</em> parameter is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AddEffect(
        ///   [in]  DWORD dwSourceStreamIndex,
        ///   [in]  IUnknown *pUnknown
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C108360D-0B8C-4539-9D78-A5559100086E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C108360D-0B8C-4539-9D78-A5559100086E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AddEffect(
            int dwSourceStreamIndex,
            [MarshalAs(UnmanagedType.IUnknown)] out object pUnknown
            );

        /// <summary>
        /// Removes an effect from a capture stream.
        /// </summary>
        /// <param name="dwSourceStreamIndex">
        /// The capture stream. The value can be any of the following.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream. To get the number of streams, call <see cref="IMFCaptureSource.GetDeviceStreamCount"/>. </description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_PHOTO_STREAM</strong></strong>0xFFFFFFFB</term><description>The first image stream.</description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item>
        /// </list>
        /// </param>
        /// <param name="pUnknown">
        /// A pointer to the <c>IUnknown</c> interface of the effect object. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>Invalid request. Possibly the specified effect could not be found.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>The <em>dwSourceStreamIndex</em> parameter is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT RemoveEffect(
        ///   [in]  DWORD dwSourceStreamIndex,
        ///   [in]  IUnknown *pUnknown
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5FF2EF1C-1BF0-4CF7-95AB-1BB10025D66F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5FF2EF1C-1BF0-4CF7-95AB-1BB10025D66F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveEffect(
            int dwSourceStreamIndex,
            [MarshalAs(UnmanagedType.IUnknown)] object pUnknown
            );

        /// <summary>
        /// Removes all effects from a capture stream.
        /// </summary>
        /// <param name="dwSourceStreamIndex">
        /// The capture stream. The value can be any of the following.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream. To get the number of streams, call <see cref="IMFCaptureSource.GetDeviceStreamCount"/>. </description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_PHOTO_STREAM</strong></strong>0xFFFFFFFB</term><description>The first image stream.</description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>The <em>dwSourceStreamIndex</em> parameter is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT RemoveAllEffects(
        ///   [in]  DWORD dwSourceStreamIndex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C01F7A61-3585-4E8B-B914-7DB1446D1BC1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C01F7A61-3585-4E8B-B914-7DB1446D1BC1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveAllEffects(
            int dwSourceStreamIndex
            );

        /// <summary>
        /// Gets a format that is supported by one of the capture streams.
        /// </summary>
        /// <param name="dwSourceStreamIndex">
        /// The stream to query. The value can be any of the following.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream. To get the number of streams, call <see cref="IMFCaptureSource.GetDeviceStreamCount"/>. </description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_PHOTO_STREAM</strong></strong>0xFFFFFFFB</term><description>The first image stream.</description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item>
        /// </list>
        /// </param>
        /// <param name="dwMediaTypeIndex">
        /// The zero-based index of the media type to retrieve.
        /// </param>
        /// <param name="ppMediaType">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>The <em>dwSourceStreamIndex</em> parameter is invalid. </description></item>
        /// <item><term><strong>MF_E_NO_MORE_TYPES</strong></term><description>The <em>dwMediaTypeIndex</em> parameter is out of range. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetAvailableDeviceMediaType(
        ///   [in]  DWORD dwSourceStreamIndex,
        ///   [in]  DWORD dwMediaTypeIndex,
        ///   [in]  IMFMediaType **ppMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B122C2DE-9544-47C7-8F4F-DBD4C1DE54C0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B122C2DE-9544-47C7-8F4F-DBD4C1DE54C0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAvailableDeviceMediaType(
            int dwSourceStreamIndex,
            int dwMediaTypeIndex,
            out IMFMediaType ppMediaType
            );

        /// <summary>
        /// Sets the output format for a capture stream.
        /// </summary>
        /// <param name="dwSourceStreamIndex">
        /// The capture stream to set. The value can be any of the following.
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
        /// A pointer to the <see cref="IMFMediaType"/> interface. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>The <em>dwSourceStreamIndex</em> parameter is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetCurrentDeviceMediaType(
        ///   [in]  DWORD dwSourceStreamIndex,
        ///   [in]  IMFMediaType *pMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2B88BBAE-E837-4F4A-B697-64772F25C89D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2B88BBAE-E837-4F4A-B697-64772F25C89D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetCurrentDeviceMediaType(
            int dwSourceStreamIndex,
            IMFMediaType pMediaType
            );

        /// <summary>
        /// Gets the current media type for a capture stream.
        /// </summary>
        /// <param name="dwSourceStreamIndex">
        /// Specifies which stream to query. The value can be any of the following.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0–0xFFFFFFFB</term><description>The zero-based index of a stream. To get the number of streams, call <see cref="IMFCaptureSource.GetDeviceStreamCount"/>. </description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_PHOTO_STREAM</strong></strong>0xFFFFFFFB</term><description>The first image stream.</description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_VIDEO_STREAM</strong></strong>0xFFFFFFFC</term><description>The first video stream.</description></item>
        /// <item><term><strong><strong>MF_CAPTURE_ENGINE_FIRST_SOURCE_AUDIO_STREAM</strong></strong>0xFFFFFFFD</term><description>The first audio stream.</description></item>
        /// </list>
        /// </param>
        /// <param name="ppMediaType">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>The <em>dwSourceStreamIndex</em> parameter is invalid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCurrentDeviceMediaType(
        ///   [in]   DWORD dwSourceStreamIndex,
        ///   [out]  IMFMediaType **ppMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8F263F5C-D1B4-4DF7-AFCB-E27575FBAAA2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8F263F5C-D1B4-4DF7-AFCB-E27575FBAAA2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCurrentDeviceMediaType(
            int dwSourceStreamIndex,
            out IMFMediaType ppMediaType
            );

        /// <summary>
        /// Gets the number of device streams.
        /// </summary>
        /// <param name="pdwStreamCount">
        /// Receives the number of device streams.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetDeviceStreamCount(
        ///   [out]  DWORD *pdwStreamCount
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0CD466EF-4753-42F6-A9B9-71CBB0668342(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0CD466EF-4753-42F6-A9B9-71CBB0668342(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetDeviceStreamCount(
            out int pdwStreamCount
            );

        /// <summary>
        /// Gets the stream category for the specified source stream index.
        /// </summary>
        /// <param name="dwSourceStreamIndex">
        /// The index of the source stream.
        /// </param>
        /// <param name="pStreamCategory">
        /// Receives the MF_CAPTURE_ENGINE_STREAM_CATEGORY of the specified source stream.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetDeviceStreamCategory(
        ///   [in]   DWORD dwSourceStreamIndex,
        ///   [out]  MF_CAPTURE_ENGINE_STREAM_CATEGORY *pStreamCategory
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F3CAA002-8676-44D3-9696-DA5B0DB09D9E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F3CAA002-8676-44D3-9696-DA5B0DB09D9E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetDeviceStreamCategory(
            int dwSourceStreamIndex,
            out MF_CAPTURE_ENGINE_STREAM_CATEGORY pStreamCategory
            );

        /// <summary>
        /// Gets the current mirroring state of the video preview stream.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The zero-based index of the stream.
        /// </param>
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
        ///   [in]   DWORD dwStreamIndex,
        ///   [out]   *pfMirrorState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3FB15EC5-DE9C-4051-9FBA-7CE332E70078(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3FB15EC5-DE9C-4051-9FBA-7CE332E70078(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMirrorState(
            int dwStreamIndex,
            [MarshalAs(UnmanagedType.Bool)] out bool pfMirrorState
            );

        /// <summary>
        /// Enables or disables mirroring of the video preview stream.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The zero-based index of the stream.
        /// </param>
        /// <param name="fMirrorState">
        /// If <strong>TRUE</strong>, mirroring is enabled; if <strong>FALSE</strong>, mirroring is disabled. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description>The device stream does not have mirroring capability.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The source is not initialized.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetMirrorState(
        ///   [in]  DWORD dwStreamIndex,
        ///   [in]   fMirrorState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E170B262-95CD-4434-925A-3573D35FC1DC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E170B262-95CD-4434-925A-3573D35FC1DC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetMirrorState(
            int dwStreamIndex,
            bool fMirrorState
            );

        /// <summary>
        /// Gets the actual device stream index translated from a friendly stream name.
        /// </summary>
        /// <param name="uifriendlyName">
        /// The friendly name.  Can be one of the following:
        /// <para/>
        /// <para>* MF_CAPTURE_ENGINE_FIRST_SOURCE_AUDIO_STREAM</para><para>* 
        /// MF_CAPTURE_ENGINE_FIRST_SOURCE_VIDEO_STREAM</para><para>* 
        /// MF_CAPTURE_ENGINE_FIRST_SOURCE_PHOTO_STREAM</para><para>* 
        /// MF_CAPTURE_ENGINE_PREFERRED_SOURCE_VIDEO_STREAM_FOR_RECORD</para><para>* 
        /// MF_CAPTURE_ENGINE_PREFERRED_SOURCE_VIDEO_STREAM_FOR_PREVIEW</para><para>* 
        /// MF_CAPTURE_ENGINE_FIRST_SOURCE_INDEPENDENT_PHOTO_STREAM</para>
        /// </param>
        /// <param name="pdwActualStreamIndex">
        /// Receives the value of the stream index that corresponds to the friendly name.
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamIndexFromFriendlyName(
        ///   [in]   UINT32 uifriendlyName,
        ///   [out]  DWORD *pdwActualStreamIndex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/38BC2CA8-29FF-4A23-9B78-693AAAB6767F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/38BC2CA8-29FF-4A23-9B78-693AAAB6767F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamIndexFromFriendlyName(
            int uifriendlyName,
            out int pdwActualStreamIndex
            );
    }

#endif

}
