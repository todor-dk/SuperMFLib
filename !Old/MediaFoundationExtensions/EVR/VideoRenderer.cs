using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="VideoRenderer"/> class implements a wrapper around the
    /// <see cref="IMFVideoRenderer"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoRenderer"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoRenderer"/>: 
    /// Sets a new mixer or presenter for the <c>Enhanced Video Renderer</c> (EVR). 
    /// <para/>
    /// Both the EVR media sink and the DirectShow EVR filter implement this interface. To get a pointer to
    /// the interface, call <strong>QueryInterface</strong> on the media sink or the filter. Do not use 
    /// <see cref="IMFGetService"/> to get a pointer to this interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/70596630-5131-460F-9CB3-ADCEA201C3B2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/70596630-5131-460F-9CB3-ADCEA201C3B2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoRenderer : COM<IMFVideoRenderer>
    {
        #region Construction

        internal VideoRenderer(IMFVideoRenderer comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
