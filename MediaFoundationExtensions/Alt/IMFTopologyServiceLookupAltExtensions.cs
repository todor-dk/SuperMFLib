using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFTopologyServiceLookupAlt"/> interface.
    /// </summary>
    public static class IMFTopologyServiceLookupAltExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFTopologyServiceLookupAlt"/>
        /// interface into a <see cref="TopologyServiceLookupAlt"/> COM wrapper object.
        /// The <see cref="TopologyServiceLookupAlt"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFTopologyServiceLookupAlt"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFTopologyServiceLookupAlt"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static TopologyServiceLookupAlt ToTopologyServiceLookupAlt(this IMFTopologyServiceLookupAlt self)
        {
            if (self == null)
                return null;
            return new TopologyServiceLookupAlt(self);
        }
    }
}
