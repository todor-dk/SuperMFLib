using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFAsyncCallbackLogging"/> interface.
    /// </summary>
    public static class IMFAsyncCallbackLoggingExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFAsyncCallbackLogging"/>
        /// interface into a <see cref="AsyncCallbackLogging"/> COM wrapper object.
        /// The <see cref="AsyncCallbackLogging"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFAsyncCallbackLogging"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFAsyncCallbackLogging"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static AsyncCallbackLogging ToAsyncCallbackLogging(this IMFAsyncCallbackLogging self)
        {
            if (self == null)
                return null;
            return new AsyncCallbackLogging(self);
        }
    }
}
