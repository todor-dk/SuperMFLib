using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ObjectReferenceStream"/> class implements a wrapper around the
    /// <see cref="IMFObjectReferenceStream"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFObjectReferenceStream"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFObjectReferenceStream"/>: 
    /// Marshals an interface pointer to and from a stream.
    /// <para/>
    /// Stream objects that support <strong>IStream</strong> can expose this interface to provide custom
    /// marshaling for interface pointers. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9D29BEFD-B0AE-4610-A0B7-17FACE03C45E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9D29BEFD-B0AE-4610-A0B7-17FACE03C45E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ObjectReferenceStream : COM<IMFObjectReferenceStream>
    {
        #region Construction

        internal ObjectReferenceStream(IMFObjectReferenceStream comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
