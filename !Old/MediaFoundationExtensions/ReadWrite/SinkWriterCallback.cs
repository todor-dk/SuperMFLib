using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.ReadWrite;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="SinkWriterCallback"/> class implements a wrapper around the
    /// <see cref="IMFSinkWriterCallback"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSinkWriterCallback"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSinkWriterCallback"/>: 
    /// Callback interface for the Microsoft Media Foundation sink writer. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FA0295E6-473D-4304-9A7B-24584CADE0A0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FA0295E6-473D-4304-9A7B-24584CADE0A0(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SinkWriterCallback : COM<IMFSinkWriterCallback>
    {
        #region Construction

        internal SinkWriterCallback(IMFSinkWriterCallback comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
