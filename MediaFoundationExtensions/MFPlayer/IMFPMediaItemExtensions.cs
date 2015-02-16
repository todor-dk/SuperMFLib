using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.MFPlayer;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFPMediaItem"/> interface.
    /// </summary>
    public static class IMFPMediaItemExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFPMediaItem"/>
        /// interface into a <see cref="PMediaItem"/> COM wrapper object.
        /// The <see cref="PMediaItem"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFPMediaItem"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFPMediaItem"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static PMediaItem ToPMediaItem(this IMFPMediaItem self)
        {
            if (self == null)
                return null;
            return new PMediaItem(self);
        }
    }
}
