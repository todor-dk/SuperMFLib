using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaSourceEx"/> class implements a wrapper around the
    /// <see cref="IMFMediaSourceEx"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaSourceEx"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaSourceEx"/>: 
    /// Extends the <see cref="IMFMediaSource"/> interface to provide additional capabilities for a media
    /// source. 
    /// <para/>
    /// To get a pointer to this interface, call <c>QueryInterface</c> on the media source. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C72C79D5-FD65-4F27-A8C8-B94BF5A9E829(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C72C79D5-FD65-4F27-A8C8-B94BF5A9E829(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaSourceEx : COM<IMFMediaSourceEx>
    {
        #region Construction

        internal MediaSourceEx(IMFMediaSourceEx comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
