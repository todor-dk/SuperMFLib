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

    public static class MFMediaType
    {
        /// <summary> From MFMediaType_Default </summary>
        public static readonly Guid Default = new Guid(0x81A412E6, 0x8103, 0x4B06, 0x85, 0x7F, 0x18, 0x62, 0x78, 0x10, 0x24, 0xAC);
        /// <summary> From MFMediaType_Audio </summary>
        public static readonly Guid Audio = new Guid(0x73647561, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71);
        /// <summary> From MFMediaType_Video </summary>
        public static readonly Guid Video = new Guid(0x73646976, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xAA, 0x00, 0x38, 0x9B, 0x71);
        /// <summary> From MFMediaType_Protected </summary>
        public static readonly Guid Protected = new Guid(0x7b4b6fe6, 0x9d04, 0x4494, 0xbe, 0x14, 0x7e, 0x0b, 0xd0, 0x76, 0xc8, 0xe4);
        /// <summary> From MFMediaType_SAMI </summary>
        public static readonly Guid SAMI = new Guid(0xe69669a0, 0x3dcd, 0x40cb, 0x9e, 0x2e, 0x37, 0x08, 0x38, 0x7c, 0x06, 0x16);
        /// <summary> From MFMediaType_Script </summary>
        public static readonly Guid Script = new Guid(0x72178C22, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
        /// <summary> From MFMediaType_Image </summary>
        public static readonly Guid Image = new Guid(0x72178C23, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
        /// <summary> From MFMediaType_HTML </summary>
        public static readonly Guid HTML = new Guid(0x72178C24, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
        /// <summary> From MFMediaType_Binary </summary>
        public static readonly Guid Binary = new Guid(0x72178C25, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
        /// <summary> From MFMediaType_FileTransfer </summary>
        public static readonly Guid FileTransfer = new Guid(0x72178C26, 0xE45B, 0x11D5, 0xBC, 0x2A, 0x00, 0xB0, 0xD0, 0xF3, 0xF4, 0xAB);
        /// <summary> From MFMediaType_Stream </summary>
        public static readonly Guid Stream = new Guid(0xe436eb83, 0x524f, 0x11ce, 0x9f, 0x53, 0x00, 0x20, 0xaf, 0x0b, 0xa7, 0x70);

        public static readonly Guid Base = new Guid(0x00000000, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid PCM = new Guid(0x00000001, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid Float = new Guid(0x0003, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid DTS = new Guid(0x0008, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid Dolby_AC3_SPDIF = new Guid(0x0092, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid DRM = new Guid(0x0009, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid WMAudioV8 = new Guid(0x0161, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid WMAudioV9 = new Guid(0x0162, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid WMAudio_Lossless = new Guid(0x0163, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid WMASPDIF = new Guid(0x0164, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MSP1 = new Guid(0x000A, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MP3 = new Guid(0x0055, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid MPEG = new Guid(0x0050, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid AAC = new Guid(0x1610, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid ADTS = new Guid(0x1600, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);

        // {00000000-767a-494d-b478-f29d25dc9037}       MFMPEG4Format_Base
        public static readonly Guid MFMPEG4Format = new Guid(0x00000000, 0x767a, 0x494d, 0xb4, 0x78, 0xf2, 0x9d, 0x25, 0xdc, 0x90, 0x37);

        public static readonly Guid RGB32 = new Guid(22, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid ARGB32 = new Guid(21, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid RGB24 = new Guid(20, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid RGB555 = new Guid(24, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid RGB565 = new Guid(23, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid RGB8 = new Guid(41, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        public static readonly Guid AI44 = new FourCC("AI44").ToMediaSubtype();
        public static readonly Guid AYUV = new FourCC("AYUV").ToMediaSubtype();
        public static readonly Guid YUY2 = new FourCC("YUY2").ToMediaSubtype();
        public static readonly Guid YVYU = new FourCC("YVYU").ToMediaSubtype();
        public static readonly Guid YVU9 = new FourCC("YVU9").ToMediaSubtype();
        public static readonly Guid UYVY = new FourCC("UYVY").ToMediaSubtype();
        public static readonly Guid NV11 = new FourCC("NV11").ToMediaSubtype();
        public static readonly Guid NV12 = new FourCC("NV12").ToMediaSubtype();
        public static readonly Guid YV12 = new FourCC("YV12").ToMediaSubtype();
        public static readonly Guid I420 = new FourCC("I420").ToMediaSubtype();
        public static readonly Guid IYUV = new FourCC("IYUV").ToMediaSubtype();
        public static readonly Guid Y210 = new FourCC("Y210").ToMediaSubtype();
        public static readonly Guid Y216 = new FourCC("Y216").ToMediaSubtype();
        public static readonly Guid Y410 = new FourCC("Y410").ToMediaSubtype();
        public static readonly Guid Y416 = new FourCC("Y416").ToMediaSubtype();
        public static readonly Guid Y41P = new FourCC("Y41P").ToMediaSubtype();
        public static readonly Guid Y41T = new FourCC("Y41T").ToMediaSubtype();
        public static readonly Guid Y42T = new FourCC("Y42T").ToMediaSubtype();
        public static readonly Guid P210 = new FourCC("P210").ToMediaSubtype();
        public static readonly Guid P216 = new FourCC("P216").ToMediaSubtype();
        public static readonly Guid P010 = new FourCC("P010").ToMediaSubtype();
        public static readonly Guid P016 = new FourCC("P016").ToMediaSubtype();
        public static readonly Guid v210 = new FourCC("v210").ToMediaSubtype();
        public static readonly Guid v216 = new FourCC("v216").ToMediaSubtype();
        public static readonly Guid v410 = new FourCC("v410").ToMediaSubtype();
        public static readonly Guid MP43 = new FourCC("MP43").ToMediaSubtype();
        public static readonly Guid MP4S = new FourCC("MP4S").ToMediaSubtype();
        public static readonly Guid M4S2 = new FourCC("M4S2").ToMediaSubtype();
        public static readonly Guid MP4V = new FourCC("MP4V").ToMediaSubtype();
        public static readonly Guid WMV1 = new FourCC("WMV1").ToMediaSubtype();
        public static readonly Guid WMV2 = new FourCC("WMV2").ToMediaSubtype();
        public static readonly Guid WMV3 = new FourCC("WMV3").ToMediaSubtype();
        public static readonly Guid WVC1 = new FourCC("WVC1").ToMediaSubtype();
        public static readonly Guid MSS1 = new FourCC("MSS1").ToMediaSubtype();
        public static readonly Guid MSS2 = new FourCC("MSS2").ToMediaSubtype();
        public static readonly Guid MPG1 = new FourCC("MPG1").ToMediaSubtype();
        public static readonly Guid DVSL = new FourCC("dvsl").ToMediaSubtype();
        public static readonly Guid DVSD = new FourCC("dvsd").ToMediaSubtype();
        public static readonly Guid DVHD = new FourCC("dvhd").ToMediaSubtype();
        public static readonly Guid DV25 = new FourCC("dv25").ToMediaSubtype();
        public static readonly Guid DV50 = new FourCC("dv50").ToMediaSubtype();
        public static readonly Guid DVH1 = new FourCC("dvh1").ToMediaSubtype();
        public static readonly Guid DVC = new FourCC("dvc ").ToMediaSubtype();
        public static readonly Guid H264 = new FourCC("H264").ToMediaSubtype();
        public static readonly Guid MJPG = new FourCC("MJPG").ToMediaSubtype();
        public static readonly Guid O420 = new FourCC("420O").ToMediaSubtype();

        public static readonly Guid MPEG2 = new Guid(0xe06d8026, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x5f, 0x6c, 0xbb, 0xea);
        public static readonly Guid MFVideoFormat_H264_ES = new Guid(0x3f40f4f0, 0x5622, 0x4ff8, 0xb6, 0xd8, 0xa1, 0x7a, 0x58, 0x4b, 0xee, 0x5e);
        public static readonly Guid MFAudioFormat_Dolby_AC3 = new Guid(0xe06d802c, 0xdb46, 0x11cf, 0xb4, 0xd1, 0x00, 0x80, 0x05f, 0x6c, 0xbb, 0xea);
        public static readonly Guid MFAudioFormat_Dolby_DDPlus = new Guid(0xa7fb87af, 0x2d02, 0x42fb, 0xa4, 0xd4, 0x5, 0xcd, 0x93, 0x84, 0x3b, 0xdd);
        public static readonly Guid MFAudioFormat_QCELP = new Guid(0x5E7F6D41, 0xB115, 0x11D0, 0xBA, 0x91, 0x00, 0x80, 0x5F, 0xB4, 0xB9, 0x7E);
        public static readonly Guid MF_MT_VIDEO_3D = new Guid(0xcb5e88cf, 0x7b5b, 0x476b, 0x85, 0xaa, 0x1c, 0xa5, 0xae, 0x18, 0x75, 0x55);
    }
}
