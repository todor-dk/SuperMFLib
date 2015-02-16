using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFStreamSinkAlt"/> interface.
    /// </summary>
    public static class IMFStreamSinkAltExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFStreamSinkAlt"/>
        /// interface into a <see cref="StreamSinkAlt"/> COM wrapper object.
        /// The <see cref="StreamSinkAlt"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFStreamSinkAlt"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFStreamSinkAlt"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static StreamSinkAlt ToStreamSinkAlt(this IMFStreamSinkAlt self)
        {
            if (self == null)
                return null;
            return new StreamSinkAlt(self);
        }
    }
}
