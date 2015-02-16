using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFQualityAdvise2"/> interface.
    /// </summary>
    public static class IMFQualityAdvise2Extensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFQualityAdvise2"/>
        /// interface into a <see cref="QualityAdvise2"/> COM wrapper object.
        /// The <see cref="QualityAdvise2"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFQualityAdvise2"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFQualityAdvise2"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static QualityAdvise2 ToQualityAdvise2(this IMFQualityAdvise2 self)
        {
            if (self == null)
                return null;
            return new QualityAdvise2(self);
        }
    }
}
