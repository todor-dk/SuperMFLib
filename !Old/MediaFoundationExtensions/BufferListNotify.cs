using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="BufferListNotify"/> class implements a wrapper around the
    /// <see cref="IMFBufferListNotify"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFBufferListNotify"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFBufferListNotify"/>: 
    /// Enables <see cref="IMFSourceBufferList"/> object to notify its clients of important state changes.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280674(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280674(v=vs.85).aspx</a>
    /// </remarks>
    public sealed class BufferListNotify : COM<IMFBufferListNotify>
    {
        #region Construction

        internal BufferListNotify(IMFBufferListNotify comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
