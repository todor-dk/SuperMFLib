using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaSharingEngineClassFactory"/> class implements a wrapper around the
    /// <see cref="IMFMediaSharingEngineClassFactory"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaSharingEngineClassFactory"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaSharingEngineClassFactory"/>: 
    /// <i>***** Documentation Missing *****</i>.
    /// </summary>
    public sealed class MediaSharingEngineClassFactory : COM<IMFMediaSharingEngineClassFactory>
    {
        #region Construction

        internal MediaSharingEngineClassFactory(IMFMediaSharingEngineClassFactory comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
