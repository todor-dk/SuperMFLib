using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="AdvancedMediaCaptureInitializationSettings"/> class implements a wrapper around the
    /// <see cref="IAdvancedMediaCaptureInitializationSettings"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IAdvancedMediaCaptureInitializationSettings"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IAdvancedMediaCaptureInitializationSettings"/>: 
    /// Provides initialization settings for advanced media capture.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8A7978C1-1919-4B49-9848-6D972E3E94F5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8A7978C1-1919-4B49-9848-6D972E3E94F5(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class AdvancedMediaCaptureInitializationSettings : COM<IAdvancedMediaCaptureInitializationSettings>
    {
        #region Construction

        internal AdvancedMediaCaptureInitializationSettings(IAdvancedMediaCaptureInitializationSettings comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
