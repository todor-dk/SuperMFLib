using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEngineExtension"/> class implements a wrapper arround the
    /// <see cref="IMFMediaEngineExtension"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEngineExtension"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEngineExtension"/>: 
    /// Enables an application to load media resources in the Media Engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A032E0D0-2201-4B81-9FE0-8E9CE2707FDB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A032E0D0-2201-4B81-9FE0-8E9CE2707FDB(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEngineExtension : COM<IMFMediaEngineExtension>
    {
        #region Construction

        internal MediaEngineExtension(IMFMediaEngineExtension comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
