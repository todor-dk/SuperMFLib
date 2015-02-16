using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="DRMNetHelper"/> class implements a wrapper around the
    /// <see cref="IMFDRMNetHelper"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFDRMNetHelper"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFDRMNetHelper"/>: 
    /// Configures Windows Media Digital Rights Management (DRM) for Network Devices on a network sink.
    /// <para/>
    /// The Advanced Systems Format (ASF) streaming media sink exposes this interface. To get a pointer to
    /// the <strong>IMFDRMNetHelper</strong> interface, perform the following tasks. 
    /// <para/>
    /// For more information, see Remarks.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6F4AC19A-0972-4152-A64C-6C719EFB396C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6F4AC19A-0972-4152-A64C-6C719EFB396C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class DRMNetHelper : COM<IMFDRMNetHelper>
    {
        #region Construction

        internal DRMNetHelper(IMFDRMNetHelper comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
