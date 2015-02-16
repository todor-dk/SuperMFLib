using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="CapturePhotoSink"/> class implements a wrapper around the
    /// <see cref="IMFCapturePhotoSink"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFCapturePhotoSink"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFCapturePhotoSink"/>: 
    /// Controls the photo sink. The photo sink captures still images from the video stream.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/14BB9A86-47F2-4CFE-A932-3F2C7B6AF2BA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/14BB9A86-47F2-4CFE-A932-3F2C7B6AF2BA(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class CapturePhotoSink : COM<IMFCapturePhotoSink>
    {
        #region Construction

        internal CapturePhotoSink(IMFCapturePhotoSink comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
