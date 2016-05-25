using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ContentEnabler"/> class implements a wrapper around the
    /// <see cref="IMFContentEnabler"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFContentEnabler"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFContentEnabler"/>: 
    /// Implements one step that must be performed for the user to access media content. For example, the
    /// steps might be individualization followed by license acquisition. Each of these steps would be
    /// encapsulated by a content enabler object that exposes the <strong>IMFContentEnabler</strong>
    /// interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/45D02BD0-1104-47EC-8559-8CC51590FC62(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/45D02BD0-1104-47EC-8559-8CC51590FC62(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ContentEnabler : COM<IMFContentEnabler>
    {
        #region Construction

        internal ContentEnabler(IMFContentEnabler comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
