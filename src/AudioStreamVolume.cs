using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Core.Interfaces;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="AudioStreamVolume"/> class implements a wrapper around the
    /// <see cref="IMFAudioStreamVolume"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFAudioStreamVolume"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFAudioStreamVolume"/>: 
    /// Controls the volume levels of individual audio channels.
    /// <para/>
    /// The streaming audio renderer (SAR) exposes this interface as a service. To get a pointer to the
    /// interface, call <see cref="IMFGetService.GetService"/> with the service identifier <strong>
    /// MR_STREAM_VOLUME_SERVICE</strong>. You can call <strong>GetService</strong> directly on the SAR or
    /// call it on the Media Session. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F06ED262-A2EC-4688-B477-877D04CF1892(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F06ED262-A2EC-4688-B477-877D04CF1892(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class AudioStreamVolume : COM<IMFAudioStreamVolume>
    {
        #region Construction

        private AudioStreamVolume(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="AudioStreamVolume"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the AudioStreamVolume's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="AudioStreamVolume"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static AudioStreamVolume FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            AudioStreamVolume result = new AudioStreamVolume(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Returns the <see cref="AudioStreamVolume"/> from the given <paramref name="service"/> 
        /// (either a streaming audio renderer (SAR) or the Media Session).
        /// </summary>
        /// <param name="service">The service to retrieve the <see cref="AudioStreamVolume"/> from (either a streaming audio renderer (SAR) or the Media Session).</param>
        /// <returns>A <see cref="AudioStreamVolume"/> for the given <paramref name="service"/>.</returns>
        public static AudioStreamVolume FromService(GetService service)
        {
            Contract.RequiresNotNull(service, "service");
            return service.Get(MFService.MR_STREAM_VOLUME_SERVICE, AudioStreamVolume.FromUnknown);
        }

        /// <summary>
        /// Returns the <see cref="AudioStreamVolume"/> from the given <paramref name="session"/>.
        /// </summary>
        /// <param name="session">Media Session to retrieve the <see cref="AudioStreamVolume"/> from.</param>
        /// <returns>A <see cref="AudioStreamVolume"/> for the given <paramref name="session"/>.</returns>
        public static AudioStreamVolume FromMediaSession(MediaSession session)
        {
            Contract.RequiresNotNull(session, "session");
            return session.GetService(MFService.MR_STREAM_VOLUME_SERVICE, AudioStreamVolume.FromUnknown);
        }

        /// <summary>
        /// Retrieves the number of channels in the audio stream.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D19A56DB-CD5F-4A19-98F0-42327C259B01(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D19A56DB-CD5F-4A19-98F0-42327C259B01(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int ChannelCount
        {
            get
            {
                int pdwCount;
                int hr = this.Interface.GetChannelCount(out pdwCount);
                COM.ThrowIfNotOK(hr);
                return pdwCount;
            }
        }

        /// <summary>
        /// Sets the volume level for a specified channel in the audio stream.
        /// </summary>
        /// <param name="index">
        /// Zero-based index of the audio channel. To get the number of channels, call 
        /// <see cref="ChannelCount"/>. 
        /// </param>
        /// <param name="level">
        /// Volume level for the channel.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7786A6AA-C777-4B65-B38C-A75CD654A080(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7786A6AA-C777-4B65-B38C-A75CD654A080(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetChannelVolume(int index, float level)
        {
            int hr = this.Interface.SetChannelVolume(index, level);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Retrieves the volume level for a specified channel in the audio stream.
        /// </summary>
        /// <param name="index">
        /// Zero-based index of the audio channel. To get the number of channels, call 
        /// <see cref="ChannelCount"/>. 
        /// </param>
        /// <returns>
        /// Returns the volume level for the channel.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5CFCC3A8-2911-45A3-8322-BF4E3B023DD2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5CFCC3A8-2911-45A3-8322-BF4E3B023DD2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public float GetChannelVolume(int index)
        {
            float pfLevel;
            int hr = this.Interface.GetChannelVolume(index, out pfLevel);
            COM.ThrowIfNotOK(hr);
            return pfLevel;
        }

        /// <summary>
        /// Sets the individual volume levels for all of the channels in the audio stream.
        /// </summary>
        /// <param name="volumes">
        /// An array of size <see cref="ChannelCount"/>. The array specifies the
        /// volume levels for all of the channels. Before calling the method, set each element of the array to
        /// the desired volume level for the channel. 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6C278693-5A2F-4AA2-B477-3B3014B2CC89(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6C278693-5A2F-4AA2-B477-3B3014B2CC89(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetAllVolumes(float[] volumes)
        {
            Contract.RequiresNotNull(volumes, "volumes");
            int hr = this.Interface.SetAllVolumes(volumes.Length, volumes);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Retrieves the volume levels for all of the channels in the audio stream.
        /// </summary>
        /// <returns>
        /// An array with the volume level for each channel in the stream. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CBCC0B5B-A60D-49CA-8B1C-7104E039A7D2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CBCC0B5B-A60D-49CA-8B1C-7104E039A7D2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public float[] GetAllVolumes()
        {
            float[] volumes = new float[this.ChannelCount];
            int hr = this.Interface.GetAllVolumes(volumes.Length, volumes);
            COM.ThrowIfNotOK(hr);
            return volumes;
        }
    }
}
