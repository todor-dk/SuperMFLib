using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Core.Interfaces;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PresentationTimeSource"/> class implements a wrapper around the
    /// <see cref="IMFPresentationTimeSource"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFPresentationTimeSource"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFPresentationTimeSource"/>:
    /// Provides the clock times for the presentation clock.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/E5FAB6B7-0ABC-4AD7-89A9-33C673E97CE2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E5FAB6B7-0ABC-4AD7-89A9-33C673E97CE2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PresentationTimeSource : COM<IMFPresentationTimeSource>
    {
        #region Construction

        private PresentationTimeSource(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="PresentationTimeSource"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the PresentationTimeSource's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="PresentationTimeSource"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static PresentationTimeSource FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            PresentationTimeSource result = new PresentationTimeSource(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion
    }
}
