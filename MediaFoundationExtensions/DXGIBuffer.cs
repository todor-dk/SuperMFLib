using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="DXGIBuffer"/> class implements a wrapper around the
    /// <see cref="IMFDXGIBuffer"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFDXGIBuffer"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFDXGIBuffer"/>: 
    /// Represents a buffer that contains a Microsoft DirectX Graphics Infrastructure (DXGI) surface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/796D7755-275D-4A0B-A34F-5D34DCEC8AC7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/796D7755-275D-4A0B-A34F-5D34DCEC8AC7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class DXGIBuffer : COM<IMFDXGIBuffer>
    {
        #region Construction

        internal DXGIBuffer(IMFDXGIBuffer comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
