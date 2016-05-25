using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="CaptureSink"/> class implements a wrapper around the
    /// <see cref="IMFCaptureSink"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFCaptureSink"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFCaptureSink"/>: 
    /// Controls a capture sink, which is an object that receives one or more streams from a capture
    /// device.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FBC85FEC-9CD1-45C8-8A2A-04E7BEC483DE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FBC85FEC-9CD1-45C8-8A2A-04E7BEC483DE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class CaptureSink : COM<IMFCaptureSink>
    {
        #region Construction

        internal CaptureSink(IMFCaptureSink comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
