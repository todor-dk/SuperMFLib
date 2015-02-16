using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="VideoPositionMapper"/> class implements a wrapper arround the
    /// <see cref="IMFVideoPositionMapper"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoPositionMapper"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoPositionMapper"/>: 
    /// Maps a position on an input video stream to the corresponding position on an output video stream.
    /// <para/>
    /// To obtain a pointer to this interface, call <see cref="IMFGetService.GetService"/> on the renderer
    /// with the service GUID MR_VIDEO_RENDER_SERVICE. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/282FA124-909F-49DC-9A86-3D962193E903(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/282FA124-909F-49DC-9A86-3D962193E903(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoPositionMapper : COM<IMFVideoPositionMapper>
    {
        #region Construction

        internal VideoPositionMapper(IMFVideoPositionMapper comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
