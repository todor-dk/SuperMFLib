using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaStream"/> class implements a wrapper around the
    /// <see cref="IMFMediaStream"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaStream"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaStream"/>: 
    /// Represents one stream in a media source. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/66D07292-3BFE-4E68-B26F-890996262B98(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/66D07292-3BFE-4E68-B26F-890996262B98(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaStream : MediaEventGenerator<IMFMediaStream>
    {
        #region Construction

        internal MediaStream(IMFMediaStream comInterface)
            : base(comInterface)
        {
        }

        #endregion

        /// <summary>
        /// Retrieves the media source that created this media stream.
        /// </summary>
        /// <returns>
        /// Returns the media source that created this media stream. The caller must release the instance. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FFCA44CA-14AE-4F93-A719-9012A8151A7A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FFCA44CA-14AE-4F93-A719-9012A8151A7A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaSource GetMediaSource()
        {
            IMFMediaSource ppMediaSource;
            int hr = this.Interface.GetMediaSource(out ppMediaSource);
            COM.ThrowIfNotOK(hr);
            return ppMediaSource.ToMediaSource();
        }

        /// <summary>
        /// Retrieves a stream descriptor for this media stream.
        /// </summary>
        /// <returns>
        /// The stream descriptor for the media stream. The caller must release the instance. 
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/574EACFB-3ACD-4B47-9C25-3A67AAE01178(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/574EACFB-3ACD-4B47-9C25-3A67AAE01178(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public StreamDescriptor  GetStreamDescriptor()
        {
            IMFStreamDescriptor ppStreamDescriptor;
            int hr = this.Interface.GetStreamDescriptor(out ppStreamDescriptor);
            COM.ThrowIfNotOK(hr);
            return ppStreamDescriptor.ToStreamDescriptor();
        }

        /// <summary>
        /// Requests a sample from the media source. 
        /// </summary>
        /// <param name="token">
        /// An object that is used as a token for the request. This parameter can be <strong>null</strong>. 
        /// </param>
        /// <returns>
        /// True if the request successed or false if the end of the stream was reached.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3838167B-5774-47F5-9B8D-2882EAA97167(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3838167B-5774-47F5-9B8D-2882EAA97167(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool RequestSample(object token)
        {
            COM com = token as COM;
            object pToken = (com != null) ? com.Interface : token;
            int hr = this.Interface.RequestSample(pToken);
            // MF_E_END_OF_STREAM: The end of the stream was reached.
            if (hr == MFError.MF_E_END_OF_STREAM)
                return false;
            COM.ThrowIfNotOK(hr);
            return true;
        }
    }
}
