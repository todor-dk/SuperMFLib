using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="TrustedInput"/> class implements a wrapper arround the
    /// <see cref="IMFTrustedInput"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTrustedInput"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTrustedInput"/>: 
    /// Implemented by components that provide input trust authorities (ITAs). This interface is used to
    /// get the ITA for each of the component's streams. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/59A9DEF7-69A6-4F80-BB5E-1CB372FF6EAB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/59A9DEF7-69A6-4F80-BB5E-1CB372FF6EAB(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class TrustedInput : COM<IMFTrustedInput>
    {
        #region Construction

        internal TrustedInput(IMFTrustedInput comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
