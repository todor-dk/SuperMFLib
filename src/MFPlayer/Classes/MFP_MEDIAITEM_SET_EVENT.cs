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
    /// Event structure for the <strong>MFP_EVENT_TYPE_MEDIAITEM_SET</strong> event. This event is sent
    /// when the <see cref="MFPlayer.IMFPMediaPlayer.SetMediaItem"/> method completes. 
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct MFP_MEDIAITEM_SET_EVENT {
    ///   MFP_EVENT_HEADER header;
    ///   IMFPMediaItem ���*pMediaItem;
    /// } MFP_MEDIAITEM_SET_EVENT;
    /// </code>
    /// <para/>
    /// The above documentation is � Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/51FF492F-8199-4E1A-8D8B-D86BBB3C98DC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/51FF492F-8199-4E1A-8D8B-D86BBB3C98DC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Obsolete("This API may be removed from future releases of Windows.")]
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MFP_MEDIAITEM_SET_EVENT")]
    public class MFP_MEDIAITEM_SET_EVENT : MFP_EVENT_HEADER
    {
        /// <summary>
        /// A pointer to the <see cref="MFPlayer.IMFPMediaItem"/> interface of the media item that was queued
        /// for playback. 
        /// </summary>
        public IMFPMediaItem pMediaItem;
    }

#endif

}
