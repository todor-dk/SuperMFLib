using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SourceOpenMonitor"/> class implements a wrapper around the
    /// <see cref="IMFSourceOpenMonitor"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSourceOpenMonitor"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSourceOpenMonitor"/>: 
    /// Callback interface to receive notifications from a network source on the progress of an
    /// asynchronous open operation.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9145910B-81F1-4FD1-8F6F-D6273E0EDDE6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9145910B-81F1-4FD1-8F6F-D6273E0EDDE6(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SourceOpenMonitor : COM<IMFSourceOpenMonitor>
    {
        #region Construction

        internal SourceOpenMonitor(IMFSourceOpenMonitor comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
