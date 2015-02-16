using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PluginControl"/> class implements a wrapper arround the
    /// <see cref="IMFPluginControl"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFPluginControl"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFPluginControl"/>: 
    /// Controls how media sources and transforms are enumerated in Microsoft Media Foundation.
    /// <para/>
    /// To get a pointer to this interface, call <see cref="MFExtern.MFGetPluginControl"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/CDC6FD4F-C544-43BB-BA99-5468EF49949D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CDC6FD4F-C544-43BB-BA99-5468EF49949D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PluginControl : COM<IMFPluginControl>
    {
        #region Construction

        internal PluginControl(IMFPluginControl comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
