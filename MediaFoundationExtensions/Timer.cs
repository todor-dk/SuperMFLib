using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="Timer"/> class implements a wrapper arround the
    /// <see cref="IMFTimer"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTimer"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTimer"/>: 
    /// Provides a timer that invokes a callback at a specified time.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/152594DF-DE3D-4F6F-9277-DBA95AB3533A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/152594DF-DE3D-4F6F-9277-DBA95AB3533A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class Timer : COM<IMFTimer>
    {
        #region Construction

        internal Timer(IMFTimer comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
