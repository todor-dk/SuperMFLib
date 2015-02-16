using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="CaptureEngineOnEventCallback"/> class implements a wrapper arround the
    /// <see cref="IMFCaptureEngineOnEventCallback"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFCaptureEngineOnEventCallback"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFCaptureEngineOnEventCallback"/>: 
    /// Callback interface for receiving events from the capture engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6F04F843-160C-4F49-9841-ECC1450F4A58(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6F04F843-160C-4F49-9841-ECC1450F4A58(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class CaptureEngineOnEventCallback : COM<IMFCaptureEngineOnEventCallback>
    {
        #region Construction

        internal CaptureEngineOnEventCallback(IMFCaptureEngineOnEventCallback comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
