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
using System.Runtime.InteropServices.ComTypes;

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation
{


    /// <summary>
    /// Provides playback controls for protected and unprotected content. The Media Session and the
    /// protected media path (PMP) session objects expose this interface. This interface is the primary
    /// interface that applications use to control the Media Foundation pipeline.
    /// <para/>
    /// To obtain a pointer to this interface, call <see cref="MFExtern.MFCreateMediaSession"/> or 
    /// <see cref="MFExtern.MFCreatePMPMediaSession"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FEEBF891-73FA-4FE6-94CA-3594986FC92D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FEEBF891-73FA-4FE6-94CA-3594986FC92D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("90377834-21D0-4DEE-8214-BA2E3E6C1127"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMFMediaSession : IMFMediaEventGenerator
    {
        #region IMFMediaEventGenerator methods

        /// <summary>
        /// Retrieves the next event in the queue. This method is synchronous.
        /// </summary>
        /// <param name="dwFlags">Specifies one of the following values.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term><strong>0</strong></term><description>The method blocks until the event generator queues an event.</description></item><item><term><strong>MF_EVENT_FLAG_NO_WAIT</strong></term><description>The method returns immediately.</description></item></list></param>
        /// <param name="ppEvent">Receives a pointer to the <see cref="IMFMediaEvent" /> interface. The caller must release the
        /// interface.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description>NULL pointer argument.</description></item>
        /// <item><term><strong>MF_E_MULTIPLE_SUBSCRIBERS</strong></term><description>There is a pending request.</description></item>
        /// <item><term><strong>MF_E_NO_EVENTS_AVAILABLE</strong></term><description>There are no events in the queue.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The object was shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetEvent(
        /// [in]   DWORD dwFlags,
        /// [out]  IMFMediaEvent **ppEvent
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/E78464B5-EC6B-4739-A135-352FA297916A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E78464B5-EC6B-4739-A135-352FA297916A(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetEvent(
            [In] MFEventFlag dwFlags,
            [MarshalAs(UnmanagedType.Interface)] out IMFMediaEvent ppEvent
            );

        /// <summary>
        /// Begins an asynchronous request for the next event in the queue.
        /// </summary>
        /// <param name="pCallback">Pointer to the <see cref="IMFAsyncCallback" /> interface of a callback object. The client must
        /// implement this interface.</param>
        /// <param name="o">The o.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_INVALIDARG</strong></term><description><strong>NULL</strong> pointer argument. </description></item>
        /// <item><term><strong>MF_E_MULTIPLE_BEGIN</strong></term><description>There is a pending request with the same callback pointer and a different state object.</description></item>
        /// <item><term><strong>MF_E_MULTIPLE_SUBSCRIBERS</strong></term><description>There is a pending request with a different callback pointer.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The object was shut down.</description></item>
        /// <item><term><strong>MF_S_MULTIPLE_BEGIN</strong></term><description>There is a pending request with the same callback pointer and state object.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginGetEvent(
        /// [in]  IMFAsyncCallback *pCallback,
        /// [in]  IUnknown *punkState
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/A2AFDDAC-46E9-4928-8B5B-44F3FC7C33D3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A2AFDDAC-46E9-4928-8B5B-44F3FC7C33D3(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int BeginGetEvent(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object o);

        /// <summary>
        /// Completes an asynchronous request for the next event in the queue.
        /// </summary>
        /// <param name="pResult">Pointer to the <see cref="IMFAsyncResult" /> interface. Pass in the same pointer that your callback
        /// object received in the <c>Invoke</c> method.</param>
        /// <param name="ppEvent">Receives a pointer to the <see cref="IMFMediaEvent" /> interface. The caller must release the
        /// interface.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The object was shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EndGetEvent(
        /// [in]   IMFAsyncResult *pResult,
        /// [out]  IMFMediaEvent **ppEvent
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/6B38E984-D818-4F69-AF28-8B54153FAEBB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6B38E984-D818-4F69-AF28-8B54153FAEBB(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int EndGetEvent(
            IMFAsyncResult pResult,
            out IMFMediaEvent ppEvent);


        /// <summary>
        /// Puts a new event in the object's queue.
        /// </summary>
        /// <param name="met">Specifies the event type. The event type is returned by the event's
        /// <see cref="IMFMediaEvent.GetType" /> method. For a list of event types, see
        /// <c>Media Foundation Events</c>.</param>
        /// <param name="guidExtendedType">The extended type. If the event does not have an extended type, use the value GUID_NULL. The
        /// extended type is returned by the event's <see cref="IMFMediaEvent.GetExtendedType" /> method.</param>
        /// <param name="hrStatus">A success or failure code indicating the status of the event. This value is returned by the event's
        /// <see cref="IMFMediaEvent.GetStatus" /> method.</param>
        /// <param name="pvValue">Pointer to a <strong>PROPVARIANT</strong> that contains the event value. This parameter can be
        /// <strong>NULL</strong>. This value is returned by the event's <see cref="IMFMediaEvent.GetValue" />
        /// method.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The object was shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT QueueEvent(
        /// [in]  MediaEventType met,
        /// [in]  REFGUID guidExtendedType,
        /// [in]  HRESULT hrStatus,
        /// [in]  const PROPVARIANT *pvValue
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/3BC33665-1385-41E1-9AD0-991FC93E91C0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3BC33665-1385-41E1-9AD0-991FC93E91C0(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int QueueEvent(
            [In] MediaEventType met,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidExtendedType,
            [In] int hrStatus,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvValue
            );

        #endregion

        /// <summary>
        /// Sets a topology on the Media Session. 
        /// </summary>
        /// <param name="dwSetTopologyFlags">
        /// Bitwise <strong>OR</strong> of zero or more flags from the <see cref="MFSessionSetTopologyFlags"/>
        /// enumeration. 
        /// </param>
        /// <param name="pTopology">
        /// Pointer to the topology object's <see cref="IMFTopology"/> interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description> The operation cannot be performed in the Media Session's current state. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description> The Media Session has been shut down. </description></item>
        /// <item><term><strong>MF_E_TOPO_INVALID_TIME_ATTRIBUTES</strong></term><description>The topology has invalid values for one or more of the following attributes:<para>* <see cref="MFAttributesClsid.MF_TOPONODE_MEDIASTART"/></para><para>* <see cref="MFAttributesClsid.MF_TOPONODE_MEDIASTOP"/></para><para>* <see cref="MFAttributesClsid.MF_TOPOLOGY_PROJECTSTART"/></para><para>* <see cref="MFAttributesClsid.MF_TOPOLOGY_PROJECTSTOP"/></para></description></item>
        /// <item><term><strong>NS_E_DRM_DEBUGGING_NOT_ALLOWED</strong></term><description> Protected content cannot be played while debugging. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetTopology(
        ///   [in]  DWORD dwSetTopologyFlags,
        ///   [in]  IMFTopology *pTopology
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EA5313F0-B0FD-4945-97A2-B3F17937294F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EA5313F0-B0FD-4945-97A2-B3F17937294F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetTopology(
            [In] MFSessionSetTopologyFlags dwSetTopologyFlags,
            [In, MarshalAs(UnmanagedType.Interface)] IMFTopology pTopology
            );

        /// <summary>
        /// Clears all of the presentations that are queued for playback in the Media Session.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description> The operation cannot be performed in the Media Session's current state. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description> The Media Session has been shut down. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ClearTopologies();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FCB7E5F1-1095-4766-AFED-43AD2279ABB4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FCB7E5F1-1095-4766-AFED-43AD2279ABB4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ClearTopologies();

        /// <summary>
        /// Starts the Media Session. 
        /// </summary>
        /// <param name="pguidTimeFormat">
        /// Pointer to a GUID that specifies the time format for the <em>pvarStartPosition</em> parameter. This
        /// parameter can be <strong>NULL</strong>. The value <strong>NULL</strong> is equivalent to passing in
        /// <strong>GUID_NULL</strong>. 
        /// <para/>
        /// The following time format GUIDs are defined:
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>GUID_NULL</strong></term><description>Presentation time. The <em>pvarStartPosition</em> parameter must have one of the following <strong>PROPVARIANT</strong> types. <para>* <strong>VT_I8</strong>: The <em>pvarStartPosition</em> parameter contains the starting position in 100-nanosecond units, relative to the start of the presentation. </para><para>* <strong>VT_EMPTY</strong>: Playback starts from the current position. </para>All media sources support this time format.</description></item>
        /// <item><term><strong>MF_TIME_FORMAT_SEGMENT_OFFSET</strong></term><description>Segment offset. This time format is supported by the <c>Sequencer Source</c>. The starting time is an offset within a segment. Call the <see cref="MFExtern.MFCreateSequencerSegmentOffset"/> function to create the <strong>PROPVARIANT</strong> value for the <em>pvarStartPosition</em> parameter. </description></item>
        /// <item><term><strong>MF_TIME_FORMAT_ENTRY_RELATIVE</strong></term><description><strong>Note</strong> Requires Windows 7 or later. Skip to a playlist entry. The <em>pvarStartPosition</em> parameter specifies the index of the playlist entry, relative to the current entry. For example, the value 2 skips forward two entries. To skip backward, pass a negative value. The <strong>PROPVARIANT</strong> type is <strong>VT_I4</strong>. If a media source supports this time format, the <see cref="IMFMediaSource.GetCharacteristics"/> method returns one or both of the following flags: <para>* <strong>MFMEDIASOURCE_CAN_SKIPFORWARD</strong></para><para>* <strong>MFMEDIASOURCE_CAN_SKIPBACKWARD</strong></para></description></item>
        /// </list>
        /// </param>
        /// <param name="pvarStartPosition">
        /// Pointer to a <strong>PROPVARIANT</strong> that specifies the starting position for playback. The
        /// meaning and data type of this parameter are indicated by the <em>pguidTimeFormat</em> parameter. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description> The operation cannot be performed in the Media Session's current state. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description> The Media Session has been shut down. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Start(
        ///   [in]  const GUID *pguidTimeFormat,
        ///   [in]  const PROPVARIANT *pvarStartPosition
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1BDEC0C0-B042-4E5E-A72B-B15942750CED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1BDEC0C0-B042-4E5E-A72B-B15942750CED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Start(
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid pguidTimeFormat,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvarStartPosition
            );

        /// <summary>
        /// Pauses the Media Session.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The operation cannot be performed in the Media Session's current state.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The Media Session has been shut down.</description></item>
        /// <item><term><strong>MF_E_SESSION_PAUSEWHILESTOPPED</strong></term><description>The Media Session cannot pause while stopped.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Pause();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FCC576BA-F8BE-4106-A270-756B2ABF52D4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FCC576BA-F8BE-4106-A270-756B2ABF52D4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Pause();

        /// <summary>
        /// Stops the Media Session.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The operation cannot be performed in the Media Session's current state.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The Media Session has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Stop();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9CC769CC-24EF-4790-A10E-4AEC8FB4FC1F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9CC769CC-24EF-4790-A10E-4AEC8FB4FC1F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Stop();

        /// <summary>
        /// Closes the Media Session and releases all of the resources it is using.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The Media Session has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Close();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6ED118AE-7538-4EF6-81FC-B762F709838F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6ED118AE-7538-4EF6-81FC-B762F709838F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Close();

        /// <summary>
        /// Shuts down the Media Session and releases all the resources used by the Media Session.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Shutdown();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5B9663C2-E32E-4075-B397-59AE01558E15(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5B9663C2-E32E-4075-B397-59AE01558E15(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Shutdown();

        /// <summary>
        /// Retrieves the Media Session's presentation clock.
        /// </summary>
        /// <param name="ppClock">
        /// Receives a pointer to the presentation clock's <see cref="IMFClock"/> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an HRESULT. Possible values include, but are not limited to, those in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_UNEXPECTED</strong></term><description>The Media Session does not have a presentation clock.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The Media Session has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetClock(
        ///   [out]  IMFClock **ppClock
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/16444DA2-68F2-4D94-8C6F-9E512D51E5E9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/16444DA2-68F2-4D94-8C6F-9E512D51E5E9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetClock(
            [MarshalAs(UnmanagedType.Interface)] out IMFClock ppClock
            );

        /// <summary>
        /// Retrieves the capabilities of the Media Session, based on the current presentation.
        /// </summary>
        /// <param name="pdwCaps">
        /// Receives a bitwise <strong>OR</strong> of zero or more of the following flags. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>MFSESSIONCAP_PAUSE</strong></term><description>The Media Session can be paused.</description></item>
        /// <item><term><strong>MFSESSIONCAP_RATE_FORWARD</strong></term><description>The Media Session supports forward playback at rates faster than 1.0.</description></item>
        /// <item><term><strong>MFSESSIONCAP_RATE_REVERSE</strong></term><description>The Media Session supports reverse playback.</description></item>
        /// <item><term><strong>MFSESSIONCAP_SEEK</strong></term><description>The Media Session can be seeked.</description></item>
        /// <item><term><strong>MFSESSIONCAP_START</strong></term><description>The Media Session can be started.</description></item>
        /// </list>
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>E_POINTER</strong></term><description>NULL pointer argument.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The Media Session has been shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetSessionCapabilities(
        ///   [out]  DWORD *pdwCaps
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3534CFB9-23FF-42A6-A3DB-B5032D427CF2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3534CFB9-23FF-42A6-A3DB-B5032D427CF2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetSessionCapabilities(
            out MFSessionCapabilities pdwCaps
            );

        /// <summary>
        /// Gets a topology from the Media Session.
        /// <para/>
        /// This method can get the current topology or a queued topology.
        /// </summary>
        /// <param name="dwGetFullTopologyFlags">
        /// Bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="MFSessionGetFullTopologyFlags"/> enumeration. 
        /// </param>
        /// <param name="TopoId">
        /// The identifier of the topology. This parameter is ignored if the <em>dwGetFullTopologyFlags</em>
        /// parameter contains the <strong>MFSESSION_GETFULLTOPOLOGY_CURRENT</strong> flag. To get the
        /// identifier of a topology, call <see cref="IMFTopology.GetTopologyID"/>. 
        /// </param>
        /// <param name="ppFullTopology">The pp full topology.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description> The Media Session has been shut down. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetFullTopology(
        ///   [in]   DWORD dwGetFullTopologyFlags,
        ///   [in]   TOPOID TopoId,
        ///   [out]  IMFTopology **ppFullTopo
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6899DBE2-A684-487F-AB56-8631B3D5A033(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6899DBE2-A684-487F-AB56-8631B3D5A033(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetFullTopology(
            [In] MFSessionGetFullTopologyFlags dwGetFullTopologyFlags,
            [In] long TopoId,
            [MarshalAs(UnmanagedType.Interface)] out IMFTopology ppFullTopology
            );
    }

}
