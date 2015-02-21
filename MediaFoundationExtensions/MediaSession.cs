using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaSession"/> class implements a wrapper around the
    /// <see cref="IMFMediaSession"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaSession"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaSession"/>: 
    /// Provides playback controls for protected and unprotected content. The Media Session and the
    /// protected media path (PMP) session objects expose this interface. This interface is the primary
    /// interface that applications use to control the Media Foundation pipeline.
    /// <para/>
    /// To obtain a pointer to this interface, call <see cref="MFExtern.MFCreateMediaSession"/> or 
    /// <see cref="MFExtern.MFCreatePMPMediaSession"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FEEBF891-73FA-4FE6-94CA-3594986FC92D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FEEBF891-73FA-4FE6-94CA-3594986FC92D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaSession : MediaEventGenerator<IMFMediaSession>
    {
        #region Construction

        internal MediaSession(IMFMediaSession comInterface)
            : base(comInterface)
        {
        }

        #endregion

        /// <summary>
        /// Creates the <c>Media Session</c> in the application's process. 
        /// </summary>
        /// <returns>
        /// Returns the media session. The caller must release the interface. 
        /// Before releasing the last reference to the <strong>MediaSession</strong> pointer, 
        /// the application must call the <see cref="IMFMediaSession.Shutdown"/> method. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/86B2B5EC-231C-4943-9ADD-1A5A60E72268(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/86B2B5EC-231C-4943-9ADD-1A5A60E72268(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static MediaSession Create()
        {
            return MediaSession.Create(null);
        }

        /// <summary>
        /// Creates the <c>Media Session</c> in the application's process. 
        /// </summary>
        /// <param name="configuration">
        /// An <see cref="Attributes"/> instance. This parameter can be <strong>null</strong>.
        /// </param>
        /// <returns>
        /// Returns the media session. The caller must release the interface. 
        /// Before releasing the last reference to the <strong>MediaSession</strong> pointer, 
        /// the application must call the <see cref="IMFMediaSession.Shutdown"/> method. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/86B2B5EC-231C-4943-9ADD-1A5A60E72268(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/86B2B5EC-231C-4943-9ADD-1A5A60E72268(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static MediaSession Create(Attributes configuration)
        {
            IMFMediaSession ppMediaSession = null;
            int hr = MFExtern.MFCreateMediaSession(configuration.GetInterface(), out ppMediaSession);
            COM.ThrowIfNotOK(hr);
            return ppMediaSession.ToMediaSession();
        }


        /// <summary>
        /// Sets a topology on the Media Session. 
        /// </summary>
        /// <param name="topologyFlags">
        /// Bitwise <strong>OR</strong> of zero or more flags from the <see cref="MFSessionSetTopologyFlags"/>
        /// enumeration. 
        /// </param>
        /// <param name="topology">
        /// The topology.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EA5313F0-B0FD-4945-97A2-B3F17937294F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EA5313F0-B0FD-4945-97A2-B3F17937294F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetTopology(MFSessionSetTopologyFlags topologyFlags, Topology topology)
        {
            int hr = this.Interface.SetTopology(topologyFlags, topology.GetInterface());
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Clears all of the presentations that are queued for playback in the Media Session.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FCB7E5F1-1095-4766-AFED-43AD2279ABB4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FCB7E5F1-1095-4766-AFED-43AD2279ABB4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void ClearTopologies()
        {
            int hr = this.Interface.ClearTopologies();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Starts the Media Session from the current position. 
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1BDEC0C0-B042-4E5E-A72B-B15942750CED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1BDEC0C0-B042-4E5E-A72B-B15942750CED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Start()
        {
            // VT_EMPTY: Playback starts from the current position.
            using (PropVariant pos = new PropVariant()) // VT_EMPTY
            {
                int hr = this.Interface.Start(Guid.Empty, pos);
                COM.ThrowIfNotOK(hr);
            }
        }

        /// <summary>
        /// Starts the Media Session. 
        /// </summary>
        /// <param name="startPosition">
        /// Starting position relative to the start of the presentation.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1BDEC0C0-B042-4E5E-A72B-B15942750CED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1BDEC0C0-B042-4E5E-A72B-B15942750CED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Start(Time startPosition)
        {
            using (PropVariant pos = new PropVariant(startPosition.Value))
            {
                int hr = this.Interface.Start(Guid.Empty, pos);
                COM.ThrowIfNotOK(hr);
            }
        }


        /// <summary>
        /// Pauses the Media Session.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FCC576BA-F8BE-4106-A270-756B2ABF52D4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FCC576BA-F8BE-4106-A270-756B2ABF52D4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Pause()
        {
            int hr = this.Interface.Pause();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Stops the Media Session.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9CC769CC-24EF-4790-A10E-4AEC8FB4FC1F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9CC769CC-24EF-4790-A10E-4AEC8FB4FC1F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Stop()
        {
            int hr = this.Interface.Stop();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Closes the Media Session and releases all of the resources it is using.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6ED118AE-7538-4EF6-81FC-B762F709838F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6ED118AE-7538-4EF6-81FC-B762F709838F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Close()
        {
            int hr = this.Interface.Close();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Dispose resources.
        /// </summary>
        /// <param name="disposing">True if disposing, false if due to GC.</param>
        protected override void Dispose(bool disposing)
        {
            // Shuts down the Media Session and releases all the resources used by the Media Session.
            int hr = this.Interface.Shutdown();
            COM.ThrowIfNotOK(hr);
            base.Dispose(disposing);
        }

        /// <summary>
        /// Retrieves the Media Session's presentation clock.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/16444DA2-68F2-4D94-8C6F-9E512D51E5E9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/16444DA2-68F2-4D94-8C6F-9E512D51E5E9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Clock Clock
        {
            get
            {
                IMFClock ppClock;
                int hr = this.Interface.GetClock(out ppClock);
                COM.ThrowIfNotOK(hr);
                return ppClock.ToClock();
            }
        }

        /// <summary>
        /// Retrieves the capabilities of the Media Session, based on the current presentation.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3534CFB9-23FF-42A6-A3DB-B5032D427CF2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3534CFB9-23FF-42A6-A3DB-B5032D427CF2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MFSessionCapabilities SessionCapabilities
        {
            get 
            {
                MFSessionCapabilities pdwCaps;
                int hr = this.Interface.GetSessionCapabilities(out pdwCaps);
                COM.ThrowIfNotOK(hr);
                return pdwCaps;
            }
        }

        /// <summary>
        /// Gets a topology from the Media Session.
        /// <para/>
        /// This method can get the current topology or a queued topology.
        /// </summary>
        /// <param name="topologyFlags">
        /// Bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="MFSessionGetFullTopologyFlags"/> enumeration. 
        /// </param>
        /// <param name="topologyId">
        /// The identifier of the topology. This parameter is ignored if the <paramref name="topologyFlags"/>
        /// parameter contains the <strong>MFSESSION_GETFULLTOPOLOGY_CURRENT</strong> flag. To get the
        /// identifier of a topology, call <see cref="IMFTopology.GetTopologyID"/>. 
        /// </param>
        /// <returns>
        /// The full topology.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6899DBE2-A684-487F-AB56-8631B3D5A033(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6899DBE2-A684-487F-AB56-8631B3D5A033(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Topology GetFullTopology(MFSessionGetFullTopologyFlags topologyFlags, long topologyId)
        {
            IMFTopology ppFullTopology;
            int hr = this.Interface.GetFullTopology(topologyFlags, topologyId, out ppFullTopology);
            COM.ThrowIfNotOK(hr);
            return ppFullTopology.ToTopology();
        }
    }
}
