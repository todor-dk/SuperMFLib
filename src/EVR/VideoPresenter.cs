using MediaFoundation.EVR.Interfaces;
using MediaFoundation.Misc.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MediaFoundation.EVR
{
    /// <summary>
    /// The <see cref="VideoPresenter"/> class implements a wrapper around the
    /// <see cref="IMFVideoPresenter"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoPresenter"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoPresenter"/>:
    /// Represents a video presenter. A <em>video presenter</em> is an object that receives video frames,
    /// typically from a video mixer, and presents them in some way, typically by rendering them to the
    /// display. The enhanced video renderer (EVR) provides a default video presenter, and applications can
    /// implement custom presenters.
    /// <para/>
    /// The video presenter receives video frames as soon as they are available from upstream. The video
    /// presenter is responsible for presenting frames at the correct time and for synchronizing with the
    /// presentation clock.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/8F6E3132-03E9-4A2E-9160-E39D29CF2408(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8F6E3132-03E9-4A2E-9160-E39D29CF2408(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public class VideoPresenter : ClockStateSink<IMFVideoPresenter>
    {
        #region Construction

        private VideoPresenter(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="VideoPresenter"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the VideoPresenter's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be considered void.
        /// </param>
        /// <returns>
        /// A new <see cref="VideoPresenter"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static VideoPresenter FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            VideoPresenter result = new VideoPresenter(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Sends a message to the video presenter. Messages are used to signal the presenter that it must
        /// perform some action, or that some event has occurred.
        /// </summary>
        /// <param name="message">
        /// Specifies the message as a member of the <see cref="EVR.MFVPMessageType"/> enumeration.
        /// </param>
        /// <param name="param">
        /// Message parameter. The meaning of this parameter depends on the message type.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/F7113CB3-2EA9-4D4F-B6C7-EF4E1025CC6D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F7113CB3-2EA9-4D4F-B6C7-EF4E1025CC6D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void ProcessMessage(MFVPMessageType message, IntPtr param)
        {
            int hr = this.Interface.ProcessMessage(message, param);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Retrieves the presenter's media type.
        /// </summary>
        /// <returns>
        /// The presenter's media type or null if media type is not set.
        /// The caller must release the result.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/4B8F0E56-35DE-4B4F-9897-32A7E14171C8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4B8F0E56-35DE-4B4F-9897-32A7E14171C8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaType GetCurrentMediaType()
        {
            IntPtr ppMediaType = IntPtr.Zero;
            int hr = this.Interface.GetCurrentMediaType(out ppMediaType);
            if (hr == MFError.MF_E_NOT_INITIALIZED)
            {
                if (ppMediaType != IntPtr.Zero)
                    Marshal.Release(ppMediaType);
                return null;
            }

            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppMediaType);
            // Technically, the result is IMFVideoMediaType (not IMFMediaType), but
            // all methods in IMFVideoMediaType are deprecated, so no idea implementing this.
            return MediaType.FromUnknown(ref ppMediaType);
        }
    }
}
