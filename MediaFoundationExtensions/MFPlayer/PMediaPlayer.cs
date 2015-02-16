using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.MFPlayer;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PMediaPlayer"/> class implements a wrapper arround the
    /// <see cref="IMFPMediaPlayer"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFPMediaPlayer"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFPMediaPlayer"/>: 
    /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
    /// Applications should use the <c>Media Session</c> for playback. 
    /// <para/>
    /// Contains methods to play media files.
    /// <para/>
    /// The MFPlay player object exposes this interface. To get a pointer to this interface, call 
    /// <see cref="MFExtern.MFPCreateMediaPlayer"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FA57D465-1EE9-4F7A-9BE8-66A6D73F65E8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FA57D465-1EE9-4F7A-9BE8-66A6D73F65E8(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PMediaPlayer : COM<IMFPMediaPlayer>
    {
        #region Construction

        internal PMediaPlayer(IMFPMediaPlayer comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
