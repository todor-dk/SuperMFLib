using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="AudioMediaType"/> class implements a wrapper arround the
    /// <see cref="IMFAudioMediaType"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFAudioMediaType"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFAudioMediaType"/>: 
    /// [ <strong>IMFAudioMediaType</strong> is no longer available for use as of Windows 7. Instead, use
    /// the media type attributes to get the properties of the audio format.] 
    /// <para/>
    /// Represents a description of an audio format.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/425A4A37-6FD3-4724-9D18-C39CC2862EF7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/425A4A37-6FD3-4724-9D18-C39CC2862EF7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class AudioMediaType : COM<IMFAudioMediaType>
    {
        #region Construction

        internal AudioMediaType(IMFAudioMediaType comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
