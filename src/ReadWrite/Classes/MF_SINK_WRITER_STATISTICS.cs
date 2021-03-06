#region license

/*
MediaFoundationLib - Provide access to MediaFoundation interfaces via .NET
Copyright (C) 2007
http://mfnet.sourceforge.net

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin St, Fifth Floor, Boston, MA  02110-1301  USA
*/

#endregion

using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation.ReadWrite.Classes
{
    /// <summary>
    /// Contains statistics about the performance of the sink writer.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MF_SINK_WRITER_STATISTICS {
    ///   DWORD ���cb;
    ///   LONGLONG llLastTimestampReceived;
    ///   LONGLONG llLastTimestampEncoded;
    ///   LONGLONG llLastTimestampProcessed;
    ///   LONGLONG llLastStreamTickReceived;
    ///   LONGLONG llLastSinkSampleRequest;
    ///   QWORD ���qwNumSamplesReceived;
    ///   QWORD ���qwNumSamplesEncoded;
    ///   QWORD ���qwNumSamplesProcessed;
    ///   QWORD ���qwNumStreamTicksReceived;
    ///   DWORD ���dwByteCountQueued;
    ///   QWORD ���qwByteCountProcessed;
    ///   DWORD ���dwNumOutstandingSinkSampleRequests;
    ///   DWORD ���dwAverageSampleRateReceived;
    ///   DWORD ���dwAverageSampleRateEncoded;
    ///   DWORD ���dwAverageSampleRateProcessed;
    /// } MF_SINK_WRITER_STATISTICS;
    /// </code>
    /// <para/>
    /// The above documentation is � Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/FF083AE1-9A53-4215-9738-D1776F8D7F9B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FF083AE1-9A53-4215-9738-D1776F8D7F9B(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    [UnmanagedName("MF_SINK_WRITER_STATISTICS")]
    public class MF_SINK_WRITER_STATISTICS
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MF_SINK_WRITER_STATISTICS"/> class.
        /// </summary>
        public MF_SINK_WRITER_STATISTICS()
        {
            this.Size = Marshal.SizeOf(this);
        }

        /// <summary>
        /// The size of the structure, in bytes.
        /// </summary>
        public int Size;

        /// <summary>
        /// The time stamp of the most recent sample given to the sink writer. The sink writer updates this
        /// value each time the application calls <see cref="ReadWrite.IMFSinkWriter.WriteSample"/>.
        /// </summary>
        public long LastTimestampReceived;

        /// <summary>
        /// The time stamp of the most recent sample to be encoded. The sink writer updates this value whenever
        /// it calls <see cref="Transform.IMFTransform.ProcessOutput"/> on the encoder.
        /// </summary>
        public long LastTimestampEncoded;

        /// <summary>
        /// The time stamp of the most recent sample given to the media sink. The sink writer updates this
        /// value whenever it calls <see cref="IMFStreamSink.ProcessSample"/> on the media sink.
        /// </summary>
        public long LastTimestampProcessed;

        /// <summary>
        /// The time stamp of the most recent stream tick. The sink writer updates this value whenever the
        /// application calls <see cref="ReadWrite.IMFSinkWriter.SendStreamTick"/>.
        /// </summary>
        public long LastStreamTickReceived;

        /// <summary>
        /// The system time of the most recent sample request from the media sink. The sink writer updates this
        /// value whenever it receives an <c>MEStreamSinkRequestSample</c> event from the media sink. The value
        /// is the current system time.
        /// </summary>
        public long LastSinkSampleRequest;

        /// <summary>
        /// The number of samples received.
        /// </summary>
        public long NumSamplesReceived;

        /// <summary>
        /// The number of samples encoded.
        /// </summary>
        public long NumSamplesEncoded;

        /// <summary>
        /// The number of samples given to the media sink.
        /// </summary>
        public long NumSamplesProcessed;

        /// <summary>
        /// The number of stream ticks received.
        /// </summary>
        public long NumStreamTicksReceived;

        /// <summary>
        /// The amount of data, in bytes, currently waiting to be processed.
        /// </summary>
        public int ByteCountQueued;

        /// <summary>
        /// The total amount of data, in bytes, that has been sent to the media sink.
        /// </summary>
        public long ByteCountProcessed;

        /// <summary>
        /// The number of pending sample requests.
        /// </summary>
        public int NumOutstandingSinkSampleRequests;

        /// <summary>
        /// The average rate, in media samples per 100-nanoseconds, at which the application sent samples to
        /// the sink writer.
        /// </summary>
        public int AverageSampleRateReceived;

        /// <summary>
        /// The average rate, in media samples per 100-nanoseconds, at which the sink writer sent samples to
        /// the encoder.
        /// </summary>
        public int AverageSampleRateEncoded;

        /// <summary>
        /// The average rate, in media samples per 100-nanoseconds, at which the sink writer sent samples to
        /// the media sink.
        /// </summary>
        public int AverageSampleRateProcessed;
    }

}
