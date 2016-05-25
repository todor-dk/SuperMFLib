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
    /// Contains flags that describe a video stream.
    /// <para/>
    /// These flags are used in the <see cref="MFVideoInfo"/> structure, which is part of the
    /// <see cref="MFVideoFormat"/> structure.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/2530BF1D-05B1-4C16-B00B-117C0DADB301(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2530BF1D-05B1-4C16-B00B-117C0DADB301(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags]
    [UnmanagedName("MFVideoFlags")]
    public enum MFVideoFlags : long
    {
        /// <summary>
        /// Use this value to mask out the next three flags, which describe the effective aspect ratio of the
        /// image. This value by itself is not a valid flag.
        /// </summary>
        PAD_TO_Mask = 0x0001 | 0x0002,

        /// <summary>
        /// Do not modify the picture aspect ratio.
        /// </summary>
        PAD_TO_None = 0 * 0x0001,

        /// <summary>
        /// Display the image in a 4 x 3 area. If this flag is set, the geometrical aperture of the picture
        /// should be expanded to a 4 x 3 area by letterboxing or pillarboxing. The geometrical aperture is the
        /// portion of the image that is intended to be viewed, without any overscan region.
        /// </summary>
        PAD_TO_4x3 = 1 * 0x0001,

        /// <summary>
        /// Display the image in a 16 x 9 area. If this flag is set, the geometrical aperture of the picture
        /// should be expanded to a 16 x 9 area by letterboxing or pillarboxing.
        /// </summary>
        PAD_TO_16x9 = 2 * 0x0001,

        /// <summary>
        /// Use this value to mask out the next three flags, which describe the source content. This value by
        /// itself is not a valid flag.
        /// </summary>
        SrcContentHintMask = 0x0004 | 0x0008 | 0x0010,

        /// <summary>
        /// There is no additional information about the source content .
        /// </summary>
        SrcContentHintNone = 0 * 0x0004,

        /// <summary>
        /// The source is a 16 x 9 image encoded within a 4 x 3 area.
        /// </summary>
        SrcContentHint16x9 = 1 * 0x0004,

        /// <summary>
        /// The source is a 2.35:1 image encoded within a 16 x 9 or 4 x 3 area.
        /// </summary>
        SrcContentHint235_1 = 2 * 0x0004,

        /// <summary>
        /// Analog copy protection should be applied.
        /// </summary>
        AnalogProtected = 0x0020,

        /// <summary>
        /// Digital copy protection should be applied.
        /// </summary>
        DigitallyProtected = 0x0040,

        /// <summary>
        /// The video source is progressive content encoded as interlaced video, possibly using 3:2 pulldown.
        /// This flag is obsolete. See Remarks.
        /// </summary>
        ProgressiveContent = 0x0080,

        /// <summary>
        /// Used to extract the field repeat count. This flag is obsolete. See Remarks.
        /// </summary>
        FieldRepeatCountMask = 0x0100 | 0x0200 | 0x0400,

        /// <summary>
        /// Used to extract the field repeat count. This flag is obsolete. See Remarks.
        /// </summary>
        FieldRepeatCountShift = 8,

        /// <summary>
        /// The progressive sequence was disrupted and the sequence is interlaced at the break. This flag is
        /// obsolete. See Remarks.
        /// </summary>
        ProgressiveSeqReset = 0x0800,

        /// <summary>
        /// Apply the pan and scan rectangle on the output.
        /// </summary>
        PanScanEnabled = 0x20000,

        /// <summary>
        /// The sample contains the lower field. This flag applies only if the interlace mode is single fields
        /// (MFVideoInterlace_FieldSingleUpperFirst or MFVideoInterlace_FieldSingleLowerFirst). This flag is
        /// obsolete. See Remarks.
        /// </summary>
        LowerFieldFirst = 0x40000,

        /// <summary>
        /// The image is represented bottom-up in memory. This flag should be used only with RGB formats.
        /// </summary>
        BottomUpLinearRep = 0x80000,

        /// <summary>
        /// Reserved. Do not use.
        /// </summary>
        DXVASurface = 0x100000,

        /// <summary>
        /// Reserved. Do not use.
        /// </summary>
        RenderTargetSurface = 0x400000,

        /// <summary>
        /// Reserved. This member forces the enumeration type to compile as a <strong>QWORD</strong> value.
        /// </summary>
        ForceQWORD = 0x7FFFFFFF
    }
}
