using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ASFMutualExclusion"/> class implements a wrapper arround the
    /// <see cref="IMFASFMutualExclusion"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFASFMutualExclusion"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFASFMutualExclusion"/>: 
    /// Configures an Advanced Systems Format (ASF) mutual exclusion object, which manages information
    /// about a group of streams in an ASF profile that are mutually exclusive. When streams or groups of
    /// streams are mutually exclusive, only one of them is read at a time, they are not read concurrently.
    /// <para/>
    /// A common example of mutual exclusion is a set of streams that each include the same content encoded
    /// at a different bit rate. The stream that is used is determined by the available bandwidth to the
    /// reader.
    /// <para/>
    /// An <strong>IMFASFMutualExclusion</strong> interface exists for every ASF mutual exclusion object. A
    /// pointer to this interface is obtained when you create the object using the 
    /// <see cref="IMFASFProfile.CreateMutualExclusion"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9C2278EC-77D1-445E-94BC-44E5D48F14AE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9C2278EC-77D1-445E-94BC-44E5D48F14AE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ASFMutualExclusion : COM<IMFASFMutualExclusion>
    {
        #region Construction

        internal ASFMutualExclusion(IMFASFMutualExclusion comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
