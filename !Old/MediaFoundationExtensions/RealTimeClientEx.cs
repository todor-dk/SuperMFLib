using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="RealTimeClientEx"/> class implements a wrapper around the
    /// <see cref="IMFRealTimeClientEx"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFRealTimeClientEx"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFRealTimeClientEx"/>: 
    /// Notifies a pipeline object to register itself with the Multimedia Class Scheduler Service (MMCSS). 
    /// <para/>
    /// This interface is a replacement for the <see cref="IMFRealTimeClient"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/EC5CDD23-B862-4DAE-AC01-4926C4FAD89A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EC5CDD23-B862-4DAE-AC01-4926C4FAD89A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class RealTimeClientEx : COM<IMFRealTimeClientEx>
    {
        #region Construction

        internal RealTimeClientEx(IMFRealTimeClientEx comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
