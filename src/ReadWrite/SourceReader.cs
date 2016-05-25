using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MediaFoundation.Internals;
using MediaFoundation.ReadWrite;
using MediaFoundation.Misc;
using System.Diagnostics;
using MediaFoundation.ReadWrite.Interfaces;
using MediaFoundation.Core;
using MediaFoundation.Misc.Classes;
using System.Runtime.InteropServices;

namespace MediaFoundation.ReadWrite
{
    /// <summary>
    /// The <see cref="SourceReader"/> class implements a wrapper around the
    /// <see cref="IMFSourceReader"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSourceReader"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSourceReader"/>:
    /// Implemented by the Microsoft Media Foundation source reader object.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/7D3CC314-6B9E-437C-AFDA-EE1965A12721(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7D3CC314-6B9E-437C-AFDA-EE1965A12721(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public sealed class SourceReader : COM<IMFSourceReader>
    {
        #region Construction

        private SourceReader(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="SourceReader"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the SourceReader's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be concidered void.
        /// </param>
        /// <returns>
        /// A new <see cref="SourceReader"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static SourceReader FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            SourceReader result = new SourceReader(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Creates the source reader from a media source.
        /// </summary>
        /// <param name="mediaSource">The media source.</param>
        /// <returns>A <see cref="SourceReader"/> object. The caller must dispose this object.</returns>
        public static SourceReader CreateFromMediaSource(MediaSource mediaSource)
        {
            return SourceReader.CreateFromMediaSource(mediaSource, null);
        }

        /// <summary>
        /// Creates the source reader from a media source.
        /// </summary>
        /// <param name="mediaSource">The media source.</param>
        /// <param name="attributes">Optional. You can use this parameter to configure the source reader.</param>
        /// <returns>A <see cref="SourceReader"/> object. The caller must dispose this object.</returns>
        public static SourceReader CreateFromMediaSource(MediaSource mediaSource, Attributes attributes)
        {
            IntPtr reader = IntPtr.Zero;
            int hr = MFExtern.MFCreateSourceReaderFromMediaSource(mediaSource.AccessInterface(), attributes.AccessInterface(), out reader);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref reader);
            Debug.Assert(reader != IntPtr.Zero);
            return SourceReader.FromUnknown(ref reader);
        }

        /// <summary>
        /// Audio or Video stream enumeration.
        /// </summary>
        public enum StreamAV : int
        {
            /// <summary>
            /// The first video stream (MF_SOURCE_READER_FIRST_VIDEO_STREAM = 0xFFFFFFFC).
            /// </summary>
            FirstVideoStream = unchecked((int)0xFFFFFFFC),

            /// <summary>
            /// The first audio stream (MF_SOURCE_READER_FIRST_AUDIO_STREAM = 0xFFFFFFFD).
            /// </summary>
            FirstAudioStream = unchecked((int)0xFFFFFFFD)
        }

        /// <summary>
        /// Queries whether a stream is selected.
        /// </summary>
        /// <param name="stream">
        /// The stream to query.
        /// </param>
        /// <returns>
        /// True if the stream is selected and will generate data. False if the stream is not selected and will not generate data.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/40301426-4BF2-442C-91B5-9916D1314617(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/40301426-4BF2-442C-91B5-9916D1314617(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool GetStreamSelection(StreamAV stream)
        {
            return this.GetStreamSelection((int)stream);
        }

        /// <summary>
        /// Queries whether a stream is selected.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of a stream to query.
        /// </param>
        /// <returns>
        /// True if the stream is selected and will generate data. False if the stream is not selected and will not generate data.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/40301426-4BF2-442C-91B5-9916D1314617(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/40301426-4BF2-442C-91B5-9916D1314617(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public bool GetStreamSelection(int streamIndex)
        {
            bool selected;
            int hr = this.Interface.GetStreamSelection(streamIndex, out selected);
            COM.ThrowIfNotOK(hr);
            return selected;
        }

        /// <summary>
        /// Audio, Video or All-Streams enumeration.
        /// </summary>
        public enum StreamAVA : int
        {
            /// <summary>
            /// The first video stream (MF_SOURCE_READER_FIRST_VIDEO_STREAM = 0xFFFFFFFC).
            /// </summary>
            FirstVideoStream = unchecked((int)0xFFFFFFFC),

            /// <summary>
            /// The first audio stream (MF_SOURCE_READER_FIRST_AUDIO_STREAM = 0xFFFFFFFD).
            /// </summary>
            FirstAudioStream = unchecked((int)0xFFFFFFFD),

            /// <summary>
            /// All streams (MF_SOURCE_READER_ALL_STREAMS = 0xFFFFFFFE).
            /// </summary>
            AllStreams = unchecked((int)0xFFFFFFFE),
        }

        /// <summary>
        /// Selects or deselects one or more streams.
        /// </summary>
        /// <param name="stream">
        /// The stream to set.
        /// </param>
        /// <param name="selected">
        /// Specify <strong>true</strong> to select streams or <strong>false</strong> to deselect streams. If a
        /// stream is deselected, it will not generate data.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/5EFADCE6-347C-48CF-B42C-D461922B2523(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5EFADCE6-347C-48CF-B42C-D461922B2523(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetStreamSelection(StreamAVA stream, bool selected)
        {
            this.SetStreamSelection((int)stream, selected);
        }

        /// <summary>
        /// Selects or deselects one or more streams.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of the stream to set.
        /// </param>
        /// <param name="selected">
        /// Specify <strong>true</strong> to select streams or <strong>false</strong> to deselect streams. If a
        /// stream is deselected, it will not generate data.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/5EFADCE6-347C-48CF-B42C-D461922B2523(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5EFADCE6-347C-48CF-B42C-D461922B2523(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetStreamSelection(int streamIndex, bool selected)
        {
            int hr = this.Interface.SetStreamSelection(streamIndex, selected);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Gets a format that is supported natively by the media source.
        /// </summary>
        /// <param name="streamIndex">
        /// Specifies the zero-based index of a stream to query.
        /// </param>
        /// <param name="mediaTypeIndex">
        /// The zero-based index of the media type to retrieve.
        /// </param>
        /// <returns>
        /// The <see cref="MediaType"/> or null if no media type is found for the given <paramref name="mediaTypeIndex"/>.
        /// The caller must release the media type.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/4B514F8D-082F-4E84-B512-D4A59706A6D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4B514F8D-082F-4E84-B512-D4A59706A6D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaType GetNativeMediaType(int streamIndex, int mediaTypeIndex)
        {
            IntPtr ppMediaType = IntPtr.Zero;
            int hr = this.Interface.GetNativeMediaType(streamIndex, mediaTypeIndex, out ppMediaType);
            if (hr == MFError.MF_E_NO_MORE_TYPES)
            {
                if (ppMediaType != IntPtr.Zero)
                    Marshal.Release(ppMediaType);
                return null;
            }

            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppMediaType);
            return MediaType.FromUnknown(ref ppMediaType);
        }

        /// <summary>
        /// Gets a format that is supported natively by the media source.
        /// </summary>
        /// <param name="stream">
        /// Specifies the stream to query.
        /// </param>
        /// <param name="mediaTypeIndex">
        /// The zero-based index of the media type to retrieve.
        /// </param>
        /// <returns>
        /// The <see cref="MediaType"/> or null if no media type is found for the given <paramref name="mediaTypeIndex"/>.
        /// The caller must release the media type.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/4B514F8D-082F-4E84-B512-D4A59706A6D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4B514F8D-082F-4E84-B512-D4A59706A6D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaType GetNativeMediaType(StreamAV stream, int mediaTypeIndex)
        {
            return this.GetNativeMediaType((int)stream, mediaTypeIndex);
        }

        /// <summary>
        /// Gets the current media type for a stream.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of the stream to query.
        /// </param>
        /// <returns>
        /// The current <see cref="MediaType"/>. The caller must release the media type.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/C0FE3B34-42AD-45E4-812D-679BBE01A200(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C0FE3B34-42AD-45E4-812D-679BBE01A200(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaType GetCurrentMediaType(int streamIndex)
        {
            IntPtr ppMediaType;
            int hr = this.Interface.GetCurrentMediaType(streamIndex, out ppMediaType);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppMediaType);
            return MediaType.FromUnknown(ref ppMediaType);
        }

        /// <summary>
        /// Gets the current media type for a stream.
        /// </summary>
        /// <param name="stream">
        /// The stream to query.
        /// </param>
        /// <returns>
        /// The current <see cref="MediaType"/>. The caller must release the media type.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/C0FE3B34-42AD-45E4-812D-679BBE01A200(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C0FE3B34-42AD-45E4-812D-679BBE01A200(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public MediaType GetCurrentMediaType(StreamAV stream)
        {
            return this.GetCurrentMediaType((int)stream);
        }

        /// <summary>
        /// Sets the media type for a stream.
        /// <para/>
        /// This media type defines that format that the <c>Source Reader</c> produces as output. It can differ
        /// from the native format provided by the media source. See Remarks for more information.
        /// </summary>
        /// <param name="stream">
        /// The stream to configure.
        /// </param>
        /// <param name="mediaType">
        /// The <see cref="MediaType"/>.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/54CAEC4D-1393-487B-94EE-78563B2B4645(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/54CAEC4D-1393-487B-94EE-78563B2B4645(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetCurrentMediaType(StreamAV stream, MediaType mediaType)
        {
            this.SetCurrentMediaType((int)stream, mediaType);
        }

        /// <summary>
        /// Sets the media type for a stream.
        /// <para/>
        /// This media type defines that format that the <c>Source Reader</c> produces as output. It can differ
        /// from the native format provided by the media source. See Remarks for more information.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of the stream to configure.
        /// </param>
        /// <param name="mediaType">
        /// The <see cref="MediaType"/>.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/54CAEC4D-1393-487B-94EE-78563B2B4645(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/54CAEC4D-1393-487B-94EE-78563B2B4645(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetCurrentMediaType(int streamIndex, MediaType mediaType)
        {
            int hr = this.Interface.SetCurrentMediaType(streamIndex, IntPtr.Zero, mediaType.AccessInterface());
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Seeks to a new position in the media source.
        /// </summary>
        /// <param name="timeFormat">
        /// A GUID that specifies the <em>time format</em>. The time format defines the units for the <em>
        /// varPosition</em> parameter. The following value is defined for all media sources:
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>GUID_NULL</strong></term><description>100-nanosecond units.</description></item>
        /// </list>
        /// <para/>
        /// Some media sources might support additional values.
        /// </param>
        /// <param name="position">
        /// The position from which playback will be started. The units are specified by the <paramref name="timeFormat"/>
        /// parameter. If the <paramref name="timeFormat"/> parameter is <strong>GUID_NULL</strong>, set the
        /// variant type to <strong>VT_I8</strong>.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/FB9412F5-4F2F-463D-9988-80E706AFD9C4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FB9412F5-4F2F-463D-9988-80E706AFD9C4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetCurrentPosition(Guid timeFormat, PropVariant position)
        {
            int hr = this.Interface.SetCurrentPosition(timeFormat, position);
        }

        /// <summary>
        /// Seeks to a new position in the media source.
        /// </summary>
        /// <param name="position">
        /// The position from which playback will be started.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/FB9412F5-4F2F-463D-9988-80E706AFD9C4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FB9412F5-4F2F-463D-9988-80E706AFD9C4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetCurrentPosition(Time position)
        {
            using (PropVariant variant = new PropVariant(position.Value))
            {
                this.SetCurrentPosition(Guid.Empty, variant);
            }
        }

        /// <summary>
        /// Reads the next sample from the media source.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of the stream to pull data from.
        /// </param>
        /// <param name="controlFlags">
        /// A bitwise <strong>OR</strong> of zero or more flags from the
        /// <see cref="ReadWrite.MF_SOURCE_READER_CONTROL_FLAG"/> enumeration.
        /// </param>
        /// <param name="actualStreamIndex">
        /// Returns the zero-based index of the stream.
        /// </param>
        /// <param name="streamFlags">
        /// Returns a bitwise <strong>OR</strong> of zero or more flags from the
        /// <see cref="ReadWrite.MF_SOURCE_READER_FLAG"/> enumeration.
        /// </param>
        /// <param name="timestamp">
        /// Returns the time stamp of the sample, or the time of the stream event indicated in <paramref name="streamFlags"/>.
        /// </param>
        /// <returns>
        /// A <see cref="Sample"/> object or <strong>null</strong> (see Remarks). If the method returns a non-null value,
        /// the caller must dispose the result.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/99BD9BD7-D8D1-433A-BC5A-4B9761DE5048(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/99BD9BD7-D8D1-433A-BC5A-4B9761DE5048(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Sample ReadSample(int streamIndex, MF_SOURCE_READER_CONTROL_FLAG controlFlags, out int actualStreamIndex, out MF_SOURCE_READER_FLAG streamFlags, out Time timestamp)
        {
            long time;
            IntPtr sample;
            int hr = this.Interface.ReadSample(streamIndex, controlFlags, out actualStreamIndex, out streamFlags, out time, out sample);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref sample);
            timestamp = new Time(time);
            return Sample.FromUnknown(ref sample);
        }

        /// <summary>
        /// Reads the next sample from the media source.
        /// </summary>
        /// <param name="stream">
        /// The stream to pull data from.
        /// </param>
        /// <param name="controlFlags">
        /// A bitwise <strong>OR</strong> of zero or more flags from the
        /// <see cref="ReadWrite.MF_SOURCE_READER_CONTROL_FLAG"/> enumeration.
        /// </param>
        /// <param name="actualStreamIndex">
        /// Returns the zero-based index of the stream.
        /// </param>
        /// <param name="streamFlags">
        /// Returns a bitwise <strong>OR</strong> of zero or more flags from the
        /// <see cref="ReadWrite.MF_SOURCE_READER_FLAG"/> enumeration.
        /// </param>
        /// <param name="timestamp">
        /// Returns the time stamp of the sample, or the time of the stream event indicated in <paramref name="streamFlags"/>.
        /// </param>
        /// <returns>
        /// A <see cref="Sample"/> object or <strong>null</strong> (see Remarks). If the method returns a non-null value,
        /// the caller must dispose the result.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/99BD9BD7-D8D1-433A-BC5A-4B9761DE5048(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/99BD9BD7-D8D1-433A-BC5A-4B9761DE5048(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public Sample ReadSample(StreamAVA stream, MF_SOURCE_READER_CONTROL_FLAG controlFlags, out int actualStreamIndex, out MF_SOURCE_READER_FLAG streamFlags, out Time timestamp)
        {
            return this.ReadSample((int)stream, controlFlags, out actualStreamIndex, out streamFlags, out timestamp);
        }

        /// <summary>
        /// Flushes one or more streams.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of the stream to flush.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/34992C64-9956-4B23-A979-DF7F678405B5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/34992C64-9956-4B23-A979-DF7F678405B5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Flush(int streamIndex)
        {
            int hr = this.Interface.Flush(streamIndex);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Flushes one or more streams.
        /// </summary>
        /// <param name="stream">
        /// The stream to flush.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/34992C64-9956-4B23-A979-DF7F678405B5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/34992C64-9956-4B23-A979-DF7F678405B5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Flush(StreamAVA stream)
        {
            this.Flush((int)stream);
        }

        /// <summary>
        /// Queries the underlying media source or decoder for an interface.
        /// </summary>
        /// <typeparam name="TService">The type of the service being requested.</typeparam>
        /// <param name="streamIndex">The zero-based index of the stream to query.</param>
        /// <param name="service">
        /// A service identifier GUID. If the value is <strong>GUID_NULL</strong>, the method calls <strong>
        /// QueryInterface</strong> to get the requested interface. Otherwise, the method calls the
        /// <see cref="IMFGetService.GetService"/> method. For a list of service identifiers, see
        /// <c>Service Interfaces</c>.
        /// </param>
        /// <returns>The requested interface. The caller must dispose the object.</returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/D8868E4D-EEDD-4FBD-B870-D3AF48890C92(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D8868E4D-EEDD-4FBD-B870-D3AF48890C92(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TService GetServiceForStream<TService>(int streamIndex, MFService service, COM.ComFactory<TService> factory)
            where TService : class
        {
            Contract.RequiresNotNull(factory, "factory");

            Guid iid = typeof(TService).GUID;
            IntPtr ppvObject = IntPtr.Zero;
            int hr = this.Interface.GetServiceForStream(streamIndex, service, COM.IID_IUnknown, out ppvObject);
            // MF_E_UNSUPPORTED_SERVICE: The object does not support the service.
            if (hr == MFError.MF_E_UNSUPPORTED_SERVICE)
            {
                if (ppvObject != IntPtr.Zero)
                    Marshal.Release(ppvObject);
                return null;
            }

            COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppvObject);
            return factory(ref ppvObject);
        }

        /// <summary>
        /// Queries the underlying media source or decoder for an interface.
        /// </summary>
        /// <typeparam name="TService">The type of the service being requested.</typeparam>
        /// <param name="stream">
        /// The object to query. If the value is <see cref="StreamAVMS.MediaSource"/>, the
        /// method queries the media source. Otherwise, it queries the decoder that is associated with the
        /// specified stream.
        /// </param>
        /// <param name="service">
        /// A service identifier GUID. If the value is <strong>GUID_NULL</strong>, the method calls <strong>
        /// QueryInterface</strong> to get the requested interface. Otherwise, the method calls the
        /// <see cref="IMFGetService.GetService"/> method. For a list of service identifiers, see
        /// <c>Service Interfaces</c>.
        /// </param>
        /// <returns>The requested interface. The caller must dispose the object.</returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/D8868E4D-EEDD-4FBD-B870-D3AF48890C92(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D8868E4D-EEDD-4FBD-B870-D3AF48890C92(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public TService GetServiceForStream<TService>(StreamAVMS stream, MFService service, COM.ComFactory<TService> factory)
            where TService : class
        {
            return this.GetServiceForStream<TService>((int)stream, service, factory);
        }

        /// <summary>
        /// Audio, Video stream or Media-Source enumeration.
        /// </summary>
        public enum StreamAVMS : int
        {
            /// <summary>
            /// The first video stream (MF_SOURCE_READER_FIRST_VIDEO_STREAM = 0xFFFFFFFC).
            /// </summary>
            FirstVideoStream = unchecked((int)0xFFFFFFFC),

            /// <summary>
            /// The first audio stream (MF_SOURCE_READER_FIRST_AUDIO_STREAM = 0xFFFFFFFD).
            /// </summary>
            FirstAudioStream = unchecked((int)0xFFFFFFFD),

            /// <summary>
            /// The media source (MF_SOURCE_READER_MEDIASOURCE = 0xFFFFFFFF).
            /// </summary>
            MediaSource = unchecked((int)0xFFFFFFFF)
        }

        /// <summary>
        /// Gets an attribute from the underlying media source.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of the stream to query.
        /// </param>
        /// <param name="attribute">
        /// A GUID that identifies the attribute to retrieve.
        /// </param>
        /// <returns>
        /// The value of the attribute. The <see cref="PropVariant"/> must be disposed.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/40544E1E-CCE2-4860-AEB2-B60696B09145(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/40544E1E-CCE2-4860-AEB2-B60696B09145(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public PropVariant GetPresentationAttribute(int streamIndex, Guid attribute)
        {
            PropVariant value = new PropVariant();
            int hr = this.Interface.GetPresentationAttribute(streamIndex, attribute, value);
            COM.ThrowIfNotOKAndDisposePropVariant(hr, value);
            return value;
        }

        /// <summary>
        /// Gets an attribute from the underlying media source.
        /// </summary>
        /// <param name="stream">
        /// The stream or object to query.
        /// </param>
        /// <param name="attribute">
        /// A GUID that identifies the attribute to retrieve.
        /// </param>
        /// <returns>
        /// The value of the attribute. The <see cref="PropVariant"/> must be disposed.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/40544E1E-CCE2-4860-AEB2-B60696B09145(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/40544E1E-CCE2-4860-AEB2-B60696B09145(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public PropVariant GetPresentationAttribute(StreamAVMS stream, Guid attribute)
        {
            return this.GetPresentationAttribute((int)stream, attribute);
        }

        /// <summary>
        /// Gets the value of an attribute from the underlying media source.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of the stream to query.
        /// </param>
        /// <param name="attribute">
        /// A GUID that identifies the attribute to retrieve.
        /// </param>
        /// <returns>
        /// The value of the attribute.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/40544E1E-CCE2-4860-AEB2-B60696B09145(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/40544E1E-CCE2-4860-AEB2-B60696B09145(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public object GetPresentationAttributeValue(int streamIndex, Guid attribute)
        {
            using (PropVariant value = this.GetPresentationAttribute(streamIndex, attribute))
            {
                return value.GetValue();
            }
        }

        /// <summary>
        /// Gets the value of an attribute from the underlying media source.
        /// </summary>
        /// <param name="stream">
        /// The stream or object to query.
        /// </param>
        /// <param name="attribute">
        /// A GUID that identifies the attribute to retrieve.
        /// </param>
        /// <returns>
        /// The value of the attribute.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/40544E1E-CCE2-4860-AEB2-B60696B09145(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/40544E1E-CCE2-4860-AEB2-B60696B09145(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public object GetPresentationAttributeValue(StreamAVMS stream, Guid attribute)
        {
            using (PropVariant value = this.GetPresentationAttribute(stream, attribute))
            {
                return value.GetValue();
            }
        }
    }
}
