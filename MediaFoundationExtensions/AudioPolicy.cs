using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="AudioPolicy"/> class implements a wrapper arround the
    /// <see cref="IMFAudioPolicy"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFAudioPolicy"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFAudioPolicy"/>: 
    /// Configures the audio session that is associated with the streaming audio renderer (SAR). Use this
    /// interface to change how the audio session appears in the Windows volume control.
    /// <para/>
    /// The SAR exposes this interface as a service. To get a pointer to the interface, call 
    /// <see cref="IMFGetService.GetService"/> with the service identifier MR_AUDIO_POLICY_SERVICE. You can
    /// call <strong>GetService</strong> directly on the SAR or call it on the Media Session. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FCD4DBFB-3F9F-4089-B9CC-7B41B2C2678A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FCD4DBFB-3F9F-4089-B9CC-7B41B2C2678A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class AudioPolicy : COM<IMFAudioPolicy>
    {
        #region Construction

        internal AudioPolicy(IMFAudioPolicy comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
