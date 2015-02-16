using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFSourceReaderAsync"/> interface.
    /// </summary>
    public static class IMFSourceReaderAsyncExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFSourceReaderAsync"/>
        /// interface into a <see cref="SourceReaderAsync"/> COM wrapper object.
        /// The <see cref="SourceReaderAsync"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFSourceReaderAsync"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFSourceReaderAsync"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static SourceReaderAsync ToSourceReaderAsync(this IMFSourceReaderAsync self)
        {
            if (self == null)
                return null;
            return new SourceReaderAsync(self);
        }
    }
}
