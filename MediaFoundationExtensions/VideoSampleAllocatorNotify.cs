using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="VideoSampleAllocatorNotify"/> class implements a wrapper around the
    /// <see cref="IMFVideoSampleAllocatorNotify"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoSampleAllocatorNotify"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoSampleAllocatorNotify"/>: 
    /// The callback for the <see cref="IMFVideoSampleAllocatorCallback"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/909C2A68-81DD-4816-B34F-71A67B620FAF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/909C2A68-81DD-4816-B34F-71A67B620FAF(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoSampleAllocatorNotify : COM<IMFVideoSampleAllocatorNotify>
    {
        #region Construction

        internal VideoSampleAllocatorNotify(IMFVideoSampleAllocatorNotify comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
