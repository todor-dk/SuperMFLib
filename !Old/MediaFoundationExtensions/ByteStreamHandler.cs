using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ByteStreamHandler"/> class implements a wrapper around the
    /// <see cref="IMFByteStreamHandler"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFByteStreamHandler"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFByteStreamHandler"/>: 
    /// Creates a media source from a byte stream. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/80C402D4-8246-42EE-A981-69C8D605CB0F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/80C402D4-8246-42EE-A981-69C8D605CB0F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ByteStreamHandler : COM<IMFByteStreamHandler>
    {
        #region Construction

        internal ByteStreamHandler(IMFByteStreamHandler comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
