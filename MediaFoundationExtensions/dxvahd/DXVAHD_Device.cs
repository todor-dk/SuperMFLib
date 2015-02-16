using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.dxvahd;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="DXVAHD_Device"/> class implements a wrapper arround the
    /// <see cref="IDXVAHD_Device"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IDXVAHD_Device"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IDXVAHD_Device"/>: 
    /// Represents a Microsoft DirectX Video Acceleration High Definition (DXVA-HD) device.
    /// <para/>
    /// To get a pointer to this interface, call the <see cref="dxvahd.OPMExtern.DXVAHD_CreateDevice"/>
    /// function. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3F79AC9C-2AED-4E1C-BF6F-02F9C54D59CD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3F79AC9C-2AED-4E1C-BF6F-02F9C54D59CD(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class DXVAHD_Device : COM<IDXVAHD_Device>
    {
        #region Construction

        internal DXVAHD_Device(IDXVAHD_Device comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
