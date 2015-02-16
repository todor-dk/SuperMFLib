using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaError"/> class implements a wrapper around the
    /// <see cref="IMFMediaError"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaError"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaError"/>: 
    /// Provides the current error status for the Media Engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is � Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/08F161FE-C0E5-44EE-923E-646ADA534C42(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/08F161FE-C0E5-44EE-923E-646ADA534C42(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaError : COM<IMFMediaError>
    {
        #region Construction

        internal MediaError(IMFMediaError comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
