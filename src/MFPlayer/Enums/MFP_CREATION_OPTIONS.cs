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
    /// Specifies options for the <see cref="MFExtern.MFPCreateMediaPlayer"/> function. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E01B402C-E21E-4DB0-B933-5A32FDCA5D2F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E01B402C-E21E-4DB0-B933-5A32FDCA5D2F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Obsolete("Applications should use the Media Session for playback.")]
    [Flags, UnmanagedName("_MFP_CREATION_OPTIONS")]
    public enum MFP_CREATION_OPTIONS
    {
        /// <summary>
        /// Use the default creation options.
        /// </summary>
        None = 0x00000000,
        /// <summary>
        /// If set, the MFPlay player object invokes the application's 
        /// <see cref="MFPlayer.IMFPMediaPlayerCallback"/> callback on another thread, and not the thread that
        /// called the <see cref="MFExtern.MFPCreateMediaPlayer"/> function. Therefore, the callback must be
        /// thread safe. 
        /// <para/>
        /// If this flag is not set, the player object invokes the callback on the same thread that calls 
        /// <see cref="MFExtern.MFPCreateMediaPlayer"/>. This thread must have a message loop. Internally, the
        /// player object creates a hidden window to dispatch the callback, similar to the mechanism used for
        /// single-threaded apartments (STAs) in COM. 
        /// </summary>
        FreeThreadedCallback = 0x00000001,
        /// <summary>
        /// Do not register the playback topology with the Multimedia Class Scheduler Service (MMCSS). By
        /// default, the MFPlay object registers the playback topology with MMCSS, which typically results in a
        /// better playback experience. For more information, see <see cref="IMFWorkQueueServices"/>. 
        /// </summary>
        NoMMCSS = 0x00000002,
        /// <summary>
        /// Disables optimizations that are otherwise performed when the application runs in a Remote Desktop
        /// Services (RDS, formerly Terminal Services) environment.
        /// </summary>
        NoRemoteDesktopOptimization = 0x00000004
    }

#endif

}
