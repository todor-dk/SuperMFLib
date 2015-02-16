using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="NetCredential"/> class implements a wrapper arround the
    /// <see cref="IMFNetCredential"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFNetCredential"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFNetCredential"/>: 
    /// Sets and retrieves user-name and password information for authentication purposes. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D202E7BC-9CE0-4861-8552-5A4D599B1661(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D202E7BC-9CE0-4861-8552-5A4D599B1661(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class NetCredential : COM<IMFNetCredential>
    {
        #region Construction

        internal NetCredential(IMFNetCredential comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
