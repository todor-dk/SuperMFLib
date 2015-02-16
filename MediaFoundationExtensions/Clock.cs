using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="Clock"/> class implements a wrapper arround the
    /// <see cref="IMFClock"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFClock"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFClock"/>: 
    /// Provides timing information from a clock in Microsoft Media Foundation.
    /// <para/>
    /// Clocks and some media sinks expose this interface through <strong>QueryInterface</strong>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3A60BFEC-8511-4A84-A833-E0C73C593970(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3A60BFEC-8511-4A84-A833-E0C73C593970(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class Clock : COM<IMFClock>
    {
        #region Construction

        internal Clock(IMFClock comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
