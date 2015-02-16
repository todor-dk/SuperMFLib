using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFNetCredentialManager"/> interface.
    /// </summary>
    public static class IMFNetCredentialManagerExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFNetCredentialManager"/>
        /// interface into a <see cref="NetCredentialManager"/> COM wrapper object.
        /// The <see cref="NetCredentialManager"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFNetCredentialManager"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFNetCredentialManager"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static NetCredentialManager ToNetCredentialManager(this IMFNetCredentialManager self)
        {
            if (self == null)
                return null;
            return new NetCredentialManager(self);
        }
    }
}
