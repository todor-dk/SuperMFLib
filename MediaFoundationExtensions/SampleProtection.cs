using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SampleProtection"/> class implements a wrapper arround the
    /// <see cref="IMFSampleProtection"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSampleProtection"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSampleProtection"/>: 
    /// Provides encryption for media data inside the protected media path (PMP). 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BEBE24CD-657B-4C6C-9FE9-5D6DD58827A3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BEBE24CD-657B-4C6C-9FE9-5D6DD58827A3(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SampleProtection : COM<IMFSampleProtection>
    {
        #region Construction

        internal SampleProtection(IMFSampleProtection comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
