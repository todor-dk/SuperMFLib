using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.ReadWrite;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFSourceReaderCallback"/> interface.
    /// </summary>
    public static class IMFSourceReaderCallbackExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFSourceReaderCallback"/>
        /// interface into a <see cref="SourceReaderCallback"/> COM wrapper object.
        /// The <see cref="SourceReaderCallback"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFSourceReaderCallback"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFSourceReaderCallback"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static SourceReaderCallback ToSourceReaderCallback(this IMFSourceReaderCallback self)
        {
            if (self == null)
                return null;
            return new SourceReaderCallback(self);
        }
    }
}
