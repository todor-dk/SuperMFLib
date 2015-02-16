using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="TranscodeSinkInfoProvider"/> class implements a wrapper arround the
    /// <see cref="IMFTranscodeSinkInfoProvider"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTranscodeSinkInfoProvider"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTranscodeSinkInfoProvider"/>: 
    /// Implemented by the transcode sink activation object.
    /// <para/>
    /// The transcode sink activation object can be used to create any of the following file sinks:
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C5EB0C30-559A-44DD-80D4-4B11933DC7CE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C5EB0C30-559A-44DD-80D4-4B11933DC7CE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class TranscodeSinkInfoProvider : COM<IMFTranscodeSinkInfoProvider>
    {
        #region Construction

        internal TranscodeSinkInfoProvider(IMFTranscodeSinkInfoProvider comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
