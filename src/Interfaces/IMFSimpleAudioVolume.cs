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

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Controls the master volume level of the audio session associated with the streaming audio renderer
    /// (SAR) and the audio capture source.
    /// <para/>
    /// The SAR and the audio capture source expose this interface as a service. To get a pointer to the
    /// interface, call <see cref="IMFGetService.GetService"/>. For the SAR, use the service identifier
    /// MR_POLICY_VOLUME_SERVICE. For the audio capture source, use the service identifier
    /// MR_CAPTURE_POLICY_VOLUME_SERVICE. You can call <strong>GetService</strong> directly on the SAR or
    /// the audio capture source, or call it on the Media Session. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/002D85A7-8BC3-422E-8CED-1907AC121D7B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/002D85A7-8BC3-422E-8CED-1907AC121D7B(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("089EDF13-CF71-4338-8D13-9E569DBDC319"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFSimpleAudioVolume
    {
        /// <summary>
        /// Sets the master volume level.
        /// </summary>
        /// <param name="fLevel">
        /// Volume level. Volume is expressed as an attenuation level, where 0.0 indicates silence and 1.0
        /// indicates full volume (no attenuation).
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>The audio renderer is not initialized.</description></item>
        /// <item><term><strong>MF_E_STREAMSINK_REMOVED</strong></term><description>The audio renderer was removed from the pipeline.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetMasterVolume(
        ///   [in]  float fLevel
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/42B51817-3C2A-463A-A533-19C327C57354(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/42B51817-3C2A-463A-A533-19C327C57354(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetMasterVolume(
            [In] float fLevel
            );

        /// <summary>
        /// Retrieves the master volume level.
        /// </summary>
        /// <param name="pfLevel">
        /// Receives the volume level. Volume is expressed as an attenuation level, where 0.0 indicates silence
        /// and 1.0 indicates full volume (no attenuation).
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>The audio renderer is not initialized.</description></item>
        /// <item><term><strong>MF_E_STREAMSINK_REMOVED</strong></term><description>The audio renderer was removed from the pipeline.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetMasterVolume(
        ///   [out]  float *pfLevel
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/03CE097E-C4E5-4DAC-84C0-B569EFC420BC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/03CE097E-C4E5-4DAC-84C0-B569EFC420BC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMasterVolume(
            out float pfLevel
            );

        /// <summary>
        /// Mutes or unmutes the audio.
        /// </summary>
        /// <param name="bMute">
        /// Specify <strong>TRUE</strong> to mute the audio, or <strong>FALSE</strong> to unmute the audio. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>The audio renderer is not initialized.</description></item>
        /// <item><term><strong>MF_E_STREAMSINK_REMOVED</strong></term><description>The audio renderer was removed from the pipeline.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetMute(
        ///   [in]  const BOOL bMute
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D8840D15-D4D5-481E-9002-54FDBF323C9C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D8840D15-D4D5-481E-9002-54FDBF323C9C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetMute(
            [In, MarshalAs(UnmanagedType.Bool)] bool bMute
            );

        /// <summary>
        /// Queries whether the audio is muted.
        /// </summary>
        /// <param name="pbMute">
        /// Receives a Boolean value. If <strong>TRUE</strong>, the audio is muted; otherwise, the audio is not
        /// muted. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>The audio renderer is not initialized.</description></item>
        /// <item><term><strong>MF_E_STREAMSINK_REMOVED</strong></term><description>The audio renderer was removed from the pipeline.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetMute(
        ///   [out]  BOOL *pbMute
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/13907D3C-62C0-4CB8-8921-5A38A63D7D6E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/13907D3C-62C0-4CB8-8921-5A38A63D7D6E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMute(
            [MarshalAs(UnmanagedType.Bool)] out bool pbMute
            );
    }

#endif

}
