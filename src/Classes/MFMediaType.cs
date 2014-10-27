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
    /// In a media type, the major type describes the overall category of the data, such as audio or video. 
    /// The subtype, if present, further refines the major type. 
    /// <para/>
    /// This class contains the predefined values for the major types as well as most of the predefined
    /// values for the audio and video subtypes.
    /// </summary>
    public static class MFMediaType
    {
        #region Major Media Types

        /// <summary> From MFMediaType_Default </summary>
        public static readonly Guid Default = new Guid(0x81A412E6, 0x8103, 0x4B06, 0x85, 0x7F, 0x18, 0x62, 0x78, 0x10, 0x24, 0xAC);
        /// <summary> Audio. From MFMediaType_Audio </summary>
        public static readonly Guid Audio = new Guid(0x73647561, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71);
        /// <summary> Video. From MFMediaType_Video </summary>
        public static readonly Guid Video = new Guid(0x73646976, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71);
        /// <summary> Protected media. From MFMediaType_Protected </summary>
        public static readonly Guid Protected = new Guid(0x7b4b6fe6, 0x9d04, 0x4494, 0xbe, 0x14, 0x7e, 0x0b, 0xd0, 0x76, 0xc8, 0xe4);
        /// <summary> Synchronized Accessible Media Interchange (SAMI) captions. From MFMediaType_SAMI </summary>
        public static readonly Guid SAMI = new Guid(0xe69669a0, 0x3dcd, 0x40cb, 0x9e, 0x2e, 0x37, 0x08, 0x38, 0x7c, 0x06, 0x16);
        /// <summary> Script stream. From MFMediaType_Script </summary>
        public static readonly Guid Script = new Guid(0x72178C22, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
        /// <summary> Still image stream. From MFMediaType_Image </summary>
        public static readonly Guid Image = new Guid(0x72178C23, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
        /// <summary> HTML stream. From MFMediaType_HTML </summary>
        public static readonly Guid HTML = new Guid(0x72178C24, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
        /// <summary> Binary stream. From MFMediaType_Binary </summary>
        public static readonly Guid Binary = new Guid(0x72178C25, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
        /// <summary> A stream that contains data files. From MFMediaType_FileTransfer </summary>
        public static readonly Guid FileTransfer = new Guid(0x72178C26, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
        /// <summary> Multiplexed stream or elementary stream. From MFMediaType_Stream </summary>
        public static readonly Guid Stream = new Guid(0xe436eb83, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        #endregion

        #region Audio Subtypes

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
        public static readonly Guid Base = new Guid(0x00000000, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Uncompressed PCM audio. Format Tag: WAVE_FORMAT.
        /// </summary>
        public static readonly Guid PCM = new Guid(0x00000001, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Uncompressed IEEE floating-point audio. Format Tag: WAVE_FORMAT.
        /// </summary>
        public static readonly Guid Float = new Guid(0x0003, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Digital Theater Systems (DTS) audio. Format Tag: WAVE_FORMAT_DTS  
        /// </summary>
        public static readonly Guid DTS = new Guid(0x0008, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Dolby AC-3 audio over Sony/Philips Digital Interface (S/PDIF). 
        /// This GUID value is identical to MEDIASUBTYPE_DOLBY_AC3_SPDIF.
        /// Format Tag: WAVE_FORMAT_DOLBY_AC3_SPDIF (0x0092).
        /// </summary>
        public static readonly Guid Dolby_AC3_SPDIF = new Guid(0x0092, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Encrypted audio data used with secure audio path. Format Tag: WAVE_FORMAT_DRM.
        /// </summary>
        public static readonly Guid DRM = new Guid(0x0009, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Windows Media Audio 8 codec, Windows Media Audio 9 codec, or Windows Media Audio 9.1 codec. Format Tag: WAVE_FORMAT.
        /// </summary>
        public static readonly Guid WMAudioV8 = new Guid(0x0161, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Windows Media Audio 9 Professional codec or Windows Media Audio 9.1 Professional codec. Format Tag: WAVE_FORMAT.
        /// </summary>
        public static readonly Guid WMAudioV9 = new Guid(0x0162, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Windows Media Audio 9 Lossless codec or Windows Media Audio 9.1 codec. Format Tag: WAVE_FORMAT_WMAUDIO_LOSSLESS (0x0163).
        /// </summary>
        public static readonly Guid WMAudio_Lossless = new Guid(0x0163, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Windows Media Audio 9 Professional codec over S/PDIF. Format Tag: WAVE_FORMAT.
        /// </summary>
        public static readonly Guid WMASPDIF = new Guid(0x0164, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Windows Media Audio 9 Voice codec. Format Tag: WAVE_FORMAT_WMAVOICE9 (0x000A).
        /// </summary>
        public static readonly Guid MSP1 = new Guid(0x000A, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// MPEG Audio Layer-3 (MP3). Format Tag: WAVE_FORMAT_MPEGLAYER3 (0x0055).
        /// </summary>
        public static readonly Guid MP3 = new Guid(0x0055, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// MPEG-1 audio payload. Format Tag: WAVE_FORMAT_MPEG.
        /// </summary>
        public static readonly Guid MPEG = new Guid(0x0050, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Advanced Audio Coding (AAC). Equivalent to MEDIASUBTYPE_MPEG_HEAAC. 
        /// The stream can contain raw AAC data or AAC data in an Audio Data Transport Stream (ADTS) stream.
        /// Format Tag: WAVE_FORMAT_MPEG_HEAAC (0x1610).
        /// </summary>
        public static readonly Guid AAC = new Guid(0x1610, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Not used. Format Tag: WAVE_FORMAT_MPEG_ADTS_AAC (0x1600).
        /// </summary>
        public static readonly Guid ADTS = new Guid(0x1600, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        /// <summary>
        /// Dolby Digital (AC-3). Same GUID value as MEDIASUBTYPE_DOLBY_AC3. Format Tag: None.
        /// </summary>
        public static readonly Guid MFAudioFormat_Dolby_AC3 = new Guid(0xe06d802c, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x05f, 0x6c, 0xbb, 0xea);
        /// <summary>
        /// Dolby Digital Plus. Same GUID value as MEDIASUBTYPE_DOLBY_DDPLUS. Format Tag: None.
        /// </summary>
        public static readonly Guid MFAudioFormat_Dolby_DDPlus = new Guid(0xa7fb87af, 0x2d02, 0x42fb, 0xa4, 0xd4, 0x5, 0xcd, 0x93, 0x84, 0x3b, 0xdd);
        /// <summary>
        /// QCELP (Qualcomm Code Excited Linear Prediction) audio. Format Tag: None.
        /// </summary>
        [Obsolete]
        public static readonly Guid MFAudioFormat_QCELP = new Guid(0x5E7F6D41, 0xB115, 0x11D0, 0xBA, 0x91, 0x00, 0x80, 0x5F, 0xB4, 0xB9, 0x7E);

        /// <summary>
        /// Advanced Audio Coding (AAC). This subtype is used for AAC contained in an AVI file with an audio format tag equal to 0x00FF.
        /// Format Tag: WAVE_FORMAT.
        /// </summary>
        public static readonly Guid RAW_AAC1 = new Guid(0x000000FF, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        public static readonly Guid AMR_NB = new Guid(0x7361, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid AMR_WB = new Guid(0x7362, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid AMR_WP = new Guid(0x7363, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        #endregion

        #region Video Subtypes


        // {00000000-767a-494d-b478-f29d25dc9037}       MFMPEG4Format_Base
        /// <summary>
        /// Value used for creating MPEG-4 types. See: 
        /// <a href="http://msdn.microsoft.com/en-us/library/dd757766%28v=vs.85%29.aspx">http://msdn.microsoft.com/en-us/library/dd757766%28v=vs.85%29.aspx</a>
        /// </summary>
        public static readonly Guid MFMPEG4Format = new Guid(0x00000000, 0x767a, 0x494d, 0xb4, 0x78, 0xf2, 0x9d, 0x25, 0xdc, 0x90, 0x37);

        #region Uncompressed RGB Formats

        /// <summary>
        /// Uncompressed RGB, 32 bpp.
        /// </summary>
        public static readonly Guid RGB32 = new Guid(22, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Uncompressed RGB, 32 bpp with alpha channel.
        /// </summary>
        public static readonly Guid ARGB32 = new Guid(21, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Uncompressed RGB, 24 bpp.
        /// </summary>
        public static readonly Guid RGB24 = new Guid(20, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Uncompressed RGB 555, 16 bpp. (Same memory layout as D3DFMT_X1R5G5B5.)
        /// </summary>
        public static readonly Guid RGB555 = new Guid(24, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Uncompressed RGB 565, 16 bpp. (Same memory layout as D3DFMT_R5G6B5.)
        /// </summary>
        public static readonly Guid RGB565 = new Guid(23, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        /// <summary>
        /// Uncompressed RGB, 8 bits per pixel (bpp). (Same memory layout as D3DFMT_P8.)
        /// </summary>
        public static readonly Guid RGB8 = new Guid(41, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        #endregion

        #region YUV Formats: 8-Bit and Palettized

        /// <summary>
        /// YUV Format: AI44, Sampling: 4:4:4, Packed, Palettized 
        /// </summary>
        public static readonly Guid AI44 = new FourCC("AI44").ToMediaSubtype();
        /// <summary>
        /// YUV Format: AYUV, Sampling: 4:4:4, Packed, 8 bits per channel 
        /// </summary>
        public static readonly Guid AYUV = new FourCC("AYUV").ToMediaSubtype();
        /// <summary>
        /// YUV Format: YUY2, Sampling: 4:2:2, Packed, 8 bits per channel 
        /// </summary>
        public static readonly Guid YUY2 = new FourCC("YUY2").ToMediaSubtype();
        /// <summary>
        /// YUV Format: UYVY, Sampling: 4:2:2, Packed, 8 bits per channel 
        /// </summary>
        public static readonly Guid UYVY = new FourCC("UYVY").ToMediaSubtype();
        /// <summary>
        /// YUV Format: NV11, Sampling: 4:1:1, Planar, 8 bits per channel 
        /// </summary>
        public static readonly Guid NV11 = new FourCC("NV11").ToMediaSubtype();
        /// <summary>
        /// YUV Format: NV12, Sampling: 4:2:0, Planar, 8 bits per channel 
        /// </summary>
        public static readonly Guid NV12 = new FourCC("NV12").ToMediaSubtype();
        /// <summary>
        /// YUV Format: YV12, Sampling: 4:2:0, Planar, 8 bits per channel 
        /// </summary>
        public static readonly Guid YV12 = new FourCC("YV12").ToMediaSubtype();
        /// <summary>
        /// YUV Format: I420, Sampling: 4:2:0, Planar, 8 bits per channel 
        /// </summary>
        public static readonly Guid I420 = new FourCC("I420").ToMediaSubtype();
        /// <summary>
        /// YUV Format: IYUV, Sampling: 4:2:0, Planar, 8 bits per channel 
        /// </summary>
        public static readonly Guid IYUV = new FourCC("IYUV").ToMediaSubtype();
        /// <summary>
        /// YUV Format: Y41P, Sampling: 4:1:1, Packed, 8 bits per channel 
        /// </summary>
        public static readonly Guid Y41P = new FourCC("Y41P").ToMediaSubtype();
        /// <summary>
        /// YUV Format: Y41T, Sampling: 4:1:1, Packed, 8 bits per channel 
        /// </summary>
        public static readonly Guid Y41T = new FourCC("Y41T").ToMediaSubtype();
        /// <summary>
        /// YUV Format: Y42T, Sampling: 4:2:2, Packed, 8 bits per channel 
        /// </summary>
        public static readonly Guid Y42T = new FourCC("Y42T").ToMediaSubtype();

        #endregion

        #region YUV Formats: 10-Bit and 16-Bit

        /// <summary>
        /// YUV Format: Y210, Sampling: 4:2:2, Packed, 10 bits per channel.
        /// </summary>
        public static readonly Guid Y210 = new FourCC("Y210").ToMediaSubtype();
        /// <summary>
        /// YUV Format: Y216, Sampling: 4:2:2, Packed, 16 bits per channel.
        /// </summary>
        public static readonly Guid Y216 = new FourCC("Y216").ToMediaSubtype();
        /// <summary>
        /// YUV Format: Y40, Sampling: 4:4:4, Packed, 10 bits per channel.
        /// </summary>
        public static readonly Guid Y410 = new FourCC("Y410").ToMediaSubtype();
        /// <summary>
        /// YUV Format: Y416, Sampling: 4:4:4, Packed, 16 bits per channel.
        /// </summary>
        public static readonly Guid Y416 = new FourCC("Y416").ToMediaSubtype();
        /// <summary>
        /// YUV Format: P210, Sampling: 4:2:2, Planar, 10 bits per channel.
        /// </summary>
        public static readonly Guid P210 = new FourCC("P210").ToMediaSubtype();
        /// <summary>
        /// YUV Format: P216, Sampling: 4:2:2, Planar, 16 bits per channel.
        /// </summary>
        public static readonly Guid P216 = new FourCC("P216").ToMediaSubtype();
        /// <summary>
        /// YUV Format: P010, Sampling: 4:2:0, Planar, 10 bits per channel.
        /// </summary>
        public static readonly Guid P010 = new FourCC("P010").ToMediaSubtype();
        /// <summary>
        /// YUV Format: P016, Sampling: 4:2:0, Planar, 16 bits per channel.
        /// </summary>
        public static readonly Guid P016 = new FourCC("P016").ToMediaSubtype();
        /// <summary>
        /// YUV Format: v210, Sampling: 4:2:2, Packed, 10 bits per channel.
        /// </summary>
        public static readonly Guid v210 = new FourCC("v210").ToMediaSubtype();
        /// <summary>
        /// YUV Format: v216, Sampling: 4:2:2, Packed, 16 bits per channel.
        /// </summary>
        public static readonly Guid v216 = new FourCC("v216").ToMediaSubtype();
        /// <summary>
        /// YUV Format: v40, Sampling: 4:4:4, Packed, 10 bits per channel.
        /// </summary>
        public static readonly Guid v410 = new FourCC("v410").ToMediaSubtype();

        #endregion

        /// <summary>
        /// YUV video stored in packed 4:2:2 format. Similar to <see cref="YUY2"/> but with different ordering of data.
        /// </summary>
        public static readonly Guid YVYU = new FourCC("YVYU").ToMediaSubtype();
        /// <summary>
        /// YUV video stored in planar 16:1:1 format.
        /// </summary>
        public static readonly Guid YVU9 = new FourCC("YVU9").ToMediaSubtype();

        #region Encoded Video Types

        /// <summary>
        /// Microsoft MPEG 4 codec version 3. This codec is no longer supported.
        /// </summary>
        public static readonly Guid MP43 = new FourCC("MP43").ToMediaSubtype();
        /// <summary>
        /// ISO MPEG 4 codec version 1.
        /// </summary>
        public static readonly Guid MP4S = new FourCC("MP4S").ToMediaSubtype();
        /// <summary>
        /// MPEG-4 part 2 video.
        /// </summary>
        public static readonly Guid M4S2 = new FourCC("M4S2").ToMediaSubtype();
        /// <summary>
        /// MPEG-4 part 2 video.
        /// </summary>
        public static readonly Guid MP4V = new FourCC("MP4V").ToMediaSubtype();
        /// <summary>
        /// Windows Media Video codec version 7.
        /// </summary>
        public static readonly Guid WMV1 = new FourCC("WMV1").ToMediaSubtype();
        /// <summary>
        /// Windows Media Video 8 codec.
        /// </summary>
        public static readonly Guid WMV2 = new FourCC("WMV2").ToMediaSubtype();
        /// <summary>
        /// Windows Media Video 9 codec.
        /// </summary>
        public static readonly Guid WMV3 = new FourCC("WMV3").ToMediaSubtype();
        /// <summary>
        /// SMPTE 421M ("VC-1").
        /// </summary>
        public static readonly Guid WVC1 = new FourCC("WVC1").ToMediaSubtype();
        /// <summary>
        /// Windows Media Screen codec version 1.
        /// </summary>
        public static readonly Guid MSS1 = new FourCC("MSS1").ToMediaSubtype();
        /// <summary>
        /// Windows Media Video 9 Screen codec.
        /// </summary>
        public static readonly Guid MSS2 = new FourCC("MSS2").ToMediaSubtype();
        /// <summary>
        /// MPEG-1 video.
        /// </summary>
        public static readonly Guid MPG1 = new FourCC("MPG1").ToMediaSubtype();
        /// <summary>
        /// SD-DVCR (525-60 or 625-50).
        /// </summary>
        public static readonly Guid DVSL = new FourCC("dvsl").ToMediaSubtype();
        /// <summary>
        /// SDL-DVCR (525-60 or 625-50).
        /// </summary>
        public static readonly Guid DVSD = new FourCC("dvsd").ToMediaSubtype();
        /// <summary>
        /// HD-DVCR (1125-60 or 1250-50).
        /// </summary>
        public static readonly Guid DVHD = new FourCC("dvhd").ToMediaSubtype();
        /// <summary>
        /// DVCPRO 25 (525-60 or 625-50).
        /// </summary>
        public static readonly Guid DV25 = new FourCC("dv25").ToMediaSubtype();
        /// <summary>
        /// DVCPRO 50 (525-60 or 625-50).
        /// </summary>
        public static readonly Guid DV50 = new FourCC("dv50").ToMediaSubtype();
        /// <summary>
        /// DVCPRO 100 (1080/60i, 1080/50i, or 720/60P).
        /// </summary>
        public static readonly Guid DVH1 = new FourCC("dvh1").ToMediaSubtype();
        /// <summary>
        /// DVC/DV Video.
        /// </summary>
        public static readonly Guid DVC = new FourCC("dvc ").ToMediaSubtype();
        /// <summary>
        /// H.263 video.
        /// </summary>
        public static readonly Guid H263 = new FourCC("H263").ToMediaSubtype();
        /// <summary>
        /// H.264 video. 
        /// Media samples contain H.264 bitstream data with start codes and has interleaved SPS/PPS. 
        /// Each sample contains one complete picture, either one field or one frame.
        /// </summary>
        public static readonly Guid H264 = new FourCC("H264").ToMediaSubtype();
        /// <summary>
        /// Motion JPEG.
        /// </summary>
        public static readonly Guid MJPG = new FourCC("MJPG").ToMediaSubtype();
        /// <summary>
        /// 8-bit per channel planar YUV 4:2:0 video. 
        /// </summary>
        public static readonly Guid O420 = new FourCC("420O").ToMediaSubtype();

        public static readonly Guid HEVC = new FourCC("HEVC").ToMediaSubtype();
        public static readonly Guid HEVC_ES = new FourCC("HEVS").ToMediaSubtype();

        /// <summary>
        /// MPEG-2 video. (Equivalent to MEDIASUBTYPE_MPEG2_VIDEO in DirectShow.)
        /// </summary>
        public static readonly Guid MPEG2 = new Guid(0xe06d8026, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea);
        /// <summary>
        /// H.264 elementary stream. 
        /// This media type is the same as MFVideoFormat_H264, 
        /// except media samples contain a fragmented H.264 bitstream. 
        /// Each sample may contain a partial picture; multiple complete pictures; 
        /// or one or more complete pictures plus a partial picture.
        /// </summary>
        public static readonly Guid MFVideoFormat_H264_ES = new Guid(0x3f40f4f0, 0x5622, 0x4ff8, 0xb6, 0xd8, 0xa1, 0x7a, 0x58, 0x4b, 0xee, 0x5e);

        #endregion

        #endregion

        /// <summary>
        /// Specifies whether a video stream contains 3D content. Data Type: BOOL stored as UINT32.
        /// </summary>
        /// <remarks>
        /// This attribute applies to video media types. 
        /// If this attribute is TRUE, the video stream contains 3D content. The default value is FALSE.
        /// </remarks>
        // NB: This IS NOT a media type, but for reason has gotten into this class. Can't kick it out ... too late.
        public static readonly Guid MF_MT_VIDEO_3D = new Guid(0xcb5e88cf, 0x7b5b, 0x476b, 0x85, 0xaa, 0x1c, 0xa5, 0xae, 0x18, 0x75, 0x55);

    }
}
