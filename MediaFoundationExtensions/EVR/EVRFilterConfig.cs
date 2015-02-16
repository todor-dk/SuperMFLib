using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="EVRFilterConfig"/> class implements a wrapper arround the
    /// <see cref="IEVRFilterConfig"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IEVRFilterConfig"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IEVRFilterConfig"/>: 
    /// Sets the number of input pins on the DirectShow <c>Enhanced Video Renderer</c> (EVR) filter. To get
    /// a pointer to this interface, call <strong>QueryInterface</strong> on the DirectShow EVR filter. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/13086D85-3DBF-4E9F-B065-D95E16412832(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/13086D85-3DBF-4E9F-B065-D95E16412832(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class EVRFilterConfig : COM<IEVRFilterConfig>
    {
        #region Construction

        internal EVRFilterConfig(IEVRFilterConfig comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
