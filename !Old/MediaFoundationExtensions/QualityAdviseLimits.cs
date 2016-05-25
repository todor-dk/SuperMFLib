using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="QualityAdviseLimits"/> class implements a wrapper around the
    /// <see cref="IMFQualityAdviseLimits"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFQualityAdviseLimits"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFQualityAdviseLimits"/>: 
    /// Queries an object for the number of <em>quality modes</em> it supports. Quality modes are used to
    /// adjust the trade-off between quality and speed when rendering audio or video. 
    /// <para/>
    /// The default presenter for the <em>enhanced video renderer</em> (EVR) implements this interface. The
    /// EVR uses the interface to respond to quality messages from the quality manager. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8EF7088C-2F49-4BE9-B719-481616E1737D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8EF7088C-2F49-4BE9-B719-481616E1737D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class QualityAdviseLimits : COM<IMFQualityAdviseLimits>
    {
        #region Construction

        internal QualityAdviseLimits(IMFQualityAdviseLimits comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
