using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="QualityAdvise"/> class implements a wrapper arround the
    /// <see cref="IMFQualityAdvise"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFQualityAdvise"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFQualityAdvise"/>: 
    /// Enables the quality manager to adjust the audio or video quality of a component in the pipeline.
    /// <para/>
    /// This interface is exposed by pipeline components that can adjust their quality. Typically it is
    /// exposed by decoders and stream sinks. For example, the enhanced video renderer (EVR) implements
    /// this interface. However, media sources can also implement this interface.
    /// <para/>
    /// To get a pointer to this interface from a media source, call <see cref="IMFGetService.GetService"/>
    /// with the service identifier MF_QUALITY_SERVICES. For all other pipeline objects (transforms and
    /// media sinks), call <strong>QueryInterface</strong>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/20681CE7-E07E-4E34-9238-EC23CC6BFC84(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/20681CE7-E07E-4E34-9238-EC23CC6BFC84(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class QualityAdvise : COM<IMFQualityAdvise>
    {
        #region Construction

        internal QualityAdvise(IMFQualityAdvise comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
