using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ASFMultiplexer"/> class implements a wrapper around the
    /// <see cref="IMFASFMultiplexer"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFASFMultiplexer"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFASFMultiplexer"/>: 
    /// Provides methods to create Advanced Systems Format (ASF) data packets. The methods of this
    /// interface process input samples into the packets that make up an ASF data section. The ASF
    /// multiplexer exposes this interface. To create the ASF multiplexer, call 
    /// <see cref="MFExtern.MFCreateASFMultiplexer"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BDB549B5-425B-4F77-B413-723CEB7ACD11(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BDB549B5-425B-4F77-B413-723CEB7ACD11(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ASFMultiplexer : COM<IMFASFMultiplexer>
    {
        #region Construction

        internal ASFMultiplexer(IMFASFMultiplexer comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
