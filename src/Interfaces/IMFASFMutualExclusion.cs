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
    /// Configures an Advanced Systems Format (ASF) mutual exclusion object, which manages information
    /// about a group of streams in an ASF profile that are mutually exclusive. When streams or groups of
    /// streams are mutually exclusive, only one of them is read at a time, they are not read concurrently.
    /// <para/>
    /// A common example of mutual exclusion is a set of streams that each include the same content encoded
    /// at a different bit rate. The stream that is used is determined by the available bandwidth to the
    /// reader.
    /// <para/>
    /// An <strong>IMFASFMutualExclusion</strong> interface exists for every ASF mutual exclusion object. A
    /// pointer to this interface is obtained when you create the object using the 
    /// <see cref="IMFASFProfile.CreateMutualExclusion"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9C2278EC-77D1-445E-94BC-44E5D48F14AE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9C2278EC-77D1-445E-94BC-44E5D48F14AE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("12558291-E399-11D5-BC2A-00B0D0F3F4AB"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFASFMutualExclusion
    {
        /// <summary>
        /// Retrieves the type of mutual exclusion represented by the Advanced Systems Format (ASF) mutual
        /// exclusion object.
        /// </summary>
        /// <param name="pguidType">
        /// A variable that receives the type identifier. For a list of predefined mutual exclusion type
        /// constants, see <see cref="MFASFMutexType"/>. 
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
        /// HRESULT GetType(
        ///   [out]  GUID *pguidType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C6AF870E-2EF8-4DEA-B76B-7A78CEAAA3D3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C6AF870E-2EF8-4DEA-B76B-7A78CEAAA3D3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetType(
            out Guid pguidType);

        /// <summary>
        /// Sets the type of mutual exclusion that is represented by the Advanced Systems Format (ASF) mutual
        /// exclusion object.
        /// </summary>
        /// <param name="guidType">
        /// The type of mutual exclusion that is represented by the ASF mutual exclusion object. For a list of
        /// predefined mutual exclusion type constants, see <see cref="MFASFMutexType"/>. 
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
        /// HRESULT SetType(
        ///   [in]  REFGUID guidType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/58FC1C27-0A7D-48BB-B5A4-AB299C5E0AC6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/58FC1C27-0A7D-48BB-B5A4-AB299C5E0AC6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetType(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidType);

        /// <summary>
        /// Retrieves the number of records in the Advanced Systems Format mutual exclusion object.
        /// </summary>
        /// <param name="pdwRecordCount">
        /// Receives the count of records.
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
        /// HRESULT GetRecordCount(
        ///   [out]  DWORD *pdwRecordCount
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8DBD883E-4AE3-422D-BB2E-087A9E311558(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8DBD883E-4AE3-422D-BB2E-087A9E311558(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetRecordCount(
            out int pdwRecordCount);

        /// <summary>
        /// Retrieves the stream numbers contained in a record in the Advanced Systems Format mutual exclusion
        /// object.
        /// </summary>
        /// <param name="dwRecordNumber">
        /// The number of the record for which to retrieve the stream numbers.
        /// </param>
        /// <param name="pwStreamNumArray">
        /// An array that receives the stream numbers. Set to <strong>NULL</strong> to get the number of
        /// elements required, which is indicated by the value of <em>pcStreams</em> on return. If this
        /// parameter is not <strong>NULL</strong>, the method will copy as many stream numbers to the array as
        /// there are elements indicated by the value of <em>pcStreams</em>. 
        /// </param>
        /// <param name="pcStreams">
        /// On input, the number of elements in the array referenced by <em>pwStreamNumArray</em>. On output,
        /// the method sets this value to the count of stream numbers in the record. You can call <strong>
        /// GetStreamsForRecord</strong> with <em>pwStreamNumArray</em> set to <strong>NULL</strong> to
        /// retrieve the number of elements required to hold all of the stream numbers. 
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
        /// HRESULT GetStreamsForRecord(
        ///   [in]       DWORD dwRecordNumber,
        ///   [out]      WORD *pwStreamNumArray,
        ///   [in, out]  DWORD *pcStreams
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CE410AE9-D0D0-4617-8178-829EF3C77CE0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CE410AE9-D0D0-4617-8178-829EF3C77CE0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamsForRecord(
            [In] int dwRecordNumber,
            [In, Out, MarshalAs(UnmanagedType.LPArray, ArraySubType=UnmanagedType.I4)] short [] pwStreamNumArray,
            ref int pcStreams);

        /// <summary>
        /// Adds a stream number to a record in the Advanced Systems Format mutual exclusion object.
        /// </summary>
        /// <param name="dwRecordNumber">
        /// The record number to which the stream is added. A record number is set by the 
        /// <see cref="IMFASFMutualExclusion.AddRecord"/> method. 
        /// </param>
        /// <param name="wStreamNumber">
        /// The stream number to add to the record.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The specified stream number is already associated with the record.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT AddStreamForRecord(
        ///   [in]  DWORD dwRecordNumber,
        ///   [in]  WORD wStreamNumber
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CFBFE3BE-B0A4-408A-952E-E4F996F94CEE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CFBFE3BE-B0A4-408A-952E-E4F996F94CEE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AddStreamForRecord(
            [In] int dwRecordNumber,
            [In] short wStreamNumber);

        /// <summary>
        /// Removes a stream number from a record in the Advanced Systems Format mutual exclusion object.
        /// </summary>
        /// <param name="dwRecordNumber">
        /// The record number from which to remove the stream number.
        /// </param>
        /// <param name="wStreamNumber">
        /// The stream number to remove from the record.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The stream number is not listed for the specified record.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT RemoveStreamFromRecord(
        ///   [in]  DWORD dwRecordNumber,
        ///   [in]  WORD wStreamNumber
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D92C022C-3241-4296-9572-62B43C6E79CB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D92C022C-3241-4296-9572-62B43C6E79CB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveStreamFromRecord(
            [In] int dwRecordNumber,
            [In] short wStreamNumber);

        /// <summary>
        /// Removes a record from the Advanced Systems Format (ASF) mutual exclusion object.
        /// </summary>
        /// <param name="dwRecordNumber">
        /// The index of the record to remove.
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
        /// HRESULT RemoveRecord(
        ///   [in]  DWORD dwRecordNumber
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/ECFB5E10-5102-4F6A-B67B-BA0ED06D0ED8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ECFB5E10-5102-4F6A-B67B-BA0ED06D0ED8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveRecord(
            [In] int dwRecordNumber);

        /// <summary>
        /// Adds a record to the mutual exclusion object. A record specifies streams that are mutually
        /// exclusive with the streams in all other records.
        /// </summary>
        /// <param name="pdwRecordNumber">
        /// Receives the index assigned to the new record. Record indexes are zero-based and sequential.
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
        /// HRESULT AddRecord(
        ///   [out]  DWORD *pdwRecordNumber
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F5DEDC87-A29C-4C8D-B493-486D975F9AC4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F5DEDC87-A29C-4C8D-B493-486D975F9AC4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AddRecord(
            out int pdwRecordNumber);

        /// <summary>
        /// Creates a copy of the Advanced Systems Format mutual exclusion object.
        /// </summary>
        /// <param name="ppIMutex">
        /// Receives a pointer to the <see cref="IMFASFMutualExclusion"/> interface of the new object. The
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
        ///   [out]  IMFASFMutualExclusion **ppIMutex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/32BD09D7-9D85-4692-8B2F-6AFAB3234FA9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/32BD09D7-9D85-4692-8B2F-6AFAB3234FA9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Clone(
            out IMFASFMutualExclusion ppIMutex);
    }

}
