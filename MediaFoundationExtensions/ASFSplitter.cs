using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ASFSplitter"/> class implements a wrapper around the
    /// <see cref="IMFASFSplitter"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFASFSplitter"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFASFSplitter"/>: 
    /// Provides methods to read data from an Advanced Systems Format (ASF) file. The ASF splitter object
    /// exposes this interface. To create the ASF splitter, <see cref="MFExtern.MFCreateASFSplitter"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/75D8B2A3-7C50-4DD5-8927-B11EB9F12602(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/75D8B2A3-7C50-4DD5-8927-B11EB9F12602(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ASFSplitter : COM<IMFASFSplitter>
    {
        #region Construction

        internal ASFSplitter(IMFASFSplitter comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
