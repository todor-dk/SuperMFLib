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

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// <strong>Note</strong> This interface is not implemented. 
    /// <para/>
    /// Manages information about the relative priorities of a group of streams in an Advanced Systems
    /// Format (ASF) profile. This interface manages information about the relative priorities of a group
    /// of streams in an ASF profile. Priority is used in streaming to determine which streams should be
    /// dropped first when available bandwidth decreases.
    /// <para/>
    /// The ASF stream prioritization object exposes this interface. The stream prioritization object
    /// maintains a list of stream numbers in priority order. The methods of this interface manipulate and
    /// interrogate that list. To obtain a pointer to this interface, call the 
    /// <see cref="IMFASFProfile.CreateStreamPrioritization"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6EB79C52-DC81-406C-9000-D25AD380E6B2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6EB79C52-DC81-406C-9000-D25AD380E6B2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("699bdc27-bbaf-49ff-8e38-9c39c9b5e088"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFASFStreamPrioritization
    {
        /// <summary>
        /// <strong>Note</strong> This interface is not implemented in this version of Media Foundation. 
        /// <para/>
        /// Retrieves the number of entries in the stream priority list.
        /// </summary>
        /// <param name="pdwStreamCount">The PDW stream count.</param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamCount(
        ///   [out]  DWORD dwStreamIndex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8C9DACBB-A952-411E-82DF-0C8768D0B3FE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8C9DACBB-A952-411E-82DF-0C8768D0B3FE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamCount(
            out int pdwStreamCount);

        /// <summary>
        /// <strong>Note</strong> This interface is not implemented in this version of Media Foundation. 
        /// <para/>
        /// Retrieves the stream number of a stream in the stream priority list.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// Zero-based index of the entry to retrieve from the stream priority list. To get the number of
        /// entries in the priority list, call <see cref="IMFASFStreamPrioritization.GetStreamCount"/>. 
        /// </param>
        /// <param name="pwStreamNumber">
        /// Receives the stream number of the stream priority entry.
        /// </param>
        /// <param name="pwStreamFlags">
        /// Receives a Boolean value. If <strong>TRUE</strong>, the stream is mandatory. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description><strong>NULL</strong> pointer argument or the <em>dwStreamIndex</em> parameter is out of range. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStream(
        ///   [in]   DWORD dwStreamIndex,
        ///   [out]  WORD *pwStreamNumber,
        ///   [out]  WORD *pwStreamFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/460A929B-71BF-4F41-9E7A-AF04A8F1C10F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/460A929B-71BF-4F41-9E7A-AF04A8F1C10F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStream(
            [In] int dwStreamIndex,
            out short pwStreamNumber,
            out short pwStreamFlags); // bool

        /// <summary>
        /// <strong>Note</strong> This interface is not implemented in this version of Media Foundation. 
        /// <para/>
        /// Adds a stream to the stream priority list.
        /// </summary>
        /// <param name="wStreamNumber">
        /// Stream number of the stream to add.
        /// </param>
        /// <param name="wStreamFlags">
        /// If <strong>TRUE</strong>, the stream is mandatory. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>Invalid stream number.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AddStream(
        ///   [in]  WORD wStreamNumber,
        ///   [in]  WORD wStreamFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/440D2838-0314-45F7-B73B-653FE5535C88(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/440D2838-0314-45F7-B73B-653FE5535C88(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AddStream(
            [In] short wStreamNumber,
            [In] short wStreamFlags); // bool

        /// <summary>
        /// <strong>Note</strong> This interface is not implemented in this version of Media Foundation. 
        /// <para/>
        /// Removes a stream from the stream priority list.
        /// </summary>
        /// <param name="dwStreamIndex">
        /// Index of the entry in the stream priority list to remove. Values range from zero, to one less than
        /// the stream count retrieved by calling <see cref="IMFASFStreamPrioritization.GetStreamCount"/>. 
        /// </param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT RemoveStream(
        ///   [in]  DWORD dwStreamIndex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A6139042-9C78-4FE7-8549-655E35BE2862(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A6139042-9C78-4FE7-8549-655E35BE2862(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveStream(
            [In] int dwStreamIndex);

        /// <summary>
        /// <strong>Note</strong> This interface is not implemented in this version of Media Foundation. 
        /// <para/>
        /// Creates a copy of the ASF stream prioritization object.
        /// </summary>
        /// <param name="ppIStreamPrioritization">
        /// Receives a pointer to the <see cref="IMFASFStreamPrioritization"/> interface of the new object. The
        /// caller must release the interface. 
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
        /// HRESULT Clone(
        ///   [out]  IMFASFStreamPrioritization **ppIStreamPrioritization
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E4D7CC00-4483-4AA6-8F26-D25DDC5129BB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E4D7CC00-4483-4AA6-8F26-D25DDC5129BB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Clone(
            out IMFASFStreamPrioritization ppIStreamPrioritization);
    }

#endif

}
