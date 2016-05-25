using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="CdmSuspendNotify"/> class implements a wrapper around the
    /// <see cref="IMFCdmSuspendNotify"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFCdmSuspendNotify"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFCdmSuspendNotify"/>: 
    /// Used to enable the client to notify the Content Decryption Module (CDM) 
    /// when global resources should be brought into a consistent state prior to suspending. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280681(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280681(v=vs.85).aspx</a>
    /// </remarks>
    public sealed class CdmSuspendNotify : COM<IMFCdmSuspendNotify>
    {
        #region Construction

        internal CdmSuspendNotify(IMFCdmSuspendNotify comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
