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
using System.Runtime.InteropServices;

using MediaFoundation.Misc;

namespace MediaFoundation.Transform.Enums
{
#if NOT_IN_USE

    /// <summary>
    /// Describes an output stream on a Media Foundation transform (MFT).
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F67E1E81-BAF5-414A-AC23-45D4D6317255(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F67E1E81-BAF5-414A-AC23-45D4D6317255(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("_MFT_OUTPUT_STREAM_INFO_FLAGS")]
    internal enum MFTOutputStreamInfoFlags
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// Each media sample ( <see cref="IMFSample"/> interface) of output data from the MFT contains
        /// complete, unbroken units of data. The definition of a <em>unit of data</em> depends on the media
        /// type: For uncompressed video, a video frame; for compressed data, a compressed packet; for
        /// uncompressed audio, a single audio frame. 
        /// <para/>
        /// For uncompressed audio formats, this flag is always implied. (It is valid to set the flag, but not
        /// required.) An uncompressed audio frame should never span more than one media sample.
        /// </summary>
        WholeSamples = 0x00000001,
        /// <summary>
        /// Each output sample contains exactly one unit of data, as defined for the
        /// MFT_OUTPUT_STREAM_WHOLE_SAMPLES flag.
        /// <para/>
        /// If this flag is present, the MFT_OUTPUT_STREAM_WHOLE_SAMPLES flag must also be present.
        /// <para/>
        /// An MFT that outputs uncompressed audio should not set this flag. For efficiency, it should output
        /// more than one audio frame at a time.
        /// </summary>
        SingleSamplePerBuffer = 0x00000002,
        /// <summary>
        /// All output samples are the same size.
        /// </summary>
        FixedSampleSize = 0x00000004,
        /// <summary>
        /// The MFT can discard the output data from this output stream, if requested by the client. To discard
        /// the output, set the MFT_PROCESS_OUTPUT_DISCARD_WHEN_NO_BUFFER flag in the 
        /// <see cref="Transform.IMFTransform.ProcessOutput"/> method. 
        /// </summary>
        Discardable = 0x00000008,
        /// <summary>
        /// This output stream is optional. The client can deselect the stream by not setting a media type or
        /// by setting a <strong>NULL</strong> media type. When an optional stream is deselected, it does not
        /// produce any output data. 
        /// </summary>
        Optional = 0x00000010,
        /// <summary>
        /// The MFT provides the output samples for this stream, either by allocating them internally or by
        /// operating directly on the input samples. The MFT cannot use output samples provided by the client
        /// for this stream.
        /// <para/>
        /// If this flag is not set, the MFT must set <strong>cbSize</strong> to a nonzero value in the 
        /// <see cref="Transform.MFTOutputStreamInfo"/> structure, so that the client can allocate the correct
        /// buffer size. For more information, see <see cref="Transform.IMFTransform.GetOutputStreamInfo"/>.
        /// This flag cannot be combined with the MFT_OUTPUT_STREAM_CAN_PROVIDE_SAMPLES flag. 
        /// </summary>
        ProvidesSamples = 0x00000100,
        /// <summary>
        /// The MFT can either provide output samples for this stream or it can use samples that the client
        /// allocates. This flag cannot be combined with the MFT_OUTPUT_STREAM_PROVIDES_SAMPLES flag.
        /// <para/>
        /// If the MFT does not set this flag or the MFT_OUTPUT_STREAM_PROVIDES_SAMPLES flag, the client must
        /// allocate the samples for this output stream. The MFT will not provide its own samples.
        /// </summary>
        CanProvideSamples = 0x00000200,
        /// <summary>
        /// The MFT does not require the client to process the output for this stream. If the client continues
        /// to send input data without getting the output from this stream, the MFT simply discards the
        /// previous input.
        /// </summary>
        LazyRead = 0x00000400,
        /// <summary>
        /// The MFT might remove this output stream during streaming. This flag typically applies to
        /// demultiplexers, where the input data contains multiple streams that can start and stop during
        /// streaming. For more information, see <see cref="Transform.IMFTransform.ProcessOutput"/>. 
        /// </summary>
        Removable = 0x00000800
    }

#endif
}
