using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ASFStreamConfig"/> class implements a wrapper around the
    /// <see cref="IMFASFStreamConfig"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFASFStreamConfig"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFASFStreamConfig"/>: 
    /// Configures the settings of a stream in an ASF file. The ASF stream configuration object exposes
    /// this interface. To obtain a pointer to this interface, call the 
    /// <see cref="IMFASFProfile.CreateStream"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7BB63396-21C2-400D-B9DE-C00B90F46D62(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7BB63396-21C2-400D-B9DE-C00B90F46D62(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ASFStreamConfig : COM<IMFASFStreamConfig>
    {
        #region Construction

        internal ASFStreamConfig(IMFASFStreamConfig comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
