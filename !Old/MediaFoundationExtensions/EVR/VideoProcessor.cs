using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="VideoProcessor"/> class implements a wrapper around the
    /// <see cref="IMFVideoProcessor"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoProcessor"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoProcessor"/>: 
    /// Controls video processing in the <c>Enhanced Video Renderer</c> (EVR). The operations controlled
    /// through this interface include color adjustment (ProcAmp), noise filters, and detail filters. 
    /// <para/>
    /// The EVR mixer implements this interface. To get a pointer to the interface, call 
    /// <see cref="IMFGetService.GetService"/>. The service identifier is GUID MR_VIDEO_MIXER_SERVICE. Call
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
    /// <a href="http://msdn.microsoft.com/en-US/library/0A63C4F8-EB32-4F0C-B69B-0C16243F2F21(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0A63C4F8-EB32-4F0C-B69B-0C16243F2F21(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoProcessor : COM<IMFVideoProcessor>
    {
        #region Construction

        internal VideoProcessor(IMFVideoProcessor comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
