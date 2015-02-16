using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SecureChannel"/> class implements a wrapper arround the
    /// <see cref="IMFSecureChannel"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSecureChannel"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSecureChannel"/>: 
    /// Establishes a one-way secure channel between two objects. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/063170B8-9483-4ACD-9B42-A226E9C38F0E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/063170B8-9483-4ACD-9B42-A226E9C38F0E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SecureChannel : COM<IMFSecureChannel>
    {
        #region Construction

        internal SecureChannel(IMFSecureChannel comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
