using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="NetCredentialManager"/> class implements a wrapper arround the
    /// <see cref="IMFNetCredentialManager"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFNetCredentialManager"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFNetCredentialManager"/>: 
    /// Implemented by applications to provide user credentials for a network source.
    /// <para/>
    /// To use this interface, implement it in your application. Then create a property store object and
    /// set the <see cref="MFProperties.MFNETSOURCE_CREDENTIAL_MANAGER"/> property. The value of the
    /// property is a pointer to your application's <strong>IMFNetCredentialManager</strong> interface.
    /// Then pass the property store to one of the source resolver's creation functions, such as 
    /// <see cref="IMFSourceResolver.CreateObjectFromURL"/>, in the <em>pProps</em> parameter. 
    /// <para/>
    /// Media Foundation does not provide a default implementation of this interface. Applications that
    /// support authentication must implement this interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/002D8608-4EF9-40FD-8DCC-FE6ADE34478E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/002D8608-4EF9-40FD-8DCC-FE6ADE34478E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class NetCredentialManager : COM<IMFNetCredentialManager>
    {
        #region Construction

        internal NetCredentialManager(IMFNetCredentialManager comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
