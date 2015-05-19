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

// This entire file only exists to work around bugs in Media Foundation.  The core problem 
// is that there are some objects in MF that don't correctly support QueryInterface.  In c++ 
// this isn't a problem, since if you tell c++ that something is a pointer to an interface, 
// it just believes you.  In fact, that's one of the places where c++ gets its performance:
// it doesn't check anything.

// In .Net, it checks.  And the way it checks is that every time it receives an interfaces
// from unmanaged code, it does a couple of QI calls on it.  First it does a QI for IUnknown.
// Second it does a QI for the specific interface it is supposed to be (ie IMFMediaSink or
// whatever).

// Since c++ *doesn't* check, oftentimes the first people to even try to call QI on some of 
// MF's objects are c# programmers.  And, not surprisingly, sometimes the first time code is 
// run, it doesn't work correctly.

// The only way you can work around it is to change the definition of the method from 
// IMFMediaSink (or whatever interface MF is trying to pass you) to IntPtr.  Of course, 
// that limits what you can do with it.  You can't call methods on an IntPtr.

// Something to keep in mind is that while the work-around involves changing the interface,
// the problem isn't in the interface, it is in the object that implements the inteface.
// This means that while the inteface may experience problems on one object, it may work
// correctly on another object.  If you are unclear on the differences between an interface
// and an object, it's time to hit the books.

// In W7, MS has fixed a few of these issues that were reported in Vista.  The problem 
// is that even if they are fixed in W7, if your program also needs to run on Vista, you 
// still have to use the work-arounds.

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Security;

using MediaFoundation.Misc;
using MediaFoundation.EVR;

namespace MediaFoundation.Alt
{
#if NOT_IN_USE
    #region Bugs in Vista that appear to be fixed in W7

    /// <summary>
    /// Represents a stream on a media sink object.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FE403CAB-B901-4C8E-A23C-788EE65C4689(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FE403CAB-B901-4C8E-A23C-788EE65C4689(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("0A97B3CF-8E7C-4A3D-8F8C-0C843DC247FB"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFStreamSinkAlt : IMFMediaEventGeneratorAlt
    {
        #region IMFMediaEventGeneratorAlt methods

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
            /* [MarshalAs(UnmanagedType.Interface)] out IMFMediaEvent */ out IntPtr ppEvent);

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
            //[In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            IntPtr pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object o
            );

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
            //IMFAsyncResult pResult,
            IntPtr pResult,
            /* out IMFMediaEvent */ out IntPtr ppEvent);

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
        /// Retrieves the media sink that owns this stream sink.
        /// </summary>
        /// <param name="ppMediaSink">
        /// Receives a pointer to the media sink's <see cref="IMFMediaSink"/> interface. The caller must
        /// release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media sink's <c>Shutdown</c> method has been called. </description></item>
        /// <item><term><strong>MF_E_STREAMSINK_REMOVED</strong></term><description>This stream was removed from the media sink and is no longer valid.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetMediaSink(
        ///   [out]  IMFMediaSink **ppMediaSink
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/799FB0CE-6A43-49C2-97CF-49C51D8F69CD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/799FB0CE-6A43-49C2-97CF-49C51D8F69CD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMediaSink(
            [MarshalAs(UnmanagedType.Interface)] out IMFMediaSinkAlt ppMediaSink
            );

        /// <summary>
        /// Retrieves the stream identifier for this stream sink.
        /// </summary>
        /// <param name="pdwIdentifier">
        /// Receives the stream identifier. If this stream sink was added by calling 
        /// <see cref="IMFMediaSink.AddStreamSink"/>, the stream identifier is in the <em>
        /// dwStreamSinkIdentifier</em> parameter of that method. Otherwise, the media sink defines the
        /// identifier. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media sink's <c>Shutdown</c> method has been called. </description></item>
        /// <item><term><strong>MF_E_STREAMSINK_REMOVED</strong></term><description>This stream was removed from the media sink and is no longer valid.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetIdentifier(
        ///   [out]  DWORD *pdwIdentifier
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AF4855F6-36FA-4949-8B93-9E630A12E71B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AF4855F6-36FA-4949-8B93-9E630A12E71B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetIdentifier(
            out int pdwIdentifier
            );

        /// <summary>
        /// Retrieves the media type handler for the stream sink. You can use the media type handler to find
        /// which formats the stream supports, and to set the media type on the stream.
        /// </summary>
        /// <param name="ppHandler">
        /// Receives a pointer to the <see cref="IMFMediaTypeHandler"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media sink's <c>Shutdown</c> method has been called. </description></item>
        /// <item><term><strong>MF_E_STREAMSINK_REMOVED</strong></term><description>This stream was removed from the media sink and is no longer valid.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetMediaTypeHandler(
        ///   [out]  IMFMediaTypeHandler **ppHandler
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/819D06B1-6B52-4496-BED8-A08B8F0B6153(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/819D06B1-6B52-4496-BED8-A08B8F0B6153(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetMediaTypeHandler(
            [MarshalAs(UnmanagedType.Interface)] out IMFMediaTypeHandler ppHandler
            );

        /// <summary>
        /// Delivers a sample to the stream. The media sink processes the sample.
        /// </summary>
        /// <param name="pSample">
        /// Pointer to the <see cref="IMFSample"/> interface of a sample that contains valid data for the
        /// stream. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALID_STATE_TRANSITION</strong></term><description>The media sink is in the wrong state to receive a sample. For example, preroll is complete but the presenation clock has not started yet.</description></item>
        /// <item><term><strong>MF_E_INVALID_TIMESTAMP</strong></term><description>The sample has an invalid time stamp. See Remarks.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description>The media sink is paused or stopped and cannot process the sample.</description></item>
        /// <item><term><strong>MF_E_NO_CLOCK</strong></term><description>The presentation clock was not set. Call <see cref="IMFMediaSink.SetPresentationClock"/>. </description></item>
        /// <item><term><strong>MF_E_NO_SAMPLE_TIMESTAMP</strong></term><description>The sample does not have a time stamp.</description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>The stream sink has not been initialized.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media sink's <c>Shutdown</c> method has been called. </description></item>
        /// <item><term><strong>MF_E_STREAMSINK_REMOVED</strong></term><description>This stream was removed from the media sink and is no longer valid.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT ProcessSample(
        ///   [in]  IMFSample *pSample
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/30E2BDB5-A99D-4A2E-AB36-7B4E383C645F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/30E2BDB5-A99D-4A2E-AB36-7B4E383C645F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int ProcessSample(
            [In, MarshalAs(UnmanagedType.Interface)] IMFSample pSample
            );

        /// <summary>
        /// Places a marker in the stream. 
        /// </summary>
        /// <param name="eMarkerType">
        /// Specifies the marker type, as a member of the <see cref="MFStreamSinkMarkerType"/> enumeration. 
        /// </param>
        /// <param name="pvarMarkerValue">
        /// Optional pointer to a <strong>PROPVARIANT</strong> that contains additional information related to
        /// the marker. The meaning of this value depends on the marker type. This parameter can be <strong>
        /// NULL</strong>. 
        /// </param>
        /// <param name="pvarContextValue">
        /// Optional pointer to a <strong>PROPVARIANT</strong> that is attached to the 
        /// <c>MEStreamSinkMarker</c> event. Call <see cref="IMFMediaEvent.GetValue"/> to get this value from
        /// the event. The caller can use this information for any purpose. This parameter can be <strong>NULL
        /// </strong>. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong><strong>S_OK</strong></strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong><strong>MF_E_SHUTDOWN</strong></strong></term><description> The media sink's <c>Shutdown</c> method has been called. </description></item>
        /// <item><term><strong><strong>MF_E_STREAMSINK_REMOVED</strong></strong></term><description> This stream was removed from the media sink and is no longer valid. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT PlaceMarker(
        ///   [in]  MFSTREAMSINK_MARKER_TYPE eMarkerType,
        ///   [in]  const PROPVARIANT *pvarMarkerValue,
        ///   [in]  const PROPVARIANT *pvarContextValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BFA4FB12-59B2-4599-B8FF-DC38750A5A79(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BFA4FB12-59B2-4599-B8FF-DC38750A5A79(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int PlaceMarker(
            [In] MFStreamSinkMarkerType eMarkerType,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvarMarkerValue,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvarContextValue
            );

        /// <summary>
        /// Causes the stream sink to drop any samples that it has received and has not rendered yet.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_NOT_INITIALIZED</strong></term><description>The stream sink has not been initialized yet. You might need to set a media type.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media sink's <c>Shutdown</c> method has been called. </description></item>
        /// <item><term><strong>MF_E_STREAMSINK_REMOVED</strong></term><description>This stream was removed from the media sink and is no longer valid.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Flush();
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/514D29BD-571D-46B1-9948-5D623C6703AA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/514D29BD-571D-46B1-9948-5D623C6703AA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Flush();
    }

    #endregion
#endif
}
