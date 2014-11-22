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
    /// Contains information about an input stream on a Media Foundation transform (MFT). To get these
    /// values, call <see cref="Transform.IMFTransform.GetInputStreamInfo" />.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MFT_INPUT_STREAM_INFO {
    ///   LONGLONG hnsMaxLatency;
    ///   DWORD    dwFlags;
    ///   DWORD    cbSize;
    ///   DWORD    cbMaxLookahead;
    ///   DWORD    cbAlignment;
    /// } MFT_INPUT_STREAM_INFO;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/DE3D6D70-3525-42A0-BC1A-2625E7EBD918(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DE3D6D70-3525-42A0-BC1A-2625E7EBD918(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 8), UnmanagedName("MFT_INPUT_STREAM_INFO")]
    public struct MFTInputStreamInfo
    {
        /// <summary>
        /// Maximum amount of time between an input sample and the corresponding output sample, in
        /// 100-nanosecond units. For example, an MFT that buffers two samples, each with a duration of 1
        /// second, has a maximum latency of two seconds. If the MFT always turns input samples directly into
        /// output samples, with no buffering, the latency is zero.
        /// </summary>
        public long hnsMaxLatency;
        /// <summary>
        /// Bitwise <strong>OR</strong> of zero or more flags from the
        /// <see cref="Transform.MFTInputStreamInfoFlags" /> enumeration.
        /// </summary>
        public MFTInputStreamInfoFlags dwFlags;
        /// <summary>
        /// The minimum size of each input buffer, in bytes. If the size is variable or the MFT does not
        /// require a specific size, the value is zero. For uncompressed audio, the value should be the audio
        /// frame size, which you can get from the <see cref="MFAttributesClsid.MF_MT_AUDIO_BLOCK_ALIGNMENT" />
        /// attribute in the media type.
        /// </summary>
        public int cbSize;
        /// <summary>
        /// Maximum amount of input data, in bytes, that the MFT holds to perform lookahead. <em>Lookahead</em>
        /// is the action of looking forward in the data before processing it. This value should be the
        /// worst-case value. If the MFT does not keep a lookahead buffer, the value is zero.
        /// </summary>
        public int cbMaxLookahead;
        /// <summary>
        /// The memory alignment required for input buffers. If the MFT does not require a specific alignment,
        /// the value is zero.
        /// </summary>
        public int cbAlignment;
    }

}
