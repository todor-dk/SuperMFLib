using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ClockStateSink"/> class implements a wrapper around the
    /// <see cref="IMFClockStateSink"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFClockStateSink"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFClockStateSink"/>: 
    /// Receives state-change notifications from the presentation clock. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9AA0D2CD-A687-4B3A-834D-CCC8D3A03196(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9AA0D2CD-A687-4B3A-834D-CCC8D3A03196(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ClockStateSink : COM<IMFClockStateSink>
    {
        #region Construction

        internal ClockStateSink(IMFClockStateSink comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
