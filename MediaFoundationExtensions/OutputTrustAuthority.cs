using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="OutputTrustAuthority"/> class implements a wrapper around the
    /// <see cref="IMFOutputTrustAuthority"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFOutputTrustAuthority"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFOutputTrustAuthority"/>: 
    /// Encapsulates the functionality of one or more output protection systems that a trusted output
    /// supports. This interface is exposed by output trust authority (OTA) objects. Each OTA represents a
    /// single action that the trusted output can perform, such as play, copy, or transcode. An OTA can
    /// represent more than one physical output if each output performs the same action.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/21594AC0-7E3C-44A3-BBEE-64316DD51824(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/21594AC0-7E3C-44A3-BBEE-64316DD51824(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class OutputTrustAuthority : COM<IMFOutputTrustAuthority>
    {
        #region Construction

        internal OutputTrustAuthority(IMFOutputTrustAuthority comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
