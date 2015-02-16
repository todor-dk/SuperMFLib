using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="VideoSampleAllocatorCallback"/> class implements a wrapper arround the
    /// <see cref="IMFVideoSampleAllocatorCallback"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoSampleAllocatorCallback"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoSampleAllocatorCallback"/>: 
    /// Enables an application to track video samples allocated by the enhanced video renderer (EVR).
    /// <para/>
    /// The stream sinks on the EVR expose this interface as a service. To get a pointer to the interface,
    /// call the <see cref="IMFGetService.GetService"/> method, using the <strong>
    /// MR_VIDEO_ACCELERATION_SERVICE</strong> service identifier. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7DBF8B3A-24B3-41D9-BB1E-9C57B88A77AC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7DBF8B3A-24B3-41D9-BB1E-9C57B88A77AC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoSampleAllocatorCallback : COM<IMFVideoSampleAllocatorCallback>
    {
        #region Construction

        internal VideoSampleAllocatorCallback(IMFVideoSampleAllocatorCallback comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
