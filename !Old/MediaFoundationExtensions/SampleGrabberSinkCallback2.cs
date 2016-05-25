using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SampleGrabberSinkCallback2"/> class implements a wrapper around the
    /// <see cref="IMFSampleGrabberSinkCallback2"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSampleGrabberSinkCallback2"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSampleGrabberSinkCallback2"/>: 
    /// Extends the <see cref="IMFSampleGrabberSinkCallback"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B303361B-BAAF-4D64-AA5B-A26DD70413F2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B303361B-BAAF-4D64-AA5B-A26DD70413F2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SampleGrabberSinkCallback2 : COM<IMFSampleGrabberSinkCallback2>
    {
        #region Construction

        internal SampleGrabberSinkCallback2(IMFSampleGrabberSinkCallback2 comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
