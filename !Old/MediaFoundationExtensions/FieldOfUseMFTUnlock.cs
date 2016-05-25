using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="FieldOfUseMFTUnlock"/> class implements a wrapper around the
    /// <see cref="IMFFieldOfUseMFTUnlock"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFFieldOfUseMFTUnlock"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFFieldOfUseMFTUnlock"/>: 
    /// Enables an application to use a Media Foundation transform (MFT) that has restrictions on its use.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B144589B-D559-4686-B617-0E3C393380E9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B144589B-D559-4686-B617-0E3C393380E9(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class FieldOfUseMFTUnlock : COM<IMFFieldOfUseMFTUnlock>
    {
        #region Construction

        internal FieldOfUseMFTUnlock(IMFFieldOfUseMFTUnlock comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
