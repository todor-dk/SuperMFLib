using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ByteStreamCacheControl2"/> class implements a wrapper arround the
    /// <see cref="IMFByteStreamCacheControl2"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFByteStreamCacheControl2"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFByteStreamCacheControl2"/>: 
    /// Controls how a network byte stream transfers data to a local cache. This interface extends the 
    /// <see cref="IMFByteStreamCacheControl"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A901F679-B6F2-4DB7-8EFC-EA61249B64FB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A901F679-B6F2-4DB7-8EFC-EA61249B64FB(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ByteStreamCacheControl2 : COM<IMFByteStreamCacheControl2>
    {
        #region Construction

        internal ByteStreamCacheControl2(IMFByteStreamCacheControl2 comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
