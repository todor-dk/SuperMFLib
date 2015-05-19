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
using System.Text;
using System.Runtime.InteropServices;

using MediaFoundation.Misc;
using System.Drawing;
using System.ComponentModel;

namespace MediaFoundation
{


    /// <summary>
    /// Media Foundation Events
    /// </summary>
    [UnmanagedName("Media Foundation Events")]
    public enum MediaEventType
    {
        /// <summary>
        /// Unknown event type. You can use this value to initialize variables of type <strong>MediaEventType
        /// </strong>, but a component should never raise the MEUnknown event 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/786B69F4-8713-41DB-829A-C13512BAA3F1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/786B69F4-8713-41DB-829A-C13512BAA3F1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEUnknown = 0,
        /// <summary>
        /// Signals a serious error. Any Media Foundation component can send this event at any time. Call 
        /// <see cref="IMFMediaEvent.GetStatus"/> to get the error code of the operation that failed. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BFF80041-77D8-43B1-A410-9CEFAF45EB2C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BFF80041-77D8-43B1-A410-9CEFAF45EB2C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEError = 1,
        /// <summary>
        /// Custom event type. You can use this event type to define custom events for your component. Use the
        /// extended event type to identify the event. The extended event type is a GUID value associated with
        /// the event. For more information, see <see cref="IMFMediaEvent.GetExtendedType"/>. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A54A446C-0E96-467B-90F6-0F64A7C1727D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A54A446C-0E96-467B-90F6-0F64A7C1727D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEExtendedType = 2,
        /// <summary>
        /// A non-fatal error occurred during streaming. Any Media Foundation component can send this event at
        /// any time.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_UI4</term><description><strong>HRESULT</strong> value that describes the error. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// No attributes are defined for this event.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/04AFCCA5-34D9-4C99-86BC-B37C19232EC1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/04AFCCA5-34D9-4C99-86BC-B37C19232EC1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MENonFatalError = 3,
        /// <summary>
        /// Internal. Don't use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MEGenericV1Anchor = MENonFatalError,
        /// <summary>
        /// Internal. Don't use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MESessionUnknown = 100,
        /// <summary>
        /// Raised after the <see cref="IMFMediaSession.SetTopology"/> method completes asynchronously. The
        /// Media Session raises this event after it resolves the topology into a full topology and queues the
        /// topology for playback. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFTopology"/> interface of the full topology. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/22A298B7-D32B-44ED-B0A1-4E0398ECFE04(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/22A298B7-D32B-44ED-B0A1-4E0398ECFE04(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESessionTopologySet = 101,
        /// <summary>
        /// Raised by the Media Session when the <see cref="IMFMediaSession.ClearTopologies"/> method completes
        /// asynchronously. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2017D13B-8DC2-48F9-A21E-7B826E174EDF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2017D13B-8DC2-48F9-A21E-7B826E174EDF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESessionTopologiesCleared = 102,
        /// <summary>
        /// Raised when the <see cref="IMFMediaSession.Start"/> method completes asynchronously. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// The following attributes are defined for this event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_PRESENTATION_TIME_OFFSET"/></term><description>Offset between the presentation time and the media source's time stamps.</description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/28ED32F0-9B23-4DA1-9587-15F490DA7BF9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/28ED32F0-9B23-4DA1-9587-15F490DA7BF9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESessionStarted = 103,
        /// <summary>
        /// Raised when the <see cref="IMFMediaSession.Pause"/> method completes asynchronously. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/72546082-83EC-4481-A24F-E82BD6C88859(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/72546082-83EC-4481-A24F-E82BD6C88859(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESessionPaused = 104,
        /// <summary>
        /// Raised when the <see cref="IMFMediaSession.Stop"/> method completes asynchronously. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9CAC9040-F652-4509-BBAB-F2A41959D836(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9CAC9040-F652-4509-BBAB-F2A41959D836(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESessionStopped = 105,
        /// <summary>
        /// Raised when the <see cref="IMFMediaSession.Close"/> method completes asynchronously. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D1056CE7-5527-428A-8ACE-E1C10A2124A5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D1056CE7-5527-428A-8ACE-E1C10A2124A5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESessionClosed = 106,
        /// <summary>
        /// Raised by the Media Session when it has finished playing the last presentation in the playback
        /// queue. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E593E51F-C239-49E9-BBA8-C6D8238EFF24(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E593E51F-C239-49E9-BBA8-C6D8238EFF24(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESessionEnded = 107,
        /// <summary>
        /// Raised by the Media Session when the playback rate changes. This event is sent after the 
        /// <see cref="IMFRateControl.SetRate"/> method completes asynchronously. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_R4</term><description>The new playback rate, expressed as a ratio of the normal playback rate.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6BEF923F-4083-46E1-9A2E-49A6825467EC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6BEF923F-4083-46E1-9A2E-49A6825467EC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESessionRateChanged = 108,
        /// <summary>
        /// Raised by the Media Session when it completes a scrubbing request.
        /// <para/>
        /// Scrubbing occurs when the playback rate is zero and the application calls 
        /// <see cref="IMFMediaSession.Start"/>. This event is raised after every stream sink has completed the
        /// scrubbing request. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1AE97022-3FB2-4C5E-9262-D5BDC2A62BEE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1AE97022-3FB2-4C5E-9262-D5BDC2A62BEE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESessionScrubSampleComplete = 109,
        /// <summary>
        /// Raised by the Media Session when the session capabilities change. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D59FD3A0-29DB-434C-B6BA-D9BEB33BD965(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D59FD3A0-29DB-434C-B6BA-D9BEB33BD965(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESessionCapabilitiesChanged = 110,
        /// <summary>
        /// Raised by the Media Session when the status of a topology changes. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFTopology"/> interface of the topology. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// The following attributes are defined for this event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_TOPOLOGY_STATUS"/></term><description>Specifies the new status of the topology.</description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B45FD598-AB1E-4B12-8D82-C88C96D1F770(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B45FD598-AB1E-4B12-8D82-C88C96D1F770(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESessionTopologyStatus = 111,
        /// <summary>
        /// Raised by the Media Session when a new presentation starts. This event indicates when the
        /// presentation will start and the offset between the presentation time and the source time.
        /// <para /><strong>Event values</strong><para />
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue" /> include the following.
        /// <para /><list type="table"><listheader><term>VARTYPE</term><description>Description</description></listheader><item><term>VT_EMPTY</term><description>No event data.</description></item></list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// The following attributes are defined for this event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_START_PRESENTATION_TIME"/></term><description>Starting time for the presentation.</description></item>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_PRESENTATION_TIME_OFFSET"/></term><description>Offset between the presentation time and the media source's time stamps.</description></item>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_START_PRESENTATION_TIME_AT_OUTPUT"/></term><description>Presentation time when the media sinks will render the first sample of the new topology.</description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/67C7D5F3-FFAF-4359-A59C-BB26B992B6CD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/67C7D5F3-FFAF-4359-A59C-BB26B992B6CD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESessionNotifyPresentationTime = 112,
        /// <summary>
        /// Raised by a media source that provides topologies through the 
        /// <see cref="IMFMediaSourceTopologyProvider"/> interface, such as the sequencer source. The source
        /// raises the event when it has a new presentation. The Media Session forwards this event to the
        /// application. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFPresentationDescriptor"/> interface of the presentation descriptor for the new presentation. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C669B2C9-5ECE-4045-B691-8A71BBF491E1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C669B2C9-5ECE-4045-B691-8A71BBF491E1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MENewPresentation = 113,
        /// <summary>
        /// Raised by the policy engine when license acquisition is about to begin. License acquisition is
        /// performed using the application's implementation of the <see cref="IMFContentProtectionManager"/>
        /// interface. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C328743C-A69B-431E-8A05-0E140AAD9B4D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C328743C-A69B-431E-8A05-0E140AAD9B4D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MELicenseAcquisitionStart = 114,
        /// <summary>
        /// Raised when license acquisition is complete. For more information, see 
        /// <c>MELicenseAcquisitionStart</c>. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F577131B-887A-4912-8278-1165A801C2B3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F577131B-887A-4912-8278-1165A801C2B3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MELicenseAcquisitionCompleted = 115,
        /// <summary>
        /// Raised by the policy engine when individualization is about to begin. Individualization is
        /// performed using the application's implementation of the <see cref="IMFContentProtectionManager"/>
        /// interface. 
        /// <para/>
        /// An individualized application is one that has received an upgrade to its digital rights management
        /// (DRM) components that differentiates it from all other copies of the same application. Content
        /// owners can require that their protected files be played only on an application that has been
        /// individualized.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A3BA98EE-4D2E-466D-BE9A-C7E3B5F920A7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A3BA98EE-4D2E-466D-BE9A-C7E3B5F920A7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEIndividualizationStart = 116,
        /// <summary>
        /// Raised by the policy engine when individualization is complete. For more information, see 
        /// <c>MEIndividualizationStart</c> event. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/44A4956F-19BA-410D-B96C-E7774CBE2D7E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/44A4956F-19BA-410D-B96C-E7774CBE2D7E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEIndividualizationCompleted = 117,
        /// <summary>
        /// Signals the progress of a content enabler object. Objects that expose the 
        /// <see cref="IMFContentEnabler"/> interface can raise this event to notify the application about the
        /// progress of the content enabler's actions. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_LPWSTR</term><description>Wide-character string that describes the progress.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EC14BA9B-CFB6-4E32-870E-2436E11C308B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EC14BA9B-CFB6-4E32-870E-2436E11C308B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEEnablerProgress = 118,
        /// <summary>
        /// Raised by a content enabler object when the object's enabling action is completed. Objects that
        /// expose the <see cref="IMFContentEnabler"/> interface can raise this event. The event is raised if
        /// either of the following occurs: 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5162800C-9C55-40DE-BE66-A98765324F76(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5162800C-9C55-40DE-BE66-A98765324F76(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEEnablerCompleted = 119,
        /// <summary>
        /// Raised by a trusted output if an error occurs while enforcing the output policy.
        /// <para/>
        /// If the Media Session receives this event, it stops playback and forwards the event to the
        /// application.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0CC62915-1ED6-4D1D-9600-0DAC0B9034E3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0CC62915-1ED6-4D1D-9600-0DAC0B9034E3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEPolicyError = 120,
        /// <summary>
        /// Raised by a trusted output to send status information about the enforcement of the output policy. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4906F6C3-1570-421F-AEF1-914BD338BB1F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4906F6C3-1570-421F-AEF1-914BD338BB1F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEPolicyReport = 121,
        /// <summary>
        /// Signals that a media source has started to buffer data.
        /// <para/>
        /// A media source can send this event if the source buffers data while the Media Session is running.
        /// When the Media Session receives this event, it pauses the presentation clock until the media source
        /// sends the <c>MEBufferingStopped</c> event. The Media Session also forwards the MEBufferingStarted
        /// event to the application. 
        /// <para/>
        /// Byte streams that implement the <see cref="IMFByteStreamBuffering"/> interface also send this
        /// event. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8637DFCD-2E0C-4CF4-A216-4089C201BFC6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8637DFCD-2E0C-4CF4-A216-4089C201BFC6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEBufferingStarted = 122,
        /// <summary>
        /// Signals that a media source has stopped buffering data.
        /// <para/>
        /// A media source sends this when it stops buffering data after sending the <c>MEBufferingStarted</c>
        /// event. 
        /// <para/>
        /// Byte streams that implement the <see cref="IMFByteStreamBuffering"/> interface also send this
        /// event. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/11B1290D-D462-4AA0-A358-B3F6447C99D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/11B1290D-D462-4AA0-A358-B3F6447C99D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEBufferingStopped = 123,
        /// <summary>
        /// Raised by the network source when it starts opening a URL. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0844AC10-CC5B-4E7F-92DF-3A5901C72148(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0844AC10-CC5B-4E7F-92DF-3A5901C72148(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEConnectStart = 124,
        /// <summary>
        /// Raised by the network source when it finishes opening a URL. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/737AEC32-24F4-4825-AD34-8D2FC889BC09(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/737AEC32-24F4-4825-AD34-8D2FC889BC09(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEConnectEnd = 125,
        /// <summary>
        /// Signals that a media source is attempting to reconnect to the server.
        /// <para/>
        /// Raised by a media source at the start of a reconnection attempt. The network source raises this
        /// event if it attempts to reconnect to the server. The Media Session forwards this event to the
        /// application.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C5975279-C710-4046-9152-D1E1C62EB785(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C5975279-C710-4046-9152-D1E1C62EB785(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEReconnectStart = 126,
        /// <summary>
        /// Signals that a media source has completed an attempt to reconnect to the server.
        /// <para/>
        /// Raised by a media source at the end of a reconnection attempt. The network source raises this event
        /// if it reconnects to the server. The Media Session forwards this event to the application.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/228E069A-A26B-472E-915E-FF9AEC5EE9C1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/228E069A-A26B-472E-915E-FF9AEC5EE9C1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEReconnectEnd = 127,
        /// <summary>
        /// Signals an event from a media sink that renders media data.
        /// <para/>
        /// The <c>Enhanced Video Renderer</c> (EVR) sends this event when it receives a user event from the
        /// EVR presenter. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_I4</term><description>Event code.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BB7DB7C9-C39F-4BF4-9412-42525C4F2EA3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BB7DB7C9-C39F-4BF4-9412-42525C4F2EA3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MERendererEvent = 128,
        /// <summary>
        /// Raised by the Media Session when the format changes on a media sink. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// The following attributes are defined for this event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_OUTPUT_NODE"/></term><description>Identifies the topology node for the media sink whose format changed.</description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F56419F8-7F50-4EDA-BF4A-FCDBBE46E180(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F56419F8-7F50-4EDA-BF4A-FCDBBE46E180(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESessionStreamSinkFormatChanged = 129,
        /// <summary>
        /// Internal. Don't use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MESessionV1Anchor = MESessionStreamSinkFormatChanged,
        /// <summary>
        /// Internal. Don't use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MESourceUnknown = 200,
        /// <summary>
        /// Raised when a media source starts without seeking. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data. The start time was from the current position.</description></item>
        /// <item><term>VT_I8</term><description>The starting time, in 100-nanosecond units, relative to the time stamps on the samples.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// The following attributes are defined for this event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_SOURCE_ACTUAL_START"/></term><description>Start time. The media source sets this attribute if it restarts from its current position.</description></item>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_SOURCE_FAKE_START"/></term><description>Specifies whether the current segment topology is empty. The sequencer source sets this attribute.</description></item>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_SOURCE_PROJECTSTART"/></term><description>Start time for a segment, relative to the start of the presentation. The sequencer source sets this attribute.</description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A52D8EE1-CB46-487D-A744-FCA6DB7C2353(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A52D8EE1-CB46-487D-A744-FCA6DB7C2353(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESourceStarted = 201,
        /// <summary>
        /// Raised by a media stream when the source starts without seeking. A media stream raises this event
        /// when the media source raises the <c>MESourceStarted</c> event. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// <item><term>VT_I8</term><description>The starting time, in 100-nanosecond units, relative to the time stamps on the samples.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6652E440-5DE9-4767-B7A6-9D919CEECE38(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6652E440-5DE9-4767-B7A6-9D919CEECE38(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamStarted = 202,
        /// <summary>
        /// Raised when a media source seeks to a new position. A media source raises this event if the source
        /// is running or paused and the application calls <see cref="IMFMediaSource.Start"/> with a start time
        /// that does not equal the current position. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_I8</term><description>The new starting position, in 100-nanosecond units.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/51CE770E-DDC7-41C1-8E31-59481CAFE2B0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/51CE770E-DDC7-41C1-8E31-59481CAFE2B0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESourceSeeked = 203,
        /// <summary>
        /// Raised by a media stream after a call to <see cref="IMFMediaSource.Start"/> causes a seek in the
        /// stream. A media stream raises this event when the media source raises the <c>MESourceSeeked</c>
        /// event. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_I8</term><description>New starting time, in 100-nanosecond units.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DF06DF16-711D-4262-B049-FB29F25934DE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DF06DF16-711D-4262-B049-FB29F25934DE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamSeeked = 204,
        /// <summary>
        /// Raised by a media source when it starts a new stream.
        /// <para/>
        /// When the <see cref="IMFMediaSource.Start"/> method is called on a media source, the media source
        /// sends one event for each selected stream: 
        /// <para/>
        /// No events are sent for unselected streams.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_UNKNOWN</term><description>Contains a pointer to the stream's <see cref="IMFMediaStream"/> interface. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1BC8B265-B7A1-4068-89F7-C0DA03DFB874(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1BC8B265-B7A1-4068-89F7-C0DA03DFB874(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MENewStream = 205,
        /// <summary>
        /// Raised by a media source when it restarts or seeks a stream that is already active.
        /// <para/>
        /// When the <see cref="IMFMediaSource.Start"/> method is called on a media source, the media source
        /// sends one event for each selected stream: 
        /// <para/>
        /// No events are sent for unselected streams.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the stream's <see cref="IMFMediaStream"/> interface. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2D91A267-E109-45F5-886B-11B883CC5509(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2D91A267-E109-45F5-886B-11B883CC5509(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEUpdatedStream = 206,
        /// <summary>
        /// Raised by a media source when the <see cref="IMFMediaSource.Stop"/> method completes
        /// asynchronously. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0EDA9AA1-3AAD-43AC-9D87-AB96E4AC319D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0EDA9AA1-3AAD-43AC-9D87-AB96E4AC319D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESourceStopped = 207,
        /// <summary>
        /// Raised by a media stream when the <see cref="IMFMediaSource.Stop"/> method completes
        /// asynchronously. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/80280820-B618-43D9-881E-6119DFA36E22(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/80280820-B618-43D9-881E-6119DFA36E22(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamStopped = 208,
        /// <summary>
        /// Raised by a media source when the <see cref="IMFMediaSource.Pause"/> method completes
        /// asynchronously. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CCA03D60-47AE-4A11-B29D-81D749E24DF9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CCA03D60-47AE-4A11-B29D-81D749E24DF9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESourcePaused = 209,
        /// <summary>
        /// Raised by a media stream when the <see cref="IMFMediaSource.Pause"/> method completes
        /// asynchronously. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8FAFB9A1-95A4-44B6-ACD6-FB007D515915(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8FAFB9A1-95A4-44B6-ACD6-FB007D515915(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamPaused = 210,
        /// <summary>
        /// Raised by a media source when a presentation ends. This event signals that all streams in the
        /// presentation are complete. The Media Session forwards this event to the application.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// The following attributes are defined for this event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_SOURCE_TOPOLOGY_CANCELED"/></term><description>Specifies whether the sequencer source canceled this presentation.</description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/259B00AE-A91B-461B-A12F-F7291ECC04FF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/259B00AE-A91B-461B-A12F-F7291ECC04FF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEEndOfPresentation = 211,
        /// <summary>
        /// Raised by a media stream when the stream ends. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E793131A-F737-411F-A9FC-03B5B3D09AEA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E793131A-F737-411F-A9FC-03B5B3D09AEA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEEndOfStream = 212,
        /// <summary>
        /// Sent when a media stream delivers a new sample in response to a call to 
        /// <see cref="IMFMediaStream.RequestSample"/>. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFSample"/> interface of the sample. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/01610053-786F-44B5-90D6-2CB2668CD632(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/01610053-786F-44B5-90D6-2CB2668CD632(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEMediaSample = 213,
        /// <summary>
        /// Signals that a media stream does not have data available at a specified time. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_I8</term><description>Time at which the gap occurs, in 100-nanosecond units.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1A00FFF1-C3AB-4965-A663-3C15BB48EA98(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1A00FFF1-C3AB-4965-A663-3C15BB48EA98(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamTick = 214,
        /// <summary>
        /// Raised by a media stream when it starts or stops thinning the stream. For information about <em>
        /// thinning</em>, see <c>About Rate Control</c>. 
        /// <para/>
        /// This event can be sent in response to the <see cref="IMFRateControl.SetRate"/> method or the 
        /// <see cref="IMFQualityAdvise.SetDropMode"/> method. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_BOOL</term><description>Indicates whether thinning has started or stopped.<para>* VARIANT_TRUE: Samples delivered after this event are thinned.</para><para>* VARIANT_FALSE: Samples delivered after this event are not thinned.</para></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7DE8CB64-122A-475F-990C-C19590A9D9D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7DE8CB64-122A-475F-990C-C19590A9D9D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamThinMode = 215,
        /// <summary>
        /// Raised by a media stream when the media type of the stream changes. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFMediaType"/> interface of the new media type. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/14786A9B-413E-4FB4-B267-BFD0CCD4631B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/14786A9B-413E-4FB4-B267-BFD0CCD4631B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamFormatChanged = 216,
        /// <summary>
        /// Raised by a media source when the playback rate changes. This event is sent after the 
        /// <see cref="IMFRateControl.SetRate"/> method completes asynchronously. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_R4</term><description>The new playback rate.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/68A7FE64-E28A-4C20-830C-9402E1FB57F8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/68A7FE64-E28A-4C20-830C-9402E1FB57F8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESourceRateChanged = 217,
        /// <summary>
        /// Raised by the sequencer source when a segment is completed and is followed by another segment. When
        /// the final segment is completed, the sequencer source raises an <c>MEEndOfPresentation</c> event. 
        /// <para/>
        /// The Media Session forwards this event to the application.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// The following attributes are defined for this event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_SOURCE_TOPOLOGY_CANCELED"/></term><description>Specifies whether the sequencer source canceled this segment.</description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1BE13C9A-D454-4642-B26B-556F2461B705(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1BE13C9A-D454-4642-B26B-556F2461B705(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEEndOfPresentationSegment = 218,
        /// <summary>
        /// Raised by a media source when the source's characteristics change. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// The following attributes are defined for this event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_SOURCE_CHARACTERISTICS"/></term><description>New characteristics of the media source.</description></item>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_SOURCE_CHARACTERISTICS_OLD"/></term><description>Previous characteristics of the media source.</description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DF7BB9A3-5949-4A4A-8835-C5B1D01B5CB3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DF7BB9A3-5949-4A4A-8835-C5B1D01B5CB3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESourceCharacteristicsChanged = 219,
        /// <summary>
        /// Raised by a media source to request a new playback rate. The application should call 
        /// <see cref="IMFRateControl.SetRate"/> with the requested rate. A media source might raise this event
        /// if it cannot continue playback at the current rate. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_R4</term><description>The requested new playback rate.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// The following attributes are defined for this event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_DO_THINNING"/></term><description>Specifies whether the media source also requests thinning.</description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/705E5A79-836B-417B-A7ED-C733572F6905(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/705E5A79-836B-417B-A7ED-C733572F6905(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESourceRateChangeRequested = 220,
        /// <summary>
        /// Raised by a media source when it updates its metadata. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6818B0C9-9628-41E6-8DC6-DFF26F4FCFD2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6818B0C9-9628-41E6-8DC6-DFF26F4FCFD2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESourceMetadataChanged = 221,
        /// <summary>
        /// Raised by the sequencer source when the <see cref="IMFSequencerSource.UpdateTopology"/> method
        /// completes asynchronously. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_UI4</term><description>Sequencer element identifier of the topology that is being updated. The application specifies this value in the <em>dwId</em> parameter of the <c>UpdateTopology</c> method. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F573CBD0-689C-4BFE-846B-6FC8008101C8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F573CBD0-689C-4BFE-846B-6FC8008101C8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESequencerSourceTopologyUpdated = 222,
        /// <summary>
        /// Internal. Don't use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MESourceV1Anchor = MESequencerSourceTopologyUpdated,

        /// <summary>
        /// Internal. Don't use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MESinkUnknown = 300,
        /// <summary>
        /// Raised by a stream sink when it completes the transition to the running state. The transition to
        /// running occurs when the <see cref="IMFPresentationClock.Start"/> method is called on the sink's
        /// presentation clock. The media sink receives the notification through its 
        /// <see cref="IMFClockStateSink.OnClockStart"/> or <see cref="IMFClockStateSink.OnClockRestart"/>
        /// method. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/95AC658B-BEC0-442D-85EF-61966B40A2F2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/95AC658B-BEC0-442D-85EF-61966B40A2F2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamSinkStarted = 301,
        /// <summary>
        /// Raised by a stream sink when it completes the transition to the stopped state. The transition to
        /// stopped occurs when the <see cref="IMFPresentationClock.Stop"/> method is called on the sink's
        /// presentation clock. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1A8C7FAA-4D4A-4458-AD08-A760A15DC347(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1A8C7FAA-4D4A-4458-AD08-A760A15DC347(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamSinkStopped = 302,
        /// <summary>
        /// Raised by a stream sink when it completes the transition to the paused state. The transition to
        /// paused occurs when the <see cref="IMFPresentationClock.Pause"/> method is called on the sink's
        /// presentation clock. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/84AB62FC-1525-433C-8AF5-70659122703C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/84AB62FC-1525-433C-8AF5-70659122703C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamSinkPaused = 303,
        /// <summary>
        /// Raised by a stream sink when the rate has changed. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C61C71DE-FD3C-429B-A29F-F9D2BBFCB531(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C61C71DE-FD3C-429B-A29F-F9D2BBFCB531(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamSinkRateChanged = 304,
        /// <summary>
        /// Raised by a stream sink to request a new media sample from the pipeline. For each
        /// MEStreamSinkRequestSample event, the pipeline requests data from the next upstream component.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/35020A15-942F-4DD0-9CA4-815AFFDACECF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/35020A15-942F-4DD0-9CA4-815AFFDACECF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamSinkRequestSample = 305,
        /// <summary>
        /// Raised by a stream sink after the <see cref="IMFStreamSink.PlaceMarker"/> method is called. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>>Any</term><description>The event value is a copy of the <strong>PROPVARIANT</strong> that the caller specified in the <em>pvarContextValue</em> parameter of the <c>PlaceMarker</c> method. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/40F68352-86E5-4864-9CA0-F30998857FEF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/40F68352-86E5-4864-9CA0-F30998857FEF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamSinkMarker = 306,
        /// <summary>
        /// Raised by a stream sink when the stream has received enough pre-roll data to begin rendering. This
        /// event is raised by media sinks that support the <see cref="IMFMediaSinkPreroll"/> interface. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1ECB1805-73CE-4741-B969-6EB88982EE26(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1ECB1805-73CE-4741-B969-6EB88982EE26(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamSinkPrerolled = 307,
        /// <summary>
        /// Raised by a stream sink when it completes a scrubbing request.
        /// <para/>
        /// Scrubbing occurs when the playback rate is zero and the presentation clock is started with a
        /// specified srubbing time. If a media sink supports scrubbing, every stream on the sink raises this
        /// event whenever the <see cref="IMFClockStateSink.OnClockStart"/> method is called while the playback
        /// rate is zero. 
        /// <para/>
        /// If the stream renders data while scrubbing, it sends the event as soon as the data is rendered. If
        /// the stream does not render data, it sends the event immediately after <c>OnClockStart</c> is
        /// called. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// The following attributes are defined for this event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_SCRUBSAMPLE_TIME"/></term><description>Presentation time for which data was rendered. If the media sink does not render data while scrubbing, it does not set this attribute.</description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/451C7E09-868E-4C05-B970-D222B97223F2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/451C7E09-868E-4C05-B970-D222B97223F2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamSinkScrubSampleComplete = 308,
        /// <summary>
        /// Raised by a stream sink when the sink's media type is no longer valid. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9EEB4262-1593-4C5F-9341-EBD328B586E7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9EEB4262-1593-4C5F-9341-EBD328B586E7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamSinkFormatChanged = 309,
        /// <summary>
        /// Raised by the stream sinks of the enhanced video renderer (EVR) if the video device changes. For
        /// example, the EVR raises this event when it receives an <c>EC_DISPLAY_CHANGED</c> event. 
        /// <para/>
        /// The Media Foundation pipeline responds to this event by resubmitting all sample requests that
        /// failed while the device was changing.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5B663D6B-5DF8-4321-A6A5-A21B9810065A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5B663D6B-5DF8-4321-A6A5-A21B9810065A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEStreamSinkDeviceChanged = 310,
        /// <summary>
        /// Provides feedback to the quality manager about playback quality. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_I8</term><description>See Remarks.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1B4B6A2D-411E-42D1-A44B-BB1928E1C063(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1B4B6A2D-411E-42D1-A44B-BB1928E1C063(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEQualityNotify = 311,
        /// <summary>
        /// Raised when a media sink becomes invalid. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// The following attributes are defined for this event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_OUTPUT_NODE"/></term><description>Identifies the topology node for this media sink.</description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FA75926E-7CEF-44DA-9EFE-F2F86FD4FD45(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FA75926E-7CEF-44DA-9EFE-F2F86FD4FD45(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MESinkInvalidated = 312,
        /// <summary>
        /// Raised by the audio renderer when the audio session display name changes. 
        /// <para/>
        /// The Media Session forwards this event to the application.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFAudioPolicy"/> interface. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D180B145-88E1-4F85-B001-B76140CA39D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D180B145-88E1-4F85-B001-B76140CA39D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEAudioSessionNameChanged = 313,
        /// <summary>
        /// Sent by the streaming audio renderer (SAR) when the volume or mute state of the audio session
        /// changes.
        /// <para/>
        /// The Media Session forwards this event to the application.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFAudioPolicy"/> interface. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/63C37BD2-0289-407A-92F1-169EB5D2E02E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/63C37BD2-0289-407A-92F1-169EB5D2E02E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEAudioSessionVolumeChanged = 314,
        /// <summary>
        /// Raised by the audio renderer when the audio device is removed. The audio renderer is now invalid. 
        /// <para/>
        /// The Media Session forwards this event to the application.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFAudioPolicy"/> interface. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A65A3931-E0D6-47AC-B545-9D616E914109(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A65A3931-E0D6-47AC-B545-9D616E914109(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEAudioSessionDeviceRemoved = 315,
        /// <summary>
        /// Raised by the audio renderer when the Windows audio server system is shut down. The audio renderer
        /// is now invalid.
        /// <para/>
        /// The Media Session forwards this event to the application.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFAudioPolicy"/> interface. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8E80903C-D6CE-4FA2-87DB-552C7FBA3C6A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8E80903C-D6CE-4FA2-87DB-552C7FBA3C6A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEAudioSessionServerShutdown = 316,
        /// <summary>
        /// Raised by the audio renderer when the grouping parameters change for the audio session. 
        /// <para/>
        /// The Media Session forwards this event to the application.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFAudioPolicy"/> interface. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D6F7757C-FD91-40BD-B2B5-A3E808445250(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D6F7757C-FD91-40BD-B2B5-A3E808445250(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEAudioSessionGroupingParamChanged = 317,
        /// <summary>
        /// Raised by the audio renderer when the audio session icon changes.
        /// <para/>
        /// The Media Session forwards this event to the application.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFAudioPolicy"/> interface. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/72AAE901-E5FE-481D-BABB-459038ABD629(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/72AAE901-E5FE-481D-BABB-459038ABD629(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEAudioSessionIconChanged = 318,
        /// <summary>
        /// Raised by the audio renderer when the default audio format for the audio device changes. The audio
        /// renderer is now invalid. 
        /// <para/>
        /// The Media Session forwards this event to the application.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFAudioPolicy"/> interface. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EEEF764A-F6D2-4F6E-9AF3-ACD5FD7BC55C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EEEF764A-F6D2-4F6E-9AF3-ACD5FD7BC55C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEAudioSessionFormatChanged = 319,
        /// <summary>
        /// Raised by the audio renderer when the audio session is disconnected from a Windows Terminal
        /// Services (WTS) session. The audio renderer is now invalid. 
        /// <para/>
        /// The Media Session forwards this event to the application.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFAudioPolicy"/> interface. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/08F9844C-F3B1-4D60-990E-9131F3312F6B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/08F9844C-F3B1-4D60-990E-9131F3312F6B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEAudioSessionDisconnected = 320,
        /// <summary>
        /// Raised by the audio renderer when the audio session is preempted by an exclusive-mode connection.
        /// The audio renderer is now invalid. 
        /// <para/>
        /// The Media Session forwards this event to the application.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFAudioPolicy"/> interface. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F89ACFE4-14A7-4051-A816-E5E0BA8DB80A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F89ACFE4-14A7-4051-A816-E5E0BA8DB80A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEAudioSessionExclusiveModeOverride = 321,
        /// <summary>
        /// Internal. Don't use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MESinkV1Anchor = MEAudioSessionExclusiveModeOverride,

        /// <summary>
        /// Sent by an audio capture source when the volume changes.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY </term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4A525D5F-9226-4277-BDB7-174BF65FE320(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4A525D5F-9226-4277-BDB7-174BF65FE320(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MECaptureAudioSessionVolumeChanged = 322,
        /// <summary>
        /// Sent by an audio capture source when the device is removed.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY </term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A249D8B4-15A8-4AD3-8316-2886E5C37825(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A249D8B4-15A8-4AD3-8316-2886E5C37825(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MECaptureAudioSessionDeviceRemoved = 323,
        /// <summary>
        /// Sent by an audio capture source when the audio format changes.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY </term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8197BBAD-8102-43C3-BA61-8DC3BC13B7D6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8197BBAD-8102-43C3-BA61-8DC3BC13B7D6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MECaptureAudioSessionFormatChanged = 324,
        /// <summary>
        /// Sent by an audio capture source when the audio dession is disconnected because the user logged off
        /// from a Windows Terminal Services (WTS) session.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY </term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/88B24E79-FEB8-46AF-9A6C-3FB426089584(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/88B24E79-FEB8-46AF-9A6C-3FB426089584(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MECaptureAudioSessionDisconnected = 325,
        /// <summary>
        /// Sent by an audio capture source when another program opens the audio device in exclusive mode.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY </term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E9CC8507-38AB-4049-8DAC-767EC0ECE270(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E9CC8507-38AB-4049-8DAC-767EC0ECE270(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MECaptureAudioSessionExclusiveModeOverride = 326,
        /// <summary>
        /// Sent by an audio capture source when the capture audio session is disconnected due to the audio
        /// server being shutdown.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY </term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/43284B3E-3018-44F3-8D6C-8C3041DCCD3E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/43284B3E-3018-44F3-8D6C-8C3041DCCD3E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MECaptureAudioSessionServerShutdown = 327,
        /// <summary>
        /// Internal. Don't use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MESinkV2Anchor = MECaptureAudioSessionServerShutdown,

        /// <summary>
        /// Internal. Don't use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        METrustUnknown = 400,
        /// <summary>
        /// Raised by a pipeline component when the output policy for the stream changes. This event applies
        /// only to protected content.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_UNKNOWN</term><description>Pointer to the <see cref="IMFOutputPolicy"/> interface of the new policy for the stream. </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9DC78DC6-3FC2-4A81-AD41-45FF3FDBDADE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9DC78DC6-3FC2-4A81-AD41-45FF3FDBDADE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEPolicyChanged = 401,
        /// <summary>
        /// Raised by a pipeline component when the configuration changes for one of the output protection
        /// schemes. This event applies only to protected content.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0A13FC08-2BBE-46D8-A076-6165CCA6EA36(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0A13FC08-2BBE-46D8-A076-6165CCA6EA36(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEContentProtectionMessage = 402,
        /// <summary>
        /// Raised by an output trust authority (OTA) when the <see cref="IMFOutputTrustAuthority.SetPolicy"/>
        /// method completes asynchronously. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C5D8A88E-2864-45A0-97B7-051341116A4C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C5D8A88E-2864-45A0-97B7-051341116A4C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEPolicySet = 403,
        /// <summary>
        /// Internal. Don't use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        METrustV1Anchor = MEPolicySet,

        /// <summary>
        /// DRM License Backup Completed.
        /// </summary>
        MEWMDRMLicenseBackupCompleted = 500,
        /// <summary>
        /// DRM License Backup Progress.
        /// </summary>
        MEWMDRMLicenseBackupProgress = 501,
        /// <summary>
        /// DRM License Restore Completed.
        /// </summary>
        MEWMDRMLicenseRestoreCompleted = 502,
        /// <summary>
        /// DRM License Restore Progress.
        /// </summary>
        MEWMDRMLicenseRestoreProgress = 503,
        /// <summary>
        /// DRM License Acquisition Completed.
        /// </summary>
        MEWMDRMLicenseAcquisitionCompleted = 506,
        /// <summary>
        /// DRM Individualization Completed.
        /// </summary>
        MEWMDRMIndividualizationCompleted = 508,
        /// <summary>
        /// DRM Individualization Progress.
        /// </summary>
        MEWMDRMIndividualizationProgress = 513,
        /// <summary>
        /// DRM Proximity Completed.
        /// </summary>
        MEWMDRMProximityCompleted = 514,
        /// <summary>
        /// DRM License Store Cleaned.
        /// </summary>
        MEWMDRMLicenseStoreCleaned = 515,
        /// <summary>
        /// DRM Revocation Download Completed.
        /// </summary>
        MEWMDRMRevocationDownloadCompleted = 516,
        /// <summary>
        /// Internal. Don't use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MEWMDRMV1Anchor = MEWMDRMRevocationDownloadCompleted,

        /// <summary>
        /// Internal. Don't use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        METransformUnknown = 600,
        /// <summary>
        /// Sent by an asynchronous Media Foundation transform (MFT) to request a new input sample.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// The following attributes are defined for this event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_MFT_INPUT_STREAM_ID"/></term><description>The identifier of the stream that needs input data.<em>(Required)</em></description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5D5C50D9-FE4E-47FF-AE09-980911EBFB22(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5D5C50D9-FE4E-47FF-AE09-980911EBFB22(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        METransformNeedInput,
        /// <summary>
        /// Sent by an asynchronous Media Foundation transform (MFT) when new output data is available from the
        /// MFT.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// No attributes are defined for this event.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A9403AD3-81BF-4CD7-BA7F-816B901BB02C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A9403AD3-81BF-4CD7-BA7F-816B901BB02C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        METransformHaveOutput,
        /// <summary>
        /// Sent by an asynchronous Media Foundation transform (MFT) when a drain operation is complete.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// The following attributes are defined for this event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_MFT_INPUT_STREAM_ID"/></term><description>The identifier of the stream that was drained.<em>(Required)</em></description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/923055E5-A09A-402E-983B-6FA3CEBB1B3A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/923055E5-A09A-402E-983B-6FA3CEBB1B3A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        METransformDrainComplete,
        /// <summary>
        /// Sent by an asynchronous Media Foundation transform (MFT) in response to an <strong>
        /// MFT_MESSAGE_COMMAND_MARKER</strong> message. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY</term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// <strong>Attributes</strong>
        /// <para/>
        /// The following attributes are defined for this event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_EVENT_MFT_CONTEXT"/></term><description>The value of the <em>ulParam</em> parameter from the <strong>MFT_MESSAGE_COMMAND_MARKER</strong> message. <em>(Required)</em></description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D0C0D62D-9133-4D4B-8606-C2AE1D4C9F0A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D0C0D62D-9133-4D4B-8606-C2AE1D4C9F0A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        METransformMarker,
        /// <summary>
        /// Sent by a byte stream when the characteristics of the byte stream have changed.
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY </term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EC34A7A3-BF01-4F9E-BA79-131B76D4C58F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EC34A7A3-BF01-4F9E-BA79-131B76D4C58F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEByteStreamCharacteristicsChanged = 700,
        /// <summary>
        /// Sent by the <see cref="IMFMediaSource"/> that encapsulates the device to indicate that the device
        /// has been removed. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY </term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/107AFF19-B444-4B62-9217-46A99AC3632C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/107AFF19-B444-4B62-9217-46A99AC3632C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEVideoCaptureDeviceRemoved = 800,
        /// <summary>
        /// Sent by the <see cref="IMFMediaSource"/> that encapsulates the device to indicate that the device
        /// has been preempted. 
        /// <para/>
        /// <strong>Event values</strong>
        /// <para/>
        /// Possible values retrieved from <see cref="IMFMediaEvent.GetValue"/> include the following. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>VARTYPE</term><description>Description</description></listheader>
        /// <item><term>VT_EMPTY </term><description>No event data.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/85EE663C-94B7-47EA-ABBA-A8371342EEB2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/85EE663C-94B7-47EA-ABBA-A8371342EEB2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        MEVideoCaptureDevicePreempted = 801,

        /// <summary>
        /// Sent by a stream sink when the downstream format has become invalidated and it needs to be renegotiated. 
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-gb/library/windows/desktop/dn302107(v=vs.85).aspx">http://msdn.microsoft.com/en-gb/library/windows/desktop/dn302107(v=vs.85).aspx</a>
        /// </remarks>
        MEStreamSinkFormatInvalidated = 802,

        /// <summary>
        /// Sent by the pipeline to encoder MFTs serially with media samples via <see cref="Transform.IMFTransform.ProcessEvent"/>. 
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302106(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302106(v=vs.85).aspx</a>
        /// </remarks>
        MEEncodingParameters = 803,

        /// <summary>
        /// Media Stream uses this event to send protection system specific metadata to the decoder.  
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302078(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302078(v=vs.85).aspx</a>
        /// </remarks>
        MEContentProtectionMetadata = 900,

        /// <summary>
        /// Internal. Don't use.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        MEReservedMax = 10000
    }

}
