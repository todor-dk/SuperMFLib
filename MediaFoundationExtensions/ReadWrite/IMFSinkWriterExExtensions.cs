using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.ReadWrite;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFSinkWriterEx"/> interface.
    /// </summary>
    public static class IMFSinkWriterExExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFSinkWriterEx"/>
        /// interface into a <see cref="SinkWriterEx"/> COM wrapper object.
        /// The <see cref="SinkWriterEx"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFSinkWriterEx"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFSinkWriterEx"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static SinkWriterEx ToSinkWriterEx(this IMFSinkWriterEx self)
        {
            if (self == null)
                return null;
            return new SinkWriterEx(self);
        }
    }
}
