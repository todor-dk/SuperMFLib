using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Core.Interfaces;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ClockStateSink"/> class implements a wrapper around the
    /// <see cref="IMFClockStateSink"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFClockStateSink"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFClockStateSink"/>: 
    /// Receives state-change notifications from the presentation clock. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9AA0D2CD-A687-4B3A-834D-CCC8D3A03196(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9AA0D2CD-A687-4B3A-834D-CCC8D3A03196(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public abstract class ClockStateSink<TClockStateSink> : COM<TClockStateSink>
        where TClockStateSink : class, IMFClockStateSink
    {
        #region Construction

        protected ClockStateSink(IntPtr unknown)
            : base(unknown)
        {
        }

        #endregion
    }

    public sealed class ClockStateSink : ClockStateSink<IMFClockStateSink>
    {
        #region Construction

        private ClockStateSink(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="ClockStateSink"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the ClockStateSink's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="ClockStateSink"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static ClockStateSink FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            ClockStateSink result = new ClockStateSink(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion
    }
}
