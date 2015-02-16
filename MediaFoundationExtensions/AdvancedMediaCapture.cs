using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="AdvancedMediaCapture"/> class implements a wrapper arround the
    /// <see cref="IAdvancedMediaCapture"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IAdvancedMediaCapture"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IAdvancedMediaCapture"/>: 
    /// Enables advanced media capture.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/932B0CBF-C264-4C3B-B143-023DD7F809F1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/932B0CBF-C264-4C3B-B143-023DD7F809F1(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class AdvancedMediaCapture : COM<IAdvancedMediaCapture>
    {
        #region Construction

        internal AdvancedMediaCapture(IAdvancedMediaCapture comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
