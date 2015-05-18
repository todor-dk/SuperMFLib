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
    /// Contains flags that describe a media item.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7BBB45E6-717D-413C-95FD-DB730AB960FF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7BBB45E6-717D-413C-95FD-DB730AB960FF(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Obsolete("Applications should use the Media Session for playback.")]
    [Flags, UnmanagedName("_MFP_MEDIAITEM_CHARACTERISTICS")]
    internal enum MFP_MEDIAITEM_CHARACTERISTICS
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0x00000000,
        /// <summary>
        /// The media item represents a live data source, such as video camera. If playback is stopped and then
        /// restarted, there will be a gap in the content.
        /// </summary>
        IsLive = 0x00000001,
        /// <summary>
        /// The media item supports seeking. If this flag is absent, the 
        /// <see cref="MFPlayer.IMFPMediaPlayer.SetPosition"/> method will fail. 
        /// </summary>
        CanSeek = 0x00000002,
        /// <summary>
        /// The media item can pause. If this flag is absent, the <see cref="MFPlayer.IMFPMediaPlayer.Pause"/>
        /// method will likely fail. 
        /// </summary>
        CanPause = 0x00000004,
        /// <summary>
        /// Seeking can take a long time. For example, the source might download content through HTTP.
        /// </summary>
        HasSlowSeek = 0x00000008
    }

#endif

}
