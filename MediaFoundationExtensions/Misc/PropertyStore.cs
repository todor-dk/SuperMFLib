using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PropertyStore"/> class implements a wrapper around the
    /// <see cref="IPropertyStore"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IPropertyStore"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IPropertyStore"/>: 
    /// Exposes methods for enumerating, getting, and setting property values.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E995AAA1-D4C9-475F-B1FA-B9123CD5B653(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E995AAA1-D4C9-475F-B1FA-B9123CD5B653(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PropertyStore : COM<IPropertyStore>
    {
        #region Construction

        internal PropertyStore(IPropertyStore comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
