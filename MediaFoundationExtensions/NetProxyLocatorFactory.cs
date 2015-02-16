using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="NetProxyLocatorFactory"/> class implements a wrapper arround the
    /// <see cref="IMFNetProxyLocatorFactory"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFNetProxyLocatorFactory"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFNetProxyLocatorFactory"/>: 
    /// Creates a proxy locator object, which determines the proxy to use.
    /// <para/>
    /// The network source uses this interface to create the proxy locator object. Applications can provide
    /// their own implementation of this interface by setting the 
    /// <see cref="MFProperties.MFNETSOURCE_PROXYLOCATORFACTORY"/> property. on the source resolver. If the
    /// application does not set this property, the network source uses the default proxy locator provided
    /// by Media Foundation. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6DD5BF50-2D07-47C7-869E-035D7E92A6BC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6DD5BF50-2D07-47C7-869E-035D7E92A6BC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class NetProxyLocatorFactory : COM<IMFNetProxyLocatorFactory>
    {
        #region Construction

        internal NetProxyLocatorFactory(IMFNetProxyLocatorFactory comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
