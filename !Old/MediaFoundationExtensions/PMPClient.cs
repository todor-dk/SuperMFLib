using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PMPClient"/> class implements a wrapper around the
    /// <see cref="IMFPMPClient"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFPMPClient"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFPMPClient"/>: 
    /// Enables a media source to receive a pointer to the <see cref="IMFPMPHost"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/ADFBA5DD-EAE6-48F3-A155-65BD491C952C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ADFBA5DD-EAE6-48F3-A155-65BD491C952C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PMPClient : COM<IMFPMPClient>
    {
        #region Construction

        internal PMPClient(IMFPMPClient comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
