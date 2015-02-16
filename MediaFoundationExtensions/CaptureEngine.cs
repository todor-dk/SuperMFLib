using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="CaptureEngine"/> class implements a wrapper arround the
    /// <see cref="IMFCaptureEngine"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFCaptureEngine"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFCaptureEngine"/>: 
    /// Controls one or more capture devices. The capture engine implements this interface. To get a
    /// pointer to this interface, call either <see cref="MFExtern.MFCreateCaptureEngine"/> or 
    /// <see cref="IMFCaptureEngineClassFactory.CreateInstance"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/4A2A0536-4255-40AB-BCAB-228B09343583(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4A2A0536-4255-40AB-BCAB-228B09343583(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class CaptureEngine : COM<IMFCaptureEngine>
    {
        #region Construction

        internal CaptureEngine(IMFCaptureEngine comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
