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

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.Transform;
using System.Drawing;

namespace MediaFoundation.EVR
{


    /// <summary>
    /// Represents a video presenter. A <em>video presenter</em> is an object that receives video frames,
    /// typically from a video mixer, and presents them in some way, typically by rendering them to the
    /// display. The enhanced video renderer (EVR) provides a default video presenter, and applications can
    /// implement custom presenters. 
    /// <para/>
    /// The video presenter receives video frames as soon as they are available from upstream. The video
    /// presenter is responsible for presenting frames at the correct time and for synchronizing with the
    /// presentation clock.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8F6E3132-03E9-4A2E-9160-E39D29CF2408(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8F6E3132-03E9-4A2E-9160-E39D29CF2408(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("29AFF080-182A-4A5D-AF3B-448F3A6346CB")]
    public interface IMFVideoPresenter : IMFClockStateSink
    {
        #region IMFClockStateSink

        /// <summary>
        /// Called when the presentation clock starts. 
        /// </summary>
        /// <param name="hnsSystemTime">The system time when the clock started, in 100-nanosecond units.</param>
        /// <param name="llClockStartOffset">The new starting time for the clock, in 100-nanosecond units. This parameter can also equal
        /// <strong>PRESENTATION_CURRENT_POSITION</strong>, indicating the clock has started or restarted from
        /// its current position.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnClockStart(
        /// [in]  MFTIME hnsSystemTime,
        /// [in]  LONGLONG llClockStartOffset
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/1A696FFC-B8E6-4EF9-B980-35BFBD3D4128(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1A696FFC-B8E6-4EF9-B980-35BFBD3D4128(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int OnClockStart(
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
        /// [in]  MFTIME hnssSystemTime
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/472B704F-D402-4E0B-96B8-FEA267E8FF63(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/472B704F-D402-4E0B-96B8-FEA267E8FF63(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int OnClockStop(
            [In] long hnsSystemTime
            );

        /// <summary>
        /// Called when the presentation clock pauses. 
        /// </summary>
        /// <param name="hnsSystemTime">The system time when the clock was paused, in 100-nanosecond units.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnClockPause(
        /// [in]  MFTIME hnsSystemTime
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/D4EB1DDF-2EEA-48E2-946A-4EA20BE8CC8F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D4EB1DDF-2EEA-48E2-946A-4EA20BE8CC8F(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int OnClockPause(
            [In] long hnsSystemTime
            );

        /// <summary>
        /// Called when the presentation clock restarts from the same position while paused. 
        /// </summary>
        /// <param name="hnsSystemTime">The system time when the clock restarted, in 100-nanosecond units.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnClockRestart(
        /// [in]  MFTIME hnsSystemTime
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/55973DFA-59B9-4105-9706-5D5497AD2818(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/55973DFA-59B9-4105-9706-5D5497AD2818(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int OnClockRestart(
            [In] long hnsSystemTime
            );

        /// <summary>
        /// Called when the rate changes on the presentation clock. 
        /// </summary>
        /// <param name="hnsSystemTime">The system time when the rate was set, in 100-nanosecond units.</param>
        /// <param name="flRate">The new rate, as a multiplier of the normal playback rate.</param>
        /// <returns>
        /// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        /// </strong> error code. 
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT OnClockSetRate(
        /// [in]  MFTIME hnsSystemTime,
        /// [in]  float flRate
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/BA8AFDF9-13EB-4E3D-B8A7-C74E0B40E998(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA8AFDF9-13EB-4E3D-B8A7-C74E0B40E998(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int OnClockSetRate(
            [In] long hnsSystemTime,
            [In] float flRate
            );

        #endregion

        /// <summary>
        /// Sends a message to the video presenter. Messages are used to signal the presenter that it must
        /// perform some action, or that some event has occurred.
        /// </summary>
        /// <param name="eMessage">
        /// Specifies the message as a member of the <see cref="EVR.MFVPMessageType"/> enumeration. 
        /// </param>
        /// <param name="ulParam">
        /// Message parameter. The meaning of this parameter depends on the message type.
        /// </param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ProcessMessage(
        ///   [in]  MFVP_MESSAGE_TYPE eMessage,
        ///   [in]  ULONG_PTR ulParam
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F7113CB3-2EA9-4D4F-B6C7-EF4E1025CC6D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F7113CB3-2EA9-4D4F-B6C7-EF4E1025CC6D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ProcessMessage(
            MFVPMessageType eMessage,
            IntPtr ulParam
            );

        /// <summary>
        /// Retrieves the presenter's media type.
        /// </summary>
        /// <param name="ppMediaType">
        /// Receives a pointer to the <see cref="IMFVideoMediaType"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>The media type is not set.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The video renderer has been shut down</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCurrentMediaType(
        ///   [out]  IMFVideoMediaType **ppMediaType
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4B8F0E56-35DE-4B4F-9897-32A7E14171C8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4B8F0E56-35DE-4B4F-9897-32A7E14171C8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetCurrentMediaType(
            [MarshalAs(UnmanagedType.Interface)] out IMFVideoMediaType ppMediaType
            );
    }

}
