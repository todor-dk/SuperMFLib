using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEngineSupportsSourceTransfer"/> class implements a wrapper around the
    /// <see cref="IMFMediaEngineSupportsSourceTransfer"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEngineSupportsSourceTransfer"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEngineSupportsSourceTransfer"/>: 
    /// Enables the media source to be transferred between  the media engine and the sharing engine for
    /// Play To.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8784DCC2-52F4-41D9-A0AE-3EA7A736B604(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8784DCC2-52F4-41D9-A0AE-3EA7A736B604(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEngineSupportsSourceTransfer : COM<IMFMediaEngineSupportsSourceTransfer>
    {
        #region Construction

        internal MediaEngineSupportsSourceTransfer(IMFMediaEngineSupportsSourceTransfer comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
