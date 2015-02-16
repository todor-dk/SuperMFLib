using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="NetSchemeHandlerConfig"/> class implements a wrapper arround the
    /// <see cref="IMFNetSchemeHandlerConfig"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFNetSchemeHandlerConfig"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFNetSchemeHandlerConfig"/>: 
    /// Configures a network scheme plug-in. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/91BDCDBD-D621-42E3-8E0F-F8EEAB489D35(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/91BDCDBD-D621-42E3-8E0F-F8EEAB489D35(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class NetSchemeHandlerConfig : COM<IMFNetSchemeHandlerConfig>
    {
        #region Construction

        internal NetSchemeHandlerConfig(IMFNetSchemeHandlerConfig comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
