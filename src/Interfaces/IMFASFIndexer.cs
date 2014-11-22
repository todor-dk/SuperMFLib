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

using MediaFoundation.Misc;

namespace MediaFoundation
{


    /// <summary>
    /// Provides methods to work with indexes in Systems Format (ASF) files. The ASF indexer object exposes
    /// this interface. To create the ASF indexer, call <see cref="MFExtern.MFCreateASFIndexer"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/93127FE4-BCA9-4674-AE21-012367D7DD2F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/93127FE4-BCA9-4674-AE21-012367D7DD2F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("53590F48-DC3B-4297-813F-787761AD7B3E"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFASFIndexer
    {
        /// <summary>
        /// Sets indexer options.
        /// </summary>
        /// <param name="dwFlags">
        /// Bitwise OR of zero or more flags from the <c>MFASF_INDEXER_FLAGS</c> enumeration specifying the
        /// indexer options to use. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The indexer object was  initialized before setting flags for it.  For more information, see Remarks.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetFlags(
        ///   [in]  DWORD dwFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7DF6ABA2-D63F-4A1A-B6E8-6894F92993B1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7DF6ABA2-D63F-4A1A-B6E8-6894F92993B1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetFlags(
            [In] MFAsfIndexerFlags dwFlags);

        /// <summary>
        /// Retrieves the flags that indicate the selected indexer options.
        /// </summary>
        /// <param name="pdwFlags">
        /// Receives a bitwise OR of zero or more flags from the <c>MFASF_INDEXER_FLAGS</c> enumeration. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description><em>pdwFlags</em> is <strong>NULL</strong>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetFlags(
        ///   [out]  DWORD *pdwFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/97809620-57AD-48F1-94BA-A2E121CDFEE6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/97809620-57AD-48F1-94BA-A2E121CDFEE6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetFlags(
            out MFAsfIndexerFlags pdwFlags);

        /// <summary>
        /// Initializes the indexer object. This method reads information in a ContentInfo object about the
        /// configuration of the content and the properties of the existing index, if present. Use this method
        /// before using the indexer for either writing or reading an index. You must make this call before
        /// using any of the other methods of the <see cref="IMFASFIndexer"/> interface. 
        /// </summary>
        /// <param name="pIContentInfo">
        /// Pointer to the <see cref="IMFASFContentInfo"/> interface of the ContentInfo object describing the
        /// content with which to use the indexer. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_ASF_INVALIDDATA</strong></term><description>Invalid ASF data.</description></item>
        /// <item><term><strong>MF_E_UNEXPECTED</strong></term><description>Unexpected error.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Initialize(
        ///   [in]  IMFASFContentInfo *pIContentInfo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C02931D3-7B43-43A9-9E4E-00945BA3C8D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C02931D3-7B43-43A9-9E4E-00945BA3C8D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Initialize(
            [In] IMFASFContentInfo pIContentInfo);

        /// <summary>
        /// Retrieves the offset of the index object from the start of the content.
        /// </summary>
        /// <param name="pIContentInfo">
        /// Pointer to the <see cref="IMFASFContentInfo"/> interface of the ContentInfo object that describes
        /// the content. 
        /// </param>
        /// <param name="pcbIndexOffset">
        /// Receives the offset of the index relative to the beginning of the content described by the
        /// ContentInfo object. This is the position relative to the beginning of the ASF file.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description><em>pIContentInfo</em> is <strong>NULL</strong> or <em>pcbIndexOffset</em> is <strong>NULL</strong></description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetIndexPosition(
        ///   [in]   IMFASFContentInfo *pIContentInfo,
        ///   [out]  QWORD *pcbIndexOffset
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7EF0E36C-1BE5-44AC-8F6A-E29805C99E78(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7EF0E36C-1BE5-44AC-8F6A-E29805C99E78(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetIndexPosition(
            [In] IMFASFContentInfo pIContentInfo,
            out long pcbIndexOffset);

        /// <summary>
        /// Adds byte streams to be indexed.
        /// </summary>
        /// <param name="ppIByteStreams">
        /// An array of <see cref="IMFByteStream"/> interface pointers. To get the byte stream, call 
        /// <see cref="MFExtern.MFCreateASFIndexerByteStream"/>. 
        /// </param>
        /// <param name="cByteStreams">
        /// The number of pointers in the <em>ppIByteStreams</em> array. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_ALREADY_INITIALIZED</strong></term><description>The indexer object has already been initialized and it  has packets which have been indexed.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetIndexByteStreams(
        ///   [in]  IMFByteStream **ppIByteStreams,
        ///   [in]  DWORD cByteStreams
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F116BAAA-8D9B-4AC0-9263-3BB65D67EE63(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F116BAAA-8D9B-4AC0-9263-3BB65D67EE63(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetIndexByteStreams(
            [In, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.IUnknown)] IMFByteStream[] ppIByteStreams,
            [In] int cByteStreams);

        /// <summary>
        /// Retrieves the number of byte streams that are  in use by the  indexer object.
        /// </summary>
        /// <param name="pcByteStreams">
        /// Receives the number of byte streams that are  in use by the indexer object.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description><em>pcByteStreams</em> is <strong>NULL</strong>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetIndexByteStreamCount(
        ///   [out]  DWORD *pcByteStreams
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A433AF8A-9E8A-4234-9694-C3A5420A1710(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A433AF8A-9E8A-4234-9694-C3A5420A1710(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetIndexByteStreamCount(
            out int pcByteStreams);

        /// <summary>
        /// Retrieves the index settings for a specified stream and index type.
        /// </summary>
        /// <param name="pIndexIdentifier">
        /// Pointer to an <see cref="ASFIndexIdentifier"/> structure that contains the stream number and index
        /// type for which to get the status. 
        /// </param>
        /// <param name="pfIsIndexed">
        /// A variable that retrieves a Boolean value specifying whether the index described by <em>
        /// pIndexIdentifier</em> has been created. 
        /// </param>
        /// <param name="pbIndexDescriptor">
        /// A buffer that receives the index descriptor. The index descriptor consists of an 
        /// <c>ASF_INDEX_DESCRIPTOR</c> structure, optionally followed by index-specific data. 
        /// </param>
        /// <param name="pcbIndexDescriptor">
        /// On input, specifies the size, in bytes, of the buffer that <em>pbIndexDescriptor</em> points to.
        /// The value can be zero if <em>pbIndexDescriptor</em> is <strong>NULL</strong>. On output, receives
        /// the size of the index descriptor, in bytes. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_BUFFERTOOSMALL</strong></term><description>The buffer size specified in <em>pcbIndexDescriptor</em> is too small. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetIndexStatus(
        ///   [in]       ASF_INDEX_IDENTIFIER *pIndexIdentifier,
        ///   [out]      BOOL *pfIsIndexed,
        ///   [out]      BYTE *pbIndexDescriptor,
        ///   [in, out]  DWORD *pcbIndexDescriptor
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DC38A060-36E4-458E-829E-2770387FC484(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DC38A060-36E4-458E-829E-2770387FC484(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetIndexStatus(
            [In, MarshalAs(UnmanagedType.LPStruct)] ASFIndexIdentifier pIndexIdentifier,
            out bool pfIsIndexed,
            IntPtr pbIndexDescriptor,
            ref int pcbIndexDescriptor);

        /// <summary>
        /// Configures the index for a stream.
        /// </summary>
        /// <param name="pbIndexDescriptor">The pb index descriptor.</param>
        /// <param name="cbIndexDescriptor">
        /// The size, in bytes, of the index descriptor.
        /// </param>
        /// <param name="fGenerateIndex">
        /// A Boolean value. Set to <strong>TRUE</strong> to have the indexer create an index of the type
        /// specified for the stream specified in the index descriptor. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>At attempt was made to change the index status in a seek-only scenario. For more information, see Remarks.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetIndexStatus(
        ///   [in]  BYTE *pIndexDescriptor,
        ///   [in]  DWORD cbIndexDescriptor,
        ///   [in]  BOOL fGenerateIndex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BAD10893-07AF-4B46-BAB1-2878553813B5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BAD10893-07AF-4B46-BAB1-2878553813B5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetIndexStatus(
            [In] IntPtr pbIndexDescriptor,
            [In] int cbIndexDescriptor,
            [In] bool fGenerateIndex);

        /// <summary>
        /// Given a desired seek time, gets the offset from which the client should start reading data. 
        /// </summary>
        /// <param name="pvarValue">
        /// The value of the index entry for which to get the position. The format of this value varies
        /// depending on the type of index, which is specified in the index identifier. For time-based
        /// indexing, the variant type is <strong>VT_I8</strong> and the value is the desired seek time, in
        /// 100-nanosecond units. 
        /// </param>
        /// <param name="pIndexIdentifier">
        /// Pointer to an <see cref="ASFIndexIdentifier"/> structure that identifies the stream number and
        /// index type. 
        /// </param>
        /// <param name="pcbOffsetWithinData">
        /// Receives the offset within the data segment of the ASF Data Object. The offset is in bytes, and is
        /// relative to the start of packet 0. The offset gives the starting location from which the client
        /// should begin reading from the stream. This location might not correspond exactly to the requested
        /// seek time. 
        /// <para/>
        /// For reverse playback, if no key frame exists after the desired seek position, this parameter
        /// receives the value <strong>MFASFINDEXER_READ_FOR_REVERSEPLAYBACK_OUTOFDATASEGMENT</strong>. In that
        /// case, the seek position should be 1 byte pass the end of the data segment. 
        /// </param>
        /// <param name="phnsApproxTime">
        /// Receives the approximate time stamp of the data that is located at the offset returned in the <em>
        /// pcbOffsetWithinData</em> parameter. The accuracy of this value is equal to the indexing interval of
        /// the ASF index, typically about 1 second. 
        /// <para/>
        /// <para>*  If the index type specified in <em>pIndexIdentifier</em> is <strong>GUID_NULL</strong>
        /// (time indexing), this parameter can be <strong>NULL</strong>. </para><para>*  For all other index
        /// types, this parameter must be <strong>NULL</strong>. </para>
        /// <para/>
        /// If the approximate time stamp cannot be determined, this parameter receives the value <strong>
        /// MFASFINDEXER_APPROX_SEEK_TIME_UNKNOWN</strong>. 
        /// </param>
        /// <param name="pdwPayloadNumberOfStreamWithinPacket">
        /// Receives the payload number of the payload that contains the information for the specified stream.
        /// Packets can contain multiple payloads, each containing data for a different stream. This parameter
        /// can be <strong>NULL</strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_ASF_OUTOFRANGE</strong></term><description> The requested seek time is out of range. </description></item>
        /// <item><term><strong>MF_E_NO_INDEX</strong></term><description> No index exists of the specified type for the specified stream. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetSeekPositionForValue(
        ///   [in]   const PROPVARIANT *pvarValue,
        ///   [in]   ASF_INDEX_IDENTIFIER *pIndexIdentifier,
        ///   [out]  QWORD *pcbOffsetWithinData,
        ///   [out]  MFTIME *phnsApproxTime,
        ///   [out]  DWORD *pdwPayloadNumberOfStreamWithinPacket
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C8E9982E-B056-48DC-AC5F-20BF65B475EC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C8E9982E-B056-48DC-AC5F-20BF65B475EC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetSeekPositionForValue(
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvarValue,
            [In, MarshalAs(UnmanagedType.LPStruct)] ASFIndexIdentifier pIndexIdentifier,
            out long pcbOffsetWithinData,
            IntPtr phnsApproxTime,
            out int pdwPayloadNumberOfStreamWithinPacket);

        /// <summary>
        /// Accepts an ASF packet for the file and creates index entries for them.
        /// </summary>
        /// <param name="pIASFPacketSample">
        /// Pointer to the <see cref="IMFSample"/> interface of a media sample that contains the ASF packet. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The argument passed in is <strong>NULL</strong>. </description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>The indexer is not initialized.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GenerateIndexEntries(
        ///   [in]  IMFSample *pIASFPacketSample
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FEBC5335-A8E8-4AE9-AFB2-17F09B750477(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FEBC5335-A8E8-4AE9-AFB2-17F09B750477(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GenerateIndexEntries(
            [In] IMFSample pIASFPacketSample);

        /// <summary>
        /// Adds information about a new index to the ContentInfo object associated with ASF content. You must
        /// call this method before copying the index to the content so that the index will be readable by the
        /// indexer later.
        /// </summary>
        /// <param name="pIContentInfo">
        /// Pointer to the <see cref="IMFASFContentInfo"/> interface of the ContentInfo object that describes
        /// the content. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The caller made an invalid request. For more information, see Remarks.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CommitIndex(
        ///   [in]  IMFASFContentInfo *pIContentInfo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/44B889E1-8860-44FA-B19F-5BE9F844A194(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/44B889E1-8860-44FA-B19F-5BE9F844A194(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int CommitIndex(
            [In] IMFASFContentInfo pIContentInfo);

        /// <summary>
        /// Retrieves the size, in bytes, of the buffer required to store the completed index.
        /// </summary>
        /// <param name="pcbIndexWriteSpace">
        /// Receives the size of the index, in bytes
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INDEX_NOT_COMMITTED</strong></term><description>The index has not been committed. For more information; see Remarks.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetIndexWriteSpace(
        ///   [out]  QWORD *pcbIndexWriteSpace
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8D62A357-E46E-4431-943F-334AE11C8B31(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8D62A357-E46E-4431-943F-334AE11C8B31(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetIndexWriteSpace(
            out long pcbIndexWriteSpace);

        /// <summary>
        /// Retrieves the completed index from the ASF indexer object.
        /// </summary>
        /// <param name="pIIndexBuffer">
        /// Pointer to the <see cref="IMFMediaBuffer"/> interface of a media buffer that receives the index
        /// data. 
        /// </param>
        /// <param name="cbOffsetWithinIndex">
        /// The offset of the data to be retrieved, in bytes from the start of the index data. Set to 0 for the
        /// first call. If subsequent calls are needed (the buffer is not large enough to hold the entire
        /// index), set to the byte following the last one retrieved.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INDEX_NOT_COMMITTED</strong></term><description>The index was not committed before attempting to get the completed index. For more information, see Remarks.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCompletedIndex(
        ///   [in]  IMFMediaBuffer *pIIndexBuffer,
        ///   [in]  QWORD cbOffsetWithinIndex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/ACA721E8-E610-4022-A3DA-8FF5A5943E3E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ACA721E8-E610-4022-A3DA-8FF5A5943E3E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCompletedIndex(
            [In] IMFMediaBuffer pIIndexBuffer,
            [In] long cbOffsetWithinIndex);
    }

}
