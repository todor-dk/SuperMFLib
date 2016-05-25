using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.ReadWrite;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SinkWriter"/> class implements a wrapper around the
    /// <see cref="IMFSinkWriter"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSinkWriter"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSinkWriter"/>: 
    /// Implemented by the Microsoft Media Foundation sink writer object.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/76FB915E-1586-429A-88A5-BD1290799352(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/76FB915E-1586-429A-88A5-BD1290799352(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SinkWriter : COM<IMFSinkWriter>
    {
        #region Construction

        internal SinkWriter(IMFSinkWriter comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
