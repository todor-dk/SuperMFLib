using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="RemoteDesktopPlugin"/> class implements a wrapper arround the
    /// <see cref="IMFRemoteDesktopPlugin"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFRemoteDesktopPlugin"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFRemoteDesktopPlugin"/>: 
    /// Modifies a topology for use in a Terminal Services environment. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/75BB9BF8-12A7-430F-9943-18623AFF9903(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/75BB9BF8-12A7-430F-9943-18623AFF9903(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class RemoteDesktopPlugin : COM<IMFRemoteDesktopPlugin>
    {
        #region Construction

        internal RemoteDesktopPlugin(IMFRemoteDesktopPlugin comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
