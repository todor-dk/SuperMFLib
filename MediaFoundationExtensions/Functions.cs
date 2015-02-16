using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MediaFoundation
{
    /// <summary>
    /// Class that exposes many wrapper function to the Media Foundation API functions.
    /// </summary>
    public static class Functions
    {
        #region Media Session

        /// <summary>
        /// Creates the <c>Media Session</c> in the application's process. 
        /// </summary>
        /// <param name="configuration">
        /// Pointer to the <see cref="IMFAttributes"/> interface. This parameter can be <strong>NULL</strong>.
        /// See Remarks. 
        /// </param>
        /// <returns>
        /// Returns a pointer to the Media Session's <see cref="IMFMediaSession"/> interface. The caller must
        /// release the interface. Before releasing the last reference to the <strong>IMFMediaSession</strong>
        /// pointer, the application must call the <see cref="IMFMediaSession.Shutdown"/> method. 
        /// </returns>
        /// <remarks>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/86B2B5EC-231C-4943-9ADD-1A5A60E72268(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/86B2B5EC-231C-4943-9ADD-1A5A60E72268(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static IMFMediaSession CreateMediaSession(IMFAttributes configuration)
        {
            IMFMediaSession mediaSession;
            int hr = MFExtern.MFCreateMediaSession(configuration, out mediaSession);
            COM.ThrowIfNotOK(hr);
            return mediaSession;
        }


        /// <summary>
        /// Creates an instance of the <c>Media Session</c> inside a Protected Media Path (PMP) process. 
        /// </summary>
        /// <param name="creationFlags">
        /// A member of the <see cref="MFPMPSessionCreationFlags"/> enumeration that specifies how to create
        /// the session object. 
        /// </param>
        /// <param name="configuration">
        /// A pointer to the <see cref="IMFAttributes"/> interface. This parameter can be <strong>NULL</strong>. 
        /// See Remarks. 
        /// </param>
        /// <param name="enablerActivate">
        /// Receives the <see cref="IMFActivate"/> interface.
        /// The caller must release the interface. 
        /// </param>
        /// <returns>
        /// Returns the PMP Media Session's <see cref="IMFMediaSession"/> interface. The caller
        /// must release the interface. Before releasing the last reference to the <strong>IMFMediaSession
        /// </strong> pointer, the application must call the <see cref="IMFMediaSession.Shutdown"/> method. 
        /// </returns>
        /// <remarks>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CB492E68-3D8A-49B2-8C0B-BEE8065B53A8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CB492E68-3D8A-49B2-8C0B-BEE8065B53A8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static IMFMediaSession CreatePMPMediaSession(MFPMPSessionCreationFlags creationFlags, IMFAttributes configuration, out IMFActivate enablerActivate)
        {
            IMFMediaSession mediaSession;
            int hr = MFExtern.MFCreatePMPMediaSession(creationFlags, configuration, out mediaSession, out enablerActivate);
            COM.ThrowIfNotOK(hr);
            return mediaSession;
        }

        /// <summary>
        /// Creates an instance of the <c>Media Session</c> inside a Protected Media Path (PMP) process. 
        /// </summary>
        /// <param name="creationFlags">
        /// A member of the <see cref="MFPMPSessionCreationFlags"/> enumeration that specifies how to create
        /// the session object. 
        /// </param>
        /// <param name="configuration">
        /// A pointer to the <see cref="IMFAttributes"/> interface. This parameter can be <strong>NULL</strong>. 
        /// See Remarks. 
        /// </param>
        /// <returns>
        /// Returns the PMP Media Session's <see cref="IMFMediaSession"/> interface. The caller
        /// must release the interface. Before releasing the last reference to the <strong>IMFMediaSession
        /// </strong> pointer, the application must call the <see cref="IMFMediaSession.Shutdown"/> method. 
        /// </returns>
        /// <remarks>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CB492E68-3D8A-49B2-8C0B-BEE8065B53A8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CB492E68-3D8A-49B2-8C0B-BEE8065B53A8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static IMFMediaSession CreatePMPMediaSession(MFPMPSessionCreationFlags creationFlags, IMFAttributes configuration)
        {
            IMFActivate enablerActivate;
            IMFMediaSession mediaSession = Functions.CreatePMPMediaSession(creationFlags, configuration, out enablerActivate);
            COM.SafeRelease(enablerActivate); // Don't need the enablerActivate.
            return mediaSession;
        }

        #endregion
    }
}
