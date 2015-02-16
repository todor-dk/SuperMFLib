using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="AsyncCallbackLogging"/> class implements a wrapper arround the
    /// <see cref="IMFAsyncCallbackLogging"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFAsyncCallbackLogging"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFAsyncCallbackLogging"/>: 
    /// Provides logging information about the parent object the async callback is associated with.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8B4DE920-8E82-4E50-B801-82842DA8A6AE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8B4DE920-8E82-4E50-B801-82842DA8A6AE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class AsyncCallbackLogging : COM<IMFAsyncCallbackLogging>
    {
        #region Construction

        internal AsyncCallbackLogging(IMFAsyncCallbackLogging comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
