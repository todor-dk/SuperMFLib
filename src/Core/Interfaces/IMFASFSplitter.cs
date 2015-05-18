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

namespace MediaFoundation.Core.Interfaces
{
#if NOT_IN_USE

    /// <summary>
    /// Provides methods to read data from an Advanced Systems Format (ASF) file. The ASF splitter object
    /// exposes this interface. To create the ASF splitter, <see cref="MFExtern.MFCreateASFSplitter"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/75D8B2A3-7C50-4DD5-8927-B11EB9F12602(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/75D8B2A3-7C50-4DD5-8927-B11EB9F12602(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("12558295-E399-11D5-BC2A-00B0D0F3F4AB"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFASFSplitter
    {
        /// <summary>
        /// Resets the Advanced Systems Format (ASF) splitter and configures it to parse data from an ASF data
        /// section.
        /// </summary>
        /// <param name="pIContentInfo">
        /// Pointer to the <see cref="IMFASFContentInfo"/> interface of a ContentInfo object that describes the
        /// data to be parsed. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The <em>pIContentInfo</em> parameter is <strong>NULL</strong>. </description></item>
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
        /// <a href="http://msdn.microsoft.com/en-US/library/DD69C2F9-DABF-4BBA-BB3B-75EC3208C189(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DD69C2F9-DABF-4BBA-BB3B-75EC3208C189(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Initialize(
            [In] IMFASFContentInfo pIContentInfo);

        /// <summary>
        /// Sets option flags on the Advanced Systems Format (ASF) splitter.
        /// </summary>
        /// <param name="dwFlags">
        /// A bitwise combination of zero or more members of the <see cref="MFASFSplitterFlags"/> enumeration. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>The splitter is not initialized.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The <em>dwFlags</em> parameter does not contain a valid flag. </description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The MFASF_SPLITTER_REVERSE flag is set, but the content cannot be parsed in reverse.</description></item>
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
        /// <a href="http://msdn.microsoft.com/en-US/library/5C70E5A0-7DD5-49C5-AF35-4D9568871B41(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5C70E5A0-7DD5-49C5-AF35-4D9568871B41(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetFlags(
            [In] MFASFSplitterFlags dwFlags);

        /// <summary>
        /// Retrieves the option flags that are set on the ASF splitter.
        /// </summary>
        /// <param name="pdwFlags">
        /// Receives the option flags. This value is a bitwise <strong>OR</strong> of zero or more members of
        /// the <see cref="MFASFSplitterFlags"/> enumeration. 
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
        /// <a href="http://msdn.microsoft.com/en-US/library/BA008E4A-98AD-4633-8B80-1D2FFCE04B9C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA008E4A-98AD-4633-8B80-1D2FFCE04B9C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetFlags(
            out MFASFSplitterFlags pdwFlags);

        /// <summary>
        /// Sets the streams to be parsed by the Advanced Systems Format (ASF) splitter.
        /// </summary>
        /// <param name="pwStreamNumbers">
        /// An array of variables containing the list of stream numbers to select.
        /// </param>
        /// <param name="wNumStreams">
        /// The number of valid elements in the stream number array.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description><em>pwStreamNumbers</em> is <strong>NULL</strong> and <em>wNumStreams</em> contains a value greater than zero. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>Invalid stream number was passed in the array.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SelectStreams(
        ///   [in]  WORD *pwStreamNumbers,
        ///   [in]  WORD wNumStreams
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A241F8A4-7609-4A6C-825F-A7B882BFC25F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A241F8A4-7609-4A6C-825F-A7B882BFC25F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SelectStreams(
            [In] short[] pwStreamNumbers,
            [In] short wNumStreams);

        /// <summary>
        /// Gets a list of currently selected streams. 
        /// </summary>
        /// <param name="pwStreamNumbers">
        /// The address of an array of <strong>WORDs</strong>. This array receives the stream numbers of the
        /// selected streams. This parameter can be <strong>NULL</strong>. 
        /// </param>
        /// <param name="pwNumStreams">
        /// On input, points to a variable that contains the number of elements in the <em>pwStreamNumbers</em>
        /// array. Set the variable to zero if <em>pwStreamNumbers</em> is <strong>NULL</strong>. 
        /// <para/>
        /// On output, receives the number of elements that were copied into <em>pwStreamNumbers</em>. Each
        /// element is the identifier of a selected stream. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description> Invalid argument. </description></item>
        /// <item><term><strong>MF_E_BUFFERTOOSMALL</strong></term><description> The <em>pwStreamNumbers</em> array is smaller than the number of selected streams. See Remarks. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetSelectedStreams(
        ///   [out]      WORD *pwStreamNumbers,
        ///   [in, out]  WORD *pwNumStreams
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F2C12E45-F320-43E0-ABF1-36993DFED32D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F2C12E45-F320-43E0-ABF1-36993DFED32D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetSelectedStreams(
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)] short[] pwStreamNumbers,
            ref short pwNumStreams);

        /// <summary>
        /// Sends packetized Advanced Systems Format (ASF) data to the ASF splitter for processing.
        /// </summary>
        /// <param name="pIBuffer">
        /// Pointer to the <see cref="IMFMediaBuffer"/> interface of a buffer object containing data to be
        /// parsed. 
        /// </param>
        /// <param name="cbBufferOffset">
        /// The offset into the data buffer where the splitter should begin parsing. This value is typically
        /// set to 0.
        /// </param>
        /// <param name="cbLength">
        /// The length, in bytes, of the data to parse. This value is measured from the offset specified by 
        /// <em>cbBufferOffset</em>. Set to 0 to process to the end of the buffer. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>The <em>pIBuffer</em> parameter is <strong>NULL</strong>. The specified offset value in <em>cbBufferOffset</em> is greater than the length of the buffer. The total value of <em>cbBufferOffset</em> and <em>cbLength</em> is greater than the length of the buffer. </description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>The <see cref="IMFASFSplitter.Initialize"/> method was not called or the call failed. </description></item>
        /// <item><term><strong>MF_E_NOTACCEPTING</strong></term><description>The splitter cannot process more input at this time.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ParseData(
        ///   [in]  IMFMediaBuffer *pIBuffer,
        ///   [in]  DWORD cbBufferOffset,
        ///   [in]  DWORD cbLength
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/13457C17-AB35-47A3-8E83-00EEF7686841(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/13457C17-AB35-47A3-8E83-00EEF7686841(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ParseData(
            [In] IMFMediaBuffer pIBuffer,
            [In] int cbBufferOffset,
            [In] int cbLength);

        /// <summary>
        /// Retrieves a sample from the Advanced Systems Format (ASF) splitter after the data has been parsed.
        /// </summary>
        /// <param name="pdwStatusFlags">
        /// Receives one of the following values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>ASF_STATUSFLAGS_INCOMPLETE</strong></term><description>More samples are ready to be retrieved. Call <strong>GetNextSample</strong> in a loop until the <em>pdwStatusFlags</em> parameter receives the value zero. </description></item>
        /// <item><term><strong>Zero</strong></term><description>No additional samples are ready. Call <see cref="IMFASFSplitter.ParseData"/> to give more input data to the splitter. </description></item>
        /// </list>
        /// </param>
        /// <param name="pwStreamNumber">
        /// If the method returns a sample in the <em>ppISample</em> parameter, this parameter receives the
        /// number of the stream to which the sample belongs. 
        /// </param>
        /// <param name="ppISample">
        /// Receives a pointer to the <see cref="IMFSample"/> interface of the parsed sample. The caller must
        /// release the interface. If no samples are ready, this parameter receives the value <strong>NULL
        /// </strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_ASF_INVALIDDATA</strong></term><description>The ASF data in the buffer is invalid.</description></item>
        /// <item><term><strong>MF_E_ASF_MISSINGDATA</strong></term><description>There is a gap in the ASF data.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetNextSample(
        ///   [out]  DWORD *pdwStatusFlags,
        ///   [out]  WORD *pwStreamNumber,
        ///   [out]  IMFSample **ppISample
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/85133059-6710-4FB2-B42B-F54747816F9C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/85133059-6710-4FB2-B42B-F54747816F9C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetNextSample(
            out ASFStatusFlags pdwStatusFlags,
            out short pwStreamNumber,
            out IMFSample ppISample);

        /// <summary>
        /// Resets the Advanced Systems Format (ASF) splitter and releases all pending samples.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Flush();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BE92C734-2BCB-4A7C-BD62-FB545C3C7762(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BE92C734-2BCB-4A7C-BD62-FB545C3C7762(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Flush();

        /// <summary>
        /// Retrieves the send time of the last sample received.
        /// </summary>
        /// <param name="pdwLastSendTime">
        /// Receives the send time of the last sample received.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description><em>pdwLastSendTime</em> is <strong>NULL</strong>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetLastSendTime(
        ///   [out]  DWORD *pdwLastSendTime
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/59A6C53C-2CDF-4677-A5A3-4138F107F721(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/59A6C53C-2CDF-4677-A5A3-4138F107F721(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetLastSendTime(
            out int pdwLastSendTime);
    }
#endif
}
