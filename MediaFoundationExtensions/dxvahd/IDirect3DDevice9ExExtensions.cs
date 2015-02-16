using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.dxvahd;

namespace MediaFoundation
{
    /// <summary>
    /// Extension methods to the <see cref="IDirect3DDevice9Ex"/> interface.
    /// </summary>
    public static class IDirect3DDevice9ExExtensions
    {
        /// <summary>
        /// Encapsulates an instance of an <see cref="IDirect3DDevice9Ex"/>
        /// interface into a <see cref="Direct3DDevice9Ex"/> COM wrapper object.
        /// The <see cref="Direct3DDevice9Ex"/> implements the <see cref="IDisposable"/>
        /// interface to allow the object to be used with the C# <strong>using</strong>
        /// statement. The wrapper also exposes <i>civilized</i> version of the
        /// <see cref="IDirect3DDevice9Ex"/> interface's methods.
        /// </summary>
        /// <param name="self">
        /// Instance of an <see cref="IDirect3DDevice9Ex"/> COM interface.
        /// </param>
        /// <returns>
        /// COM wrapper over the given interface <paramref name="self"/>,
        /// or <stong>null</stong> if <paramref name="self"/> is null.
        /// </returns>
        public static Direct3DDevice9Ex ToDirect3DDevice9Ex(this IDirect3DDevice9Ex self)
        {
            if (self == null)
                return null;
            return new Direct3DDevice9Ex(self);
        }
    }
}
