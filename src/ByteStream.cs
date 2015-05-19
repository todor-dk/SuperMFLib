using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Core.Interfaces;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ByteStream"/> class implements a wrapper around the
    /// <see cref="IMFByteStream"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFByteStream"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFByteStream"/>: 
    /// Represents a byte stream from some data source, which might be a local file, a network file, or
    /// some other source. The <strong>IMFByteStream</strong> interface supports the typical stream
    /// operations, such as reading, writing, and seeking. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/690035B7-2855-4714-938F-F8250EC70D24(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/690035B7-2855-4714-938F-F8250EC70D24(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ByteStream : COM<IMFByteStream>
    {
        #region Construction

        private ByteStream(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="ByteStream"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the ByteStream's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="ByteStream"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static ByteStream FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            ByteStream result = new ByteStream(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion
    }
}
