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
#if NOT_IN_USE

    /// <summary>
    /// Receives state-change notifications from the presentation clock. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9AA0D2CD-A687-4B3A-834D-CCC8D3A03196(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9AA0D2CD-A687-4B3A-834D-CCC8D3A03196(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("F6696E82-74F7-4F3D-A178-8A5E09C3659F")]
    internal interface IMFClockStateSink
    {
        /// <summary>
        /// Called when the presentation clock starts. 
        /// </summary>
        /// <param name="hnsSystemTime">
        /// The system time when the clock started, in 100-nanosecond units. 
        /// </param>
        /// <param name="llClockStartOffset">
        /// The new starting time for the clock, in 100-nanosecond units. This parameter can also equal 
        /// <strong>PRESENTATION_CURRENT_POSITION</strong>, indicating the clock has started or restarted from
        /// its current position. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnClockStart(
        ///   [in]  MFTIME hnsSystemTime,
        ///   [in]  LONGLONG llClockStartOffset
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1A696FFC-B8E6-4EF9-B980-35BFBD3D4128(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1A696FFC-B8E6-4EF9-B980-35BFBD3D4128(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnClockStart(
            [In] long hnsSystemTime,
            [In] long llClockStartOffset
            );

        /// <summary>
        /// Called when the presentation clock stops. 
        /// </summary>
        /// <param name="hnsSystemTime">The HNS system time.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_SINK_ALREADYSTOPPED</strong></term><description>Deprecated. Do not use this error code.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnClockStop(
        ///   [in]  MFTIME hnssSystemTime
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/472B704F-D402-4E0B-96B8-FEA267E8FF63(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/472B704F-D402-4E0B-96B8-FEA267E8FF63(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnClockStop(
            [In] long hnsSystemTime
            );

        /// <summary>
        /// Called when the presentation clock pauses. 
        /// </summary>
        /// <param name="hnsSystemTime">
        /// The system time when the clock was paused, in 100-nanosecond units. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnClockPause(
        ///   [in]  MFTIME hnsSystemTime
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D4EB1DDF-2EEA-48E2-946A-4EA20BE8CC8F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D4EB1DDF-2EEA-48E2-946A-4EA20BE8CC8F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnClockPause(
            [In] long hnsSystemTime
            );

        /// <summary>
        /// Called when the presentation clock restarts from the same position while paused. 
        /// </summary>
        /// <param name="hnsSystemTime">
        /// The system time when the clock restarted, in 100-nanosecond units. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnClockRestart(
        ///   [in]  MFTIME hnsSystemTime
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/55973DFA-59B9-4105-9706-5D5497AD2818(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/55973DFA-59B9-4105-9706-5D5497AD2818(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnClockRestart(
            [In] long hnsSystemTime
            );

        /// <summary>
        /// Called when the rate changes on the presentation clock. 
        /// </summary>
        /// <param name="hnsSystemTime">
        /// The system time when the rate was set, in 100-nanosecond units. 
        /// </param>
        /// <param name="flRate">
        /// The new rate, as a multiplier of the normal playback rate. 
        /// </param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnClockSetRate(
        ///   [in]  MFTIME hnsSystemTime,
        ///   [in]  float flRate
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BA8AFDF9-13EB-4E3D-B8A7-C74E0B40E998(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA8AFDF9-13EB-4E3D-B8A7-C74E0B40E998(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int OnClockSetRate(
            [In] long hnsSystemTime,
            [In] float flRate
            );
    }

#endif
}
