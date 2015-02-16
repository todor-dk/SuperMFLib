using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.dxvahd;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="DXVAHD_VideoProcessor"/> class implements a wrapper arround the
    /// <see cref="IDXVAHD_VideoProcessor"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IDXVAHD_VideoProcessor"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IDXVAHD_VideoProcessor"/>: 
    /// Represents a Microsoft DirectX Video Acceleration High Definition (DXVA-HD) video processor. 
    /// <para/>
    /// To get a pointer to this interface, call the 
    /// <see cref="dxvahd.IDXVAHD_Device.CreateVideoProcessor"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/CBFACFF5-1CBB-4296-8242-C06B43FC95AF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CBFACFF5-1CBB-4296-8242-C06B43FC95AF(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class DXVAHD_VideoProcessor : COM<IDXVAHD_VideoProcessor>
    {
        #region Construction

        internal DXVAHD_VideoProcessor(IDXVAHD_VideoProcessor comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
