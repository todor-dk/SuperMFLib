using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFMediaStreamAlt"/> interface.
    /// </summary>
    public static class IMFMediaStreamAltExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFMediaStreamAlt"/>
        /// interface into a <see cref="MediaStreamAlt"/> COM wrapper object.
        /// The <see cref="MediaStreamAlt"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFMediaStreamAlt"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFMediaStreamAlt"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static MediaStreamAlt ToMediaStreamAlt(this IMFMediaStreamAlt self)
        {
            if (self == null)
                return null;
            return new MediaStreamAlt(self);
        }
    }
}
