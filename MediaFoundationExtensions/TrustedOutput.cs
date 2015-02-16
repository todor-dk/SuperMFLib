using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="TrustedOutput"/> class implements a wrapper around the
    /// <see cref="IMFTrustedOutput"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTrustedOutput"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTrustedOutput"/>: 
    /// Implemented by components that provide output trust authorities (OTAs). Any Media Foundation
    /// transform (MFT) or media sink that is designed to work within the protected media path (PMP) and
    /// also sends protected content outside the Media Foundation pipeline must implement this interface.
    /// <para/>
    /// The policy engine uses this interface to negotiate what type of content protection should be
    /// applied to the content. Applications do not use this interface directly.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/14342D8B-3C76-4C13-8CBE-A60BB66084C8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/14342D8B-3C76-4C13-8CBE-A60BB66084C8(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class TrustedOutput : COM<IMFTrustedOutput>
    {
        #region Construction

        internal TrustedOutput(IMFTrustedOutput comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
