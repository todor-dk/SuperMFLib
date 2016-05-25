using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="OutputPolicy"/> class implements a wrapper around the
    /// <see cref="IMFOutputPolicy"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFOutputPolicy"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFOutputPolicy"/>: 
    /// Encapsulates a usage policy from an input trust authority (ITA). Output trust authorities (OTAs)
    /// use this interface to query which protection systems they are required to enforce by the ITA.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/76AF8E03-9584-4F4B-AB2C-8A0FF2C3485B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/76AF8E03-9584-4F4B-AB2C-8A0FF2C3485B(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class OutputPolicy : COM<IMFOutputPolicy>
    {
        #region Construction

        internal OutputPolicy(IMFOutputPolicy comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
