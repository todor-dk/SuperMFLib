using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="QualityManager"/> class implements a wrapper arround the
    /// <see cref="IMFQualityManager"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFQualityManager"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFQualityManager"/>: 
    /// Adjusts playback quality. This interface is exposed by the quality manager. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/66781A1F-7469-4222-9E99-6B1415830F4C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/66781A1F-7469-4222-9E99-6B1415830F4C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class QualityManager : COM<IMFQualityManager>
    {
        #region Construction

        internal QualityManager(IMFQualityManager comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
