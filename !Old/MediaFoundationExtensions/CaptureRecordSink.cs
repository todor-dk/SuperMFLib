using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="CaptureRecordSink"/> class implements a wrapper around the
    /// <see cref="IMFCaptureRecordSink"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFCaptureRecordSink"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFCaptureRecordSink"/>: 
    /// Controls the recording sink. The recording sink creates compressed audio/video files or compressed
    /// audio/video streams.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/AEF5923D-C4ED-4BEA-A969-163ED837A5BD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AEF5923D-C4ED-4BEA-A969-163ED837A5BD(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class CaptureRecordSink : COM<IMFCaptureRecordSink>
    {
        #region Construction

        internal CaptureRecordSink(IMFCaptureRecordSink comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
