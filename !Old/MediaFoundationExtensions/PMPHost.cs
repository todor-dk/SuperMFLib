using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PMPHost"/> class implements a wrapper around the
    /// <see cref="IMFPMPHost"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFPMPHost"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFPMPHost"/>: 
    /// Enables a media source in the application process to create objects in the protected media path
    /// (PMP) process.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FAB1FB42-07C5-4A74-B6F5-0950B2C3BA46(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FAB1FB42-07C5-4A74-B6F5-0950B2C3BA46(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PMPHost : COM<IMFPMPHost>
    {
        #region Construction

        internal PMPHost(IMFPMPHost comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
