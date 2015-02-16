using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SaveJob"/> class implements a wrapper arround the
    /// <see cref="IMFSaveJob"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSaveJob"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSaveJob"/>: 
    /// Persists media data from a source byte stream to an application-provided byte stream.
    /// <para/>
    /// The byte stream used for HTTP download implements this interface. To get a pointer to this
    /// interface, call <see cref="IMFGetService.GetService"/> on the byte stream, with the service
    /// identifier MFNET_SAVEJOB_SERVICE. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/0F38FA60-ED04-40C4-9BB0-B6E196CD9586(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0F38FA60-ED04-40C4-9BB0-B6E196CD9586(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SaveJob : COM<IMFSaveJob>
    {
        #region Construction

        internal SaveJob(IMFSaveJob comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
