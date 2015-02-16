using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFMediaSourceAlt"/> interface.
    /// </summary>
    public static class IMFMediaSourceAltExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFMediaSourceAlt"/>
        /// interface into a <see cref="MediaSourceAlt"/> COM wrapper object.
        /// The <see cref="MediaSourceAlt"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFMediaSourceAlt"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFMediaSourceAlt"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static MediaSourceAlt ToMediaSourceAlt(this IMFMediaSourceAlt self)
        {
            if (self == null)
                return null;
            return new MediaSourceAlt(self);
        }
    }
}
