using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ASFIndexer"/> class implements a wrapper arround the
    /// <see cref="IMFASFIndexer"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFASFIndexer"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFASFIndexer"/>: 
    /// Provides methods to work with indexes in Systems Format (ASF) files. The ASF indexer object exposes
    /// this interface. To create the ASF indexer, call <see cref="MFExtern.MFCreateASFIndexer"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/93127FE4-BCA9-4674-AE21-012367D7DD2F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/93127FE4-BCA9-4674-AE21-012367D7DD2F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ASFIndexer : COM<IMFASFIndexer>
    {
        #region Construction

        internal ASFIndexer(IMFASFIndexer comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
