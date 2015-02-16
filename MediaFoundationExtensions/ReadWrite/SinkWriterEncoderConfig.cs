using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.ReadWrite;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SinkWriterEncoderConfig"/> class implements a wrapper arround the
    /// <see cref="IMFSinkWriterEncoderConfig"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSinkWriterEncoderConfig"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSinkWriterEncoderConfig"/>: 
    /// Provides additional functionality on the sink writer for dynamically changing the media type and
    /// encoder configuration. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3A0D090D-9EB1-4624-989B-C5DA27B988AA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3A0D090D-9EB1-4624-989B-C5DA27B988AA(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SinkWriterEncoderConfig : COM<IMFSinkWriterEncoderConfig>
    {
        #region Construction

        internal SinkWriterEncoderConfig(IMFSinkWriterEncoderConfig comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
