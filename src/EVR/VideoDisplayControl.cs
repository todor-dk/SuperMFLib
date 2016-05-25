using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.EVR;
using MediaFoundation.Misc;
using System.Runtime.InteropServices;
using MediaFoundation.EVR.Interfaces;
using MediaFoundation.Misc.Classes;

namespace MediaFoundation.EVR
{
    /// <summary>
    /// The <see cref="VideoDisplayControl"/> class implements a wrapper around the
    /// <see cref="IMFVideoDisplayControl"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFVideoDisplayControl"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFVideoDisplayControl"/>:
    /// Controls how the <c>Enhanced Video Renderer</c> (EVR) displays video.
    /// <para/>
    /// The EVR presenter implements this interface. To get a pointer to the interface, call
    /// <see cref="IMFGetService.GetService"/>. The service identifier is GUID MR_VIDEO_RENDER_SERVICE.
    /// Call <strong>GetService</strong> on any of the following objects:
    /// <para/>
    /// If you implement a custom presenter for the EVR, the presenter can optionally expose this interface
    /// as a service.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/DB9B4663-9240-484F-8C47-CB1F5DAA238D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DB9B4663-9240-484F-8C47-CB1F5DAA238D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class VideoDisplayControl : COM<IMFVideoDisplayControl>
    {
        #region Construction

        private VideoDisplayControl(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="VideoDisplayControl"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the VideoDisplayControl's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="VideoDisplayControl"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static VideoDisplayControl FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            VideoDisplayControl result = new VideoDisplayControl(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Returns the <see cref="VideoDisplayControl"/> from the given <paramref name="service"/> (a Media Session, EVR presenter etc.).
        /// </summary>
        /// <param name="service">The service to retrieve the <see cref="VideoDisplayControl"/> from (a Media Session, EVR presenter etc.).</param>
        /// <returns>A <see cref="VideoDisplayControl"/> for the given <paramref name="service"/>.</returns>
        public static VideoDisplayControl FromService(GetService service)
        {
            Contract.RequiresNotNull(service, "service");
            return service.Get(MFService.MR_VIDEO_RENDER_SERVICE, VideoDisplayControl.FromUnknown);
        }

        /// <summary>
        /// Returns the <see cref="VideoDisplayControl"/> from the given <paramref name="session"/>.
        /// </summary>
        /// <param name="session">Media Session to retrieve the <see cref="VideoDisplayControl"/> from.</param>
        /// <returns>A <see cref="VideoDisplayControl"/> for the given <paramref name="session"/>.</returns>
        public static VideoDisplayControl FromMediaSession(MediaSession session)
        {
            Contract.RequiresNotNull(session, "session");
            return session.GetService(MFService.MR_VIDEO_RENDER_SERVICE, VideoDisplayControl.FromUnknown);
        }

        /// <summary>
        /// Gets the size and aspect ratio of the video, prior to any stretching by the video renderer.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/12630035-DD07-44BD-98F7-79974C9CC58B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/12630035-DD07-44BD-98F7-79974C9CC58B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public VideoSizeNative NativeVideoSize
        {
            get
            {
                MFSize pszVideo = new MFSize();
                MFSize pszARVideo = new MFSize();
                int hr = this.Interface.GetNativeVideoSize(pszVideo, pszARVideo);
                COM.ThrowIfNotOK(hr);
                return new VideoSizeNative(new Size(pszVideo.Width, pszVideo.Height), new Size(pszARVideo.Width, pszARVideo.Height));
            }
        }

        /// <summary>
        /// Contains the size and aspect ratio of the video, prior to any stretching by the video renderer.
        /// </summary>
        public struct VideoSizeNative
        {
            /// <summary>
            /// The size of the native video rectangle.
            /// </summary>
            public Size Size { get; private set; }

            /// <summary>
            /// The aspect ratio of the video.
            /// </summary>
            public Size AspectRatio { get; private set; }

            internal VideoSizeNative(Size size, Size aspectRatio)
                : this()
            {
                this.Size = size;
                this.AspectRatio = aspectRatio;
            }
        }

        /// <summary>
        /// Gets the range of sizes that the enhanced video renderer (EVR) can display without significantly
        /// degrading performance or image quality.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/C580778B-FE7C-4C62-9BCD-8A5FDE370B9D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C580778B-FE7C-4C62-9BCD-8A5FDE370B9D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public VideoSizeIdeal IdealVideoSize
        {
            get
            {
                MFSize pszMin = new MFSize();
                MFSize pszMax = new MFSize();
                int hr = this.Interface.GetIdealVideoSize(pszMin, pszMax);
                COM.ThrowIfNotOK(hr);
                return new VideoSizeIdeal(new Size(pszMin.Width, pszMin.Height), new Size(pszMax.Width, pszMax.Height));
            }
        }

        /// <summary>
        /// Contains the range of sizes that the enhanced video renderer (EVR) can display without significantly
        /// degrading performance or image quality.
        /// </summary>
        public struct VideoSizeIdeal
        {
            /// <summary>
            /// The minimum ideal size.
            /// </summary>
            public Size Minimum { get; private set; }

            /// <summary>
            /// The maximum ideal size.
            /// </summary>
            public Size Maximum { get; private set; }

            internal VideoSizeIdeal(Size min, Size max)
                : this()
            {
                this.Minimum = min;
                this.Maximum = max;
            }
        }

        /// <summary>
        /// Represents a size.
        /// </summary>
        public struct Size
        {
            /// <summary>
            /// Specifies the rectangle's width.
            /// </summary>
            public int Width { get; private set; }

            /// <summary>
            /// Specifies the rectangle's height.
            /// </summary>
            public int Height { get; private set; }

            internal Size(int width, int height)
                : this()
            {
                this.Width = width;
                this.Height = height;
            }
        }

        /// <summary>
        /// Sets the source and destination rectangles for the video.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/5DC789B7-E206-4F1D-A0B2-12CB98CE4184(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5DC789B7-E206-4F1D-A0B2-12CB98CE4184(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public VideoPos VideoPosition
        {
            get
            {
                MFVideoNormalizedRect pnrcSource = new MFVideoNormalizedRect();
                MFRect prcDest = new MFRect();
                int hr = this.Interface.GetVideoPosition(pnrcSource, prcDest);
                COM.ThrowIfNotOK(hr);
                return new VideoPos(pnrcSource, prcDest);
            }

            set
            {
                int hr = this.Interface.SetVideoPosition(value.Source, value.Destination);
                COM.ThrowIfNotOK(hr);
            }
        }

        /// <summary>
        /// Value for the <see cref="VideoPosition"/> property.
        /// </summary>
        public struct VideoPos
        {
            /// <summary>
            /// The source rectangle. If this parameter is <strong>null</strong>, the source rectangle does not change.
            /// </summary>
            public MFVideoNormalizedRect Source { get; set; }

            /// <summary>
            /// The destination rectangle. If this is <strong>null</strong>, the destination rectangle does not change.
            /// </summary>
            public MFRect Destination { get; set; }

            /// <summary>
            /// Initializes a new instance of the <see cref="VideoPosition"/> struct.
            /// </summary>
            /// <param name="source">The source rectangle. If this parameter is <strong>null</strong>, the source rectangle does not change.</param>
            /// <param name="destination">The destination rectangle. If this is <strong>null</strong>, the destination rectangle does not change.</param>
            public VideoPos(MFVideoNormalizedRect source, MFRect destination)
                : this()
            {
                this.Source = source;
                this.Destination = destination;
            }
        }

        /// <summary>
        /// Specifies how the enhanced video renderer (EVR) handles the aspect ratio of the source video.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/DD49A110-1C11-4ECA-9E7B-6021F3BDD397(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DD49A110-1C11-4ECA-9E7B-6021F3BDD397(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MFVideoAspectRatioMode AspectRatioMode
        {
            get
            {
                MFVideoAspectRatioMode pdwAspectRatioMode;
                int hr = this.Interface.GetAspectRatioMode(out pdwAspectRatioMode);
                COM.ThrowIfNotOK(hr);
                return pdwAspectRatioMode;
            }

            set
            {
                int hr = this.Interface.SetAspectRatioMode(value);
                COM.ThrowIfNotOK(hr);
            }
        }

        /// <summary>
        /// Gets or sets the clipping window for the video.
        /// The value is a handle to the window where the enhanced video renderer (EVR) will draw the video.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/50BC345C-EE44-4174-9B1A-E406041096B5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/50BC345C-EE44-4174-9B1A-E406041096B5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public IntPtr VideoWindow
        {
            get
            {
                IntPtr phwndVideo;
                int hr = this.Interface.GetVideoWindow(out phwndVideo);
                COM.ThrowIfNotOK(hr);
                return phwndVideo;
            }

            set
            {
                int hr = this.Interface.SetVideoWindow(value);
                if (hr == COM.S_FALSE)
                    return; // DWM thumbnails were not enabled/disabled.
                COM.ThrowIfNotOK(hr);
            }
        }

        /// <summary>
        /// Repaints the current video frame. Call this method whenever the application receives a WM_PAINT
        /// message.
        /// </summary>
        /// <returns>
        /// True if repaint succeded or false the EVR cannot repaint the frame at this time.
        /// This error can occur while the EVR is switching between full-screen and windowed mode.
        /// The caller can safely ignore this error.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/C8051883-2A48-4CA4-A7D2-C90D0D451CD2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C8051883-2A48-4CA4-A7D2-C90D0D451CD2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool RepaintVideo()
        {
            int hr = this.Interface.RepaintVideo();
            // MF_E_INVALIDREQUEST: The EVR cannot repaint the frame at this time.
            // This error can occur while the EVR is switching between full-screen and windowed mode.
            // The caller can safely ignore this error.
            if (hr == MFError.MF_E_INVALIDREQUEST)
                return false;
            COM.ThrowIfNotOK(hr);
            return true;
        }

        /// <summary>
        /// Gets a copy of the current image being displayed by the video renderer.
        /// </summary>
        /// <returns>
        /// The captured bitmap image. The caller must release this instance.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/25EC4C23-04DD-4E18-9CC1-DE9E57271E8F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/25EC4C23-04DD-4E18-9CC1-DE9E57271E8F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public CapturedImage GetCurrentImage()
        {
            BitmapInfoHeader pBih = new BitmapInfoHeader();
            pBih.Size = Marshal.SizeOf(typeof(BitmapInfoHeader));
            IntPtr pDib;
            int pcbDib;
            long pTimeStamp;
            int hr = this.Interface.GetCurrentImage(pBih, out pDib, out pcbDib, out pTimeStamp);
            COM.ThrowIfNotOK(hr);
            return new CapturedImage(pBih, pDib, pcbDib, (Time)pTimeStamp);
        }

        /// <summary>
        /// Represents an image captures with the <see cref="GetCurrentImage"/> method.
        /// </summary>
        public class CapturedImage : IDisposable
        {
            /// <summary>
            /// <see cref="BitmapInfoHeader"/> structure that contains a description of the bitmap.
            /// </summary>
            public BitmapInfoHeader BitmapInfoHeader { get; private set; }

            /// <summary>
            /// A pointer to a buffer that contains a packed Windows device-independent bitmap (DIB).
            /// </summary>
            public IntPtr DibData { get; private set; }

            /// <summary>
            /// The size of the <see cref="DibData"/> buffer in bytes.
            /// </summary>
            public int DibDataLength { get; private set; }

            /// <summary>
            /// The time stamp of the captured image.
            /// </summary>
            public Time Timestamp { get; private set; }

            internal CapturedImage(BitmapInfoHeader bitmapInfoHeader, IntPtr dibData, int dibDataLength, Time timestamp)
            {
                this.BitmapInfoHeader = bitmapInfoHeader;
                this.DibData = dibData;
                this.DibDataLength = dibDataLength;
                this.Timestamp = timestamp;
            }

            /// <summary>
            /// <see cref="CapturedImage"/> finalizer.
            /// </summary>
            ~CapturedImage()
            {
                this.Dispose(false);
            }

            /// <summary>
            /// Disposes the <see cref="CapturedImage"/> instance.
            /// </summary>
            public void Dispose()
            {
                this.Dispose(true);
                GC.SuppressFinalize(this);
            }

            private void Dispose(bool disposing)
            {
                if (this.DibData != IntPtr.Zero)
                    Marshal.FreeCoTaskMem(this.DibData);
                this.DibData = IntPtr.Zero;
                this.DibDataLength = 0;
            }
        }

        /// <summary>
        /// Gets or sets the border color for the video as a <strong>COLORREF</strong> value.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/4A3647A8-4789-4F18-979B-4A9EE1CE7B71(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4A3647A8-4789-4F18-979B-4A9EE1CE7B71(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int BorderColor
        {
            get
            {
                int pClr;
                int hr = this.Interface.GetBorderColor(out pClr);
                COM.ThrowIfNotOK(hr);
                return pClr;
            }

            set
            {
                int hr = this.Interface.SetBorderColor(value);
                COM.ThrowIfNotOK(hr);
            }
        }

        /// <summary>
        /// Get or sets various preferences related to video rendering.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/7603AAF8-1671-4B35-BEE5-335F656DE3C5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7603AAF8-1671-4B35-BEE5-335F656DE3C5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MFVideoRenderPrefs RenderingPreferences
        {
            get
            {
                MFVideoRenderPrefs pdwRenderFlags;
                int hr = this.Interface.GetRenderingPrefs(out pdwRenderFlags);
                COM.ThrowIfNotOK(hr);
                return pdwRenderFlags;
            }

            set
            {
                int hr = this.Interface.SetRenderingPrefs(value);
                COM.ThrowIfNotOK(hr);
            }
        }
    }
}
