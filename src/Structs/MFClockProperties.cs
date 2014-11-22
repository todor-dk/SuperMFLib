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


    /// <summary>
    /// Defines the properties of a clock.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MFCLOCK_PROPERTIES {
    ///   unsigned __int64 qwCorrelationRate;
    ///   GUID             guidClockId;
    ///   DWORD            dwClockFlags;
    ///   unsigned __int64 qwClockFrequency;
    ///   DWORD            dwClockTolerance;
    ///   DWORD            dwClockJitter;
    /// } MFCLOCK_PROPERTIES;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1EFC6602-9851-40E5-85AA-0335D4E899A2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1EFC6602-9851-40E5-85AA-0335D4E899A2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 8), UnmanagedName("MFCLOCK_PROPERTIES")]
    public struct MFClockProperties
    {
        /// <summary>
        /// The interval at which the clock correlates its clock time with the system time, in 100-nanosecond
        /// units. If the value is zero, the correlation is made whenever the
        /// <see cref="IMFClock.GetCorrelatedTime" /> method is called.
        /// </summary>
        public long qwCorrelationRate;
        /// <summary>
        /// The unique identifier of the underlying device that provides the time. If two clocks have the same
        /// unique identifier, they are based on the same device. If the underlying device is not shared
        /// between two clocks, the value can be <strong>GUID_NULL</strong>.
        /// </summary>
        public Guid guidClockId;
        /// <summary>
        /// A bitwise <strong>OR</strong> of flags from the <see cref="MFClockRelationalFlags" /> enumeration.
        /// </summary>
        public MFClockRelationalFlags dwClockFlags;
        /// <summary>
        /// The clock frequency in Hz. A value of <strong>MFCLOCK_FREQUENCY_HNS</strong> means that the clock
        /// has a frequency of 10 MHz (100-nanosecond ticks), which is the standard <c>MFTIME</c> time unit in
        /// Media Foundation. If the <see cref="IMFClock.GetClockCharacteristics" /> method returns the <strong>
        /// MFCLOCK_CHARACTERISTICS_FLAG_FREQUENCY_10MHZ</strong> flag, the value of this field must be
        /// <strong>MFCLOCK_FREQUENCY_HNS</strong>.
        /// </summary>
        public long qwClockFrequency;
        /// <summary>
        /// The amount of inaccuracy that may be present on the clock, in parts per billion (ppb). For example,
        /// an inaccuracy of 50 ppb means the clock might drift up to 50 seconds per billion seconds of real
        /// time. If the tolerance is not known, the value is <strong>MFCLOCK_TOLERANCE_UNKNOWN</strong>. This
        /// constant is equal to 50 parts per million (ppm).
        /// </summary>
        public int dwClockTolerance;
        /// <summary>
        /// The amount of jitter that may be present, in 100-nanosecond units. Jitter is the variation in the
        /// frequency due to sampling the underlying clock. Jitter does not include inaccuracies caused by
        /// drift, which is reflected in the value of <strong>dwClockTolerance</strong>.
        /// <para />
        /// For clocks based on a single device, the minimum jitter is the length of the tick period (the
        /// inverse of the frequency). For example, if the frequency is 10 Hz, the jitter is 0.1 second, which
        /// is 1,000,000 in <c>MFTIME</c> units. This value reflects the fact that the clock might be sampled
        /// just before the next tick, resulting in a clock time that is one period less than the actual time.
        /// If the frequency is greater than 10 MHz, the jitter should be set to 1 (the minimum value).
        /// <para />
        /// If a clock's underlying hardware device does not directly time stamp the incoming data, the jitter
        /// also includes the time required to dispatch the driver's interrupt service routine (ISR). In that
        /// case, the expected jitter should include the following values:
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term><strong>MFCLOCK_JITTER_ISR</strong></term><description> Jitter due to time stamping during the device driver's ISR. </description></item><item><term><strong>MFCLOCK_JITTER_DPC</strong></term><description> Jitter due to time stamping during the deferred procedure call (DPC) processing. </description></item><item><term><strong>MFCLOCK_JITTER_PASSIVE</strong></term><description> Jitter due to dropping to normal thread execution before time stamping. </description></item></list>
        /// </summary>
        public int dwClockJitter;
    }
}
