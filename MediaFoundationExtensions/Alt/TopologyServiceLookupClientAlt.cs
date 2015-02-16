using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="TopologyServiceLookupClientAlt"/> class implements a wrapper arround the
    /// <see cref="IMFTopologyServiceLookupClientAlt"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTopologyServiceLookupClientAlt"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTopologyServiceLookupClientAlt"/>: 
    /// Initializes a video mixer or presenter. This interface is implemented by mixers and presenters, and
    /// enables them to query the enhanced video renderer (EVR) for interface pointers.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C4215D08-3734-44B9-B053-0D49D89A90F6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C4215D08-3734-44B9-B053-0D49D89A90F6(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class TopologyServiceLookupClientAlt : COM<IMFTopologyServiceLookupClientAlt>
    {
        #region Construction

        internal TopologyServiceLookupClientAlt(IMFTopologyServiceLookupClientAlt comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
