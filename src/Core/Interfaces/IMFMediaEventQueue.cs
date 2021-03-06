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

namespace MediaFoundation.Core.Interfaces
{
#if NOT_IN_USE

    /// <summary>
    /// Provides an event queue for applications that need to implement the 
    /// <see cref="IMFMediaEventGenerator"/> interface. 
    /// <para/>
    /// This interface is exposed by a helper object that implements an event queue. If you are writing a
    /// component that implements the <see cref="IMFMediaEventGenerator"/> interface, you can use this
    /// object in your implementation. The event queue object is thread safe and provides methods to queue
    /// events and to pull them from the queue either synchronously or asynchronously. To create the event
    /// queue object, call <see cref="Alt.MFExternAlt.MFCreateEventQueue"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E1698CAA-DB70-436D-AF6A-64C6E7247590(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E1698CAA-DB70-436D-AF6A-64C6E7247590(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("36F846FC-2256-48B6-B58E-E2B638316581"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFMediaEventQueue
    {
        /// <summary>
        /// Retrieves the next event in the queue. This method is synchronous.
        /// <para/>
        /// Call this method inside your implementation of <see cref="IMFMediaEventGenerator.GetEvent"/>. Pass
        /// the parameters from that method directly to this method. 
        /// </summary>
        /// <param name="dwFlags">
        /// Specifies whether the method blocks until an event is queued. For a list of valid flags, see 
        /// <see cref="IMFMediaEventGenerator.GetEvent"/>. 
        /// </param>
        /// <param name="ppEvent">
        /// Receives a pointer to the <see cref="IMFMediaEvent"/> interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT GetEvent(
        ///   [in]   DWORD dwFlags,
        ///   [out]  IMFMediaEvent **ppEvent
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B7C48607-F410-47EE-8CC6-38123919DA55(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B7C48607-F410-47EE-8CC6-38123919DA55(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetEvent(
            [In] MFEventFlag dwFlags,
            /* [MarshalAs(UnmanagedType.Interface)] out IMFMediaEvent */ out IntPtr ppEvent);

        /// <summary>
        /// Begins an asynchronous request for the next event in the queue.
        /// <para/>
        /// Call this method inside your implementation of <see cref="IMFMediaEventGenerator.BeginGetEvent"/>.
        /// Pass the parameters from that method directly to this method. 
        /// </summary>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. 
        /// </param>
        /// <param name="pUnkState">The p unk state.</param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT BeginGetEvent(
        ///   [in]  IMFAsyncCallback *pCallback,
        ///   [in]  IUnknown *punkState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/454D4B3B-6251-4B7E-B8F3-FF7CFF5269B5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/454D4B3B-6251-4B7E-B8F3-FF7CFF5269B5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginGetEvent(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnkState
            );

        /// <summary>
        /// Completes an asynchronous request for the next event in the queue.
        /// <para/>
        /// Call this method inside your implementation of <see cref="IMFMediaEventGenerator.EndGetEvent"/>.
        /// Pass the parameters from that method directly to this method. 
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. 
        /// </param>
        /// <param name="ppEvent">
        /// Receives a pointer to the <see cref="IMFMediaEvent"/> interface of the event object. The caller
        /// must release the interface. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT EndGetEvent(
        ///   [in]   IMFAsyncResult *pResult,
        ///   [out]  IMFMediaEvent **ppEvent
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BB0EA226-9DC0-43E3-A482-CFEC531B5734(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BB0EA226-9DC0-43E3-A482-CFEC531B5734(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndGetEvent(
            [In, MarshalAs(UnmanagedType.Interface)] IMFAsyncResult pResult,
            /* out IMFMediaEvent */ out IntPtr ppEvent);

        /// <summary>
        /// Puts an event in the queue.
        /// </summary>
        /// <param name="pEvent">
        /// Pointer to the <see cref="IMFMediaEvent"/> interface of the event to be put in the queue. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT QueueEvent(
        ///   [in]  IMFMediaEvent *pEvent
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EB04CE9F-FB64-438F-AD4D-BA1FB849D59C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EB04CE9F-FB64-438F-AD4D-BA1FB849D59C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int QueueEvent(
            [In, MarshalAs(UnmanagedType.Interface)] IMFMediaEvent pEvent
            );

        /// <summary>
        /// Creates an event, sets a <strong>PROPVARIANT</strong> as the event data, and puts the event in the
        /// queue. 
        /// <para/>
        /// Call this method inside your implementation of <see cref="IMFMediaEventGenerator.QueueEvent"/>.
        /// Pass the parameters from that method directly to this method. 
        /// <para/>
        /// You can also call this method when your component needs to raise an event that does not contain
        /// attributes. If the event data is an <strong>IUnknown</strong> pointer, you can use 
        /// <see cref="IMFMediaEventQueue.QueueEventParamUnk"/>. If the event contains attributes, use 
        /// <see cref="IMFMediaEventQueue.QueueEvent"/> instead. 
        /// </summary>
        /// <param name="met">
        /// Specifies the type of the event to be added to the queue. The event type is returned by the event's
        /// <see cref="IMFMediaEvent.GetType"/> method. For a list of event types, see 
        /// <c>Media Foundation Events</c>. 
        /// </param>
        /// <param name="guidExtendedType">
        /// The extended type of the event. If the event does not have an extended type, use the value
        /// GUID_NULL. The extended type is returned by the event's <see cref="IMFMediaEvent.GetExtendedType"/>
        /// method. 
        /// </param>
        /// <param name="hrStatus">
        /// A success or failure code indicating the status of the event. This value is returned by the event's
        /// <see cref="IMFMediaEvent.GetStatus"/> method. 
        /// </param>
        /// <param name="pvValue">
        /// Pointer to a <strong>PROPVARIANT</strong> that contains the event value. This parameter can be 
        /// <strong>NULL</strong>. This value is returned by the event's <see cref="IMFMediaEvent.GetValue"/>
        /// method. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT QueueEventParamVar(
        ///   [in]  MediaEventType met,
        ///   [in]  REFGUID guidExtendedType,
        ///   [in]  HRESULT hrStatus,
        ///   [in]  const PROPVARIANT *pvValue
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E2BAFECA-76E7-4DF4-94A7-86AEF04F3A35(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E2BAFECA-76E7-4DF4-94A7-86AEF04F3A35(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int QueueEventParamVar(
            [In] MediaEventType met,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidExtendedType,
            [In, MarshalAs(UnmanagedType.Error)] int hrStatus,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvValue
            );

        /// <summary>
        /// Creates an event, sets an <strong>IUnknown</strong> pointer as the event data, and puts the event
        /// in the queue. 
        /// </summary>
        /// <param name="met">
        /// Specifies the event type of the event to be added to the queue. The event type is returned by the
        /// event's <see cref="IMFMediaEvent.GetType"/> method. For a list of event types, see 
        /// <c>Media Foundation Events</c>. 
        /// </param>
        /// <param name="guidExtendedType">
        /// The extended type of the event. If the event does not have an extended type, use the value
        /// GUID_NULL. The extended type is returned by the event's <see cref="IMFMediaEvent.GetExtendedType"/>
        /// method. 
        /// </param>
        /// <param name="hrStatus">
        /// A success or failure code indicating the status of the event. This value is returned by the event's
        /// <see cref="IMFMediaEvent.GetStatus"/> method. 
        /// </param>
        /// <param name="pUnk">
        /// Pointer to the <strong>IUnknown</strong> interface. The method sets this pointer as the event
        /// value. The pointer is returned by the event's <see cref="IMFMediaEvent.GetValue"/> method. 
        /// </param>
        /// <returns>
        /// The method returns an <strong>HRESULT</strong>. Possible values include, but are not limited to,
        /// those in the following table. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Return code</term><description>Description</description></listheader>
        /// <item><term><strong>S_OK</strong></term><description>The method succeeded.</description></item>
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The <c>Shutdown</c> method was called. </description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT QueueEventParamUnk(
        ///   [in]  MediaEventType met,
        ///   [in]  REFGUID guidExtendedType,
        ///   [in]  HRESULT hrStatus,
        ///   [in]  IUnknown *pUnk
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E51653A4-8F71-44F3-90E8-2052DB521307(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E51653A4-8F71-44F3-90E8-2052DB521307(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int QueueEventParamUnk(
            [In] MediaEventType met,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidExtendedType,
            [In, MarshalAs(UnmanagedType.Error)] int hrStatus,
            [In, MarshalAs(UnmanagedType.IUnknown)] object pUnk
            );

        /// <summary>
        /// Shuts down the event queue.
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
        /// <a href="http://msdn.microsoft.com/en-US/library/6EC52973-0D90-463B-B2BE-08D5D6FDCC05(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6EC52973-0D90-463B-B2BE-08D5D6FDCC05(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int Shutdown();
    }

#endif
}
