using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SharingEngineClassFactory"/> class implements a wrapper around the
    /// <see cref="IMFSharingEngineClassFactory"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSharingEngineClassFactory"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSharingEngineClassFactory"/>: 
    /// Creates an instance of the media sharing engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/191CB50C-8CBB-470F-B558-F3A9EE554DA3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/191CB50C-8CBB-470F-B558-F3A9EE554DA3(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SharingEngineClassFactory : COM<IMFSharingEngineClassFactory>
    {
        #region Construction

        internal SharingEngineClassFactory(IMFSharingEngineClassFactory comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
