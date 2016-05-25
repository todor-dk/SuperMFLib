using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEngineSrcElements"/> class implements a wrapper around the
    /// <see cref="IMFMediaEngineSrcElements"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEngineSrcElements"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEngineSrcElements"/>: 
    /// Provides the Media Engine with a list of media resources.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/37A3EAC0-639C-47F3-AAB9-588EBEC8E1E3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/37A3EAC0-639C-47F3-AAB9-588EBEC8E1E3(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEngineSrcElements : COM<IMFMediaEngineSrcElements>
    {
        #region Construction

        internal MediaEngineSrcElements(IMFMediaEngineSrcElements comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
