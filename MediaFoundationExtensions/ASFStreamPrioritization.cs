using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ASFStreamPrioritization"/> class implements a wrapper arround the
    /// <see cref="IMFASFStreamPrioritization"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFASFStreamPrioritization"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFASFStreamPrioritization"/>: 
    /// <strong>Note</strong> This interface is not implemented. 
    /// <para/>
    /// Manages information about the relative priorities of a group of streams in an Advanced Systems
    /// Format (ASF) profile. This interface manages information about the relative priorities of a group
    /// of streams in an ASF profile. Priority is used in streaming to determine which streams should be
    /// dropped first when available bandwidth decreases.
    /// <para/>
    /// The ASF stream prioritization object exposes this interface. The stream prioritization object
    /// maintains a list of stream numbers in priority order. The methods of this interface manipulate and
    /// interrogate that list. To obtain a pointer to this interface, call the 
    /// <see cref="IMFASFProfile.CreateStreamPrioritization"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6EB79C52-DC81-406C-9000-D25AD380E6B2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6EB79C52-DC81-406C-9000-D25AD380E6B2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ASFStreamPrioritization : COM<IMFASFStreamPrioritization>
    {
        #region Construction

        internal ASFStreamPrioritization(IMFASFStreamPrioritization comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
