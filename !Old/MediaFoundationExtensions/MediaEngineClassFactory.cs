using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEngineClassFactory"/> class implements a wrapper around the
    /// <see cref="IMFMediaEngineClassFactory"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEngineClassFactory"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEngineClassFactory"/>: 
    /// Creates an instance of the Media Engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8E4E84A0-BCFC-4CBF-813B-4FEE2B42A83E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8E4E84A0-BCFC-4CBF-813B-4FEE2B42A83E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEngineClassFactory : COM<IMFMediaEngineClassFactory>
    {
        #region Construction

        internal MediaEngineClassFactory(IMFMediaEngineClassFactory comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
