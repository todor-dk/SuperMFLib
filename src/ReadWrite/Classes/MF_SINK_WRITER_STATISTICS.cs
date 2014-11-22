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

namespace MediaFoundation.ReadWrite
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains statistics about the performance of the sink writer.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MF_SINK_WRITER_STATISTICS {
    ///   DWORD    cb;
    ///   LONGLONG llLastTimestampReceived;
    ///   LONGLONG llLastTimestampEncoded;
    ///   LONGLONG llLastTimestampProcessed;
    ///   LONGLONG llLastStreamTickReceived;
    ///   LONGLONG llLastSinkSampleRequest;
    ///   QWORD    qwNumSamplesReceived;
    ///   QWORD    qwNumSamplesEncoded;
    ///   QWORD    qwNumSamplesProcessed;
    ///   QWORD    qwNumStreamTicksReceived;
    ///   DWORD    dwByteCountQueued;
    ///   QWORD    qwByteCountProcessed;
    ///   DWORD    dwNumOutstandingSinkSampleRequests;
    ///   DWORD    dwAverageSampleRateReceived;
    ///   DWORD    dwAverageSampleRateEncoded;
    ///   DWORD    dwAverageSampleRateProcessed;
    /// } MF_SINK_WRITER_STATISTICS;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FF083AE1-9A53-4215-9738-D1776F8D7F9B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FF083AE1-9A53-4215-9738-D1776F8D7F9B(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MF_SINK_WRITER_STATISTICS")]
    public class MF_SINK_WRITER_STATISTICS
    {
        /// <summary>
        /// The size of the structure, in bytes.
        /// </summary>
        int cb;

        /// <summary>
        /// The time stamp of the most recent sample given to the sink writer. The sink writer updates this
        /// value each time the application calls <see cref="ReadWrite.IMFSinkWriter.WriteSample"/>. 
        /// </summary>
        long llLastTimestampReceived;
        /// <summary>
        /// The time stamp of the most recent sample to be encoded. The sink writer updates this value whenever
        /// it calls <see cref="Transform.IMFTransform.ProcessOutput"/> on the encoder. 
        /// </summary>
        long llLastTimestampEncoded;
        /// <summary>
        /// The time stamp of the most recent sample given to the media sink. The sink writer updates this
        /// value whenever it calls <see cref="IMFStreamSink.ProcessSample"/> on the media sink. 
        /// </summary>
        long llLastTimestampProcessed;
        /// <summary>
        /// The time stamp of the most recent stream tick. The sink writer updates this value whenever the
        /// application calls <see cref="ReadWrite.IMFSinkWriter.SendStreamTick"/>. 
        /// </summary>
        long llLastStreamTickReceived;
        /// <summary>
        /// The system time of the most recent sample request from the media sink. The sink writer updates this
        /// value whenever it receives an <c>MEStreamSinkRequestSample</c> event from the media sink. The value
        /// is the current system time. 
        /// </summary>
        long llLastSinkSampleRequest;

        /// <summary>
        /// The number of samples received.
        /// </summary>
        long qwNumSamplesReceived;
        /// <summary>
        /// The number of samples encoded.
        /// </summary>
        long qwNumSamplesEncoded;
        /// <summary>
        /// The number of samples given to the media sink.
        /// </summary>
        long qwNumSamplesProcessed;
        /// <summary>
        /// The number of stream ticks received.
        /// </summary>
        long qwNumStreamTicksReceived;

        /// <summary>
        /// The amount of data, in bytes, currently waiting to be processed. 
        /// </summary>
        int dwByteCountQueued;
        /// <summary>
        /// The total amount of data, in bytes, that has been sent to the media sink.
        /// </summary>
        long qwByteCountProcessed;

        /// <summary>
        /// The number of pending sample requests.
        /// </summary>
        int dwNumOutstandingSinkSampleRequests;

        /// <summary>
        /// The average rate, in media samples per 100-nanoseconds, at which the application sent samples to
        /// the sink writer.
        /// </summary>
        int dwAverageSampleRateReceived;
        /// <summary>
        /// The average rate, in media samples per 100-nanoseconds, at which the sink writer sent samples to
        /// the encoder.
        /// </summary>
        int dwAverageSampleRateEncoded;
        /// <summary>
        /// The average rate, in media samples per 100-nanoseconds, at which the sink writer sent samples to
        /// the media sink.
        /// </summary>
        int dwAverageSampleRateProcessed;
    }

#endif

}
