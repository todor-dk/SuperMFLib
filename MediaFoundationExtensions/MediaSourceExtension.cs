using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaSourceExtension"/> class implements a wrapper arround the
    /// <see cref="IMFMediaSourceExtension"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaSourceExtension"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaSourceExtension"/>: 
    /// Provides functionality for the Media Source Extension (MSE).
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/2ACABCC2-242D-4B3D-B5B4-680C7973201F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2ACABCC2-242D-4B3D-B5B4-680C7973201F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaSourceExtension : COM<IMFMediaSourceExtension>
    {
        #region Construction

        internal MediaSourceExtension(IMFMediaSourceExtension comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
