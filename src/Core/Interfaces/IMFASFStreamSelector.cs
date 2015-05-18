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
    /// Selects streams in an Advanced Systems Format (ASF) file, based on the mutual exclusion information
    /// in the ASF header. The ASF stream selector object exposes this interface. To create the ASF stream
    /// selector, call <see cref="MFExtern.MFCreateASFStreamSelector"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D2E1FC15-2E12-4698-A4B1-CA8046D228DE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D2E1FC15-2E12-4698-A4B1-CA8046D228DE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("d01bad4a-4fa0-4a60-9349-c27e62da9d41"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFASFStreamSelector
    {
        /// <summary>
        /// Retrieves the number of streams that are in the Advanced Systems Format (ASF) content.
        /// </summary>
        /// <param name="pcStreams">
        /// Receives the number of streams in the content.
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
        /// HRESULT GetStreamCount(
        ///   [out]  DWORD *pcStreams
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E1E80C32-BFD4-4404-9CCC-05B5077B83A6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E1E80C32-BFD4-4404-9CCC-05B5077B83A6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamCount(
            out int pcStreams);

        /// <summary>
        /// Retrieves the number of outputs for the Advanced Systems Format (ASF) content.
        /// </summary>
        /// <param name="pcOutputs">
        /// Receives the number of outputs.
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
        /// HRESULT GetOutputCount(
        ///   [out]  DWORD *pcOutputs
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/09F00F52-F897-46F0-AFB9-AE59913E04A1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/09F00F52-F897-46F0-AFB9-AE59913E04A1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputCount(
            out int pcOutputs);

        /// <summary>
        /// Retrieves the number of streams associated with an output.
        /// </summary>
        /// <param name="dwOutputNum">
        /// The output number for which to retrieve the stream count.
        /// </param>
        /// <param name="pcStreams">
        /// Receives the number of streams associated with the output.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>Invalid output number.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetOutputStreamCount(
        ///   [in]   DWORD dwOutputNum,
        ///   [out]  DWORD *pcStreams
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/928E958B-55DC-4939-8AC3-282389F0077A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/928E958B-55DC-4939-8AC3-282389F0077A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputStreamCount(
            [In] int dwOutputNum,
            out int pcStreams);

        /// <summary>
        /// Retrieves the stream numbers for all of the streams that are associated with an output.
        /// </summary>
        /// <param name="dwOutputNum">
        /// The output number for which to retrieve stream numbers.
        /// </param>
        /// <param name="rgwStreamNumbers">
        /// Address of an array that receives the stream numbers associated with the output. The caller
        /// allocates the array. The array size must be at least as large as the value returned by the 
        /// <see cref="IMFASFStreamSelector.GetOutputStreamCount"/> method. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>Invalid output number.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetOutputStreamNumbers(
        ///   [in]   DWORD dwOutputNum,
        ///   [out]  WORD *rgwStreamNumbers
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4A999E7A-1B2E-4206-874A-ED93B868150B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4A999E7A-1B2E-4206-874A-ED93B868150B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputStreamNumbers(
            [In] int dwOutputNum,
            [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)] short[] rgwStreamNumbers);

        /// <summary>
        /// Retrieves the output number associated with a stream.
        /// </summary>
        /// <param name="wStreamNum">
        /// The stream number for which to retrieve an output number.
        /// </param>
        /// <param name="pdwOutput">
        /// Receives the output number.
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
        /// HRESULT GetOutputFromStream(
        ///   [in]   WORD wStreamNum,
        ///   [out]  DWORD *pdwOutput
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A7FF421B-3EF3-406A-AE05-8D8BF9F4357F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A7FF421B-3EF3-406A-AE05-8D8BF9F4357F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputFromStream(
            [In] short wStreamNum,
            out int pdwOutput);

        /// <summary>
        /// Retrieves the manual output override selection that is set for a stream.
        /// </summary>
        /// <param name="dwOutputNum">
        /// Stream number for which to retrieve the output override selection.
        /// </param>
        /// <param name="pSelection">
        /// Receives the output override selection. The value is a member of the 
        /// <see cref="ASFSelectionStatus"/> enumeration. 
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
        /// HRESULT GetOutputOverride(
        ///   [in]   DWORD dwOutputNum,
        ///   [out]  ASF_SELECTION_STATUS *pSelection
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/64413669-BCB9-47FA-9362-B3F6831E55FB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/64413669-BCB9-47FA-9362-B3F6831E55FB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputOverride(
            [In] int dwOutputNum,
            out ASFSelectionStatus pSelection);

        /// <summary>
        /// Sets the selection status of an output, overriding other selection criteria.
        /// </summary>
        /// <param name="dwOutputNum">
        /// Output number for which to set selection.
        /// </param>
        /// <param name="Selection">
        /// Member of the <see cref="ASFSelectionStatus"/> enumeration specifying the level of selection for
        /// the output. 
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
        /// HRESULT SetOutputOverride(
        ///   [in]  DWORD dwOutputNum,
        ///   [in]  ASF_SELECTION_STATUS Selection
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C8AFFECD-107F-4701-88DF-200DB06AD49E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C8AFFECD-107F-4701-88DF-200DB06AD49E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetOutputOverride(
            [In] int dwOutputNum,
            [In] ASFSelectionStatus Selection);

        /// <summary>
        /// Retrieves the number of mutual exclusion objects associated with an output.
        /// </summary>
        /// <param name="dwOutputNum">
        /// Output number for which to retrieve the count of mutually exclusive relationships.
        /// </param>
        /// <param name="pcMutexes">
        /// Receives the number of mutual exclusions.
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
        /// HRESULT GetOutputMutexCount(
        ///   [in]   DWORD dwOutputNum,
        ///   [out]  DWORD *pcMutexes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D6E98595-3307-47F5-806D-796350C78CEC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D6E98595-3307-47F5-806D-796350C78CEC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputMutexCount(
            [In] int dwOutputNum,
            out int pcMutexes);

        /// <summary>
        /// Retrieves a mutual exclusion object for an output.
        /// </summary>
        /// <param name="dwOutputNum">
        /// Output number for which to retrieve a mutual exclusion object.
        /// </param>
        /// <param name="dwMutexNum">
        /// Mutual exclusion number. This is an index of mutually exclusive relationships associated with the
        /// output. Set to a number between 0, and 1 less than the number of mutual exclusion objects retrieved
        /// by calling <see cref="IMFASFStreamSelector.GetOutputMutexCount"/>. 
        /// </param>
        /// <param name="ppMutex">
        /// Receives a pointer to the mutual exclusion object's <strong>IUnknown</strong> interface. The caller
        /// must release the interface. 
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
        /// HRESULT GetOutputMutex(
        ///   [in]   DWORD dwOutputNum,
        ///   [in]   DWORD dwMutexNum,
        ///   [out]  IUnknown **ppMutex
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D134F4A9-9BCA-454F-8DC1-2E152684A4BF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D134F4A9-9BCA-454F-8DC1-2E152684A4BF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetOutputMutex(
            [In] int dwOutputNum,
            [In] int dwMutexNum,
            [MarshalAs(UnmanagedType.IUnknown)] out object ppMutex);

        /// <summary>
        /// Selects a mutual exclusion record to use for a mutual exclusion object associated with an output.
        /// </summary>
        /// <param name="dwOutputNum">
        /// The output number for which to set a stream.
        /// </param>
        /// <param name="dwMutexNum">
        /// Index of the mutual exclusion for which to select.
        /// </param>
        /// <param name="wSelectedRecord">
        /// Record of the specified mutual exclusion to select.
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
        /// HRESULT SetOutputMutexSelection(
        ///   [in]  DWORD dwOutputNum,
        ///   [in]  DWORD dwMutexNum,
        ///   [in]  WORD wSelectedRecord
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EEBAF4A4-FCD5-4438-82EC-E9DA2DE6B0FD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EEBAF4A4-FCD5-4438-82EC-E9DA2DE6B0FD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetOutputMutexSelection(
            [In] int dwOutputNum,
            [In] int dwMutexNum,
            [In] short wSelectedRecord);

        /// <summary>
        /// Retrieves the number of bandwidth steps that exist for the content. This method is used for
        /// multiple bit rate (MBR) content.
        /// </summary>
        /// <param name="pcStepCount">
        /// Receives the number of bandwidth steps.
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
        /// HRESULT GetBandwidthStepCount(
        ///   [out]  DWORD *pcStepCount
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6B7105C1-7395-462F-AD52-DAF621258714(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6B7105C1-7395-462F-AD52-DAF621258714(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetBandwidthStepCount(
            out int pcStepCount);

        /// <summary>
        /// Retrieves the stream numbers that apply to a bandwidth step. This method is used for multiple bit
        /// rate (MBR) content.
        /// </summary>
        /// <param name="dwStepNum">
        /// Bandwidth step number for which to retrieve information. Set this value to a number between 0, and
        /// 1 less than the number of bandwidth steps returned by 
        /// <see cref="IMFASFStreamSelector.GetBandwidthStepCount"/>. 
        /// </param>
        /// <param name="pdwBitrate">
        /// Receives the bit rate associated with the bandwidth step.
        /// </param>
        /// <param name="rgwStreamNumbers">
        /// Address of an array that receives the stream numbers. The caller allocates the array. The array
        /// size must be at least as large as the value returned by the 
        /// <see cref="IMFASFStreamSelector.GetStreamCount"/> method. 
        /// </param>
        /// <param name="rgSelections">
        /// Address of an array that receives the selection status of each stream, as an 
        /// <see cref="ASFSelectionStatus"/> value. The members of this array correspond to the members of the 
        /// <em>rgwStreamNumbers</em> array by index. The caller allocates the array. The array size must be at
        /// least as large as the value returned by the <see cref="IMFASFStreamSelector.GetStreamCount"/>
        /// method. 
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
        /// HRESULT GetBandwidthStep(
        ///   [in]   DWORD dwStepNum,
        ///   [out]  DWORD *pdwBitrate,
        ///   [out]  WORD *rgwStreamNumbers,
        ///   [out]  ASF_SELECTION_STATUS *rgSelections
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/82D9B642-48E3-4EF5-B0E1-B72F1DD39B2C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/82D9B642-48E3-4EF5-B0E1-B72F1DD39B2C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetBandwidthStep(
            [In] int dwStepNum,
            out int pdwBitrate,
            [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I2)] short[] rgwStreamNumbers,
            [Out, MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.I4)] ASFSelectionStatus[] rgSelections);

        /// <summary>
        /// Retrieves the index of a bandwidth step that is appropriate for a specified bit rate. This method
        /// is used for multiple bit rate (MBR) content.
        /// </summary>
        /// <param name="dwBitrate">
        /// The bit rate to find a bandwidth step for.
        /// </param>
        /// <param name="pdwStepNum">
        /// Receives the step number. Use this number to retrieve information about the step by calling 
        /// <see cref="IMFASFStreamSelector.GetBandwidthStep"/>. 
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
        /// HRESULT BitrateToStepNumber(
        ///   [in]   DWORD dwBitrate,
        ///   [out]  DWORD *pdwStepNum
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E2DEBBCE-F6EE-45D7-BF05-2B07AA7719C7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E2DEBBCE-F6EE-45D7-BF05-2B07AA7719C7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BitrateToStepNumber(
            [In] int dwBitrate,
            out int pdwStepNum);

        /// <summary>
        /// Sets options for the stream selector.
        /// </summary>
        /// <param name="dwStreamSelectorFlags">
        /// Bitwise <strong>OR</strong> of zero or more members of the <c>MFASF_STREAMSELECTOR_FLAGS</c>
        /// enumeration specifying the options to use. 
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
        /// HRESULT SetStreamSelectorFlags(
        ///   [in]  DWORD dwStreamSelectorFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A2A0F318-0DE2-49E0-B8F2-847AB1371752(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A2A0F318-0DE2-49E0-B8F2-847AB1371752(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetStreamSelectorFlags(
            [In] MFAsfStreamSelectorFlags dwStreamSelectorFlags);
    }
#endif
}
