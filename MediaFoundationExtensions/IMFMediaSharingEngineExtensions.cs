using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFMediaSharingEngine"/> interface.
    /// </summary>
    public static class IMFMediaSharingEngineExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFMediaSharingEngine"/>
        /// interface into a <see cref="MediaSharingEngine"/> COM wrapper object.
        /// The <see cref="MediaSharingEngine"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFMediaSharingEngine"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFMediaSharingEngine"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static MediaSharingEngine ToMediaSharingEngine(this IMFMediaSharingEngine self)
        {
            if (self == null)
                return null;
            return new MediaSharingEngine(self);
        }
    }
}
