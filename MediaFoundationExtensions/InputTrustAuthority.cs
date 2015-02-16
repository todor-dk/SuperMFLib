using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="InputTrustAuthority"/> class implements a wrapper arround the
    /// <see cref="IMFInputTrustAuthority"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFInputTrustAuthority"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFInputTrustAuthority"/>: 
    /// Enables other components in the protected media path (PMP) to use the input protection system
    /// provided by an input trust authorities (ITA). An ITA is a component that implements an input
    /// protection system for media content. ITAs expose the <strong>IMFInputTrustAuthority</strong>
    /// interface. 
    /// <para/>
    /// An ITA translates policy from the content's native format into a common format that is used by
    /// other PMP components. It also provides a decrypter, if one is needed to decrypt the stream.
    /// <para/>
    /// The topology contains one ITA instance for every protected stream in the media source. The ITA is
    /// obtained from the media source by calling <see cref="IMFTrustedInput.GetInputTrustAuthority"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/637E0225-6FD8-4B83-B4FB-119E7A5EF5D2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/637E0225-6FD8-4B83-B4FB-119E7A5EF5D2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class InputTrustAuthority : COM<IMFInputTrustAuthority>
    {
        #region Construction

        internal InputTrustAuthority(IMFInputTrustAuthority comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
