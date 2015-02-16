using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="NamedPropertyStore"/> class implements a wrapper arround the
    /// <see cref="INamedPropertyStore"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="INamedPropertyStore"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="INamedPropertyStore"/>: 
    /// Exposes methods that get and set named properties.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/5F7997BA-A5C8-42B5-90C8-5CB34AFD6092(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5F7997BA-A5C8-42B5-90C8-5CB34AFD6092(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class NamedPropertyStore : COM<INamedPropertyStore>
    {
        #region Construction

        internal NamedPropertyStore(INamedPropertyStore comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
