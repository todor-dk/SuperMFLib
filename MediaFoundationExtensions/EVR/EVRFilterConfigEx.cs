using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="EVRFilterConfigEx"/> class implements a wrapper arround the
    /// <see cref="IEVRFilterConfigEx"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IEVRFilterConfigEx"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IEVRFilterConfigEx"/>: 
    /// Configures the DirectShow <c>Enhanced Video Renderer</c> (EVR) filter. To get a pointer to this
    /// interface, call <strong>QueryInterface</strong> on the EVR filter. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BBE85DC1-AF9C-4BE7-9064-D61BBA160942(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BBE85DC1-AF9C-4BE7-9064-D61BBA160942(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class EVRFilterConfigEx : COM<IEVRFilterConfigEx>
    {
        #region Construction

        internal EVRFilterConfigEx(IEVRFilterConfigEx comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
