using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="WorkQueueServices"/> class implements a wrapper around the
    /// <see cref="IMFWorkQueueServices"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFWorkQueueServices"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFWorkQueueServices"/>: 
    /// Controls the work queues created by the <c>Media Session</c>. 
    /// <para/>
    /// The Media Session exposes this interface as a service. To obtain a pointer to this interface, call 
    /// <see cref="IMFGetService.GetService"/> on the Media Session with the service identifier
    /// MF_WORKQUEUE_SERVICES. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7A6DDB67-9A8C-408C-B750-4F3FD3BA0D7D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7A6DDB67-9A8C-408C-B750-4F3FD3BA0D7D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class WorkQueueServices : COM<IMFWorkQueueServices>
    {
        #region Construction

        internal WorkQueueServices(IMFWorkQueueServices comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
