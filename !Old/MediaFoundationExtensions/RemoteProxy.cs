using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="RemoteProxy"/> class implements a wrapper around the
    /// <see cref="IMFRemoteProxy"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFRemoteProxy"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFRemoteProxy"/>: 
    /// Exposed by objects that act as a proxy for a remote object. To obtain a pointer to this interface,
    /// call <see cref="IMFGetService.GetService"/> with the service identifier MF_REMOTE_PROXY. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/46AF5BA7-C362-4CFD-AE6D-B698C6403A65(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/46AF5BA7-C362-4CFD-AE6D-B698C6403A65(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class RemoteProxy : COM<IMFRemoteProxy>
    {
        #region Construction

        internal RemoteProxy(IMFRemoteProxy comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
