using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFTopologyServiceLookupClientAlt"/> interface.
    /// </summary>
    public static class IMFTopologyServiceLookupClientAltExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFTopologyServiceLookupClientAlt"/>
        /// interface into a <see cref="TopologyServiceLookupClientAlt"/> COM wrapper object.
        /// The <see cref="TopologyServiceLookupClientAlt"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFTopologyServiceLookupClientAlt"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFTopologyServiceLookupClientAlt"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static TopologyServiceLookupClientAlt ToTopologyServiceLookupClientAlt(this IMFTopologyServiceLookupClientAlt self)
        {
            if (self == null)
                return null;
            return new TopologyServiceLookupClientAlt(self);
        }
    }
}
