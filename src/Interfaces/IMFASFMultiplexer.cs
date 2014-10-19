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

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Provides methods to create Advanced Systems Format (ASF) data packets. The methods of this
    /// interface process input samples into the packets that make up an ASF data section. The ASF
    /// multiplexer exposes this interface. To create the ASF multiplexer, call 
    /// <see cref="MFExtern.MFCreateASFMultiplexer"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BDB549B5-425B-4F77-B413-723CEB7ACD11(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BDB549B5-425B-4F77-B413-723CEB7ACD11(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("57BDD80A-9B38-4838-B737-C58F670D7D4F"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFASFMultiplexer
    {
        /// <summary>
        /// Initializes the multiplexer with the data from an ASF ContentInfo object.
        /// </summary>
        /// <param name="pIContentInfo">
        /// Pointer to the <see cref="IMFASFContentInfo"/> interface of the <strong>MFASFContentInfo</strong>
        /// object that contains the header information of the new ASF file. The multiplexer will generate data
        /// packets for this file. 
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Initialize(
        ///   [in]  IMFASFContentInfo *pIContentInfo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/61C37BD5-3F6F-434B-AE5B-C25C5213D49F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/61C37BD5-3F6F-434B-AE5B-C25C5213D49F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Initialize(
            [In] IMFASFContentInfo pIContentInfo);

        /// <summary>
        /// Sets multiplexer options.
        /// </summary>
        /// <param name="dwFlags">
        /// Bitwise <strong>OR</strong> of zero or more members of the <see cref="MFASFMultiplexerFlags"/>
        /// enumeration. These flags specify which multiplexer options to use. For more information, see
        /// "Multiplexer Initialization and Leaky Bucket Settings" in <c>Creating the Multiplexer Object</c>. 
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetFlags(
        ///   [in]  DWORD dwFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DAC4F9B0-E83A-4E99-9A4A-EC1154C929A7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DAC4F9B0-E83A-4E99-9A4A-EC1154C929A7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetFlags(
            [In] MFASFMultiplexerFlags dwFlags);

        /// <summary>
        /// Retrieves flags indicating the configured multiplexer options.
        /// </summary>
        /// <param name="pdwFlags">
        /// Receives a bitwise <strong>OR</strong> of zero or more values from the 
        /// <see cref="MFASFMultiplexerFlags"/> enumeration. To set these flags, call 
        /// <see cref="IMFASFMultiplexer.SetFlags"/>. 
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetFlags(
        ///   [out]  DWORD *pdwFlags
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B0AEEFB5-6996-4ABB-B869-855AAA7FCDE2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B0AEEFB5-6996-4ABB-B869-855AAA7FCDE2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetFlags(
            out MFASFMultiplexerFlags pdwFlags);

        /// <summary>
        /// Delivers input samples to the multiplexer. 
        /// </summary>
        /// <param name="wStreamNumber">
        /// The stream number of the stream to which the sample belongs. 
        /// </param>
        /// <param name="pISample">
        /// Pointer to the <see cref="IMFSample"/> interface of the input sample. The input sample contains the
        /// media data to be converted to ASF data packets. When possible, the time stamp of this sample should
        /// be accurate. 
        /// </param>
        /// <param name="hnsTimestampAdjust">
        /// The adjustment to apply to the time stamp of the sample. This parameter is used if the caller wants
        /// to shift the sample time on <em>pISample</em>. This value should be positive if the time stamp
        /// should be pushed ahead and negative if the time stamp should be pushed back. This time stamp is
        /// added to sample time on <em>pISample</em>, and the resulting time is used by the multiplexer
        /// instead of the original sample time. If no adjustment is needed, set this value to 0. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_NOTACCEPTING</strong></term><description> There are too many packets waiting to be retrieved from the multiplexer. Call <see cref="IMFASFMultiplexer.GetNextPacket"/> to get the packets. </description></item>
        /// <item><term><strong>MF_E_BANDWIDTH_OVERRUN</strong></term><description> The sample that was processed violates the bandwidth limitations specified for the stream in the ASF ContentInfo object. When this error is generated, the sample is dropped. </description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description> The value passed in <em>wStreamNumber</em> is invalid. </description></item>
        /// <item><term><strong>MF_E_LATE_SAMPLE</strong></term><description> The presentation time of the input media sample is earlier than the send time. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT ProcessSample(
        ///   [in]  WORD wStreamNumber,
        ///   [in]  IMFSample *pISample,
        ///   [in]  LONGLONG hnsTimestampAdjust
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/30A693BB-255C-47A4-8102-1543872B0A5E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/30A693BB-255C-47A4-8102-1543872B0A5E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ProcessSample(
            [In] short wStreamNumber,
            [In] IMFSample pISample,
            [In] long hnsTimestampAdjust);

        /// <summary>
        /// Retrieves the next output ASF packet from the multiplexer.
        /// </summary>
        /// <param name="pdwStatusFlags">
        /// Receives zero or more status flags. If more than one packet is waiting, the method sets the 
        /// <strong>ASF_STATUSFLAGS_INCOMPLETE</strong> flag. 
        /// </param>
        /// <param name="ppIPacket">
        /// Receives a pointer to the <see cref="IMFSample"/> interface of the first output sample of the data
        /// packet. The caller must release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetNextPacket(
        ///   [out]  DWORD *pdwStatusFlags,
        ///   [out]  IMFSample **ppIPacket
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/39B9F8A0-FB26-4F46-98FD-B4636F8F88C7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/39B9F8A0-FB26-4F46-98FD-B4636F8F88C7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetNextPacket(
            out ASFStatusFlags pdwStatusFlags,
            out IMFSample ppIPacket);

        /// <summary>
        /// Signals the multiplexer to process all queued output media samples. Call this method after passing
        /// the last sample to the multiplexer.
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT Flush();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/44A66374-AD9D-4C76-8C95-21A15E071C6D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/44A66374-AD9D-4C76-8C95-21A15E071C6D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Flush();

        /// <summary>
        /// Collects data from the multiplexer and updates the ASF ContentInfo object to include that
        /// information in the ASF Header Object.
        /// </summary>
        /// <param name="pIContentInfo">
        /// Pointer to the <see cref="IMFASFContentInfo"/> interface of the ContentInfo object. This must be
        /// the same object that was used to initialize the multiplexer. The ContentInfo object represents the
        /// ASF Header Object of the file for which the multiplexer generated data packets. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_FLUSH_NEEDED</strong></term><description>There are pending output media samples waiting in the multiplexer. Call <see cref="IMFASFMultiplexer.Flush"/> to force the media samples to be packetized. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT End(
        ///   [in]  IMFASFContentInfo *pIContentInfo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2A106EA5-976A-40DF-A554-1B76D9A07286(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2A106EA5-976A-40DF-A554-1B76D9A07286(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int End(
            [In] IMFASFContentInfo pIContentInfo);

        /// <summary>
        /// Retrieves multiplexer statistics.
        /// </summary>
        /// <param name="wStreamNumber">
        /// The stream number for which to obtain statistics.
        /// </param>
        /// <param name="pMuxStats">
        /// Pointer to an <see cref="ASFMuxStatistics"/> structure that receives the statistics. 
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT GetStatistics(
        ///   [in]   WORD wStreamNumber,
        ///   [out]  ASF_MUX_STATISTICS *pMuxStats
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/56083CEB-3D39-4FDA-995A-F91FA0E16853(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/56083CEB-3D39-4FDA-995A-F91FA0E16853(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStatistics(
            [In] short wStreamNumber,
            out ASFMuxStatistics pMuxStats);

        /// <summary>
        /// Sets the maximum time by which samples from various streams can be out of synchronization. The
        /// multiplexer will not accept a sample with a time stamp that is out of synchronization with the
        /// latest samples from any other stream by an amount that exceeds the synchronization tolerance.
        /// </summary>
        /// <param name="msSyncTolerance">
        /// Synchronization tolerance in milliseconds.
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
        /// <strong>C/C++ Syntax</strong>
        /// <code>
        /// HRESULT SetSyncTolerance(
        ///   [in]  DWORD msSyncTolerance
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/54AEA995-2BEB-4C38-A79F-43A539031D95(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/54AEA995-2BEB-4C38-A79F-43A539031D95(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetSyncTolerance(
            [In] int msSyncTolerance);
    }

#endif

}
