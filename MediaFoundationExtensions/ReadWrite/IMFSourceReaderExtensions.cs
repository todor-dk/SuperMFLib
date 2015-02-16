using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.ReadWrite;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFSourceReader"/> interface.
    /// </summary>
    public static class IMFSourceReaderExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFSourceReader"/>
        /// interface into a <see cref="SourceReader"/> COM wrapper object.
        /// The <see cref="SourceReader"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFSourceReader"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFSourceReader"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static SourceReader ToSourceReader(this IMFSourceReader self)
        {
            if (self == null)
                return null;
            return new SourceReader(self);
        }
    }
}
