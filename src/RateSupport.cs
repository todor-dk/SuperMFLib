using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Core.Enums;
using MediaFoundation.Misc.Classes;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="RateSupport"/> class implements a wrapper around the
    /// <see cref="IMFRateSupport"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFRateSupport"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFRateSupport"/>: 
    /// Queries the range of playback rates that are supported, including reverse playback.
    /// <para/>
    /// To get a pointer to this interface, call <see cref="IMFGetService.GetService"/> with the service
    /// identifier MF_RATE_CONTROL_SERVICE. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A6C495FA-0F6A-4E4C-8FBA-996B22D55053(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A6C495FA-0F6A-4E4C-8FBA-996B22D55053(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class RateSupport : COM<IMFRateSupport>
    {
        #region Construction

        internal RateSupport(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="RateSupport"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the RateSupport's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="RateSupport"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static RateSupport FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            RateSupport result = new RateSupport(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Returns the <see cref="RateSupport"/> from the given <paramref name="service"/> (a Media Session).
        /// </summary>
        /// <param name="service">The service to retrieve the <see cref="RateSupport"/> from (a Media Session).</param>
        /// <returns>A <see cref="RateSupport"/> for the given <paramref name="service"/>.</returns>
        public static RateSupport FromService(GetService service)
        {
            Contract.RequiresNotNull(service, "service");
            return service.Get(MFService.MF_RATE_CONTROL_SERVICE, RateSupport.FromUnknown);
        }

        /// <summary>
        /// Returns the <see cref="RateSupport"/> from the given <paramref name="session"/>.
        /// </summary>
        /// <param name="session">Media Session to retrieve the <see cref="RateSupport"/> from.</param>
        /// <returns>A <see cref="RateSupport"/> for the given <paramref name="session"/>.</returns>
        public static RateSupport FromMediaSession(MediaSession session)
        {
            Contract.RequiresNotNull(session, "session");
            return session.GetService(MFService.MF_RATE_CONTROL_SERVICE, RateSupport.FromUnknown);
        }

        /// <summary>
        /// Retrieves the slowest playback rate supported by the object.
        /// </summary>
        /// <param name="direction">
        /// Specifies whether to query to the slowest forward playback rate or reverse playback rate. The value
        /// is a member of the <see cref="MFRateDirection"/> enumeration. 
        /// </param>
        /// <param name="thinned">
        /// If <strong>true</strong>, the method retrieves the slowest thinned playback rate. Otherwise, the
        /// method retrieves the slowest non-thinned playback rate. For information about thinning, see 
        /// <c>About Rate Control</c>. 
        /// </param>
        /// <returns>
        /// The slowest playback rate that the object supports or 
        /// null if the object does not support reverse playback or thinning.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E10125E9-8BC7-4FB6-8A10-BA5717F1596F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E10125E9-8BC7-4FB6-8A10-BA5717F1596F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public float? GetSlowestRate(MFRateDirection direction, bool thinned)
        {
            float pflRate;
            int hr = this.Interface.GetSlowestRate(direction, thinned, out pflRate);
            // MF_E_REVERSE_UNSUPPORTED: The object does not support reverse playback.
            if (hr == MFError.MF_E_REVERSE_UNSUPPORTED)
                return null;
            // MF_E_THINNING_UNSUPPORTED: The object does not support thinning.
            if (hr == MFError.MF_E_THINNING_UNSUPPORTED)
                return null;
            COM.ThrowIfNotOK(hr);
            return pflRate;
        }

        /// <summary>
        /// Gets the fastest playback rate supported by the object.
        /// </summary>
        /// <param name="direction">
        /// Specifies whether to query to the fastest forward playback rate or reverse playback rate. The value
        /// is a member of the <see cref="MFRateDirection"/> enumeration. 
        /// </param>
        /// <param name="thinned">
        /// If <strong>true</strong>, the method retrieves the fastest thinned playback rate. Otherwise, the
        /// method retrieves the fastest non-thinned playback rate. For information about thinning, see 
        /// <c>About Rate Control</c>. 
        /// </param>
        /// <returns>
        /// The fastest playback rate that the object supports or 
        /// null if the object does not support reverse playback or thinning.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/00413771-21CB-48A7-9080-2C3D195C366B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/00413771-21CB-48A7-9080-2C3D195C366B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public float? GetFastestRate(MFRateDirection direction, bool thinned)
        {
            float pflRate;
            int hr = this.Interface.GetFastestRate(direction, thinned, out pflRate);
            // MF_E_REVERSE_UNSUPPORTED: The object does not support reverse playback.
            if (hr == MFError.MF_E_REVERSE_UNSUPPORTED)
                return null;
            // MF_E_THINNING_UNSUPPORTED: The object does not support thinning.
            if (hr == MFError.MF_E_THINNING_UNSUPPORTED)
                return null;
            COM.ThrowIfNotOK(hr);
            return pflRate;
        }

        /// <summary>
        /// Queries whether the object supports a specified playback rate.
        /// </summary>
        /// <param name="thinned">
        /// If <strong>true</strong>, the method queries whether the object supports the playback rate with
        /// thinning. Otherwise, the method queries whether the object supports the playback rate without
        /// thinning. For information about thinning, see <c>About Rate Control</c>. 
        /// </param>
        /// <param name="rate">
        /// The playback rate to query.
        /// </param>
        /// <param name="nearestSupportedRate">
        /// If the object does not support the playback rate given in <paramref name="rate"/>, this parameter receives
        /// the closest supported playback rate. If the method returns <strong>true</strong>, this parameter receives the value
        /// given in <paramref name="rate"/>. 
        /// </param>
        /// <returns>
        /// True if object supports the specified rate, otherwise false.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3AC04683-17D3-4D87-B260-39B04EAB9E59(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3AC04683-17D3-4D87-B260-39B04EAB9E59(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Support IsRateSupported(bool thinned, float rate, out float nearestSupportedRate)
        {
            float pflNearestSupportedRate = rate;
            int hr = this.Interface.IsRateSupported(thinned, rate, pflNearestSupportedRate);
            // MF_E_UNSUPPORTED_RATE: The object does not support the specified rate.
            if (hr == MFError.MF_E_UNSUPPORTED_RATE)
            {
                nearestSupportedRate = pflNearestSupportedRate;
                return Support.Unsupported;
            }
            // MF_E_REVERSE_UNSUPPORTED: The object does not support reverse playback.
            if (hr == MFError.MF_E_REVERSE_UNSUPPORTED)
            {
                nearestSupportedRate = pflNearestSupportedRate;
                return Support.ReverseUnsupported;
            }
            // MF_E_THINNING_UNSUPPORTED: The object does not support thinning.
            if (hr == MFError.MF_E_THINNING_UNSUPPORTED)
            {
                nearestSupportedRate = pflNearestSupportedRate;
                return Support.ThinningUnsupported;
            }
            COM.ThrowIfNotOK(hr);
            nearestSupportedRate = pflNearestSupportedRate;
            return Support.Supported;
        }

        /// <summary>
        /// Queries whether the object supports a specified playback rate.
        /// </summary>
        /// <param name="thinned">
        /// If <strong>true</strong>, the method queries whether the object supports the playback rate with
        /// thinning. Otherwise, the method queries whether the object supports the playback rate without
        /// thinning. For information about thinning, see <c>About Rate Control</c>. 
        /// </param>
        /// <param name="rate">
        /// The playback rate to query.
        /// </param>
        /// <returns>
        /// True if object supports the specified rate, otherwise false.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3AC04683-17D3-4D87-B260-39B04EAB9E59(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3AC04683-17D3-4D87-B260-39B04EAB9E59(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Support IsRateSupported(bool thinned, float rate)
        {
            float na;
            return this.IsRateSupported(thinned, rate, out na);
        }

        /// <summary>
        /// Enumeration determining of a playback rate is supported or unsupported (and why it's unsupported).
        /// </summary>
        public enum Support
        {
            /// <summary>
            /// The rate is supported.
            /// </summary>
            Supported,
            /// <summary>
            /// The rate is unsupported.
            /// </summary>
            Unsupported,
            /// <summary>
            /// The object does not support reverse playback.
            /// </summary>
            ReverseUnsupported,
            /// <summary>
            /// The object does not support thinning.
            /// </summary>
            ThinningUnsupported,
        }
    }
}
