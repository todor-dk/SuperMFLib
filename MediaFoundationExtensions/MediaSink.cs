using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaSink"/> class implements a wrapper arround the
    /// <see cref="IMFMediaSink"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaSink"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaSink"/>: 
    /// Implemented by media sink objects. This interface is the base interface for all Media Foundation
    /// media sinks. Stream sinks handle the actual processing of data on each stream.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/103E6FD8-A18F-480A-8261-099623014659(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/103E6FD8-A18F-480A-8261-099623014659(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaSink : COM<IMFMediaSink>
    {
        #region Construction

        internal MediaSink(IMFMediaSink comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
