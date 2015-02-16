using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="PluginControl2"/> class implements a wrapper arround the
    /// <see cref="IMFPluginControl2"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFPluginControl2"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFPluginControl2"/>: 
    /// Controls how media sources and transforms are enumerated in Microsoft Media Foundation.
    /// <para/>
    /// This interface extends the <see cref="IMFPluginControl"/> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/15BD57FC-7CEF-45DC-AF94-3E54A3A9477A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/15BD57FC-7CEF-45DC-AF94-3E54A3A9477A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class PluginControl2 : COM<IMFPluginControl2>
    {
        #region Construction

        internal PluginControl2(IMFPluginControl2 comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
