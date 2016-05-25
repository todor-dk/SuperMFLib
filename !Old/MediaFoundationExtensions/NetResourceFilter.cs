using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="NetResourceFilter"/> class implements a wrapper around the
    /// <see cref="IMFNetResourceFilter"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFNetResourceFilter"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFNetResourceFilter"/>: 
    /// Notifies the application when a byte stream requests a URL, and enables the application to block
    /// URL redirection.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/AC8FBD93-B39B-4530-8475-275D3D0DA512(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC8FBD93-B39B-4530-8475-275D3D0DA512(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class NetResourceFilter : COM<IMFNetResourceFilter>
    {
        #region Construction

        internal NetResourceFilter(IMFNetResourceFilter comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
