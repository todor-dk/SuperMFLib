using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IEVRTrustedVideoPlugin"/> interface.
    /// </summary>
    public static class IEVRTrustedVideoPluginExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IEVRTrustedVideoPlugin"/>
        /// interface into a <see cref="EVRTrustedVideoPlugin"/> COM wrapper object.
        /// The <see cref="EVRTrustedVideoPlugin"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IEVRTrustedVideoPlugin"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IEVRTrustedVideoPlugin"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static EVRTrustedVideoPlugin ToEVRTrustedVideoPlugin(this IEVRTrustedVideoPlugin self)
        {
            if (self == null)
                return null;
            return new EVRTrustedVideoPlugin(self);
        }
    }
}
