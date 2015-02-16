using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFMediaEventQueue"/> interface.
    /// </summary>
    public static class IMFMediaEventQueueExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFMediaEventQueue"/>
        /// interface into a <see cref="MediaEventQueue"/> COM wrapper object.
        /// The <see cref="MediaEventQueue"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFMediaEventQueue"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFMediaEventQueue"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static MediaEventQueue ToMediaEventQueue(this IMFMediaEventQueue self)
        {
            if (self == null)
                return null;
            return new MediaEventQueue(self);
        }
    }
}
