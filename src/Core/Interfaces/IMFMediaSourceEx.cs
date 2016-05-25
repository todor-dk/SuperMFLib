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

namespace MediaFoundation.Core.Interfaces
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Extends the <see cref="IMFMediaSource"/> interface to provide additional capabilities for a media
    /// source. 
    /// <para/>
    /// To get a pointer to this interface, call <c>QueryInterface</c> on the media source. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C72C79D5-FD65-4F27-A8C8-B94BF5A9E829(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C72C79D5-FD65-4F27-A8C8-B94BF5A9E829(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown),
    Guid("3C9B2EB9-86D5-4514-A394-F56664F9F0D8")]
    internal interface IMFMediaSourceEx : IMFMediaSource
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
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
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
            IMFAsyncResult pResult,
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

    #region IMFMediaSource methods

        /// <summary>
        /// Retrieves the characteristics of the media source.
        /// </summary>
        /// <param name="pdwCharacteristics">Receives a bitwise <strong>OR</strong> of zero or more flags from the
        /// <see cref="MFMediaSourceCharacteristics" /> enumeration.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media source's <c>Shutdown</c> method has been called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetCharacteristics(
        /// [out]  DWORD *pdwCharacteristics
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/CB5D54CD-58A3-4903-B22E-8207F90DBBC0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CB5D54CD-58A3-4903-B22E-8207F90DBBC0(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int GetCharacteristics(
            out MFMediaSourceCharacteristics pdwCharacteristics
        );

        /// <summary>
        /// Retrieves a copy of the media source's presentation descriptor. Applications use the presentation
        /// descriptor to select streams and to get information about the source content.
        /// </summary>
        /// <param name="ppPresentationDescriptor">Receives a pointer to the presentation descriptor's <see cref="IMFPresentationDescriptor" />
        /// interface. The caller must release the interface.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media source's <c>Shutdown</c> method has been called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT CreatePresentationDescriptor(
        /// [out]  IMFPresentationDescriptor **ppPresentationDescriptor
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/B6AC50B7-3EF1-43CF-8126-D9A003EBD825(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B6AC50B7-3EF1-43CF-8126-D9A003EBD825(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int CreatePresentationDescriptor(
            /* out IMFPresentationDescriptor */ out IntPtr ppPresentationDescriptor);

        /// <summary>
        /// Starts, seeks, or restarts the media source by specifying where to start playback.
        /// </summary>
        /// <param name="pPresentationDescriptor">Pointer to the <see cref="IMFPresentationDescriptor" /> interface of the media source's presentation
        /// descriptor. To get the presentation descriptor, call
        /// <see cref="IMFMediaSource.CreatePresentationDescriptor" />. You can modify the presentation
        /// descriptor before calling <strong>Start</strong>, to select or deselect streams or change the media
        /// types.</param>
        /// <param name="pguidTimeFormat">Pointer to a GUID that specifies the time format. The time format defines the units for the <em>
        /// pvarStartPosition</em> parameter. If the value <em></em> is <strong>GUID_NULL</strong>, the time
        /// format is 100-nanosecond units. Some media sources might support additional time format GUIDs. This
        /// parameter can be <strong>NULL</strong>. If the value is <strong>NULL</strong>, it is equalivent to
        /// <strong>GUID_NULL</strong>.</param>
        /// <param name="pvarStartPosition">Specifies where to start playback. The units of this parameter are indicated by the time format
        /// given in <em>pguidTimeFormat</em>. If the time format is <strong>GUID_NULL</strong>, the variant
        /// type must be <strong>VT_I8</strong> or <strong>VT_EMPTY</strong>. Use <strong>VT_I8</strong> to
        /// specify a new starting position, in 100-nanosecond units. Use <strong>VT_EMPTY</strong> to start
        /// from the current position. Other time formats might use other <strong>PROPVARIANT</strong> types.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description> The method succeeded. </description></item>
        /// <item><term><strong>MF_E_ASF_OUTOFRANGE</strong></term><description> The start position is past the end of the presentation (ASF media source). </description></item>
        /// <item><term><strong>MF_E_HW_MFT_FAILED_START_STREAMING</strong></term><description>A hardware device was unable to start streaming. This error code can be returned by a media source that represents a hardware device, such as a camera. For example, if the camera is already being used by another application, the method might return this error code.</description></item>
        /// <item><term><strong>MF_E_INVALIDREQUEST</strong></term><description> The start request is not valid. For example, the start position is past the end of the presentation. </description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description> The media source's <c>Shutdown</c> method has been called. </description></item>
        /// <item><term><strong>MF_E_UNSUPPORTED_TIME_FORMAT</strong></term><description> The media source does not support the time format specified in <em>pguidTimeFormat</em>. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Start(
        /// [in]  IMFPresentationDescriptor *pPresentationDescriptor,
        /// [in]  const GUID *pguidTimeFormat,
        /// [in]  const PROPVARIANT *pvarStartPosition
        /// );
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/0A5ABAFE-1525-4BDA-946C-05A6145E57EE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0A5ABAFE-1525-4BDA-946C-05A6145E57EE(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int Start(
            [In, MarshalAs(UnmanagedType.Interface)] IMFPresentationDescriptor pPresentationDescriptor,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid pguidTimeFormat,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvarStartPosition
        );

        /// <summary>
        /// Stops all active streams in the media source.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media source's <c>Shutdown</c> method has been called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Stop();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/AA7AF7A0-A6C2-4C9E-9F98-D36716679297(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AA7AF7A0-A6C2-4C9E-9F98-D36716679297(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int Stop();

        /// <summary>
        /// Pauses all active streams in the media source.
        /// </summary>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_INVALID_STATE_TRANSITION</strong></term><description>Invalid state transition. The media source must be in the started state.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The media source's <c>Shutdown</c> method has been called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT Pause();
        /// </code>
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/113B3DC7-918E-427E-AA70-CF474B951C6D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/113B3DC7-918E-427E-AA70-CF474B951C6D(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int Pause();

        /// <summary>
        /// Shuts down the media source and releases the resources it is using.
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
        /// <para />
        /// The above documentation is © Microsoft Corporation. It is reproduced here
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para />
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/C7F890A8-74BD-4418-BB02-A3FEE62DEC6D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C7F890A8-74BD-4418-BB02-A3FEE62DEC6D(v=VS.85,d=hv.2).aspx</a></remarks>
        [PreserveSig]
        new int Shutdown();

    #endregion

        /// <summary>
        /// Gets an attribute store for the media source.
        /// </summary>
        /// <param name="ppAttributes">
        /// Receives a pointer to the <see cref="IMFAttributes"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description>The media source does not support source-level attributes.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetSourceAttributes(
        ///   [out]  IMFAttributes **ppAttributes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A58A2537-1ABD-4EC5-AC84-A5FFA7127CEB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A58A2537-1ABD-4EC5-AC84-A5FFA7127CEB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetSourceAttributes( 
            out IMFAttributes ppAttributes
        );

        /// <summary>
        /// Gets an attribute store for a stream on the media source.
        /// </summary>
        /// <param name="dwStreamIdentifier">
        /// The identifier of the stream. To get the identifier, call 
        /// <see cref="IMFStreamDescriptor.GetStreamIdentifier"/> on the stream descriptor. 
        /// </param>
        /// <param name="ppAttributes">
        /// Receives a pointer to the <see cref="IMFAttributes"/> interface. The caller must release the
        /// interface. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description>The media source does not support stream-level attributes.</description></item>
        /// <item><term><strong>MF_E_INVALIDSTREAMNUMBER</strong></term><description>Invalid stream identifier.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetStreamAttributes(
        ///   [in]   DWORD dwStreamIdentifier,
        ///   [out]  IMFAttributes **ppAttributes
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/360B64E6-4936-4E40-A0EB-7E9EBAF1203E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/360B64E6-4936-4E40-A0EB-7E9EBAF1203E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetStreamAttributes( 
            int dwStreamIdentifier,
            out IMFAttributes ppAttributes
        );

        /// <summary>
        /// Sets a pointer to the Microsoft DirectX Graphics Infrastructure (DXGI) Device Manager on the media
        /// source.
        /// </summary>
        /// <param name="pManager">
        /// A pointer to the <c>IUnknown</c> interface of the DXGI Manager. The media source should query this
        /// pointer for the <see cref="IMFDXGIDeviceManager"/> interface. 
        /// </param>
        /// <returns>
        /// This method can return one of these values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>Success.</description></item>
        /// <item><term><strong>E_NOTIMPL</strong></term><description>The media source does not support source-level attributes.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT SetD3DManager(
        ///   [in]  IUnknown *pManager
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9E956E68-9950-4AA1-BF43-C1DCB02393F7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9E956E68-9950-4AA1-BF43-C1DCB02393F7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int SetD3DManager( 
            [MarshalAs(UnmanagedType.IUnknown)] object pManager
        );
    }

#endif

}
