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
    /// Represents a presentation clock, which is used to schedule when samples are rendered and to
    /// synchronize multiple streams.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/979C4F77-CBEE-468C-8F6B-E68442D89025(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/979C4F77-CBEE-468C-8F6B-E68442D89025(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport]
    [System.Security.SuppressUnmanagedCodeSecurity]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("868CE85C-8EA9-4F55-AB82-B009A910A805")]
    public interface IMFPresentationClock : IMFClock
    {
    #region IMFClock methods

        /// <summary>
        /// Retrieves the characteristics of the clock.
        /// </summary>
        /// <param name="pdwCharacteristics">Receives a bitwise OR of values from the <see cref="MFClockCharacteristicsFlags" /> enumeration
        /// indicating the characteristics of the clock.</param>
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
        /// HRESULT GetClockCharacteristics(
        /// [out]  DWORD *pdwCharacteristics
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/50A81E8B-9AA8-484C-AFB7-950068FEEFC4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/50A81E8B-9AA8-484C-AFB7-950068FEEFC4(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetClockCharacteristics(
            out MFClockCharacteristicsFlags pdwCharacteristics);

        /// <summary>
        /// Retrieves the last clock time that was correlated with system time.
        /// </summary>
        /// <param name="dwReserved">Reserved, must be zero.</param>
        /// <param name="pllClockTime">Receives the last known clock time, in units of the clock's frequency.</param>
        /// <param name="phnsSystemTime">Receives the system time that corresponds to the clock time returned in <em>pllClockTime</em>, in
        /// 100-nanosecond units.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_CLOCK_NO_TIME_SOURCE</strong></term><description> The clock does not have a time source. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCorrelatedTime(
        /// [in]   DWORD dwReserved,
        /// [out]  LONGLONG *pllClockTime,
        /// [out]  MFTIME *phnsSystemTime
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/0A897426-D994-4B27-9F13-9B0C7C9B3A9B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0A897426-D994-4B27-9F13-9B0C7C9B3A9B(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetCorrelatedTime(
            [In] int dwReserved,
            out long pllClockTime,
            out long phnsSystemTime);

        /// <summary>
        /// Retrieves the clock's continuity key. (Not supported.)
        /// </summary>
        /// <param name="pdwContinuityKey">Receives the continuity key.</param>
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
        /// HRESULT GetContinuityKey(
        /// [out]  DWORD *pdwContinuityKey
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/8AFDA8C7-BAB6-40FD-B20C-6BB29ED4900F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8AFDA8C7-BAB6-40FD-B20C-6BB29ED4900F(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetContinuityKey(
            out int pdwContinuityKey);

        /// <summary>
        /// Retrieves the current state of the clock.
        /// </summary>
        /// <param name="dwReserved">Reserved, must be zero.</param>
        /// <param name="peClockState">Receives the clock state, as a member of the <see cref="MFClockState" /> enumeration.</param>
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
        /// HRESULT GetState(
        /// [in]   DWORD dwReserved,
        /// [out]  MFCLOCK_STATE *peClockState
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/8E2DDA03-F589-4572-B715-2BE7B29A6ACE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8E2DDA03-F589-4572-B715-2BE7B29A6ACE(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetState(
            [In] int dwReserved,
            out MFClockState peClockState);

        /// <summary>
        /// Retrieves the properties of the clock.
        /// </summary>
        /// <param name="pClockProperties">Pointer to an <see cref="MFClockProperties" /> structure that receives the properties.</param>
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
        /// HRESULT GetProperties(
        /// [out]  MFCLOCK_PROPERTIES *pClockProperties
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/9DFC0EFC-D274-45A6-B1AB-30F6215FBED8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9DFC0EFC-D274-45A6-B1AB-30F6215FBED8(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetProperties(
            out MFClockProperties pClockProperties);

        #endregion

        /// <summary>
        /// Sets the time source for the presentation clock. The time source is the object that drives the
        /// clock by providing the current time.
        /// </summary>
        /// <param name="pTimeSource">
        /// Pointer to the <see cref="IMFPresentationTimeSource"/> interface of the time source.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_CLOCK_NOT_SIMPLE</strong></term><description>The time source does not have a frequency of 10 MHz.</description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>The time source has not been initialized.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetTimeSource(
        ///   [in]  IMFPresentationTimeSource *pTimeSource
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/170B7C8E-9D1A-4168-964A-5FD057D1E8F9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/170B7C8E-9D1A-4168-964A-5FD057D1E8F9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetTimeSource(
            [In, MarshalAs(UnmanagedType.Interface)] IMFPresentationTimeSource pTimeSource);

        /// <summary>
        /// Retrieves the clock's presentation time source.
        /// </summary>
        /// <param name="ppTimeSource">
        /// Receives a pointer to the time source's <see cref="IMFPresentationTimeSource"/> interface. The
        /// caller must release the interface.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_CLOCK_NO_TIME_SOURCE</strong></term><description>No time source was set on this clock.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetTimeSource(
        ///   [out]  IMFPresentationTimeSource **ppTimeSource
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/E6B6851B-F5B3-40C2-9160-59F2A68C9131(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E6B6851B-F5B3-40C2-9160-59F2A68C9131(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetTimeSource(
            /* [MarshalAs(UnmanagedType.Interface)] out IMFPresentationTimeSource */ out IntPtr ppTimeSource);

        /// <summary>
        /// Retrieves the latest clock time.
        /// </summary>
        /// <param name="phnsClockTime">
        /// Receives the latest clock time, in 100-nanosecond units. The time is relative to when the clock was
        /// last started.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_CLOCK_NO_TIME_SOURCE</strong></term><description> The clock does not have a presentation time source. Call <see cref="IMFPresentationClock.SetTimeSource"/>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetTime(
        ///   [out]  MFTIME *phnsClockTime
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/31037B75-9FA5-48E0-A58C-A451B445147F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/31037B75-9FA5-48E0-A58C-A451B445147F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetTime(
            out long phnsClockTime);

        /// <summary>
        /// Registers an object to be notified whenever the clock starts, stops, or pauses, or changes rate.
        /// </summary>
        /// <param name="pStateSink">
        /// Pointer to the object's <see cref="IMFClockStateSink"/> interface.
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
        /// HRESULT AddClockStateSink(
        ///   [in]  IMFClockStateSink *pStateSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/C90C3D26-51FA-4CD6-A154-6F72C21219D2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C90C3D26-51FA-4CD6-A154-6F72C21219D2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int AddClockStateSink(
            [In, MarshalAs(UnmanagedType.Interface)] IMFClockStateSink pStateSink);

        /// <summary>
        /// Unregisters an object that is receiving state-change notifications from the clock.
        /// </summary>
        /// <param name="pStateSink">
        /// Pointer to the object's <see cref="IMFClockStateSink"/> interface.
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
        /// HRESULT RemoveClockStateSink(
        ///   [in]  IMFClockStateSink *pStateSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/C037183D-A81F-4F49-9E02-06DC2476471F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C037183D-A81F-4F49-9E02-06DC2476471F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int RemoveClockStateSink(
            [In, MarshalAs(UnmanagedType.Interface)] IMFClockStateSink pStateSink);

        /// <summary>
        /// Starts the presentation clock.
        /// </summary>
        /// <param name="llClockStartOffset">
        /// Initial starting time, in 100-nanosecond units. At the time the <strong>Start</strong> method is
        /// called, the clock's <see cref="IMFPresentationClock.GetTime"/> method returns this value, and the
        /// clock time increments from there. If the value is PRESENTATION_CURRENT_POSITION, the clock starts
        /// from its current position. Use this value if the clock is paused and you want to restart it from
        /// the same position.
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_CLOCK_NO_TIME_SOURCE</strong></term><description>No time source was set on this clock.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Start(
        ///   [in]  LONGLONG llClockStartOffset
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/BA5986D1-9C94-4747-A221-43D0583F1FED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA5986D1-9C94-4747-A221-43D0583F1FED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Start(
            [In] long llClockStartOffset);

        /// <summary>
        /// Stops the presentation clock. While the clock is stopped, the clock time does not advance, and the
        /// clock's <see cref="IMFPresentationClock.GetTime"/> method returns zero.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_CLOCK_NO_TIME_SOURCE</strong></term><description>No time source was set on this clock.</description></item>
        /// <item><term><strong>MF_E_CLOCK_STATE_ALREADY_SET</strong></term><description>The clock is already stopped.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Stop();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/54377D65-2AF7-410D-B8CF-45F467527A45(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/54377D65-2AF7-410D-B8CF-45F467527A45(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Stop();

        /// <summary>
        /// Pauses the presentation clock. While the clock is paused, the clock time does not advance, and the
        /// clock's <see cref="IMFPresentationClock.GetTime"/> returns the time at which the clock was paused.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_CLOCK_NO_TIME_SOURCE</strong></term><description>No time source was set on this clock.</description></item>
        /// <item><term><strong>MF_E_CLOCK_STATE_ALREADY_SET</strong></term><description>The clock is already paused.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The clock is stopped. This request is not valid when the clock is stopped.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Pause();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/2EDDC9A9-E3A6-46C4-83C6-446B6A7A64B0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2EDDC9A9-E3A6-46C4-83C6-446B6A7A64B0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Pause();
    }
}
