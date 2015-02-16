using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.dxvahd;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IDirect3DSurface9"/> interface.
    /// </summary>
    public static class IDirect3DSurface9Extensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IDirect3DSurface9"/>
        /// interface into a <see cref="Direct3DSurface9"/> COM wrapper object.
        /// The <see cref="Direct3DSurface9"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IDirect3DSurface9"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IDirect3DSurface9"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static Direct3DSurface9 ToDirect3DSurface9(this IDirect3DSurface9 self)
        {
            if (self == null)
                return null;
            return new Direct3DSurface9(self);
        }
    }
}
