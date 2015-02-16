using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="TranscodeProfile"/> class implements a wrapper arround the
    /// <see cref="IMFTranscodeProfile"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFTranscodeProfile"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFTranscodeProfile"/>: 
    /// Implemented by the transcode profile object.
    /// <para/>
    /// The transcode profile stores configuration settings that the topology builder uses to generate the
    /// transcode topology for the output file. These configuration settings are specified by the caller
    /// and include audio and video stream properties, encoder settings, and  container settings that are
    /// specified by the caller.
    /// <para/>
    /// To create the transcode profile object, call <see cref="MFExtern.MFCreateTranscodeProfile"/>. The
    /// configured transcode profile is passed to <see cref="MFExtern.MFCreateTranscodeTopology"/>, which
    /// creates the transcode topology with the appropriate settings. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/82E012E0-84D8-4791-8B6F-BDA58B498A90(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/82E012E0-84D8-4791-8B6F-BDA58B498A90(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class TranscodeProfile : COM<IMFTranscodeProfile>
    {
        #region Construction

        internal TranscodeProfile(IMFTranscodeProfile comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
