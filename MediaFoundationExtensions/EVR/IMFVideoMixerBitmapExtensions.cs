using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFVideoMixerBitmap"/> interface.
    /// </summary>
    public static class IMFVideoMixerBitmapExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFVideoMixerBitmap"/>
        /// interface into a <see cref="VideoMixerBitmap"/> COM wrapper object.
        /// The <see cref="VideoMixerBitmap"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFVideoMixerBitmap"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFVideoMixerBitmap"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static VideoMixerBitmap ToVideoMixerBitmap(this IMFVideoMixerBitmap self)
        {
            if (self == null)
                return null;
            return new VideoMixerBitmap(self);
        }
    }
}
