using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SequencerSource"/> class implements a wrapper around the
    /// <see cref="IMFSequencerSource"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSequencerSource"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSequencerSource"/>: 
    /// Implemented by the <c>Sequencer Source</c>. The sequencer source enables an application to create a
    /// sequence of topologies. To create the sequencer source, call 
    /// <see cref="MFExtern.MFCreateSequencerSource"/>. For step-by-step instructions about how to create a
    /// playlist, see <c>How to Create a Playlist</c>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BA5E8E7B-5B0E-4807-A459-75BD5727D1E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA5E8E7B-5B0E-4807-A459-75BD5727D1E2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SequencerSource : COM<IMFSequencerSource>
    {
        #region Construction

        internal SequencerSource(IMFSequencerSource comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
