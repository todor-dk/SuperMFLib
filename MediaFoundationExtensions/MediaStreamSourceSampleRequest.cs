using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaStreamSourceSampleRequest"/> class implements a wrapper around the
    /// <see cref="IMFMediaStreamSourceSampleRequest"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaStreamSourceSampleRequest"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaStreamSourceSampleRequest"/>: 
    /// Represents a request for a  sample from a MediaStreamSource. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/43617CDA-84B1-405F-8A20-BE793413C186(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/43617CDA-84B1-405F-8A20-BE793413C186(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaStreamSourceSampleRequest : COM<IMFMediaStreamSourceSampleRequest>
    {
        #region Construction

        internal MediaStreamSourceSampleRequest(IMFMediaStreamSourceSampleRequest comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
