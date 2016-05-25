using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="TopologyNodeAttributeEditor"/> class implements a wrapper around the
    /// <see cref="IMFTopologyNodeAttributeEditor"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTopologyNodeAttributeEditor"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTopologyNodeAttributeEditor"/>: 
    /// Updates the attributes of one or more nodes in the Media Session's current topology.
    /// <para/>
    /// The Media Session exposes this interface as a service. To get a pointer to the interface, call 
    /// <see cref="IMFGetService.GetService"/>. The service identifier is
    /// MF_TOPONODE_ATTRIBUTE_EDITOR_SERVICE. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9AB384B9-0CE9-428C-A683-B09DBD4E07D9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9AB384B9-0CE9-428C-A683-B09DBD4E07D9(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class TopologyNodeAttributeEditor : COM<IMFTopologyNodeAttributeEditor>
    {
        #region Construction

        internal TopologyNodeAttributeEditor(IMFTopologyNodeAttributeEditor comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
