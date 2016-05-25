using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="_PlayToSourceClassFactory"/> class implements a wrapper around the
    /// <see cref="IPlayToSourceClassFactory"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IPlayToSourceClassFactory"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IPlayToSourceClassFactory"/>: 
    /// Creates an instance of the <c>PlayToSource</c> object. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F8F9FEC6-836C-429A-BADD-5CD1E550AED0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F8F9FEC6-836C-429A-BADD-5CD1E550AED0(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class _PlayToSourceClassFactory : COM<IPlayToSourceClassFactory>
    {
        #region Construction

        internal _PlayToSourceClassFactory(IPlayToSourceClassFactory comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
