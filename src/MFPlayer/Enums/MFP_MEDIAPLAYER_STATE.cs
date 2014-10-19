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
    /// Specifies the current playback state.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A0D5C840-A1AA-48CF-BF2E-7E5C35951FB6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A0D5C840-A1AA-48CF-BF2E-7E5C35951FB6(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFP_MEDIAPLAYER_STATE")]
    public enum MFP_MEDIAPLAYER_STATE
    {
        /// <summary>
        /// Initial state. No media items have been set on the player object.
        /// </summary>
        Empty = 0x00000000,
        /// <summary>
        /// Playback is stopped.
        /// </summary>
        Stopped = 0x00000001,
        /// <summary>
        /// Playback is in progress.
        /// </summary>
        Playing = 0x00000002,
        /// <summary>
        /// Playback is paused.
        /// </summary>
        Paused = 0x00000003,
        /// <summary>
        /// The player object was shut down. This state is returned after the application calls 
        /// <see cref="MFPlayer.IMFPMediaPlayer.Shutdown"/>. 
        /// </summary>
        Shutdown = 0x00000004
    }

#endif

}
