using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ContentProtectionManager"/> class implements a wrapper arround the
    /// <see cref="IMFContentProtectionManager"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFContentProtectionManager"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFContentProtectionManager"/>: 
    /// Enables playback of protected content by providing the application with a pointer to a content
    /// enabler object.
    /// <para/>
    /// Applications that play protected content should implement this interface.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/0DBA0384-EAC7-456A-AF9F-86EB944CDB2E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0DBA0384-EAC7-456A-AF9F-86EB944CDB2E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ContentProtectionManager : COM<IMFContentProtectionManager>
    {
        #region Construction

        internal ContentProtectionManager(IMFContentProtectionManager comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
