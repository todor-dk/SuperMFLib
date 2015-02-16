using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;

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

        internal GetService(IMFGetService comInterface)
            : base(comInterface)
        {
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
        public TService Get<TService>(Guid guidService)
            where TService : class
        {
            Guid riid = typeof(TService).GUID;
            object ppvObject;
            int hr = this.Interface.GetService(guidService, riid, out ppvObject);
            // MF_E_UNSUPPORTED_SERVICE: The object does not support the service.
            if (hr == MFError.MF_E_UNSUPPORTED_SERVICE)
                return null;
            COM.ThrowIfNotOK(hr);
            if (ppvObject == null)
                return null;
            TService service = (TService)ppvObject;
            if (!Object.ReferenceEquals(ppvObject, service))
                COM.SafeRelease(ppvObject);
            return service;
        }
    }
}
