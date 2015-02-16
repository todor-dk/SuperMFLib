using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="_2DBuffer"/> class implements a wrapper around the
    /// <see cref="IMF2DBuffer"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMF2DBuffer"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMF2DBuffer"/>: 
    /// Represents a buffer that contains a two-dimensional surface, such as a video frame. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/80EB23DB-A7C0-4DBE-97D8-0DC07A34D8F7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/80EB23DB-A7C0-4DBE-97D8-0DC07A34D8F7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class _2DBuffer : COM<IMF2DBuffer>
    {
        #region Construction

        internal _2DBuffer(IMF2DBuffer comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
