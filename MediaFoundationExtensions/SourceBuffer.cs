using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SourceBuffer"/> class implements a wrapper around the
    /// <see cref="IMFSourceBuffer"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSourceBuffer"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSourceBuffer"/>: 
    /// Represents a buffer which contains media data for a <c>IMFMediaSourceExtension</c>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F241E232-9013-46D0-BE97-2D6B5246CFF3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F241E232-9013-46D0-BE97-2D6B5246CFF3(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SourceBuffer : COM<IMFSourceBuffer>
    {
        #region Construction

        internal SourceBuffer(IMFSourceBuffer comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
