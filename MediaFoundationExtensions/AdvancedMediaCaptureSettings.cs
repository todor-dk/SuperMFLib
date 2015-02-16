using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="AdvancedMediaCaptureSettings"/> class implements a wrapper around the
    /// <see cref="IAdvancedMediaCaptureSettings"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IAdvancedMediaCaptureSettings"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IAdvancedMediaCaptureSettings"/>: 
    /// Provides settings for advanced media capture.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F99669A1-5E6E-4E3B-8907-5FB537ECADFE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F99669A1-5E6E-4E3B-8907-5FB537ECADFE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class AdvancedMediaCaptureSettings : COM<IAdvancedMediaCaptureSettings>
    {
        #region Construction

        internal AdvancedMediaCaptureSettings(IAdvancedMediaCaptureSettings comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
