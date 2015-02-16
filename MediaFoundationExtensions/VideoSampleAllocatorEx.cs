using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="VideoSampleAllocatorEx"/> class implements a wrapper around the
    /// <see cref="IMFVideoSampleAllocatorEx"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoSampleAllocatorEx"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoSampleAllocatorEx"/>: 
    /// Allocates video samples that contain Microsoft Direct3D 11 texture surfaces.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B621F413-001B-4419-8FA7-439C45F97243(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B621F413-001B-4419-8FA7-439C45F97243(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoSampleAllocatorEx : COM<IMFVideoSampleAllocatorEx>
    {
        #region Construction

        internal VideoSampleAllocatorEx(IMFVideoSampleAllocatorEx comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
