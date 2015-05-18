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

namespace MediaFoundation.MFPlayer.Enums
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
    /// Applications should use the <c>Media Session</c> for playback. 
    /// <para/>
    /// Defines event types for the <see cref="MFPlayer.IMFPMediaPlayerCallback"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/95BEB13D-DB84-4713-9C27-27B37EAC7F2F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/95BEB13D-DB84-4713-9C27-27B37EAC7F2F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFP_EVENT_TYPE")]
    internal enum MFP_EVENT_TYPE
    {
        /// <summary>
        /// Playback has started. This event is sent when the <see cref="MFPlayer.IMFPMediaPlayer.Play"/>
        /// method completes. 
        /// </summary>
        Play = 0,
        /// <summary>
        /// Playback has paused. This event is sent when the <see cref="MFPlayer.IMFPMediaPlayer.Pause"/>
        /// method completes. 
        /// </summary>
        Pause = 1,
        /// <summary>
        /// Playback has stopped. This event is sent when the <see cref="MFPlayer.IMFPMediaPlayer.Stop"/>
        /// method completes. 
        /// </summary>
        Stop = 2,
        /// <summary>
        /// The MFPlay player object has seeked to a new playback position. This event is sent when the 
        /// <see cref="MFPlayer.IMFPMediaPlayer.SetPosition"/> method completes. 
        /// </summary>
        PositionSet = 3,
        /// <summary>
        /// The playback rate has changed. This event is sent when the 
        /// <see cref="MFPlayer.IMFPMediaPlayer.SetRate"/> method completes. 
        /// </summary>
        RateSet = 4,
        /// <summary>
        /// A new media item was created. This event is sent when the 
        /// <see cref="MFPlayer.IMFPMediaPlayer.CreateMediaItemFromURL"/> or <c>CreateMediaItemFromObject</c>
        /// method completes. 
        /// </summary>
        MediaItemCreated = 5,
        /// <summary>
        /// A media item is ready for playback. This event is sent when the 
        /// <see cref="MFPlayer.IMFPMediaPlayer.SetMediaItem"/> method completes. 
        /// </summary>
        MediaItemSet = 6,
        /// <summary>
        /// A frame-step operation has completed. This event is sent when the 
        /// <see cref="MFPlayer.IMFPMediaPlayer.FrameStep"/> method completes. 
        /// </summary>
        FrameStep = 7,
        /// <summary>
        /// The current media item was cleared. This event is sent when the 
        /// <see cref="MFPlayer.IMFPMediaPlayer.ClearMediaItem"/> method completes. 
        /// </summary>
        MediaItemCleared = 8,
        /// <summary>
        /// A pipeline object sent an event. The player object forwards certain pipeline events to the
        /// application. For more information, see <see cref="MFPlayer.MFP_MF_EVENT"/>. 
        /// </summary>
        MF = 9,
        /// <summary>
        /// A playback error has occurred. 
        /// </summary>
        Error = 10,
        /// <summary>
        /// Playback has ended. The player object sends this event when playback reaches the end of the media
        /// file.
        /// </summary>
        PlaybackEnded = 11,
        /// <summary>
        /// The media source requires authentication before it can play the file.
        /// </summary>
        AcquireUserCredential = 12
    }

#endif

}
