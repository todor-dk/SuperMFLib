using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFSystemId"/> interface.
    /// </summary>
    public static class IMFSystemIdExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFSystemId"/>
        /// interface into a <see cref="SystemId"/> COM wrapper object.
        /// The <see cref="SystemId"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFSystemId"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFSystemId"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static SystemId ToSystemId(this IMFSystemId self)
        {
            if (self == null)
                return null;
            return new SystemId(self);
        }
    }
}
