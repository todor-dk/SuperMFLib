using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="CaptureSink2"/> class implements a wrapper around the
    /// <see cref="IMFCaptureSink2"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFCaptureSink2"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFCaptureSink2"/>: 
    /// Extends the <see cref="IMFCaptureSink"/> interface to provide functionality for 
    /// dynamically setting the output media type of the record sink or preview sink.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280679(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280679(v=vs.85).aspx</a>
    /// </remarks>
    public sealed class CaptureSink2 : COM<IMFCaptureSink2>
    {
        #region Construction

        internal CaptureSink2(IMFCaptureSink2 comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
