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
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation.Core.Interfaces
{
    /// <summary>
    /// Controls the volume levels of individual audio channels.
    /// <para/>
    /// The streaming audio renderer (SAR) exposes this interface as a service. To get a pointer to the
    /// interface, call <see cref="IMFGetService.GetService"/> with the service identifier <strong>
    /// MR_STREAM_VOLUME_SERVICE</strong>. You can call <strong>GetService</strong> directly on the SAR or
    /// call it on the Media Session.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/F06ED262-A2EC-4688-B477-877D04CF1892(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F06ED262-A2EC-4688-B477-877D04CF1892(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport]
    [System.Security.SuppressUnmanagedCodeSecurity]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("76B1BBDB-4EC8-4F36-B106-70A9316DF593")]
    public interface IMFAudioStreamVolume
    {
        /// <summary>
        /// Retrieves the number of channels in the audio stream.
        /// </summary>
        /// <param name="pdwCount">
        /// Receives the number of channels in the audio stream.
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
        /// HRESULT GetChannelCount(
        ///   [out]  UINT32 *pdwCount
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/D19A56DB-CD5F-4A19-98F0-42327C259B01(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D19A56DB-CD5F-4A19-98F0-42327C259B01(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetChannelCount(
            out int pdwCount);

        /// <summary>
        /// Sets the volume level for a specified channel in the audio stream.
        /// </summary>
        /// <param name="dwIndex">
        /// Zero-based index of the audio channel. To get the number of channels, call
        /// <see cref="IMFAudioStreamVolume.GetChannelCount"/>.
        /// </param>
        /// <param name="fLevel">
        /// Volume level for the channel.
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
        /// HRESULT SetChannelVolume(
        ///   [in]  UINT32 dwIndex,
        ///   [in]  const float fLevel
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/7786A6AA-C777-4B65-B38C-A75CD654A080(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7786A6AA-C777-4B65-B38C-A75CD654A080(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetChannelVolume(
            [In] int dwIndex,
            [In] float fLevel);

        /// <summary>
        /// Retrieves the volume level for a specified channel in the audio stream.
        /// </summary>
        /// <param name="dwIndex">
        /// Zero-based index of the audio channel. To get the number of channels, call
        /// <see cref="IMFAudioStreamVolume.GetChannelCount"/>.
        /// </param>
        /// <param name="pfLevel">
        /// Receives the volume level for the channel.
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
        /// HRESULT GetChannelVolume(
        ///   [in]   UINT32 dwIndex,
        ///   [out]  float *pfLevel
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/5CFCC3A8-2911-45A3-8322-BF4E3B023DD2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5CFCC3A8-2911-45A3-8322-BF4E3B023DD2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetChannelVolume(
            [In] int dwIndex,
            out float pfLevel);

        /// <summary>
        /// Sets the individual volume levels for all of the channels in the audio stream.
        /// </summary>
        /// <param name="dwCount">
        /// Number of elements in the <em>pfVolumes</em> array. The value must equal the number of channels. To
        /// get the number of channels, call <see cref="IMFAudioStreamVolume.GetChannelCount"/>.
        /// </param>
        /// <param name="pfVolumes">
        /// Address of an array of size <em>dwCount</em>, allocated by the caller. The array specifies the
        /// volume levels for all of the channels. Before calling the method, set each element of the array to
        /// the desired volume level for the channel.
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
        /// HRESULT SetAllVolumes(
        ///   [in]  UINT32 dwCount,
        ///   [in]  const float *pfVolumes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/6C278693-5A2F-4AA2-B477-3B3014B2CC89(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6C278693-5A2F-4AA2-B477-3B3014B2CC89(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetAllVolumes(
            [In] int dwCount,
            [In] float[] pfVolumes);

        /// <summary>
        /// Retrieves the volume levels for all of the channels in the audio stream.
        /// </summary>
        /// <param name="dwCount">
        /// Number of elements in the <em>pfVolumes</em> array. The value must equal the number of channels. To
        /// get the number of channels, call <see cref="IMFAudioStreamVolume.GetChannelCount"/>.
        /// </param>
        /// <param name="pfVolumes">
        /// Address of an array of size <em>dwCount</em>, allocated by the caller. The method fills the array
        /// with the volume level for each channel in the stream.
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
        /// HRESULT GetAllVolumes(
        ///   [in]   UINT32 dwCount,
        ///   [out]  float *pfVolumes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/CBCC0B5B-A60D-49CA-8B1C-7104E039A7D2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CBCC0B5B-A60D-49CA-8B1C-7104E039A7D2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetAllVolumes(
            [In] int dwCount,
            [Out] float[] pfVolumes);
    }
}
