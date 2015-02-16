using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="GetServiceAlt"/> class implements a wrapper arround the
    /// <see cref="IMFGetServiceAlt"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFGetServiceAlt"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFGetServiceAlt"/>: 
    /// Queries an object for a specified service interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/102A1DFF-8419-4F86-A145-53CE3D0123F5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/102A1DFF-8419-4F86-A145-53CE3D0123F5(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class GetServiceAlt : COM<IMFGetServiceAlt>
    {
        #region Construction

        internal GetServiceAlt(IMFGetServiceAlt comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
