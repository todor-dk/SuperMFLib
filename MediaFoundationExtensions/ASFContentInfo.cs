using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ASFContentInfo"/> class implements a wrapper around the
    /// <see cref="IMFASFContentInfo"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFASFContentInfo"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFASFContentInfo"/>: 
    /// Provides methods to work with the header section of files conforming to the Advanced Systems Format
    /// (ASF) specification. 
    /// <para/>
    /// The <c>ASF ContentInfo Object</c> exposes this interface. To create the get a pointer to the 
    /// <strong>IMFASFContentInfo</strong> interface, call <see cref="MFExtern.MFCreateASFContentInfo"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9F490E6A-F378-45C1-A69D-985C6E884358(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9F490E6A-F378-45C1-A69D-985C6E884358(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ASFContentInfo : COM<IMFASFContentInfo>
    {
        #region Construction

        internal ASFContentInfo(IMFASFContentInfo comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
