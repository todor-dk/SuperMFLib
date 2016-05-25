using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="VideoDeviceID"/> class implements a wrapper around the
    /// <see cref="IMFVideoDeviceID"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoDeviceID"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoDeviceID"/>: 
    /// Returns the device identifier supported by a video renderer component. This interface is
    /// implemented by mixers and presenters for the enhanced video renderer (EVR). If you replace either
    /// of these components, the mixer and presenter must report the same device identifier.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C42B75F9-6B72-4AAB-92F2-3361AB475CE9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C42B75F9-6B72-4AAB-92F2-3361AB475CE9(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoDeviceID : COM<IMFVideoDeviceID>
    {
        #region Construction

        internal VideoDeviceID(IMFVideoDeviceID comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
