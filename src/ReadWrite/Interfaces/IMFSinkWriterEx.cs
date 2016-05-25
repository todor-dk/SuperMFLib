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

namespace MediaFoundation.ReadWrite.Interfaces
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Extends the <see cref="ReadWrite.IMFSinkWriter"/> interface. 
    /// <para/>
    /// The <c>Sink Writer</c> implements this interface in Windows 8. To get a pointer to this interface,
    /// call <c>QueryInterface</c> on the Sink Writer. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/77E6CB22-E3B5-4D5E-8876-48582F75AA5C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/77E6CB22-E3B5-4D5E-8876-48582F75AA5C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("588d72ab-5Bc1-496a-8714-b70617141b25")]
    internal interface IMFSinkWriterEx : IMFSinkWriter
    {

        #region IMFSinkWriter methods

        /// <summary>
        /// Adds a stream to the sink writer.
        /// </summary>
        /// <param name="pTargetMediaType">A pointer to the <see cref="IMFMediaType" /> interface of a media type. This media type specifies
        /// the format of the samples that will be written to the file. It does not need to match the input
        /// format. To set the input format, call <see cref="ReadWrite.IMFSinkWriter.SetInputMediaType" />.</param>
        /// <param name="pdwStreamIndex">Receives the zero-based index of the new stream.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AddStream(
        /// [in]   IMFMediaType *pTargetMediaType,
        /// [out]  DWORD *pdwStreamIndex
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/9F9B1216-E915-4188-BCFD-6C41E1821EC4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9F9B1216-E915-4188-BCFD-6C41E1821EC4(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int AddStream(
            IMFMediaType pTargetMediaType,
            out int pdwStreamIndex
        );

        /// <summary>
        /// Sets the input format for a stream on the sink writer.
        /// </summary>
        /// <param name="dwStreamIndex">The zero-based index of the stream. The index is received by the <em>pdwStreamIndex</em> parameter
        /// of the <see cref="ReadWrite.IMFSinkWriter.AddStream" /> method.</param>
        /// <param name="pInputMediaType">A pointer to the <see cref="IMFMediaType" /> interface of a media type. The media type specifies the
        /// input format.</param>
        /// <param name="pEncodingParameters">A pointer to the <see cref="IMFAttributes" /> interface of an attribute store. Use the attribute
        /// store to configure the encoder. This parameter can be <strong>NULL</strong>.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDMEDIATYPE</strong></strong></term><description>The underlying media sink does not support the format, no conversion is possible, or a dynamic format change is not possible.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDSTREAMNUMBER</strong></strong></term><description>The <em>dwStreamIndex</em> parameter is invalid. </description></item>
        /// <item><term><strong><strong>MF_E_TOPO_CODEC_NOT_FOUND</strong></strong></term><description>Could not find an encoder for the encoded format.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetInputMediaType(
        /// [in]  DWORD dwStreamIndex,
        /// [in]  IMFMediaType *pInputMediaType,
        /// [in]  IMFAttributes *pEncodingParameters
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/02A73F73-3B25-4578-9A7E-C9F8A4C8CD99(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/02A73F73-3B25-4578-9A7E-C9F8A4C8CD99(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SetInputMediaType(
            int dwStreamIndex,
            IMFMediaType pInputMediaType,
            IMFAttributes pEncodingParameters
        );

        /// <summary>
        /// Initializes the sink writer for writing.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>The request is invalid.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginWriting();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/32252658-662E-4D2F-A5FE-34F24CE60094(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/32252658-662E-4D2F-A5FE-34F24CE60094(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int BeginWriting();

        /// <summary>
        /// Delivers a sample to the sink writer.
        /// </summary>
        /// <param name="dwStreamIndex">The zero-based index of the stream for this sample.</param>
        /// <param name="pSample">A pointer to the <see cref="IMFSample" /> interface of the sample.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>The request is invalid.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT WriteSample(
        /// [in]  DWORD dwStreamIndex,
        /// [in]  IMFSample *pSample
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/1C65A5D0-CC1B-456E-9D88-A24DA57EE30A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1C65A5D0-CC1B-456E-9D88-A24DA57EE30A(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int WriteSample(
            int dwStreamIndex,
            IMFSample pSample
        );

        /// <summary>
        /// Indicates a gap in an input stream.
        /// </summary>
        /// <param name="dwStreamIndex">The zero-based index of the stream.</param>
        /// <param name="llTimestamp">The position in the stream where the gap in the data occurs. The value is given in 100-nanosecond
        /// units, relative to the start of the stream.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SendStreamTick(
        /// [in]  DWORD dwStreamIndex,
        /// [in]  LONGLONG llTimestamp
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/3B4B76B7-1A39-4323-94E7-0B2D159A8038(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3B4B76B7-1A39-4323-94E7-0B2D159A8038(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int SendStreamTick(
            int dwStreamIndex,
            long llTimestamp
        );

        /// <summary>
        /// Places a marker in the specified stream.
        /// </summary>
        /// <param name="dwStreamIndex">The zero-based index of the stream.</param>
        /// <param name="pvContext">Pointer to an application-defined value. The value of this parameter is returned to the caller in
        /// the <em>pvContext</em> parameter of the caller's
        /// <see cref="ReadWrite.IMFSinkWriterCallback.OnMarker" /> callback method. The application is
        /// responsible for any memory allocation associated with this data. This parameter can be <strong>NULL
        /// </strong>.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>The request is invalid.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT PlaceMarker(
        /// [in]  DWORD dwStreamIndex,
        /// [in]  LPVOID pvContext
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/93140993-A926-437E-BC40-9B011C4C6832(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/93140993-A926-437E-BC40-9B011C4C6832(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int PlaceMarker(
            int dwStreamIndex,
            IntPtr pvContext
        );

        /// <summary>
        /// Notifies the media sink that a stream has reached the end of a segment.
        /// </summary>
        /// <param name="dwStreamIndex">The zero-based index of a stream, or <strong>MF_SINK_WRITER_ALL_STREAMS</strong> to signal that all
        /// streams have reached the end of a segment.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>The request is invalid.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT NotifyEndOfSegment(
        /// [in]  DWORD dwStreamIndex
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/CB5B76B4-FF08-4CAC-BD30-D4F3B57ACB78(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CB5B76B4-FF08-4CAC-BD30-D4F3B57ACB78(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int NotifyEndOfSegment(
            int dwStreamIndex
        );

        /// <summary>
        /// Flushes one or more streams.
        /// </summary>
        /// <param name="dwStreamIndex">The zero-based index of the stream to flush, or <strong>MF_SINK_WRITER_ALL_STREAMS</strong> to
        /// flush all of the streams.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong><strong>MF_E_INVALIDREQUEST</strong></strong></term><description>The request is invalid.</description></item>
        /// </list>
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
        /// <a href="http://msdn.microsoft.com/en-US/library/997235CB-6CA5-434C-81A6-7A294E0CCCCA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/997235CB-6CA5-434C-81A6-7A294E0CCCCA(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int Flush(
            int dwStreamIndex
        );

        /// <summary>
        /// Finalize_s.
        /// </summary>
        /// <returns>System.Int32.</returns>
        [PreserveSig]
        new int Finalize_();

        /// <summary>
        /// Queries the underlying media sink or encoder for an interface.
        /// </summary>
        /// <param name="dwStreamIndex">The zero-based index of a stream to query, or <strong>MF_SINK_WRITER_MEDIASINK</strong> to query
        /// the media sink itself.</param>
        /// <param name="guidService">A service identifier GUID, or <strong>GUID_NULL</strong>. If the value is <strong>GUID_NULL
        /// </strong>, the method calls <strong>QueryInterface</strong> to get the requested interface.
        /// Otherwise, the method calls <see cref="IMFGetService.GetService" />. For a list of service
        /// identifiers, see <c>Service Interfaces</c>.</param>
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
        /// <a href="http://msdn.microsoft.com/en-US/library/166F8F71-E52D-43B1-9137-E4BF79BF5421(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/166F8F71-E52D-43B1-9137-E4BF79BF5421(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetServiceForStream(
            int dwStreamIndex,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidService,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid riid,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppvObject
        );

        /// <summary>
        /// Gets statistics about the performance of the sink writer.
        /// </summary>
        /// <param name="dwStreamIndex">The zero-based index of a stream to query, or <strong>MF_SINK_WRITER_ALL_STREAMS </strong> to query
        /// the media sink itself.</param>
        /// <param name="pStats">A pointer to an <see cref="ReadWrite.MF_SINK_WRITER_STATISTICS" /> structure. Before calling the
        /// method, set the <strong>cb</strong> member to the size of the structure in bytes. The method fills
        /// the structure with statistics from the sink writer.</param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>Invalid stream number.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStatistics(
        /// [in]   DWORD dwStreamIndex,
        /// [out]  MF_SINK_WRITER_STATISTICS *pStats
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/84028B1D-3843-4289-A04C-3039311D095B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/84028B1D-3843-4289-A04C-3039311D095B(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetStatistics(
            int dwStreamIndex,
            out MF_SINK_WRITER_STATISTICS pStats
        );

        #endregion

        /// <summary>
        /// Gets a pointer to a Media Foundation transform (MFT) for a specified stream.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// The zero-based index of a stream.
        /// </param>
        /// <param name="dwTransformIndex">
        /// The zero-based index of the MFT to retreive.
        /// </param>
        /// <param name="pGuidCategory">
        /// Receives a pointer to a GUID that specifies the category of the MFT. For a list of possible values,
        /// see <c>MFT_CATEGORY</c>. 
        /// </param>
        /// <param name="ppTransform">
        /// Receives a pointer to the <see cref="Transform.IMFTransform"/> interface of the MFT. The caller
        /// must release the interface. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
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
        /// <a href="http://msdn.microsoft.com/en-US/library/72EEC01F-ED62-4DD7-A18C-766D01705CAE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/72EEC01F-ED62-4DD7-A18C-766D01705CAE(v=VS.85,d=hv.2).aspx</a>
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
