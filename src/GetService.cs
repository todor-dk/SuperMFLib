using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using MediaFoundation.Core.Interfaces;
using System.Runtime.InteropServices;
using MediaFoundation.Misc.Classes;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="GetService"/> class implements a wrapper around the
    /// <see cref="IMFGetService"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFGetService"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFGetService"/>:
    /// Queries an object for a specified service interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/102A1DFF-8419-4F86-A145-53CE3D0123F5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/102A1DFF-8419-4F86-A145-53CE3D0123F5(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class GetService : COM<IMFGetService>
    {
        #region Construction

        private GetService(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="GetService"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the GetService's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="GetService"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static GetService FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            GetService result = new GetService(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Retrieves a service.
        /// </summary>
        /// <param name="guidService">
        /// The service identifier (SID) of the service. For a list of service identifiers, see
        /// <c>Service Interfaces</c>.
        /// </param>
        /// <returns>
        /// The requested service or null if the object does not support the service.
        /// The caller must release the instance.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/4287DD1F-1718-4231-BC62-B58E0E61D688(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4287DD1F-1718-4231-BC62-B58E0E61D688(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TService Get<TService>(MFService guidService, COM.ComFactory<TService> factory)
            where TService : class
        {
            Contract.RequiresNotNull(factory, "factory");

            Guid riid = COM.IID_IUnknown;
            IntPtr ppvObject = IntPtr.Zero;
            int hr = this.Interface.GetService(guidService, riid, out ppvObject);
            // MF_E_UNSUPPORTED_SERVICE: The object does not support the service.
            if (hr == MFError.MF_E_UNSUPPORTED_SERVICE)
            {
                if (ppvObject != IntPtr.Zero)
                    Marshal.Release(ppvObject);
                return null;
            }

            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppvObject);
            try
            {
                return factory(ref ppvObject);
            }
            finally
            {
                if (ppvObject != IntPtr.Zero)
                    Marshal.Release(ppvObject);
            }
        }
    }
}
