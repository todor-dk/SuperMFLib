using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Transform;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFLocalMFTRegistration"/> interface.
    /// </summary>
    public static class IMFLocalMFTRegistrationExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFLocalMFTRegistration"/>
        /// interface into a <see cref="LocalMFTRegistration"/> COM wrapper object.
        /// The <see cref="LocalMFTRegistration"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFLocalMFTRegistration"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFLocalMFTRegistration"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static LocalMFTRegistration ToLocalMFTRegistration(this IMFLocalMFTRegistration self)
        {
            if (self == null)
                return null;
            return new LocalMFTRegistration(self);
        }
    }
}
