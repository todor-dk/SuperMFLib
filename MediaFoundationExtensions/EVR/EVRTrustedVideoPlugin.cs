using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="EVRTrustedVideoPlugin"/> class implements a wrapper arround the
    /// <see cref="IEVRTrustedVideoPlugin"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IEVRTrustedVideoPlugin"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IEVRTrustedVideoPlugin"/>: 
    /// Enables a plug-in component for the enhanced video renderer (EVR) to work with protected media.
    /// <para/>
    /// To work in the protected media path (PMP), a custom EVR mixer or presenter must implement this
    /// interface. The EVR obtains a pointer to this interface by calling <strong>QueryInterface</strong>
    /// on the plug-in component. 
    /// <para/>
    /// This interface is required only if the plug-in is a trusted component, designed to work in the PMP.
    /// It is not required for playing clear content in an unprotected process.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1DCAA01C-2596-4A22-9E2A-7F0E26D58FFE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1DCAA01C-2596-4A22-9E2A-7F0E26D58FFE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class EVRTrustedVideoPlugin : COM<IEVRTrustedVideoPlugin>
    {
        #region Construction

        internal EVRTrustedVideoPlugin(IEVRTrustedVideoPlugin comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
