using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.ReadWrite;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ReadWriteClassFactory"/> class implements a wrapper around the
    /// <see cref="IMFReadWriteClassFactory"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFReadWriteClassFactory"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFReadWriteClassFactory"/>: 
    /// Creates an instance of either the sink writer or the source reader.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/83EF0F0A-AE60-474D-A9E7-7C83A73F6255(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/83EF0F0A-AE60-474D-A9E7-7C83A73F6255(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ReadWriteClassFactory : COM<IMFReadWriteClassFactory>
    {
        #region Construction

        internal ReadWriteClassFactory(IMFReadWriteClassFactory comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
