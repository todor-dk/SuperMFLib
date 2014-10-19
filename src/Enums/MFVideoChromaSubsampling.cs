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

namespace MediaFoundation
{


    /// <summary>
    /// Contains flags that define the chroma encoding scheme for Y'Cb'Cr' data.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/778D0456-F98E-44AC-AFB7-9CE01DA06741(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/778D0456-F98E-44AC-AFB7-9CE01DA06741(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFVideoChromaSubsampling")]
    public enum MFVideoChromaSubsampling
    {
        /// <summary>
        /// Chroma samples are aligned vertically and horizontally with the luma samples. YUV formats such as
        /// 4:4:4, 4:2:2, and 4:1:1 are always cosited in both directions and should use this flag.
        /// </summary>
        Cosited = 7,
        /// <summary>
        /// Specifies the chroma encoding scheme for PAL DV video.
        /// </summary>
        DV_PAL = 6,
        /// <summary>
        /// Reserved. This member forces the enumeration type to compile as a <strong>DWORD</strong> value. 
        /// </summary>
        ForceDWORD = 0x7fffffff,
        /// <summary>
        /// Chroma samples are aligned horizontally with the luma samples, or with multiples of the luma
        /// samples. If this flag is not set, chroma samples are located 1/2 pixel to the right of the
        /// corresponding luma sample.
        /// </summary>
        Horizontally_Cosited = 4,
        /// <summary>
        /// Reserved.
        /// </summary>
        Last = 8,
        /// <summary>
        /// Specifies the chroma encoding scheme for MPEG-1 video.
        /// </summary>
        MPEG1 = 1,
        /// <summary>
        /// Specifies the chroma encoding scheme for MPEG-2 video. Chroma samples are aligned horizontally with
        /// the luma samples, but are not aligned vertically. The U and V planes are aligned vertically.
        /// </summary>
        MPEG2 = 5,
        /// <summary>
        /// Chroma should be reconstructed as if the underlying video was progressive content, rather than
        /// skipping fields or applying chroma filtering to minimize artifacts from reconstructing 4:2:0
        /// interlaced chroma.
        /// </summary>
        ProgressiveChroma = 8,
        /// <summary>
        /// Unknown encoding scheme.
        /// </summary>
        Unknown = 0,
        /// <summary>
        /// The U and V planes are aligned vertically. If this flag is not set, the chroma planes are assumed
        /// to be out of phase by 1/2 chroma sample, alternating between a line of U followed by a line of V.
        /// </summary>
        Vertically_AlignedChromaPlanes = 1,
        /// <summary>
        /// Chroma samples are aligned vertically with the luma samples, or with multiples of the luma samples.
        /// If this flag is not set, chroma samples are located 1/2 pixel down from the corresponding luma
        /// sample.
        /// </summary>
        Vertically_Cosited = 2
    }

}
