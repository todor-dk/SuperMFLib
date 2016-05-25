using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PlayToControlWithCapabilities"/> class implements a wrapper around the
    /// <see cref="IPlayToControlWithCapabilities"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IPlayToControlWithCapabilities"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IPlayToControlWithCapabilities"/>: 
    /// Provides functionality for the <c>IPlayToSource</c> to determine the capabilities of the content. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D670F320-30B5-4712-9192-D0976B65DD65(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D670F320-30B5-4712-9192-D0976B65DD65(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PlayToControlWithCapabilities : COM<IPlayToControlWithCapabilities>
    {
        #region Construction

        internal PlayToControlWithCapabilities(IPlayToControlWithCapabilities comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
