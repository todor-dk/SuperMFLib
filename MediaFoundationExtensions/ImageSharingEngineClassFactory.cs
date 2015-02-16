using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ImageSharingEngineClassFactory"/> class implements a wrapper around the
    /// <see cref="IMFImageSharingEngineClassFactory"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFImageSharingEngineClassFactory"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFImageSharingEngineClassFactory"/>: 
    /// <i>***** Documentation Missing *****</i>.
    /// </summary>
    public sealed class ImageSharingEngineClassFactory : COM<IMFImageSharingEngineClassFactory>
    {
        #region Construction

        internal ImageSharingEngineClassFactory(IMFImageSharingEngineClassFactory comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
