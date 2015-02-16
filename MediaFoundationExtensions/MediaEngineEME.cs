using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEngineEME"/> class implements a wrapper around the
    /// <see cref="IMFMediaEngineEME"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEngineEME"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEngineEME"/>: 
    /// Implemented by the media engine to add encrypted media extensions methods.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D03045D5-BAFE-4E65-98DA-E9EA8104C169(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D03045D5-BAFE-4E65-98DA-E9EA8104C169(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEngineEME : COM<IMFMediaEngineEME>
    {
        #region Construction

        internal MediaEngineEME(IMFMediaEngineEME comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
