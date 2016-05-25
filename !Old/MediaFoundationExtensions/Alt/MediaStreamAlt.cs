using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaStreamAlt"/> class implements a wrapper around the
    /// <see cref="IMFMediaStreamAlt"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaStreamAlt"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaStreamAlt"/>: 
    /// Represents one stream in a media source. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/66D07292-3BFE-4E68-B26F-890996262B98(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/66D07292-3BFE-4E68-B26F-890996262B98(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaStreamAlt : COM<IMFMediaStreamAlt>
    {
        #region Construction

        internal MediaStreamAlt(IMFMediaStreamAlt comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
