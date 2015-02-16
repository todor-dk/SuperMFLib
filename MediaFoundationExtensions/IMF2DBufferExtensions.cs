using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMF2DBuffer"/> interface.
    /// </summary>
    public static class IMF2DBufferExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMF2DBuffer"/>
        /// interface into a <see cref="_2DBuffer"/> COM wrapper object.
        /// The <see cref="_2DBuffer"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMF2DBuffer"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMF2DBuffer"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static _2DBuffer To2DBuffer(this IMF2DBuffer self)
        {
            if (self == null)
                return null;
            return new _2DBuffer(self);
        }
    }
}
