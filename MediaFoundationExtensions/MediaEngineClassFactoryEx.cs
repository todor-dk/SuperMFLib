using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEngineClassFactoryEx"/> class implements a wrapper around the
    /// <see cref="IMFMediaEngineClassFactoryEx"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEngineClassFactoryEx"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEngineClassFactoryEx"/>: 
    /// Extension for the <see cref="IMFMediaEngineClassFactory"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D672EE59-F702-49C7-8CCF-5BA0260C9B23(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D672EE59-F702-49C7-8CCF-5BA0260C9B23(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEngineClassFactoryEx : COM<IMFMediaEngineClassFactoryEx>
    {
        #region Construction

        internal MediaEngineClassFactoryEx(IMFMediaEngineClassFactoryEx comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
