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

    /// <summary>
    /// Specifies the container type of an encoded file. The container types are supported by Media
    /// Foundation.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/97FD968A-6843-4695-AECE-02F9ACD618FD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/97FD968A-6843-4695-AECE-02F9ACD618FD(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public static class MFTranscodeContainerType
    {

        /// <summary>
        /// ASF file container.
        /// </summary>
        public static readonly Guid ASF = new Guid(0x430f6f6e, 0xb6bf, 0x4fc1, 0xa0, 0xbd, 0x9e, 0xe4, 0x6e, 0xee, 0x2a, 0xfb);
        /// <summary>
        /// MP4 file container.
        /// </summary>
        public static readonly Guid MPEG4 = new Guid(0xdc6cd05d, 0xb9d0, 0x40ef, 0xbd, 0x35, 0xfa, 0x62, 0x2c, 0x1a, 0xb2, 0x8a);
        /// <summary>
        /// MP3 file container.
        /// </summary>
        public static readonly Guid MP3 = new Guid(0xe438b912, 0x83f1, 0x4de6, 0x9e, 0x3a, 0x9f, 0xfb, 0xc6, 0xdd, 0x24, 0xd1);
        /// <summary>
        /// 3GP file container. 
        /// </summary>
        public static readonly Guid x3GP = new Guid(0x34c50167, 0x4472, 0x4f34, 0x9e, 0xa0, 0xc4, 0x9f, 0xba, 0xcf, 0x03, 0x7d);
        /// <summary>
        /// AC3 file container. 
        /// </summary>
        public static readonly Guid AC3 = new Guid(0x6d8d91c3, 0x8c91, 0x4ed1, 0x87, 0x42, 0x8c, 0x34, 0x7d, 0x5b, 0x44, 0xd0);
        /// <summary>
        /// ADTS file container. 
        /// </summary>
        public static readonly Guid ADTS = new Guid(0x132fd27d, 0x0f02, 0x43de, 0xa3, 0x01, 0x38, 0xfb, 0xbb, 0xb3, 0x83, 0x4e);
        /// <summary>
        /// MPEG2 file container. 
        /// </summary>
        public static readonly Guid MPEG2 = new Guid(0xbfc2dbf9, 0x7bb4, 0x4f8f, 0xaf, 0xde, 0xe1, 0x12, 0xc4, 0x4b, 0xa8, 0x82);
        /// <summary>
        /// FMPEG4 file container. 
        /// </summary>
        public static readonly Guid FMPEG4 = new Guid(0x9ba876f1, 0x419f, 0x4b77, 0xa1, 0xe0, 0x35, 0x95, 0x9d, 0x9d, 0x40, 0x4);
        /// <summary>
        /// WAVE file container. Supported in Windows 8.1 and and later.
        /// </summary>
        public static readonly Guid WAVE = new Guid(0x64c3453c, 0x0f26, 0x4741, 0xbe, 0x63, 0x87, 0xbd, 0xf8, 0xbb, 0x93, 0x5b);
        /// <summary>
        /// AVI file container. Supported in Windows 8.1 and and later.
        /// </summary>
        public static readonly Guid AVI = new Guid(0x7edfe8af, 0x402f, 0x4d76, 0xa3, 0x3c, 0x61, 0x9f, 0xd1, 0x57, 0xd0, 0xf1);
    }
}
