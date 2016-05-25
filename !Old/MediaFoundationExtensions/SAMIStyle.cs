using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SAMIStyle"/> class implements a wrapper around the
    /// <see cref="IMFSAMIStyle"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSAMIStyle"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSAMIStyle"/>: 
    /// Sets and retrieves Synchronized Accessible Media Interchange (SAMI) styles on the 
    /// <c>SAMI Media Source</c>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C4887C52-57AF-4783-B853-11FE6AD3510E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C4887C52-57AF-4783-B853-11FE6AD3510E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SAMIStyle : COM<IMFSAMIStyle>
    {
        #region Construction

        internal SAMIStyle(IMFSAMIStyle comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
