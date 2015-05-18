using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEventGenerator"/> class implements a wrapper around the
    /// <see cref="IMFMediaEventGenerator"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEventGenerator"/>
    /// interface's methods.
    /// </summary>
    public abstract class MediaEventGenerator<TInterface> : COM<TInterface>
        where TInterface : class, IMFMediaEventGenerator
    {
        #region Construction

        internal MediaEventGenerator(TInterface comInterface)
            : base(comInterface)
        {
        }

        #endregion

        /// <summary>
        /// Retrieves the next event in the queue. This method is synchronous.
        /// </summary>
        /// <param name="flags">Optional flags controlling the execution of the method.</param>
        /// <returns>A <see cref="MediaEvent"/> object. The caller must dispose the object.</returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E78464B5-EC6B-4739-A135-352FA297916A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E78464B5-EC6B-4739-A135-352FA297916A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaEvent GetEvent(MFEventFlag flags)
        {
            IMFMediaEvent ppEvent;
            int hr = this.Interface.GetEvent(flags, out ppEvent);
            COM.ThrowIfNotOK(hr);
            return ppEvent.ToMediaEvent();
        }

        /// <summary>
        /// Begins an asynchronous request for the next event in the queue.
        /// </summary>
        /// <param name="callback">
        /// The <see cref="AsyncCallback"/> callback object. The client must implement this interface. 
        /// </param>
        /// <param name="state">
        /// A state object, defined by the caller. This parameter can be NULL. 
        /// You can use this object to hold state information. 
        /// The object is returned to the caller when the callback is invoked.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A2AFDDAC-46E9-4928-8B5B-44F3FC7C33D3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A2AFDDAC-46E9-4928-8B5B-44F3FC7C33D3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void BeginGetEvent(AsyncCallback callback, object state)
        {
            int hr = this.Interface.BeginGetEvent(callback, state);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Begins an asynchronous request for the next event in the queue.
        /// </summary>
        /// <param name="callback">
        /// The <see cref="AsyncCallback"/> callback object. The client must implement this interface. 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A2AFDDAC-46E9-4928-8B5B-44F3FC7C33D3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A2AFDDAC-46E9-4928-8B5B-44F3FC7C33D3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void BeginGetEvent(AsyncCallback callback)
        {
            this.BeginGetEvent(callback, null);
        }

        /// <summary>
        /// Completes an asynchronous request for the next event in the queue.
        /// </summary>
        /// <param name="result">
        /// The <see cref="AsyncResult"/>. Pass in the same pointer that your callback
        /// object received in the <c>Invoke</c> method. 
        /// </param>
        /// <returns>
        /// The <see cref="MediaEvent"/> object. The caller must release the object. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6B38E984-D818-4F69-AF28-8B54153FAEBB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6B38E984-D818-4F69-AF28-8B54153FAEBB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaEvent EndGetEvent(AsyncResult result)
        {
            IMFMediaEvent evt;
            int hr = this.Interface.EndGetEvent(result.GetInterface(), out evt);
            COM.ThrowIfNotOK(hr);
            return evt.ToMediaEvent();
        }

        /// <summary>
        /// Puts a new event in the object's queue.
        /// </summary>
        /// <param name="type">
        /// Specifies the event type. The event type is returned by the event's 
        /// <see cref="MediaEvent{T}.Type"/> method. For a list of event types, see 
        /// <c>Media Foundation Events</c>. 
        /// </param>
        /// <param name="extendedType">
        /// The extended type. If the event does not have an extended type, use the value GUID_NULL. The
        /// extended type is returned by the event's <see cref="MediaEvent{T}.ExtendedType"/> method. 
        /// </param>
        /// <param name="status">
        /// A success or failure code indicating the status of the event. This value is returned by the event's
        /// <see cref="MediaEvent{T}.GetStatus"/> method. 
        /// </param>
        /// <param name="value">
        /// A <see cref="PropVariant"/> that contains the event value. This parameter can be <strong>null</strong>. 
        /// This value is returned by the event's <see cref="MediaEvent{T}.GetValue"/> method. 
        /// </param>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3BC33665-1385-41E1-9AD0-991FC93E91C0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3BC33665-1385-41E1-9AD0-991FC93E91C0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void QueueEvent(MediaEventType type, Guid extendedType, int status, ConstPropVariant value)
        {
            int hr = this.Interface.QueueEvent(type, extendedType, status, value);
            COM.ThrowIfNotOK(hr);
        }
    }

    /// <summary>
    /// The <see cref="MediaEventGenerator"/> class implements a wrapper around the
    /// <see cref="IMFMediaEventGenerator"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEventGenerator"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEventGenerator"/>: 
    /// Retrieves events from any Media Foundation object that generates events. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A37D0840-C896-43A0-B3D1-C2A6AAFF1B25(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A37D0840-C896-43A0-B3D1-C2A6AAFF1B25(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEventGenerator : MediaEventGenerator<IMFMediaEventGenerator>
    {
        #region Construction

        internal MediaEventGenerator(IMFMediaEventGenerator comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
