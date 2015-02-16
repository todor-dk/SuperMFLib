using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="FinalizableMediaSink"/> class implements a wrapper arround the
    /// <see cref="IMFFinalizableMediaSink"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFFinalizableMediaSink"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFFinalizableMediaSink"/>: 
    /// Optionally supported by media sinks to perform required tasks before shutdown. This interface is
    /// typically exposed by archive sinks—that is, media sinks that write to a file. It is used to perform
    /// tasks such as flushing data to disk or updating a file header.
    /// <para/>
    /// To get a pointer to this interface, call <strong>QueryInterface</strong> on the media sink. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E60C2773-F2FC-469E-A698-036390CBED16(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E60C2773-F2FC-469E-A698-036390CBED16(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class FinalizableMediaSink : COM<IMFFinalizableMediaSink>
    {
        #region Construction

        internal FinalizableMediaSink(IMFFinalizableMediaSink comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
