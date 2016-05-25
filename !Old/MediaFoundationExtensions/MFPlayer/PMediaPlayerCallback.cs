using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.MFPlayer;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PMediaPlayerCallback"/> class implements a wrapper around the
    /// <see cref="IMFPMediaPlayerCallback"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFPMediaPlayerCallback"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFPMediaPlayerCallback"/>: 
    /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
    /// Applications should use the <c>Media Session</c> for playback. 
    /// <para/>
    /// Callback interface for the <see cref="MFPlayer.IMFPMediaPlayer"/> interface. 
    /// <para/>
    /// To set the callback, pass an <strong>IMFPMediaPlayerCallback</strong> pointer to the 
    /// <see cref="MFExtern.MFPCreateMediaPlayer"/> function in the <em>pCallback</em> parameter. The
    /// application implements the <strong>IMFPMediaPlayerCallback</strong> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7D9D01BF-861A-4C35-93B1-DBF85CBF0A32(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7D9D01BF-861A-4C35-93B1-DBF85CBF0A32(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PMediaPlayerCallback : COM<IMFPMediaPlayerCallback>
    {
        #region Construction

        internal PMediaPlayerCallback(IMFPMediaPlayerCallback comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
