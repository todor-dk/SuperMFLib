using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFGetServiceAlt"/> interface.
    /// </summary>
    public static class IMFGetServiceAltExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFGetServiceAlt"/>
        /// interface into a <see cref="GetServiceAlt"/> COM wrapper object.
        /// The <see cref="GetServiceAlt"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFGetServiceAlt"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFGetServiceAlt"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static GetServiceAlt ToGetServiceAlt(this IMFGetServiceAlt self)
        {
            if (self == null)
                return null;
            return new GetServiceAlt(self);
        }
    }
}
