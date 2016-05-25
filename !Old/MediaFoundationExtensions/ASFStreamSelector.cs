using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ASFStreamSelector"/> class implements a wrapper around the
    /// <see cref="IMFASFStreamSelector"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFASFStreamSelector"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFASFStreamSelector"/>: 
    /// Selects streams in an Advanced Systems Format (ASF) file, based on the mutual exclusion information
    /// in the ASF header. The ASF stream selector object exposes this interface. To create the ASF stream
    /// selector, call <see cref="MFExtern.MFCreateASFStreamSelector"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D2E1FC15-2E12-4698-A4B1-CA8046D228DE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D2E1FC15-2E12-4698-A4B1-CA8046D228DE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ASFStreamSelector : COM<IMFASFStreamSelector>
    {
        #region Construction

        internal ASFStreamSelector(IMFASFStreamSelector comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
