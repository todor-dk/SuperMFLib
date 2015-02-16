using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="_2DBuffer2"/> class implements a wrapper arround the
    /// <see cref="IMF2DBuffer2"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMF2DBuffer2"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMF2DBuffer2"/>: 
    /// Represents a buffer that contains a two-dimensional surface, such as a video frame.
    /// </summary>
    /// <remarks>The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para />
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/BFA73B1A-F8A7-4100-9DBD-234CCA06F9F5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BFA73B1A-F8A7-4100-9DBD-234CCA06F9F5(v=VS.85,d=hv.2).aspx</a></remarks>
    public sealed class _2DBuffer2 : COM<IMF2DBuffer2>
    {
        #region Construction

        internal _2DBuffer2(IMF2DBuffer2 comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
