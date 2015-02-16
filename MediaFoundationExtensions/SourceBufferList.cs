using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SourceBufferList"/> class implements a wrapper arround the
    /// <see cref="IMFSourceBufferList"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSourceBufferList"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSourceBufferList"/>: 
    /// Represents a collection of <c>IMFSourceBuffer</c> objects. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/26F66C2D-5F84-485F-BC86-C8399666C9F1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/26F66C2D-5F84-485F-BC86-C8399666C9F1(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SourceBufferList : COM<IMFSourceBufferList>
    {
        #region Construction

        internal SourceBufferList(IMFSourceBufferList comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
