using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.MFPlayer;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PMediaItem"/> class implements a wrapper around the
    /// <see cref="IMFPMediaItem"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFPMediaItem"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFPMediaItem"/>: 
    /// <strong>Note</strong> Deprecated. This API may be removed from future releases of Windows.
    /// Applications should use the <c>Media Session</c> for playback. 
    /// <para/>
    /// Represents a media item. A <em>media item</em> is an abstraction for a source of media data, such
    /// as a video file. Use this interface to get information about the source, or to change certain
    /// playback settings, such as the start and stop times. To get a pointer to this interface, call one
    /// of the following methods: 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/2839D256-BDAF-40CF-9F9D-46F9E2CE59E8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2839D256-BDAF-40CF-9F9D-46F9E2CE59E8(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PMediaItem : COM<IMFPMediaItem>
    {
        #region Construction

        internal PMediaItem(IMFPMediaItem comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
