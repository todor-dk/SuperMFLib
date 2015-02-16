using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="TimecodeTranslate"/> class implements a wrapper around the
    /// <see cref="IMFTimecodeTranslate"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTimecodeTranslate"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTimecodeTranslate"/>: 
    /// Converts between Society of Motion Picture and Television Engineers (SMPTE) time codes and
    /// 100-nanosecond time units.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/935EC6B3-12E6-4458-B8A1-FFEB4159D957(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/935EC6B3-12E6-4458-B8A1-FFEB4159D957(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class TimecodeTranslate : COM<IMFTimecodeTranslate>
    {
        #region Construction

        internal TimecodeTranslate(IMFTimecodeTranslate comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
