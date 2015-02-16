using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IMFSampleGrabberSinkCallback2"/> interface.
    /// </summary>
    public static class IMFSampleGrabberSinkCallback2Extensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IMFSampleGrabberSinkCallback2"/>
        /// interface into a <see cref="SampleGrabberSinkCallback2"/> COM wrapper object.
        /// The <see cref="SampleGrabberSinkCallback2"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IMFSampleGrabberSinkCallback2"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IMFSampleGrabberSinkCallback2"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static SampleGrabberSinkCallback2 ToSampleGrabberSinkCallback2(this IMFSampleGrabberSinkCallback2 self)
        {
            if (self == null)
                return null;
            return new SampleGrabberSinkCallback2(self);
        }
    }
}
