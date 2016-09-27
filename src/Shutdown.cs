using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Core.Enums;
using MediaFoundation.Misc.Classes;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="Shutdown"/> class implements a wrapper around the
    /// <see cref="IMFShutdown"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFShutdown"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFShutdown"/>:
    /// Exposed by some Media Foundation objects that must be explicitly shut down.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/C3052658-51BB-401B-8DB9-3428868899D6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C3052658-51BB-401B-8DB9-3428868899D6(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class Shutdown : COM<IMFShutdown>
    {
        #region Construction

        private Shutdown(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="Shutdown"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the Shutdown's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be considered void.
        /// </param>
        /// <returns>
        /// A new <see cref="Shutdown"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static Shutdown FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            Shutdown result = new Shutdown(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Shuts down a Media Foundation object and releases all resources associated with the object.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/9E7824D2-0F76-4C4C-98C5-BA51CD297DE7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9E7824D2-0F76-4C4C-98C5-BA51CD297DE7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void ShutDown()
        {
            int hr = this.Interface.Shutdown();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Queries the status of an earlier call to the <see cref="Shutdown"/> method.
        /// </summary>
        /// <returns>
        /// The status of an earlier call to the <see cref="Shutdown"/> method or
        /// null if the Shutdown method has not been called on this object.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/8CF5F5F3-A3AD-4745-87E8-764ED118477A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8CF5F5F3-A3AD-4745-87E8-764ED118477A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MFShutdownStatus? GetShutdownStatus()
        {
            MFShutdownStatus pStatus;
            int hr = this.Interface.GetShutdownStatus(out pStatus);
            // MF_E_INVALIDREQUEST: The <c>Shutdown</c> method has not been called on this object.
            if (hr == MFError.MF_E_INVALIDREQUEST)
                return null;
            COM.ThrowIfNotOK(hr);
            return pStatus;
        }
    }
}
