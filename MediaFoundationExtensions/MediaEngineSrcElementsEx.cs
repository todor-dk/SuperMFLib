using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEngineSrcElementsEx"/> class implements a wrapper around the
    /// <see cref="IMFMediaEngineSrcElementsEx"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEngineSrcElementsEx"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEngineSrcElementsEx"/>: 
    /// Extends the <see cref="IMFMediaEngineSrcElements"/> interface to provide additional capabilities. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F15CB527-0F46-4887-9E02-835F0115BC5B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F15CB527-0F46-4887-9E02-835F0115BC5B(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEngineSrcElementsEx : COM<IMFMediaEngineSrcElementsEx>
    {
        #region Construction

        internal MediaEngineSrcElementsEx(IMFMediaEngineSrcElementsEx comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
