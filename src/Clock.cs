using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Core.Enums;
using MediaFoundation.Core.Structs;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="Clock"/> class implements a wrapper around the
    /// <see cref="IMFClock"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFClock"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFClock"/>: 
    /// Provides timing information from a clock in Microsoft Media Foundation.
    /// <para/>
    /// Clocks and some media sinks expose this interface through <strong>QueryInterface</strong>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3A60BFEC-8511-4A84-A833-E0C73C593970(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3A60BFEC-8511-4A84-A833-E0C73C593970(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public abstract class Clock<TClock> : COM<TClock>
        where TClock : class, IMFClock
    {
        #region Construction

        /// <summary>
        /// Initializes a new instance of the <see cref="Clock{TClock}"/> class.
        /// </summary>
        /// <param name="comInterface">The COM interface.</param>
        protected Clock(IntPtr unknown)
            : base(unknown)
        {
        }

        #endregion

        /// <summary>
        /// Retrieves the characteristics of the clock.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/50A81E8B-9AA8-484C-AFB7-950068FEEFC4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/50A81E8B-9AA8-484C-AFB7-950068FEEFC4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MFClockCharacteristicsFlags ClockCharacteristics
        {
            get
            {
                MFClockCharacteristicsFlags pdwCharacteristics;
                int hr = this.Interface.GetClockCharacteristics(out pdwCharacteristics);
                COM.ThrowIfNotOK(hr);
                return pdwCharacteristics;
            }
        }

        /// <summary>
        /// Retrieves the last clock time that was correlated with system time. 
        /// </summary>
        /// <returns>
        /// Returns the last clock time that was correlated with system time.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0A897426-D994-4B27-9F13-9B0C7C9B3A9B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0A897426-D994-4B27-9F13-9B0C7C9B3A9B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public CorrelatedTimes CorrelatedTime
        {
            get
            {
                long pllClockTime;
                long phnsSystemTime;
                int hr = this.Interface.GetCorrelatedTime(0, out pllClockTime, out phnsSystemTime);
                COM.ThrowIfNotOK(hr);
                return new CorrelatedTimes(this.TicksToTime(pllClockTime), (Time)phnsSystemTime);
            }
        }


        private Time TicksToTime(long ticks)
        {
            if (this.ClockFrequency == -1)
            {
                if ((this.ClockCharacteristics & MFClockCharacteristicsFlags.Frequency10Mhz) != 0)
                {
                    this.ClockFrequency = 0;
                }
                else
                {
                    long freq = this.ClockProperties.qwClockFrequency;
                    if (freq == MFCLOCK_FREQUENCY_HNS)
                        this.ClockFrequency = 0;
                    else
                        this.ClockFrequency = freq;
                }

            }

            if (this.ClockFrequency == 0)
                return (Time)ticks;
            else
                return (Time)(ticks * Time.OneSecondValue / this.ClockFrequency);
        }

        private long ClockFrequency = -1;

        private const long MFCLOCK_FREQUENCY_HNS = 10000000L;

        /// <summary>
        /// Contains the last clock time that was correlated with system time.
        /// </summary>
        public struct CorrelatedTimes
        {
            /// <summary>
            /// The last known clock time.
            /// </summary>
            public Time ClockTime { get; private set; }

            /// <summary>
            /// The system time that corresponds to the clock time in <see cref="ClockTime"/>.
            /// </summary>
            public Time SystemTime { get; private set; }

            internal CorrelatedTimes(Time clockTime, Time systemTime)
                : this()
            {
                this.ClockTime = clockTime;
                this.SystemTime = systemTime;
            }
        }

        /// <summary>
        /// Retrieves the current state of the clock.
        /// </summary>
        /// <returns>
        /// Returns the current state of the clock.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8E2DDA03-F589-4572-B715-2BE7B29A6ACE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8E2DDA03-F589-4572-B715-2BE7B29A6ACE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MFClockState State
        {
            get
            {
                MFClockState peClockState;
                int hr = this.Interface.GetState(0, out peClockState);
                COM.ThrowIfNotOK(hr);
                return peClockState;
            }
        }

        /// <summary>
        /// Retrieves the properties of the clock.
        /// </summary>
        /// <returns>
        /// The properties of the clock.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9DFC0EFC-D274-45A6-B1AB-30F6215FBED8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9DFC0EFC-D274-45A6-B1AB-30F6215FBED8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MFClockProperties ClockProperties
        {
            get
            {
                MFClockProperties pClockProperties;
                int hr = this.Interface.GetProperties(out pClockProperties);
                COM.ThrowIfNotOK(hr);
                return pClockProperties;
            }
        }
    }

    /// <summary>
    /// The <see cref="Clock"/> class implements a wrapper around the
    /// <see cref="IMFClock"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFClock"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFClock"/>: 
    /// Provides timing information from a clock in Microsoft Media Foundation.
    /// <para/>
    /// Clocks and some media sinks expose this interface through <strong>QueryInterface</strong>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3A60BFEC-8511-4A84-A833-E0C73C593970(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3A60BFEC-8511-4A84-A833-E0C73C593970(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class Clock : Clock<IMFClock>
    {
        #region Construction

        private Clock(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="Clock"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the Clock's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="Clock"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static Clock FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            Clock result = new Clock(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion
    }
}
