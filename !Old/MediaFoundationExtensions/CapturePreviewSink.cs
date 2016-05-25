using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="CapturePreviewSink"/> class implements a wrapper around the
    /// <see cref="IMFCapturePreviewSink"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFCapturePreviewSink"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFCapturePreviewSink"/>: 
    /// Controls the preview sink. The preview sink enables the application to preview audio and video from
    /// the camera.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/5E64C24D-D6EC-419B-9DC8-309EBCE0077E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5E64C24D-D6EC-419B-9DC8-309EBCE0077E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class CapturePreviewSink : COM<IMFCapturePreviewSink>
    {
        #region Construction

        internal CapturePreviewSink(IMFCapturePreviewSink comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
