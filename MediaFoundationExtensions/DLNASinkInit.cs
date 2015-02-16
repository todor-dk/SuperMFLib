using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="DLNASinkInit"/> class implements a wrapper around the
    /// <see cref="IMFDLNASinkInit"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFDLNASinkInit"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFDLNASinkInit"/>: 
    /// Initializes the Digital Living Network Alliance (DLNA) media sink. 
    /// <para/>
    /// The DLNA media sink exposes this interface. To get a pointer to this interface, call <strong>
    /// CoCreateInstance</strong>. The CLSID is <strong>CLSID_MPEG2DLNASink</strong>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FEC2933A-AA1A-41E5-B697-FDAE548B3789(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FEC2933A-AA1A-41E5-B697-FDAE548B3789(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class DLNASinkInit : COM<IMFDLNASinkInit>
    {
        #region Construction

        internal DLNASinkInit(IMFDLNASinkInit comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}
