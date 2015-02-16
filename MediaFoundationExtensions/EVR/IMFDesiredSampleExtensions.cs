using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFDesiredSample"/> interface.
    /// </summary>
    public static class IMFDesiredSampleExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFDesiredSample"/>
        /// interface into a <see cref="DesiredSample"/> COM wrapper object.
        /// The <see cref="DesiredSample"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFDesiredSample"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFDesiredSample"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static DesiredSample ToDesiredSample(this IMFDesiredSample self)
        {
            if (self == null)
                return null;
            return new DesiredSample(self);
        }
    }
}
