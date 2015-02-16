using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFShutdown"/> interface.
    /// </summary>
    public static class IMFShutdownExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFShutdown"/>
        /// interface into a <see cref="Shutdown"/> COM wrapper object.
        /// The <see cref="Shutdown"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFShutdown"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFShutdown"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static Shutdown ToShutdown(this IMFShutdown self)
        {
            if (self == null)
                return null;
            return new Shutdown(self);
        }
    }
}
