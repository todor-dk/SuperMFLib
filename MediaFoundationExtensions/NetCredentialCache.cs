using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="NetCredentialCache"/> class implements a wrapper arround the
    /// <see cref="IMFNetCredentialCache"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFNetCredentialCache"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFNetCredentialCache"/>: 
    /// Gets credentials from the credential cache.
    /// <para/>
    /// This interface is implemented by the credential cache object. Applications that implement the 
    /// <see cref="IMFNetCredentialManager"/> interface can use this object to store the user's
    /// credentials. To create the credential cache object, call 
    /// <see cref="MFExtern.MFCreateCredentialCache"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D02E26E7-E99C-4BE7-8495-830EFF2F1554(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D02E26E7-E99C-4BE7-8495-830EFF2F1554(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class NetCredentialCache : COM<IMFNetCredentialCache>
    {
        #region Construction

        internal NetCredentialCache(IMFNetCredentialCache comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
