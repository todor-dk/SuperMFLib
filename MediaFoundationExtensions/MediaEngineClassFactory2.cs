using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEngineClassFactory2"/> class implements a wrapper arround the
    /// <see cref="IMFMediaEngineClassFactory2"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEngineClassFactory2"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEngineClassFactory2"/>: 
    /// Creates an instance of the <see cref="IMFMediaKeys"/> object.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn449731(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn449731(v=vs.85).aspx</a>
    /// </remarks>
    public sealed class MediaEngineClassFactory2 : COM<IMFMediaEngineClassFactory2>
    {
        #region Construction

        internal MediaEngineClassFactory2(IMFMediaEngineClassFactory2 comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
