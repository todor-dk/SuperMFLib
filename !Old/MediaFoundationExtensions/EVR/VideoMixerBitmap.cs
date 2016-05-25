using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="VideoMixerBitmap"/> class implements a wrapper around the
    /// <see cref="IMFVideoMixerBitmap"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoMixerBitmap"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoMixerBitmap"/>: 
    /// Alpha-blends a static bitmap image with the video displayed by the <c>Enhanced Video Renderer</c>
    /// (EVR). 
    /// <para/>
    /// The EVR mixer implements this interface. To get a pointer to the interface, call 
    /// <see cref="IMFGetService.GetService"/>. The service identifier GUID is MR_VIDEO_MIXER_SERVICE. Call
    /// <strong>GetService</strong> on any of the following objects: 
    /// <para/>
    /// If you implement a custom mixer for the EVR, the mixer can optionally expose this interface as a
    /// service.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/4DA4BDB9-857B-40C9-B910-04A099A23AB5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4DA4BDB9-857B-40C9-B910-04A099A23AB5(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoMixerBitmap : COM<IMFVideoMixerBitmap>
    {
        #region Construction

        internal VideoMixerBitmap(IMFVideoMixerBitmap comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
