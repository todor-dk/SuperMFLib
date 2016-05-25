using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaKeys"/> class implements a wrapper around the
    /// <see cref="IMFMediaKeys"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaKeys"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaKeys"/>: 
    /// Represents a media keys used for decrypting media data using a Digital Rights Management (DRM) key
    /// system. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/0689D938-E0BE-46D7-BFED-ADD431331A90(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0689D938-E0BE-46D7-BFED-ADD431331A90(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaKeys : COM<IMFMediaKeys>
    {
        #region Construction

        internal MediaKeys(IMFMediaKeys comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
