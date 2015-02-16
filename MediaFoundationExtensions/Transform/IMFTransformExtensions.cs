using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Transform;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFTransform"/> interface.
    /// </summary>
    public static class IMFTransformExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFTransform"/>
        /// interface into a <see cref="Transform"/> COM wrapper object.
        /// The <see cref="Transform"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFTransform"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFTransform"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static MFTransform ToMFTransform(this IMFTransform self)
        {
            if (self == null)
                return null;
            return new MFTransform(self);
        }
    }
}
