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
    /// Guid constants defining services that can be queried using the <see cref="IMFGetService.GetService"/> method.
    /// </summary>
    public class MFService : GuidEnum
    {
        public MFService(Guid serviceGuid)
            : base(serviceGuid)
        {
        }

        public MFService(uint a, ushort b, ushort c, byte d, byte e, byte f, byte g, byte h, byte i, byte j, byte k)
            : this(new Guid(a, b, c, d, e, f, g, h, i, j, k))
        {
        }

        /// <summary>
        /// Exposed by: ASF media source.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFTimecodeTranslate"/> interface.
        /// </summary>
        public static readonly MFService MF_TIMECODE_SERVICE = new MFService(0xa0d502a7, 0x0eb3, 0x4885, 0xb1, 0xb9, 0x9f, 0xeb, 0x0d, 0x08, 0x34, 0x54);

        /// <summary>
        /// Exposed by: Media sources.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IPropertyStore"/> interface.
        /// </summary>
        public static readonly MFService MF_PROPERTY_HANDLER_SERVICE = new MFService(0xa3face02, 0x32b8, 0x41dd, 0x90, 0xe7, 0x5f, 0xef, 0x7c, 0x89, 0x91, 0xb5);

        /// <summary>
        /// Exposed by: Media sources.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFMetadataProvider"/> interface.
        /// </summary>
        public static readonly MFService MF_METADATA_PROVIDER_SERVICE = new MFService(0xdb214084, 0x58a4, 0x4d2e, 0xb8, 0x4f, 0x6f, 0x75, 0x5b, 0x2f, 0x7a, 0xd);

        /// <summary>
        /// Exposed by: Protected media path (PMP) Media Session.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFPMPServer"/> interface.
        /// </summary>
        public static readonly MFService MF_PMP_SERVER_CONTEXT = new MFService(0x2f00c910, 0xd2cf, 0x4278, 0x8b, 0x6a, 0xd0, 0x77, 0xfa, 0xc3, 0xa2, 0x5f);

        /// <summary>
        /// Exposed by: Media sources.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFQualityAdvise"/> interface.
        /// </summary>
        public static readonly MFService MF_QUALITY_SERVICES = new MFService(0xb7e2be11, 0x2f96, 0x4640, 0xb5, 0x2c, 0x28, 0x23, 0x65, 0xbd, 0xf1, 0x6c);

        /// <summary>
        /// Exposed by: Media sources, Media Session.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFRateSupport"/> or <see cref="IMFRateControl"/> interface.
        /// </summary>
        public static readonly MFService MF_RATE_CONTROL_SERVICE = new MFService(0x866fa297, 0xb802, 0x4bf8, 0x9d, 0xc9, 0x5e, 0x3b, 0x6a, 0x9f, 0x53, 0xc9);

        /// <summary>
        /// Exposed by: Proxies for remote objects.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFRemoteProxy"/> interface.
        /// </summary>
        public static readonly MFService MF_REMOTE_PROXY = new MFService(0x2f00c90e, 0xd2cf, 0x4278, 0x8b, 0x6a, 0xd0, 0x77, 0xfa, 0xc3, 0xa2, 0x5f);

        /// <summary>
        /// Exposed by: Synchronized Accessible Media Interchange (SAMI) media source.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFSAMIStyle"/> interface.
        /// </summary>
        public static readonly MFService MF_SAMI_SERVICE = new MFService(0x49a89ae7, 0xb4d9, 0x4ef2, 0xaa, 0x5c, 0xf6, 0x5a, 0x3e, 0x5, 0xae, 0x4e);

        /// <summary>
        /// Exposed by: Sequencer source.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFMediaSourcePresentationProvider"/> interface.
        /// </summary>
        public static readonly MFService MF_SOURCE_PRESENTATION_PROVIDER_SERVICE = new MFService(0xe002aadc, 0xf4af, 0x4ee5, 0x98, 0x47, 0x05, 0x3e, 0xdf, 0x84, 0x04, 0x26);

        /// <summary>
        /// Exposed by: Media session.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFTopologyNodeAttributeEditor"/> interface.
        /// </summary>
        public static readonly MFService MF_TOPONODE_ATTRIBUTE_EDITOR_SERVICE = new MFService(0x65656e1a, 0x077f, 0x4472, 0x83, 0xef, 0x31, 0x6f, 0x11, 0xd5, 0x08, 0x7a);

        /// <summary>
        /// Exposed by: Media session.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFWorkQueueServices"/> interface.
        /// </summary>
        public static readonly MFService MF_WORKQUEUE_SERVICES = new MFService(0x8e37d489, 0x41e0, 0x413a, 0x90, 0x68, 0x28, 0x7c, 0x88, 0x6d, 0x8d, 0xda);

        /// <summary>
        /// Exposed by: Byte streams.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFSaveJob"/> interface.
        /// </summary>
        public static readonly MFService MFNET_SAVEJOB_SERVICE = new MFService(0xb85a587f, 0x3d02, 0x4e52, 0x95, 0x65, 0x55, 0xd3, 0xec, 0x1e, 0x7f, 0xf7);

        /// <summary>
        /// Exposed by: Network source. Use this service to retrieve network statistics. See MFNETSOURCE_STATISTICS Property.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IPropertyStore"/> interface.
        /// </summary>
        public static readonly MFService MFNETSOURCE_STATISTICS_SERVICE = new MFService(0x3cb1f275, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        /// <summary>
        /// Exposed by: Audio renderer.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFAudioPolicy"/> interface.
        /// </summary>
        public static readonly MFService MR_AUDIO_POLICY_SERVICE = new MFService(0x911fd737, 0x6775, 0x4ab0, 0xa6, 0x14, 0x29, 0x78, 0x62, 0xfd, 0xac, 0x88);

        /// <summary>
        /// Exposed by: Audio renderer.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFSimpleAudioVolume"/> interface.
        /// </summary>
        public static readonly MFService MR_POLICY_VOLUME_SERVICE = new MFService(0x1abaa2ac, 0x9d3b, 0x47c6, 0xab, 0x48, 0xc5, 0x95, 0x6, 0xde, 0x78, 0x4d);

        /// <summary>
        /// Exposed by: Audio renderer.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFAudioStreamVolume "/> interface.
        /// </summary>
        public static readonly MFService MR_STREAM_VOLUME_SERVICE = new MFService(0xf8b5fa2f, 0x32ef, 0x46f5, 0xb1, 0x72, 0x13, 0x21, 0x21, 0x2f, 0xb2, 0xc4);

        /// <summary>
        /// Exposed by: EVR.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get
        /// various interfaces exposed by the EVR presenter.
        /// See <a href="http://msdn.microsoft.com/en-gb/library/windows/desktop/aa965221(v=vs.85).aspx">http://msdn.microsoft.com/en-gb/library/windows/desktop/aa965221(v=vs.85).aspx</a>.
        /// </summary>
        public static readonly MFService MR_VIDEO_RENDER_SERVICE = new MFService(0x1092a86c, 0xab1a, 0x459a, 0xa3, 0x36, 0x83, 0x1f, 0xbc, 0x4d, 0x11, 0xff);

        /// <summary>
        /// Exposed by: EVR.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get
        /// various interfaces exposed by the EVR presenter.
        /// See <a href="http://msdn.microsoft.com/en-gb/library/windows/desktop/aa965221(v=vs.85).aspx">http://msdn.microsoft.com/en-gb/library/windows/desktop/aa965221(v=vs.85).aspx</a>.
        /// </summary>
        public static readonly MFService MR_VIDEO_MIXER_SERVICE = new MFService(0x73cd2fc, 0x6cf4, 0x40b7, 0x88, 0x59, 0xe8, 0x95, 0x52, 0xc8, 0x41, 0xf8);

        /// <summary>
        /// Exposed by: Enhanced video renderer (EVR), Input pins on the DirectShow EVR filter, EVR stream sinks.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <c>IDirect3DDeviceManager9</c>, <c>IDirectXVideoAccelerationService</c>,
        /// <c>IDirectXVideoMemoryConfiguration</c> or <see cref="IMFVideoSampleAllocator"/> interface.
        /// </summary>
        public static readonly MFService MR_VIDEO_ACCELERATION_SERVICE = new MFService(0xefef5175, 0x5c7d, 0x4ce2, 0xbb, 0xbd, 0x34, 0xff, 0x8b, 0xca, 0x65, 0x54);

        /// <summary>
        /// Exposed by: DirectX surface buffers.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="dxvahd.IDirect3DSurface9"/> interface.
        /// </summary>
        public static readonly MFService MR_BUFFER_SERVICE = new MFService(0xa562248c, 0x9ac6, 0x4ffc, 0x9f, 0xba, 0x3a, 0xf8, 0xf8, 0xad, 0x1a, 0x4d);

        /// <summary>
        /// Exposed by: PMP Media Session.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFPMPHost"/> interface.
        /// </summary>
        public static readonly MFService MF_PMP_SERVICE = new MFService(0x2F00C90C, 0xD2CF, 0x4278, 0x8B, 0x6A, 0xD0, 0x77, 0xFA, 0xC3, 0xA2, 0x5F);

        /// <summary>
        /// Exposed by: Media Session.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="Transform.IMFLocalMFTRegistration"/> interface.
        /// </summary>
        public static readonly MFService MF_LOCAL_MFT_REGISTRATION_SERVICE = new MFService(0xddf5cf9c, 0x4506, 0x45aa, 0xab, 0xf0, 0x6d, 0x5d, 0x94, 0xdd, 0x1b, 0x4a);

        /// <summary>
        /// GUID passed to <see cref="IMFGetService.GetService"/> to retrieve a bytestream
        /// service interface such as <see cref="IMFByteStreamCacheControl2"/>,
        /// <see cref="IMFByteStreamBuffering"/>, or <see cref="IPropertyStore"/>
        /// from a Media Source.
        /// </summary>
        public static readonly MFService MF_BYTESTREAM_SERVICE = new MFService(0xab025e2b, 0x16d9, 0x4180, 0xa1, 0x27, 0xba, 0x6c, 0x70, 0x15, 0x61, 0x61);

        /// <summary>
        /// Exposed by: <i>*****Unknown*****</i>.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <i>*****Unknown*****</i> interface.
        /// </summary>
        public static readonly MFService MF_WRAPPED_BUFFER_SERVICE = new MFService(0xab544072, 0xc269, 0x4ebc, 0xa5, 0x52, 0x1c, 0x3b, 0x32, 0xbe, 0xd5, 0xca);

        /// <summary>
        /// Exposed by: <i>*****Unknown*****</i>.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <i>*****Unknown*****</i> interface.
        /// </summary>
        public static readonly MFService MF_WRAPPED_SAMPLE_SERVICE = new MFService(0x31f52bf2, 0xd03e, 0x4048, 0x80, 0xd0, 0x9c, 0x10, 0x46, 0xd8, 0x7c, 0x61);

        /// <summary>
        /// Exposed by: <i>*****Unknown*****</i>.
        /// <para/>
        /// Use this service Guid with the <see cref="IMFGetService.GetService"/> to get an
        /// instance of a <see cref="IMFMediaSource"/> interface.
        /// </summary>
        public static readonly MFService MF_MEDIASOURCE_SERVICE = new MFService(0xf09992f7, 0x9fba, 0x4c4a, 0xa3, 0x7f, 0x8c, 0x47, 0xb4, 0xe1, 0xdf, 0xe7);

        /// <summary>
        /// GUID identifying the PlayToService.
        /// This is used when trying to access <c>PlayTo</c> interfaces through the <c>IServiceProvider</c> interface.
        /// </summary>
        public static readonly MFService GUID_PlayToService = new MFService(0xf6a8ff9d, 0x9e14, 0x41c9, 0xbf, 0x0f, 0x12, 0x0a, 0x2b, 0x3c, 0xe1, 0x20);

        /// <summary>
        /// GUID identifying the <c>NativeDeviceService</c>. If the user has a pointer to just an <c>IBasicDevice</c>,
        /// it can be QI'd for <c>IServiceProvider</c>.
        /// <para/>
        /// IServiceProvider->QueryService() can be used with GUID_NativeDeviceService to get native interfaces for the device.
        /// <para/>
        /// For example: You can retrieve a IUPnPDevice pointer as follows:
        /// pBasicDevice->QueryService( GUID_NativeDeviceService, IID_IUPnPDevice, (void **)spUPnPDevice);
        /// </summary>
        public static readonly MFService GUID_NativeDeviceService = new MFService(0xef71e53c, 0x52f4, 0x43c5, 0xb8, 0x6a, 0xad, 0x6c, 0xb2, 0x16, 0xa6, 0x1e);
    }
}
