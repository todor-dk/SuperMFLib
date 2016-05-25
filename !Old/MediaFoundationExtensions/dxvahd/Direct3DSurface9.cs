using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.dxvahd;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="Direct3DSurface9"/> class implements a wrapper around the
    /// <see cref="IDirect3DSurface9"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IDirect3DSurface9"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IDirect3DSurface9"/>: 
    /// Applications use the methods of the IDirect3DSurface9 interface to query and prepare surfaces.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/VS|DIRECTX_SDK|~\IDIRECT3DSURFACE9.HTM(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/VS|DIRECTX_SDK|~\IDIRECT3DSURFACE9.HTM(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class Direct3DSurface9 : COM<IDirect3DSurface9>
    {
        #region Construction

        internal Direct3DSurface9(IDirect3DSurface9 comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
