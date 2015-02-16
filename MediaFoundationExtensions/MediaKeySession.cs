using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaKeySession"/> class implements a wrapper arround the
    /// <see cref="IMFMediaKeySession"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaKeySession"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaKeySession"/>: 
    /// Represents a session with the Digital Rights Management (DRM) key system.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/07F97BC9-9DA2-4655-9AB9-5E17ABC57D6D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/07F97BC9-9DA2-4655-9AB9-5E17ABC57D6D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaKeySession : COM<IMFMediaKeySession>
    {
        #region Construction

        internal MediaKeySession(IMFMediaKeySession comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
