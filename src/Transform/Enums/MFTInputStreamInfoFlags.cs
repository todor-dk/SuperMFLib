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

namespace MediaFoundation.Transform
{


    /// <summary>
    /// Describes an input stream on a Media Foundation transform (MFT).
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D9A05A0F-56A7-4A91-93DC-A5079E51DEAC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D9A05A0F-56A7-4A91-93DC-A5079E51DEAC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("_MFT_INPUT_STREAM_INFO_FLAGS")]
    public enum MFTInputStreamInfoFlags
    {
        /// <summary>
        /// Each media sample ( <see cref="IMFSample"/> interface) of input data must contain complete,
        /// unbroken units of data. The definition of a <em>unit of data</em> depends on the media type: For
        /// uncompressed video, a video frame; for compressed data, a compressed packet; for uncompressed
        /// audio, a single audio frame. 
        /// <para/>
        /// For uncompressed audio formats, this flag is always implied. (It is valid to set the flag, but not
        /// required.) An uncompressed audio frame should never span more than one media sample.
        /// </summary>
        WholeSamples = 0x1,
        /// <summary>
        /// Each media sample that the client provides as input must contain exactly one unit of data, as
        /// defined for the MFT_INPUT_STREAM_WHOLE_SAMPLES flag.
        /// <para/>
        /// If this flag is present, the MFT_INPUT_STREAM_WHOLE_SAMPLES flag must also be present.
        /// <para/>
        /// An MFT that processes uncompressed audio should not set this flag. The MFT should accept buffers
        /// that contain more than a single audio frame, for efficiency.
        /// </summary>
        SingleSamplePerBuffer = 0x2,
        /// <summary>
        /// All input samples must be the same size. The size is given in the <strong>cbSize</strong> member of
        /// the <see cref="Transform.MFTInputStreamInfo"/> structure. The MFT must provide this value. During
        /// processing, the MFT should verify the size of input samples, and may drop samples with incorrect
        /// size. 
        /// </summary>
        FixedSampleSize = 0x4,
        /// <summary>
        /// The MFT might hold one or more input samples after 
        /// <see cref="Transform.IMFTransform.ProcessOutput"/> is called. If this flag is present, the <strong>
        /// hnsMaxLatency</strong> member of the <see cref="Transform.MFTInputStreamInfo"/> structure gives the
        /// maximum latency, and the <strong>cbMaxLookahead</strong> member gives the maximum number of bytes
        /// of lookahead. 
        /// </summary>
        HoldsBuffers = 0x8,
        /// <summary>
        /// The MFT does not hold input samples after the <see cref="Transform.IMFTransform.ProcessInput"/>
        /// method returns. It releases the sample before the <strong>ProcessInput</strong> method returns. 
        /// <para/>
        /// If this flag is absent, the MFT might hold a reference count on the samples that are passed to the 
        /// <c>ProcessInput</c> method. The client must not re-use or delete the buffer memory until the MFT
        /// releases the sample's <see cref="IMFSample"/> pointer. 
        /// <para/>
        /// If this flag is absent, it does not guarantee that the MFT holds a reference count on the input
        /// samples. It is valid for an MFT to release input samples in <c>ProcessInput</c> even if the MFT
        /// does not set this flag. However, setting this flag might enable to client to optimize how it
        /// re-uses buffers. 
        /// <para/>
        /// An MFT should not set this flag if it ever holds onto an input sample after returning from 
        /// <c>ProcessInput</c>. 
        /// </summary>
        DoesNotAddRef = 0x100,
        /// <summary>
        /// This input stream can be removed by calling <see cref="Transform.IMFTransform.DeleteInputStream"/>.
        /// </summary>
        Removable = 0x200,
        /// <summary>
        /// This input stream is optional. The transform can produce output without receiving input from this
        /// stream. The caller can deselect the stream by not setting a media type or by setting a <strong>NULL
        /// </strong> media type. It is possible for every input stream on a transform to be optional, but at
        /// least one input must be selected in order to produce output. 
        /// </summary>
        Optional = 0x400,
        /// <summary>
        /// The MFT can perform in-place processing. In this mode, the MFT directly modifies the input buffer.
        /// When the client calls <c>ProcessOutput</c>, the same sample that was delivered to this stream is
        /// returned in the output stream that has a matching stream identifier. This flag implies that the MFT
        /// holds onto the input buffer, so this flag cannot combined with the MFT_INPUT_STREAM_DOES_NOT_ADDREF
        /// flag. 
        /// <para/>
        /// If this flag is present, the MFT must set the MFT_OUTPUT_STREAM_PROVIDES_SAMPLES or
        /// MFT_OUTPUT_STREAM_CAN_PROVIDE_SAMPLES flag for the output stream that corresponds to this input
        /// stream. (See <see cref="Transform.IMFTransform.GetOutputStreamInfo"/>). 
        /// </summary>
        ProcessesInPlace = 0x800
    }

}
