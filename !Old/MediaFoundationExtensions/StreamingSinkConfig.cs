using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="StreamingSinkConfig"/> class implements a wrapper around the
    /// <see cref="IMFStreamingSinkConfig"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFStreamingSinkConfig"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFStreamingSinkConfig"/>: 
    /// Passes configuration information to the media sinks that are used for streaming the content. 
    /// Optionally, this interface is supported by media sinks. The built-in ASF streaming media sink and
    /// the MP3 media sink implement this interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/5EAEF815-9660-487A-885D-457CD270BA3D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5EAEF815-9660-487A-885D-457CD270BA3D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class StreamingSinkConfig : COM<IMFStreamingSinkConfig>
    {
        #region Construction

        internal StreamingSinkConfig(IMFStreamingSinkConfig comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
