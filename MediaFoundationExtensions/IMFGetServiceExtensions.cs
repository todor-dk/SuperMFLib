using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFGetService"/> interface.
    /// </summary>
    public static class IMFGetServiceExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFGetService"/>
        /// interface into a <see cref="GetService"/> COM wrapper object.
        /// The <see cref="GetService"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFGetService"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFGetService"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static GetService ToGetService(this IMFGetService self)
        {
            if (self == null)
                return null;
            return new GetService(self);
        }

        /// <summary>
        /// Retrieves the <see cref="IMFGetService"/> interface from the given
        /// <see cref="COM"/> wrapped COM interface and returns an encapsulation
        /// of the <see cref="IMFGetService"/> interface into a <see cref="GetService"/> 
        /// COM wrapper object. If the object does not support the IMFGetService
        /// interface, null is returned.
        /// <para/>
        /// The <see cref="GetService"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFGetService"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of a <see cref="COM"/> wrapped COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the <see cref="IMFGetService"/> interface 
        /// or <stong>null</stong> if <paramref name="self"/> is null or
        /// of <paramref name="self"/> does not support IMFGetService.
        /// </returns>
        public static GetService ToGetService(this COM self)
        {
            if (self == null)
                return null;
            IMFGetService servive = self.GetUniqueReferenceOrNull<IMFGetService>();
            if (servive == null)
                return null;
            return new GetService(servive);
        }
    }
}
