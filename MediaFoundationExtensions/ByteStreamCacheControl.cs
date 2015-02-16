using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ByteStreamCacheControl"/> class implements a wrapper around the
    /// <see cref="IMFByteStreamCacheControl"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFByteStreamCacheControl"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFByteStreamCacheControl"/>: 
    /// Controls how a network byte stream transfers data to a local cache. Optionally, this interface is
    /// exposed by byte streams that read data from a network, for example, through HTTP. 
    /// <para/>
    /// To get a pointer to this interface, call <strong>QueryInterface</strong> on the byte stream object.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E12A532A-4624-4E06-8E19-6E9DAEC550AC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E12A532A-4624-4E06-8E19-6E9DAEC550AC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ByteStreamCacheControl : COM<IMFByteStreamCacheControl>
    {
        #region Construction

        internal ByteStreamCacheControl(IMFByteStreamCacheControl comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
