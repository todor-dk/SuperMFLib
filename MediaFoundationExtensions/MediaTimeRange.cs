using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaTimeRange"/> class implements a wrapper around the
    /// <see cref="IMFMediaTimeRange"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaTimeRange"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaTimeRange"/>: 
    /// Represents a list of time ranges, where each range is defined by a start and end time.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E39646E6-66F4-4413-A84B-43039689AEE7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E39646E6-66F4-4413-A84B-43039689AEE7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaTimeRange : COM<IMFMediaTimeRange>
    {
        #region Construction

        internal MediaTimeRange(IMFMediaTimeRange comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
