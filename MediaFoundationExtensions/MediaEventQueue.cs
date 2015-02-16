using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEventQueue"/> class implements a wrapper around the
    /// <see cref="IMFMediaEventQueue"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEventQueue"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEventQueue"/>: 
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
    public sealed class MediaEventQueue : COM<IMFMediaEventQueue>
    {
        #region Construction

        internal MediaEventQueue(IMFMediaEventQueue comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
