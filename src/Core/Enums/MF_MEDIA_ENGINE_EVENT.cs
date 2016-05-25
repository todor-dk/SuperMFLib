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

using MediaFoundation.Misc;
using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation.Core.Enums
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Defines event codes for the Media Engine. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/05790FF8-0720-474B-AFF1-362E7A1B7C34(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/05790FF8-0720-474B-AFF1-362E7A1B7C34(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_MEDIA_ENGINE_EVENT")]
    internal enum MF_MEDIA_ENGINE_EVENT
    {
        /// <summary>
        /// The Media Engine has started to load the source. See <see cref="IMFMediaEngine.Load"/>. 
        /// </summary>
        LoadStart = 1,
        /// <summary>
        /// The Media Engine is loading the source.
        /// </summary>
        Progress = 2,
        /// <summary>
        /// The Media Engine has suspended a load operation.
        /// </summary>
        Suspend = 3,
        /// <summary>
        /// The Media Engine cancelled a load operation that was in progress. 
        /// </summary>
        Abort = 4,
        /// <summary>
        /// An error occurred.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Event Parameter</term><description>Description</description></listheader>
        /// <item><term><em>param1</em></term><description>A member of the <see cref="MF_MEDIA_ENGINE_ERR"/> enumeration. </description></item>
        /// <item><term><em>param2</em></term><description>An <strong>HRESULT</strong> error code, or zero. </description></item>
        /// </list>
        /// </summary>
        Error = 5,
        /// <summary>
        /// The Media Engine has switched to the <strong>MF_MEDIA_ENGINE_NETWORK_EMPTY</strong> state. This can
        /// occur when the <see cref="IMFMediaEngine.Load"/> method is called, or if an error occurs during the
        /// <strong>Load</strong> method. See <see cref="IMFMediaEngine.GetNetworkState"/>. 
        /// </summary>
        Emptied = 6,
        /// <summary>
        /// The <c>Load</c> algorithm is stalled, waiting for data. 
        /// </summary>
        Stalled = 7,
        /// <summary>
        /// The Media Engine is switching to the playing state. See <see cref="IMFMediaEngine.Play"/>. 
        /// </summary>
        Play = 8,
        /// <summary>
        /// The media engine has paused. See <see cref="IMFMediaEngine.Pause"/>. 
        /// </summary>
        Pause = 9,
        /// <summary>
        /// The Media Engine has loaded enough source data to determine the duration and dimensions  of the
        /// source.
        /// </summary>
        LoadedMetadata = 10,
        /// <summary>
        /// The Media Engine has loaded enough data to render some content (for example, a video frame).
        /// </summary>
        LoadedData = 11,
        /// <summary>
        /// Playback has stopped because the next frame is not available.
        /// </summary>
        Waiting = 12,
        /// <summary>
        /// Playback has started. See <see cref="IMFMediaEngine.Play"/>. 
        /// </summary>
        Playing = 13,
        /// <summary>
        /// Playback can start, but the Media Engine might need to stop to buffer more data.
        /// </summary>
        CanPlay = 14,
        /// <summary>
        /// The Media Engine can probably play through to the end of the resource, without stopping to buffer
        /// data.
        /// </summary>
        CanPlayThrough = 15,
        /// <summary>
        /// The Media Engine has started seeking to a new playback position. See 
        /// <see cref="IMFMediaEngine.SetCurrentTime"/>. 
        /// </summary>
        Seeking = 16,
        /// <summary>
        /// The Media Engine has seeked to a new playback position. See 
        /// <see cref="IMFMediaEngine.SetCurrentTime"/>. 
        /// </summary>
        Seeked = 17,
        /// <summary>
        /// The playback position has changed. See <see cref="IMFMediaEngine.GetCurrentTime"/>. 
        /// </summary>
        TimeUpdate = 18,
        /// <summary>
        /// Playback has reached the end of the source. This event is not sent if the <c>GetLoop</c>is <strong>
        /// TRUE</strong>. 
        /// </summary>
        Ended = 19,
        /// <summary>
        /// The playback rate has changed. See <see cref="IMFMediaEngine.SetPlaybackRate"/>. 
        /// </summary>
        RateChange = 20,
        /// <summary>
        /// The duration of the media source has changed. See <see cref="IMFMediaEngine.GetDuration"/>. 
        /// </summary>
        DurationChange = 21,
        /// <summary>
        /// The audio volume changed. See <see cref="IMFMediaEngine.SetVolume"/>. 
        /// </summary>
        VolumeChange = 22,

        /// <summary>
        /// The output format of the media source has changed.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Event Parameter</term><description>Description</description></listheader>
        /// <item><term><em>param1</em></term><description>Zero if the video format changed, 1 if the audio format changed.</description></item>
        /// <item><term><em>param2</em></term><description>Zero.</description></item>
        /// </list>
        /// </summary>
        FormatChange = 1000,
        /// <summary>
        /// The Media Engine flushed any pending events from its 	queue.
        /// </summary>
        PurgeQueuedEvents = 1001,
        /// <summary>
        /// The playback position reached a timeline marker. See 
        /// <see cref="IMFMediaEngineEx.SetTimelineMarkerTimer"/>. 
        /// </summary>
        TimelineMarker = 1002,
        /// <summary>
        /// The audio balance changed. See <see cref="IMFMediaEngineEx.SetBalance"/>. 
        /// </summary>
        BalanceChange = 1003,
        /// <summary>
        /// The Media Engine has finished downloading the source data.
        /// </summary>
        DownloadComplete = 1004,
        /// <summary>
        /// The media source has started to buffer data.
        /// </summary>
        BufferingStarted = 1005,
        /// <summary>
        /// The media source has stopped buffering data.
        /// </summary>
        BufferingEnded = 1006,
        /// <summary>
        /// The <see cref="IMFMediaEngineEx.FrameStep"/> method completed. 
        /// </summary>
        FrameStepCompleted = 1007,
        /// <summary>
        /// The Media Engine's <c>Load</c> algorithm is waiting to start. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Event Parameter</term><description>Description</description></listheader>
        /// <item><term><em>param1</em></term><description>A handle to a waitable event, of type <strong>HANDLE</strong>. </description></item>
        /// <item><term><em>param2</em></term><description>Zero.</description></item>
        /// </list>
        /// <para/>
        /// If Media Engine is created with the <strong>MF_MEDIA_ENGINE_WAITFORSTABLE_STATE</strong> flag, the
        /// Media Engine sends the <strong>MF_MEDIA_ENGINE_EVENT_NOTIFYSTABLESTATE</strong> event at the start
        /// of the <c>Load</c> algorithm. The <em>param1</em> parameter is a handle to a waitable event. The 
        /// <strong>Load</strong> thread waits for the application to signal the event by calling 
        /// <c>SetEvent</c>. 
        /// <para/>
        /// If the Media Engine is not created with the <strong>MF_MEDIA_ENGINE_WAITFORSTABLE_STATE</strong>,
        /// it does not send this event, and the <c>Load</c> thread does not wait to be signalled. 
        /// </summary>
        NotifyStableState = 1008,
        /// <summary>
        /// The first frame of the media source is ready to render.
        /// </summary>
        FirstFrameReady = 1009,
        /// <summary>
        /// Raised when a new track is added or removed.
        /// <para/>
        /// Supported in Windows 8.1 and later.
        /// </summary>
        TracksChange = 1010,
        /// <summary>
        /// Raised when there is new information about the Output Protection Manager (OPM).
        /// <para/>
        /// This event will be raised when an OPM failure occurs, but ITA allows fallback without the OPM. 
        /// In this case, constriction can be applied. 
        /// <para/>
        /// This event will not be raised when there is an OPM failure and the fallback also fails. 
        /// For example, if ITA blocks playback entirely when OPM cannot be established.
        /// <para/>
        /// Supported in Windows 8.1 and later.
        /// </summary>
        OpmInfo = 1011,
    }

#endif

}
