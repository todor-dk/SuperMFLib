using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.Misc;
using MediaFoundation.Core.Interfaces;
using MediaFoundation.Core.Enums;

namespace MediaFoundation
{
    /// <summary>
    /// The <see cref="MediaSource"/> class implements a wrapper around the
    /// <see cref="IMFMediaSource"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFMediaSource"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFMediaSource"/>:
    /// Implemented by media source objects.
    /// <para/>
    /// Media sources are objects that generate media data. For example, the data might come from a video
    /// file, a network stream, or a hardware device, such as a camera. Each media source contains one or
    /// more streams, and each stream delivers data of one type, such as audio or video.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/8B579F61-6FEA-4B20-A051-7633FC01FA05(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8B579F61-6FEA-4B20-A051-7633FC01FA05(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class MediaSource : MediaEventGenerator<IMFMediaSource>
    {
        #region Construction

        private MediaSource(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="MediaSource"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the MediaSource's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="MediaSource"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static MediaSource FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            MediaSource result = new MediaSource(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Retrieves the characteristics of the media source.
        /// </summary>
        /// <returns>
        /// Receives a bitwise <strong>OR</strong> of zero or more flags from the <see cref="MFMediaSourceCharacteristics"/> enumeration.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/CB5D54CD-58A3-4903-B22E-8207F90DBBC0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CB5D54CD-58A3-4903-B22E-8207F90DBBC0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MFMediaSourceCharacteristics Characteristics
        {
            get
            {
                MFMediaSourceCharacteristics pdwCharacteristics;
                int hr = this.Interface.GetCharacteristics(out pdwCharacteristics);
                COM.ThrowIfNotOK(hr);
                return pdwCharacteristics;
            }
        }

        /// <summary>
        /// Retrieves a copy of the media source's presentation descriptor. Applications use the presentation
        /// descriptor to select streams and to get information about the source content.
        /// </summary>
        /// <returns>
        /// New <see cref="PresentationDescriptor"/> object. The caller must release the interface.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/B6AC50B7-3EF1-43CF-8126-D9A003EBD825(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B6AC50B7-3EF1-43CF-8126-D9A003EBD825(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public PresentationDescriptor CreatePresentationDescriptor()
        {
            IntPtr ppPresentationDescriptor = IntPtr.Zero;
            int hr = this.Interface.CreatePresentationDescriptor(out ppPresentationDescriptor);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppPresentationDescriptor);
            return PresentationDescriptor.FromUnknown(ref ppPresentationDescriptor);
        }

        /// <summary>
        /// Starts, seeks, or restarts the media source by specifying where to start playback.
        /// </summary>
        /// <param name="presentationDescriptor">
        /// The <see cref="PresentationDescriptor"/> of the media source's presentation descriptor.
        /// To get the presentation descriptor, call <see cref="MediaSource.CreatePresentationDescriptor"/>.
        /// You can modify the presentation descriptor before calling <strong>Start</strong>,
        /// to select or deselect streams or change the media types.
        /// </param>
        /// <param name="timeFormat">
        /// A GUID that specifies the time format. The time format defines the units for the <em>
        /// pvarStartPosition</em> parameter. If the value is <strong>GUID_NULL</strong>, the time
        /// format is 100-nanosecond units. Some media sources might support additional time format GUIDs.
        /// </param>
        /// <param name="startPosition">
        /// Specifies where to start playback. The units of this parameter are indicated by the time format
        /// given in <paramref name="timeFormat"/>. If the time format is <strong>GUID_NULL</strong>, the variant
        /// type must be <strong>VT_I8</strong> or <strong>VT_EMPTY</strong>. Use <strong>VT_I8</strong> to
        /// specify a new starting position, in 100-nanosecond units. Use <strong>VT_EMPTY</strong> to start
        /// from the current position. Other time formats might use other <strong>PROPVARIANT</strong> types.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/0A5ABAFE-1525-4BDA-946C-05A6145E57EE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0A5ABAFE-1525-4BDA-946C-05A6145E57EE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Start(PresentationDescriptor presentationDescriptor, Guid timeFormat, ConstPropVariant startPosition)
        {
            int hr = this.Interface.Start(presentationDescriptor.AccessInterface(), timeFormat, startPosition);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Starts, seeks, or restarts the media source by specifying where to start playback.
        /// </summary>
        /// <param name="presentationDescriptor">
        /// The <see cref="PresentationDescriptor"/> of the media source's presentation descriptor.
        /// To get the presentation descriptor, call <see cref="MediaSource.CreatePresentationDescriptor"/>.
        /// You can modify the presentation descriptor before calling <strong>Start</strong>,
        /// to select or deselect streams or change the media types.
        /// </param>
        /// <param name="startPosition">
        /// Specifies where to start playback.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/0A5ABAFE-1525-4BDA-946C-05A6145E57EE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0A5ABAFE-1525-4BDA-946C-05A6145E57EE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Start(PresentationDescriptor presentationDescriptor, Time startPosition)
        {
            using (PropVariant variant = new PropVariant(startPosition.Value))
            {
                this.Start(presentationDescriptor, Guid.Empty, variant);
            }
        }

        /// <summary>
        /// Stops all active streams in the media source.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/AA7AF7A0-A6C2-4C9E-9F98-D36716679297(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AA7AF7A0-A6C2-4C9E-9F98-D36716679297(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Stop()
        {
            int hr = this.Interface.Stop();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Pauses all active streams in the media source.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/113B3DC7-918E-427E-AA70-CF474B951C6D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/113B3DC7-918E-427E-AA70-CF474B951C6D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Pause()
        {
            int hr = this.Interface.Pause();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Shuts down the media source and releases the resources it is using.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/C7F890A8-74BD-4418-BB02-A3FEE62DEC6D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C7F890A8-74BD-4418-BB02-A3FEE62DEC6D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Shutdown()
        {
            int hr = this.Interface.Shutdown();
            COM.ThrowIfNotOK(hr);
        }
    }
}
