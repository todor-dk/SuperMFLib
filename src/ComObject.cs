using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaFoundation
{
    public sealed class ComObject : COM<Object>
    {
        private ComObject(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="ComObject"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the ComObject's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be considered void.
        /// </param>
        /// <returns>
        /// A new <see cref="ComObject"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static ComObject FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            ComObject result = new ComObject(unknown);
            unknown = IntPtr.Zero;
            return result;
        }
    }
}
