#if NOT_IMPLEMENTED

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.OPM;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="OPMVideoOutput"/> class implements a wrapper around the
    /// <see cref="IOPMVideoOutput"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IOPMVideoOutput"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IOPMVideoOutput"/>: 
    /// Represents a video output for an <c>Output Protection Manager</c> (OPM) session. 
    /// <para/>
    /// To get a pointer to this interface, call one of the following functions:
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8BF43577-3535-4F62-AC81-BB7E3C329403(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8BF43577-3535-4F62-AC81-BB7E3C329403(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class OPMVideoOutput : COM<IOPMVideoOutput>
    {
        #region Construction

        internal OPMVideoOutput(IOPMVideoOutput comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}

#endif