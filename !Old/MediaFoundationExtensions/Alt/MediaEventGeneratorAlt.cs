using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEventGeneratorAlt"/> class implements a wrapper around the
    /// <see cref="IMFMediaEventGeneratorAlt"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEventGeneratorAlt"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEventGeneratorAlt"/>: 
    /// Retrieves events from any Media Foundation object that generates events. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A37D0840-C896-43A0-B3D1-C2A6AAFF1B25(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A37D0840-C896-43A0-B3D1-C2A6AAFF1B25(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEventGeneratorAlt : COM<IMFMediaEventGeneratorAlt>
    {
        #region Construction

        internal MediaEventGeneratorAlt(IMFMediaEventGeneratorAlt comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
