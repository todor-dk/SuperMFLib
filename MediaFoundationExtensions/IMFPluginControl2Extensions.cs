using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFPluginControl2"/> interface.
    /// </summary>
    public static class IMFPluginControl2Extensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFPluginControl2"/>
        /// interface into a <see cref="PluginControl2"/> COM wrapper object.
        /// The <see cref="PluginControl2"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFPluginControl2"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFPluginControl2"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static PluginControl2 ToPluginControl2(this IMFPluginControl2 self)
        {
            if (self == null)
                return null;
            return new PluginControl2(self);
        }
    }
}
