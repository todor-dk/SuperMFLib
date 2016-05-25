using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEngineNotify"/> class implements a wrapper around the
    /// <see cref="IMFMediaEngineNotify"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEngineNotify"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEngineNotify"/>: 
    /// Callback interface for the <see cref="IMFMediaEngine"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/85D702D4-3C9B-4848-81F2-3634C2B6AE1A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/85D702D4-3C9B-4848-81F2-3634C2B6AE1A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEngineNotify : COM<IMFMediaEngineNotify>
    {
        #region Construction

        internal MediaEngineNotify(IMFMediaEngineNotify comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
