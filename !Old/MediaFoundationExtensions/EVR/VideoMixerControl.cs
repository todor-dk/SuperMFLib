using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="VideoMixerControl"/> class implements a wrapper around the
    /// <see cref="IMFVideoMixerControl"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoMixerControl"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoMixerControl"/>: 
    /// Controls how the <c>Enhanced Video Renderer</c> (EVR) mixes video substreams. Applications can use
    /// this interface to control video mixing during playback. 
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
    /// <a href="http://msdn.microsoft.com/en-US/library/8B5F54E3-C6DA-4201-857A-9C718AD911DB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8B5F54E3-C6DA-4201-857A-9C718AD911DB(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoMixerControl : COM<IMFVideoMixerControl>
    {
        #region Construction

        internal VideoMixerControl(IMFVideoMixerControl comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
