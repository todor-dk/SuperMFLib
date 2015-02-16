using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.ReadWrite;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SinkWriterEx"/> class implements a wrapper arround the
    /// <see cref="IMFSinkWriterEx"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSinkWriterEx"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSinkWriterEx"/>: 
    /// Extends the <see cref="ReadWrite.IMFSinkWriter"/> interface. 
    /// <para/>
    /// The <c>Sink Writer</c> implements this interface in Windows 8. To get a pointer to this interface,
    /// call <c>QueryInterface</c> on the Sink Writer. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/77E6CB22-E3B5-4D5E-8876-48582F75AA5C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/77E6CB22-E3B5-4D5E-8876-48582F75AA5C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SinkWriterEx : COM<IMFSinkWriterEx>
    {
        #region Construction

        internal SinkWriterEx(IMFSinkWriterEx comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
