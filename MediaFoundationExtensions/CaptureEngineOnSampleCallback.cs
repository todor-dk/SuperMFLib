using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="CaptureEngineOnSampleCallback"/> class implements a wrapper arround the
    /// <see cref="IMFCaptureEngineOnSampleCallback"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFCaptureEngineOnSampleCallback"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFCaptureEngineOnSampleCallback"/>: 
    /// Callback interface to receive data from the capture engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7C621525-CCD2-45EC-9E7A-3A774B96EA6F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7C621525-CCD2-45EC-9E7A-3A774B96EA6F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class CaptureEngineOnSampleCallback : COM<IMFCaptureEngineOnSampleCallback>
    {
        #region Construction

        internal CaptureEngineOnSampleCallback(IMFCaptureEngineOnSampleCallback comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
