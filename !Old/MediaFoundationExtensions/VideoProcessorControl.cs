using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="VideoProcessorControl"/> class implements a wrapper around the
    /// <see cref="IMFVideoProcessorControl"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoProcessorControl"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoProcessorControl"/>: 
    /// Configures the <c>Video Processor MFT</c>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6803B69E-CF84-45D5-804C-BD961BD5E13D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6803B69E-CF84-45D5-804C-BD961BD5E13D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoProcessorControl : COM<IMFVideoProcessorControl>
    {
        #region Construction

        internal VideoProcessorControl(IMFVideoProcessorControl comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
