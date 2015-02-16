using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.ReadWrite;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SourceReaderCallback"/> class implements a wrapper arround the
    /// <see cref="IMFSourceReaderCallback"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSourceReaderCallback"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSourceReaderCallback"/>: 
    /// Callback interface for the Microsoft Media Foundation source reader.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FFF8B6E6-5D56-4301-B3CE-F3FF49398593(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FFF8B6E6-5D56-4301-B3CE-F3FF49398593(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SourceReaderCallback : COM<IMFSourceReaderCallback>
    {
        #region Construction

        internal SourceReaderCallback(IMFSourceReaderCallback comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
