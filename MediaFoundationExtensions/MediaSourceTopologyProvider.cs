using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaSourceTopologyProvider"/> class implements a wrapper arround the
    /// <see cref="IMFMediaSourceTopologyProvider"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaSourceTopologyProvider"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaSourceTopologyProvider"/>: 
    /// Enables an application to get a topology from the sequencer source. This interface is exposed by
    /// the sequencer source object.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7C08FB54-6A78-4B6D-AAE7-4B3A823EB880(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7C08FB54-6A78-4B6D-AAE7-4B3A823EB880(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaSourceTopologyProvider : COM<IMFMediaSourceTopologyProvider>
    {
        #region Construction

        internal MediaSourceTopologyProvider(IMFMediaSourceTopologyProvider comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
