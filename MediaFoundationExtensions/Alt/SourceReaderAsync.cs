using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SourceReaderAsync"/> class implements a wrapper around the
    /// <see cref="IMFSourceReaderAsync"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSourceReaderAsync"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSourceReaderAsync"/>: 
    /// Implemented by the Microsoft Media Foundation source reader object.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7D3CC314-6B9E-437C-AFDA-EE1965A12721(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7D3CC314-6B9E-437C-AFDA-EE1965A12721(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SourceReaderAsync : COM<IMFSourceReaderAsync>
    {
        #region Construction

        internal SourceReaderAsync(IMFSourceReaderAsync comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
