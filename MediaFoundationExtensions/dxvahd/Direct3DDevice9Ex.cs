using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.dxvahd;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="Direct3DDevice9Ex"/> class implements a wrapper arround the
    /// <see cref="IDirect3DDevice9Ex"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IDirect3DDevice9Ex"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IDirect3DDevice9Ex"/>: 
    /// Applications use the methods of the IDirect3DDevice9Ex interface to render primitives, create
    /// resources, work with system-level variables, adjust gamma ramp levels, work with palettes, and
    /// create shaders. The IDirect3DDevice9Ex interface derives from the <c>IDirect3DDevice9</c>
    /// interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/VS|DIRECTX_SDK|~\IDIRECT3DDEVICE9EX.HTM(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/VS|DIRECTX_SDK|~\IDIRECT3DDEVICE9EX.HTM(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class Direct3DDevice9Ex : COM<IDirect3DDevice9Ex>
    {
        #region Construction

        internal Direct3DDevice9Ex(IDirect3DDevice9Ex comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
