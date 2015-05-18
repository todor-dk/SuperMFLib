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
    /// Provides methods to work with the header section of files conforming to the Advanced Systems Format
    /// (ASF) specification. 
    /// <para/>
    /// The <c>ASF ContentInfo Object</c> exposes this interface. To create the get a pointer to the 
    /// <strong>IMFASFContentInfo</strong> interface, call <see cref="MFExtern.MFCreateASFContentInfo"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9F490E6A-F378-45C1-A69D-985C6E884358(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9F490E6A-F378-45C1-A69D-985C6E884358(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("B1DCA5CD-D5DA-4451-8E9E-DB5C59914EAD"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFASFContentInfo
    {
        /// <summary>
        /// Retrieves the size of the header section of an Advanced Systems Format (ASF) file. 
        /// </summary>
        /// <param name="pIStartOfContent">
        /// The <see cref="IMFMediaBuffer"/> interface of a buffer object containing the beginning of ASF
        /// content. The size of the valid data in the buffer must be at least MFASF_MIN_HEADER_BYTES in bytes.
        /// </param>
        /// <param name="cbHeaderSize">
        /// Receives the size, in bytes, of the header section of the content. The value includes the size of
        /// the ASF Header Object plus the size of the header section of the Data Object. Therefore, the
        /// resulting value is the offset to the start of the data packets in the ASF Data Object.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_ASF_INVALIDDATA</strong></term><description> The buffer does not contain valid ASF data. </description></item>
        /// <item><term><strong>MF_E_BUFFERTOOSMALL</strong></term><description> The buffer does not contain enough valid data. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetHeaderSize(
        ///   [in]   IMFMediaBuffer *pIStartOfContent,
        ///   [out]  QWORD *cbHeaderSize
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C13EE7E6-DF59-448F-80C4-04AC7C8C98ED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C13EE7E6-DF59-448F-80C4-04AC7C8C98ED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetHeaderSize(
            [In] IMFMediaBuffer pIStartOfContent,
            out long cbHeaderSize);

        /// <summary>
        /// Parses the information in an ASF header and uses that information to set values in the ContentInfo
        /// object. You can pass the entire header in a single buffer or send it in several pieces.
        /// </summary>
        /// <param name="pIHeaderBuffer">
        /// Pointer to the <see cref="IMFMediaBuffer"/> interface of a buffer object containing some or all of
        /// the header. The buffer must contain at least 30 bytes, which is the size of the Header Object, not
        /// including the objects contained in the Header Object (that is, everything up to and including the
        /// Reserved2 field in the Header Object). 
        /// </param>
        /// <param name="cbOffsetWithinHeader">
        /// Offset, in bytes, of the first byte in the buffer relative to the beginning of the header.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The header is completely parsed and validated.</description></item>
        /// <item><term><strong>MF_E_ASF_INVALIDDATA</strong></term><description>The input buffer does not contain valid ASF data.</description></item>
        /// <item><term><strong>MF_E_BUFFERTOOSMALL</strong></term><description>The input buffer is to small.</description></item>
        /// <item><term><strong>MF_S_ASF_PARSEINPROGRESS</strong></term><description>The method succeeded, but the header passed was incomplete. This is the successful return code for all calls but the last one when passing the header in pieces.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ParseHeader(
        ///   [in]  IMFMediaBuffer *pIHeaderBuffer,
        ///   [in]  QWORD cbOffsetWithinHeader
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/149E2514-74E5-403B-925F-53A17DBBCB64(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/149E2514-74E5-403B-925F-53A17DBBCB64(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ParseHeader(
            [In] IMFMediaBuffer pIHeaderBuffer,
            [In] long cbOffsetWithinHeader);

        /// <summary>
        /// Encodes the data in the <strong>MFASFContentInfo</strong> object into a binary Advanced Systems
        /// Format (ASF) header. 
        /// </summary>
        /// <param name="pIHeader">
        /// A pointer to the <see cref="IMFMediaBuffer"/> interface of the buffer object that will receive the
        /// encoded header. Set to <strong>NULL</strong> to retrieve the size of the header. 
        /// </param>
        /// <param name="pcbHeader">
        /// Size of the encoded ASF header in bytes. If <em>pIHeader</em> is <strong>NULL</strong>, this value
        /// is set to the buffer size required to hold the encoded header. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description> The ASF Header Objects do not exist for the media that the ContentInfo object holds reference to. </description></item>
        /// <item><term><strong>MF_E_ASF_INVALIDDATA</strong></term><description> The ASF Header Object size exceeds 10 MB. </description></item>
        /// <item><term><strong>MF_E_BUFFERTOOSMALL</strong></term><description> The buffer passed in <em>pIHeader</em> is not large enough to hold the ASF Header Object information. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GenerateHeader(
        ///   [in, out]  IMFMediaBuffer *pIHeader,
        ///   [out]      DWORD *pcbHeader
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/972F5AE7-AD00-4C3B-8EC4-2CEF4CE03C4E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/972F5AE7-AD00-4C3B-8EC4-2CEF4CE03C4E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GenerateHeader(
            [In] IMFMediaBuffer pIHeader,
            out int pcbHeader);

        /// <summary>
        /// Retrieves an Advanced Systems Format (ASF) profile that describes the ASF content.
        /// </summary>
        /// <param name="ppIProfile">
        /// Receives an <see cref="IMFASFProfile"/> interface pointer. The caller must release the interface.
        /// If the object does not have an ASF profile, this parameter receives the value <strong>NULL</strong>
        /// . 
        /// </param>
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
        /// HRESULT GetProfile(
        ///   [out]  IMFASFProfile **ppIProfile
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6F74C896-A0C0-407B-B893-DE15863BC2EB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6F74C896-A0C0-407B-B893-DE15863BC2EB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetProfile(
            out IMFASFProfile ppIProfile);

        /// <summary>
        /// Uses profile data from a profile object to configure settings in the ContentInfo object.
        /// </summary>
        /// <param name="pIProfile">
        /// The <see cref="IMFASFProfile"/> interface of the profile object. 
        /// </param>
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
        /// HRESULT SetProfile(
        ///   [in]  IMFASFProfile *pIProfile
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7E7E062D-9507-400A-8CC2-5355C12017F5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7E7E062D-9507-400A-8CC2-5355C12017F5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetProfile(
            [In] IMFASFProfile pIProfile);

        /// <summary>
        /// Creates a presentation descriptor for ASF content.
        /// </summary>
        /// <param name="ppIPresentationDescriptor">
        /// Receives a pointer to the <see cref="IMFPresentationDescriptor"/> interface. The caller must
        /// release the interface. 
        /// </param>
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
        /// HRESULT GeneratePresentationDescriptor(
        ///   [out]  IMFPresentationDescriptor **ppIPresentationDescriptor
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F22CB48D-1346-4182-8CA2-F57A7FDC76E4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F22CB48D-1346-4182-8CA2-F57A7FDC76E4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GeneratePresentationDescriptor(
            out IMFPresentationDescriptor ppIPresentationDescriptor);

        /// <summary>
        /// Retrieves a property store that can be used to set encoding properties.
        /// </summary>
        /// <param name="wStreamNumber">
        /// Stream number to configure. Set to zero to configure file-level encoding properties.
        /// </param>
        /// <param name="ppIStore">
        /// Receives a pointer to the <strong>IPropertyStore</strong> interface. The caller must release the
        /// interface. 
        /// </param>
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
        /// HRESULT GetEncodingConfigurationPropertyStore(
        ///   [in]   WORD wStreamNumber,
        ///   [out]  IPropertyStore **ppIStore
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E77A5564-82BC-4C1D-9FB8-84AB484C4CA8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E77A5564-82BC-4C1D-9FB8-84AB484C4CA8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetEncodingConfigurationPropertyStore(
            [In] short wStreamNumber,
            out IPropertyStore ppIStore);
    }
#endif
}
