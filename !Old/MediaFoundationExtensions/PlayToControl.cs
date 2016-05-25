using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PlayToControl"/> class implements a wrapper around the
    /// <see cref="IPlayToControl"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IPlayToControl"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IPlayToControl"/>: 
    /// Enables the <strong>PlayToConnection</strong> object to connect to a media element. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/53355EEA-559B-4803-89F6-D454E15F9254(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/53355EEA-559B-4803-89F6-D454E15F9254(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PlayToControl : COM<IPlayToControl>
    {
        #region Construction

        internal PlayToControl(IPlayToControl comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
