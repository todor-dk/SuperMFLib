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

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Specifies the buffering parameters for a network byte stream.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MFBYTESTREAM_BUFFERING_PARAMS {
    ///   QWORD                cbTotalFileSize;
    ///   QWORD                cbPlayableDataSize;
    ///   MF_LEAKY_BUCKET_PAIR *prgBuckets;
    ///   DWORD                cBuckets;
    ///   QWORD                qwNetBufferingTime;
    ///   QWORD                qwExtraBufferingTimeDuringSeek;
    ///   QWORD                qwPlayDuration;
    ///   float                dRate;
    /// } MFBYTESTREAM_BUFFERING_PARAMS;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6667D32C-36A8-414E-A546-02D00A447B70(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6667D32C-36A8-414E-A546-02D00A447B70(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MFBYTESTREAM_BUFFERING_PARAMS")]
    public struct MFByteStreamBufferingParams
    {
        /// <summary>
        /// Size of the file, in bytes. If the total size is unknown, set this member to -1.
        /// </summary>
        public long cbTotalFileSize;
        /// <summary>
        /// Size of the playable media data in the file, excluding any trailing data that is not useful for
        /// playback. If this value is unknown, set this member to -1.
        /// </summary>
        public long cbPlayableDataSize;
        /// <summary>
        /// Pointer to an array of <see cref="MF_LeakyBucketPair" /> structures. Each member of the array gives
        /// the buffer window for a particular bit rate.
        /// </summary>
        public IntPtr prgBuckets;
        /// <summary>
        /// The number of elements in the <strong>prgBuckets</strong> array.
        /// </summary>
        public int cBuckets;
        /// <summary>
        /// Amount of data to buffer from the network, in 100-nanosecond units. This value is in addition to
        /// the buffer windows defined in the <strong>prgBuckets</strong> member.
        /// </summary>
        public long qwNetBufferingTime;
        /// <summary>
        /// Amount of additional data to buffer when seeking, in 100-nanosecond units. This value reflects the
        /// fact that downloading must start from the previous key frame before the seek point. If the value is
        /// unknown, set this member to zero.
        /// </summary>
        public long qwExtraBufferingTimeDuringSeek;
        /// <summary>
        /// The playback duration of the file, in 100-nanosecond units. If the duration is unknown, set this
        /// member to zero.
        /// </summary>
        public long qwPlayDuration;
        /// <summary>
        /// Playback rate.
        /// </summary>
        public float dRate;
    }

#endif

}
