using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.OPM;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IOPMVideoOutput"/> interface.
    /// </summary>
    public static class IOPMVideoOutputExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IOPMVideoOutput"/>
        /// interface into a <see cref="OPMVideoOutput"/> COM wrapper object.
        /// The <see cref="OPMVideoOutput"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IOPMVideoOutput"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IOPMVideoOutput"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static OPMVideoOutput ToOPMVideoOutput(this IOPMVideoOutput self)
        {
            if (self == null)
                return null;
            return new OPMVideoOutput(self);
        }
    }
}
