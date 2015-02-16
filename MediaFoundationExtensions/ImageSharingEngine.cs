using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ImageSharingEngine"/> class implements a wrapper around the
    /// <see cref="IMFImageSharingEngine"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFImageSharingEngine"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFImageSharingEngine"/>: 
    /// Enables image sharing.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A30C73DA-9BD5-4D12-A6FB-771BBD2D1191(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A30C73DA-9BD5-4D12-A6FB-771BBD2D1191(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ImageSharingEngine : COM<IMFImageSharingEngine>
    {
        #region Construction

        internal ImageSharingEngine(IMFImageSharingEngine comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
