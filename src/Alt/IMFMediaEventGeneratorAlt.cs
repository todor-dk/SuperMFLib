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
    /// Retrieves events from any Media Foundation object that generates events. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A37D0840-C896-43A0-B3D1-C2A6AAFF1B25(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A37D0840-C896-43A0-B3D1-C2A6AAFF1B25(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [ComImport, System.Security.SuppressUnmanagedCodeSecurity,
    Guid("2CD0BD52-BCD5-4B89-B62C-EADC0C031E7D"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    internal interface IMFMediaEventGeneratorAlt
    {
        /// <summary>
        /// Retrieves the next event in the queue. This method is synchronous.
        /// </summary>
        /// <param name="dwFlags">
        /// Specifies one of the following values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>0</strong></term><description>The method blocks until the event generator queues an event.</description></item>
        /// <item><term><strong>MF_EVENT_FLAG_NO_WAIT</strong></term><description>The method returns immediately.</description></item>
        /// </list>
        /// </param>
        /// <param name="ppEvent">
        /// Receives a pointer to the <see cref="IMFMediaEvent"/> interface. The caller must release the
        /// interface. 
        /// </param>
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
        ///   [in]   DWORD dwFlags,
        ///   [out]  IMFMediaEvent **ppEvent
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E78464B5-EC6B-4739-A135-352FA297916A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E78464B5-EC6B-4739-A135-352FA297916A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int GetEvent(
            [In] MFEventFlag dwFlags,
            /* [MarshalAs(UnmanagedType.Interface)] out IMFMediaEvent */ out IntPtr ppEvent);

        /// <summary>
        /// Begins an asynchronous request for the next event in the queue.
        /// </summary>
        /// <param name="pCallback">
        /// Pointer to the <see cref="IMFAsyncCallback"/> interface of a callback object. The client must
        /// implement this interface. 
        /// </param>
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
        ///   [in]  IMFAsyncCallback *pCallback,
        ///   [in]  IUnknown *punkState
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A2AFDDAC-46E9-4928-8B5B-44F3FC7C33D3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A2AFDDAC-46E9-4928-8B5B-44F3FC7C33D3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int BeginGetEvent(
            //[In, MarshalAs(UnmanagedType.Interface)] IMFAsyncCallback pCallback,
            IntPtr pCallback,
            [In, MarshalAs(UnmanagedType.IUnknown)] object o
            );

        /// <summary>
        /// Completes an asynchronous request for the next event in the queue.
        /// </summary>
        /// <param name="pResult">
        /// Pointer to the <see cref="IMFAsyncResult"/> interface. Pass in the same pointer that your callback
        /// object received in the <c>Invoke</c> method. 
        /// </param>
        /// <param name="ppEvent">
        /// Receives a pointer to the <see cref="IMFMediaEvent"/> interface. The caller must release the
        /// interface. 
        /// </param>
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
        ///   [in]   IMFAsyncResult *pResult,
        ///   [out]  IMFMediaEvent **ppEvent
        /// );
        /// </code>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6B38E984-D818-4F69-AF28-8B54153FAEBB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6B38E984-D818-4F69-AF28-8B54153FAEBB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int EndGetEvent(
            //IMFAsyncResult pResult,
            IntPtr pResult,
            /* out IMFMediaEvent */ out IntPtr ppEvent);

        /// <summary>
        /// Puts a new event in the object's queue.
        /// </summary>
        /// <param name="met">
        /// Specifies the event type. The event type is returned by the event's 
        /// <see cref="IMFMediaEvent.GetType"/> method. For a list of event types, see 
        /// <c>Media Foundation Events</c>. 
        /// </param>
        /// <param name="guidExtendedType">
        /// The extended type. If the event does not have an extended type, use the value GUID_NULL. The
        /// extended type is returned by the event's <see cref="IMFMediaEvent.GetExtendedType"/> method. 
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
        /// <item><term><strong>MF_E_SHUTDOWN</strong></term><description>The object was shut down.</description></item>
        /// </list>
        /// </returns>
        /// <remarks>
        /// <code language="cpp" title="C/C++ Syntax">
        /// HRESULT QueueEvent(
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
        /// <a href="http://msdn.microsoft.com/en-US/library/3BC33665-1385-41E1-9AD0-991FC93E91C0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3BC33665-1385-41E1-9AD0-991FC93E91C0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        int QueueEvent(
            [In] MediaEventType met,
            [In, MarshalAs(UnmanagedType.LPStruct)] Guid guidExtendedType,
            [In] int hrStatus,
            [In, MarshalAs(UnmanagedType.LPStruct)] ConstPropVariant pvValue
            );
    }

    #endregion
#endif
}
