using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEngineProtectedContent"/> class implements a wrapper around the
    /// <see cref="IMFMediaEngineProtectedContent"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEngineProtectedContent"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEngineProtectedContent"/>: 
    /// Enables the Media Engine to play protected video content.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/85B37711-DB46-4BC7-A051-79E9507791FA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/85B37711-DB46-4BC7-A051-79E9507791FA(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEngineProtectedContent : COM<IMFMediaEngineProtectedContent>
    {
        #region Construction

        internal MediaEngineProtectedContent(IMFMediaEngineProtectedContent comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
