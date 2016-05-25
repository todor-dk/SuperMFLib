using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PMPHostApp"/> class implements a wrapper around the
    /// <see cref="IMFPMPHostApp"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFPMPHostApp"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFPMPHostApp"/>: 
    /// Allows a media source to create a <c>Windows Runtime</c> object in the <c>Protected Media Path</c>
    /// (PMP) process. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/CA24930D-BD1E-4C12-8246-1E505A98944A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CA24930D-BD1E-4C12-8246-1E505A98944A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PMPHostApp : COM<IMFPMPHostApp>
    {
        #region Construction

        internal PMPHostApp(IMFPMPHostApp comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
