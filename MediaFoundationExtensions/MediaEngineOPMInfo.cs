using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEngineOPMInfo"/> class implements a wrapper arround the
    /// <see cref="IMFMediaEngineOPMInfo"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEngineOPMInfo"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEngineOPMInfo"/>: 
    /// Provides methods for getting information about the <c>Output Protection Manager</c> (OPM). 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/399F81AC-38F8-4AAA-8B34-F5FD13B71402(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/399F81AC-38F8-4AAA-8B34-F5FD13B71402(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEngineOPMInfo : COM<IMFMediaEngineOPMInfo>
    {
        #region Construction

        internal MediaEngineOPMInfo(IMFMediaEngineOPMInfo comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
