using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFMediaEventGeneratorAlt"/> interface.
    /// </summary>
    public static class IMFMediaEventGeneratorAltExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFMediaEventGeneratorAlt"/>
        /// interface into a <see cref="MediaEventGeneratorAlt"/> COM wrapper object.
        /// The <see cref="MediaEventGeneratorAlt"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFMediaEventGeneratorAlt"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFMediaEventGeneratorAlt"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static MediaEventGeneratorAlt ToMediaEventGeneratorAlt(this IMFMediaEventGeneratorAlt self)
        {
            if (self == null)
                return null;
            return new MediaEventGeneratorAlt(self);
        }
    }
}
