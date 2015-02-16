using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFVideoProcessor"/> interface.
    /// </summary>
    public static class IMFVideoProcessorExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFVideoProcessor"/>
        /// interface into a <see cref="VideoProcessor"/> COM wrapper object.
        /// The <see cref="VideoProcessor"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFVideoProcessor"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFVideoProcessor"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static VideoProcessor ToVideoProcessor(this IMFVideoProcessor self)
        {
            if (self == null)
                return null;
            return new VideoProcessor(self);
        }
    }
}
