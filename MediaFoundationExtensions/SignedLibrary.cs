using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SignedLibrary"/> class implements a wrapper around the
    /// <see cref="IMFSignedLibrary"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSignedLibrary"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSignedLibrary"/>: 
    /// Provides a method that allows content protection systems to get the procedure address of a function
    /// in the signed library. This method provides the same functionality as <strong>GetProcAddress
    /// </strong> which is not available to Windows Store apps. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1170FD74-7DA4-49A8-B095-DD1572DB382D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1170FD74-7DA4-49A8-B095-DD1572DB382D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SignedLibrary : COM<IMFSignedLibrary>
    {
        #region Construction

        internal SignedLibrary(IMFSignedLibrary comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
