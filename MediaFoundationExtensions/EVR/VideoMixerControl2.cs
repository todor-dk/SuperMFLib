using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="VideoMixerControl2"/> class implements a wrapper around the
    /// <see cref="IMFVideoMixerControl2"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoMixerControl2"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoMixerControl2"/>: 
    /// Controls preferences for video deinterlacing.
    /// <para/>
    /// The default video mixer for the <c>Enhanced Video Renderer</c> (EVR) implements this interface. 
    /// <para/>
    /// To get a pointer to the interface, call <see cref="IMFGetService.GetService"/> on any of the
    /// following objects, using the <strong>MR_VIDEO_MIXER_SERVICE</strong> service identifier: 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A238B050-101D-4B8A-9479-984B889823F4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A238B050-101D-4B8A-9479-984B889823F4(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoMixerControl2 : COM<IMFVideoMixerControl2>
    {
        #region Construction

        internal VideoMixerControl2(IMFVideoMixerControl2 comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
