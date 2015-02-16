using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="VideoPresenter"/> class implements a wrapper around the
    /// <see cref="IMFVideoPresenter"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoPresenter"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoPresenter"/>: 
    /// Represents a video presenter. A <em>video presenter</em> is an object that receives video frames,
    /// typically from a video mixer, and presents them in some way, typically by rendering them to the
    /// display. The enhanced video renderer (EVR) provides a default video presenter, and applications can
    /// implement custom presenters. 
    /// <para/>
    /// The video presenter receives video frames as soon as they are available from upstream. The video
    /// presenter is responsible for presenting frames at the correct time and for synchronizing with the
    /// presentation clock.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8F6E3132-03E9-4A2E-9160-E39D29CF2408(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8F6E3132-03E9-4A2E-9160-E39D29CF2408(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoPresenter : COM<IMFVideoPresenter>
    {
        #region Construction

        internal VideoPresenter(IMFVideoPresenter comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
