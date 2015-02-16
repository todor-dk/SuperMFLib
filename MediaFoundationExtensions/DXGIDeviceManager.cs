using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="DXGIDeviceManager"/> class implements a wrapper arround the
    /// <see cref="IMFDXGIDeviceManager"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFDXGIDeviceManager"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFDXGIDeviceManager"/>: 
    /// Enables two threads to share the same Microsoft Direct3D 11 device.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/4A0DC266-FCF0-4ECD-AC78-CF429839486D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4A0DC266-FCF0-4ECD-AC78-CF429839486D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class DXGIDeviceManager : COM<IMFDXGIDeviceManager>
    {
        #region Construction

        internal DXGIDeviceManager(IMFDXGIDeviceManager comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
