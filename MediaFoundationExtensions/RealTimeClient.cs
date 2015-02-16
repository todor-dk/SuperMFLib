using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="RealTimeClient"/> class implements a wrapper arround the
    /// <see cref="IMFRealTimeClient"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFRealTimeClient"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFRealTimeClient"/>: 
    /// Notifies a pipeline object to register itself with the Multimedia Class Scheduler Service (MMCSS).
    /// <para/>
    /// Any pipeline object that creates worker threads should implement this interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B1D1901E-DD49-421F-9212-61E32CFF411E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B1D1901E-DD49-421F-9212-61E32CFF411E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class RealTimeClient : COM<IMFRealTimeClient>
    {
        #region Construction

        internal RealTimeClient(IMFRealTimeClient comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
