using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="QualityAdvise2"/> class implements a wrapper arround the
    /// <see cref="IMFQualityAdvise2"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFQualityAdvise2"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFQualityAdvise2"/>: 
    /// Enables a pipeline object to adjust its own audio or video quality, in response to quality
    /// messages.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C6114BBC-31D8-45EB-9BF8-745B3138DD50(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C6114BBC-31D8-45EB-9BF8-745B3138DD50(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class QualityAdvise2 : COM<IMFQualityAdvise2>
    {
        #region Construction

        internal QualityAdvise2(IMFQualityAdvise2 comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
