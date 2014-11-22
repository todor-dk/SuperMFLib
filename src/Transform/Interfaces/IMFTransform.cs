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

namespace MediaFoundation.Transform
{


    /// <summary>
    /// Implemented by all <c>Media Foundation Transforms</c> (MFTs). 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3CC502D8-D364-43B9-B0B6-D9474C002B20(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3CC502D8-D364-43B9-B0B6-D9474C002B20(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("BF94C121-5B05-4E6F-8000-BA598961414D")]
    public interface IMFTransform
    {
        /// <summary>
        /// Gets the minimum and maximum number of input and output streams for this Media Foundation transform
        /// (MFT). 
        /// </summary>
        /// <param name="pdwInputMinimum">
        /// Receives the minimum number of input streams. 
        /// </param>
        /// <param name="pdwInputMaximum">
        /// Receives the maximum number of input streams. If there is no maximum, receives the value <strong>
        /// MFT_STREAMS_UNLIMITED</strong>. 
        /// </param>
        /// <param name="pdwOutputMinimum">
        /// Receives the minimum number of output streams. 
        /// </param>
        /// <param name="pdwOutputMaximum">
        /// Receives the maximum number of output streams. If there is no maximum, receives the value <strong>
        /// MFT_STREAMS_UNLIMITED</strong>. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamLimits(
        ///   [out]  DWORD *pdwInputMinimum,
        ///   [out]  DWORD *pdwInputMaximum,
        ///   [out]  DWORD *pdwOutputMinimum,
        ///   [out]  DWORD *pdwOutputMaximum
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4D9585F0-5818-4E7F-925C-4C50AE6A6EDC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4D9585F0-5818-4E7F-925C-4C50AE6A6EDC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamLimits(
            [Out] MFInt pdwInputMinimum,
            [Out] MFInt pdwInputMaximum,
            [Out] MFInt pdwOutputMinimum,
            [Out] MFInt pdwOutputMaximum
        );

        /// <summary>
        /// Gets the current number of input and output streams on this Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="pcInputStreams">
        /// Receives the number of input streams. 
        /// </param>
        /// <param name="pcOutputStreams">
        /// Receives the number of output streams. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamCount(
        ///   [out]  DWORD *pcInputStreams,
        ///   [out]  DWORD *pcOutputStreams
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/491F7F44-FCAC-4236-BA5C-E5705267C6C2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/491F7F44-FCAC-4236-BA5C-E5705267C6C2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamCount(
            [Out] MFInt pcInputStreams,
            [Out] MFInt pcOutputStreams
        );

        /// <summary>
        /// Gets the stream identifiers for the input and output streams on this Media Foundation transform
        /// (MFT). 
        /// </summary>
        /// <param name="dwInputIDArraySize">
        /// Number of elements in the <em>pdwInputIDs</em> array. 
        /// </param>
        /// <param name="pdwInputIDs">
        /// Pointer to an array allocated by the caller. The method fills the array with the input stream
        /// identifiers. The array size must be at least equal to the number of input streams. To get the
        /// number of input streams, call <see cref="Transform.IMFTransform.GetStreamCount"/>. 
        /// <para/>
        /// If the caller passes an array that is larger than the number of input streams, the MFT must not
        /// write values into the extra array entries.
        /// </param>
        /// <param name="dwOutputIDArraySize">
        /// Number of elements in the <em>pdwOutputIDs</em> array. 
        /// </param>
        /// <param name="pdwOutputIDs">
        /// Pointer to an array allocated by the caller. The method fills the array with the output stream
        /// identifiers. The array size must be at least equal to the number of output streams. To get the
        /// number of output streams, call <c>GetStreamCount</c>. 
        /// <para/>
        /// If the caller passes an array that is larger than the number of output streams, the MFT must not
        /// write values into the extra array entries.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description> Not implemented. See Remarks. </description></item>
        /// <item><term><strong>MF_E_BUFFERTOOSMALL</strong></term><description> One or both of the arrays is too small. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamIDs(
        ///   [in]   DWORD dwInputIDArraySize,
        ///   [out]  DWORD *pdwInputIDs,
        ///   [in]   DWORD dwOutputIDArraySize,
        ///   [out]  DWORD *pdwOutputIDs
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0715C78E-DE92-439D-A4F3-078E19F78A8E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0715C78E-DE92-439D-A4F3-078E19F78A8E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamIDs(
            int dwInputIDArraySize,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] int [] pdwInputIDs,
            int dwOutputIDArraySize,
            [Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] int[] pdwOutputIDs
        );

        /// <summary>
        /// Gets the buffer requirements and other information for an input stream on this Media Foundation
        /// transform (MFT). 
        /// </summary>
        /// <param name="dwInputStreamID">
        /// Input stream identifier. To get the list of stream identifiers, call 
        /// <see cref="Transform.IMFTransform.GetStreamIDs"/>. 
        /// </param>
        /// <param name="pStreamInfo">
        /// Pointer to an <see cref="Transform.MFTInputStreamInfo"/> structure. The method fills the structure
        /// with information about the input stream. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream identifier. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetInputStreamInfo(
        ///   [in]   DWORD dwInputStreamID,
        ///   [out]  MFT_INPUT_STREAM_INFO *pStreamInfo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D57FFAC7-1A92-4C6B-BD59-0ACD7239C0A6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D57FFAC7-1A92-4C6B-BD59-0ACD7239C0A6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetInputStreamInfo(
            int dwInputStreamID,
            out MFTInputStreamInfo pStreamInfo
        );

        /// <summary>
        /// Gets the buffer requirements and other information for an output stream on this Media Foundation
        /// transform (MFT). 
        /// </summary>
        /// <param name="dwOutputStreamID">
        /// Output stream identifier. To get the list of stream identifiers, call 
        /// <see cref="Transform.IMFTransform.GetStreamIDs"/>. 
        /// </param>
        /// <param name="pStreamInfo">
        /// Pointer to an <see cref="Transform.MFTOutputStreamInfo"/> structure. The method fills the structure
        /// with information about the output stream. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream number. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetOutputStreamInfo(
        ///   [in]   DWORD dwOutputStreamID,
        ///   [out]  MFT_OUTPUT_STREAM_INFO *pStreamInfo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/06CC7F1D-57A3-43B8-AB83-8D2EE8E655B5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/06CC7F1D-57A3-43B8-AB83-8D2EE8E655B5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputStreamInfo(
            int dwOutputStreamID,
            out MFTOutputStreamInfo pStreamInfo
        );

        /// <summary>
        /// Gets the global attribute store for this Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="pAttributes">
        /// Receives a pointer to the <see cref="IMFAttributes"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description> The MFT does not support attributes. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetAttributes(
        ///   [out]  IMFAttributes **pAttributes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CB3BA2BC-550C-43B4-A69C-B546F2B92ACC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CB3BA2BC-550C-43B4-A69C-B546F2B92ACC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAttributes(
            [MarshalAs(UnmanagedType.Interface)] out IMFAttributes pAttributes
        );

        /// <summary>
        /// Gets the attribute store for an input stream on this Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="dwInputStreamID">
        /// Input stream identifier. To get the list of stream identifiers, call 
        /// <see cref="Transform.IMFTransform.GetStreamIDs"/>. 
        /// </param>
        /// <param name="pAttributes">The p attributes.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description> The MFT does not support input stream attributes. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream identifier. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetInputStreamAttributes(
        ///   [in]   DWORD dwInputStreamID,
        ///   [out]  IMFAttributes **ppAttributes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2698DA30-6913-41A9-9D98-F124CF31E591(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2698DA30-6913-41A9-9D98-F124CF31E591(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetInputStreamAttributes(
            int dwInputStreamID,
            [MarshalAs(UnmanagedType.Interface)] out IMFAttributes pAttributes
        );

        /// <summary>
        /// Gets the attribute store for an output stream on this Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="dwOutputStreamID">
        /// Output stream identifier. To get the list of stream identifiers, call 
        /// <see cref="Transform.IMFTransform.GetStreamIDs"/>. 
        /// </param>
        /// <param name="pAttributes">The p attributes.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description> The MFT does not support output stream attributes. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream identifier. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetOutputStreamAttributes(
        ///   [in]   DWORD dwOutputStreamID,
        ///   [out]  IMFAttributes **ppAttributes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D54CE20C-8EF9-4480-9DDD-908751FC0A7E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D54CE20C-8EF9-4480-9DDD-908751FC0A7E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputStreamAttributes(
            int dwOutputStreamID,
            [MarshalAs(UnmanagedType.Interface)] out IMFAttributes pAttributes
        );

        /// <summary>
        /// Removes an input stream from this Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="dwStreamID">
        /// Identifier of the input stream to remove. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description> The transform has a fixed number of input streams. </description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description> The stream is not removable, or the transform currently has the minimum number of input streams it can support. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream identifier. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_INPUT_REMAINING</strong></term><description> The transform has unprocessed input buffers for the specified stream. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT DeleteInputStream(
        ///   [in]  DWORD dwStreamID
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CBA37F7F-6AB2-469C-95C2-61D9E4D31D0B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CBA37F7F-6AB2-469C-95C2-61D9E4D31D0B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int DeleteInputStream(
            int dwStreamID
        );

        /// <summary>
        /// Adds one or more new input streams to this Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="cStreams">
        /// Number of streams to add. 
        /// </param>
        /// <param name="adwStreamIDs">
        /// Array of stream identifiers. The new stream identifiers must not match any existing input streams. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description> Invalid argument. </description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description> The MFT has a fixed number of input streams. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AddInputStreams(
        ///   [in]  DWORD cStreams,
        ///   [in]  DWORD *adwStreamIDs
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/311AB66E-5DBD-452A-BAD4-99A6293CBC60(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/311AB66E-5DBD-452A-BAD4-99A6293CBC60(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AddInputStreams(
            int cStreams,
            [In, MarshalAs(UnmanagedType.LPArray, SizeParamIndex=0)] int[] adwStreamIDs
        );

        /// <summary>
        /// Gets an available media type for an input stream on this Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="dwInputStreamID">
        /// Input stream identifier. To get the list of stream identifiers, call 
        /// <see cref="Transform.IMFTransform.GetStreamIDs"/>. 
        /// </param>
        /// <param name="dwTypeIndex">
        /// Index of the media type to retrieve. Media types are indexed from zero and returned in approximate
        /// order of preference. 
        /// </param>
        /// <param name="ppType">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description> The MFT does not have a list of available input types. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream identifier. </description></item>
        /// <item><term><strong>MF_E_NO_MORE_TYPES</strong></term><description> The <em>dwTypeIndex</em> parameter is out of range. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description> You must set the output types before setting the input types. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetInputAvailableType(
        ///   [in]   DWORD dwInputStreamID,
        ///   [in]   DWORD dwTypeIndex,
        ///   [out]  IMFMediaType **ppType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/ED4CFDD0-28D5-4775-AA32-C17C6B13E5BF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ED4CFDD0-28D5-4775-AA32-C17C6B13E5BF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetInputAvailableType(
            int dwInputStreamID,
            int dwTypeIndex,
            [MarshalAs(UnmanagedType.Interface)] out IMFMediaType ppType
        );

        /// <summary>
        /// Gets an available media type for an output stream on this Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="dwOutputStreamID">
        /// Output stream identifier. To get the list of stream identifiers, call 
        /// <see cref="Transform.IMFTransform.GetStreamIDs"/>. 
        /// </param>
        /// <param name="dwTypeIndex">
        /// Index of the media type to retrieve. Media types are indexed from zero and returned in approximate
        /// order of preference. 
        /// </param>
        /// <param name="ppType">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description> The MFT does not have a list of available output types. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream identifier. </description></item>
        /// <item><term><strong>MF_E_NO_MORE_TYPES</strong></term><description> The <em>dwTypeIndex</em> parameter is out of range. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description> You must set the input types before setting the output types. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetOutputAvailableType(
        ///   [in]   DWORD dwOutputStreamID,
        ///   [in]   DWORD dwTypeIndex,
        ///   [out]  IMFMediaType **ppType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D0F75414-18CF-4E76-B875-5F373510C87B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D0F75414-18CF-4E76-B875-5F373510C87B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputAvailableType(
            int dwOutputStreamID,
            int dwTypeIndex,
            [MarshalAs(UnmanagedType.Interface)] out IMFMediaType ppType
        );

        /// <summary>
        /// Sets, tests, or clears the media type for an input stream on this Media Foundation transform (MFT).
        /// </summary>
        /// <param name="dwInputStreamID">
        /// Input stream identifier. To get the list of stream identifiers, call 
        /// <see cref="Transform.IMFTransform.GetStreamIDs"/>. 
        /// </param>
        /// <param name="pType">
        /// Pointer to the <see cref="IMFMediaType"/> interface, or <strong>NULL</strong>. 
        /// </param>
        /// <param name="dwFlags">
        /// Zero or more flags from the <see cref="Transform.MFTSetTypeFlags"/> enumeration. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDMEDIATYPE</strong></term><description> The MFT cannot use the proposed media type. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream identifier. </description></item>
        /// <item><term><strong>MF_E_INVALIDTYPE</strong></term><description> The proposed type is not valid. This error code indicates that the media type itself is not configured correctly; for example, it might contain mutually contradictory attributes. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_CANNOT_CHANGE_MEDIATYPE_WHILE_PROCESSING</strong></term><description> The MFT cannot switch types while processing data. Try draining or flushing the MFT. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description> You must set the output types before setting the input types. </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_D3D_TYPE</strong></term><description> The MFT could not find a suitable DirectX Video Acceleration (DXVA) configuration. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetInputType(
        ///   [in]  DWORD dwInputStreamID,
        ///   [in]  IMFMediaType *pType,
        ///   [in]  DWORD dwFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/822A83D1-177A-4A8D-842E-EB76F8253283(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/822A83D1-177A-4A8D-842E-EB76F8253283(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetInputType(
            int dwInputStreamID,
            [In, MarshalAs(UnmanagedType.Interface)] IMFMediaType pType,
            MFTSetTypeFlags dwFlags
        );

        /// <summary>
        /// Sets, tests, or clears the media type for an output stream on this Media Foundation transform
        /// (MFT). 
        /// </summary>
        /// <param name="dwOutputStreamID">
        /// Output stream identifier. To get the list of stream identifiers, call 
        /// <see cref="Transform.IMFTransform.GetStreamIDs"/>. 
        /// </param>
        /// <param name="pType">
        /// Pointer to the <see cref="IMFMediaType"/> interface, or <strong>NULL</strong>. 
        /// </param>
        /// <param name="dwFlags">
        /// Zero or more flags from the <see cref="Transform.MFTSetTypeFlags"/> enumeration. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDMEDIATYPE</strong></term><description> The transform cannot use the proposed media type. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream identifier. </description></item>
        /// <item><term><strong>MF_E_INVALIDTYPE</strong></term><description> The proposed type is not valid. This error code indicates that the media type itself is not configured correctly; for example, it might contain mutually contradictory flags. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_CANNOT_CHANGE_MEDIATYPE_WHILE_PROCESSING</strong></term><description> The MFT cannot switch types while processing data. Try draining or flushing the MFT. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description> You must set the input types before setting the output types. </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_D3D_TYPE</strong></term><description> The MFT could not find a suitable DirectX Video Acceleration (DXVA) configuration. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetOutputType(
        ///   [in]  DWORD dwOutputStreamID,
        ///   [in]  IMFMediaType *pType,
        ///   [in]  DWORD dwFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A9A1D03F-2E56-490C-885B-78C69DEA8E92(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A9A1D03F-2E56-490C-885B-78C69DEA8E92(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetOutputType(
            int dwOutputStreamID,
            [In, MarshalAs(UnmanagedType.Interface)] IMFMediaType pType,
            MFTSetTypeFlags dwFlags
        );

        /// <summary>
        /// Gets the current media type for an input stream on this Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="dwInputStreamID">
        /// Input stream identifier. To get the list of stream identifiers, call 
        /// <see cref="Transform.IMFTransform.GetStreamIDs"/>. 
        /// </param>
        /// <param name="ppType">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream identifier. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description> The input media type has not been set. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetInputCurrentType(
        ///   [in]   DWORD dwInputStreamID,
        ///   [out]  IMFMediaType **ppType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F3603586-41FD-4EED-9942-28925ED29690(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F3603586-41FD-4EED-9942-28925ED29690(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetInputCurrentType(
            int dwInputStreamID,
            [MarshalAs(UnmanagedType.Interface)] out IMFMediaType ppType
        );

        /// <summary>
        /// Gets the current media type for an output stream on this Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="dwOutputStreamID">
        /// Output stream identifier. To get the list of stream identifiers, call 
        /// <see cref="Transform.IMFTransform.GetStreamIDs"/>. 
        /// </param>
        /// <param name="ppType">
        /// Receives a pointer to the <see cref="IMFMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream identifier. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description> The output media type has not been set. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetOutputCurrentType(
        ///   [in]   DWORD dwOutputStreamID,
        ///   [out]  IMFMediaType **ppType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/433C1918-4B87-40B1-A32B-DB5CDD74D769(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/433C1918-4B87-40B1-A32B-DB5CDD74D769(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputCurrentType(
            int dwOutputStreamID,
            [MarshalAs(UnmanagedType.Interface)] out IMFMediaType ppType
        );

        /// <summary>
        /// Queries whether an input stream on this Media Foundation transform (MFT) can accept more data. 
        /// </summary>
        /// <param name="dwInputStreamID">
        /// Input stream identifier. To get the list of stream identifiers, call 
        /// <see cref="Transform.IMFTransform.GetStreamIDs"/>. 
        /// </param>
        /// <param name="pdwFlags">
        /// Receives a member of the <see cref="Transform.MFTInputStatusFlags"/> enumeration, or zero. If the
        /// value is <strong>MFT_INPUT_STATUS_ACCEPT_DATA</strong>, the stream specified in <em>dwInputStreamID
        /// </em> can accept more input data. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream identifier. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description> The media type is not set on one or more streams. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetInputStatus(
        ///   [in]   DWORD dwInputStreamID,
        ///   [out]  DWORD *pdwFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6205DC1A-F209-49AA-8632-837783EF5F04(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6205DC1A-F209-49AA-8632-837783EF5F04(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetInputStatus(
            int dwInputStreamID,
            out MFTInputStatusFlags pdwFlags
        );

        /// <summary>
        /// Queries whether the Media Foundation transform (MFT) is ready to produce output data. 
        /// </summary>
        /// <param name="pdwFlags">
        /// Receives a member of the <see cref="Transform.MFTOutputStatusFlags"/> enumeration, or zero. If the
        /// value is <strong>MFT_OUTPUT_STATUS_SAMPLE_READY</strong>, the MFT can produce an output sample. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description> Not implemented. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description> The media type is not set on one or more streams. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetOutputStatus(
        ///   [out]  DWORD *pdwFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3EB82F76-088B-4ABC-9F3A-DFA5ECD1068D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3EB82F76-088B-4ABC-9F3A-DFA5ECD1068D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputStatus(
            out MFTOutputStatusFlags pdwFlags
        );

        /// <summary>
        /// Sets the range of time stamps the client needs for output. 
        /// </summary>
        /// <param name="hnsLowerBound">
        /// Specifies the earliest time stamp. The Media Foundation transform (MFT) will accept input until it
        /// can produce an output sample that begins at this time; or until it can produce a sample that ends
        /// at this time or later. If there is no lower bound, use the value <strong>
        /// MFT_OUTPUT_BOUND_LOWER_UNBOUNDED</strong>. 
        /// </param>
        /// <param name="hnsUpperBound">
        /// Specifies the latest time stamp. The MFT will not produce an output sample with time stamps later
        /// than this time. If there is no upper bound, use the value <strong>MFT_OUTPUT_BOUND_UPPER_UNBOUNDED
        /// </strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description> Not implemented. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description> The media type is not set on one or more streams. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetOutputBounds(
        ///   LONGLONG hnsLowerBound,
        ///   LONGLONG hnsUpperBound
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/045F2F16-3F32-4CC4-9052-424F32274F34(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/045F2F16-3F32-4CC4-9052-424F32274F34(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetOutputBounds(
            long hnsLowerBound,
            long hnsUpperBound
        );

        /// <summary>
        /// Sends an event to an input stream on this Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="dwInputStreamID">
        /// Input stream identifier. To get the list of stream identifiers, call 
        /// <see cref="Transform.IMFTransform.GetStreamIDs"/>. 
        /// </param>
        /// <param name="pEvent">
        /// Pointer to the <see cref="IMFMediaEvent"/> interface of an event object. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description> Not implemented. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream number. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description> The media type is not set on one or more streams. </description></item>
        /// <item><term><strong>MF_S_TRANSFORM_DO_NOT_PROPAGATE_EVENT</strong></term><description> The pipeline should not propagate the event. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ProcessEvent(
        ///   [in]  DWORD dwInputStreamID,
        ///   [in]  IMFMediaEvent *pEvent
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/28366DF3-C414-45FF-BB15-C5483F11DE85(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/28366DF3-C414-45FF-BB15-C5483F11DE85(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ProcessEvent(
            int dwInputStreamID,
            [In, MarshalAs(UnmanagedType.Interface)] IMFMediaEvent pEvent
        );

        /// <summary>
        /// Sends a message to the Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="eMessage">
        /// The message to send, specified as a member of the <see cref="Transform.MFTMessageType"/>
        /// enumeration. 
        /// </param>
        /// <param name="ulParam">
        /// Message parameter. The meaning of this parameter depends on the message type. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream number. Applies to the <strong>MFT_MESSAGE_NOTIFY_END_OF_STREAM</strong> message. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description> The media type is not set on one or more streams. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ProcessMessage(
        ///   [in]  MFT_MESSAGE_TYPE eMessage,
        ///   [in]  ULONG_PTR ulParam
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A6DC67E5-8473-444A-8463-24F411E59565(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A6DC67E5-8473-444A-8463-24F411E59565(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ProcessMessage(
            MFTMessageType eMessage,
            IntPtr ulParam
        );

        /// <summary>
        /// Delivers data to an input stream on this Media Foundation transform (MFT). 
        /// </summary>
        /// <param name="dwInputStreamID">
        /// Input stream identifier. To get the list of stream identifiers, call 
        /// <see cref="Transform.IMFTransform.GetStreamIDs"/>. 
        /// </param>
        /// <param name="pSample">
        /// Pointer to the <see cref="IMFSample"/> interface of the input sample. The sample must contain at
        /// least one media buffer that contains valid input data. 
        /// </param>
        /// <param name="dwFlags">
        /// Reserved. Must be zero. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description> Invalid argument. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream identifier. </description></item>
        /// <item><term><strong>MF_E_NO_SAMPLE_DURATION</strong></term><description>The input sample requires a valid sample duration. To set the duration, call <see cref="IMFSample.SetSampleDuration"/>. Some MFTs require that input samples have valid durations. Some MFTs do not require sample durations.</description></item>
        /// <item><term><strong>MF_E_NO_SAMPLE_TIMESTAMP</strong></term><description>The input sample requires a time stamp. To set the time stamp, call <see cref="IMFSample.SetSampleTime"/>. Some MFTs require that input samples have valid time stamps. Some MFTs do not require time stamps.</description></item>
        /// <item><term><strong>MF_E_NOTACCEPTING</strong></term><description> The transform cannot process more input at this time. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description> The media type is not set on one or more streams. </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_D3D_TYPE</strong></term><description> The media type is not supported for DirectX Video Acceleration (DXVA). A DXVA-enabled decoder might return this error code. </description></item>
        /// </list>
        /// <para/>
        /// <strong>Note</strong> If you are converting a DirectX Media Object (DMO) to an MFT, be aware that 
        /// <strong>S_FALSE</strong> is not a valid return code for <strong>IMFTransform::ProcessInput</strong>
        /// , unlike the <strong>IMediaObject::ProcessInput</strong> method. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ProcessInput(
        ///   [in]  DWORD dwInputStreamID,
        ///   [in]  IMFSample *pSample,
        ///   [in]  DWORD dwFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C94D406B-7CD9-42D4-AE9E-3D21DBB47209(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C94D406B-7CD9-42D4-AE9E-3D21DBB47209(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ProcessInput(
            int dwInputStreamID,
            [MarshalAs(UnmanagedType.Interface)] IMFSample pSample,
            int dwFlags // Must be zero
        );

        /// <summary>
        /// Generates output from the current input data. 
        /// </summary>
        /// <param name="dwFlags">
        /// Bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="Transform.MFTProcessOutputFlags"/> enumeration. 
        /// </param>
        /// <param name="cOutputBufferCount">
        /// Number of elements in the <em>pOutputSamples</em> array. The value must be at least 1. 
        /// </param>
        /// <param name="pOutputSamples">
        /// Pointer to an array of <see cref="Transform.MFTOutputDataBuffer"/> structures, allocated by the
        /// caller. The MFT uses this array to return output data to the caller. 
        /// </param>
        /// <param name="pdwStatus">
        /// Receives a bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="Transform.ProcessOutputStatus"/> enumeration. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_UNEXPECTED</strong></term><description>The <c>ProcessOutput</c> method was called on an asynchronous MFT that was not expecting this method call. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> Invalid stream identifier in the <strong>dwStreamID</strong> member of one or more <see cref="Transform.MFTOutputDataBuffer"/> structures. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_NEED_MORE_INPUT</strong></term><description> The transform cannot produce output data until it receives more input data. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_STREAM_CHANGE</strong></term><description> The format has changed on an output stream, or there is a new preferred format, or there is a new output stream. </description></item>
        /// <item><term><strong>MF_E_TRANSFORM_TYPE_NOT_SET</strong></term><description> You must set the media type on one or more streams of the MFT. </description></item>
        /// </list>
        /// <para/>
        /// <strong>Note</strong> If you are converting a DirectX Media Object (DMO) to an MFT, be aware that 
        /// <strong>S_FALSE</strong> is not a valid return code for <strong>IMFTransform::ProcessOutput
        /// </strong>, unlike the <strong>IMediaObject::ProcessOutput</strong> method. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ProcessOutput(
        ///   [in]       DWORD dwFlags,
        ///   [in]       DWORD cOutputBufferCount,
        ///   [in, out]  MFT_OUTPUT_DATA_BUFFER *pOutputSamples,
        ///   [out]      DWORD *pdwStatus
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DC58CC75-7E01-4F47-A572-8E3CA1BC43B4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DC58CC75-7E01-4F47-A572-8E3CA1BC43B4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ProcessOutput(
            MFTProcessOutputFlags dwFlags,
            int cOutputBufferCount,
            [In, Out, MarshalAs(UnmanagedType.LPArray, SizeParamIndex=1)] MFTOutputDataBuffer [] pOutputSamples,
            out ProcessOutputStatus pdwStatus
        );
    }

}
