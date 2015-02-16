using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="VideoMediaType"/> class implements a wrapper around the
    /// <see cref="IMFVideoMediaType"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoMediaType"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoMediaType"/>: 
    /// Represents a description of a video format.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9109B0DD-C44D-41D4-9480-1CA5C667DBD7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9109B0DD-C44D-41D4-9480-1CA5C667DBD7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoMediaType : COM<IMFVideoMediaType>
    {
        #region Construction

        internal VideoMediaType(IMFVideoMediaType comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
