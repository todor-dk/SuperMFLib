using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PresentationClock"/> class implements a wrapper arround the
    /// <see cref="IMFPresentationClock"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFPresentationClock"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFPresentationClock"/>: 
    /// Represents a presentation clock, which is used to schedule when samples are rendered and to
    /// synchronize multiple streams.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/979C4F77-CBEE-468C-8F6B-E68442D89025(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/979C4F77-CBEE-468C-8F6B-E68442D89025(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PresentationClock : COM<IMFPresentationClock>
    {
        #region Construction

        internal PresentationClock(IMFPresentationClock comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
