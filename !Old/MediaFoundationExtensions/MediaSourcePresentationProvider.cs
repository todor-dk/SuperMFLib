using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaSourcePresentationProvider"/> class implements a wrapper around the
    /// <see cref="IMFMediaSourcePresentationProvider"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaSourcePresentationProvider"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaSourcePresentationProvider"/>: 
    /// Provides notifications to the sequencer source. This interface is exposed by the sequencer source.
    /// Applications do not use this interface.
    /// <para/>
    /// To get a pointer to this interface, call <see cref="IMFGetService.GetService"/> with the service
    /// identifier MF_SOURCE_PRESENTATION_PROVIDER_SERVICE. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B6B36324-A315-42A0-BDBF-8D2CEC6CDE3F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B6B36324-A315-42A0-BDBF-8D2CEC6CDE3F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaSourcePresentationProvider : COM<IMFMediaSourcePresentationProvider>
    {
        #region Construction

        internal MediaSourcePresentationProvider(IMFMediaSourcePresentationProvider comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
