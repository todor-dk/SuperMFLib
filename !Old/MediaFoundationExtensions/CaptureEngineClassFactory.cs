using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="CaptureEngineClassFactory"/> class implements a wrapper around the
    /// <see cref="IMFCaptureEngineClassFactory"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFCaptureEngineClassFactory"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFCaptureEngineClassFactory"/>: 
    /// Creates an instance of the capture engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FAFA52AD-B96E-4ADC-BE79-3BE5F1ACC92A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FAFA52AD-B96E-4ADC-BE79-3BE5F1ACC92A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class CaptureEngineClassFactory : COM<IMFCaptureEngineClassFactory>
    {
        #region Construction

        internal CaptureEngineClassFactory(IMFCaptureEngineClassFactory comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
