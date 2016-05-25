using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaSharingEngine"/> class implements a wrapper around the
    /// <see cref="IMFMediaSharingEngine"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaSharingEngine"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaSharingEngine"/>: 
    /// Enables media sharing.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D56612FC-840A-41EE-B162-7AF16ED3D975(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D56612FC-840A-41EE-B162-7AF16ED3D975(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaSharingEngine : COM<IMFMediaSharingEngine>
    {
        #region Construction

        internal MediaSharingEngine(IMFMediaSharingEngine comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
