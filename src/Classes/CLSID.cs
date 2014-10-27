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
    /// Static class that contains many of the GUIDs commonly used with the Media Foundation framework.
    /// </summary>
    public static class CLSID
    {
        // Unknown

        /// <summary>
        /// Index descriptor GUID. This is used in the ASF_INDEX_DESCRIPTOR structure.
        /// </summary>
        public static readonly Guid MFASFINDEXER_TYPE_TIMECODE = new Guid(0x49815231, 0x6bad, 0x44fd, 0x81, 0xa, 0x3f, 0x60, 0x98, 0x4e, 0xc7, 0xfd);

        /// <summary>
        /// Specifies a device's type, such as audio capture or video capture.
        /// <para /><strong>Data type</strong><para /><strong>GUID</strong><para />
        /// The following values are defined for this attribute:
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term><strong>MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_GUID</strong></term><description>Audio capture device.</description></item><item><term><strong>MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_GUID</strong></term><description>Video capture device.</description></item></list><para /><strong>Get/set</strong><para />
        /// To get this attribute, call <see cref="IMFAttributes.GetGUID" />.
        /// <para />
        /// To set this attribute, call <see cref="IMFAttributes.SetGUID" />.
        /// </summary>
        /// <remarks>
        /// Use this attribute as input to the following functions:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateDeviceSource"/></para><para>* 
        /// <see cref="MFExtern.MFCreateDeviceSourceActivate"/></para><para>* 
        /// <see cref="MFExtern.MFEnumDeviceSources"/></para>
        /// <para/>
        /// In addition, this attribute is set on the activation objects returned by the 
        /// <see cref="MFExtern.MFEnumDeviceSources"/> function. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C6C05267-1C93-48E2-B463-B5A1514F1B7B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C6C05267-1C93-48E2-B463-B5A1514F1B7B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_GUID = new Guid(0x14dd9a1c, 0x7cff, 0x41be, 0xb1, 0xb9, 0xba, 0x1a, 0xc6, 0xec, 0xb5, 0x71);
        /// <summary>
        /// Specifies a device's type, such as audio capture or video capture.
        /// <para /><strong>Data type</strong><para /><strong>GUID</strong><para />
        /// The following values are defined for this attribute:
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term><strong>MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_GUID</strong></term><description>Audio capture device.</description></item><item><term><strong>MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_GUID</strong></term><description>Video capture device.</description></item></list><para /><strong>Get/set</strong><para />
        /// To get this attribute, call <see cref="IMFAttributes.GetGUID" />.
        /// <para />
        /// To set this attribute, call <see cref="IMFAttributes.SetGUID" />.
        /// </summary>
        /// <remarks>
        /// Use this attribute as input to the following functions:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateDeviceSource"/></para><para>* 
        /// <see cref="MFExtern.MFCreateDeviceSourceActivate"/></para><para>* 
        /// <see cref="MFExtern.MFEnumDeviceSources"/></para>
        /// <para/>
        /// In addition, this attribute is set on the activation objects returned by the 
        /// <see cref="MFExtern.MFEnumDeviceSources"/> function. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C6C05267-1C93-48E2-B463-B5A1514F1B7B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C6C05267-1C93-48E2-B463-B5A1514F1B7B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_GUID = new Guid(0x8ac3587a, 0x4ae7, 0x42d8, 0x99, 0xe0, 0x0a, 0x60, 0x13, 0xee, 0xf9, 0x0f);

        /// <summary>
        /// Audio data sent over a connector via S/PDIF. 
        /// <para/>
        /// <seealso cref="IMFOutputPolicy.GenerateRequiredSchemas"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFCONNECTOR_SDI = new Guid(0x57cd5971, 0xce47, 0x11d9, 0x92, 0xdb, 0x00, 0x0b, 0xdb, 0x28, 0xff, 0x98);

        /// <summary>
        /// Specifies Analog Copy Protection (ACP) protection.
        /// </summary>
        public static readonly Guid MFPROTECTION_ACP = new Guid(0xc3fd11c6, 0xf8b7, 0x4d20, 0xb0, 0x08, 0x1d, 0xb1, 0x7d, 0x61, 0xf2, 0xda);
        /// <summary>
        /// Specifies Copy Generational Management System - A (CGMS-A) protection. 
        /// </summary>
        public static readonly Guid MFPROTECTION_CGMSA = new Guid(0xE57E69E9, 0x226B, 0x4d31, 0xB4, 0xE3, 0xD3, 0xDB, 0x00, 0x87, 0x36, 0xDD);
        /// <summary>
        /// Specifies to constrict audio.
        /// </summary>
        public static readonly Guid MFPROTECTION_CONSTRICTAUDIO = new Guid(0xffc99b44, 0xdf48, 0x4e16, 0x8e, 0x66, 0x09, 0x68, 0x92, 0xc1, 0x57, 0x8a);
        /// <summary>
        /// Specifies to constrict video.
        /// </summary>
        public static readonly Guid MFPROTECTION_CONSTRICTVIDEO = new Guid(0x193370ce, 0xc5e4, 0x4c3a, 0x8a, 0x66, 0x69, 0x59, 0xb4, 0xda, 0x44, 0x42);

        /// <summary>
        /// This attribute specifies additional protection offered by a video output trust authority(OTA) 
        /// when a connector does not offer output protection.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302132(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302132(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MFPROTECTION_CONSTRICTVIDEO_NOOPM = new Guid(0xa580e8cd, 0xc247, 0x4957, 0xb9, 0x83, 0x3c, 0x2e, 0xeb, 0xd1, 0xff, 0x59);

        /// <summary>
        /// Specifies protection is disabled.
        /// </summary>
        public static readonly Guid MFPROTECTION_DISABLE = new Guid(0x8cc6d81b, 0xfec6, 0x4d8f, 0x96, 0x4b, 0xcf, 0xba, 0x0b, 0x0d, 0xad, 0x0d);
        /// <summary>
        /// Specifies FFT protection. 
        /// </summary>
        public static readonly Guid MFPROTECTION_FFT = new Guid(0x462a56b2, 0x2866, 0x4bb6, 0x98, 0x0d, 0x6d, 0x8d, 0x9e, 0xdb, 0x1a, 0x8c);
        /// <summary>
        /// Specifies HDCP High-Bandwidth Digital Content Protection (HDCP) protection.
        /// </summary>
        public static readonly Guid MFPROTECTION_HDCP = new Guid(0xAE7CC03D, 0xC828, 0x4021, 0xac, 0xb7, 0xd5, 0x78, 0xd2, 0x7a, 0xaf, 0x13);
        /// <summary>
        /// Specifies trusted audio drivers.
        /// </summary>
        public static readonly Guid MFPROTECTION_TRUSTEDAUDIODRIVERS = new Guid(0x65bdf3d2, 0x0168, 0x4816, 0xa5, 0x33, 0x55, 0xd4, 0x7b, 0x02, 0x71, 0x01);
        /// <summary>
        /// Specifies Windows Media Digital Rights Management (WMDRM) Output Trust Authority (OTA).
        /// </summary>
        public static readonly Guid MFPROTECTION_WMDRMOTA = new Guid(0xa267a6a1, 0x362e, 0x47d0, 0x88, 0x05, 0x46, 0x28, 0x59, 0x8a, 0x23, 0xe4);
        /// <summary>
        /// Protection schema attribute GUID: Constrict video image size.
        /// </summary>
        public static readonly Guid MFPROTECTIONATTRIBUTE_CONSTRICTVIDEO_IMAGESIZE = new Guid(0x8476fc, 0x4b58, 0x4d80, 0xa7, 0x90, 0xe7, 0x29, 0x76, 0x73, 0x16, 0x1d);
        /// <summary>
        /// Protection schema attribute GUID: HDCP SRM data. Needed for Protected Media Path (PMP).
        /// </summary>
        public static readonly Guid MFPROTECTIONATTRIBUTE_HDCP_SRM = new Guid(0x6f302107, 0x3477, 0x4468, 0x8a, 0x8, 0xee, 0xf9, 0xdb, 0x10, 0xe2, 0xf);
        /// <summary>
        /// Sample attributes are used for encrypted samples: Descramble Data. Type: UINT64.
        /// </summary>
        public static readonly Guid MFSampleExtension_DescrambleData = new Guid(0x43483be6, 0x4903, 0x4314, 0xb0, 0x32, 0x29, 0x51, 0x36, 0x59, 0x36, 0xfc);
        /// <summary>
        /// Sample attributes are used for encrypted samples: Sample Key Id. Type: UINT32.
        /// </summary>
        public static readonly Guid MFSampleExtension_SampleKeyID = new Guid(0x9ed713c8, 0x9b87, 0x4b26, 0x82, 0x97, 0xa9, 0x3b, 0x0c, 0x5a, 0x8a, 0xcc);
        /// <summary>
        /// Sample attributes are used for encrypted samples: Generate-Key Function. Type: UINT64. Type: UINT64.
        /// </summary>
        public static readonly Guid MFSampleExtension_GenKeyFunc = new Guid(0x441ca1ee, 0x6b1f, 0x4501, 0x90, 0x3a, 0xde, 0x87, 0xdf, 0x42, 0xf6, 0xed);
        /// <summary>
        /// Sample attributes are used for encrypted samples: Generate-Key Context.
        /// </summary>
        public static readonly Guid MFSampleExtension_GenKeyCtx = new Guid(0x188120cb, 0xd7da, 0x4b59, 0x9b, 0x3e, 0x92, 0x52, 0xfd, 0x37, 0x30, 0x1c);
        /// <summary>
        /// Specifies the offsets to the payload boundaries in a frame for protected samples. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetBlob"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetBlob"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFSample"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to media samples protected by Windows Media Digital Rights Management (DRM).
        /// The value of the attribute is an array of <strong>DWORD</strong>s. Each entry in the array is the
        /// offset of a payload boundary, relative to the start of the frame. An application can use these
        /// values when decrypting and reconstructing the frames. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8AA25AFD-EFA8-4FE0-92D4-8432F9D633C9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8AA25AFD-EFA8-4FE0-92D4-8432F9D633C9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_PacketCrossOffsets = new Guid(0x2789671d, 0x389f, 0x40bb, 0x90, 0xd9, 0xc2, 0x82, 0xf7, 0x7f, 0x9a, 0xbd);

        /// <summary>
        /// Specifies the ID of an encrypted sample.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/09B11406-DF7B-4541-998C-68306654BADC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/09B11406-DF7B-4541-998C-68306654BADC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_Encryption_SampleID = new Guid(0x6698b84e, 0x0afa, 0x4330, 0xae, 0xb2, 0x1c, 0x0a, 0x98, 0xd7, 0xa4, 0x4d);
        /// <summary>
        /// <i>***** Documentation Missing *****</i>.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BLOB</strong>
        /// </summary>
        public static readonly Guid MFSampleExtension_Encryption_KeyID = new Guid(0x76376591, 0x795f, 0x4da1, 0x86, 0xed, 0x9d, 0x46, 0xec, 0xa1, 0x09, 0xa9);
        /// <summary>
        /// Sets the Key ID for the sample.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302158(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302158(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_Content_KeyID = new Guid(0xc6c7f5b0, 0xacca, 0x415b, 0x87, 0xd9, 0x10, 0x44, 0x14, 0x69, 0xef, 0xc6);
        /// <summary>
        /// Sets the sub-sample mapping for the sample indicating the clear and encrypted bytes in the sample data. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BLOB</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302160(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302160(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_Encryption_SubSampleMappingSplit = new Guid(0xfe0254b9, 0x2aa5, 0x4edc, 0x99, 0xf7, 0x17, 0xe8, 0x9d, 0xbf, 0x91, 0x74);

        /// <summary>
        /// <i>***** Documentation Missing *****</i>.
        /// </summary>
        public static readonly Guid MF_SampleProtectionSalt = new Guid(0x5403deee, 0xb9ee, 0x438f, 0xaa, 0x83, 0x38, 0x4, 0x99, 0x7e, 0x56, 0x9d);
        /// <summary>
        /// This is used to call <see cref="IMFPMPHost.CreateObjectByCLSID"/> with the class identifier <see cref="CLSID_MFSourceResolver"/> 
        /// to create the source resolver inside the PMP process. The method returns a pointer to a proxy for the source resolver.
        /// </summary>
        public static readonly Guid CLSID_MFSourceResolver = new Guid(0x90eab60f, 0xe43a, 0x4188, 0xbc, 0xc4, 0xe4, 0x7f, 0xdf, 0x04, 0x86, 0x8c);

        // Generic

        /// <summary>
        /// Create the sink writer. The <c>ppvObject</c> parameter receives an <see cref="ReadWrite.IMFSinkWriter"/> interface pointer.
        /// <para/>
        /// <seealso cref="ReadWrite.IMFReadWriteClassFactory.CreateInstanceFromURL"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2769FAA2-E381-4908-95F8-122AE4CD7EC5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2769FAA2-E381-4908-95F8-122AE4CD7EC5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid CLSID_MFSinkWriter = new Guid(0xa3bbfb17, 0x8273, 0x4e52, 0x9e, 0x0e, 0x97, 0x39, 0xdc, 0x88, 0x79, 0x90);
        /// <summary>
        /// Create the source reader. The <c>ppvObject</c> parameter receives an <see cref="ReadWrite.IMFSourceReader"/> interface pointer.
        /// <para/>
        /// <seealso cref="ReadWrite.IMFReadWriteClassFactory.CreateInstanceFromURL"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2769FAA2-E381-4908-95F8-122AE4CD7EC5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2769FAA2-E381-4908-95F8-122AE4CD7EC5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid CLSID_MFSourceReader = new Guid(0x1777133c, 0x0881, 0x411b, 0xa5, 0x77, 0xad, 0x54, 0x5f, 0x07, 0x14, 0xc4);

        /// <summary>
        /// Approximate processing latency introduced by the component, in 100-nanosecond units.
        /// <para/>
        /// Processing latency is the amount of latency that a component introduces into the pipeline 
        /// by processing a sample. In some cases, the latency cannot be derived simply by looking at 
        /// the calls to IMFQualityManager::NotifyProcessInput and IMFQualityManager::NotifyProcessOutput. 
        /// For example, there may not be a one-to-one correspondence between input samples and output samples. 
        /// In this case, the component might send an MEQualityNotify event with the processing latency. 
        /// If the processing latency changes, the component can send a new event at any time during streaming.
        /// <para/>
        /// <seealso cref="MediaEventType.MEQualityNotify"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1B4B6A2D-411E-42D1-A44B-BB1928E1C063(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1B4B6A2D-411E-42D1-A44B-BB1928E1C063(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_QUALITY_NOTIFY_PROCESSING_LATENCY = new Guid(0xf6b44af8, 0x604d, 0x46fe, 0xa9, 0x5d, 0x45, 0x47, 0x9b, 0x10, 0xc9, 0xbc);
        /// <summary>
        /// Lag time for the sample, in 100-nanosecond units. 
        /// If the value is positive, the sample was late. 
        /// If the value is negative, the sample was early.
        /// <para/>
        /// <seealso cref="MediaEventType.MEQualityNotify"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1B4B6A2D-411E-42D1-A44B-BB1928E1C063(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1B4B6A2D-411E-42D1-A44B-BB1928E1C063(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_QUALITY_NOTIFY_SAMPLE_LAG = new Guid(0x30d15206, 0xed2a, 0x4760, 0xbe, 0x17, 0xeb, 0x4a, 0x9f, 0x12, 0x29, 0x5c);
        /// <summary>
        /// Segment offset. This time format is supported by the Sequencer Source. 
        /// The starting time is an offset within a segment.
        /// <para/>
        /// Call the MFCreateSequencerSegmentOffset function to create the PROPVARIANT value 
        /// for the pvarStartPosition parameter.
        /// <para/>
        /// <seealso cref="IMFMediaSession.Start"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1BDEC0C0-B042-4E5E-A72B-B15942750CED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1BDEC0C0-B042-4E5E-A72B-B15942750CED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TIME_FORMAT_SEGMENT_OFFSET = new Guid(0xc8b8be77, 0x869c, 0x431d, 0x81, 0x2e, 0x16, 0x96, 0x93, 0xf6, 0x5a, 0x39);
        /// <summary>
        /// Skip to a playlist entry. The <c>pvarStartPosition</c> parameter specifies the index of the playlist entry, 
        /// relative to the current entry. For example, the value 2 skips forward two entries. 
        /// To skip backward, pass a negative value. The PROPVARIANT type is VT_I4.
        /// <para/>
        /// If a media source supports this time format, the <see cref="IMFMediaSource.GetCharacteristics"/> 
        /// method returns one or both of the following flags:
        /// <para/>
        /// * MFMEDIASOURCE_CAN_SKIPFORWARD
        /// <para/>
        /// * MFMEDIASOURCE_CAN_SKIPBACKWARD
        /// <para/>
        /// <seealso cref="IMFMediaSession.Start"/>
        /// </summary>
        /// <remarks>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1BDEC0C0-B042-4E5E-A72B-B15942750CED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1BDEC0C0-B042-4E5E-A72B-B15942750CED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TIME_FORMAT_ENTRY_RELATIVE = new Guid(0x4399f178, 0x46d3, 0x4504, 0xaf, 0xda, 0x20, 0xd3, 0x2e, 0x9b, 0xa3, 0x60);
        /// <summary>
        /// 100-nanosecond units. 
        /// <para/>
        /// The value returned in <c>pvDurationValue</c> is a <strong>LARGE_INTEGER</strong>.
        /// <para/>
        /// Variant type (vt): <strong>VT_I8</strong>
        /// <para/>
        /// <seealso cref="MFPlayer.IMFPMediaItem.GetDuration"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/831F023B-C06F-4099-9F4C-DF38F3D1382F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/831F023B-C06F-4099-9F4C-DF38F3D1382F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFP_POSITIONTYPE_100NS = Guid.Empty;

        /// <summary>
        /// Class ID used to create an instance of the Media Engine.
        /// <para/>
        /// <seealso cref="ReadWrite.IMFReadWriteClassFactory"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/hh447919(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/hh447919(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid CLSID_MFMediaEngineClassFactory = new Guid(0xb44392da, 0x499b, 0x446b, 0xa4, 0xcb, 0x0, 0x5f, 0xea, 0xd0, 0xe6, 0xd5);
    }
}
