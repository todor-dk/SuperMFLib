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
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;

namespace MediaFoundation.MFPlayer
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
    /// Applications should use the <c>Media Session</c> for playback. 
    /// <para/>
    /// Event structure for the <strong>MFP_EVENT_TYPE_ACQUIRE_USER_CREDENTIAL</strong> event. This event
    /// is sent if the application plays a media file from a server that requires authentication. The
    /// application can respond by providing the user credentials. 
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct MFP_ACQUIRE_USER_CREDENTIAL_EVENT {
    ///   MFP_EVENT_HEADER     header;
    ///   DWORD_PTR            dwUserData;
    ///   BOOL                 fProceedWithAuthentication;
    ///   HRESULT              hrAuthenticationStatus;
    ///   LPCWSTR              pwszURL;
    ///   LPCWSTR              pwszSite;
    ///   LPCWSTR              pwszRealm;
    ///   LPCWSTR              pwszPackage;
    ///   LONG                 nRetries;
    ///   MFP_CREDENTIAL_FLAGS flags;
    ///   IMFNetCredential     *pCredential;
    /// } MFP_ACQUIRE_USER_CREDENTIAL_EVENT;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/61767B81-8641-43D5-B272-148D52517727(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/61767B81-8641-43D5-B272-148D52517727(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Obsolete("This API may be removed from future releases of Windows.")]
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MFP_ACQUIRE_USER_CREDENTIAL_EVENT")]
    public class MFP_ACQUIRE_USER_CREDENTIAL_EVENT : MFP_EVENT_HEADER
    {
        /// <summary>
        /// Application-defined user data for the media item. This value is specified when the application
        /// calls <see cref="MFPlayer.IMFPMediaPlayer.CreateMediaItemFromURL"/> or 
        /// <see cref="MFPlayer.IMFPMediaPlayer.CreateMediaItemFromObject"/> to create the media item. 
        /// <para/>
        /// This event is sent (if at all) before the media item is created and before the application receives
        /// the <strong>MFP_EVENT_TYPE_MEDIAITEM_CREATED</strong> event. You can use the value of <strong>
        /// dwUserData</strong> to identify which media item requires authentication. 
        /// </summary>
        public IntPtr dwUserData;
        /// <summary>
        /// The application should set this member to either <strong>TRUE</strong> or <strong>FALSE</strong>
        /// before returning from the <see cref="MFPlayer.IMFPMediaPlayerCallback.OnMediaPlayerEvent"/> event
        /// callback. 
        /// <para/>
        /// If the value is <strong>TRUE</strong> when the callback returns, MFPlay continues the
        /// authentication attempt. Otherwise, authentication fails. 
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool fProceedWithAuthentication;
        /// <summary>
        /// The response code of the authentication challenge. 
        /// </summary>
        public int hrAuthenticationStatus;
        /// <summary>
        /// The original URL that requires authentication. 
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszURL;
        /// <summary>
        /// The name of the site or proxy that requires authentication.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszSite;
        /// <summary>
        /// The name of the realm for this authentication.
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszRealm;
        /// <summary>
        /// The name of the authentication package, such as "Digest" or "MBS_BASIC".
        /// </summary>
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pwszPackage;
        /// <summary>
        /// The number of retries. This member is set to zero on the first attempt, and incremented once for
        /// each subsequent attempt.
        /// </summary>
        public int nRetries;
        /// <summary>
        /// Bitwise <strong>OR</strong> of zero or more flags from the <c>_MFP_CREDENTIAL_FLAGS</c>
        /// enumeration. 
        /// </summary>
        public MFP_CREDENTIAL_FLAGS flags;
        /// <summary>
        /// Pointer to the <see cref="IMFNetCredential"/> interface. The application uses this interface to set
        /// the user's credentials. 
        /// </summary>
        public IMFNetCredential pCredential;
    }

#endif

}
