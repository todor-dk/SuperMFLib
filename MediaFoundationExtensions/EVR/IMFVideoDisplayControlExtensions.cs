using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFVideoDisplayControl"/> interface.
    /// </summary>
    public static class IMFVideoDisplayControlExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFVideoDisplayControl"/>
        /// interface into a <see cref="VideoDisplayControl"/> COM wrapper object.
        /// The <see cref="VideoDisplayControl"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFVideoDisplayControl"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFVideoDisplayControl"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static VideoDisplayControl ToVideoDisplayControl(this IMFVideoDisplayControl self)
        {
            if (self == null)
                return null;
            return new VideoDisplayControl(self);
        }
    }
}
