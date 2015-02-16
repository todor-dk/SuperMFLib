using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ByteStreamBuffering"/> class implements a wrapper arround the
    /// <see cref="IMFByteStreamBuffering"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFByteStreamBuffering"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFByteStreamBuffering"/>: 
    /// Controls how a byte stream buffers data from a network. 
    /// <para/>
    /// To get a pointer to this interface, call <strong>QueryInterface</strong> on the byte stream object.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BBF9CDB1-5EC7-498A-AA59-85C24779547E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BBF9CDB1-5EC7-498A-AA59-85C24779547E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ByteStreamBuffering : COM<IMFByteStreamBuffering>
    {
        #region Construction

        internal ByteStreamBuffering(IMFByteStreamBuffering comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
