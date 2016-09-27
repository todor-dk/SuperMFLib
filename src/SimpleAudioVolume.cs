using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Core.Interfaces;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SimpleAudioVolume"/> class implements a wrapper around the
    /// <see cref="IMFSimpleAudioVolume"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSimpleAudioVolume"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSimpleAudioVolume"/>:
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
    public sealed class SimpleAudioVolume : COM<IMFSimpleAudioVolume>
    {
        #region Construction

        private SimpleAudioVolume(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="SimpleAudioVolume"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the SimpleAudioVolume's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be considered void.
        /// </param>
        /// <returns>
        /// A new <see cref="SimpleAudioVolume"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static SimpleAudioVolume FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            SimpleAudioVolume result = new SimpleAudioVolume(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Returns the <see cref="SimpleAudioVolume"/> from the given <paramref name="service"/>
        /// (either a streaming audio renderer (SAR) or the Media Session).
        /// </summary>
        /// <param name="service">The service to retrieve the <see cref="SimpleAudioVolume"/> from (either a streaming audio renderer (SAR) or the Media Session).</param>
        /// <returns>A <see cref="SimpleAudioVolume"/> for the given <paramref name="service"/>.</returns>
        public static SimpleAudioVolume FromService(GetService service)
        {
            Contract.RequiresNotNull(service, "service");
            return service.Get(MFService.MR_POLICY_VOLUME_SERVICE, SimpleAudioVolume.FromUnknown);
        }

        /// <summary>
        /// Returns the <see cref="SimpleAudioVolume"/> from the given <paramref name="session"/>.
        /// </summary>
        /// <param name="session">Media Session to retrieve the <see cref="SimpleAudioVolume"/> from.</param>
        /// <returns>A <see cref="SimpleAudioVolume"/> for the given <paramref name="session"/>.</returns>
        public static SimpleAudioVolume FromMediaSession(MediaSession session)
        {
            Contract.RequiresNotNull(session, "session");
            return session.GetService(MFService.MR_POLICY_VOLUME_SERVICE, SimpleAudioVolume.FromUnknown);
        }

        /// <summary>
        /// Gets or Sets the master volume level.
        /// <para/>
        /// Volume is expressed as an attenuation level, where 0.0 indicates silence and 1.0
        /// indicates full volume (no attenuation).
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/42B51817-3C2A-463A-A533-19C327C57354(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/42B51817-3C2A-463A-A533-19C327C57354(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public float MasterVolume
        {
            get
            {
                float pfLevel;
                int hr = this.Interface.GetMasterVolume(out pfLevel);
                COM.ThrowIfNotOK(hr);
                return pfLevel;
            }

            set
            {
                int hr = this.Interface.SetMasterVolume(value);
                COM.ThrowIfNotOK(hr);
            }
        }

        /// <summary>
        /// Mutes or unmutes the audio.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/D8840D15-D4D5-481E-9002-54FDBF323C9C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D8840D15-D4D5-481E-9002-54FDBF323C9C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool Mute
        {
            get
            {
                bool pbMute;
                int hr = this.Interface.GetMute(out pbMute);
                COM.ThrowIfNotOK(hr);
                return pbMute;
            }

            set
            {
                int hr = this.Interface.SetMute(value);
                COM.ThrowIfNotOK(hr);
            }
        }
    }
}
