using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="WorkQueueServicesEx"/> class implements a wrapper arround the
    /// <see cref="IMFWorkQueueServicesEx"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFWorkQueueServicesEx"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFWorkQueueServicesEx"/>: 
    /// Extends the <see cref="IMFWorkQueueServices"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/12D4F0F4-9A6D-4782-B5AE-4ADD6608782A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/12D4F0F4-9A6D-4782-B5AE-4ADD6608782A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class WorkQueueServicesEx : COM<IMFWorkQueueServicesEx>
    {
        #region Construction

        internal WorkQueueServicesEx(IMFWorkQueueServicesEx comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
