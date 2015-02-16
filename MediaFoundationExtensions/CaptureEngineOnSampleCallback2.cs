using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="CaptureEngineOnSampleCallback2"/> class implements a wrapper arround the
    /// <see cref="IMFCaptureEngineOnSampleCallback2"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFCaptureEngineOnSampleCallback2"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFCaptureEngineOnSampleCallback2"/>: 
    /// Extensions for the <see cref="IMFCaptureEngineOnSampleCallback"/> callback interface 
    /// that is used to receive data from the capture engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280677(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280677(v=vs.85).aspx</a>
    /// </remarks>
    public sealed class CaptureEngineOnSampleCallback2 : COM<IMFCaptureEngineOnSampleCallback2>
    {
        #region Construction

        internal CaptureEngineOnSampleCallback2(IMFCaptureEngineOnSampleCallback2 comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
