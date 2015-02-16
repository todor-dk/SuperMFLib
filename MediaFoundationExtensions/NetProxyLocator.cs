using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="NetProxyLocator"/> class implements a wrapper arround the
    /// <see cref="IMFNetProxyLocator"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFNetProxyLocator"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFNetProxyLocator"/>: 
    /// Determines the proxy to use when connecting to a server. The network source uses this interface.
    /// <para/>
    /// Applications can create the proxy locator configured by the application by implementing the 
    /// <see cref="IMFNetProxyLocatorFactory"/> interface and setting the 
    /// <see cref="MFProperties.MFNETSOURCE_PROXYLOCATORFACTORY"/> property on the source resolver.
    /// Otherwise, the network source uses the default Media Foundation implementation. 
    /// <para/>
    /// To create the default proxy locator, call <see cref="MFExtern.MFCreateProxyLocator"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/2906B998-F1CA-4C65-B810-CBC360390653(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2906B998-F1CA-4C65-B810-CBC360390653(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class NetProxyLocator : COM<IMFNetProxyLocator>
    {
        #region Construction

        internal NetProxyLocator(IMFNetProxyLocator comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
