using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="CaptureSource"/> class implements a wrapper arround the
    /// <see cref="IMFCaptureSource"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFCaptureSource"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFCaptureSource"/>: 
    /// Controls the capture source object. The capture source manages the audio and video capture devices.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/864B6B5D-EB7E-4C49-A326-9B6704A27635(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/864B6B5D-EB7E-4C49-A326-9B6704A27635(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class CaptureSource : COM<IMFCaptureSource>
    {
        #region Construction

        internal CaptureSource(IMFCaptureSource comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
