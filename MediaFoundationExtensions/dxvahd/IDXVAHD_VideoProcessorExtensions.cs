using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.dxvahd;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IDXVAHD_VideoProcessor"/> interface.
    /// </summary>
    public static class IDXVAHD_VideoProcessorExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IDXVAHD_VideoProcessor"/>
        /// interface into a <see cref="DXVAHD_VideoProcessor"/> COM wrapper object.
        /// The <see cref="DXVAHD_VideoProcessor"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IDXVAHD_VideoProcessor"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IDXVAHD_VideoProcessor"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static DXVAHD_VideoProcessor ToDXVAHD_VideoProcessor(this IDXVAHD_VideoProcessor self)
        {
            if (self == null)
                return null;
            return new DXVAHD_VideoProcessor(self);
        }
    }
}
