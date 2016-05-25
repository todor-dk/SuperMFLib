using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaSourceAlt"/> class implements a wrapper around the
    /// <see cref="IMFMediaSourceAlt"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaSourceAlt"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaSourceAlt"/>: 
    /// Implemented by media source objects.
    /// <para/>
    /// Media sources are objects that generate media data. For example, the data might come from a video
    /// file, a network stream, or a hardware device, such as a camera. Each media source contains one or
    /// more streams, and each stream delivers data of one type, such as audio or video.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8B579F61-6FEA-4B20-A051-7633FC01FA05(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8B579F61-6FEA-4B20-A051-7633FC01FA05(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaSourceAlt : COM<IMFMediaSourceAlt>
    {
        #region Construction

        internal MediaSourceAlt(IMFMediaSourceAlt comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
