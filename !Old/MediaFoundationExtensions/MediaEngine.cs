using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEngine"/> class implements a wrapper around the
    /// <see cref="IMFMediaEngine"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEngine"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEngine"/>: 
    /// Enables an application to play audio or video files.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A0023F18-2D28-4F0D-9B00-B8FB11567034(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A0023F18-2D28-4F0D-9B00-B8FB11567034(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEngine : COM<IMFMediaEngine>
    {
        #region Construction

        internal MediaEngine(IMFMediaEngine comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
