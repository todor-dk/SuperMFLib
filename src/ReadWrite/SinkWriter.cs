using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using MediaFoundation.Core;
using MediaFoundation.Internals;
using MediaFoundation.Misc.Classes;
using MediaFoundation.ReadWrite.Classes;
using MediaFoundation.ReadWrite.Interfaces;

namespace MediaFoundation.ReadWrite
{
    /// <summary>
    /// The <see cref="SinkWriter"/> class implements a wrapper around the
    /// <see cref="IMFSinkWriter"/> COM interface. This adds <see cref="IDisposable"/>
    /// support to make it compatible with the <strong>using</strong> statement as well as
    /// exposing <i>civilized</i> version of the <see cref="IMFSinkWriter"/>
    /// interface's methods.
    /// <para/>
    /// <see cref="IMFSinkWriter"/>:
    /// Implemented by the Microsoft Media Foundation source reader object.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/76FB915E-1586-429A-88A5-BD1290799352(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/76FB915E-1586-429A-88A5-BD1290799352(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public class SinkWriter : COM<IMFSinkWriter>
    {
        private const int MF_SINK_WRITER_ALL_STREAMS = unchecked((int)0xfffffffe);

        #region Construction

        private SinkWriter(IntPtr unknown)
            : base(unknown)
        {
        }

        /// <summary>
        /// Creates a new <see cref="SinkWriter"/> instance from the given IUnknown interface pointer.
        /// </summary>
        /// <param name="unknown">
        /// Pointer to the SinkWriter's IUnknown interface.
        /// <para/>
        /// Ownership of the IUnknown interface pointer is passed to the new object.
        /// On return <paramref name="unknown"/> is set to NULL. The pointer should be considered void.
        /// </param>
        /// <returns>
        /// A new <see cref="SinkWriter"/> or <strong>null</strong> if <paramref name="unknown"/> is NULL.
        /// </returns>
        public static SinkWriter FromUnknown(ref IntPtr unknown)
        {
            if (unknown == IntPtr.Zero)
                return null;
            SinkWriter result = new SinkWriter(unknown);
            unknown = IntPtr.Zero;
            return result;
        }

        #endregion

        /// <summary>
        /// Creates a new sink writer from a given byte stream.
        /// </summary>
        /// <param name="stream">
        /// The sink writer writes to the provided byte stream. (The byte stream must be writable.).
        /// </param>
        /// <param name="attributes">
        /// You can use this parameter to configure the sink writer.
        /// </param>
        /// <returns>
        /// The newly created sink writer.
        /// </returns>
        /// <remarks>
        /// Use a byte stream. The <paramref name="attributes"/> parameter must point to an attribute store that contains
        /// the MF_TRANSCODE_CONTAINERTYPE attribute. The sink writer uses the MF_TRANSCODE_CONTAINERTYPE attribute to
        /// determine the type of file container to write, such as ASF or MP4.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AC6A30C7-5E44-453A-8114-8D7D65332024(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC6A30C7-5E44-453A-8114-8D7D65332024(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static SinkWriter CreateFromStream(ByteStream stream, Attributes attributes)
        {
            return SinkWriter.CreateFromURLInternal(null, stream, attributes);
        }

        /// <summary>
        /// Creates a new sink writer from a given byte stream. The sink writer writes to the byte stream.
        /// </summary>
        /// <param name="stream">
        /// The sink writer writes to the provided byte stream. (The byte stream must be writable.).
        /// </param>
        /// <param name="url">
        /// The URL provided is informational only; the sink writer does not create a new file. The sink writer uses the file name extension to select the container type.
        /// </param>
        /// <returns>
        /// The newly created sink writer.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AC6A30C7-5E44-453A-8114-8D7D65332024(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC6A30C7-5E44-453A-8114-8D7D65332024(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static SinkWriter CreateFromStream(ByteStream stream, string url)
        {
            return SinkWriter.CreateFromURLInternal(url, stream, null);
        }

        /// <summary>
        /// Creates a new sink writer from a given byte stream. The sink writer writes to the byte stream.
        /// </summary>
        /// <param name="url">
        /// The sink writer creates a new file named <paramref name="url"/>. The sink writer uses the file name extension to select the container type.
        /// </param>
        /// <returns>
        /// The newly created sink writer.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AC6A30C7-5E44-453A-8114-8D7D65332024(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC6A30C7-5E44-453A-8114-8D7D65332024(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static SinkWriter CreateFromURL(string url)
        {
            return SinkWriter.CreateFromURLInternal(url, null, null);
        }

        /// <summary>
        /// Creates a new sink writer from a given byte stream. The sink writer writes to the byte stream.
        /// </summary>
        /// <param name="url">
        /// The sink writer creates a new file named <paramref name="url"/>. The sink writer uses the file name extension to select the container type,
        /// but only if <paramref name="attributes"/> does not contain a MF_TRANSCODE_CONTAINERTYPE value.
        /// </param>
        /// <param name="attributes">
        /// You can use this parameter to configure the sink writer.
        /// </param>
        /// <returns>
        /// The newly created sink writer.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AC6A30C7-5E44-453A-8114-8D7D65332024(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AC6A30C7-5E44-453A-8114-8D7D65332024(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static SinkWriter CreateFromURL(string url, Attributes attributes)
        {
            return SinkWriter.CreateFromURLInternal(url, null, attributes);
        }

        private static SinkWriter CreateFromURLInternal(string url, ByteStream stream, Attributes attributes)
        {
            IntPtr writer = IntPtr.Zero;
            int hr = MFExtern.MFCreateSinkWriterFromURL(url, stream.AccessInterface(), attributes.AccessInterface(), out writer);
            COM.ThrowIfNotOKAndReleaseInterface(hr, ref writer);
            Debug.Assert(writer != IntPtr.Zero);
            return SinkWriter.FromUnknown(ref writer);
        }



        /// <summary>
        /// Adds a stream to the sink writer.
        /// </summary>
        /// <param name="mediaType">
        /// This media type specifies the format of the samples that will be written to the file. 
        /// It does not need to match the input format. To set the input format,
        /// call <see cref="SetInputMediaType"/>.
        /// </param>
        /// <returns>
        /// The zero-based index of the new stream.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/9F9B1216-E915-4188-BCFD-6C41E1821EC4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9F9B1216-E915-4188-BCFD-6C41E1821EC4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public int AddStream(MediaType mediaType)
        {
            int pdwStreamIndex;
            int hr = this.Interface.AddStream(mediaType.AccessInterface(), out pdwStreamIndex);
            COM.ThrowIfNotOK(hr);
            return pdwStreamIndex;

        }

        /// <summary>
        /// Sets the input format for a stream on the sink writer.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of the stream. The index is received from the <see cref="AddStream"/> method.
        /// </param>
        /// <param name="inputMediaType">
        /// The media type specifies the input format.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/02A73F73-3B25-4578-9A7E-C9F8A4C8CD99(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/02A73F73-3B25-4578-9A7E-C9F8A4C8CD99(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetInputMediaType(int streamIndex, MediaType inputMediaType)
        {
            this.SetInputMediaType(streamIndex, inputMediaType, null);
        }

        /// <summary>
        /// Sets the input format for a stream on the sink writer.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of the stream. The index is received from the <see cref="AddStream"/> method.
        /// </param>
        /// <param name="inputMediaType">
        /// The media type specifies the input format.
        /// </param>
        /// <param name="encodingParameters">
        /// Use the attribute store to configure the encoder. This parameter can be <strong>NULL</strong>.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/02A73F73-3B25-4578-9A7E-C9F8A4C8CD99(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/02A73F73-3B25-4578-9A7E-C9F8A4C8CD99(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SetInputMediaType(int streamIndex, MediaType inputMediaType, Attributes encodingParameters)
        {
            int hr = this.Interface.SetInputMediaType(streamIndex, inputMediaType.AccessInterface(), encodingParameters.AccessInterface());
            COM.ThrowIfNotOK(hr);
        }
        /// <summary>
        /// Initializes the sink writer for writing.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/32252658-662E-4D2F-A5FE-34F24CE60094(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/32252658-662E-4D2F-A5FE-34F24CE60094(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void BeginWriting()
        {
            int hr = this.Interface.BeginWriting();
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Delivers a sample to the sink writer.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of the stream for this sample.
        /// </param>
        /// <param name="sample">
        /// The sample.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/1C65A5D0-CC1B-456E-9D88-A24DA57EE30A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1C65A5D0-CC1B-456E-9D88-A24DA57EE30A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void WriteSample(int streamIndex, Sample sample)
        {
            int hr = this.Interface.WriteSample(streamIndex, sample.AccessInterface());
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Indicates a gap in an input stream.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of the stream.
        /// </param>
        /// <param name="timestamp">
        /// The position in the stream where the gap in the data occurs. The value is relative to the start of the stream.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/3B4B76B7-1A39-4323-94E7-0B2D159A8038(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3B4B76B7-1A39-4323-94E7-0B2D159A8038(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void SendStreamTick(int streamIndex, Time timestamp)
        {
            int hr = this.Interface.SendStreamTick(streamIndex, timestamp.Value);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Places a marker in the specified stream.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of the stream.
        /// </param>
        /// <param name="context">
        /// Pointer to an application-defined value. The value of this parameter is returned to the caller in
        /// the <em>pvContext</em> parameter of the caller's
        /// <see cref="ReadWrite.IMFSinkWriterCallback.OnMarker"/> callback method. The application is
        /// responsible for any memory allocation associated with this data. This parameter can be <strong>NULL
        /// </strong>.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/93140993-A926-437E-BC40-9B011C4C6832(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/93140993-A926-437E-BC40-9B011C4C6832(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void PlaceMarker(int streamIndex, IntPtr context)
        {
            int hr = this.Interface.PlaceMarker(streamIndex, context);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Notifies the media sink that a stream has reached the end of a segment.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of a stream that has have reached the end of a segment.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/CB5B76B4-FF08-4CAC-BD30-D4F3B57ACB78(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CB5B76B4-FF08-4CAC-BD30-D4F3B57ACB78(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void NotifyEndOfSegment(int streamIndex)
        {
            int hr = this.Interface.NotifyEndOfSegment(streamIndex);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Notifies the media sink that all streams have reached the end of a segment.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/CB5B76B4-FF08-4CAC-BD30-D4F3B57ACB78(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CB5B76B4-FF08-4CAC-BD30-D4F3B57ACB78(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void NotifyEndOfSegment()
        {
            int hr = this.Interface.NotifyEndOfSegment(MF_SINK_WRITER_ALL_STREAMS);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Flushes a streams.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of the stream to flush.
        /// </param>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/997235CB-6CA5-434C-81A6-7A294E0CCCCA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/997235CB-6CA5-434C-81A6-7A294E0CCCCA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Flush(int streamIndex)
        {
            int hr = this.Interface.Flush(streamIndex);
            COM.ThrowIfNotOK(hr);
        }

        /// <summary>
        /// Flushes all streams.
        /// </summary>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/997235CB-6CA5-434C-81A6-7A294E0CCCCA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/997235CB-6CA5-434C-81A6-7A294E0CCCCA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public void Flush()
        {
            int hr = this.Interface.Flush(MF_SINK_WRITER_ALL_STREAMS);
            COM.ThrowIfNotOK(hr);
        }


        /// <summary>
        /// Completes all writing operations on the sink writer.
        /// Call this method after you send all of the input samples to the sink writer. 
        /// The method performs any operations needed to create the final output from the media sink.
        /// </summary>
        public void Finalize()
        {
            int hr = this.Interface.Finalize_();
            COM.ThrowIfNotOK(hr);
        }

        ///// <summary>
        ///// Queries the underlying media encoder for an interface of the given stream.
        ///// </summary>
        ///// <param name="streamIndex">
        ///// The zero-based index of a stream to query.
        ///// </param>
        ///// <param name="guidService">
        ///// A service identifier GUID, or <strong>GUID_NULL</strong>. If the value is <strong>GUID_NULL
        ///// </strong>, the method calls <strong>QueryInterface</strong> to get the requested interface.
        ///// Otherwise, the method calls <see cref="IMFGetService.GetService"/>. For a list of service
        ///// identifiers, see <c>Service Interfaces</c>.
        ///// </param>
        ///// <param name="riid">
        ///// The interface identifier (IID) of the interface being requested.
        ///// </param>
        ///// <param name="ppvObject">
        ///// Receives a pointer to the requested interface. The caller must release the interface.
        ///// </param>
        ///// <returns>
        ///// If this method succeeds, it returns <strong>S_OK</strong>. Otherwise, it returns an <strong>HRESULT
        ///// </strong> error code.
        ///// </returns>
        ///// <remarks>
        ///// <code language="cpp" title="C/C++ Syntax">
        ///// HRESULT GetServiceForStream(
        /////   [in]   DWORD dwStreamIndex,
        /////   [in]   REFGUID guidService,
        /////   [in]   REFIID riid,
        /////   [out]  LPVOID *ppvObject
        ///// );
        ///// </code>
        ///// <para/>
        ///// The above documentation is © Microsoft Corporation. It is reproduced here
        ///// with the sole purpose to increase usability and add IntelliSense support.
        ///// <para/>
        ///// View the original documentation topic online:
        ///// <a href="http://msdn.microsoft.com/en-US/library/166F8F71-E52D-43B1-9137-E4BF79BF5421(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/166F8F71-E52D-43B1-9137-E4BF79BF5421(v=VS.85,d=hv.2).aspx</a>
        ///// </remarks>
        //public object GetServiceForStream<TService>(int streamIndex, Guid guidService, COM.ComFactory<TService> factory)
        //{
        //    Contract.RequiresNotNull(factory, "factory");

        //    Guid riid = COM.IID_IUnknown;
        //    IntPtr ppvObject = IntPtr.Zero;
        //    int hr = this.Interface.GetServiceForStream(streamIndex, guidService, riid, out ppvObject);
        //    // MF_E_UNSUPPORTED_SERVICE: The object does not support the service.
        //    if (hr == MFError.MF_E_UNSUPPORTED_SERVICE)
        //    {
        //        if (ppvObject != IntPtr.Zero)
        //            Marshal.Release(ppvObject);
        //        return null;
        //    }

        //    COM.ThrowIfNotOKAndReleaseInterface(hr, ref ppvObject);
        //    try
        //    {
        //        return factory(ref ppvObject);
        //    }
        //    finally
        //    {
        //        if (ppvObject != IntPtr.Zero)
        //            Marshal.Release(ppvObject);
        //    }
        //}

        /// <summary>
        /// Gets statistics about the performance of the sink writer.
        /// </summary>
        /// <param name="streamIndex">
        /// The zero-based index of a stream to query.
        /// </param>
        /// <returns>
        /// Statistics from the sink writer.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/84028B1D-3843-4289-A04C-3039311D095B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/84028B1D-3843-4289-A04C-3039311D095B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        public MF_SINK_WRITER_STATISTICS GetStatistics(int streamIndex)
        {
            MF_SINK_WRITER_STATISTICS stats = new Classes.MF_SINK_WRITER_STATISTICS();
            int hr = this.Interface.GetStatistics(streamIndex, stats);
            COM.ThrowIfNotOK(hr);
            return stats;
        }

        /// <summary>
        /// Gets statistics about the performance of the media sink.
        /// </summary>
        /// <returns>
        /// Statistics from the media sink.
        /// </returns>
        /// <remarks>
        /// View the original documentation topic online:
        /// <a href="http://msdn.microsoft.com/en-US/library/84028B1D-3843-4289-A04C-3039311D095B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/84028B1D-3843-4289-A04C-3039311D095B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [PreserveSig]
        public MF_SINK_WRITER_STATISTICS GetStatistics()
        {
            return this.GetStatistics(MF_SINK_WRITER_ALL_STREAMS);
        }
    }
}
