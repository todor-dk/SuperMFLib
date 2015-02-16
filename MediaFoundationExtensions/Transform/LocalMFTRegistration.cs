using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Transform;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="LocalMFTRegistration"/> class implements a wrapper arround the
    /// <see cref="IMFLocalMFTRegistration"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFLocalMFTRegistration"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFLocalMFTRegistration"/>: 
    /// Registers Media Foundation transforms (MFTs) in the caller's process.
    /// <para/>
    /// The Media Session exposes this interface as a service. To obtain a pointer to this interface, call
    /// the <see cref="IMFGetService.GetService"/> method on the Media Session with the service identifier 
    /// <strong>MF_LOCAL_MFT_REGISTRATION_SERVICE</strong>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E540A93A-ECCE-4C5B-A121-B0F868A2AF41(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E540A93A-ECCE-4C5B-A121-B0F868A2AF41(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class LocalMFTRegistration : COM<IMFLocalMFTRegistration>
    {
        #region Construction

        internal LocalMFTRegistration(IMFLocalMFTRegistration comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
