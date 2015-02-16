using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="RemoteAsyncCallback"/> class implements a wrapper around the
    /// <see cref="IMFRemoteAsyncCallback"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFRemoteAsyncCallback"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFRemoteAsyncCallback"/>: 
    /// Used by the Microsoft Media Foundation proxy/stub DLL to marshal certain asynchronous method calls
    /// across process boundaries.
    /// <para/>
    /// Applications do not use or implement this interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/57BE21CF-B381-436A-BC7E-3FDC01CC2515(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/57BE21CF-B381-436A-BC7E-3FDC01CC2515(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class RemoteAsyncCallback : COM<IMFRemoteAsyncCallback>
    {
        #region Construction

        internal RemoteAsyncCallback(IMFRemoteAsyncCallback comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
