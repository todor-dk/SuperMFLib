using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ByteStreamTimeSeek"/> class implements a wrapper arround the
    /// <see cref="IMFByteStreamTimeSeek"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFByteStreamTimeSeek"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFByteStreamTimeSeek"/>: 
    /// Seeks a byte stream by time position.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BD9EDFF7-46BA-4788-A44E-C69C4B0BEB50(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BD9EDFF7-46BA-4788-A44E-C69C4B0BEB50(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ByteStreamTimeSeek : COM<IMFByteStreamTimeSeek>
    {
        #region Construction

        internal ByteStreamTimeSeek(IMFByteStreamTimeSeek comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
