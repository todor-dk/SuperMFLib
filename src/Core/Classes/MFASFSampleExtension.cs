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

namespace MediaFoundation.Core.Classes
{
#if NOT_IN_USE
    /// <summary>
    /// ASF Payload Extension GUIDs.
    /// This class defines payload extensions for Advanced Systems Format (ASF) streams.
    /// </summary>
    /// <remarks>
    /// Online Documentation:
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms703998(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/ms703998(v=vs.85).aspx</a>.
    /// </remarks>
    public static class MFASFSampleExtension
    {
        /// <summary>
        /// The data indicates the duration, in milliseconds, of the sample contained in the buffer object.
        /// </summary>
        public static readonly Guid SampleDuration = new Guid(0xc6bd9450, 0x867f, 0x4907, 0x83, 0xa3, 0xc7, 0x79, 0x21, 0xb7, 0x33, 0xad);
        /// <summary>
        /// The data indicates whether the sample is a key frame. A value of zero indicates that the sample is not a key frame. 
        /// A nonzero value indicates that it is a key frame.
        /// </summary>
        public static readonly Guid OutputCleanPoint = new Guid(0xf72a3c6f, 0x6eb4, 0x4ebc, 0xb1, 0x92, 0x9, 0xad, 0x97, 0x59, 0xe8, 0x28);
        /// <summary>
        /// The data is a SMPTE time code.
        /// </summary>
        public static readonly Guid SMPTE = new Guid(0x399595ec, 0x8667, 0x4e2d, 0x8f, 0xdb, 0x98, 0x81, 0x4c, 0xe7, 0x6c, 0x1e);
        /// <summary>
        /// The data in the sample extension specifies the name of the file from which the content in the sample was taken.
        /// </summary>
        public static readonly Guid FileName = new Guid(0xe165ec0e, 0x19ed, 0x45d7, 0xb4, 0xa7, 0x25, 0xcb, 0xd1, 0xe2, 0x8e, 0x9b);
        /// <summary>
        /// The data identifies the type of content that the sample contains.
        /// </summary>
        public static readonly Guid ContentType = new Guid(0xd590dc20, 0x07bc, 0x436c, 0x9c, 0xf7, 0xf3, 0xbb, 0xfb, 0xf1, 0xa4, 0xdc);
        /// <summary>
        /// The data indicates the pixel aspect ratio of the content in the sample.
        /// </summary>
        public static readonly Guid PixelAspectRatio = new Guid(0x1b1ee554, 0xf9ea, 0x4bc8, 0x82, 0x1a, 0x37, 0x6b, 0x74, 0xe4, 0xc4, 0xb8);
        /// <summary>
        /// Extension used by WMDRM-ND: Sample ID.
        /// </summary>
        public static readonly Guid Encryption_SampleID = new Guid(0x6698B84E, 0x0AFA, 0x4330, 0xAE, 0xB2, 0x1C, 0x0A, 0x98, 0xD7, 0xA4, 0x4D);
        /// <summary>
        /// Extension used by WMDRM-ND: Key ID.
        /// </summary>
        public static readonly Guid Encryption_KeyID = new Guid(0x76376591, 0x795f, 0x4da1, 0x86, 0xed, 0x9d, 0x46, 0xec, 0xa1, 0x09, 0xa9);
    }
#endif
}
