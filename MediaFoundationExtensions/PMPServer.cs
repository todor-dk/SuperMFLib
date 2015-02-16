using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PMPServer"/> class implements a wrapper around the
    /// <see cref="IMFPMPServer"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFPMPServer"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFPMPServer"/>: 
    /// Enables two instances of the <c>Media Session</c> to share the same protected media path (PMP)
    /// process. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BA6DC70A-D77D-41DE-AFE1-65F2EFCC4A95(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA6DC70A-D77D-41DE-AFE1-65F2EFCC4A95(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PMPServer : COM<IMFPMPServer>
    {
        #region Construction

        internal PMPServer(IMFPMPServer comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
