using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using System.Runtime.InteropServices;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Misc.Classes;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="RateControl"/> class implements a wrapper around the
    /// <see cref="IMFRateControl"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFRateControl"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFRateControl"/>:
    /// Gets or sets the playback rate.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/54303C32-B260-4364-9130-A592694F2816(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/54303C32-B260-4364-9130-A592694F2816(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class RateControl : COM<IMFRateControl>
    {
        #region Construction

        private RateControl(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="RateControl"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the RateControl's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be considered void.
        /// </param>
        /// <returns>
        /// A new <see cref="RateControl"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static RateControl FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            RateControl result = new RateControl(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Returns the <see cref="RateControl"/> from the given <paramref name="service"/> (a Media Session, Media Source or Transform).
        /// </summary>
        /// <param name="service">The service to retrieve the <see cref="RateControl"/> from (a Media Session, Media Source or Transform).</param>
        /// <returns>A <see cref="RateControl"/> for the given <paramref name="service"/>.</returns>
        public static RateControl FromService(GetService service)
        {
            Contract.RequiresNotNull(service, "service");
            return service.Get(MFService.MF_RATE_CONTROL_SERVICE, RateControl.FromUnknown);
        }

        /// <summary>
        /// Returns the <see cref="RateControl"/> from the given <paramref name="session"/>.
        /// </summary>
        /// <param name="session">Media Session to retrieve the <see cref="RateControl"/> from.</param>
        /// <returns>A <see cref="RateControl"/> for the given <paramref name="session"/>.</returns>
        public static RateControl FromMediaSession(MediaSession session)
        {
            Contract.RequiresNotNull(session, "session");
            return session.GetService(MFService.MF_RATE_CONTROL_SERVICE, RateControl.FromUnknown);
        }

        /// <summary>
        /// Sets the playback rate.
        /// </summary>
        /// <param name="thinned">
        /// If <strong>true</strong>, the media streams are thinned. Otherwise, the stream is not thinned. For
        /// media sources and demultiplexers, the object must thin the streams when this parameter is <strong>
        /// true</strong>. For downstream transforms, such as decoders and multiplexers, this parameter is
        /// informative; it notifies the object that the input streams are thinned. For information, see
        /// <c>About Rate Control</c>.
        /// </param>
        /// <param name="rate">
        /// The requested playback rate. Postive values indicate forward playback, negative values indicate
        /// reverse playback, and zero indicates scrubbing (the source delivers a single frame).
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/428D73FA-F284-4861-A41E-04EA7709DB0F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/428D73FA-F284-4861-A41E-04EA7709DB0F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetRate(bool thinned, float rate)
        {
            int hr = this.Interface.SetRate(thinned, rate);
            // MF_E_REVERSE_UNSUPPORTED: The object does not support reverse playback.
            if (hr == MFError.MF_E_REVERSE_UNSUPPORTED)
                throw new MediaFoundationException("The object does not support reverse playback.", hr);
            // MF_E_THINNING_UNSUPPORTED: The object does not support thinning.
            if (hr == MFError.MF_E_THINNING_UNSUPPORTED)
                throw new MediaFoundationException("The object does not support thinning.", hr);
            // MF_E_UNSUPPORTED_RATE: The object does not support the requested playback rate.
            if (hr == MFError.MF_E_UNSUPPORTED_RATE)
                throw new MediaFoundationException("The object does not support the requested playback rate.", hr);
            // MF_E_UNSUPPORTED_RATE_TRANSITION: The object cannot change to the new rate while in the running state.
            if (hr == MFError.MF_E_UNSUPPORTED_RATE_TRANSITION)
                throw new MediaFoundationException("The object cannot change to the new rate while in the running state.", hr);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Gets the current playback rate.
        /// </summary>
        /// <param name="thinned">
        /// Receives the value <strong>true</strong> if the stream is currently being thinned. If the object
        /// does not support thinning, this parameter always receives the value <strong>false</strong>.
        /// </param>
        /// <returns>
        /// The current playback rate.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/FB970D06-0F82-4E35-8E03-68044C7F12CD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FB970D06-0F82-4E35-8E03-68044C7F12CD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public float GetRate(out bool thinned)
        {
            float pflRate;
            thinned = false;
            int hr = this.Interface.GetRate(ref thinned, out pflRate);
            COM.ThrowIfNotOK(hr);
            return pflRate;
        }

        /// <summary>
        /// Gets the current playback rate.
        /// </summary>
        /// <returns>
        /// The current playback rate.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/FB970D06-0F82-4E35-8E03-68044C7F12CD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FB970D06-0F82-4E35-8E03-68044C7F12CD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public float GetRate()
        {
            bool na;
            return this.GetRate(out na);
        }
    }
}
