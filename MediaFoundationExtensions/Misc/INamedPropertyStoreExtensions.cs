using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="INamedPropertyStore"/> interface.
    /// </summary>
    public static class INamedPropertyStoreExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="INamedPropertyStore"/>
        /// interface into a <see cref="NamedPropertyStore"/> COM wrapper object.
        /// The <see cref="NamedPropertyStore"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="INamedPropertyStore"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="INamedPropertyStore"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static NamedPropertyStore ToNamedPropertyStore(this INamedPropertyStore self)
        {
            if (self == null)
                return null;
            return new NamedPropertyStore(self);
        }
    }
}
