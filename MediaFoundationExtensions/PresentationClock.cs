using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PresentationClock"/> class implements a wrapper around the
    /// <see cref="IMFPresentationClock"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFPresentationClock"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFPresentationClock"/>: 
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
    public sealed class PresentationClock : Clock<IMFPresentationClock>
    {
        #region Construction

        internal PresentationClock(IMFPresentationClock comInterface)
            : base(comInterface)
        {
        }

        #endregion


        /// <summary>
        /// Gets or sets the time source for the presentation clock. The time source is the object that drives the
        /// clock by providing the current time.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/170B7C8E-9D1A-4168-964A-5FD057D1E8F9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/170B7C8E-9D1A-4168-964A-5FD057D1E8F9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public PresentationTimeSource TimeSource
        {
            get
            {
                IMFPresentationTimeSource pTimeSource;
                int hr = this.Interface.GetTimeSource(out pTimeSource);
                // MF_E_CLOCK_NO_TIME_SOURCE: No time source was set on this clock.
                if (hr == MFError.MF_E_CLOCK_NO_TIME_SOURCE)
                    return null;
                COM.ThrowIfNotOK(hr);
                return pTimeSource.ToPresentationTimeSource();
            }
            set
            {
                int hr = this.Interface.SetTimeSource(value.GetInterface());
                COM.ThrowIfNotOK(hr);
            }
        }
        
        /// <summary>
        /// Retrieves the latest clock time. The time is relative to when the clock was last started. 
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/31037B75-9FA5-48E0-A58C-A451B445147F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/31037B75-9FA5-48E0-A58C-A451B445147F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Time Time
        {
            get
            {
                long phnsClockTime; 
                int hr = this.Interface.GetTime(out phnsClockTime);
                COM.ThrowIfNotOK(hr);
                return (Time)phnsClockTime;
            }
        }

        /// <summary>
        /// Registers an object to be notified whenever the clock starts, stops, or pauses, or changes rate.
        /// </summary>
        /// <param name="stateSink">
        /// A <see cref="ClockStateSink"/> object. 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C90C3D26-51FA-4CD6-A154-6F72C21219D2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C90C3D26-51FA-4CD6-A154-6F72C21219D2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void AddClockStateSink(ClockStateSink stateSink)
        {
            int hr = this.Interface.AddClockStateSink(stateSink.GetInterface());
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Unregisters an object that is receiving state-change notifications from the clock.
        /// </summary>
        /// <param name="stateSink">
        /// A <see cref="ClockStateSink"/> object. 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C037183D-A81F-4F49-9E02-06DC2476471F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C037183D-A81F-4F49-9E02-06DC2476471F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void RemoveClockStateSink(ClockStateSink stateSink)
        {
            int hr = this.Interface.RemoveClockStateSink(stateSink.GetInterface());
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Starts the presentation clock.
        /// </summary>
        /// <param name="clockStartOffset">
        /// Initial starting time. At the time the <strong>Start</strong> method is
        /// called, the clock's <see cref="PresentationClock.Time"/> method returns this value, and the
        /// clock time increments from there. 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BA5986D1-9C94-4747-A221-43D0583F1FED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA5986D1-9C94-4747-A221-43D0583F1FED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Start(Time clockStartOffset)
        {
            int hr = this.Interface.Start(clockStartOffset.Value);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Starts the presentation clock from its current position. Use this if the clock is paused 
        /// and you want to restart it from the same position. 
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BA5986D1-9C94-4747-A221-43D0583F1FED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA5986D1-9C94-4747-A221-43D0583F1FED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Start()
        {
            int hr = this.Interface.Start(PresentationClock.PRESENTATION_CURRENT_POSITION);
            COM.ThrowIfNotOK(hr);
        }

        private const long PRESENTATION_CURRENT_POSITION = 0x7fffffffffffffffL;

        /// <summary>
        /// Stops the presentation clock. While the clock is stopped, the clock time does not advance, and the
        /// clock's <see cref="PresentationClock.Time"/> method returns zero. 
        /// </summary>
        /// <returns>
        /// True of the clock was stopped or false if the clock was already stopped.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/54377D65-2AF7-410D-B8CF-45F467527A45(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/54377D65-2AF7-410D-B8CF-45F467527A45(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool Stop()
        {
            int hr = this.Interface.Stop();
            // MF_E_CLOCK_STATE_ALREADY_SET: The clock is already stopped.
            if (hr == MFError.MF_E_CLOCK_STATE_ALREADY_SET)
                return false;
            COM.ThrowIfNotOK(hr);
            return true;
        }

        /// <summary>
        /// Pauses the presentation clock. While the clock is paused, the clock time does not advance, and the
        /// clock's <see cref="PresentationClock.Time"/> returns the time at which the clock was paused. 
        /// </summary>
        /// <returns>
        /// True of the clock was paused or false if the clock was already paused or stopped.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2EDDC9A9-E3A6-46C4-83C6-446B6A7A64B0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2EDDC9A9-E3A6-46C4-83C6-446B6A7A64B0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool Pause()
        {
            int hr = this.Interface.Pause();
            // MF_E_CLOCK_STATE_ALREADY_SET: The clock is already stopped.
            if (hr == MFError.MF_E_CLOCK_STATE_ALREADY_SET)
                return false;
            // MF_E_INVALIDREQUEST: The clock is stopped. This request is not valid when the clock is stopped.
            if (hr == MFError.MF_E_INVALIDREQUEST)
                return false;
            COM.ThrowIfNotOK(hr);
            return true;
        }

    }
}
