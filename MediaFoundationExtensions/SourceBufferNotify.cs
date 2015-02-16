using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SourceBufferNotify"/> class implements a wrapper arround the
    /// <see cref="IMFSourceBufferNotify"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSourceBufferNotify"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSourceBufferNotify"/>: 
    /// Provides functionality for raising events associated with <c>IMFSourceBuffer</c>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/4A823D37-F55A-4810-AAED-4E04F5371D3B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4A823D37-F55A-4810-AAED-4E04F5371D3B(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SourceBufferNotify : COM<IMFSourceBufferNotify>
    {
        #region Construction

        internal SourceBufferNotify(IMFSourceBufferNotify comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
