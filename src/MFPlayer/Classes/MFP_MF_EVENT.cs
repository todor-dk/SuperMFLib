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
    /// Event structure for the <strong>MFP_EVENT_TYPE_MF</strong> event. The MFPlay player object uses
    /// this event to forward certain events from the Media Foundation pipeline to the application. 
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct MFP_MF_EVENT {
    ///   MFP_EVENT_HEADER header;
    ///   MediaEventType   MFEventType;
    ///   IMFMediaEvent    *pMFMediaEvent;
    ///   IMFPMediaItem    *pMediaItem;
    /// } MFP_MF_EVENT;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/61DEC86D-919C-4B1B-AB2A-527D062AE0F8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/61DEC86D-919C-4B1B-AB2A-527D062AE0F8(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Obsolete("This API may be removed from future releases of Windows.")]
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MFP_MF_EVENT")]
    public class MFP_MF_EVENT : MFP_EVENT_HEADER
    {
        /// <summary>
        /// Media Foundation event type. Currently, the MFPlay player object forwards the following pipeline
        /// events to the application:
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Event</term><description>Description</description></listheader>
        /// <item><term><c>MEBufferingStarted</c></term><description>The source has started buffering data.</description></item>
        /// <item><term><c>MEBufferingStopped</c></term><description>The source has stopped buffering data.</description></item>
        /// <item><term><c>MEExtendedType</c></term><description>Custom event type.</description></item>
        /// <item><term><c>MEReconnectEnd</c></term><description>The source has completed an attempt to reconnect to the server.</description></item>
        /// <item><term><c>MEReconnectStart</c></term><description>The source is attempting to reconnect to the server.</description></item>
        /// <item><term><c>MERendererEvent</c></term><description>Event sent by a renderer, such as the <c>Enhanced Video Renderer</c> (EVR). </description></item>
        /// <item><term><c>MEStreamSinkFormatChanged</c></term><description>A stream format has changed.</description></item>
        /// </list>
        /// </summary>
        public MediaEventType MFEventType;
        /// <summary>
        /// Pointer to the <see cref="IMFMediaEvent"/> interface of the Media Foundation event. 
        /// </summary>
        public IMFMediaEvent pMFMediaEvent;
        /// <summary>
        /// Pointer to the <see cref="MFPlayer.IMFPMediaItem"/> interface of the current media item. 
        /// </summary>
        public IMFPMediaItem pMediaItem;
    }

#endif

}
