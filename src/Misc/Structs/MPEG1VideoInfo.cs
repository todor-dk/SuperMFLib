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

namespace MediaFoundation.Misc.Structs
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// The <strong>MPEG1VIDEOINFO</strong> structure describes an MPEG-1 video stream. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/AE5B8825-7C1C-4A44-B665-098732E6C3BC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AE5B8825-7C1C-4A44-B665-098732E6C3BC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MPEG1VIDEOINFO"), StructLayout(LayoutKind.Sequential)]
    internal struct MPEG1VideoInfo
    {
        /// <summary>
        /// <see cref="Misc.VideoInfoHeader"/> structure. 
        /// </summary>
        public VideoInfoHeader hdr;
        /// <summary>
        /// 25-bit group-of-pictures (GOP) time code at start of data.
        /// </summary>
        public int dwStartTimeCode;
        /// <summary>
        /// Length of the <strong>bSequenceHeader</strong> member, in bytes. 
        /// </summary>
        public int cbSequenceHeader;
        /// <summary>
        /// Start of an array that contains the sequence header, including quantization matrices, if any. The
        /// size of the array is given in the <strong>cbSequenceHeader</strong> member. 
        /// </summary>
        public byte [] bSequenceHeader; // Needs marshaler
    }

#endif

}
