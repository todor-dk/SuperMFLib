using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SchemeHandler"/> class implements a wrapper arround the
    /// <see cref="IMFSchemeHandler"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSchemeHandler"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSchemeHandler"/>: 
    /// Creates a media source or a byte stream from a URL. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A342054E-2CB5-494A-A2F7-D144C72D1FA5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A342054E-2CB5-494A-A2F7-D144C72D1FA5(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SchemeHandler : COM<IMFSchemeHandler>
    {
        #region Construction

        internal SchemeHandler(IMFSchemeHandler comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
