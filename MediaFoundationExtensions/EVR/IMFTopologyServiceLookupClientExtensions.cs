using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFTopologyServiceLookupClient"/> interface.
    /// </summary>
    public static class IMFTopologyServiceLookupClientExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFTopologyServiceLookupClient"/>
        /// interface into a <see cref="TopologyServiceLookupClient"/> COM wrapper object.
        /// The <see cref="TopologyServiceLookupClient"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFTopologyServiceLookupClient"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFTopologyServiceLookupClient"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static TopologyServiceLookupClient ToTopologyServiceLookupClient(this IMFTopologyServiceLookupClient self)
        {
            if (self == null)
                return null;
            return new TopologyServiceLookupClient(self);
        }
    }
}
