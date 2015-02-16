using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.MFPlayer;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFPMediaPlayerCallback"/> interface.
    /// </summary>
    public static class IMFPMediaPlayerCallbackExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFPMediaPlayerCallback"/>
        /// interface into a <see cref="PMediaPlayerCallback"/> COM wrapper object.
        /// The <see cref="PMediaPlayerCallback"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFPMediaPlayerCallback"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFPMediaPlayerCallback"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static PMediaPlayerCallback ToPMediaPlayerCallback(this IMFPMediaPlayerCallback self)
        {
            if (self == null)
                return null;
            return new PMediaPlayerCallback(self);
        }
    }
}
