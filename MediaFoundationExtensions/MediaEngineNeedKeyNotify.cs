using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaEngineNeedKeyNotify"/> class implements a wrapper around the
    /// <see cref="IMFMediaEngineNeedKeyNotify"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaEngineNeedKeyNotify"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaEngineNeedKeyNotify"/>: 
    /// Represents a callback to the media engine to notify key request data.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BBEDFBE8-9389-4B4F-8D52-111C787A6268(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BBEDFBE8-9389-4B4F-8D52-111C787A6268(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaEngineNeedKeyNotify : COM<IMFMediaEngineNeedKeyNotify>
    {
        #region Construction

        internal MediaEngineNeedKeyNotify(IMFMediaEngineNeedKeyNotify comInterface)
            : base(comInterface)
        {
        }

        #endregion
    }
}