using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.MFPlayer;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFPMediaPlayer"/> interface.
    /// </summary>
    public static class IMFPMediaPlayerExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFPMediaPlayer"/>
        /// interface into a <see cref="PMediaPlayer"/> COM wrapper object.
        /// The <see cref="PMediaPlayer"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFPMediaPlayer"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFPMediaPlayer"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static PMediaPlayer ToPMediaPlayer(this IMFPMediaPlayer self)
        {
            if (self == null)
                return null;
            return new PMediaPlayer(self);
        }
    }
}
