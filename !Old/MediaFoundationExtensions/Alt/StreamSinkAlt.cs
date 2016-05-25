using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="StreamSinkAlt"/> class implements a wrapper around the
    /// <see cref="IMFStreamSinkAlt"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFStreamSinkAlt"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFStreamSinkAlt"/>: 
    /// Represents a stream on a media sink object.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FE403CAB-B901-4C8E-A23C-788EE65C4689(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FE403CAB-B901-4C8E-A23C-788EE65C4689(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class StreamSinkAlt : COM<IMFStreamSinkAlt>
    {
        #region Construction

        internal StreamSinkAlt(IMFStreamSinkAlt comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
