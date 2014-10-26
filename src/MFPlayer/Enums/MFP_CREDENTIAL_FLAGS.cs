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
    /// <para />
    /// Contains flags for the <see cref="MFPlayer.MFP_ACQUIRE_USER_CREDENTIAL_EVENT" /> structure.
    /// <para />
    /// Some of these flags, marked [out], convey information back to the MFPlay player object. The
    /// application should set or clear these flags as appropriate, before returning from the
    /// <see cref="MFPlayer.IMFPMediaPlayerCallback.OnMediaPlayerEvent" /> callback method.
    /// </summary>
    /// <remarks>The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para />
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/5AA13072-239A-41B6-A0B6-A2729BAB2DB4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5AA13072-239A-41B6-A0B6-A2729BAB2DB4(v=VS.85,d=hv.2).aspx</a></remarks>
    [Flags, UnmanagedName("_MFP_CREDENTIAL_FLAGS")]
    [Obsolete("Applications should use the Media Session for playback.")]
    public enum MFP_CREDENTIAL_FLAGS
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0x00000000,
        /// <summary>
        /// The player object does not have any stored credentials and requires them from the application. If
        /// the player object can provide cached or stored credentials to the server, it does not set this
        /// flag.
        /// </summary>
        Prompt = 0x00000001,
        /// <summary>
        /// The credentials are saved to persistent storage. This flag acts as a hint for the application's UI.
        /// If the application prompts the user for credentials, the UI can indicate that the credentials have
        /// already been saved. 
        /// <para/>
        /// [out] If the application sets this flag, the player object saves the user credentials in persistent
        /// storage. Otherwise, the player object does not save the credentials.
        /// </summary>
        Save = 0x00000002,
        /// <summary>
        /// [out] If the application sets this flag, the player object does not cache the user credentials in
        /// memory. Otherwise, the player object does not cache the credentials. If you set this flag, do not
        /// set the <strong>MFP_CREDENTIAL_SAVE</strong> flag. 
        /// </summary>
        DoNotCache = 0x00000004,
        /// <summary>
        /// The credentials will be sent in clear text. The application should  warn the user that the
        /// credentials will be sent over the network without encryption.
        /// <para/>
        /// [out] On output, set this flag to allow the player object to send credentials in clear text,
        /// without prompting the user to re-enter the credentials.
        /// </summary>
        ClearText = 0x00000008,
        /// <summary>
        /// The credentials will be used to authenticate with a proxy. 
        /// </summary>
        Proxy = 0x00000010,
        /// <summary>
        /// The authentication scheme supports authentication of the user who is currently logged on. 
        /// </summary>
        LoggedOnUser = 0x00000020
    }

#endif

}
