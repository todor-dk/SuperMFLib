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

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.Core.Structs
{
#if NOT_IN_USE

    /// <summary>
    /// Contains information about a video compression format. This structure is used in the
    /// <see cref="MFVideoFormat" /> structure.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MFVideoCompressedInfo {
    ///   LONGLONG AvgBitrate;
    ///   LONGLONG AvgBitErrorRate;
    ///   DWORD    MaxKeyFrameSpacing;
    /// } MFVideoCompressedInfo;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FE9AA287-33E9-4413-8BC5-0E7B2DA1112E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FE9AA287-33E9-4413-8BC5-0E7B2DA1112E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 8), UnmanagedName("MFVideoCompressedInfo")]
    internal struct MFVideoCompressedInfo
    {
        /// <summary>
        /// Average bit rate of the encoded video stream, in bits per second.
        /// </summary>
        public long AvgBitrate;
        /// <summary>
        /// Expected error rate, in bits per second.
        /// </summary>
        public long AvgBitErrorRate;
        /// <summary>
        /// Number of frames between key frames.
        /// </summary>
        public int MaxKeyFrameSpacing;
    }

#endif
}
