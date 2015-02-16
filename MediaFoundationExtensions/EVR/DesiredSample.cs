using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="DesiredSample"/> class implements a wrapper around the
    /// <see cref="IMFDesiredSample"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFDesiredSample"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFDesiredSample"/>: 
    /// Enables the presenter for the enhanced video renderer (EVR) to request a specific frame from the
    /// video mixer.
    /// <para/>
    /// The sample objects created by the <see cref="MFExtern.MFCreateVideoSampleFromSurface"/> function
    /// implement this interface. To retrieve a pointer to this interface, call <strong>QueryInterface
    /// </strong> on the sample. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/373C076C-6329-4332-9F07-F18A01197659(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/373C076C-6329-4332-9F07-F18A01197659(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class DesiredSample : COM<IMFDesiredSample>
    {
        #region Construction

        internal DesiredSample(IMFDesiredSample comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
