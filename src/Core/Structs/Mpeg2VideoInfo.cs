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

namespace MediaFoundation.Core.Structs
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// The <strong>MPEG2VIDEOINFO</strong> structure describes an MPEG-2 video stream.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct tagMPEG2VIDEOINFO {
    ///   VIDEOINFOHEADER2 hdr;
    ///   DWORD            dwStartTimeCode;
    ///   DWORD            cbSequenceHeader;
    ///   DWORD            dwProfile;
    ///   DWORD            dwLevel;
    ///   DWORD            dwFlags;
    ///   DWORD            dwSequenceHeader[1];
    /// } MPEG2VIDEOINFO;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1A6AB686-99A1-40C2-ADDF-7FA215E2311A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1A6AB686-99A1-40C2-ADDF-7FA215E2311A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MPEG2VIDEOINFO")]
    internal struct Mpeg2VideoInfo
    {
        /// <summary>
        /// <see cref="Misc.VideoInfoHeader2" /> structure.
        /// </summary>
        VideoInfoHeader2 hdr;
        /// <summary>
        /// 25-bit group-of-pictures (GOP) time code at start of data. This field is not used for DVD.
        /// </summary>
        int dwStartTimeCode;        //  ?? not used for DVD ??
        /// <summary>
        /// Length of the sequence header, in bytes. For DVD, set this field to zero. The sequence header is
        /// given in the <strong>dwSequenceHeader</strong> field.
        /// </summary>
        int cbSequenceHeader;       // is 0 for DVD (no sequence header)
        /// <summary>
        /// Specifies the MPEG-2 profile as an <c>AM_MPEG2Profile</c> enumeration type.
        /// </summary>
        int dwProfile;              // use enum MPEG2Profile
        /// <summary>
        /// Specifies the MPEG-2 level as an <c>AM_MPEG2Level</c> enumeration type.
        /// </summary>
        int dwLevel;                // use enum MPEG2Level
        /// <summary>
        /// Flag indicating preferences. Set one or a combination of the following values.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term><strong>AMMPEG2_DoPanScan</strong> 0x00000001</term><description>If this flag is set, the MPEG-2 video decoder should crop the output image based on pan-scan vectors in picture_display_extension and change the picture aspect ratio to 4x3. The VMR should not receive a 16x9 sample with this flag. A simple implementation might alter the source rectangle to indicate a 540 wide source region with a left edge equal to the display offset in the picture_display_extension.</description></item><item><term><strong>AMMPEG2_DVDLine21Field1</strong> 0x00000002</term><description>If set, the MPEG-2 decoder must be able to produce an output pin for DVD style closed-captioned data found in the Group Of Pictures (GOP) layer of field 1. </description></item><item><term><strong>AMMPEG2_DVDLine21Field2</strong> 0x00000004</term><description>If set, the MPEG-2 decoder must be able to produce an output pin for DVD style closed-captioned data found in the GOP layer of field 2.</description></item><item><term><strong>AMMPEG2_SourceIsLetterboxed</strong> 0x00000008</term><description>If set, indicates that black bars have been encoded in the top and bottom of the video. </description></item><item><term><strong>AMMPEG2_FilmCameraMode</strong> 0x00000010</term><description>If set, indicates "film mode" used for the 625/50 (line/field) content. If cleared, indicates that "camera mode" was used.</description></item><item><term><strong>AMMPEG2_LetterboxAnalogOut</strong> 0x00000020</term><description>If set and this stream is sent to an analog output, it should be letterboxed. Streams sent to VGA should be letterboxed only by renderers.</description></item><item><term><strong>AMMPEG2_DSS_UserData</strong> 0x00000040</term><description>If set, the MPEG-2 decoder must process DSS style user data. </description></item><item><term><strong>AMMPEG2_DVB_UserData</strong> 0x00000080</term><description>If set, the MPEG-2 decoder must process DVB style user data. </description></item><item><term><strong>AMMPEG2_27MhzTimebase</strong> 0x00000100</term><description>If set, the PTS, DTS timestamps advance at 27MHz rather than 90KHz. </description></item><item><term><strong>AMMPEG2_WidescreenAnalogOut</strong> 0x00000200</term><description>If set and this stream is sent to an analog output, it should be in widescreen format (4x3 content should be centered on a 16x9 output). Streams sent to VGA should be widescreened only by renderers. </description></item></list><para />
        /// Set undefined flags to zero or connection will be rejected. For more information on how to use
        /// these flags, see <c>MPEG Decoder Preprocessing Transformations</c>.
        /// </summary>
        int dwFlags;                // use AMMPEG2_* defines.  Reject connection if undefined bits are not 0
        /// <summary>
        /// Start of an array that contains the sequence header, including quantization matrices and the
        /// sequence extension, if required. This field is typed as <strong>DWORD</strong> array to enforce
        /// 32-bit alignment. The size of the array, in bytes, is given in the <strong>cbSequenceHeader
        /// </strong> member.
        /// </summary>
        int[] dwSequenceHeader;     // DWORD instead of Byte for alignment purposes
        //   For MPEG-2, if a sequence_header is included, the sequence_extension
        //   should also be included
    }

#endif

}
