using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ByteStreamProxyClassFactory"/> class implements a wrapper around the
    /// <see cref="IMFByteStreamProxyClassFactory"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFByteStreamProxyClassFactory"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFByteStreamProxyClassFactory"/>: 
    /// Creates a proxy to a byte stream.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/DF29B5FC-864F-4400-8EDB-3A2CD797E37A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DF29B5FC-864F-4400-8EDB-3A2CD797E37A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ByteStreamProxyClassFactory : COM<IMFByteStreamProxyClassFactory>
    {
        #region Construction

        internal ByteStreamProxyClassFactory(IMFByteStreamProxyClassFactory comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
