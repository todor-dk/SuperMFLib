using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="TrackedSample"/> class implements a wrapper around the
    /// <see cref="IMFTrackedSample"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTrackedSample"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTrackedSample"/>: 
    /// Tracks the reference counts on a video media sample. Video samples created by the 
    /// <see cref="MFExtern.MFCreateVideoSampleFromSurface"/> function expose this interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/4AD4B14C-94AF-4314-8A16-163579DEC67F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4AD4B14C-94AF-4314-8A16-163579DEC67F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class TrackedSample : COM<IMFTrackedSample>
    {
        #region Construction

        internal TrackedSample(IMFTrackedSample comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
