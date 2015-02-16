using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PMPClientApp"/> class implements a wrapper arround the
    /// <see cref="IMFPMPClientApp"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFPMPClientApp"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFPMPClientApp"/>: 
    /// Provides a mechanism for a media source to implement content protection functionality in a Windows
    /// Store apps.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/03CD9E3C-65AC-40AD-802D-E36127DBD61F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/03CD9E3C-65AC-40AD-802D-E36127DBD61F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PMPClientApp : COM<IMFPMPClientApp>
    {
        #region Construction

        internal PMPClientApp(IMFPMPClientApp comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
