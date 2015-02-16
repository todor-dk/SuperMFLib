using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.ReadWrite;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SourceReaderEx"/> class implements a wrapper arround the
    /// <see cref="IMFSourceReaderEx"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSourceReaderEx"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSourceReaderEx"/>: 
    /// Extends the <see cref="ReadWrite.IMFSourceReader"/> interface. 
    /// <para/>
    /// The <c>Source Reader</c> implements this interface in Windows 8. To get a pointer to this
    /// interface, call <c>QueryInterface</c> on the Source Reader. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/59888F9B-C464-4045-AA77-03EE16E2B598(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/59888F9B-C464-4045-AA77-03EE16E2B598(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SourceReaderEx : COM<IMFSourceReaderEx>
    {
        #region Construction

        internal SourceReaderEx(IMFSourceReaderEx comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
