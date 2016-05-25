using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="EVRVideoStreamControl"/> class implements a wrapper around the
    /// <see cref="IEVRVideoStreamControl"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IEVRVideoStreamControl"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IEVRVideoStreamControl"/>: 
    /// This interface is not supported.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/EA7B0DD2-2EFF-4A37-826B-6F87FBEA5785(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EA7B0DD2-2EFF-4A37-826B-6F87FBEA5785(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class EVRVideoStreamControl : COM<IEVRVideoStreamControl>
    {
        #region Construction

        internal EVRVideoStreamControl(IEVRVideoStreamControl comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
