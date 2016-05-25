using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="DXGIDeviceManagerSource"/> class implements a wrapper around the
    /// <see cref="IMFDXGIDeviceManagerSource"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFDXGIDeviceManagerSource"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFDXGIDeviceManagerSource"/>: 
    /// Provides functionality for getting the <see cref="IMFDXGIDeviceManager"/> from 
    /// the Microsoft Media Foundation video rendering sink.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn280687(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn280687(v=vs.85).aspx</a>
    /// </remarks>
    public sealed class DXGIDeviceManagerSource : COM<IMFDXGIDeviceManagerSource>
    {
        #region Construction

        internal DXGIDeviceManagerSource(IMFDXGIDeviceManagerSource comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
