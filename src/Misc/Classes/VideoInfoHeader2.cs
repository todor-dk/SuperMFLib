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

namespace MediaFoundation.Misc.Classes
{
#if NOT_IN_USE

    /// <summary>
    /// The <strong>VIDEOINFOHEADER2</strong> structure describes the bitmap and color information for a
    /// video image, including interlace, copy protection, and pixel aspect ratio information. 
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct tagVIDEOINFOHEADER2 {
    ///   RECT             rcSource;
    ///   RECT             rcTarget;
    ///   DWORD            dwBitRate;
    ///   DWORD            dwBitErrorRate;
    ///   REFERENCE_TIME   AvgTimePerFrame;
    ///   DWORD            dwInterlaceFlags;
    ///   DWORD            dwCopyProtectFlags;
    ///   DWORD            dwPictAspectRatioX;
    ///   DWORD            dwPictAspectRatioY;
    ///   union {
    ///     DWORD dwControlFlags;
    ///     DWORD dwReserved1;
    ///   };
    ///   DWORD            dwReserved2;
    ///   BITMAPINFOHEADER bmiHeader;
    /// } VIDEOINFOHEADER2;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/5E3D5BF0-435F-45DA-8409-A1463B56A7AE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5E3D5BF0-435F-45DA-8409-A1463B56A7AE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("VIDEOINFOHEADER2"), StructLayout(LayoutKind.Sequential)]
    internal class  VideoInfoHeader2
    {
        /// <summary>
        /// A <c>RECT</c> structure that specifies what part of the source stream should be used to fill the
        /// destination buffer. Renderers can use this field to ask the decoders to stretch or clip. For more
        /// information, see <c>Source and Target Rectangles in Video Renderers</c>. 
        /// </summary>
        public MFRect SrcRect;
        /// <summary>
        /// A <c>RECT</c> structure that specifies that specifies what part of the destination buffer should be
        /// used 
        /// </summary>
        public MFRect TargetRect;
        /// <summary>
        /// The approximate data rate of the video stream, in bits per second. 
        /// </summary>
        public int BitRate;
        /// <summary>
        /// The data error rate of the video stream, in bits per second. 
        /// </summary>
        public int BitErrorRate;
        /// <summary>
        /// The video frame's average display time, in 100-nanosecond units. For more information, see the
        /// Remarks section for the <see cref="Misc.VideoInfoHeader"/> structure. 
        /// </summary>
        public long AvgTimePerFrame;
        /// <summary>
        /// Flags that specify how the video is interlaced. This member is a bit-wise combination of zero or
        /// more of the following flags. The flags in Group 2 are mutually exclusive, and so are the flags in
        /// Group 3. (The flags in Group 2 are not recommended.) The flags in Group 1 may be combined with each
        /// other, and with one flag each from Group 2 and Group 3. See the table at the bottom of this page
        /// for more information about flag combinations.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Group 1</term><description>Description</description></listheader>
        /// <item><term><strong>AMINTERLACE_IsInterlaced</strong></term><description>The stream is interlaced. If this flag is absent, the video is progressive and the other bits are irrelevant.</description></item>
        /// <item><term><strong>AMINTERLACE_1FieldPerSample</strong></term><description>Each media sample contains one field. If this flag is absent, each media sample contains two fields.</description></item>
        /// <item><term><strong>AMINTERLACE_Field1First</strong></term><description>Field 1 is first. If this flag is absent, field 2 is first. (The top field in PAL is field 1, and the top field in NTSC is field 2.)</description></item>
        /// </list>
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Group 2</term><description>Description</description></listheader>
        /// <item><term><strong>AMINTERLACE_FieldPatField1Only</strong></term><description>The stream never contains a field 2.</description></item>
        /// <item><term><strong>AMINTERLACE_FieldPatField2Only</strong></term><description>The stream never contains a field 1.</description></item>
        /// <item><term><strong>AMINTERLACE_FieldPatBothRegular</strong></term><description>There is one field 2 for every field 1.</description></item>
        /// <item><term><strong>AMINTERLACE_FieldPatBothIrregular</strong></term><description>The stream contains an irregular pattern of field 1 and field 2.</description></item>
        /// </list>
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Group 3</term><description>Description</description></listheader>
        /// <item><term><strong>AMINTERLACE_DisplayModeBobOnly</strong></term><description>Bob display mode only.</description></item>
        /// <item><term><strong>AMINTERLACE_DisplayModeWeaveOnly</strong></term><description>Weave display mode only.</description></item>
        /// <item><term><strong>AMINTERLACE_DisplayModeBobOrWeave</strong></term><description>Either bob or weave mode.</description></item>
        /// </list>
        /// <para/>
        /// Set undefined flags to zero, or the connection will be rejected.
        /// </summary>
        public AMInterlace InterlaceFlags;
        /// <summary>
        /// Flag set with the AMCOPYPROTECT_RestrictDuplication value (0x00000001) to indicate that the
        /// duplication of the stream should be restricted. If undefined, specify zero or else the connection
        /// will be rejected.
        /// </summary>
        public AMCopyProtect CopyProtectFlags;
        /// <summary>
        /// The X dimension of picture aspect ratio. For example, 16 for a 16-inch x 9-inch display.
        /// </summary>
        public int PictAspectRatioX;
        /// <summary>
        /// The Y dimension of picture aspect ratio. For example, 9 for a 16-inch x 9-inch display.
        /// </summary>
        public int PictAspectRatioY;
        /// <summary>
        /// This field was originally named <strong>dwReserved</strong>, and was required to be zero. The field
        /// was renamed to <strong>dwControlFlags</strong>, and must contain a bitwise OR of zero or more of
        /// the following flags: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>AMCONTROL_USED</strong></term><description>Indicates the ControlFlags flags are used.</description></item>
        /// <item><term><strong>AMCONTROL_PAD_TO_4x3</strong></term><description>The image should be padded and displayed in a 4 x 3 area.</description></item>
        /// <item><term><strong>AMCONTROL_PAD_TO_16x9</strong></term><description>The image should be padded and displayed in a 16 x 9 area.</description></item>
        /// <item><term><strong>AMCONTROL_COLORINFO_PRESENT</strong></term><description>Additional color information is contained in the upper 24 bits of the <strong>dwControlFlags</strong> field. </description></item>
        /// </list>
        /// <para/>
        /// The AMCONTROL_USED flag provides backward compatibility with older filters. If the AMCONTROL_USED
        /// flag is not set, the remaining bits in this field should be ignored. If a filter uses any of the
        /// other flags, it should set the AMCONTROL_USED flag.
        /// <para/>
        /// The two AMCONTROL_PAD_xxx flags are used by decoders to determine the aspect ratio of the output
        /// rectangle. The source filter sets the AMCONTROL_USED flag and one of the padding flags and calls 
        /// <c>QueryAccept</c> on the downstream pin. If the decoder rejects the type, the source filter should
        /// set the ControlFlags field to zero. For more information on the use of these flags, see MPEG
        /// Decoder Preprocessing Transformations. 
        /// <para/>
        /// If the AMCONTROL_COLORINFO_PRESENT flag is set, it means the upper 24 bits of the ControlFlags
        /// field are treated as a <strong>DXVA_ExtendedFormat</strong> structure. See Remarks for more
        /// information. 
        /// <para/>
        /// If this field contains any combination of flags that the filter does not support, the filter should
        /// reject the media type.
        /// </summary>
        public AMControl ControlFlags;
        /// <summary>
        /// Reserved for future use. Must be zero.
        /// </summary>
        public int Reserved2;
        /// <summary>
        /// <see cref="Misc.BitmapInfoHeader"/> structure that contains color and dimension information for the
        /// video image bitmap. 
        /// <para/>
        /// When used inside a <strong>VIDEOINFOHEADER2</strong> structure, the semantics of the 
        /// <see cref="Misc.BitmapInfoHeader"/> structure differ slightly from how the structure is used in
        /// GDI. For more information, refer to the topic <see cref="Misc.BitmapInfoHeader"/>. 
        /// </summary>
        public BitmapInfoHeader BmiHeader;  // Custom marshaler?
    }

#endif
}
