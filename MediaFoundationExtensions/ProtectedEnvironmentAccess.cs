using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ProtectedEnvironmentAccess"/> class implements a wrapper around the
    /// <see cref="IMFProtectedEnvironmentAccess"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFProtectedEnvironmentAccess"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFProtectedEnvironmentAccess"/>: 
    /// Provides a method that allows content protection systems to perform a handshake with the protected
    /// environment. This is needed because the <strong>CreateFile</strong> and <strong>DeviceIoControl
    /// </strong> APIs are not available to Windows Store apps. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/2CD93BC9-4A42-4E16-80AA-4ECF5900F5E4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2CD93BC9-4A42-4E16-80AA-4ECF5900F5E4(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ProtectedEnvironmentAccess : COM<IMFProtectedEnvironmentAccess>
    {
        #region Construction

        internal ProtectedEnvironmentAccess(IMFProtectedEnvironmentAccess comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
