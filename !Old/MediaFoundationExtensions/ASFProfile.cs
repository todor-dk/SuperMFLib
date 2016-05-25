using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="ASFProfile"/> class implements a wrapper around the
    /// <see cref="IMFASFProfile"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFASFProfile"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFASFProfile"/>: 
    /// Manages an Advanced Systems Format (ASF) profile. A profile is a collection of information that
    /// describes the configuration of streams that will be included in an ASF file. Information about the
    /// relationships between streams is also included in the profile.
    /// <para/>
    /// An <strong>IMFASFProfile</strong> interface exists for every ASF profile object. To create an ASF
    /// profile object, call <see cref="MFExtern.MFCreateASFProfile"/> or 
    /// <see cref="MFExtern.MFCreateASFProfileFromPresentationDescriptor"/>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FE441C61-1BE7-4FDA-A2A3-BD79ECF4E54C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FE441C61-1BE7-4FDA-A2A3-BD79ECF4E54C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class ASFProfile : COM<IMFASFProfile>
    {
        #region Construction

        internal ASFProfile(IMFASFProfile comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
