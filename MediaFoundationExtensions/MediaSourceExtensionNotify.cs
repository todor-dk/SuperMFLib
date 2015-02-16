using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaSourceExtensionNotify"/> class implements a wrapper arround the
    /// <see cref="IMFMediaSourceExtensionNotify"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaSourceExtensionNotify"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaSourceExtensionNotify"/>: 
    /// Provides functionality for raising events associated with <c>IMFMediaSourceExtension</c>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/44EED02D-CF92-41E5-8748-1CE11AB4AAC0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/44EED02D-CF92-41E5-8748-1CE11AB4AAC0(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaSourceExtensionNotify : COM<IMFMediaSourceExtensionNotify>
    {
        #region Construction

        internal MediaSourceExtensionNotify(IMFMediaSourceExtensionNotify comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
