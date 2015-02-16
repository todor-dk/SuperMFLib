using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEngineEx"/> class implements a wrapper arround the
    /// <see cref="IMFMediaEngineEx"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEngineEx"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEngineEx"/>: 
    /// Extends the <see cref="IMFMediaEngine"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/EE3591FD-4FE8-4F20-A4E2-52C896229571(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EE3591FD-4FE8-4F20-A4E2-52C896229571(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEngineEx : COM<IMFMediaEngineEx>
    {
        #region Construction

        internal MediaEngineEx(IMFMediaEngineEx comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
