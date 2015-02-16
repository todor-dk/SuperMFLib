using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaSinkPreroll"/> class implements a wrapper arround the
    /// <see cref="IMFMediaSinkPreroll"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaSinkPreroll"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaSinkPreroll"/>: 
    /// Enables a media sink to receive samples before the presentation clock is started.
    /// <para/>
    /// To get a pointer to this interface, call <strong>QueryInterface</strong> on the media sink. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7CC93751-4477-4649-B09E-53F519FB1ACB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7CC93751-4477-4649-B09E-53F519FB1ACB(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaSinkPreroll : COM<IMFMediaSinkPreroll>
    {
        #region Construction

        internal MediaSinkPreroll(IMFMediaSinkPreroll comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
