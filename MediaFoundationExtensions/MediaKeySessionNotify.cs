using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaKeySessionNotify"/> class implements a wrapper arround the
    /// <see cref="IMFMediaKeySessionNotify"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaKeySessionNotify"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaKeySessionNotify"/>: 
    /// Provides a mechanism for notifying the app about information regarding the media key session. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D28C16A8-4A74-40C3-BE95-FF7E4B1CDC09(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D28C16A8-4A74-40C3-BE95-FF7E4B1CDC09(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaKeySessionNotify : COM<IMFMediaKeySessionNotify>
    {
        #region Construction

        internal MediaKeySessionNotify(IMFMediaKeySessionNotify comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
