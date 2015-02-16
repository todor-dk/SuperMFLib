using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SampleGrabberSinkCallback"/> class implements a wrapper arround the
    /// <see cref="IMFSampleGrabberSinkCallback"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSampleGrabberSinkCallback"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSampleGrabberSinkCallback"/>: 
    /// Callback interface to get media data from the sample-grabber sink. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6635823C-F532-4012-AD3C-382491B61671(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6635823C-F532-4012-AD3C-382491B61671(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SampleGrabberSinkCallback : COM<IMFSampleGrabberSinkCallback>
    {
        #region Construction

        internal SampleGrabberSinkCallback(IMFSampleGrabberSinkCallback comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
