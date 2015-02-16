using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SampleOutputStream"/> class implements a wrapper around the
    /// <see cref="IMFSampleOutputStream"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSampleOutputStream"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSampleOutputStream"/>: 
    /// Writes media samples to a byte stream.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BA293BB7-9191-4123-96DB-FF6386ABB3AE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA293BB7-9191-4123-96DB-FF6386ABB3AE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SampleOutputStream : COM<IMFSampleOutputStream>
    {
        #region Construction

        internal SampleOutputStream(IMFSampleOutputStream comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
