using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SystemId"/> class implements a wrapper arround the
    /// <see cref="IMFSystemId"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSystemId"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSystemId"/>: 
    /// Provides a method that retireves system id data.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/45C80FC5-5EA7-4D4E-9C9C-5A38F62B2D28(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/45C80FC5-5EA7-4D4E-9C9C-5A38F62B2D28(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SystemId : COM<IMFSystemId>
    {
        #region Construction

        internal SystemId(IMFSystemId comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
