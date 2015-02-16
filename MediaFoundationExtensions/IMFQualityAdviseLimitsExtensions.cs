using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFQualityAdviseLimits"/> interface.
    /// </summary>
    public static class IMFQualityAdviseLimitsExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFQualityAdviseLimits"/>
        /// interface into a <see cref="QualityAdviseLimits"/> COM wrapper object.
        /// The <see cref="QualityAdviseLimits"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFQualityAdviseLimits"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFQualityAdviseLimits"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static QualityAdviseLimits ToQualityAdviseLimits(this IMFQualityAdviseLimits self)
        {
            if (self == null)
                return null;
            return new QualityAdviseLimits(self);
        }
    }
}
