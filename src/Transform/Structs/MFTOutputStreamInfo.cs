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
    /// Contains information about an output stream on a Media Foundation transform (MFT). To get these
    /// values, call <see cref="Transform.IMFTransform.GetOutputStreamInfo" />.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MFT_OUTPUT_STREAM_INFO {
    ///   DWORD dwFlags;
    ///   DWORD cbSize;
    ///   DWORD cbAlignment;
    /// } MFT_OUTPUT_STREAM_INFO;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/4181D8B8-7C1B-4F8E-A0C6-63AB039539F6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4181D8B8-7C1B-4F8E-A0C6-63AB039539F6(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 4), UnmanagedName("MFT_OUTPUT_STREAM_INFO")]
    public struct MFTOutputStreamInfo
    {
        /// <summary>
        /// Bitwise <strong>OR</strong> of zero or more flags from the
        /// <see cref="Transform.MFTOutputStreamInfoFlags" /> enumeration.
        /// </summary>
        public MFTOutputStreamInfoFlags dwFlags;
        /// <summary>
        /// Minimum size of each output buffer, in bytes. If the MFT does not require a specific size, the
        /// value is zero. For uncompressed audio, the value should be the audio frame size, which you can get
        /// from the <see cref="MFAttributesClsid.MF_MT_AUDIO_BLOCK_ALIGNMENT" /> attribute in the media type.
        /// <para />
        /// If the <strong>dwFlags</strong> member contains the MFT_OUTPUT_STREAM_PROVIDES_SAMPLES flag, the
        /// value is zero, because the MFT allocates the output buffers.
        /// </summary>
        public int cbSize;
        /// <summary>
        /// The memory alignment required for output buffers. If the MFT does not require a specific alignment,
        /// the value is zero. If the <strong>dwFlags</strong> member contains the
        /// MFT_OUTPUT_STREAM_PROVIDES_SAMPLES flag, this value is the alignment that the MFT uses internally
        /// when it allocates samples. It is recommended, but not required, that MFTs allocate buffers with at
        /// least a 16-byte memory alignment.
        /// </summary>
        public int cbAlignment;
    }

}
