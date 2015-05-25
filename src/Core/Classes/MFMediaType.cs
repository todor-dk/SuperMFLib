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
using MediaFoundation.Misc.Classes;

namespace MediaFoundation
{

    /// <summary>
    /// In a media type, the major type describes the overall category of the data, such as audio or video. 
    /// The subtype, if present, further refines the major type. 
    /// <para/>
    /// This class contains the predefined values for the major types as well as most of the predefined
    /// values for the audio and video subtypes.
    /// </summary>
    public static class MFMediaType
    {
        public class MajorType : GuidEnum
        {
            public MajorType(Guid serviceGuid)
                : base(serviceGuid)
            {
            }

            public MajorType(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
                : this(new Guid(a, b, c, d, e, f, g, h, i, j, k))
            {
            }

            #region Major Media Types

            /// <summary> From MFMediaType_Default </summary>
            public static readonly MajorType Default = new MajorType(0x81A412E6, 0x8103, 0x4B06, 0x85, 0x7F, 0x18, 0x62, 0x78, 0x10, 0x24, 0xAC);
            /// <summary> Audio. From MFMediaType_Audio </summary>
            public static readonly MajorType Audio = new MajorType(0x73647561, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71);
            /// <summary> Video. From MFMediaType_Video </summary>
            public static readonly MajorType Video = new MajorType(0x73646976, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71);
            /// <summary> Protected media. From MFMediaType_Protected </summary>
            public static readonly MajorType Protected = new MajorType(0x7b4b6fe6, 0x9d04, 0x4494, 0xbe, 0x14, 0x7e, 0x0b, 0xd0, 0x76, 0xc8, 0xe4);
            /// <summary> Synchronized Accessible Media Interchange (SAMI) captions. From MFMediaType_SAMI </summary>
            public static readonly MajorType SAMI = new MajorType(0xe69669a0, 0x3dcd, 0x40cb, 0x9e, 0x2e, 0x37, 0x08, 0x38, 0x7c, 0x06, 0x16);
            /// <summary> Script stream. From MFMediaType_Script </summary>
            public static readonly MajorType Script = new MajorType(0x72178C22, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
            /// <summary> Still image stream. From MFMediaType_Image </summary>
            public static readonly MajorType Image = new MajorType(0x72178C23, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
            /// <summary> HTML stream. From MFMediaType_HTML </summary>
            public static readonly MajorType HTML = new MajorType(0x72178C24, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
            /// <summary> Binary stream. From MFMediaType_Binary </summary>
            public static readonly MajorType Binary = new MajorType(0x72178C25, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
            /// <summary> A stream that contains data files. From MFMediaType_FileTransfer </summary>
            public static readonly MajorType FileTransfer = new MajorType(0x72178C26, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
            /// <summary> Multiplexed stream or elementary stream. From MFMediaType_Stream </summary>
            public static readonly MajorType Stream = new MajorType(0xe436eb83, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

            #endregion

        }

        public class SubType : GuidEnum
        {
            public SubType(Guid serviceGuid)
                : base(serviceGuid)
            {
            }

            public SubType(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
                : this(new Guid(a, b, c, d, e, f, g, h, i, j, k))
            {
            }

            public static class Audio
            {

                /// <summary>
                /// In MF, media types for uncompressed video formats MUST be composed from a FourCC or D3DFORMAT combined with
                /// this "base GUID" {00000000-0000-0010-8000-00AA00389B71} by replacing the initial 32 bits with the FourCC/D3DFORMAT
                /// <para/>
                /// Audio media types for types which already have a defined wFormatTag value can be constructed similarly, by
                /// putting the wFormatTag (zero-extended to 32 bits) into the first 32 bits of the base GUID.
                /// <para/>
                /// Compressed video or audio can also use any well-known GUID that exists, or can create a new GUID.
                /// <para/>
                /// GUIDs for common media types are defined below.
                /// </summary>
                public static readonly SubType Base = new SubType(0x00000000, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Uncompressed PCM audio. Format Tag: WAVE_FORMAT.
                /// </summary>
                public static readonly SubType PCM = new SubType(0x00000001, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Uncompressed IEEE floating-point audio. Format Tag: WAVE_FORMAT.
                /// </summary>
                public static readonly SubType Float = new SubType(0x0003, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Digital Theater Systems (DTS) audio. Format Tag: WAVE_FORMAT_DTS  
                /// </summary>
                public static readonly SubType DTS = new SubType(0x0008, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Dolby AC-3 audio over Sony/Philips Digital Interface (S/PDIF). 
                /// This GUID value is identical to MEDIASUBTYPE_DOLBY_AC3_SPDIF.
                /// Format Tag: WAVE_FORMAT_DOLBY_AC3_SPDIF (0x0092).
                /// </summary>
                public static readonly SubType Dolby_AC3_SPDIF = new SubType(0x0092, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Encrypted audio data used with secure audio path. Format Tag: WAVE_FORMAT_DRM.
                /// </summary>
                public static readonly SubType DRM = new SubType(0x0009, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Windows Media Audio 8 codec, Windows Media Audio 9 codec, or Windows Media Audio 9.1 codec. Format Tag: WAVE_FORMAT.
                /// </summary>
                public static readonly SubType WMAudioV8 = new SubType(0x0161, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Windows Media Audio 9 Professional codec or Windows Media Audio 9.1 Professional codec. Format Tag: WAVE_FORMAT.
                /// </summary>
                public static readonly SubType WMAudioV9 = new SubType(0x0162, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Windows Media Audio 9 Lossless codec or Windows Media Audio 9.1 codec. Format Tag: WAVE_FORMAT_WMAUDIO_LOSSLESS (0x0163).
                /// </summary>
                public static readonly SubType WMAudio_Lossless = new SubType(0x0163, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Windows Media Audio 9 Professional codec over S/PDIF. Format Tag: WAVE_FORMAT.
                /// </summary>
                public static readonly SubType WMASPDIF = new SubType(0x0164, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Windows Media Audio 9 Voice codec. Format Tag: WAVE_FORMAT_WMAVOICE9 (0x000A).
                /// </summary>
                public static readonly SubType MSP1 = new SubType(0x000A, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// MPEG Audio Layer-3 (MP3). Format Tag: WAVE_FORMAT_MPEGLAYER3 (0x0055).
                /// </summary>
                public static readonly SubType MP3 = new SubType(0x0055, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// MPEG-1 audio payload. Format Tag: WAVE_FORMAT_MPEG.
                /// </summary>
                public static readonly SubType MPEG = new SubType(0x0050, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Advanced Audio Coding (AAC). Equivalent to MEDIASUBTYPE_MPEG_HEAAC. 
                /// The stream can contain raw AAC data or AAC data in an Audio Data Transport Stream (ADTS) stream.
                /// Format Tag: WAVE_FORMAT_MPEG_HEAAC (0x1610).
                /// </summary>
                public static readonly SubType AAC = new SubType(0x1610, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Not used. Format Tag: WAVE_FORMAT_MPEG_ADTS_AAC (0x1600).
                /// </summary>
                public static readonly SubType ADTS = new SubType(0x1600, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

                /// <summary>
                /// Dolby Digital (AC-3). Same GUID value as MEDIASUBTYPE_DOLBY_AC3. Format Tag: None.
                /// </summary>
                public static readonly SubType MFAudioFormat_Dolby_AC3 = new SubType(0xe06d802c, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x05f, 0x6c, 0xbb, 0xea);
                /// <summary>
                /// Dolby Digital Plus. Same GUID value as MEDIASUBTYPE_DOLBY_DDPLUS. Format Tag: None.
                /// </summary>
                public static readonly SubType MFAudioFormat_Dolby_DDPlus = new SubType(0xa7fb87af, 0x2d02, 0x42fb, 0xa4, 0xd4, 0x5, 0xcd, 0x93, 0x84, 0x3b, 0xdd);
                /// <summary>
                /// QCELP (Qualcomm Code Excited Linear Prediction) audio. Format Tag: None.
                /// </summary>
                [Obsolete]
                public static readonly SubType MFAudioFormat_QCELP = new SubType(0x5E7F6D41, 0xB115, 0x11D0, 0xBA, 0x91, 0x00, 0x80, 0x5F, 0xB4, 0xB9, 0x7E);

                /// <summary>
                /// Advanced Audio Coding (AAC). This subtype is used for AAC contained in an AVI file with an audio format tag equal to 0x00FF.
                /// Format Tag: WAVE_FORMAT.
                /// </summary>
                public static readonly SubType RAW_AAC1 = new SubType(0x000000FF, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

                /// <summary>
                /// Adaptative Multi-Rate audio.
                /// Format Tag: WAVE_FORMAT_AMR_NB.
                /// <para/>
                /// Supported in Windows 8.1 and later.
                /// </summary>
                public static readonly SubType AMR_NB = new SubType(0x7361, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

                /// <summary>
                /// Adaptative Multi-Rate Wideband audio.
                /// Format Tag: WAVE_FORMAT_AMR_WB.
                /// <para/>
                /// Supported in Windows 8.1 and later.
                /// </summary>
                public static readonly SubType AMR_WB = new SubType(0x7362, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

                /// <summary>
                /// Adaptative Multi-Rate Wideband Plus audio.
                /// Format Tag: WAVE_FORMAT_AMR_WP.
                /// <para/>
                /// Supported in Windows 8.1 and later.
                /// </summary>
                public static readonly SubType AMR_WP = new SubType(0x7363, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

            }

            public static class Video
            {
                // {00000000-767a-494d-b478-f29d25dc9037}       MFMPEG4Format_Base
                /// <summary>
                /// Value used for creating MPEG-4 types. See: 
                /// <a href="http://msdn.microsoft.com/en-us/library/dd757766%28v=vs.85%29.aspx">http://msdn.microsoft.com/en-us/library/dd757766%28v=vs.85%29.aspx</a>
                /// </summary>
                public static readonly SubType MFMPEG4Format = new SubType(0x00000000, 0x767a, 0x494d, 0xb4, 0x78, 0xf2, 0x9d, 0x25, 0xdc, 0x90, 0x37);

                #region Uncompressed RGB Formats

                /// <summary>
                /// Uncompressed RGB, 32 bpp.
                /// </summary>
                public static readonly SubType RGB32 = new SubType(22, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Uncompressed RGB, 32 bpp with alpha channel.
                /// </summary>
                public static readonly SubType ARGB32 = new SubType(21, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Uncompressed RGB, 24 bpp.
                /// </summary>
                public static readonly SubType RGB24 = new SubType(20, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Uncompressed RGB 555, 16 bpp. (Same memory layout as D3DFMT_X1R5G5B5.)
                /// </summary>
                public static readonly SubType RGB555 = new SubType(24, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Uncompressed RGB 565, 16 bpp. (Same memory layout as D3DFMT_R5G6B5.)
                /// </summary>
                public static readonly SubType RGB565 = new SubType(23, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
                /// <summary>
                /// Uncompressed RGB, 8 bits per pixel (bpp). (Same memory layout as D3DFMT_P8.)
                /// </summary>
                public static readonly SubType RGB8 = new SubType(41, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

                #endregion

                #region YUV Formats: 8-Bit and Palettized

                /// <summary>
                /// YUV Format: AI44, Sampling: 4:4:4, Packed, Palettized 
                /// </summary>
                public static readonly SubType AI44 = new SubType(new FourCC("AI44").ToMediaSubtype());
                /// <summary>
                /// YUV Format: AYUV, Sampling: 4:4:4, Packed, 8 bits per channel 
                /// </summary>
                public static readonly SubType AYUV = new SubType(new FourCC("AYUV").ToMediaSubtype());
                /// <summary>
                /// YUV Format: YUY2, Sampling: 4:2:2, Packed, 8 bits per channel 
                /// </summary>
                public static readonly SubType YUY2 = new SubType(new FourCC("YUY2").ToMediaSubtype());
                /// <summary>
                /// YUV Format: UYVY, Sampling: 4:2:2, Packed, 8 bits per channel 
                /// </summary>
                public static readonly SubType UYVY = new SubType(new FourCC("UYVY").ToMediaSubtype());
                /// <summary>
                /// YUV Format: NV11, Sampling: 4:1:1, Planar, 8 bits per channel 
                /// </summary>
                public static readonly SubType NV11 = new SubType(new FourCC("NV11").ToMediaSubtype());
                /// <summary>
                /// YUV Format: NV12, Sampling: 4:2:0, Planar, 8 bits per channel 
                /// </summary>
                public static readonly SubType NV12 = new SubType(new FourCC("NV12").ToMediaSubtype());
                /// <summary>
                /// YUV Format: YV12, Sampling: 4:2:0, Planar, 8 bits per channel 
                /// </summary>
                public static readonly SubType YV12 = new SubType(new FourCC("YV12").ToMediaSubtype());
                /// <summary>
                /// YUV Format: I420, Sampling: 4:2:0, Planar, 8 bits per channel 
                /// </summary>
                public static readonly SubType I420 = new SubType(new FourCC("I420").ToMediaSubtype());
                /// <summary>
                /// YUV Format: IYUV, Sampling: 4:2:0, Planar, 8 bits per channel 
                /// </summary>
                public static readonly SubType IYUV = new SubType(new FourCC("IYUV").ToMediaSubtype());
                /// <summary>
                /// YUV Format: Y41P, Sampling: 4:1:1, Packed, 8 bits per channel 
                /// </summary>
                public static readonly SubType Y41P = new SubType(new FourCC("Y41P").ToMediaSubtype());
                /// <summary>
                /// YUV Format: Y41T, Sampling: 4:1:1, Packed, 8 bits per channel 
                /// </summary>
                public static readonly SubType Y41T = new SubType(new FourCC("Y41T").ToMediaSubtype());
                /// <summary>
                /// YUV Format: Y42T, Sampling: 4:2:2, Packed, 8 bits per channel 
                /// </summary>
                public static readonly SubType Y42T = new SubType(new FourCC("Y42T").ToMediaSubtype());

                #endregion

                #region YUV Formats: 10-Bit and 16-Bit

                /// <summary>
                /// YUV Format: Y210, Sampling: 4:2:2, Packed, 10 bits per channel.
                /// </summary>
                public static readonly SubType Y210 = new SubType(new FourCC("Y210").ToMediaSubtype());
                /// <summary>
                /// YUV Format: Y216, Sampling: 4:2:2, Packed, 16 bits per channel.
                /// </summary>
                public static readonly SubType Y216 = new SubType(new FourCC("Y216").ToMediaSubtype());
                /// <summary>
                /// YUV Format: Y40, Sampling: 4:4:4, Packed, 10 bits per channel.
                /// </summary>
                public static readonly SubType Y410 = new SubType(new FourCC("Y410").ToMediaSubtype());
                /// <summary>
                /// YUV Format: Y416, Sampling: 4:4:4, Packed, 16 bits per channel.
                /// </summary>
                public static readonly SubType Y416 = new SubType(new FourCC("Y416").ToMediaSubtype());
                /// <summary>
                /// YUV Format: P210, Sampling: 4:2:2, Planar, 10 bits per channel.
                /// </summary>
                public static readonly SubType P210 = new SubType(new FourCC("P210").ToMediaSubtype());
                /// <summary>
                /// YUV Format: P216, Sampling: 4:2:2, Planar, 16 bits per channel.
                /// </summary>
                public static readonly SubType P216 = new SubType(new FourCC("P216").ToMediaSubtype());
                /// <summary>
                /// YUV Format: P010, Sampling: 4:2:0, Planar, 10 bits per channel.
                /// </summary>
                public static readonly SubType P010 = new SubType(new FourCC("P010").ToMediaSubtype());
                /// <summary>
                /// YUV Format: P016, Sampling: 4:2:0, Planar, 16 bits per channel.
                /// </summary>
                public static readonly SubType P016 = new SubType(new FourCC("P016").ToMediaSubtype());
                /// <summary>
                /// YUV Format: v210, Sampling: 4:2:2, Packed, 10 bits per channel.
                /// </summary>
                public static readonly SubType v210 = new SubType(new FourCC("v210").ToMediaSubtype());
                /// <summary>
                /// YUV Format: v216, Sampling: 4:2:2, Packed, 16 bits per channel.
                /// </summary>
                public static readonly SubType v216 = new SubType(new FourCC("v216").ToMediaSubtype());
                /// <summary>
                /// YUV Format: v40, Sampling: 4:4:4, Packed, 10 bits per channel.
                /// </summary>
                public static readonly SubType v410 = new SubType(new FourCC("v410").ToMediaSubtype());

                #endregion

                /// <summary>
                /// YUV video stored in packed 4:2:2 format. Similar to <see cref="YUY2"/> but with different ordering of data.
                /// </summary>
                public static readonly SubType YVYU = new SubType(new FourCC("YVYU").ToMediaSubtype());
                /// <summary>
                /// YUV video stored in planar 16:1:1 format.
                /// </summary>
                public static readonly SubType YVU9 = new SubType(new FourCC("YVU9").ToMediaSubtype());

                #region Encoded Video Types

                /// <summary>
                /// Microsoft MPEG 4 codec version 3. This codec is no longer supported.
                /// </summary>
                public static readonly SubType MP43 = new SubType(new FourCC("MP43").ToMediaSubtype());
                /// <summary>
                /// ISO MPEG 4 codec version 1.
                /// </summary>
                public static readonly SubType MP4S = new SubType(new FourCC("MP4S").ToMediaSubtype());
                /// <summary>
                /// MPEG-4 part 2 video.
                /// </summary>
                public static readonly SubType M4S2 = new SubType(new FourCC("M4S2").ToMediaSubtype());
                /// <summary>
                /// MPEG-4 part 2 video.
                /// </summary>
                public static readonly SubType MP4V = new SubType(new FourCC("MP4V").ToMediaSubtype());
                /// <summary>
                /// Windows Media Video codec version 7.
                /// </summary>
                public static readonly SubType WMV1 = new SubType(new FourCC("WMV1").ToMediaSubtype());
                /// <summary>
                /// Windows Media Video 8 codec.
                /// </summary>
                public static readonly SubType WMV2 = new SubType(new FourCC("WMV2").ToMediaSubtype());
                /// <summary>
                /// Windows Media Video 9 codec.
                /// </summary>
                public static readonly SubType WMV3 = new SubType(new FourCC("WMV3").ToMediaSubtype());
                /// <summary>
                /// SMPTE 421M ("VC-1").
                /// </summary>
                public static readonly SubType WVC1 = new SubType(new FourCC("WVC1").ToMediaSubtype());
                /// <summary>
                /// Windows Media Screen codec version 1.
                /// </summary>
                public static readonly SubType MSS1 = new SubType(new FourCC("MSS1").ToMediaSubtype());
                /// <summary>
                /// Windows Media Video 9 Screen codec.
                /// </summary>
                public static readonly SubType MSS2 = new SubType(new FourCC("MSS2").ToMediaSubtype());
                /// <summary>
                /// MPEG-1 video.
                /// </summary>
                public static readonly SubType MPG1 = new SubType(new FourCC("MPG1").ToMediaSubtype());
                /// <summary>
                /// SD-DVCR (525-60 or 625-50).
                /// </summary>
                public static readonly SubType DVSL = new SubType(new FourCC("dvsl").ToMediaSubtype());
                /// <summary>
                /// SDL-DVCR (525-60 or 625-50).
                /// </summary>
                public static readonly SubType DVSD = new SubType(new FourCC("dvsd").ToMediaSubtype());
                /// <summary>
                /// HD-DVCR (1125-60 or 1250-50).
                /// </summary>
                public static readonly SubType DVHD = new SubType(new FourCC("dvhd").ToMediaSubtype());
                /// <summary>
                /// DVCPRO 25 (525-60 or 625-50).
                /// </summary>
                public static readonly SubType DV25 = new SubType(new FourCC("dv25").ToMediaSubtype());
                /// <summary>
                /// DVCPRO 50 (525-60 or 625-50).
                /// </summary>
                public static readonly SubType DV50 = new SubType(new FourCC("dv50").ToMediaSubtype());
                /// <summary>
                /// DVCPRO 100 (1080/60i, 1080/50i, or 720/60P).
                /// </summary>
                public static readonly SubType DVH1 = new SubType(new FourCC("dvh1").ToMediaSubtype());
                /// <summary>
                /// DVC/DV Video.
                /// </summary>
                public static readonly SubType DVC = new SubType(new FourCC("dvc ").ToMediaSubtype());
                /// <summary>
                /// H.263 video.
                /// </summary>
                public static readonly SubType H263 = new SubType(new FourCC("H263").ToMediaSubtype());
                /// <summary>
                /// H.264 video. 
                /// Media samples contain H.264 bitstream data with start codes and has interleaved SPS/PPS. 
                /// Each sample contains one complete picture, either one field or one frame.
                /// </summary>
                public static readonly SubType H264 = new SubType(new FourCC("H264").ToMediaSubtype());
                /// <summary>
                /// Motion JPEG.
                /// </summary>
                public static readonly SubType MJPG = new SubType(new FourCC("MJPG").ToMediaSubtype());
                /// <summary>
                /// 8-bit per channel planar YUV 4:2:0 video. 
                /// </summary>
                public static readonly SubType O420 = new SubType(new FourCC("420O").ToMediaSubtype());

                /// <summary>
                /// The HEVC Main profile and Main Still Picture profile.
                /// <para/>
                /// Each sample contains one complete picture.
                /// <para/>
                /// Supported in Windows 8.1 and later. The HEVC Main profile and Main Still Picture profile elementary stream.  
                /// </summary>
                public static readonly SubType HEVC = new SubType(new FourCC("HEVC").ToMediaSubtype());
                /// <summary>
                /// This media type is the same as <see cref="HEVC"/>, except media samples contain 
                /// a fragmented HEVC bitstream. Each sample may contain a partial picture; 
                /// multiple complete pictures; or one or more complete pictures plus a partial picture.
                /// <para/>
                /// Supported in Windows 8.1 and later.
                /// </summary>
                public static readonly SubType HEVC_ES = new SubType(new FourCC("HEVS").ToMediaSubtype());

                /// <summary>
                /// MPEG-2 video. (Equivalent to MEDIASUBTYPE_MPEG2_VIDEO in DirectShow.)
                /// </summary>
                public static readonly SubType MPEG2 = new SubType(0xe06d8026, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea);
                /// <summary>
                /// H.264 elementary stream. 
                /// This media type is the same as MFVideoFormat_H264, 
                /// except media samples contain a fragmented H.264 bitstream. 
                /// Each sample may contain a partial picture; multiple complete pictures; 
                /// or one or more complete pictures plus a partial picture.
                /// </summary>
                public static readonly SubType MFVideoFormat_H264_ES = new SubType(0x3f40f4f0, 0x5622, 0x4ff8, 0xb6, 0xd8, 0xa1, 0x7a, 0x58, 0x4b, 0xee, 0x5e);

                #endregion



                /// <summary>
                /// Specifies whether a video stream contains 3D content. Data Type: BOOL stored as UINT32.
                /// </summary>
                /// <remarks>
                /// This attribute applies to video media types. 
                /// If this attribute is TRUE, the video stream contains 3D content. The default value is FALSE.
                /// </remarks>
                // NB: This IS NOT a media type, but for reason has gotten into this class. Can't kick it out ... too late.
                public static readonly SubType MF_MT_VIDEO_3D = new SubType(0xcb5e88cf, 0x7b5b, 0x476b, 0x85, 0xaa, 0x1c, 0xa5, 0xae, 0x18, 0x75, 0x55);
            }
        }
    }
}