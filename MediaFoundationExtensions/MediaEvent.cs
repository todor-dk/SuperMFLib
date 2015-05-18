using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEvent"/> class implements a wrapper around the
    /// <see cref="IMFMediaEvent"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEvent"/>
    /// interface's methods.
    /// </summary>
    public abstract class MediaEvent<TInterface> : Attributes<TInterface>
        where TInterface : class, IMFMediaEvent
    {
        #region Construction

        internal MediaEvent(TInterface comInterface)
            : base(comInterface)
        {
        }

        #endregion

        /// <summary>
        /// Retrieves the event type. The event type indicates what happened to trigger the event. It also
        /// defines the meaning of the event value.
        /// </summary>
        /// <returns>
        /// The event type. For a list of event types, see <c>Media Foundation Events</c>.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B62E0D9F-DADA-4B75-A8D3-568EE2955888(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B62E0D9F-DADA-4B75-A8D3-568EE2955888(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaEventType Type
        {
            get
            {
                MediaEventType type;
                int hr = this.Interface.GetType(out type);
                COM.ThrowIfNotOK(hr);
                return type;
            }
        }

        /// <summary>
        /// Retrieves the extended type of the event.
        /// </summary>
        /// <returns>
        /// A <see cref="Guid"/> that identifies the extended type. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/56284491-6F84-467E-9FAC-46B04DB4024A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/56284491-6F84-467E-9FAC-46B04DB4024A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Guid ExtendedType
        {
            get
            {
                Guid type;
                int hr = this.Interface.GetExtendedType(out type);
                COM.ThrowIfNotOK(hr);
                return type;
            }
        }

        /// <summary>
        /// Retrieves an <strong>HRESULT</strong> that specifies the event status. 
        /// </summary>
        /// <returns>
        /// Returns the event status. If the operation that generated the event was successful, the value is a
        /// success code. A failure code means that an error condition triggered the event.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E2FC6C81-11C0-4947-B647-3E74A73EE5A2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E2FC6C81-11C0-4947-B647-3E74A73EE5A2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int GetStatus()
        {
            int status;
            int hr = this.Interface.GetStatus(out status);
            COM.ThrowIfNotOK(hr);
            return status;
        }

        /// <summary>
        /// Retrieves the value associated with the event, if any. The value is retrieved as a <see cref="PropVariant"/>. 
        /// The actual data type and the meaning of the value depend on the event. 
        /// </summary>
        /// <returns>
        /// A <see cref="PropVariant"/> value. Remember to dispose the PropVariant.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/05E57B40-2565-4312-866E-50F0C7D62C4A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/05E57B40-2565-4312-866E-50F0C7D62C4A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public PropVariant GetValue()
        {
            PropVariant value = new PropVariant();
            int hr = this.Interface.GetValue(value);
            COM.ThrowIfNotOKAndDisposePropVariant(hr, value);
            return value;
        }

        /// <summary>
        /// Retrieves the value associated with the event, if any. The value is retrieved as a <see cref="PropVariant"/>. 
        /// The actual data type and the meaning of the value depend on the event. 
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/05E57B40-2565-4312-866E-50F0C7D62C4A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/05E57B40-2565-4312-866E-50F0C7D62C4A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public object Value
        {
            get
            {
                using(PropVariant value = this.GetValue())
                {
                    return value.GetValue();
                }
            }
        }
    }

    /// <summary>
    /// The <see cref="MediaEvent"/> class implements a wrapper around the
    /// <see cref="IMFMediaEvent"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEvent"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEvent"/>: 
    /// Represents an event generated by a Media Foundation object. Use this interface to get information
    /// about the event.
    /// <para/>
    /// To get a pointer to this interface, call <see cref="IMFMediaEventGenerator.BeginGetEvent"/> or 
    /// <see cref="IMFMediaEventGenerator.GetEvent"/> on the event generator. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B4F686BE-9472-433C-B983-6C48DFD3AC76(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B4F686BE-9472-433C-B983-6C48DFD3AC76(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    internal class  MediaEvent : MediaEvent<IMFMediaEvent>
    {
        #region Construction

        internal MediaEvent(IMFMediaEvent comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
