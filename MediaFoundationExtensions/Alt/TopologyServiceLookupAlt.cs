using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Alt;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="TopologyServiceLookupAlt"/> class implements a wrapper arround the
    /// <see cref="IMFTopologyServiceLookupAlt"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTopologyServiceLookupAlt"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTopologyServiceLookupAlt"/>: 
    /// Enables a custom video mixer or video presenter to get interface pointers from the 
    /// <c>Enhanced Video Renderer</c> (EVR). The mixer can also use this interface to get interface
    /// pointers from the presenter, and the presenter can use it to get interface pointers from the mixer.
    /// <para/>
    /// To use this interface, implement the <see cref="EVR.IMFTopologyServiceLookupClient"/> interface on
    /// your custom mixer or presenter. The EVR calls 
    /// <see cref="EVR.IMFTopologyServiceLookupClient.InitServicePointers"/> with a pointer to the EVR's 
    /// <strong>IMFTopologyServiceLookup</strong> interface. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A912C17A-40EF-441C-BFC9-7EF49D22070F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A912C17A-40EF-441C-BFC9-7EF49D22070F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class TopologyServiceLookupAlt : COM<IMFTopologyServiceLookupAlt>
    {
        #region Construction

        internal TopologyServiceLookupAlt(IMFTopologyServiceLookupAlt comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
