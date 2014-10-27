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
    /// Class MF_CAPTURE_ENGINE.
    /// </summary>
    public static class MF_CAPTURE_ENGINE
    {
        /// <summary>
        /// Signals capture engine was initialized in response to <see cref="IMFCaptureEngine.Initialize"/>.
        /// </summary>
        public static readonly Guid INITIALIZED = new Guid(0x219992bc, 0xcf92, 0x4531, 0xa1, 0xae, 0x96, 0xe1, 0xe8, 0x86, 0xc8, 0xf1);
        /// <summary>
        /// Signals capture engine preview started in response to <see cref="IMFCaptureEngine.StartPreview"/>.
        /// </summary>
        public static readonly Guid PREVIEW_STARTED = new Guid(0xa416df21, 0xf9d3, 0x4a74, 0x99, 0x1b, 0xb8, 0x17, 0x29, 0x89, 0x52, 0xc4);
        /// <summary>
        /// Signals capture engine preview stopped in response to <see cref="IMFCaptureEngine.StopPreview"/>.
        /// </summary>
        public static readonly Guid PREVIEW_STOPPED = new Guid(0x13d5143c, 0x1edd, 0x4e50, 0xa2, 0xef, 0x35, 0x0a, 0x47, 0x67, 0x80, 0x60);
        /// <summary>
        /// Signals capture engine record started in response to <see cref="IMFCaptureEngine.StartRecord"/>.
        /// </summary>
        public static readonly Guid RECORD_STARTED = new Guid(0xac2b027b, 0xddf9, 0x48a0, 0x89, 0xbe, 0x38, 0xab, 0x35, 0xef, 0x45, 0xc0);
        /// <summary>
        /// Signals capture engine record stopped in response to <see cref="IMFCaptureEngine.StopRecord"/>.
        /// </summary>
        public static readonly Guid RECORD_STOPPED = new Guid(0x55e5200a, 0xf98f, 0x4c0d, 0xa9, 0xec, 0x9e, 0xb2, 0x5e, 0xd3, 0xd7, 0x73);
        /// <summary>
        /// Signals a photo was taken by capture engine in response to <see cref="IMFCaptureEngine.TakePhoto"/>.
        /// </summary>
        public static readonly Guid PHOTO_TAKEN = new Guid(0x3c50c445, 0x7304, 0x48eb, 0x86, 0x5d, 0xbb, 0xa1, 0x9b, 0xa3, 0xaf, 0x5c);
        /// <summary>
        /// Signals an error in capture engine.
        /// </summary>
        public static readonly Guid ERROR = new Guid(0x46b89fc6, 0x33cc, 0x4399, 0x9d, 0xad, 0x78, 0x4d, 0xe7, 0x7d, 0x58, 0x7c);
        /// <summary>
        /// Signals an error in capture engine.
        /// </summary>
        public static readonly Guid EFFECT_ADDED = new Guid(0xaa8dc7b5, 0xa048, 0x4e13, 0x8e, 0xbe, 0xf2, 0x3c, 0x46, 0xc8, 0x30, 0xc1);
        /// <summary>
        /// Signals an error in capture engine.
        /// </summary>
        public static readonly Guid EFFECT_REMOVED = new Guid(0xc6e8db07, 0xfb09, 0x4a48, 0x89, 0xc6, 0xbf, 0x92, 0xa0, 0x42, 0x22, 0xc9);
        /// <summary>
        /// Signals an error in capture engine.
        /// </summary>
        public static readonly Guid ALL_EFFECTS_REMOVED = new Guid(0xfded7521, 0x8ed8, 0x431a, 0xa9, 0x6b, 0xf3, 0xe2, 0x56, 0x5e, 0x98, 0x1c);
        /// <summary>
        /// This attribute enables video sample allocation using DX11 surfaces,
        /// and enables hardware acceleration within the Source Reader.
        /// This should be set to the IUnknown interface of an
        /// object that implements the IDirect3DDeviceManager11 interface.
        /// <para/>
        /// Data type: IUnknown.
        /// </summary>
        public static readonly Guid D3D_MANAGER = new Guid(0x76e25e7b, 0xd595, 0x4283, 0x96, 0x2c, 0xc5, 0x94, 0xaf, 0xd7, 0x8d, 0xdf);
        /// <summary>
        /// This attribute dictates the maximum number of unprocessed samples that can be buffered 
        /// for processing in the record sink video path. Once the record has buffered 
        /// MF_CAPTURE_ENGINE_RECORD_SINK_VIDEO_MAX_UNPROCESSED_SAMPLES number of unprocessed samples, 
        /// it drops the frame rate by dropping samples.
        /// <para/>
        /// Data type: UINT32
        /// </summary>
        public static readonly Guid RECORD_SINK_VIDEO_MAX_UNPROCESSED_SAMPLES = new Guid(0xb467f705, 0x7913, 0x4894, 0x9d, 0x42, 0xa2, 0x15, 0xfe, 0xa2, 0x3d, 0xa9);
        /// <summary>
        /// This attribute dictates the maximum number of unprocessed samples that can be buffered 
        /// for processing in the record sink audio path. Once the record has buffered 
        /// MF_CAPTURE_ENGINE_RECORD_SINK_AUDIO_MAX_UNPROCESSED_SAMPLES number of unprocessed samples, 
        /// it drops the frame rate by dropping samples.
        /// <para/>
        /// Data type: UINT32
        /// </summary>
        public static readonly Guid RECORD_SINK_AUDIO_MAX_UNPROCESSED_SAMPLES = new Guid(0x1cddb141, 0xa7f4, 0x4d58, 0x98, 0x96, 0x4d, 0x15, 0xa5, 0x3c, 0x4e, 0xfe);
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public static readonly Guid RECORD_SINK_VIDEO_MAX_PROCESSED_SAMPLES = new Guid(0xe7b4a49e, 0x382c, 0x4aef, 0xa9, 0x46, 0xae, 0xd5, 0x49, 0xb, 0x71, 0x11);
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public static readonly Guid RECORD_SINK_AUDIO_MAX_PROCESSED_SAMPLES = new Guid(0xe7b4a49e, 0x382c, 0x4aef, 0xa9, 0x46, 0xae, 0xd5, 0x49, 0xb, 0x71, 0x11);
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public static readonly Guid USE_AUDIO_DEVICE_ONLY = new Guid(0x1c8077da, 0x8466, 0x4dc4, 0x8b, 0x8e, 0x27, 0x6b, 0x3f, 0x85, 0x92, 0x3b);
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public static readonly Guid USE_VIDEO_DEVICE_ONLY = new Guid(0x7e025171, 0xcf32, 0x4f2e, 0x8f, 0x19, 0x41, 0x5, 0x77, 0xb7, 0x3a, 0x66);
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public static readonly Guid DISABLE_HARDWARE_TRANSFORMS = new Guid(0xb7c42a6b, 0x3207, 0x4495, 0xb4, 0xe7, 0x81, 0xf9, 0xc3, 0x5d, 0x59, 0x91);
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public static readonly Guid DISABLE_DXVA = new Guid(0xf9818862, 0x179d, 0x433f, 0xa3, 0x2f, 0x74, 0xcb, 0xcf, 0x74, 0x46, 0x6d);
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public static readonly Guid MEDIASOURCE_CONFIG = new Guid(0xbc6989d2, 0x0fc1, 0x46e1, 0xa7, 0x4f, 0xef, 0xd3, 0x6b, 0xc7, 0x88, 0xde);
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public static readonly Guid DECODER_MFT_FIELDOFUSE_UNLOCK_Attribute = new Guid(0x2b8ad2e8, 0x7acb, 0x4321, 0xa6, 0x06, 0x32, 0x5c, 0x42, 0x49, 0xf4, 0xfc);
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public static readonly Guid ENCODER_MFT_FIELDOFUSE_UNLOCK_Attribute = new Guid(0x54c63a00, 0x78d5, 0x422f, 0xaa, 0x3e, 0x5e, 0x99, 0xac, 0x64, 0x92, 0x69);
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        [Obsolete]
        public static readonly Guid DISABLE_LOW_LATENCY = new Guid(0xdab5a16d, 0x1f0f, 0x44da, 0xad, 0x48, 0x82, 0x27, 0x31, 0x89, 0x43, 0xb8);
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public static readonly Guid EVENT_GENERATOR_GUID = new Guid(0xabfa8ad5, 0xfc6d, 0x4911, 0x87, 0xe0, 0x96, 0x19, 0x45, 0xf8, 0xf7, 0xce);
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public static readonly Guid EVENT_STREAM_INDEX = new Guid(0x82697f44, 0xb1cf, 0x42eb, 0x97, 0x53, 0xf8, 0x6d, 0x64, 0x9c, 0x88, 0x65);

        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public static readonly Guid SOURCE_CURRENT_DEVICE_MEDIA_TYPE_SET = new Guid(0xe7e75e4c, 0x039c, 0x4410, 0x81, 0x5b, 0x87, 0x41, 0x30, 0x7b, 0x63, 0xaa);
        /// <summary>
        /// ********* DOCUMENTATION NOT FOUND *********
        /// </summary>
        public static readonly Guid SINK_PREPARED = new Guid(0x7BFCE257, 0x12B1, 0x4409, 0x8C, 0x34, 0xD4, 0x45, 0xDA, 0xAB, 0x75, 0x78);

        public static readonly Guid OUTPUT_MEDIA_TYPE_SET = new Guid(0xcaaad994, 0x83ec, 0x45e9, 0xa3, 0x0a, 0x1f, 0x20, 0xaa, 0xdb, 0x98, 0x31);
    }

}
