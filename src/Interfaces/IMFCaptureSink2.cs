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
    /// Extends the <see cref="IMFCaptureSink"/> interface to provide functionality for 
    /// dynamically setting the output media type of the record sink or preview sink.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280679(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280679(v=vs.85).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("f9e4219e-6197-4b5e-b888-bee310ab2c59")]
    public interface IMFCaptureSink2 : IMFCaptureSink
    {
        #region IMFCaptureEngineOnSampleCallback methods

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
            int dwSinkStreamIndex,
            out IMFMediaType ppMediaType
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
        /// Dynamically sets the output media type of the record sink or preview sink.
        /// </summary>
        /// <param name="dwStreamIndex">
        ///  The stream index to change the output media type on.
        /// </param>
        /// <param name="pMediaType">
        /// The new output media type.
        /// </param>
        /// <param name="pEncodingAttributes">
        /// The new encoder attributes. This can be null.
        /// </param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the following table.
        /// <para/>
        /// <strong>S_OK</strong>: The method succeeded.
        /// <para/>
        /// <strong>MF_E_INVALID_MEDIATYPE</strong>: The sink does not support the media type.
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetOutputMediaType(
        ///   [in]  DWORD dwStreamIndex,
        ///   [in]  IMFMediaType *pMediaType,
        ///   [in]  IMFAttributes *pEncodingAttributes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280680(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280680(v=vs.85).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetOutputMediaType(
            int dwStreamIndex,
            IMFMediaType pMediaType,
            IMFAttributes pEncodingAttributes
            );
    }
#endif
}
