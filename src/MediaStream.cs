using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Misc.Classes;

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

        private MediaStream(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="MediaStream"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the MediaStream's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="MediaStream"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static MediaStream FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            MediaStream result = new MediaStream(unknown);
            unknown = IntPtr.Zero;
            return result;
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
            IntPtr ppMediaSource;
            int hr = this.Interface.GetMediaSource(out ppMediaSource);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppMediaSource);
            return MediaSource.FromUnknown(ref ppMediaSource);
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
        public StreamDescriptor GetStreamDescriptor()
        {
            IntPtr ppStreamDescriptor;
            int hr = this.Interface.GetStreamDescriptor(out ppStreamDescriptor);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppStreamDescriptor);
            return StreamDescriptor.FromUnknown(ref ppStreamDescriptor);
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
            object pToken = (com != null) ? com.AccessInterface() : token;
            int hr = this.Interface.RequestSample(pToken);
            // MF_E_END_OF_STREAM: The end of the stream was reached.
            if (hr == MFError.MF_E_END_OF_STREAM)
                return false;
            COM.ThrowIfNotOK(hr);
            return true;
        }
    }
}
