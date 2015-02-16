using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="VideoSampleAllocator"/> class implements a wrapper around the
    /// <see cref="IMFVideoSampleAllocator"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoSampleAllocator"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoSampleAllocator"/>: 
    /// Allocates video samples for a video media sink.
    /// <para/>
    /// The stream sinks on the enhanced video renderer (EVR) expose this interface as a service. To obtain
    /// a pointer to the interface, call <see cref="IMFGetService.GetService"/> using the service
    /// identifier MR_VIDEO_ACCELERATION_SERVICE. Custom media sinks can also implement this interface. The
    /// Media Session uses this interface to allocate samples for the EVR, unless the upstream decoder
    /// supports DirectX Video Acceleration (DXVA). 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BEF92133-AE6C-4013-9210-5E0F0BE2002C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BEF92133-AE6C-4013-9210-5E0F0BE2002C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoSampleAllocator : COM<IMFVideoSampleAllocator>
    {
        #region Construction

        internal VideoSampleAllocator(IMFVideoSampleAllocator comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
