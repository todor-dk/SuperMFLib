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

namespace MediaFoundation.Core.Classes
{

    /// <summary>
    /// This class contains the attribute GUIDs that are defined for Media Foundation.
    /// </summary>
    internal static class MFAttributesClsid
    {
#if NOT_IN_USE

    #region Audio Renderer Attributes

        /// <summary>
        /// Specifies the identifier for the audio endpoint device. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Wide-character string
        /// </summary>
        /// <remarks>
        /// You can use this attribute to configure the audio renderer. The usage depends on which function you
        /// call to create the audio renderer:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateAudioRenderer"/>: Set this attribute using the 
        /// <see cref="IMFAttributes"/> interface pointer specified in the <em>pAudioAttributes</em> parameter.
        /// </para><para>* <see cref="MFExtern.MFCreateAudioRendererActivate"/>: Set this attribute using the 
        /// <see cref="IMFActivate"/> interface pointer retrieved in the <em>ppActivate</em> parameter. Set the
        /// attribute before calling <see cref="IMFActivate.ActivateObject"/>. </para>
        /// <para/>
        /// An audio endpoint device is a hardware device that lies at one end of an audio data path, such as a
        /// headphone or a speaker. To obtain the audio endpoint identifier, use the following core audio APIs:
        /// <para/>
        /// <para>*  Use the <c>IMMDeviceEnumerator</c> interface to enumerate the devices on the system. 
        /// </para><para>*  Call <c>IMMDevice::GetId</c> to get the identifier for the device. </para>
        /// <para/>
        /// For more information, see the <c>Core Audio</c> API documentation. If this attribute is not set,
        /// the audio renderer uses the default endpoint device. 
        /// <para/>
        /// If this attribute is set, do not set the 
        /// <see cref="MFAttributesClsid.MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ROLE"/> attribute. If both
        /// attributes are set, a failure will occur when the audio renderer is created. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F145FB80-C136-421C-9A65-E69C52109348(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F145FB80-C136-421C-9A65-E69C52109348(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ID = new Guid(0xb10aaec3, 0xef71, 0x4cc3, 0xb8, 0x73, 0x5, 0xa9, 0xa0, 0x8b, 0x9f, 0x8e);
        /// <summary>
        /// Specifies the audio endpoint role for the audio renderer. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// You can use this attribute to configure the audio renderer. The usage depends on which function you
        /// call to create the audio renderer:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateAudioRenderer"/>: Set this attribute using the 
        /// <see cref="IMFAttributes"/> interface pointer specified in the <em>pAudioAttributes</em> parameter.
        /// </para><para>* <see cref="MFExtern.MFCreateAudioRendererActivate"/>: Set this attribute using the 
        /// <see cref="IMFActivate"/> interface pointer retrieved in the <em>ppActivate</em> parameter. Set the
        /// attribute before calling <see cref="IMFActivate.ActivateObject"/>. </para>
        /// <para/>
        /// An audio endpoint device is a hardware device that lies at one end of an audio data path, such as a
        /// headphone or a speaker.
        /// <para/>
        /// If this attribute is set, the audio renderer uses the default audio device for the specified role.
        /// The value of this attribute is a member of the <strong>ERole</strong> enumeration, which is defined
        /// in the header file mmdeviceapi.h. For more information, see the Core Audio API documentation. If
        /// this attribute is not set, the audio renderer uses the default endpoint device. 
        /// <para/>
        /// If this attribute is set, do not set the 
        /// <see cref="MFAttributesClsid.MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ID"/> attribute. If both
        /// attributes are set, a failure will occur when the audio renderer is created. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F0456337-5351-457E-9830-920BF346BFC4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F0456337-5351-457E-9830-920BF346BFC4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_ENDPOINT_ROLE = new Guid(0x6ba644ff, 0x27c5, 0x4d02, 0x98, 0x87, 0xc2, 0x86, 0x19, 0xfd, 0xb9, 0x1b);
        /// <summary>
        /// Contains flags to configure the audio renderer. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a bitwise <strong>OR</strong> of the following flags. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term><strong>MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_CROSSPROCESS</strong></term><description>The audio renderer is uses a cross-process audio session. This flag enables audio renderers in multiple processes to share the same audio session, along with the associated volume and policy controls.If this flag is not set, the audio session cannot be shared by audio renderers in other processes.</description></item>
        /// <item><term><strong>MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS_NOPERSIST</strong></term><description>The Windows audio session API (WASAPI) will not persist the properties for this audio session, such as the session volume.If this flag is not set, WASAPI will persist the audio session properties.</description></item>
        /// </list>
        /// <para/>
        /// You can use this attribute to configure the audio renderer. The usage depends on which function you
        /// call to create the audio renderer:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateAudioRenderer"/>: Set this attribute using the 
        /// <see cref="IMFAttributes"/> interface pointer specified in the <em>pAudioAttributes</em> parameter.
        /// </para><para>* <see cref="MFExtern.MFCreateAudioRendererActivate"/>: Set this attribute using the 
        /// <see cref="IMFActivate"/> interface pointer retrieved in the <em>ppActivate</em> parameter. Set the
        /// attribute before calling <see cref="IMFActivate.ActivateObject"/>. </para>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/07433904-1BF6-4E8D-9571-8D663BF4FD13(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/07433904-1BF6-4E8D-9571-8D663BF4FD13(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_FLAGS = new Guid(0xede4b5e0, 0xf805, 0x4d6c, 0x99, 0xb3, 0xdb, 0x01, 0xbf, 0x95, 0xdf, 0xab);
        /// <summary>
        /// Specifies the audio policy class for the audio renderer. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// </summary>
        /// <remarks>
        /// This attribute associates the audio renderer with an audio policy class. Each policy class has its
        /// own volume and policy control. If this attribute is not set, the new SAR joins the application's
        /// default audio session. For more information, see <c>IAudioClient::Initialize</c> in the core audio
        /// API documentation. 
        /// <para/>
        /// You can use this attribute to configure the audio renderer. The usage depends on which function you
        /// call to create the audio renderer:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateAudioRenderer"/>: Set this attribute using the 
        /// <see cref="IMFAttributes"/> interface pointer specified in the <em>pAudioAttributes</em> parameter.
        /// </para><para>* <see cref="MFExtern.MFCreateAudioRendererActivate"/>: Set this attribute using the 
        /// <see cref="IMFActivate"/> interface pointer retrieved in the <em>ppActivate</em> parameter. Set the
        /// attribute before calling <see cref="IMFActivate.ActivateObject"/>. </para>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/80B028F5-7756-4BB8-B5E3-EBC8343E168C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/80B028F5-7756-4BB8-B5E3-EBC8343E168C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_SESSION_ID = new Guid(0xede4b5e3, 0xf805, 0x4d6c, 0x99, 0xb3, 0xdb, 0x01, 0xbf, 0x95, 0xdf, 0xab);

        #endregion

    #region Byte Stream Attributes

        /// <summary>
        /// Specifies the original URL for a byte stream. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Wide-character string
        /// </summary>
        /// <remarks>
        /// File-based byte streams can support this attribute. The attribute value is set when the byte stream
        /// is created. To get the attribute value, query the byte stream object for the 
        /// <see cref="IMFAttributes"/> interface. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/31D7DE71-5BBB-4C29-8CE0-DF3684C56916(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/31D7DE71-5BBB-4C29-8CE0-DF3684C56916(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_BYTESTREAM_ORIGIN_NAME = new Guid(0xfc358288, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a);
        /// <summary>
        /// Specifies the MIME type of a byte stream. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Wide-character string
        /// </summary>
        /// <remarks>
        /// To get the attribute value, query the byte stream object for the <see cref="IMFAttributes"/>
        /// interface. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BCF86ECE-2673-4ED8-98FD-CD0E2154B4A8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BCF86ECE-2673-4ED8-98FD-CD0E2154B4A8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_BYTESTREAM_CONTENT_TYPE = new Guid(0xfc358289, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a);
        /// <summary>
        /// Specifies the duration of a byte stream, in 100-nanosecond units. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// Treat as a <strong>LONGLONG</strong> value. 
        /// </summary>
        /// <remarks>
        /// This attribute is optional. If the object that creates the byte stream can determine the duration,
        /// it can set this attribute. (For example, in a network stream, the duration might be part of the
        /// session description.)
        /// <para/>
        /// To get the attribute value, call <strong>QueryInterface</strong> on the byte stream to get a
        /// pointer to the <see cref="IMFAttributes"/> interface. 
        /// <para/>
        /// This attribute is a signed value, although it is stored as a <strong>UINT64</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AFA4930C-544B-4D66-94FE-9795BB526E0A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AFA4930C-544B-4D66-94FE-9795BB526E0A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_BYTESTREAM_DURATION = new Guid(0xfc35828a, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a);
        /// <summary>
        /// Specifies when a byte stream was last modified. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// This attribute is optional. The value of the attribute is a <c>FILETIME</c> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DCEFF922-44EB-478F-842A-8AC0E73A02EE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DCEFF922-44EB-478F-842A-8AC0E73A02EE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_BYTESTREAM_LAST_MODIFIED_TIME = new Guid(0xfc35828b, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a);
        /// <summary>
        /// Contains the URL of the IFO (DVD Information) file specified by the HTTP server in the HTTP header,
        /// "Pragma: ifoFileURI.dlna.org". 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>LPWSTR</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetString"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetString"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFByteStream"/>
        /// </summary>
        /// <remarks>
        /// The HTTP byte stream searches the HTTP header  for the "ifoFileURI.dlna.org" string. If the string
        /// is found, it is copied to this attribute on the byte stream.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/007E0F4D-FB37-4DEC-96A7-311DF567EB04(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/007E0F4D-FB37-4DEC-96A7-311DF567EB04(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_BYTESTREAM_IFO_FILE_URI = new Guid(0xfc35828c, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a);
        /// <summary>
        /// The DLNA Profile ID of the content that is being downloaded.
        /// <para/>
        /// Data type: <strong>LPWSTR</strong>
        /// </summary>
        public static readonly Guid MF_BYTESTREAM_DLNA_PROFILE_ID = new Guid(0xfc35828d, 0x3cb6, 0x460c, 0xa4, 0x24, 0xb6, 0x68, 0x12, 0x60, 0x37, 0x5a);
        /// <summary>
        /// Gets the effective URL of a byte stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetString"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetString"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFByteStream"/>
        /// </summary>
        /// <remarks>
        /// The effective URL can differ from the original URL if the original URL contains any extra
        /// information, such as search strings or anchors, or if the request was redirected.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0A83CFC0-7EAA-464B-BA39-50DF220AF683(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0A83CFC0-7EAA-464B-BA39-50DF220AF683(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_BYTESTREAM_EFFECTIVE_URL = new Guid(0x9afa0209, 0x89d1, 0x42af, 0x84, 0x56, 0x1d, 0xe6, 0xb5, 0x62, 0xd6, 0x91);
        /// <summary>
        /// Indicates that the data in the byte stream is the result of a transcoding operation.
        /// <para/>
        /// Data type: <strong>UINT32</strong> (treat as BOOL).
        /// </summary>
        public static readonly Guid MF_BYTESTREAM_TRANSCODED = new Guid(0xb6c5c282, 0x4dc9, 0x4db9, 0xab, 0x48, 0xcf, 0x3b, 0x6d, 0x8b, 0xc5, 0xe0);

        #endregion

    #region Enhanced Video Renderer Attributes

        /// <summary>
        /// Specifies an activation object that creates a custom video mixer for the enhanced video renderer
        /// (EVR) media sink. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/60484F87-7588-4B52-93AA-EF8FAD66D971(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/60484F87-7588-4B52-93AA-EF8FAD66D971(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_MIXER_ACTIVATE = new Guid(0xba491361, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8);
        /// <summary>
        /// CLSID of a custom video mixer for the enhanced video renderer (EVR) media sink. 
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
        /// <a href="http://msdn.microsoft.com/en-US/library/A3586E6F-A2A2-4932-8B43-A076F64C5958(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A3586E6F-A2A2-4932-8B43-A076F64C5958(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_MIXER_CLSID = new Guid(0xba491360, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8);
        /// <summary>
        /// Specifies how to create a custom mixer for the enhanced video renderer (EVR). 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// You can set this attribute on the <see cref="IMFActivate"/> pointer obtained from the 
        /// <see cref="MFExtern.MFCreateVideoRendererActivate"/> function. The value of this attribute is a
        /// bitwise <strong>OR</strong> of the following values. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term><strong>MF_ACTIVATE_CUSTOM_MIXER_ALLOWFAIL</strong></term><description>If the <see cref="IMFActivate.ActivateObject"/> method fails to create the application's custom mixer, it uses the default EVR mixer instead. By default, if the <see cref="IMFActivate"/> object fails when it tries to create the custom mixer, the <strong>ActivateObject</strong> method fails. </description></item>
        /// </list>
        /// <para/>
        /// Applications can use the <see cref="MFAttributesClsid.MF_ACTIVATE_CUSTOM_VIDEO_MIXER_CLSID"/>
        /// attribute to specify a custom mixer for the EVR. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/00E65718-885F-4E1F-9B06-66C7F5786851(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/00E65718-885F-4E1F-9B06-66C7F5786851(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_MIXER_FLAGS = new Guid(0xba491362, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8);
        /// <summary>
        /// Specifies an activation object that creates a custom video presenter for the enhanced video
        /// renderer (EVR) media sink. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/65D88832-0969-4D85-BEE2-FD0AA68E9F3B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/65D88832-0969-4D85-BEE2-FD0AA68E9F3B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_ACTIVATE = new Guid(0xba491365, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8);
        /// <summary>
        /// CLSID of a custom video presenter for the enhanced video renderer (EVR) media sink. 
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
        /// <a href="http://msdn.microsoft.com/en-US/library/F035EE56-7582-45D3-BAFE-DD9C821B6326(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F035EE56-7582-45D3-BAFE-DD9C821B6326(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_CLSID = new Guid(0xba491364, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8);
        /// <summary>
        /// Specifies how to create a custom presenter for the enhanced video renderer (EVR). 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// You can set this attribute on the <see cref="IMFActivate"/> pointer obtained from the 
        /// <see cref="MFExtern.MFCreateVideoRendererActivate"/> function. The value of this attribute is a
        /// bitwise <strong>OR</strong> of the following values. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term><strong>MF_ACTIVATE_CUSTOM_PRESENTER_ALLOWFAIL</strong></term><description>If the <see cref="IMFActivate.ActivateObject"/> method fails to create the application's custom presenter, it uses the default EVR presenter instead. By default, if the <see cref="IMFActivate"/> object fails when it tries to create the custom presenter, the <strong>ActivateObject</strong> method fails. </description></item>
        /// </list>
        /// <para/>
        /// Applications can use the <see cref="MFAttributesClsid.MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_CLSID"/>
        /// attribute to specify a custom presenter for the EVR. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/40893E13-BF2E-4424-AE43-2B253FC0B622(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/40893E13-BF2E-4424-AE43-2B253FC0B622(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_ACTIVATE_CUSTOM_VIDEO_PRESENTER_FLAGS = new Guid(0xba491366, 0xbe50, 0x451e, 0x95, 0xab, 0x6d, 0x4a, 0xcc, 0xc7, 0xda, 0xd8);
        /// <summary>
        /// Handle to the video clipping window. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// Treat as <strong>DWORD_PTR</strong> ( <strong>HWND</strong>). 
        /// </summary>
        /// <remarks>
        /// This attribute applies to the activation object for the enhanced video renderer (EVR). The value is
        /// set automatically when you call <see cref="MFExtern.MFCreateVideoRendererActivate"/> to create the
        /// EVR activation object. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/883BC7CF-F52F-4CB5-A942-B42B429B17A9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/883BC7CF-F52F-4CB5-A942-B42B429B17A9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_ACTIVATE_VIDEO_WINDOW = new Guid(0x9a2dbbdd, 0xf57e, 0x4162, 0x82, 0xb9, 0x68, 0x31, 0x37, 0x76, 0x82, 0xd3);
        /// <summary>
        /// Indicates the number of uncompressed buffers that the enhanced video renderer (EVR) media sink
        /// requires for deinterlacing. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B62BFF64-153F-4028-A546-250419DC4152(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B62BFF64-153F-4028-A546-250419DC4152(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SA_REQUIRED_SAMPLE_COUNT = new Guid(0x18802c61, 0x324b, 0x4952, 0xab, 0xd0, 0x17, 0x6f, 0xf5, 0xc6, 0x96, 0xff);
        /// <summary>
        /// Indicates the number of samples that a Microsoft Media Foundation transform (MFT) requires to be
        /// allocated for progressive content.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This value is used if the next node downstream has an <see cref="IMFVideoSampleAllocator"/>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/69F9EA59-41B4-4DE5-A77D-1D0E59BFBF3A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/69F9EA59-41B4-4DE5-A77D-1D0E59BFBF3A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SA_REQUIRED_SAMPLE_COUNT_PROGRESSIVE = new Guid(0xb172d58e, 0xfa77, 0x4e48, 0x8d, 0x2a, 0x1d, 0xf2, 0xd8, 0x50, 0xea, 0xc2);
        /// <summary>
        /// Specifies the maximum number of output samples that a Microsoft Media Foundation transform (MFT)
        /// will have outstanding in the pipeline at any time.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/53D393B4-BFF1-430F-9CD1-5071336E6F04(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/53D393B4-BFF1-430F-9CD1-5071336E6F04(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT = new Guid(0x851745d5, 0xc3d6, 0x476d, 0x95, 0x27, 0x49, 0x8e, 0xf2, 0xd1, 0xd, 0x18);
        /// <summary>
        /// Indicates the minimum number of progressive samples that the Microsoft Media Foundation transform
        /// (MFT) should allow to be oustanding at any given time.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C1F27F39-FADA-4644-ACD6-B02EAD9CFFE7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C1F27F39-FADA-4644-ACD6-B02EAD9CFFE7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SA_MINIMUM_OUTPUT_SAMPLE_COUNT_PROGRESSIVE = new Guid(0xf5523a5, 0x1cb2, 0x47c5, 0xa5, 0x50, 0x2e, 0xeb, 0x84, 0xb4, 0xd1, 0x4a);
        /// <summary>
        /// Specifies the source rectangle for video mixer of the <c>Enhanced Video Renderer</c> (EVR). The
        /// source rectangle is the portion of the video frame that the mixer blits to the destination surface.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4364FF87-816E-4B64-B5E9-C53DD6C9BB33(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4364FF87-816E-4B64-B5E9-C53DD6C9BB33(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid VIDEO_ZOOM_RECT = new Guid(0x7aaa1638, 0x1b7f, 0x4c93, 0xbd, 0x89, 0x5b, 0x9c, 0x9f, 0xb6, 0xfc, 0xf0);

        #endregion

    #region Event Attributes

        /// <summary>
        /// MEStreamSinkFormatChanged attribute used when the event source is from the SAR.
        /// <para/>
        /// <strong>Note:</strong> only inbox SAR should set this attribute on MEStreamSinkFormatChanged event.
        /// <para/>
        /// Data type: <strong>UINT32</strong>
        /// </summary>
        [Obsolete]
        public static readonly Guid MF_EVENT_FORMAT_CHANGE_REQUEST_SOURCE_SAR = new Guid(0xb26fbdfd, 0xc32c, 0x41fe, 0x9c, 0xf0, 0x8, 0x3c, 0xd5, 0xc7, 0xf8, 0xa4);

        // MF_EVENT_DO_THINNING {321EA6FB-DAD9-46e4-B31D-D2EAE7090E30}
        /// <summary>
        /// When a media source requests a new playback rate, this attribute specifies whether the source also
        /// requests thinning. For a definition of thinning, see <c>About Rate Control</c>. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute is used with the <c>MESourceRateChangeRequested</c> event. If the value is <strong>
        /// TRUE</strong>, the media source is requesting a switch to thinned playback. 
        /// <para/>
        /// The default value is <strong>FALSE</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/42B6D0B3-E5AF-4A48-969C-53628D1B7C31(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/42B6D0B3-E5AF-4A48-969C-53628D1B7C31(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_DO_THINNING = new Guid(0x321ea6fb, 0xdad9, 0x46e4, 0xb3, 0x1d, 0xd2, 0xea, 0xe7, 0x9, 0xe, 0x30);

        // MF_EVENT_OUTPUT_NODE {830f1a8b-c060-46dd-a801-1c95dec9b107}
        /// <summary>
        /// Identifies the topology node for a stream sink.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// Treat as <c>TOPOID</c>. 
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a node identifier for an output node on the current topology. To get
        /// a pointer to the associated node, call <see cref="IMFTopology.GetNodeByID"/> on the topology. 
        /// <para/>
        /// This attribute is used with the following events:
        /// <para/>
        /// <para>* <c>MESessionStreamSinkFormatChanged</c></para><para>* <c>MESinkInvalidated</c></para>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9AA6CA66-5122-4D05-94B9-32BE194E9EB3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9AA6CA66-5122-4D05-94B9-32BE194E9EB3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_OUTPUT_NODE = new Guid(0x830f1a8b, 0xc060, 0x46dd, 0xa8, 0x01, 0x1c, 0x95, 0xde, 0xc9, 0xb1, 0x07);

        // MF_EVENT_MFT_INPUT_STREAM_ID {F29C2CCA-7AE6-42d2-B284-BF837CC874E2}
        /// <summary>
        /// Specifies an input stream on a Media Foundation transform (MFT).
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// The value is an input stream identifier.
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaEvent"/>
        /// </summary>
        /// <remarks>
        /// This attribute is used with the following events:
        /// <para/>
        /// <para>* <c>METransformDrainComplete</c></para><para>* <c>METransformNeedInput</c></para>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2922AF62-3FCC-4153-A26A-ABA3C4121A0B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2922AF62-3FCC-4153-A26A-ABA3C4121A0B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_MFT_INPUT_STREAM_ID = new Guid(0xf29c2cca, 0x7ae6, 0x42d2, 0xb2, 0x84, 0xbf, 0x83, 0x7c, 0xc8, 0x74, 0xe2);

        // MF_EVENT_MFT_CONTEXT {B7CD31F1-899E-4b41-80C9-26A896D32977}
        /// <summary>
        /// Contains a caller-defined value for an <c>METransformMarker</c> event. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>ULONG_PTR</strong> stored as <strong>UINT64</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT64"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT64"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaEvent"/>
        /// </summary>
        /// <remarks>
        /// This attribute is used with the <c>METransformMarker</c> event. The value of the attribute is taken
        /// from the <em>ulParam</em> parameter of the <see cref="Transform.IMFTransform.ProcessMessage"/>
        /// method. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C6AB20D9-C2BC-43BA-A018-2C6682BF0485(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C6AB20D9-C2BC-43BA-A018-2C6682BF0485(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_MFT_CONTEXT = new Guid(0xb7cd31f1, 0x899e, 0x4b41, 0x80, 0xc9, 0x26, 0xa8, 0x96, 0xd3, 0x29, 0x77);

        // MF_EVENT_PRESENTATION_TIME_OFFSET {5AD914D1-9B45-4a8d-A2C0-81D1E50BFB07}
        /// <summary>
        /// Offset between the presentation time and the media source's time stamps. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// </summary>
        /// <remarks>
        /// The offset is calculated as follows: offset = presentation time ? source time. This attribute is
        /// used with the following events:
        /// <para/>
        /// <para>* <c>MESessionNotifyPresentationTime</c></para><para>* <c>MESessionStarted</c></para>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/450F3C39-063E-4BF3-838A-0F7C240D6647(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/450F3C39-063E-4BF3-838A-0F7C240D6647(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_PRESENTATION_TIME_OFFSET = new Guid(0x5ad914d1, 0x9b45, 0x4a8d, 0xa2, 0xc0, 0x81, 0xd1, 0xe5, 0xb, 0xfb, 0x7);

        // MF_EVENT_SCRUBSAMPLE_TIME {9AC712B3-DCB8-44d5-8D0C-37455A2782E3}
        /// <summary>
        /// Presentation time for a sample that was rendered while scrubbing. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// Treat as a <strong>LONGLONG</strong> value. 
        /// </summary>
        /// <remarks>
        /// This attribute is used with the <c>MEStreamSinkScrubSampleComplete</c> event. 
        /// <para/>
        /// This attribute is a signed value, although it is stored as a <strong>UINT64</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6CE52CF5-014B-49A2-ABF7-2C9CC5340A42(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6CE52CF5-014B-49A2-ABF7-2C9CC5340A42(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_SCRUBSAMPLE_TIME = new Guid(0x9ac712b3, 0xdcb8, 0x44d5, 0x8d, 0xc, 0x37, 0x45, 0x5a, 0x27, 0x82, 0xe3);

        // MF_EVENT_SESSIONCAPS {7E5EBCD0-11B8-4abe-AFAD-10F6599A7F42}
        /// <summary>
        /// Contains flags that define the capabilities of the Media Session, based on the current
        /// presentation. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute contains a bitwise <strong>OR</strong> of zero or more flags. For a list of possible
        /// flags, see <see cref="IMFMediaSession.GetSessionCapabilities"/>. 
        /// <para/>
        /// This attribute is used with the <c>MESessionCapabilitiesChanged</c> event. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A78A3F3F-4BA1-41F3-B808-43F1E4975BB9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A78A3F3F-4BA1-41F3-B808-43F1E4975BB9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_SESSIONCAPS = new Guid(0x7e5ebcd0, 0x11b8, 0x4abe, 0xaf, 0xad, 0x10, 0xf6, 0x59, 0x9a, 0x7f, 0x42);

        // MF_EVENT_SESSIONCAPS_DELTA {7E5EBCD1-11B8-4abe-AFAD-10F6599A7F42}
        // Type: UINT32
        /// <summary>
        /// Contains flags that indicate which capabilities have changed in the Media Session, based on the
        /// current presentation. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute contains a bitmask indicating which capabilities flags have changed. For a list of
        /// possible flags, see <see cref="IMFMediaSession.GetSessionCapabilities"/>. Bits are set to 1 in the
        /// bitmask for any of the following reasons: 
        /// <para/>
        /// <para>*  The corresponding capabilities bit changed from 0 to 1. </para><para>*  The corresponding
        /// capabilities bit changed from 1 to 0. </para><para>*  The corresponding capabilities bit remained
        /// 1, but the details of the capability changed. For example, the maximum playback rate changed. 
        /// </para>
        /// <para/>
        /// This attribute is used with the <c>MESessionCapabilitiesChanged</c> event. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AA01D17F-F2AC-4504-B278-3EDD90AB8A23(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AA01D17F-F2AC-4504-B278-3EDD90AB8A23(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_SESSIONCAPS_DELTA = new Guid(0x7e5ebcd1, 0x11b8, 0x4abe, 0xaf, 0xad, 0x10, 0xf6, 0x59, 0x9a, 0x7f, 0x42);

        // MF_EVENT_SOURCE_ACTUAL_START {a8cc55a9-6b31-419f-845d-ffb351a2434b}
        /// <summary>
        /// Contains the start time at which a media source restarts from its current position. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// Treat as a <strong>LONGLONG</strong> value. 
        /// </summary>
        /// <remarks>
        /// This attribute is used with the <c>MESourceStarted</c> event. The attribute is relevant when the
        /// event data is empty ( <strong>VT_EMPTY</strong>), which indicates that the media source started
        /// from the current playback position. In that case, the <strong>MF_EVENT_SOURCE_ACTUAL_START</strong>
        /// attribute specifies the actual starting time. If the event data is <strong>VT_EMPTY</strong> and
        /// this attribute is not set, the starting time is assumed to be zero. 
        /// <para/>
        /// When the <c>MESourceStarted</c> event data contains the start time ( <strong>VT_I8</strong>), this
        /// attribute should not be set. 
        /// <para/>
        /// This attribute is a signed value, although it is stored as a <strong>UINT64</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B598B4D1-40E1-4282-B312-5AA6CA3A6733(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B598B4D1-40E1-4282-B312-5AA6CA3A6733(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_SOURCE_ACTUAL_START = new Guid(0xa8cc55a9, 0x6b31, 0x419f, 0x84, 0x5d, 0xff, 0xb3, 0x51, 0xa2, 0x43, 0x4b);

        // MF_EVENT_SOURCE_CHARACTERISTICS {47DB8490-8B22-4f52-AFDA-9CE1B2D3CFA8}
        /// <summary>
        /// Specifies the current characteristics of the media source. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a bitwise <strong>OR</strong> of flags from the 
        /// <see cref="MFMediaSourceCharacteristics"/> enumeration. 
        /// <para/>
        /// This attribute is used with the <c>MESourceCharacteristicsChanged</c> event. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AF2A2B75-CD4E-453C-876E-3BE2DB695E4E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AF2A2B75-CD4E-453C-876E-3BE2DB695E4E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_SOURCE_CHARACTERISTICS = new Guid(0x47db8490, 0x8b22, 0x4f52, 0xaf, 0xda, 0x9c, 0xe1, 0xb2, 0xd3, 0xcf, 0xa8);

        // MF_EVENT_SOURCE_CHARACTERISTICS_OLD {47DB8491-8B22-4f52-AFDA-9CE1B2D3CFA8}
        /// <summary>
        /// Specifies the previous characteristics of the media source. The attribute data is a bitwise 
        /// <strong>OR</strong> of flags from the <see cref="MFMediaSourceCharacteristics"/> enumeration. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute is used with the <c>MESourceCharacteristicsChanged</c> event. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9779F350-60D5-4129-BADA-0C4A58F93E6A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9779F350-60D5-4129-BADA-0C4A58F93E6A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_SOURCE_CHARACTERISTICS_OLD = new Guid(0x47db8491, 0x8b22, 0x4f52, 0xaf, 0xda, 0x9c, 0xe1, 0xb2, 0xd3, 0xcf, 0xa8);

        // MF_EVENT_SOURCE_FAKE_START {a8cc55a7-6b31-419f-845d-ffb351a2434b}
        /// <summary>
        /// Specifies whether the current segment topology is empty. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute is used with the <c>MESourceStarted</c> event. 
        /// <para/>
        /// The sequencer source sets this attribute to <strong>TRUE</strong> if the current segment topology
        /// is empty. If this attribute is <strong>TRUE</strong>, playback has not started yet. The default
        /// value of this attribute is <strong>FALSE</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EFD497DC-AFFC-4453-975C-09C5DCA06374(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EFD497DC-AFFC-4453-975C-09C5DCA06374(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_SOURCE_FAKE_START = new Guid(0xa8cc55a7, 0x6b31, 0x419f, 0x84, 0x5d, 0xff, 0xb3, 0x51, 0xa2, 0x43, 0x4b);

        // MF_EVENT_SOURCE_PROJECTSTART {a8cc55a8-6b31-419f-845d-ffb351a2434b}
        /// <summary>
        /// Specifies the start time for a segment topology. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// Treat as a <strong>LONGLONG</strong> value. 
        /// </summary>
        /// <remarks>
        /// This attribute is used with the <c>MESourceStarted</c> event. The sequencer source sets this
        /// attribute when the current segment topology has the 
        /// <see cref="MFAttributesClsid.MF_TOPOLOGY_PROJECTSTART"/> attribute. The two attributes have the
        /// same value. 
        /// <para/>
        /// This attribute is a signed value, although it is stored as a <strong>UINT64</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D8902FB6-C758-4D3D-9230-E918948BDA19(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D8902FB6-C758-4D3D-9230-E918948BDA19(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_SOURCE_PROJECTSTART = new Guid(0xa8cc55a8, 0x6b31, 0x419f, 0x84, 0x5d, 0xff, 0xb3, 0x51, 0xa2, 0x43, 0x4b);

        // MF_EVENT_SOURCE_TOPOLOGY_CANCELED {DB62F650-9A5E-4704-ACF3-563BC6A73364}
        /// <summary>
        /// Specifies whether the <c>Sequencer Source</c> canceled a topology. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute is used with the following events:
        /// <para/>
        /// <para>* <c>MEEndOfPresentationSegment</c></para><para>* <c>MEEndOfPresentation</c></para>
        /// <para/>
        /// If this attribute is present and nonzero, it means that the presentation segment ended because the
        /// sequencer source canceled the topology. Otherwise, the presentation segment ended normally.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B7252336-1612-43FC-8F08-1FDFDBB293EB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B7252336-1612-43FC-8F08-1FDFDBB293EB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_SOURCE_TOPOLOGY_CANCELED = new Guid(0xdb62f650, 0x9a5e, 0x4704, 0xac, 0xf3, 0x56, 0x3b, 0xc6, 0xa7, 0x33, 0x64);

        // MF_EVENT_START_PRESENTATION_TIME {5AD914D0-9B45-4a8d-A2C0-81D1E50BFB07}
        /// <summary>
        /// The starting time for the presentation, in 100-nanosecond units, as measured by the presentation
        /// clock. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// Treat as a <strong>LONGLONG</strong> value. 
        /// </summary>
        /// <remarks>
        /// This attribute is used with the <c>MESessionNotifyPresentationTime</c> event. 
        /// <para/>
        /// This attribute is a signed value, although it is stored as a <strong>UINT64</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D19D851C-AB4A-4A9D-BCC4-8DD4E993FA2C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D19D851C-AB4A-4A9D-BCC4-8DD4E993FA2C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_START_PRESENTATION_TIME = new Guid(0x5ad914d0, 0x9b45, 0x4a8d, 0xa2, 0xc0, 0x81, 0xd1, 0xe5, 0xb, 0xfb, 0x7);

        // MF_EVENT_START_PRESENTATION_TIME_AT_OUTPUT {5AD914D2-9B45-4a8d-A2C0-81D1E50BFB07}
        /// <summary>
        /// The presentation time at which the media sinks will render the first sample of the new topology. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// Treat as a <strong>LONGLONG</strong> value. 
        /// </summary>
        /// <remarks>
        /// If any pipeline objects in the previous topology buffered data, this value will be slightly less
        /// than the value in the <see cref="MFAttributesClsid.MF_EVENT_PRESENTATION_TIME_OFFSET"/> attribute,
        /// because the sinks must render the buffered data. 
        /// <para/>
        /// This attribute is a signed value, although it is stored as a <strong>UINT64</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/02A8C542-B519-495E-9FB2-8DB2F5384DB7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/02A8C542-B519-495E-9FB2-8DB2F5384DB7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_START_PRESENTATION_TIME_AT_OUTPUT = new Guid(0x5ad914d2, 0x9b45, 0x4a8d, 0xa2, 0xc0, 0x81, 0xd1, 0xe5, 0xb, 0xfb, 0x7);

        // MF_EVENT_TOPOLOGY_STATUS {30C5018D-9A53-454b-AD9E-6D5F8FA7C43B}
        /// <summary>
        /// Specifies the status of a topology during playback. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a member of the <see cref="MFTopoStatus"/> enumeration. 
        /// <para/>
        /// This attribute is used with the <c>MESessionTopologyStatus</c> event. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F7C93BAD-1A64-45B0-AB5C-6EDEA4A1C0D1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F7C93BAD-1A64-45B0-AB5C-6EDEA4A1C0D1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_TOPOLOGY_STATUS = new Guid(0x30c5018d, 0x9a53, 0x454b, 0xad, 0x9e, 0x6d, 0x5f, 0x8f, 0xa7, 0xc4, 0x3b);

        // MF_EVENT_STREAM_METADATA_KEYDATA {CD59A4A1-4A3B-4BBD-8665-72A40FBEA776}
        /// <summary>
        /// Specifies protection system specific data.
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
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302186(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302186(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_STREAM_METADATA_KEYDATA = new Guid(0xcd59a4a1, 0x4a3b, 0x4bbd, 0x86, 0x65, 0x72, 0xa4, 0xf, 0xbe, 0xa7, 0x76);

        // MF_EVENT_STREAM_METADATA_CONTENT_KEYIDS {5063449D-CC29-4FC6-A75A-D247B35AF85C}
        /// <summary>
        /// Specifies the content key IDs.
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
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302185(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302185(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_STREAM_METADATA_CONTENT_KEYIDS = new Guid(0x5063449d, 0xcc29, 0x4fc6, 0xa7, 0x5a, 0xd2, 0x47, 0xb3, 0x5a, 0xf8, 0x5c);

        // MF_EVENT_STREAM_METADATA_SYSTEMID {1EA2EF64-BA16-4A36-8719-FE7560BA32AD}
        /// <summary>
        /// Specifies the system ID for which the key data is intended. 
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
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302187(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302187(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MF_EVENT_STREAM_METADATA_SYSTEMID = new Guid(0x1ea2ef64, 0xba16, 0x4a36, 0x87, 0x19, 0xfe, 0x75, 0x60, 0xba, 0x32, 0xad);

        /// <summary>
        /// The approximate time when the Media Session raised an event. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// Treat as a <strong>LONGLONG</strong> value. 
        /// </summary>
        /// <remarks>
        /// Some events from the Media Session have this attribute. The value gives the approximate
        /// presentation time when the event was raised.
        /// <para/>
        /// This attribute is a signed value, although it is stored as a <strong>UINT64</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/58083BC8-59CC-4503-8FAE-36FCD864921A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/58083BC8-59CC-4503-8FAE-36FCD864921A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SESSION_APPROX_EVENT_OCCURRENCE_TIME = new Guid(0x190e852f, 0x6238, 0x42d1, 0xb5, 0xaf, 0x69, 0xea, 0x33, 0x8e, 0xf8, 0x50);

        #endregion

    #region Media Session Attributes

        /// <summary>
        /// Provides a callback interface for the application to receive a content enabler object from the
        /// protected media path (PMP) session. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a pointer to the application's 
        /// <see cref="IMFContentProtectionManager"/> interface. 
        /// <para/>
        /// Set this attribute on the PMP session by using the <em>pConfiguration</em> parameter of the 
        /// <see cref="MFExtern.MFCreatePMPMediaSession"/> function. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/66482541-63D4-439B-862F-7507605AF5D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/66482541-63D4-439B-862F-7507605AF5D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SESSION_CONTENT_PROTECTION_MANAGER = new Guid(0x1e83d482, 0x1f1c, 0x4571, 0x84, 0x5, 0x88, 0xf4, 0xb2, 0x18, 0x1f, 0x74);
        /// <summary>
        /// Specifies whether topologies have a global start and stop time. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// You can set this attribute when you create the media sesison by using the <em>pConfiguration</em>
        /// parameter of the <see cref="MFExtern.MFCreateMediaSession"/> or 
        /// <see cref="MFExtern.MFCreatePMPMediaSession"/> function. 
        /// <para/>
        /// If this attribute is present and nonzero, then all topologies passed to the Media Session must have
        /// the <see cref="MFAttributesClsid.MF_TOPOLOGY_PROJECTSTART"/> and 
        /// <see cref="MFAttributesClsid.MF_TOPOLOGY_PROJECTSTOP"/> attributes. These attributes specify the
        /// start and stop times for the topology relative to the entire presentation. 
        /// <para/>
        /// If this attribute is absent or <strong>FALSE</strong>, the topologies must not have the 
        /// <see cref="MFAttributesClsid.MF_TOPOLOGY_PROJECTSTART"/> or 
        /// <see cref="MFAttributesClsid.MF_TOPOLOGY_PROJECTSTOP"/> attribute. 
        /// <para/>
        /// Use this attribute to create editing sequences. For more information, see 
        /// <c>Sequence Presentation Times</c>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6810A22C-F091-423C-97DD-C04FDABDB9BB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6810A22C-F091-423C-97DD-C04FDABDB9BB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SESSION_GLOBAL_TIME = new Guid(0x1e83d482, 0x1f1c, 0x4571, 0x84, 0x5, 0x88, 0xf4, 0xb2, 0x18, 0x1f, 0x72);
        /// <summary>
        /// Contains the CLSID of a quality manager for the Media Session. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// </summary>
        /// <remarks>
        /// You can use this attribute to provide a custom quality manager for the Media Session.
        /// <para/>
        /// Set this attribute by using the <em>pConfiguration</em> parameter of the 
        /// <see cref="MFExtern.MFCreateMediaSession"/> or <see cref="MFExtern.MFCreatePMPMediaSession"/>
        /// function. 
        /// <para/>
        /// If this attribute is set, the Media Session calls <strong>CoCreateInstance</strong> with the
        /// specified CLSID to create the quality manager. The object created by this CLSID must expose the 
        /// <see cref="IMFQualityManager"/> interface. 
        /// <para/>
        /// If this attribute is not set, the Media Session creates the default quality manager provided in
        /// Media Foundation.
        /// <para/>
        /// If you want to run the Media Session with no quality manager at all, set this attribute to <strong>
        /// GUID_NULL</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/24B4A5E3-84F1-44D0-A8AC-75C127EC8A8A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/24B4A5E3-84F1-44D0-A8AC-75C127EC8A8A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SESSION_QUALITY_MANAGER = new Guid(0x1e83d482, 0x1f1c, 0x4571, 0x84, 0x5, 0x88, 0xf4, 0xb2, 0x18, 0x1f, 0x73);
        /// <summary>
        /// Specifies that the media source will be created in a remote process. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// You can set this attribute on the protected media path (PMP) session by using the <em>
        /// pConfiguration</em> parameter of the <see cref="MFExtern.MFCreatePMPMediaSession"/> function. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3A2F9FF5-1780-40F3-B36B-3A7CCCB47D05(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3A2F9FF5-1780-40F3-B36B-3A7CCCB47D05(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SESSION_REMOTE_SOURCE_MODE = new Guid(0xf4033ef4, 0x9bb3, 0x4378, 0x94, 0x1f, 0x85, 0xa0, 0x85, 0x6b, 0xc2, 0x44);
        /// <summary>
        /// Enables two instances of the Media Session to share the same Protected Media Path (PMP) process. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// Use this attribute if you want to create the PMP Media Session in an existing PMP process. The
        /// value of the attribute is a pointer to the <see cref="IMFPMPServer"/> interface. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A922C79B-D6C1-447D-B6FA-993970169A3F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A922C79B-D6C1-447D-B6FA-993970169A3F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SESSION_SERVER_CONTEXT = new Guid(0xafe5b291, 0x50fa, 0x46e8, 0xb9, 0xbe, 0xc, 0xc, 0x3c, 0xe4, 0xb3, 0xa5);
        /// <summary>
        /// Contains the CLSID of a topology loader for the Media Session. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// </summary>
        /// <remarks>
        /// You can use this attribute to provide a custom topology loader for the Media Session.
        /// <para/>
        /// Set this attribute using the <em>pConfiguration</em> parameter of the 
        /// <see cref="MFExtern.MFCreateMediaSession"/> function or the 
        /// <see cref="MFExtern.MFCreatePMPMediaSession"/> function. 
        /// <para/>
        /// If this attribute is set, the Media Session calls <strong>CoCreateInstance</strong> with the
        /// specified CLSID when it creates the topology loader. The object created by this CLSID must expose
        /// the <see cref="IMFTopoLoader"/> interface. 
        /// <para/>
        /// If this attribute is not set, the Media Session creates the default topology loader provided in
        /// Media Foundation.
        /// <para/>
        /// A topology loader must support multithreaded apartments. You should register the topology loader as
        /// ThreadingModel="Both". Also, if you are using the topology loader inside the protected media path
        /// (PMP), the topology loader must be a trusted component. For more information, see 
        /// <c>Protected Media Path</c>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/672274FB-71FC-49CA-BAB6-1FC4DE21D17C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/672274FB-71FC-49CA-BAB6-1FC4DE21D17C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SESSION_TOPOLOADER = new Guid(0x1e83d482, 0x1f1c, 0x4571, 0x84, 0x5, 0x88, 0xf4, 0xb2, 0x18, 0x1f, 0x71);

        #endregion

#endif

        #region Media Type Attributes

        // {48eba18e-f8c9-4687-bf11-0a74c9f96a8f}   MF_MT_MAJOR_TYPE                {GUID}
        /// <summary>
        /// Major type GUID for a media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// </summary>
        /// <remarks>
        /// The major type defines the overall category of the media data. Major types include video, audio,
        /// script, and so forth. For a list of possible values, see <c>Major Media Types</c>. 
        /// <para/>
        /// An alternate way to retrieve this attribute is to call <see cref="IMFMediaType.GetMajorType"/>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B88B5FCF-8025-4638-930D-9FC5CF0EC8A3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B88B5FCF-8025-4638-930D-9FC5CF0EC8A3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_MAJOR_TYPE = new Guid(0x48eba18e, 0xf8c9, 0x4687, 0xbf, 0x11, 0x0a, 0x74, 0xc9, 0xf9, 0x6a, 0x8f);

        // {f7e34c9a-42e8-4714-b74b-cb29d72c35e5}   MF_MT_SUBTYPE                   {GUID}
        /// <summary>
        /// Subtype GUID for a media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// </summary>
        /// <remarks>
        /// The subtype GUID defines a specific media format type within a major type. For example, within
        /// video, the subtypes include RGB-24, RGB-32, UYVY, AYUV, and so forth. Within audio, the subtypes
        /// include PCM audio, Windows Media Audio 9, and so forth.
        /// <para/>
        /// For possible values, see the following topics:
        /// <para/>
        /// <para>* <c>Audio Subtype GUIDs</c></para><para>* <c>Video Subtype GUIDs</c></para>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8E600943-92F1-4936-8C00-842FC7F4CB57(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8E600943-92F1-4936-8C00-842FC7F4CB57(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_SUBTYPE = new Guid(0xf7e34c9a, 0x42e8, 0x4714, 0xb7, 0x4b, 0xcb, 0x29, 0xd7, 0x2c, 0x35, 0xe5);

#if NOT_IN_USE

        // {c9173739-5e56-461c-b713-46fb995cb95f}   MF_MT_ALL_SAMPLES_INDEPENDENT   {UINT32 (BOOL)}
        /// <summary>
        /// Specifies for a media type whether each sample is independent of the other samples in the stream. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// If this attribute is <strong>FALSE</strong>, some samples cannot be used without referring to other
        /// samples in the stream. For example, if a video format contains delta frames, this attribute should
        /// be <strong>FALSE</strong>. 
        /// <para/>
        /// This attribute corresponds to the <strong>bTemporalCompression</strong> field in the DirectShow 
        /// <see cref="Misc.AMMediaType"/> structure. 
        /// <para/>
        /// Set this attribute to <strong>TRUE</strong> for all uncompressed media types. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/40434F63-E191-45E1-B788-5F80FE7F49AE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/40434F63-E191-45E1-B788-5F80FE7F49AE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_ALL_SAMPLES_INDEPENDENT = new Guid(0xc9173739, 0x5e56, 0x461c, 0xb7, 0x13, 0x46, 0xfb, 0x99, 0x5c, 0xb9, 0x5f);

        // {b8ebefaf-b718-4e04-b0a9-116775e3321b}   MF_MT_FIXED_SIZE_SAMPLES        {UINT32 (BOOL)}
        /// <summary>
        /// Specifies for a media type whether the samples have a fixed size. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// If this attribute is <strong>TRUE</strong>, every sample in the stream is the same size (in bytes).
        /// Otherwise, samples might vary in size. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2D67864A-FD2F-400D-8A1E-E71DC1920593(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2D67864A-FD2F-400D-8A1E-E71DC1920593(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_FIXED_SIZE_SAMPLES = new Guid(0xb8ebefaf, 0xb718, 0x4e04, 0xb0, 0xa9, 0x11, 0x67, 0x75, 0xe3, 0x32, 0x1b);

        // {3afd0cee-18f2-4ba5-a110-8bea502e1f92}   MF_MT_COMPRESSED                {UINT32 (BOOL)}
        /// <summary>
        /// Specifies for a media type whether the media data is compressed. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// If this attribute is <strong>TRUE</strong>, the media type is a compressed format. Otherwise,
        /// either the media type is uncompressed or the compression type is not known. 
        /// <para/>
        /// This attribute is not guaranteed to be set to <strong>TRUE</strong> for all compressed formats, so
        /// applications should generally not rely this attribute. The most reliable way to determine whether a
        /// format is compressed is to maintain a list of known formats. If an application does not recognize a
        /// format, as specified in the <see cref="MFAttributesClsid.MF_MT_SUBTYPE"/> attribute, it should not
        /// assume anything about the compression of the format. 
        /// <para/>
        /// To determine whether a format uses temporal compression (meaning that some samples are computed as
        /// deltas from earlier samples), check the 
        /// <see cref="MFAttributesClsid.MF_MT_ALL_SAMPLES_INDEPENDENT"/> attribute. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B44FB757-4390-4392-B1CB-37772B4AE3FB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B44FB757-4390-4392-B1CB-37772B4AE3FB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_COMPRESSED = new Guid(0x3afd0cee, 0x18f2, 0x4ba5, 0xa1, 0x10, 0x8b, 0xea, 0x50, 0x2e, 0x1f, 0x92);

        // {dad3ab78-1990-408b-bce2-eba673dacc10}   MF_MT_SAMPLE_SIZE               {UINT32}
        /// <summary>
        /// Specifies the size of each sample, in bytes, in a media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute is valid only if the <see cref="MFAttributesClsid.MF_MT_FIXED_SIZE_SAMPLES"/>
        /// attribute is <strong>TRUE</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4C28F73D-FF40-4EB9-A45F-57A60DF719C6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4C28F73D-FF40-4EB9-A45F-57A60DF719C6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_SAMPLE_SIZE = new Guid(0xdad3ab78, 0x1990, 0x408b, 0xbc, 0xe2, 0xeb, 0xa6, 0x73, 0xda, 0xcc, 0x10);

        // 4d3f7b23-d02f-4e6c-9bee-e4bf2c6c695d     MF_MT_WRAPPED_TYPE              {Blob}
        /// <summary>
        /// Contains a media type that has been wrapped in another media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3BD94523-0206-44D8-83A2-E569E4AB7815(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3BD94523-0206-44D8-83A2-E569E4AB7815(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_WRAPPED_TYPE = new Guid(0x4d3f7b23, 0xd02f, 0x4e6c, 0x9b, 0xee, 0xe4, 0xbf, 0x2c, 0x6c, 0x69, 0x5d);

        // {37e48bf5-645e-4c5b-89de-ada9e29b696a}   MF_MT_AUDIO_NUM_CHANNELS            {UINT32}
        /// <summary>
        /// Number of audio channels in an audio media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>nChannels</strong> member of the 
        /// <see cref="Misc.WaveFormatEx"/> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/524283FB-D046-4F8C-A30F-4FE7DDB43174(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/524283FB-D046-4F8C-A30F-4FE7DDB43174(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_NUM_CHANNELS = new Guid(0x37e48bf5, 0x645e, 0x4c5b, 0x89, 0xde, 0xad, 0xa9, 0xe2, 0x9b, 0x69, 0x6a);

        // {5faeeae7-0290-4c31-9e8a-c534f68d9dba}   MF_MT_AUDIO_SAMPLES_PER_SECOND      {UINT32}
        /// <summary>
        /// Number of audio samples per second in an audio media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>nSamplesPerSec</strong> member of the 
        /// <see cref="Misc.WaveFormatEx"/> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F640016D-595E-4B20-8CE8-23A029C2B064(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F640016D-595E-4B20-8CE8-23A029C2B064(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_SAMPLES_PER_SECOND = new Guid(0x5faeeae7, 0x0290, 0x4c31, 0x9e, 0x8a, 0xc5, 0x34, 0xf6, 0x8d, 0x9d, 0xba);

        // {fb3b724a-cfb5-4319-aefe-6e42b2406132}   MF_MT_AUDIO_FLOAT_SAMPLES_PER_SECOND {double}
        /// <summary>
        /// Number of audio samples per second in an audio media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>double</strong>
        /// </summary>
        /// <remarks>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9E794F7D-0FB3-4069-8431-62651252517D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9E794F7D-0FB3-4069-8431-62651252517D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_FLOAT_SAMPLES_PER_SECOND = new Guid(0xfb3b724a, 0xcfb5, 0x4319, 0xae, 0xfe, 0x6e, 0x42, 0xb2, 0x40, 0x61, 0x32);

        // {1aab75c8-cfef-451c-ab95-ac034b8e1731}   MF_MT_AUDIO_AVG_BYTES_PER_SECOND    {UINT32}
        /// <summary>
        /// Average number of bytes per second in an audio media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>nAvgBytesPerSec</strong> member of the 
        /// <see cref="Misc.WaveFormatEx"/> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0EE371FB-D980-44DE-A9BD-201E2B72E874(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0EE371FB-D980-44DE-A9BD-201E2B72E874(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_AVG_BYTES_PER_SECOND = new Guid(0x1aab75c8, 0xcfef, 0x451c, 0xab, 0x95, 0xac, 0x03, 0x4b, 0x8e, 0x17, 0x31);

        // {322de230-9eeb-43bd-ab7a-ff412251541d}   MF_MT_AUDIO_BLOCK_ALIGNMENT         {UINT32}
        /// <summary>
        /// Block alignment, in bytes, for an audio media type. The block alignment is the minimum atomic unit
        /// of data for the audio format. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// For PCM audio formats, the block alignment is equal to the number of audio channels multiplied by
        /// the number of bytes per audio sample.
        /// <para/>
        /// This attribute corresponds to the <strong>nBlockAlign</strong> member of the 
        /// <see cref="Misc.WaveFormatEx"/> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7D304826-AD81-4243-A675-2F55B668B348(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7D304826-AD81-4243-A675-2F55B668B348(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_BLOCK_ALIGNMENT = new Guid(0x322de230, 0x9eeb, 0x43bd, 0xab, 0x7a, 0xff, 0x41, 0x22, 0x51, 0x54, 0x1d);

        // {f2deb57f-40fa-4764-aa33-ed4f2d1ff669}   MF_MT_AUDIO_BITS_PER_SAMPLE         {UINT32}
        /// <summary>
        /// Number of bits per audio sample in an audio media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>wBitsPerSample</strong> member of the 
        /// <see cref="Misc.WaveFormatEx"/> structure. 
        /// <para/>
        /// If some bits contain padding, set the 
        /// <see cref="MFAttributesClsid.MF_MT_AUDIO_VALID_BITS_PER_SAMPLE"/> attribute to specify the number
        /// of bits of valid audio data in each sample. 
        /// <para/>
        /// If the audio contains 8 bits per sample, the audio samples are unsigned values. (Each audio sample
        /// has the range 0–255.) If the audio contains 16 bits per sample or higher, the audio samples are
        /// signed values. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D78A8C4D-377E-45EB-9CF6-2D61B34E82D6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D78A8C4D-377E-45EB-9CF6-2D61B34E82D6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_BITS_PER_SAMPLE = new Guid(0xf2deb57f, 0x40fa, 0x4764, 0xaa, 0x33, 0xed, 0x4f, 0x2d, 0x1f, 0xf6, 0x69);

        // {d9bf8d6a-9530-4b7c-9ddf-ff6fd58bbd06}   MF_MT_AUDIO_VALID_BITS_PER_SAMPLE   {UINT32}
        /// <summary>
        /// Number of valid bits of audio data in each audio sample. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The <strong>MF_MT_AUDIO_VALID_BITS_PER_SAMPLE</strong> attribute is used for audio formats that
        /// contain padding after each audio sample. The total size of each audio sample, including padding
        /// bits, is given in the <see cref="MFAttributesClsid.MF_MT_AUDIO_BITS_PER_SAMPLE"/> attribute. 
        /// <para/>
        /// If the <strong>MF_MT_AUDIO_VALID_BITS_PER_SAMPLE</strong> attribute is not set, use the 
        /// <see cref="MFAttributesClsid.MF_MT_AUDIO_BITS_PER_SAMPLE"/> attribute to find the number of valid
        /// bits per sample. 
        /// <para/>
        /// If an audio format does not contain any padding bits, then this attribute should not be set, or
        /// should be set to the same value as the <see cref="MFAttributesClsid.MF_MT_AUDIO_BITS_PER_SAMPLE"/>
        /// attribute. 
        /// <para/>
        /// This attribute corresponds to the <strong>wValidBitsPerSample</strong> member of the 
        /// <see cref="Misc.WaveFormatExtensible"/> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B5B97700-C98A-4394-A184-661852ADD0B4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B5B97700-C98A-4394-A184-661852ADD0B4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_VALID_BITS_PER_SAMPLE = new Guid(0xd9bf8d6a, 0x9530, 0x4b7c, 0x9d, 0xdf, 0xff, 0x6f, 0xd5, 0x8b, 0xbd, 0x06);

        // {aab15aac-e13a-4995-9222-501ea15c6877}   MF_MT_AUDIO_SAMPLES_PER_BLOCK       {UINT32}
        /// <summary>
        /// Number of audio samples contained in one compressed block of audio data. This attribute can be used
        /// in compressed audio formats that have a fixed number of samples within each block. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>wSamplesPerBlock</strong> member of the 
        /// <see cref="Misc.WaveFormatExtensible"/> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6AE31548-4D78-4E38-9CFC-01B611A6022D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6AE31548-4D78-4E38-9CFC-01B611A6022D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_SAMPLES_PER_BLOCK = new Guid(0xaab15aac, 0xe13a, 0x4995, 0x92, 0x22, 0x50, 0x1e, 0xa1, 0x5c, 0x68, 0x77);

        // {55fb5765-644a-4caf-8479-938983bb1588}`  MF_MT_AUDIO_CHANNEL_MASK            {UINT32}
        /// <summary>
        /// In an audio media type, specifies the assignment of audio channels to speaker positions. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>dwChannelMask</strong> member of the 
        /// <see cref="Misc.WaveFormatExtensible"/> structure.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/windows/desktop/ms705633(v=vs.100).aspx">http://msdn.microsoft.com/en-us/windows/desktop/ms705633(v=vs.100).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_CHANNEL_MASK = new Guid(0x55fb5765, 0x644a, 0x4caf, 0x84, 0x79, 0x93, 0x89, 0x83, 0xbb, 0x15, 0x88);

        // {9d62927c-36be-4cf2-b5c4-a3926e3e8711}`  MF_MT_AUDIO_FOLDDOWN_MATRIX         {BLOB, MFFOLDDOWN_MATRIX}
        /// <summary>
        /// Specifies how an audio decoder should transform multichannel audio to stereo output. This process
        /// is also called <em>fold-down</em>. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// This attribute applies to audio media types.
        /// <para/>
        /// The value of this attribute is an <c>MFFOLDDOWN_MATRIX</c> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6DFE2B97-1EBC-4954-B478-85B3BBBA89E3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6DFE2B97-1EBC-4954-B478-85B3BBBA89E3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_FOLDDOWN_MATRIX = new Guid(0x9d62927c, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11);

        // {0x9d62927d-36be-4cf2-b5c4-a3926e3e8711}`  MF_MT_AUDIO_WMADRC_PEAKREF         {UINT32}
        /// <summary>
        /// Reference peak volume level of a Windows Media Audio file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to audio media types for Windows Media Audio codecs. It specifies the
        /// original peak volume level of the content. The decoder can use this value to perform dynamic range
        /// control.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.ParseHeader"/> method adds this attribute to the media type if the
        /// ASF header contains the <c>WM/WMADRCPeakReference</c> attribute. This attribute is documented in
        /// the Windows Media Format SDK documentation. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BB762F9C-CF08-4D32-991E-490EB7B1F579(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BB762F9C-CF08-4D32-991E-490EB7B1F579(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_WMADRC_PEAKREF = new Guid(0x9d62927d, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11);

        // {0x9d62927e-36be-4cf2-b5c4-a3926e3e8711}`  MF_MT_AUDIO_WMADRC_PEAKTARGET        {UINT32}
        /// <summary>
        /// Target peak volume level of a Windows Media Audio file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to audio media types for Windows Media Audio codecs. It specifies the target
        /// peak volume level of the content. The decoder can use this value to perform dynamic range control.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.ParseHeader"/> method adds this attribute to the media type if the
        /// ASF header contains the <c>WM/WMADRCPeakTarget</c> attribute. This attribute is documented in the
        /// Windows Media Format SDK documentation. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/73F4E763-DCB7-48CD-AB80-37635D973DA0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/73F4E763-DCB7-48CD-AB80-37635D973DA0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_WMADRC_PEAKTARGET = new Guid(0x9d62927e, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11);

        // {0x9d62927f-36be-4cf2-b5c4-a3926e3e8711}`  MF_MT_AUDIO_WMADRC_AVGREF         {UINT32}
        /// <summary>
        /// Reference average volume level of a Windows Media Audio file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to audio media types for Windows Media Audio codecs. It specifies the
        /// original average volume level of the content. The decoder can use this value to perform dynamic
        /// range control.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.ParseHeader"/> method adds this attribute to the media type if the
        /// ASF header contains the <c>WM/WMADRCAverageReference</c> attribute. This attribute is documented in
        /// the Windows Media Format SDK documentation. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EA7D4ED1-2A96-4372-9936-ABDD6473B57E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EA7D4ED1-2A96-4372-9936-ABDD6473B57E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_WMADRC_AVGREF = new Guid(0x9d62927f, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11);

        // {0x9d629280-36be-4cf2-b5c4-a3926e3e8711}`  MF_MT_AUDIO_WMADRC_AVGTARGET      {UINT32}
        /// <summary>
        /// Target average volume level of a Windows Media Audio file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to audio media types for Windows Media Audio codecs. It specifies the target
        /// average volume level of the content. The decoder can use this value to perform dynamic range
        /// control.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.ParseHeader"/> method adds this attribute to the media type if the
        /// ASF header contains the <c>WM/WMADRCAverageTarget</c> attribute. This attribute is documented in
        /// the Windows Media Format SDK documentation. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F81158C8-B341-4B39-8FA4-B510C93B89FC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F81158C8-B341-4B39-8FA4-B510C93B89FC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_WMADRC_AVGTARGET = new Guid(0x9d629280, 0x36be, 0x4cf2, 0xb5, 0xc4, 0xa3, 0x92, 0x6e, 0x3e, 0x87, 0x11);

        // {a901aaba-e037-458a-bdf6-545be2074042}   MF_MT_AUDIO_PREFER_WAVEFORMATEX     {UINT32 (BOOL)}
        /// <summary>
        /// Specifies the preferred legacy format structure to use when converting an audio media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute provides a hint to the <see cref="MFExtern.MFCreateWaveFormatExFromMFMediaType"/>
        /// function. If the attribute is <strong>TRUE</strong>, the function converts the audio media type to
        /// a <see cref="Misc.WaveFormatEx"/> structure whenever possible, instead of converting it to a 
        /// <see cref="Misc.WaveFormatExtensible"/> structure. 
        /// <para/>
        /// The <see cref="MFExtern.MFInitMediaTypeFromWaveFormatEx"/> function sets this attribute. You can
        /// override the value of this attribute, but setting this attribute to <strong>TRUE</strong> does not
        /// guarantee that an audio media type can be converted to <see cref="Misc.WaveFormatEx"/> form. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9BB045A2-BE5B-468B-B30B-AEDCB7849945(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9BB045A2-BE5B-468B-B30B-AEDCB7849945(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AUDIO_PREFER_WAVEFORMATEX = new Guid(0xa901aaba, 0xe037, 0x458a, 0xbd, 0xf6, 0x54, 0x5b, 0xe2, 0x07, 0x40, 0x42);

        // {BFBABE79-7434-4d1c-94F0-72A3B9E17188} MF_MT_AAC_PAYLOAD_TYPE       {UINT32}
        /// <summary>
        /// Specifies the payload type of an Advanced Audio Coding (AAC) stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// The following values are possible.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0</term><description>The stream contains raw_data_block elements only.</description></item>
        /// <item><term>1</term><description>Audio Data Transport Stream (ADTS). The stream contains an adts_sequence, as defined by MPEG-2.</description></item>
        /// <item><term>2</term><description>Audio Data Interchange Format (ADIF). The stream contains an adif_sequence, as defined by MPEG-2.</description></item>
        /// <item><term>3</term><description>The stream contains an MPEG-4 audio transport stream with a synchronization layer (LOAS) and a multiplex layer (LATM).</description></item>
        /// </list>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies To </strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A032FCF4-2584-4047-ADBD-D94D4FC4E841(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A032FCF4-2584-4047-ADBD-D94D4FC4E841(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AAC_PAYLOAD_TYPE = new Guid(0xbfbabe79, 0x7434, 0x4d1c, 0x94, 0xf0, 0x72, 0xa3, 0xb9, 0xe1, 0x71, 0x88);

        // {7632F0E6-9538-4d61-ACDA-EA29C8C14456} MF_MT_AAC_AUDIO_PROFILE_LEVEL_INDICATION       {UINT32}
        /// <summary>
        /// Specifies the audio profile and level of an Advanced Audio Coding (AAC) stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies To </strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// This attribute contains the value of the <strong>audioProfileLevelIndication</strong> field, as
        /// defined by ISO/IEC 14496-3. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/87FA1127-46CA-4B83-A3B5-99253AF22BA0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/87FA1127-46CA-4B83-A3B5-99253AF22BA0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AAC_AUDIO_PROFILE_LEVEL_INDICATION = new Guid(0x7632f0e6, 0x9538, 0x4d61, 0xac, 0xda, 0xea, 0x29, 0xc8, 0xc1, 0x44, 0x56);

        // {1652c33d-d6b2-4012-b834-72030849a37d}   MF_MT_FRAME_SIZE                {UINT64 (HI32(Width),LO32(Height))}
        /// <summary>
        /// Width and height of a video frame, in pixels. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// </summary>
        /// <remarks>
        /// The upper 32 bits contain the width and the lower 32 bits contain the height. 
        /// <para/>
        /// To set this attribute, use the <c>MFSetAttributeSize</c> function. To get this attribute, use the 
        /// <c>MFGetAttributeSize</c> function. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9F10A972-406F-47EF-B71C-86ED771C9A9A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9F10A972-406F-47EF-B71C-86ED771C9A9A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_FRAME_SIZE = new Guid(0x1652c33d, 0xd6b2, 0x4012, 0xb8, 0x34, 0x72, 0x03, 0x08, 0x49, 0xa3, 0x7d);

        // {c459a2e8-3d2c-4e44-b132-fee5156c7bb0}   MF_MT_FRAME_RATE                {UINT64 (HI32(Numerator),LO32(Denominator))}
        /// <summary>
        /// Frame rate of a video media type, in frames per second. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// </summary>
        /// <remarks>
        /// The frame rate is expressed as a ratio. The upper 32 bits of the attribute value contain the
        /// numerator and the lower 32 bits contain the denominator. For example, if the frame rate is 30
        /// frames per second (fps), the ratio is 30/1. If the frame rate is 29.97 fps, the ratio is
        /// 30,000/1001.
        /// <para/>
        /// To set the value, use the <c>MFSetAttributeRatio</c> function. To get the value, use the 
        /// <c>MFGetAttributeRatio</c> function. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8336559C-06F1-478E-B921-E9EAE7425230(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8336559C-06F1-478E-B921-E9EAE7425230(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_FRAME_RATE = new Guid(0xc459a2e8, 0x3d2c, 0x4e44, 0xb1, 0x32, 0xfe, 0xe5, 0x15, 0x6c, 0x7b, 0xb0);

        // {c6376a1e-8d0a-4027-be45-6d9a0ad39bb6}   MF_MT_PIXEL_ASPECT_RATIO        {UINT64 (HI32(Numerator),LO32(Denominator))}
        /// <summary>
        /// Pixel aspect ratio for a video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// </summary>
        /// <remarks>
        /// The upper 32 bits contain the numerator of the pixel aspect ratio and the lower 32 bits contain the
        /// denominator. The numerator is the horizontal component of the aspect ratio; the denominator is the
        /// vertical component.
        /// <para/>
        /// To set this attribute, use the <c>MFSetAttributeRatio</c> function. To get this attribute, use the 
        /// <c>MFGetAttributeRatio</c> function. 
        /// <para/>
        /// The pixel aspect ratio describes the shape of the pixels in the displayed video image. Set this
        /// attribute if the image has non-square pixels. To display correctly on a display device with square
        /// pixels, the image must be scaled by the inverse of the image's pixel aspect ratio.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E82CDD22-7D3F-4858-BEFD-43FA6F9F915E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E82CDD22-7D3F-4858-BEFD-43FA6F9F915E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_PIXEL_ASPECT_RATIO = new Guid(0xc6376a1e, 0x8d0a, 0x4027, 0xbe, 0x45, 0x6d, 0x9a, 0x0a, 0xd3, 0x9b, 0xb6);

        // {8772f323-355a-4cc7-bb78-6d61a048ae82}   MF_MT_DRM_FLAGS                 {UINT32 (anyof MFVideoDRMFlags)}
        /// <summary>
        /// Specifies whether a video media type requires the enforcement of copy protection. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a member of the <c>MFVideoDRMFlags</c> enumeration. 
        /// <para/>
        /// This attribute provides a hint to the application. It is not used to enforce copy protection or to
        /// specify the copy protection mechanism. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FB12BA38-A4F4-44FE-BF31-E731C56BB145(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FB12BA38-A4F4-44FE-BF31-E731C56BB145(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_DRM_FLAGS = new Guid(0x8772f323, 0x355a, 0x4cc7, 0xbb, 0x78, 0x6d, 0x61, 0xa0, 0x48, 0xae, 0x82);

        // {24974215-1B7B-41e4-8625-AC469F2DEDAA}   MF_MT_TIMESTAMP_CAN_BE_DTS      {UINT32 (BOOL)}
        /// <summary>
        /// Specifies whether a decoder can use decode time stamps (DTS) when setting time stamps.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/38E6AA56-EE38-48D5-92F1-F29ABB2C7A72(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/38E6AA56-EE38-48D5-92F1-F29ABB2C7A72(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_TIMESTAMP_CAN_BE_DTS = new Guid(0x24974215, 0x1b7b, 0x41e4, 0x86, 0x25, 0xac, 0x46, 0x9f, 0x2d, 0xed, 0xaa);

        // {A20AF9E8-928A-4B26-AAA9-F05C74CAC47C}   MF_MT_MPEG2_STANDARD            {UINT32 (0 for default MPEG2, 1  to use ATSC standard, 2 to use DVB standard, 3 to use ARIB standard)}
        /// <summary>
        /// For a media type that describes an MPEG-2 program stream (PS) or transport stream (TS), specifies
        /// the standard that is used to multiplex the stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>0</strong></term><description>Standard MPEG-2 PS or TS.</description></item>
        /// <item><term><strong>1</strong></term><description>Advanced Television Systems Committee (ATSC) standard.</description></item>
        /// <item><term><strong>2</strong></term><description>Digital Video Broadcasting  (DVB) standard.</description></item>
        /// <item><term><strong>3</strong></term><description>Association of Radio Industries and Businesses (ARIB) standard.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3D4C1A81-A9BA-427F-93DB-F522A0616EAB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3D4C1A81-A9BA-427F-93DB-F522A0616EAB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_MPEG2_STANDARD = new Guid(0xa20af9e8, 0x928a, 0x4b26, 0xaa, 0xa9, 0xf0, 0x5c, 0x74, 0xca, 0xc4, 0x7c);

        // {5229BA10-E29D-4F80-A59C-DF4F180207D2}   MF_MT_MPEG2_TIMECODE            {UINT32 (0 for no timecode, 1 to append an 4 byte timecode to the front of each transport packet)}
        /// <summary>
        /// For a media type that describes an MPEG-2 transport stream (TS), specifies the transport packets
        /// contain a 4-byte time code.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>0</strong></term><description>No time code is added.</description></item>
        /// <item><term><strong>1</strong></term><description>A 4-byte time code is added at the start of each transport packet. This time code is required by some digital television standards.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B172E7A8-5757-49B7-A784-FAFC7E904A4C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B172E7A8-5757-49B7-A784-FAFC7E904A4C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_MPEG2_TIMECODE = new Guid(0x5229ba10, 0xe29d, 0x4f80, 0xa5, 0x9c, 0xdf, 0x4f, 0x18, 0x2, 0x7, 0xd2);

        // {825D55E4-4F12-4197-9EB3-59B6E4710F06}   MF_MT_MPEG2_CONTENT_PACKET      {UINT32 (0 for no content packet, 1 to append a 14 byte Content Packet header according to the ARIB specification to the beginning a transport packet at 200-1000 ms intervals.)}
        /// <summary>
        /// For a media type that describes an MPEG-2 transport stream (TS), specifies whether the transport
        /// packets contain Content Packet headers.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>0</strong></term><description>No Content Packet headers are added.</description></item>
        /// <item><term><strong>1</strong></term><description>At 200–1000   millisecond intervals, a 14-byte Content Packet header is added to the beginning of the transport packet, as defined by the Association of Radio Industries and Businesses (ARIB) standard.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/527B965D-4330-4DCB-B6DA-32D6BCDF5515(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/527B965D-4330-4DCB-B6DA-32D6BCDF5515(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_MPEG2_CONTENT_PACKET = new Guid(0x825d55e4, 0x4f12, 0x4197, 0x9e, 0xb3, 0x59, 0xb6, 0xe4, 0x71, 0xf, 0x6);

#endif

        #endregion


#if NOT_IN_USE

        #region VIDEO - H264 extra data

        // {F5929986-4C45-4FBB-BB49-6CC534D05B9B}  {UINT32, UVC 1.5 H.264 format descriptor: bMaxCodecConfigDelay}
        /// <summary>
        /// The maximum number of frames the H.264 encoder takes to respond to a command. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to media types for H.264 streams transmitted over USB. The value corresponds
        /// to the <strong>bMaxCodecConfigDelay</strong> field in the UVC 1.2 H.264 video format descriptor. 
        /// <para/>
        /// This attribute is also used with <c>H.264 UVC 1.5 camera encoders</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C856B2B0-4A06-436D-B589-B01DA86DB53D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C856B2B0-4A06-436D-B589-B01DA86DB53D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_H264_MAX_CODEC_CONFIG_DELAY = new Guid(0xf5929986, 0x4c45, 0x4fbb, 0xbb, 0x49, 0x6c, 0xc5, 0x34, 0xd0, 0x5b, 0x9b);

        // {C8BE1937-4D64-4549-8343-A8086C0BFDA5} {UINT32, UVC 1.5 H.264 format descriptor: bmSupportedSliceModes}
        /// <summary>
        /// Specifies the supported slice modes for an H.264 video stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to media types for H.264 streams transmitted over USB. The value corresponds
        /// to the <strong>bmSupportedSliceModes</strong> field in the UVC 1.5 H.264 video format descriptor. 
        /// <para/>
        /// This attribute is also used with <c>H.264 UVC 1.5 camera encoders</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/72DA62EC-A509-4C3B-A51D-7313C176AAA9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/72DA62EC-A509-4C3B-A51D-7313C176AAA9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_H264_SUPPORTED_SLICE_MODES = new Guid(0xc8be1937, 0x4d64, 0x4549, 0x83, 0x43, 0xa8, 0x8, 0x6c, 0xb, 0xfd, 0xa5);

        // {89A52C01-F282-48D2-B522-22E6AE633199} {UINT32, UVC 1.5 H.264 format descriptor: bmSupportedSyncFrameTypes}
        /// <summary>
        /// Specifies the types of synchronization frame that are supported for an H.264 video stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to media types for H.264 streams transmitted over USB. The value corresponds
        /// to the <strong>bmSupportedSyncFrameTypes</strong> field in the UVC 1.5 H.264 video format
        /// descriptor. 
        /// <para/>
        /// This attribute is also used with <c>H.264 UVC 1.5 camera encoders</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A2E548F1-A5FA-4110-AD07-46BE9D7DC4A5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A2E548F1-A5FA-4110-AD07-46BE9D7DC4A5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_H264_SUPPORTED_SYNC_FRAME_TYPES = new Guid(0x89a52c01, 0xf282, 0x48d2, 0xb5, 0x22, 0x22, 0xe6, 0xae, 0x63, 0x31, 0x99);

        // {E3854272-F715-4757-BA90-1B696C773457} {UINT32, UVC 1.5 H.264 format descriptor: bResolutionScaling}
        /// <summary>
        /// UVC 1.5 H.264 format descriptor: <c>bResolutionScaling</c>
        /// <para/>
        /// Data type: <strong>UINT32</strong>
        /// </summary>
        public static readonly Guid MF_MT_H264_RESOLUTION_SCALING = new Guid(0xe3854272, 0xf715, 0x4757, 0xba, 0x90, 0x1b, 0x69, 0x6c, 0x77, 0x34, 0x57);

        // {9EA2D63D-53F0-4A34-B94E-9DE49A078CB3} {UINT32, UVC 1.5 H.264 format descriptor: bSimulcastSupport}
        /// <summary>
        /// Specifies the number of streaming endpoints and the number of supported streams for a UVC H.264
        /// encoder.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to media types for H.264 streams transmitted over USB. The value corresponds
        /// to the <strong>bSimulcastSupport</strong> field in the UVC 1.5 H.264 video format descriptor. 
        /// <para/>
        /// This attribute is also used with <c>H.264 UVC 1.5 camera encoders</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/343EC59E-30E5-4F37-8B05-60EF51717835(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/343EC59E-30E5-4F37-8B05-60EF51717835(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_H264_SIMULCAST_SUPPORT = new Guid(0x9ea2d63d, 0x53f0, 0x4a34, 0xb9, 0x4e, 0x9d, 0xe4, 0x9a, 0x7, 0x8c, 0xb3);

        // {6A8AC47E-519C-4F18-9BB3-7EEAAEA5594D} {UINT32, UVC 1.5 H.264 format descriptor: bmSupportedRateControlModes}
        /// <summary>
        /// Specifies the supported rate-control modes for an H.264 video stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to media types for H.264 streams transmitted over USB. The value corresponds
        /// to the <strong>bmSupportedRateControlModes</strong> field in the UVC 1.5 H.264 video format
        /// descriptor. 
        /// <para/>
        /// This attribute is also used with <c>H.264 UVC 1.5 camera encoders</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DAA62ECD-AFA2-40C2-9B52-F2D581F4D894(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DAA62ECD-AFA2-40C2-9B52-F2D581F4D894(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_H264_SUPPORTED_RATE_CONTROL_MODES = new Guid(0x6a8ac47e, 0x519c, 0x4f18, 0x9b, 0xb3, 0x7e, 0xea, 0xae, 0xa5, 0x59, 0x4d);

        // {45256D30-7215-4576-9336-B0F1BCD59BB2}  {Blob of size 20 * sizeof(WORD), UVC 1.5 H.264 format descriptor: wMaxMBperSec*}
        /// <summary>
        /// Specifies the maximum macroblock processing rate for an H.264 video stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32[]</strong> stored as <strong>UINT8[]</strong>
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to media types for H.264 streams transmitted over USB. The value of the
        /// attribute is an array of UINT32 values, which correspond to the following fields in the UVC 1.5
        /// H.264 video format descriptor.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Array Element</term><description>Descriptor Field</description></listheader>
        /// <item><term>0</term><description><strong>dwMaxMBperSecOneResolutionNoScalability </strong></description></item>
        /// <item><term>1</term><description><strong>dwMaxMBperSecTwoResolutionsNoScalability</strong></description></item>
        /// <item><term>2</term><description><strong>dwMaxMBperSecThreeResolutionsNoScalability </strong></description></item>
        /// <item><term>3</term><description><strong>dwMaxMBperSecFourResolutionsNoScalability </strong></description></item>
        /// <item><term>4</term><description><strong>dwMaxMBperSecOneResolutionTemporalScalability </strong></description></item>
        /// <item><term>5</term><description><strong>dwMaxMBperSecTwoResolutionsTemporalScalablility </strong></description></item>
        /// <item><term>6</term><description><strong>dwMaxMBperSecThreeResolutionsTemporalScalability </strong></description></item>
        /// <item><term>7</term><description><strong>dwMaxMBperSecFourResolutionsTemporalScalability </strong></description></item>
        /// <item><term>8</term><description><strong>dwMaxMBperSecOneResolutionTemporalQualityScalability </strong></description></item>
        /// <item><term>9</term><description><strong>dwMaxMBperSecTwoResolutionsTemporalQualityScalability </strong></description></item>
        /// <item><term>10</term><description><strong>dwMaxMBperSecThreeResolutionsTemporalQualityScalablity</strong></description></item>
        /// <item><term>11</term><description><strong>dwMaxMBperSecFourResolutionsTemporalQualityScalability</strong></description></item>
        /// <item><term>12</term><description><strong>dwMaxMBperSecOneResolutionFullScalability</strong></description></item>
        /// <item><term>13</term><description><strong>dwMaxMBperSecTwoResolutionsFullScalability </strong></description></item>
        /// <item><term>14</term><description><strong>dwMaxMBperSecThreeResolutionsFullScalability </strong></description></item>
        /// <item><term>15</term><description><strong>dwMaxMBperSecFourResolutionsFullScalability </strong></description></item>
        /// </list>
        /// <para/>
        /// This attribute is also used with <c>H.264 UVC 1.5 camera encoders</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/882F54D1-A963-4016-BEC7-F9C1AC5885FD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/882F54D1-A963-4016-BEC7-F9C1AC5885FD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_H264_MAX_MB_PER_SEC = new Guid(0x45256d30, 0x7215, 0x4576, 0x93, 0x36, 0xb0, 0xf1, 0xbc, 0xd5, 0x9b, 0xb2);

        // {60B1A998-DC01-40CE-9736-ABA845A2DBDC}         {UINT32, UVC 1.5 H.264 frame descriptor: bmSupportedUsages}
        /// <summary>
        /// Specifies the supported usage modes for an H.264 video stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to media types for H.264 streams transmitted over USB. The value corresponds
        /// to the <strong>bmSupportedUsages</strong> field in the UVC 1.5 H.264 video frame descriptor. 
        /// <para/>
        /// This attribute is also used with <c>H.264 UVC 1.5 camera encoders</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EEAE0B57-9731-4032-80A3-6A1AD11214EC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EEAE0B57-9731-4032-80A3-6A1AD11214EC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_H264_SUPPORTED_USAGES = new Guid(0x60b1a998, 0xdc01, 0x40ce, 0x97, 0x36, 0xab, 0xa8, 0x45, 0xa2, 0xdb, 0xdc);

        // {BB3BD508-490A-11E0-99E4-1316DFD72085}         {UINT32, UVC 1.5 H.264 frame descriptor: bmCapabilities}
        /// <summary>
        /// Specifies the capabilities flags for an H.264 video stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to media types for H.264 streams transmitted over USB. The value corresponds
        /// to the <strong>bmCapabilities</strong> field in the UVC 1.5 H.264 video frame descriptor. 
        /// <para/>
        /// This attribute is also used with <c>H.264 UVC 1.5 camera encoders</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/59EF18D6-6063-4EF3-BBFB-51A966CFF09E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/59EF18D6-6063-4EF3-BBFB-51A966CFF09E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_H264_CAPABILITIES = new Guid(0xbb3bd508, 0x490a, 0x11e0, 0x99, 0xe4, 0x13, 0x16, 0xdf, 0xd7, 0x20, 0x85);

        // {F8993ABE-D937-4A8F-BBCA-6966FE9E1152}         {UINT32, UVC 1.5 H.264 frame descriptor: bmSVCCapabilities}
        /// <summary>
        /// Specifies the SVC capabilities of an H.264 video stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to media types for H.264 streams transmitted over USB. The value corresponds
        /// to the <strong>bmSVCCapabilities</strong> field in the UVC 1.5 H.264 video frame descriptor. 
        /// <para/>
        /// This attribute is also used with <c>H.264 UVC 1.5 camera encoders</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B727D9D2-6126-41F8-A27A-743640FE3AE4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B727D9D2-6126-41F8-A27A-743640FE3AE4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_H264_SVC_CAPABILITIES = new Guid(0xf8993abe, 0xd937, 0x4a8f, 0xbb, 0xca, 0x69, 0x66, 0xfe, 0x9e, 0x11, 0x52);

        // {359CE3A5-AF00-49CA-A2F4-2AC94CA82B61}         {UINT32, UVC 1.5 H.264 Probe/Commit Control: bUsage}
        /// <summary>
        /// Specifies the usage mode for a UVC H.264 encoder.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to media types for H.264 streams transmitted over USB. The value corresponds
        /// to the <strong>bUsage</strong> field in the UVC 1.2 H.264 probe/commit control. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/05158F47-CE01-4C99-8FFA-6BBD4F829B59(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/05158F47-CE01-4C99-8FFA-6BBD4F829B59(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_H264_USAGE = new Guid(0x359ce3a5, 0xaf00, 0x49ca, 0xa2, 0xf4, 0x2a, 0xc9, 0x4c, 0xa8, 0x2b, 0x61);

        //{705177D8-45CB-11E0-AC7D-B91CE0D72085}          {UINT32, UVC 1.5 H.264 Probe/Commit Control: bmRateControlModes}
        /// <summary>
        /// Specifies the rate-control mode for an H.264 video stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to media types for H.264 streams transmitted over USB. The value corresponds
        /// to the <strong>bmRateControlModes</strong> field in the UVC 1.2 H.264 probe/commit control. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EA8EFEFA-9292-4D7B-BF5D-DE5239BB1D2C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EA8EFEFA-9292-4D7B-BF5D-DE5239BB1D2C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_H264_RATE_CONTROL_MODES = new Guid(0x705177d8, 0x45cb, 0x11e0, 0xac, 0x7d, 0xb9, 0x1c, 0xe0, 0xd7, 0x20, 0x85);

        //{85E299B2-90E3-4FE8-B2F5-C067E0BFE57A}          {UINT64, UVC 1.5 H.264 Probe/Commit Control: bmLayoutPerStream}
        /// <summary>
        /// UVC 1.5 H.264 Probe/Commit Control: <c>bmLayoutPerStream</c>.
        /// <para/>
        /// Data type: <strong>UINT64</strong>
        /// </summary>
        public static readonly Guid MF_MT_H264_LAYOUT_PER_STREAM = new Guid(0x85e299b2, 0x90e3, 0x4fe8, 0xb2, 0xf5, 0xc0, 0x67, 0xe0, 0xbf, 0xe5, 0x7a);

        // {4d0e73e5-80ea-4354-a9d0-1176ceb028ea}   MF_MT_PAD_CONTROL_FLAGS         {UINT32 (oneof MFVideoPadFlags)}
        /// <summary>
        /// Specifies the aspect ratio of the output rectangle for a video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a member of the <see cref="Misc.MFVideoPadFlags"/> enumeration. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D7FEC5FB-A1FE-4CC9-AA27-A3AF0456EA8D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D7FEC5FB-A1FE-4CC9-AA27-A3AF0456EA8D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_PAD_CONTROL_FLAGS = new Guid(0x4d0e73e5, 0x80ea, 0x4354, 0xa9, 0xd0, 0x11, 0x76, 0xce, 0xb0, 0x28, 0xea);

        // {68aca3cc-22d0-44e6-85f8-28167197fa38}   MF_MT_SOURCE_CONTENT_HINT       {UINT32 (oneof MFVideoSrcContentHintFlags)}
        /// <summary>
        /// Describes the intended aspect ratio for a video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a member of the <see cref="Misc.MFVideoSrcContentHintFlags"/>
        /// enumeration. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6B32E257-C523-4859-8C8F-661C33810624(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6B32E257-C523-4859-8C8F-661C33810624(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_SOURCE_CONTENT_HINT = new Guid(0x68aca3cc, 0x22d0, 0x44e6, 0x85, 0xf8, 0x28, 0x16, 0x71, 0x97, 0xfa, 0x38);

        // {65df2370-c773-4c33-aa64-843e068efb0c}   MF_MT_CHROMA_SITING             {UINT32 (anyof MFVideoChromaSubsampling)}
        /// <summary>
        /// Describes how chroma was sampled for a Y'Cb'Cr' video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a bitwise <strong>OR</strong> of flags from the 
        /// <see cref="MFVideoChromaSubsampling"/> enumeration. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0C930348-8669-42CC-9D74-DF9EF475BDC8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0C930348-8669-42CC-9D74-DF9EF475BDC8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_VIDEO_CHROMA_SITING = new Guid(0x65df2370, 0xc773, 0x4c33, 0xaa, 0x64, 0x84, 0x3e, 0x06, 0x8e, 0xfb, 0x0c);

        // {e2724bb8-e676-4806-b4b2-a8d6efb44ccd}   MF_MT_INTERLACE_MODE            {UINT32 (oneof MFVideoInterlaceMode)}
        /// <summary>
        /// Describes how the frames in a video media type are interlaced. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a member of the <see cref="MFVideoInterlaceMode"/> enumeration. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/19AA0147-AC49-4A2E-AC75-E967FEC9CA68(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/19AA0147-AC49-4A2E-AC75-E967FEC9CA68(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_INTERLACE_MODE = new Guid(0xe2724bb8, 0xe676, 0x4806, 0xb4, 0xb2, 0xa8, 0xd6, 0xef, 0xb4, 0x4c, 0xcd);

        // {5fb0fce9-be5c-4935-a811-ec838f8eed93}   MF_MT_TRANSFER_FUNCTION         {UINT32 (oneof MFVideoTransferFunction)}
        /// <summary>
        /// Specifies the conversion function from RGB to R'G'B' for a video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a member of the <see cref="MFVideoTransferFunction"/> enumeration. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C64C2135-F588-4D7A-9CA8-AE4F7B290572(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C64C2135-F588-4D7A-9CA8-AE4F7B290572(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_TRANSFER_FUNCTION = new Guid(0x5fb0fce9, 0xbe5c, 0x4935, 0xa8, 0x11, 0xec, 0x83, 0x8f, 0x8e, 0xed, 0x93);

        // {dbfbe4d7-0740-4ee0-8192-850ab0e21935}   MF_MT_VIDEO_PRIMARIES           {UINT32 (oneof MFVideoPrimaries)}
        /// <summary>
        /// Specifies the color primaries for a video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a member of the <see cref="MFVideoPrimaries"/> enumeration. 
        /// <para/>
        /// The <see cref="MFVideoPrimaries"/> enumeration identifies color primaries associated with certain
        /// common video standards. If the media type uses color primaries that are not identified in the 
        /// <strong>MFVideoPrimaries</strong> enumeration, set the 
        /// <see cref="MFAttributesClsid.MF_MT_CUSTOM_VIDEO_PRIMARIES"/> attribute instead of this attribute. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/56F31C1A-B610-4DA0-9DF4-76E15ADD672C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/56F31C1A-B610-4DA0-9DF4-76E15ADD672C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_VIDEO_PRIMARIES = new Guid(0xdbfbe4d7, 0x0740, 0x4ee0, 0x81, 0x92, 0x85, 0x0a, 0xb0, 0xe2, 0x19, 0x35);

        // {47537213-8cfb-4722-aa34-fbc9e24d77b8}   MF_MT_CUSTOM_VIDEO_PRIMARIES    {BLOB (MT_CUSTOM_VIDEO_PRIMARIES)}
        /// <summary>
        /// Specifies custom color primaries for a video media type. 
        /// <para/>
        /// <strong>Note</strong> This attribute is currently not used by the Media Foundation pipeline. To
        /// specify standard color primaries, set the <see cref="MFAttributesClsid.MF_MT_VIDEO_PRIMARIES"/>
        /// attribute. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// The attribute data is an <see cref="Misc.MT_CustomVideoPrimaries"/> structure. 
        /// <para/>
        /// Use this attribute if the media type uses color primaries that are not defined by the 
        /// <see cref="MFAttributesClsid.MF_MT_VIDEO_PRIMARIES"/> attribute. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DC5DF755-53CF-4910-AF42-309F1F46B1ED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DC5DF755-53CF-4910-AF42-309F1F46B1ED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_CUSTOM_VIDEO_PRIMARIES = new Guid(0x47537213, 0x8cfb, 0x4722, 0xaa, 0x34, 0xfb, 0xc9, 0xe2, 0x4d, 0x77, 0xb8);

        // {3e23d450-2c75-4d25-a00e-b91670d12327}   MF_MT_YUV_MATRIX                {UINT32 (oneof MFVideoTransferMatrix)}
        /// <summary>
        /// For YUV media types, defines the conversion matrix from the Y'Cb'Cr' color space to the R'G'B'
        /// color space. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a member of the <see cref="MFVideoTransferMatrix"/> enumeration. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B268D16D-B4CC-4026-9BA7-805CC5409B95(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B268D16D-B4CC-4026-9BA7-805CC5409B95(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_YUV_MATRIX = new Guid(0x3e23d450, 0x2c75, 0x4d25, 0xa0, 0x0e, 0xb9, 0x16, 0x70, 0xd1, 0x23, 0x27);

        // {53a0529c-890b-4216-8bf9-599367ad6d20}   MF_MT_VIDEO_LIGHTING            {UINT32 (oneof MFVideoLighting)}
        /// <summary>
        /// Specifies the optimal lighting conditions for a video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a member of the <see cref="MFVideoLighting"/> enumeration. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/697590E3-898E-4AC9-8390-7B0994B6E571(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/697590E3-898E-4AC9-8390-7B0994B6E571(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_VIDEO_LIGHTING = new Guid(0x53a0529c, 0x890b, 0x4216, 0x8b, 0xf9, 0x59, 0x93, 0x67, 0xad, 0x6d, 0x20);

        // {c21b8ee5-b956-4071-8daf-325edf5cab11}   MF_MT_VIDEO_NOMINAL_RANGE       {UINT32 (oneof MFNominalRange)}
        /// <summary>
        /// Specifies the nominal range of the color information in a video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a member of the <see cref="MFNominalRange"/> enumeration. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7B2B809E-AAE4-401C-816A-626FB88F5F87(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7B2B809E-AAE4-401C-816A-626FB88F5F87(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_VIDEO_NOMINAL_RANGE = new Guid(0xc21b8ee5, 0xb956, 0x4071, 0x8d, 0xaf, 0x32, 0x5e, 0xdf, 0x5c, 0xab, 0x11);

        // {66758743-7e5f-400d-980a-aa8596c85696}   MF_MT_GEOMETRIC_APERTURE        {BLOB (MFVideoArea)}
        /// <summary>
        /// Defines the geometric aperture for a video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// The value of this attribute is an <see cref="MFVideoArea"/> structure. 
        /// <para/>
        /// The picture aspect ratio is calculated relative to the geometric aperture, using the following
        /// formula: Picture aspect ratio = (geometric aperture width / geometric aperture height) × pixel
        /// aspect ratio. 
        /// <para/>
        /// If this attribute is not set, the geometric aperture is assumed to be the entire video frame. You
        /// should set this attribute only when the media type describes a video standard with a defined active
        /// area.
        /// <para/>
        /// For example, in NTSC television the video frame is 720 × 480 with an active area of 704 × 480 and a
        /// 10:11 pixel aspect ratio. The resulting picture has an aspect ratio of (704/480) × (10/11) = 4:3.
        /// <para/>
        /// <strong>Note</strong> The default presenter for the <c>Enhanced Video Renderer</c> (EVR) shows the
        /// geometric aperture of the video, if specified. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A2489BA1-F322-4B63-A479-0D9879C30A8C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A2489BA1-F322-4B63-A479-0D9879C30A8C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_GEOMETRIC_APERTURE = new Guid(0x66758743, 0x7e5f, 0x400d, 0x98, 0x0a, 0xaa, 0x85, 0x96, 0xc8, 0x56, 0x96);

        // {d7388766-18fe-48c6-a177-ee894867c8c4}   MF_MT_MINIMUM_DISPLAY_APERTURE  {BLOB (MFVideoArea)}
        /// <summary>
        /// Defines the display aperture, which is the region of a video frame that contains valid image data. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// The attribute value is an <see cref="MFVideoArea"/> structure. 
        /// <para/>
        /// The minimum display aperture is the region that contains the valid portion of the signal. The
        /// pixels outside the aperture contain invalid data and should not be displayed. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/86A7509B-C690-49C2-BBE4-8B02D64C307C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/86A7509B-C690-49C2-BBE4-8B02D64C307C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_MINIMUM_DISPLAY_APERTURE = new Guid(0xd7388766, 0x18fe, 0x48c6, 0xa1, 0x77, 0xee, 0x89, 0x48, 0x67, 0xc8, 0xc4);

        // {79614dde-9187-48fb-b8c7-4d52689de649}   MF_MT_PAN_SCAN_APERTURE         {BLOB (MFVideoArea)}
        /// <summary>
        /// Defines the pan/scan aperture, which is the 4×3 region of video that should be displayed in
        /// pan/scan mode. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// The attribute value is an <see cref="MFVideoArea"/> structure. 
        /// <para/>
        /// This attribute is used to crop widescreen video to a 4:3 aspect ratio. The pan/scan aperture is
        /// used only in pan/scan mode, which is enabled by setting the 
        /// <see cref="MFAttributesClsid.MF_MT_PAN_SCAN_ENABLED"/> attribute to <strong>TRUE</strong>. 
        /// <para/>
        /// If pan/scan mode is not enabled, use the display aperture, specified by the 
        /// <see cref="MFAttributesClsid.MF_MT_MINIMUM_DISPLAY_APERTURE"/> attribute. 
        /// <para/>
        /// If this attribute is not set, the pan/scan aperture is assumed to be the entire video frame. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FAA577FD-6572-46B9-9C6C-F91C47832CB5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FAA577FD-6572-46B9-9C6C-F91C47832CB5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_PAN_SCAN_APERTURE = new Guid(0x79614dde, 0x9187, 0x48fb, 0xb8, 0xc7, 0x4d, 0x52, 0x68, 0x9d, 0xe6, 0x49);

        // {4b7f6bc3-8b13-40b2-a993-abf630b8204e}   MF_MT_PAN_SCAN_ENABLED          {UINT32 (BOOL)}
        /// <summary>
        /// Specifies whether pan/scan mode is enabled. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// If this attribute is <strong>TRUE</strong>, only the pan/scan region of the video should be
        /// displayed. The pan/scan region is specified by the 
        /// <see cref="MFAttributesClsid.MF_MT_PAN_SCAN_APERTURE"/> attribute. 
        /// <para/>
        /// If this attribute is <strong>FALSE</strong> or not set, the entire display aperture of the video
        /// should be displayed. The display aperture is specified by the 
        /// <see cref="MFAttributesClsid.MF_MT_MINIMUM_DISPLAY_APERTURE"/> attribute. 
        /// <para/>
        /// If you set this attribute to <strong>TRUE</strong>, also set the value of the 
        /// <see cref="MFAttributesClsid.MF_MT_PAN_SCAN_APERTURE"/> attribute. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9E8746C6-13A4-4CF7-9748-82223D9529FA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9E8746C6-13A4-4CF7-9748-82223D9529FA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_PAN_SCAN_ENABLED = new Guid(0x4b7f6bc3, 0x8b13, 0x40b2, 0xa9, 0x93, 0xab, 0xf6, 0x30, 0xb8, 0x20, 0x4e);

        // {20332624-fb0d-4d9e-bd0d-cbf6786c102e}   MF_MT_AVG_BITRATE               {UINT32}
        /// <summary>
        /// Approximate data rate of the video stream, in bits per second, for a video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>dwBitRate</strong> member of the 
        /// <see cref="Misc.VideoInfoHeader"/> and <see cref="Misc.VideoInfoHeader2"/> structures. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CF9374A7-3688-4A6C-8339-D68C267C9BED(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CF9374A7-3688-4A6C-8339-D68C267C9BED(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AVG_BITRATE = new Guid(0x20332624, 0xfb0d, 0x4d9e, 0xbd, 0x0d, 0xcb, 0xf6, 0x78, 0x6c, 0x10, 0x2e);

        // {799cabd6-3508-4db4-a3c7-569cd533deb1}   MF_MT_AVG_BIT_ERROR_RATE        {UINT32}
        /// <summary>
        /// Data error rate, in bit errors per second, for a video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>dwBitErrorRate</strong> member of the 
        /// <see cref="Misc.VideoInfoHeader"/> and <see cref="Misc.VideoInfoHeader2"/> structures. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/90433FF4-A563-4751-86D9-CAAC0CC58194(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/90433FF4-A563-4751-86D9-CAAC0CC58194(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AVG_BIT_ERROR_RATE = new Guid(0x799cabd6, 0x3508, 0x4db4, 0xa3, 0xc7, 0x56, 0x9c, 0xd5, 0x33, 0xde, 0xb1);

        // {c16eb52b-73a1-476f-8d62-839d6a020652}   MF_MT_MAX_KEYFRAME_SPACING      {UINT32}
        /// <summary>
        /// Maximum number of frames from one key frame to the next, in a video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/833A212C-83A8-4046-8AC7-2BCE35B2A982(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/833A212C-83A8-4046-8AC7-2BCE35B2A982(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_MAX_KEYFRAME_SPACING = new Guid(0xc16eb52b, 0x73a1, 0x476f, 0x8d, 0x62, 0x83, 0x9d, 0x6a, 0x02, 0x06, 0x52);

        // {644b4e48-1e02-4516-b0eb-c01ca9d49ac6}   MF_MT_DEFAULT_STRIDE            {UINT32 (INT32)} // in bytes
        /// <summary>
        /// Default surface stride, for an uncompressed video media type. Stride is the number of bytes needed
        /// to go from one row of pixels to the next.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a <strong>INT32</strong> value. 
        /// </summary>
        /// <remarks>
        /// The attribute value is stored as a <strong>UINT32</strong>, but should be cast to a 32-bit signed
        /// integer value. Stride can be negative. 
        /// <para/>
        /// Stride is positive for top-down images, and negative for bottom-up images.
        /// <para/>
        /// This attribute gives the stride for a <em>contiguous</em> representation of the image in memory;
        /// that is, a representation with no additional padding bytes after each row. If a media buffer
        /// supports the <see cref="IMF2DBuffer"/> interface, use the <see cref="IMF2DBuffer.Lock2D"/> method
        /// to get the actual stride of the surface, which might include extra padding bytes. 
        /// <para/>
        /// For more information about surface stride, see <c>Image Stride</c>. 
        /// <para/>
        /// For an example of how to calculate the default stride, see <c>Uncompressed Video Buffers</c>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/71FDA231-3497-49DB-B82E-2FD79F6ADE66(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/71FDA231-3497-49DB-B82E-2FD79F6ADE66(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_DEFAULT_STRIDE = new Guid(0x644b4e48, 0x1e02, 0x4516, 0xb0, 0xeb, 0xc0, 0x1c, 0xa9, 0xd4, 0x9a, 0xc6);

        // {6d283f42-9846-4410-afd9-654d503b1a54}   MF_MT_PALETTE                   {BLOB (array of MFPaletteEntry - usually 256)}
        /// <summary>
        /// Contains the palette entries for a video media type. Use this attribute for palettized video
        /// formats, such as RGB 8. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// The attribute data is an array of <see cref="MFPaletteEntry"/> unions. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3EFC124B-073E-4C48-9550-C100E29F2D6F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3EFC124B-073E-4C48-9550-C100E29F2D6F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_PALETTE = new Guid(0x6d283f42, 0x9846, 0x4410, 0xaf, 0xd9, 0x65, 0x4d, 0x50, 0x3b, 0x1a, 0x54);

        // {b6bc765f-4c3b-40a4-bd51-2535b66fe09d}   MF_MT_USER_DATA                 {BLOB}
        /// <summary>
        /// Contains additional format data for a media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// The meaning of the data in this attribute depends on the format that is described by the media
        /// type. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Format Type</term><description>Additional Format Data</description></listheader>
        /// <item><term>Windows Media codec.</term><description>Codec private data.</description></item>
        /// <item><term>Converted <see cref="Misc.VideoInfoHeader"/> or <see cref="Misc.VideoInfoHeader2"/> structure. </term><description>Extra data that appears after the <see cref="Misc.BitmapInfoHeader"/> structure, not including the color table or color masks. </description></item>
        /// <item><term>Converted <see cref="Misc.WaveFormatEx"/> or <see cref="Misc.WaveFormatExtensible"/> structure. </term><description>Extra data that appears after the audio format structure.</description></item>
        /// </list>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/020832C4-40A1-4D8B-ADA0-7A04CE097BCE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/020832C4-40A1-4D8B-ADA0-7A04CE097BCE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_USER_DATA = new Guid(0xb6bc765f, 0x4c3b, 0x40a4, 0xbd, 0x51, 0x25, 0x35, 0xb6, 0x6f, 0xe0, 0x9d);

        // {ad76a80b-2d5c-4e0b-b375-64e520137036}   MF_MT_VIDEO_PROFILE             {UINT32}    This is an alias of  MF_MT_MPEG2_PROFILE
        /// <summary>
        /// Specifies the profile of video encoding on the output media type. This is an alias of MF_MT_MPEG2_PROFILE attribute.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302198(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302198(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_VIDEO_PROFILE = new Guid(0xad76a80b, 0x2d5c, 0x4e0b, 0xb3, 0x75, 0x64, 0xe5, 0x20, 0x13, 0x70, 0x36);

        // {96f66574-11c5-4015-8666-bff516436da7}   MF_MT_VIDEO_LEVEL               {UINT32}    This is an alias of  MF_MT_MPEG2_LEVEL
        /// <summary>
        /// Specifies the MPEG-2 or H.264 level in a video media type. This is an alias of MF_MT_MPEG2_LEVEL.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302197(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302197(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_VIDEO_LEVEL = new Guid(0x96f66574, 0x11c5, 0x4015, 0x86, 0x66, 0xbf, 0xf5, 0x16, 0x43, 0x6d, 0xa7);

        // {73d1072d-1870-4174-a063-29ff4ff6c11e}
        /// <summary>
        /// Contains a DirectShow format GUID for a media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// </summary>
        /// <remarks>
        /// This attribute might be set when a DirectShow media type is converted into a Media Foundation media
        /// type. The attribute indicates the original DirectShow format type. The value corresponds to the
        /// formattype member of the <see cref="Misc.AMMediaType"/> structure. 
        /// <para/>
        /// For an audio format, the <see cref="MFAttributesClsid.MF_MT_USER_DATA"/> attribute might contain
        /// the original format block, if the DirectShow format type was not recognized. 
        /// <para/>
        /// Do not set this attribute on a media type unless you are converting a DirectShow format structure.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DC532791-39E1-4ACB-9E62-21D8F25BE870(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DC532791-39E1-4ACB-9E62-21D8F25BE870(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_AM_FORMAT_TYPE = new Guid(0x73d1072d, 0x1870, 0x4174, 0xa0, 0x63, 0x29, 0xff, 0x4f, 0xf6, 0xc1, 0x1e);

        // {91f67885-4333-4280-97cd-bd5a6c03a06e}   MF_MT_MPEG_START_TIME_CODE      {UINT32}
        /// <summary>
        /// Group-of-pictures (GOP) start time code, for an MPEG-1 or MPEG-2 video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>dwStartTimeCode</strong> member of the 
        /// <see cref="Misc.MPEG1VideoInfo"/> and <see cref="Mpeg2VideoInfo"/> structures. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8313B83C-5A0A-4AAA-BDC8-58A987C329C7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8313B83C-5A0A-4AAA-BDC8-58A987C329C7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_MPEG_START_TIME_CODE = new Guid(0x91f67885, 0x4333, 0x4280, 0x97, 0xcd, 0xbd, 0x5a, 0x6c, 0x03, 0xa0, 0x6e);

        // {ad76a80b-2d5c-4e0b-b375-64e520137036}   MF_MT_MPEG2_PROFILE             {UINT32 (oneof AM_MPEG2Profile)}
        /// <summary>
        /// Specifies the MPEG-2 or H.264 profile in a video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// For MPEG-2 video, the value of this attribute is a member of the <c>AM_MPEG2Profile</c>
        /// enumeration. 
        /// <para/>
        /// For H.264 video, the value is a member of the <see cref="eAVEncH264VProfile"/> enumeration. 
        /// <para/>
        /// This attribute corresponds to the <strong>dwProfile</strong> member of the 
        /// <see cref="Mpeg2VideoInfo"/> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8C6A68CB-D976-4099-8934-064F0E8F6374(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8C6A68CB-D976-4099-8934-064F0E8F6374(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_MPEG2_PROFILE = new Guid(0xad76a80b, 0x2d5c, 0x4e0b, 0xb3, 0x75, 0x64, 0xe5, 0x20, 0x13, 0x70, 0x36);

        // {96f66574-11c5-4015-8666-bff516436da7}   MF_MT_MPEG2_LEVEL               {UINT32 (oneof AM_MPEG2Level)}
        /// <summary>
        /// Specifies the MPEG-2 or H.264 level in a video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// For MPEG-2 video, the value of this attribute is a member of the <c>AM_MPEG2Level</c> enumeration. 
        /// <para/>
        /// For H.264 video, the value is a member of the <see cref="eAVEncH264VLevel"/> enumeration. 
        /// <para/>
        /// This attribute corresponds to the <strong>dwLevel</strong> member of the 
        /// <see cref="Mpeg2VideoInfo"/> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8DD8E8C4-5A6F-4A87-A643-73AF35C362A9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8DD8E8C4-5A6F-4A87-A643-73AF35C362A9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_MPEG2_LEVEL = new Guid(0x96f66574, 0x11c5, 0x4015, 0x86, 0x66, 0xbf, 0xf5, 0x16, 0x43, 0x6d, 0xa7);

        // {31e3991d-f701-4b2f-b426-8ae3bda9e04b}   MF_MT_MPEG2_FLAGS               {UINT32 (anyof AMMPEG2_xxx flags)}
        /// <summary>
        /// Contains miscellaneous flags for an MPEG-2 video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>dwFlags</strong> member of the 
        /// <see cref="Mpeg2VideoInfo"/> structure. For a list of valid flags, see the documentation for 
        /// <strong>MPEG2VIDEOINFO</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2E1BF3E3-C005-418B-B9FD-1D43C42DAD6F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2E1BF3E3-C005-418B-B9FD-1D43C42DAD6F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_MPEG2_FLAGS = new Guid(0x31e3991d, 0xf701, 0x4b2f, 0xb4, 0x26, 0x8a, 0xe3, 0xbd, 0xa9, 0xe0, 0x4b);

        // {3c036de7-3ad0-4c9e-9216-ee6d6ac21cb3}   MF_MT_MPEG_SEQUENCE_HEADER      {BLOB}
        /// <summary>
        /// Contains the MPEG-1 or MPEG-2 sequence header for a video media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>dwSequenceHeader</strong> member of the 
        /// <see cref="Mpeg2VideoInfo"/> structure, or the <strong>bSequenceHeader</strong> member of the 
        /// <see cref="Misc.MPEG1VideoInfo"/> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/17B7F76C-404C-4AA9-9746-1488FEE027F2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/17B7F76C-404C-4AA9-9746-1488FEE027F2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_MPEG_SEQUENCE_HEADER = new Guid(0x3c036de7, 0x3ad0, 0x4c9e, 0x92, 0x16, 0xee, 0x6d, 0x6a, 0xc2, 0x1c, 0xb3);

        // {84bd5d88-0fb8-4ac8-be4b-a8848bef98f3}   MF_MT_DV_AAUX_SRC_PACK_0        {UINT32}
        /// <summary>
        /// Audio auxiliary (AAUX) source pack for the first audio block in a digital video (DV) media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>dwDVAAuxSrc</strong> member of the DirectShow 
        /// <c>DVINFO</c> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A37D9371-0D9F-44A8-B8B3-9FBFCFAD1A51(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A37D9371-0D9F-44A8-B8B3-9FBFCFAD1A51(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_DV_AAUX_SRC_PACK_0 = new Guid(0x84bd5d88, 0x0fb8, 0x4ac8, 0xbe, 0x4b, 0xa8, 0x84, 0x8b, 0xef, 0x98, 0xf3);

        // {f731004e-1dd1-4515-aabe-f0c06aa536ac}   MF_MT_DV_AAUX_CTRL_PACK_0       {UINT32}
        /// <summary>
        /// Audio auxiliary (AAUX) source control pack for the first audio block in a digital video (DV) media
        /// type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>dwDVAAuxCtl</strong> member of the DirectShow 
        /// <c>DVINFO</c> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/483B5A5E-D385-4730-91DC-2E4DCCA73EAD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/483B5A5E-D385-4730-91DC-2E4DCCA73EAD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_DV_AAUX_CTRL_PACK_0 = new Guid(0xf731004e, 0x1dd1, 0x4515, 0xaa, 0xbe, 0xf0, 0xc0, 0x6a, 0xa5, 0x36, 0xac);

        // {720e6544-0225-4003-a651-0196563a958e}   MF_MT_DV_AAUX_SRC_PACK_1        {UINT32}
        /// <summary>
        /// Audio auxiliary (AAUX) source pack for the second audio block in a digital video (DV) media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>dwDVAAuxSrc1</strong> member of the DirectShow 
        /// <c>DVINFO</c> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C9D350BD-BF49-4C2C-A12F-3B5B475AC103(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C9D350BD-BF49-4C2C-A12F-3B5B475AC103(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_DV_AAUX_SRC_PACK_1 = new Guid(0x720e6544, 0x0225, 0x4003, 0xa6, 0x51, 0x01, 0x96, 0x56, 0x3a, 0x95, 0x8e);

        // {cd1f470d-1f04-4fe0-bfb9-d07ae0386ad8}   MF_MT_DV_AAUX_CTRL_PACK_1       {UINT32}
        /// <summary>
        /// Audio auxiliary (AAUX) source control pack for the second audio block in a digital video (DV) media
        /// type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>dwDVAAuxCtl1</strong> member of the DirectShow 
        /// <c>DVINFO</c> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E9C17940-BEB7-4034-95A3-983AACA0C905(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E9C17940-BEB7-4034-95A3-983AACA0C905(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_DV_AAUX_CTRL_PACK_1 = new Guid(0xcd1f470d, 0x1f04, 0x4fe0, 0xbf, 0xb9, 0xd0, 0x7a, 0xe0, 0x38, 0x6a, 0xd8);

        // {41402d9d-7b57-43c6-b129-2cb997f15009}   MF_MT_DV_VAUX_SRC_PACK          {UINT32}
        /// <summary>
        /// Video auxiliary (VAUX) source pack in a digital video (DV) media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>dwDVVAuxSrc</strong> member of the DirectShow 
        /// <c>DVINFO</c> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4263032F-9093-4C7A-9CA0-14F8DC0D1AEF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4263032F-9093-4C7A-9CA0-14F8DC0D1AEF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_DV_VAUX_SRC_PACK = new Guid(0x41402d9d, 0x7b57, 0x43c6, 0xb1, 0x29, 0x2c, 0xb9, 0x97, 0xf1, 0x50, 0x09);

        // {2f84e1c4-0da1-4788-938e-0dfbfbb34b48}   MF_MT_DV_VAUX_CTRL_PACK         {UINT32}
        /// <summary>
        /// Video auxiliary (VAUX) source control pack in a digital video (DV) media type. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute corresponds to the <strong>dwDVVAuxCtl</strong> member of the DirectShow 
        /// <c>DVINFO</c> structure. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/14098435-5033-489C-908F-CBB814A0349C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/14098435-5033-489C-908F-CBB814A0349C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_DV_VAUX_CTRL_PACK = new Guid(0x2f84e1c4, 0x0da1, 0x4788, 0x93, 0x8e, 0x0d, 0xfb, 0xfb, 0xb3, 0x4b, 0x48);

        // {5315d8a0-87c5-4697-b793-666c67c49b}         MF_MT_VIDEO_3D_FORMAT           {UINT32 (anyof MFVideo3DFormat)}
        /// <summary>
        /// For a video media type, specifies how 3D video frames are stored in memory.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>MFVideo3DFormat</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a member of the <see cref="MFVideo3DFormat"/> enumeration. The
        /// attribute applies only if the <see cref="MFMediaType.MF_MT_VIDEO_3D"/> attribute is <strong>TRUE
        /// </strong>. 
        /// <para/>
        /// This attribute is required for uncompressed 3D video formats.  It is optional for compressed 3D
        /// video. A media source that delivers encoded frames might be able to set the attribute, based on
        /// information in the file container. Otherwise, the attribute should be set by the decoder in the
        /// decoder's output media type.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/880DF017-5841-4C0A-82AF-F092DEF5406B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/880DF017-5841-4C0A-82AF-F092DEF5406B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_VIDEO_3D_FORMAT = new Guid(0x5315d8a0, 0x87c5, 0x4697, 0xb7, 0x93, 0x66, 0x6, 0xc6, 0x7c, 0x4, 0x9b);

        // {BB077E8A-DCBF-42eb-AF60-418DF98AA495}       MF_MT_VIDEO_3D_NUM_VIEW         {UINT32}
        /// <summary>
        /// The number of views in a 3D video sequence.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// A typical 3D video sequence contains two views, left and right. Currently, the value of this
        /// attribute must be either 1 or 2.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5D8224E3-94B1-4056-8424-9978D2B88B3A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5D8224E3-94B1-4056-8424-9978D2B88B3A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_VIDEO_3D_NUM_VIEWS = new Guid(0xbb077e8a, 0xdcbf, 0x42eb, 0xaf, 0x60, 0x41, 0x8d, 0xf9, 0x8a, 0xa4, 0x95);

        // {6D4B7BFF-5629-4404-948C-C634F4CE26D4}       MF_MT_VIDEO_3D_LEFT_IS_BASE     {UINT32}
        /// <summary>
        /// For a 3D video format, specifies which view is the base view.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// By default, the left view in a 3D video sequence is the base view. If the right view is the base
        /// view, set this attribute to <strong>FALSE</strong>. 
        /// <para/>
        /// To convert stereoscopic video to 2D, keep the base view and discard the other view.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/11555BA0-D9BE-4239-A857-C9EEE86A8520(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/11555BA0-D9BE-4239-A857-C9EEE86A8520(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_VIDEO_3D_LEFT_IS_BASE = new Guid(0x6d4b7bff, 0x5629, 0x4404, 0x94, 0x8c, 0xc6, 0x34, 0xf4, 0xce, 0x26, 0xd4);

        // {EC298493-0ADA-4ea1-A4FE-CBBD36CE9331}       MF_MT_VIDEO_3D_FIRST_IS_LEFT    {UINT32 (BOOL)}
        /// <summary>
        /// For a 3D video format, specifies which view is the left view.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// For 3D video, each video sample contains two views, which are designated <em>first view</em> and 
        /// <em>second view</em>. The exact layout of the views in memory is indicated by the 
        /// <see cref="MFAttributesClsid.MF_MT_VIDEO_3D_FORMAT"/> attribute. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Format</term><description>First View</description><description>Second View</description></listheader>
        /// <item><term>Packed side-by-side</term><description>Left half of the buffer</description><description>Right half of the buffer</description></item>
        /// <item><term>Packed top-to-bottom</term><description>Top half of the buffer</description><description>Bottom half of the buffer</description></item>
        /// <item><term>Multiview</term><description>Buffer index 0</description><description>Buffer index 1</description></item>
        /// <item><term>Base view</term><description>Entire frame</description><description>Not present</description></item>
        /// </list>
        /// <para/>
        /// By default, the first view is the left view, and the second view is the right view. If the left and
        /// right views are swapped, set the MF_MT_VIDEO_3D_FIRST_IS_LEFT attribute to <strong>FALSE</strong>
        /// in the media type. 
        /// <para/>
        /// <strong>Note</strong> In <em>base view</em> format ( <strong>MFVideo3DSampleFormat_BaseView
        /// </strong>), only the base view is retained, so this attribute does not apply. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4F33BF2D-EB32-46B6-B071-F9130D404201(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4F33BF2D-EB32-46B6-B071-F9130D404201(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_VIDEO_3D_FIRST_IS_LEFT = new Guid(0xec298493, 0xada, 0x4ea1, 0xa4, 0xfe, 0xcb, 0xbd, 0x36, 0xce, 0x93, 0x31);

        /// <summary>
        /// Specifies the rotation of a video frame in the counter-clockwise direction.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>MFVideoRotationFormat</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// Video  from a handheld device, such as a mobile phone, is often rotated by 90, 180, or 270 degrees.
        /// If the camera stores the orientation as metadata in the video file, the image can be adjusted at
        /// the time of playback.
        /// <para/>
        /// If this attribute set to <strong>MFVideoRotationFormat_90</strong>, it means that the content has
        /// been rotated 90 degrees in the counter-clockwise direction. If the content was rotated 90 degrees
        /// in the clockwise direction, the attribute value would be <strong>MFVideoRotationFormat_270</strong>
        /// . 
        /// <para/>
        /// The supported values for this attribute are enumerated in <see cref="MFVideoRotationFormat"/>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7C0911A6-6D7C-4510-891F-A6F56CE1EC2B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7C0911A6-6D7C-4510-891F-A6F56CE1EC2B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_VIDEO_ROTATION = new Guid(0xc380465d, 0x2271, 0x428c, 0x9b, 0x83, 0xec, 0xea, 0x3b, 0x4a, 0x85, 0xc1);

        #endregion

        #region Sample Attributes

        /// <summary>
        /// Contains the decode time stamp (DTS) for the sample.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// </summary>
        /// <remarks>
        /// The value of the attribute is the DTS in 100-nanosecond units. The DTS is defined in some encoding
        /// standards, including MPEG. The DTS specifies when the encoded picture should be decoded. If the
        /// encoded video contains B frames, the DTS can differ from the presentation time, because B pictures
        /// appear out of temporal order in the bitstream.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4E0B8266-FF48-49A1-AB7B-A47C4F96AECD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4E0B8266-FF48-49A1-AB7B-A47C4F96AECD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_DecodeTimestamp = new Guid(0x73a954d4, 0x9e2, 0x4861, 0xbe, 0xfc, 0x94, 0xbd, 0x97, 0xc0, 0x8e, 0x6e);

        /// <summary>
        /// Specifies the quantization parameter (QP) that was used to encode a video sample.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT64"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT64"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFSample"/>
        /// </summary>
        /// <remarks>
        /// The <c>H.264 Video Encoder</c> sets this attribute on the output samples that it generates. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F7C4FEFC-FEE7-4614-BC90-4F9D5D878F49(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F7C4FEFC-FEE7-4614-BC90-4F9D5D878F49(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_VideoEncodeQP = new Guid(0xb2efe478, 0xf979, 0x4c66, 0xb9, 0x5e, 0xee, 0x2b, 0x82, 0xc8, 0x2f, 0x36);

        /// <summary>
        /// Specifies the type of picture that is output by a video encoder.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>eAVEncH264PictureType_B</strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFSample"/>
        /// </summary>
        /// <remarks>
        /// The <c>H.264 Video Encoder</c> sets this attribute on the output samples that it generates. The
        /// value of the attribute is a member of the <c>eAVEncH264PictureType</c> enumeration. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/18A47033-3EAC-46C3-94AB-6ED20732F63C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/18A47033-3EAC-46C3-94AB-6ED20732F63C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_VideoEncodePictureType = new Guid(0x973704e6, 0xcd14, 0x483c, 0x8f, 0x20, 0xc9, 0xfc, 0x9, 0x28, 0xba, 0xd5);

        /// <summary>
        /// Specifies whether a video frame is corrupted.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFSample"/>
        /// </summary>
        /// <remarks>
        /// A video decoder can set this attribute on its output samples. If the value is 1, the decoder
        /// detected data corruption in the frame. If the value is 0, there is no data corruption, or none was
        /// detected.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0218F6F6-6832-445C-B733-6A99E4EA2A3B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0218F6F6-6832-445C-B733-6A99E4EA2A3B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_FrameCorruption = new Guid(0xb4dd4a8c, 0xbeb, 0x44c4, 0x8b, 0x75, 0xb0, 0x2b, 0x91, 0x3b, 0x4, 0xf0);

        // {941ce0a3-6ae3-4dda-9a08-a64298340617}   MFSampleExtension_BottomFieldFirst
        /// <summary>
        /// Specifies the field dominance for an interlaced video frame. This attribute applies to media
        /// samples. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFSample"/>
        /// </summary>
        /// <remarks>
        /// If the video frame is interlaced and the sample contains two interleaved fields, this attribute
        /// indicates which field is displayed first. If <strong>TRUE</strong>, the bottom field is first in
        /// time. If <strong>FALSE</strong>, the top field is first. 
        /// <para/>
        /// If the frame is interlaced and the sample contains a single field, this attribute indicates which
        /// field the sample contains. If <strong>TRUE</strong>, the sample contains the bottom field. If 
        /// <strong>FALSE</strong>, the sample contains the top field. 
        /// <para/>
        /// If the frame is progressive, this attribute describes how the fields should be ordered when the
        /// output is interlaced. If <strong>TRUE</strong>, the bottom field should be output first. If 
        /// <strong>FALSE</strong>, the top field should be output first. 
        /// <para/>
        /// If this attribute not set, the media type describes the field dominance.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/680C42E4-2808-46ED-98A8-C77B14A55DEF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/680C42E4-2808-46ED-98A8-C77B14A55DEF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_BottomFieldFirst = new Guid(0x941ce0a3, 0x6ae3, 0x4dda, 0x9a, 0x08, 0xa6, 0x42, 0x98, 0x34, 0x06, 0x17);

        // MFSampleExtension_CleanPoint {9cdf01d8-a0f0-43ba-b077-eaa06cbd728a}
        /// <summary>
        /// Indicates whether a video sample is a key frame. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFSample"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to samples. If the attribute is <strong>TRUE</strong>, the sample is a key
        /// frame and decoding can begin from this sample. Otherwise, the sample is not a key frame. 
        /// <para/>
        /// If this attribute is not set, the default value is <strong>FALSE</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/03D4BFD8-1148-4551-8E71-05CFBA2E15FA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/03D4BFD8-1148-4551-8E71-05CFBA2E15FA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_CleanPoint = new Guid(0x9cdf01d8, 0xa0f0, 0x43ba, 0xb0, 0x77, 0xea, 0xa0, 0x6c, 0xbd, 0x72, 0x8a);

        // {6852465a-ae1c-4553-8e9b-c3420fcb1637}   MFSampleExtension_DerivedFromTopField
        /// <summary>
        /// Specifies whether a deinterlaced video frame was derived from the upper field or the lower field.
        /// This attribute applies to media samples. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFSample"/>
        /// </summary>
        /// <remarks>
        /// This attribute is valid for deinterlaced samples only. Set this attribute if the frame was
        /// deinterlaced by interpolating one of the fields. 
        /// <para/>
        /// If the value is <strong>TRUE</strong>, the lower field was interpolated from the upper field. If
        /// the value is <strong>FALSE</strong>, the upper field was interpolated from the lower field. 
        /// <para/>
        /// If the attribute is not set, the frame has not been deinterlaced. The frame is either a true
        /// progressive frame, or it is an interlaced frame. 
        /// <para/>
        /// This attribute is informational. A software deinterlacer could set this attribute. If this
        /// attribute is set, it provides a hint that you can recover the original field by dropping the
        /// interpolated scan lines. For example, if the attribute is <strong>TRUE</strong>, you can recover
        /// the original upper field by dropping the interpolated lower field. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3710AB94-AFB3-44D3-A680-B4A716810EC1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3710AB94-AFB3-44D3-A680-B4A716810EC1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_DerivedFromTopField = new Guid(0x6852465a, 0xae1c, 0x4553, 0x8e, 0x9b, 0xc3, 0x42, 0x0f, 0xcb, 0x16, 0x37);

        // MFSampleExtension_MeanAbsoluteDifference {1cdbde11-08b4-4311-a6dd-0f9f371907aa}
        /// <summary>
        /// This attribute returns the mean absolute difference (MAD) across all macro-blocks in the Y plane. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302162(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302162(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_MeanAbsoluteDifference = new Guid(0x1cdbde11, 0x08b4, 0x4311, 0xa6, 0xdd, 0x0f, 0x9f, 0x37, 0x19, 0x07, 0xaa);

        // MFSampleExtension_LongTermReferenceFrameInfo {9154733f-e1bd-41bf-81d3-fcd918f71332}
        /// <summary>
        /// Specifies Long Term Reference (LTR) frame info and is returned on the output sample. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302161(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302161(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_LongTermReferenceFrameInfo = new Guid(0x9154733f, 0xe1bd, 0x41bf, 0x81, 0xd3, 0xfc, 0xd9, 0x18, 0xf7, 0x13, 0x32);

        // MFSampleExtension_ROIRectangle {3414a438-4998-4d2c-be82-be3ca0b24d43}
        /// <summary>
        /// Specifies the bounds of the region of interest which indicates the region of the frame that requires different quality. 
        /// <para/>
        /// <see cref="ROI_AREA"/> stored as <strong>BLOB</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302165(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302165(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_ROIRectangle = new Guid(0x3414a438, 0x4998, 0x4d2c, 0xbe, 0x82, 0xbe, 0x3c, 0xa0, 0xb2, 0x4d, 0x43);

        // MFSampleExtension_PhotoThumbnail {74BBC85C-C8BB-42DC-B586DA17FFD35DCC}
        /// <summary>
        /// Contains the photo thumbnail of a <see cref="IMFSample"/>.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnknown</strong> stored as <strong>IMFMediaBuffer</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302163(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302163(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_PhotoThumbnail = new Guid(0x74BBC85C, 0xC8BB, 0x42DC, 0xB5, 0x86, 0xDA, 0x17, 0xFF, 0xD3, 0x5D, 0xCC);

        // MFSampleExtension_PhotoThumbnailMediaType {61AD5420-EBF8-4143-89AF6BF25F672DEF}
        /// <summary>
        /// Contains the <see cref="IMFMediaType"/> which describes the image format type contained in 
        /// the <see cref="MFSampleExtension_PhotoThumbnail"/> attribute.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnknown</strong> stored as <strong>IMFMediaBuffer</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302164(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302164(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_PhotoThumbnailMediaType = new Guid(0x61AD5420, 0xEBF8, 0x4143, 0x89, 0xAF, 0x6B, 0xF2, 0x5F, 0x67, 0x2D, 0xEF);

        // MFSampleExtension_CaptureMetadata
        /// <summary>
        /// The <see cref="IMFAttributes"/> store for all the metadata related to the capture pipeline.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnknown</strong> stored as <see cref="IMFAttributes"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302157(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302157(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_CaptureMetadata = new Guid(0x2EBE23A8, 0xFAF5, 0x444A, 0xA6, 0xA2, 0xEB, 0x81, 0x08, 0x80, 0xAB, 0x5D);

        /// <summary>
        /// Indicates if a flash was triggered for the captured frame.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302184(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302184(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MF_CAPTURE_METADATA_PHOTO_FRAME_FLASH = new Guid(0x0F9DD6C6, 0x6003, 0x45D8, 0xBD, 0x59, 0xF1, 0xF5, 0x3E, 0x3D, 0x04, 0xE8);

        // MFSampleExtension_Discontinuity {9cdf01d9-a0f0-43ba-b077-eaa06cbd728a}
        /// <summary>
        /// Specifies whether a media sample is the first sample after a gap in the stream. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFSample"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to media samples. If this attribute is <strong>TRUE</strong>, it means there
        /// was a discontinuity in the stream and this sample is the first to appear after the gap. 
        /// <para/>
        /// If this attribute is not set, the default value is <strong>FALSE</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F9E1E700-9958-404D-8B83-08F846F5A1B0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F9E1E700-9958-404D-8B83-08F846F5A1B0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_Discontinuity = new Guid(0x9cdf01d9, 0xa0f0, 0x43ba, 0xb0, 0x77, 0xea, 0xa0, 0x6c, 0xbd, 0x72, 0x8a);

        // {b1d5830a-deb8-40e3-90fa-389943716461}   MFSampleExtension_Interlaced
        /// <summary>
        /// Indicates whether a video frame is interlaced or progressive. If <strong>TRUE</strong>, the frame
        /// is interlaced. If <strong>FALSE</strong>, the frame is progressive. If not set, the media type
        /// describes the interlacing. This attribute applies to media samples. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFSample"/>
        /// </summary>
        /// <remarks>
        /// For video content that contains mixed progressive and interlaced frames, set the media type to
        /// interlaced and use this attribute on each frame to indicate whether the frame is progressive or
        /// interlaced.
        /// <para/>
        /// For video content that is entirely interlaced, set the media type to interlaced and omit this
        /// attribute, or set it to <strong>TRUE</strong> on every sample. 
        /// <para/>
        /// For video content that is entirely progressive, set the media type to progressive and omit this
        /// attribute, or set it to <strong>FALSE</strong> on every sample. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3CB80E75-E803-493B-A22D-E485E77B5177(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3CB80E75-E803-493B-A22D-E485E77B5177(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_Interlaced = new Guid(0xb1d5830a, 0xdeb8, 0x40e3, 0x90, 0xfa, 0x38, 0x99, 0x43, 0x71, 0x64, 0x61);

        // {304d257c-7493-4fbd-b149-9228de8d9a99}   MFSampleExtension_RepeatFirstField
        /// <summary>
        /// Specifies whether to repeat the first field in an interlaced frame. This attribute applies to media
        /// samples. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFSample"/>
        /// </summary>
        /// <remarks>
        /// If the value is <strong>FALSE</strong> or the attribute is not set, the first field is not
        /// repeated. If the value is <strong>TRUE</strong>, the first field is repeated. The value <strong>
        /// TRUE</strong> is valid only when the following conditions are true: 
        /// <para/>
        /// <para>*  The media type is mixed interlaced and progressive. (The 
        /// <see cref="MFAttributesClsid.MF_MT_INTERLACE_MODE"/> attribute attribute on the media type is 
        /// <strong>MFVideoInterlace_MixedInterlaceOrProgressive</strong>.) </para><para>*  The frame is
        /// progressive and the <see cref="MFAttributesClsid.MFSampleExtension_Interlaced"/> attribute on the
        /// sample is <strong>TRUE</strong>. </para><para>*  The 
        /// <see cref="MFAttributesClsid.MFSampleExtension_BottomFieldFirst"/> attribute is set on the sample.
        /// The value can be <strong>TRUE</strong> or <strong>FALSE</strong>. The ordering of the fields is
        /// determined by this attribute. </para>
        /// <para/>
        /// This attribute is used for 3:2 pulldown. The following table shows the order in which fields are
        /// displayed.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>MFSampleExtension_RepeatFirstField</term><description>MFSampleExtension_BottomFieldFirst</description><description>Field order</description></listheader>
        /// <item><term><strong>TRUE</strong></term><description><strong>TRUE</strong></description><description>Lower, upper, lower</description></item>
        /// <item><term><strong>TRUE</strong></term><description><strong>FALSE</strong></description><description>Upper, lower, upper</description></item>
        /// <item><term><strong>FALSE</strong></term><description><strong>TRUE</strong></description><description>Lower, upper</description></item>
        /// <item><term><strong>FALSE</strong></term><description><strong>FALSE</strong></description><description>Upper, lower</description></item>
        /// </list>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C469F418-FA23-443F-8012-0D548EE98C17(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C469F418-FA23-443F-8012-0D548EE98C17(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_RepeatFirstField = new Guid(0x304d257c, 0x7493, 0x4fbd, 0xb1, 0x49, 0x92, 0x28, 0xde, 0x8d, 0x9a, 0x99);

        // {9d85f816-658b-455a-bde0-9fa7e15ab8f9}   MFSampleExtension_SingleField
        /// <summary>
        /// Specifies whether a video sample contains a single field or two interleaved fields. This attribute
        /// applies to media samples. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFSample"/>
        /// </summary>
        /// <remarks>
        /// If the value is <strong>TRUE</strong>, the sample contains one field. If the value is <strong>FALSE
        /// </strong> or the attribute is not set, the sample contains a complete frame. (Two fields if
        /// interlaced, or a progressive frame.) 
        /// <para/>
        /// If the media type is progressive frames or interleaved fields, this attribute must be <strong>FALSE
        /// </strong> or left unset. 
        /// <para/>
        /// If the media type is single field, this attribute must be <strong>TRUE</strong>. Set the 
        /// <see cref="MFAttributesClsid.MFSampleExtension_BottomFieldFirst"/> attribute on the sample to
        /// indicate whether it is the upper field or the lower field. 
        /// <para/>
        /// Currently the enhanced video renderer (EVR) does not support content that switches between
        /// interlaced frames and single fields.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/550619BE-2042-4A2C-9AD2-728474835255(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/550619BE-2042-4A2C-9AD2-728474835255(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_SingleField = new Guid(0x9d85f816, 0x658b, 0x455a, 0xbd, 0xe0, 0x9f, 0xa7, 0xe1, 0x5a, 0xb8, 0xf9);

        // MFSampleExtension_Token {8294da66-f328-4805-b551-00deb4c57a61}
        /// <summary>
        /// Contains a pointer to the token that was provided to the <see cref="IMFMediaStream.RequestSample"/>
        /// method. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnknown*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUnknown"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUnknown"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFSample"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to media samples. The value of the attribute is the <strong>IUnknown
        /// </strong> pointer that is passed to the <em>pToken</em> parameter of the <c>RequestSample</c>
        /// method. The caller uses this attribute to track the status of the request. 
        /// <para/>
        /// If you are writing a custom media source, set this attribute on the sample when the media stream
        /// delivers a sample in response to the <c>RequestSample</c> method, unless the value of <em>pToken
        /// </em> is <strong>NULL</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9403BB15-E912-4AA3-9AF1-FEF4A4F9B242(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9403BB15-E912-4AA3-9AF1-FEF4A4F9B242(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_Token = new Guid(0x8294da66, 0xf328, 0x4805, 0xb5, 0x51, 0x00, 0xde, 0xb4, 0xc5, 0x7a, 0x61);

        // MFSampleExtension_3DVideo                    {F86F97A4-DD54-4e2e-9A5E-55FC2D74A005}
        /// <summary>
        /// Specifies whether a media sample contains a 3D video frame.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// If this attribute is <strong>TRUE</strong>, the media sample contains a video frame that has two or
        /// more stereoscopic views. The default value is <strong>FALSE</strong>. 
        /// <para/>
        /// A component that generates 3D video frames should set this attribute to <strong>TRUE</strong> on
        /// every media sample that contains a 3D frame. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1B0B9DBD-80EB-4876-B2F2-BE419AC84265(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1B0B9DBD-80EB-4876-B2F2-BE419AC84265(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_3DVideo = new Guid(0xf86f97a4, 0xdd54, 0x4e2e, 0x9a, 0x5e, 0x55, 0xfc, 0x2d, 0x74, 0xa0, 0x05);

        // MFSampleExtension_3DVideo_SampleFormat       {08671772-E36F-4cff-97B3-D72E20987A48}
        /// <summary>
        /// Specifies how a 3D video frame is stored in a media sample.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a member of the <see cref="MFVideo3DSampleFormat"/> enumeration. 
        /// <para/>
        /// A component that generates 3D video frames should set this attribute to <strong>TRUE</strong> on
        /// every media sample that contains a 3D frame. The attribute is ignored if the 
        /// <see cref="MFAttributesClsid.MFSampleExtension_3DVideo"/> attribute is <strong>FALSE</strong> or
        /// not set. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1B996B22-C76B-47E5-8937-1E5E672E32EC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1B996B22-C76B-47E5-8937-1E5E672E32EC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_3DVideo_SampleFormat = new Guid(0x8671772, 0xe36f, 0x4cff, 0x97, 0xb3, 0xd7, 0x2e, 0x20, 0x98, 0x7a, 0x48);

        // Sample Grabber Sink Attributes
        /// <summary>
        /// Offset between the time stamp on each sample received by the sample grabber, and the time when the
        /// sample grabber presents the sample. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// </summary>
        /// <remarks>
        /// You can set this attribute on the <see cref="IMFActivate"/> object that is returned by the 
        /// <see cref="MFExtern.MFCreateSampleGrabberSinkActivate"/> function. This attribute enables the
        /// sample grabber's callback function to receive samples earlier than the presentation time. 
        /// <para/>
        /// When the sample grabber receives a new sample, it presents the sample at time <em>t</em> ? <em>
        /// offset</em>, where <em>t</em> is the time stamp on the sample and <em>offset</em> is the value of
        /// this attribute. If this attribute is not set, the default value is zero. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8D06B415-AAFC-4276-9A88-4B7262DF62F1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8D06B415-AAFC-4276-9A88-4B7262DF62F1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SAMPLEGRABBERSINK_SAMPLE_TIME_OFFSET = new Guid(0x62e3d776, 0x8100, 0x4e03, 0xa6, 0xe8, 0xbd, 0x38, 0x57, 0xac, 0x9c, 0x47);

        #endregion

        #region Stream descriptor Attributes

        /// <summary>
        /// Specifies the language for a stream. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Wide-character string
        /// </summary>
        /// <remarks>
        /// The value of this attribute is an RFC 1766-compliant language tag. This attribute applies to stream
        /// descriptors.
        /// <para/>
        /// A media source (or any object that creates a stream descriptor) can set this attribute if the
        /// stream has a specified language. Applications can query this attribute to get the language. If the
        /// attribute is not set, the stream does not have a specified language.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B64A9554-A560-4212-8964-B68EBBADC046(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B64A9554-A560-4212-8964-B68EBBADC046(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SD_LANGUAGE = new Guid(0xaf2180, 0xbdc2, 0x423c, 0xab, 0xca, 0xf5, 0x3, 0x59, 0x3b, 0xc1, 0x21);
        /// <summary>
        /// Indicates whether a stream contains protected content. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute applies to stream descriptors. If the value of the attribute is <strong>TRUE
        /// </strong>, the stream contains protected content. If the value is <strong>FALSE</strong>, or the
        /// attribute is not set, the stream contains clear content. 
        /// <para/>
        /// Instead of checking each stream for this attribute, you can pass a presentation descriptor to the 
        /// <see cref="MFExtern.MFRequireProtectedEnvironment"/> function. This function tests whether the
        /// presentation descriptor contains any protected streams. 
        /// <para/>
        /// A media source should set this attribute on the stream descriptor if the content requires the
        /// protected media path (PMP).
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1C1A201C-4B55-4B86-A08F-D06C1A7DB29D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1C1A201C-4B55-4B86-A08F-D06C1A7DB29D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SD_PROTECTED = new Guid(0xaf2181, 0xbdc2, 0x423c, 0xab, 0xca, 0xf5, 0x3, 0x59, 0x3b, 0xc1, 0x21);
        /// <summary>
        /// Contains the Synchronized Accessible Media Interchange (SAMI) language name that is defined for the
        /// stream. 
        /// <para/>
        /// This attribute is present in the stream descriptors returned from the SAMI media source.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Wide-character string
        /// </summary>
        /// <remarks>
        /// The SAMI language name is specified in the SAMI file.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3151C369-9D2B-4F03-9A4A-9B9267314DC1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3151C369-9D2B-4F03-9A4A-9B9267314DC1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SD_SAMI_LANGUAGE = new Guid(0x36fcb98a, 0x6cd0, 0x44cb, 0xac, 0xb9, 0xa8, 0xf5, 0x60, 0xd, 0xd0, 0xbb);

        #endregion

        #region Topology Attributes

        /// <summary>
        /// Specifies whether the pipeline trims samples. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// By default, the pipeline trims samples to match the correct presentation times. Trimming is done at
        /// the topology nodes that have the <see cref="MFAttributesClsid.MF_TOPONODE_MARKIN_HERE"/> and 
        /// <see cref="MFAttributesClsid.MF_TOPONODE_MARKOUT_HERE"/> attributes. If the <strong>
        /// MF_TOPOLOGY_NO_MARKIN_MARKOUT</strong> attribute is set to <strong>TRUE</strong> on the topology,
        /// the pipeline does not trim samples, and the <strong>MF_TOPONODE_MARKIN_HERE</strong> and <strong>
        /// MF_TOPONODE_MARKOUT_HERE</strong> attributes are ignored. If the attribute is not set, or has the
        /// value <strong>FALSE</strong>, the pipeline trims samples. 
        /// <para/>
        /// An application might set the <strong>MF_TOPOLOGY_NO_MARKIN_MARKOUT</strong> attribute to <strong>
        /// TRUE</strong> if the application receives compressed samples from the pipeline and needs to get all
        /// of the key frames, which might otherwise be trimmed. 
        /// <para/>
        /// The default value of this attribute is <strong>FALSE</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4BA66D18-3854-4994-9509-967303DC7D98(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4BA66D18-3854-4994-9509-967303DC7D98(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPOLOGY_NO_MARKIN_MARKOUT = new Guid(0x7ed3f804, 0x86bb, 0x4b3f, 0xb7, 0xe4, 0x7c, 0xb4, 0x3a, 0xfd, 0x4b, 0x80);
        /// <summary>
        /// Specifies the stop time for a topology, relative to the start of the first topology in the
        /// sequence.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// Treat as a <strong>LONGLONG</strong> value. 
        /// </summary>
        /// <remarks>
        /// The value is given in units of 100 nanoseconds.
        /// <para/>
        /// If the Media Session was created with the <see cref="MFAttributesClsid.MF_SESSION_GLOBAL_TIME"/>
        /// attribute equal to <strong>TRUE</strong>, all topologies must contain the <strong>
        /// MF_TOPOLOGY_PROJECTSTART</strong> attribute. Otherwise, topologies must not contain the <strong>
        /// MF_TOPOLOGY_PROJECTSTART</strong> attribute. For more information, see 
        /// <c>Sequence Presentation Times</c>. 
        /// <para/>
        /// This attribute is a signed value, although it is stored as a <strong>UINT64</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7669F97E-87AD-4A64-A2A5-62B8CE450D80(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7669F97E-87AD-4A64-A2A5-62B8CE450D80(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPOLOGY_PROJECTSTART = new Guid(0x7ed3f802, 0x86bb, 0x4b3f, 0xb7, 0xe4, 0x7c, 0xb4, 0x3a, 0xfd, 0x4b, 0x80);
        /// <summary>
        /// Specifies the start time for a topology, relative to the start of the first topology in the
        /// sequence.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// Treat as a <strong>LONGLONG</strong> value. 
        /// </summary>
        /// <remarks>
        /// The value is given in units of 100 nanoseconds.
        /// <para/>
        /// If the Media Session was created with the <see cref="MFAttributesClsid.MF_SESSION_GLOBAL_TIME"/>
        /// attribute equal to <strong>TRUE</strong>, all topologies must contain the <strong>
        /// MF_TOPOLOGY_PROJECTSTOP</strong> attribute. Otherwise, topologies must not contain the <strong>
        /// MF_TOPOLOGY_PROJECTSTOP</strong> attribute. For more information, see 
        /// <c>Sequence Presentation Times</c>. 
        /// <para/>
        /// This attribute is a signed value, although it is stored as a <strong>UINT64</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1CA3709E-88EA-40CA-8DA4-C2259365122B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1CA3709E-88EA-40CA-8DA4-C2259365122B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPOLOGY_PROJECTSTOP = new Guid(0x7ed3f803, 0x86bb, 0x4b3f, 0xb7, 0xe4, 0x7c, 0xb4, 0x3a, 0xfd, 0x4b, 0x80);
        /// <summary>
        /// Specifies the status of an attempt to resolve a topology. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The topology loader or the Media Session might set this attribute on a topology. The value of this
        /// attribute is a bitwise <strong>OR</strong> of flags from the 
        /// <c>MF_TOPOLOGY_RESOLUTION_STATUS_FLAGS</c> enumeration. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7C2410CE-E70B-4303-9DBC-CAFF4A355D6B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7C2410CE-E70B-4303-9DBC-CAFF4A355D6B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPOLOGY_RESOLUTION_STATUS = new Guid(0x494bbcde, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        #endregion

        #region Topology Node Attributes

        /// <summary>
        /// Specifies how the topology loader connects this topology node, and whether this node is optional. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to all node types.
        /// <para/>
        /// The attribute value is a bitwise <strong>OR</strong> of flags from the 
        /// <see cref="MF_CONNECT_METHOD"/> enumeration. If this attribute is not set, the default value is 
        /// <strong>MF_CONNECT_ALLOW_DECODER</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8D70E1AF-607B-47C3-9808-091C95FD05B7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8D70E1AF-607B-47C3-9808-091C95FD05B7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_CONNECT_METHOD = new Guid(0x494bbcf1, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Specifies whether the transform associated with a topology node supports DirectX Video Acceleration
        /// (DXVA). 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute applies to transform nodes ( <strong>MF_TOPOLOGY_TRANSFORM_NODE</strong>). 
        /// <para/>
        /// Applications typically do not use this attribute directly. The Media Session sets this attribute on
        /// a transform node if the underlying Media Foundation transform has the 
        /// <see cref="MFAttributesClsid.MF_SA_D3D_AWARE"/> attribute. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B9E393BE-0BC0-4CF6-BE44-E9E95339C434(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B9E393BE-0BC0-4CF6-BE44-E9E95339C434(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_D3DAWARE = new Guid(0x494bbced, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Specifies whether a topology node's underlying object is a decoder. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute applies to all node types.
        /// <para/>
        /// If the value of this attribute is nonzero, the node's underlying object is a decoder.
        /// <para/>
        /// The topology loader sets this attribute when it creates a decoder node. An application should set
        /// this attribute if the application manually adds a decoder to the topology.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B6D576DC-B12F-49BF-B938-DB2C629DF400(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B6D576DC-B12F-49BF-B938-DB2C629DF400(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_DECODER = new Guid(0x494bbd02, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Specifies whether a toplogy node's underlying object is a decrypter. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute applies to all node types.
        /// <para/>
        /// If the value of this attribute is nonzero, the node's underlying object is a decrypter.
        /// <para/>
        /// Applications typically do not use this attribute directly. The Media Session sets this attribute
        /// when it creates a node for a decrypter, obtained from the 
        /// <see cref="IMFInputTrustAuthority.GetDecrypter"/> method. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/211789D8-5E51-485C-B8F1-CD0AE3E39250(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/211789D8-5E51-485C-B8F1-CD0AE3E39250(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_DECRYPTOR = new Guid(0x494bbcfa, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Specifies whether the Media Session uses preroll on the media sink represented by this topology
        /// node. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute applies to output nodes ( <strong>MF_TOPOLOGY_OUTPUT_NODE</strong>). 
        /// <para/>
        /// If the value of this attribute is <strong>TRUE</strong>, the Media Session does not preroll any
        /// data to the media sink, even if the media sink exposes the <see cref="IMFMediaSinkPreroll"/>
        /// interface. If the value is <strong>FALSE</strong>, the Media Session prerolls data if the media
        /// sink implements <strong>IMFMediaSinkPreroll</strong>. The default value is <strong>FALSE</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1781F3A0-6BAA-4E06-B2EB-9A8F572AA040(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1781F3A0-6BAA-4E06-B2EB-9A8F572AA040(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_DISABLE_PREROLL = new Guid(0x14932f9e, 0x9087, 0x4bb4, 0x84, 0x12, 0x51, 0x67, 0x14, 0x5c, 0xbe, 0x04);
        /// <summary>
        /// Specifies whether the pipeline can drop samples from a topology node. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// This attribute applies to all node types. Typically you would set this attribute on tee nodes, to
        /// indicate that the secondary outputs are not essential.
        /// <para/>
        /// The value of the attribute is an array of indexes to output streams on the node.
        /// <para/>
        /// If this attribute is set, the pipeline might drop samples from the specified output streams, if the
        /// stream is falling behind.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8BE20446-4876-4D6F-B0DB-2EB1FFAEF9AA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8BE20446-4876-4D6F-B0DB-2EB1FFAEF9AA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_DISCARDABLE = new Guid(0x494bbcfb, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Specifies when a transform is drained. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to transform nodes ( <strong>MF_TOPOLOGY_TRANSFORM_NODE</strong>). 
        /// <para/>
        /// The value of the attribute is a member of the <c>MF_TOPONODE_DRAIN_MODE</c> enumeration. If this
        /// attribute is not set, the default value is <strong>MF_TOPONODE_DRAIN_DEFAULT</strong>. 
        /// <para/>
        /// Draining is performed by calling <see cref="Transform.IMFTransform.ProcessMessage"/> on the
        /// transform with the <c>MFT_MESSAGE_COMMAND_DRAIN</c> message. For more information, see 
        /// <see cref="Transform.MFTMessageType"/> enumeration. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/68332106-D1FE-467B-8BAA-1E592B9CC243(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/68332106-D1FE-467B-8BAA-1E592B9CC243(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_DRAIN = new Guid(0x494bbce9, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Contains the major media type for a topology node. This attribute is set when the topology fails to
        /// load because the correct decoder could not be found. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to all node types.
        /// <para/>
        /// The topology loader might set the attribute. Applications typically read this attribute but do not
        /// set it.
        /// <para/>
        /// For a list of possible values, see <c>Major Media Types</c>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EB837FE6-12C9-479C-A0BE-63B24093E6FD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EB837FE6-12C9-479C-A0BE-63B24093E6FD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_ERROR_MAJORTYPE = new Guid(0x494bbcfd, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Contains the media subtype for a topology node. This attribute is set when the topology fails to
        /// load because the correct decoder could not be found. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to all node types.
        /// <para/>
        /// The topology loader might set the attribute. Applications typically read this attribute but do not
        /// set it.
        /// <para/>
        /// For a list of possible values, see <c>Media Type GUIDs</c>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/89DA33C8-97AF-4C56-8BDB-2AC588810D77(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/89DA33C8-97AF-4C56-8BDB-2AC588810D77(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_ERROR_SUBTYPE = new Guid(0x494bbcfe, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Contains the error code from the most recent connection failure for this toplogy node. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Ttreat as an <strong>HRESULT</strong> value. 
        /// </summary>
        /// <remarks>
        /// This attribute applies to all node types.
        /// <para/>
        /// The value of this attribute is an <strong>HRESULT</strong> value. 
        /// <para/>
        /// The Media Session or the topology loader might set the attribute. Applications typically read this
        /// attribute but do not set it.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FAE90E06-0AE0-43A1-AAF2-7A2D1DABC79B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FAE90E06-0AE0-43A1-AAF2-7A2D1DABC79B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_ERRORCODE = new Guid(0x494bbcee, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Specifies when a transform is flushed. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to transform nodes ( <strong>MF_TOPOLOGY_TRANSFORM_NODE</strong>). 
        /// <para/>
        /// The value of the attribute is a member of the <c>MF_TOPONODE_FLUSH_MODE</c> enumeration. If this
        /// attribute is not set, the default value is <strong>MF_TOPONODE_FLUSH_ALWAYS</strong>. 
        /// <para/>
        /// Flushing is performed by calling <see cref="Transform.IMFTransform.ProcessMessage"/> on the
        /// transform with the <c>MFT_MESSAGE_COMMAND_FLUSH</c> message. For more information, see 
        /// <see cref="Transform.MFTMessageType"/> enumeration. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1E87F58F-546F-4DD4-B218-1458FF17DB53(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1E87F58F-546F-4DD4-B218-1458FF17DB53(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_FLUSH = new Guid(0x494bbce8, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Specifies whether the media types can be changed on this topology node. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute applies to all node types.
        /// <para/>
        /// If value of this attribute is nonzero, the topology loader will not change the media types. This
        /// attribute is set to <strong>TRUE</strong> when the node is in use. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8805ED63-1408-40BC-BB82-F3C51576DFA4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8805ED63-1408-40BC-BB82-F3C51576DFA4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_LOCKED = new Guid(0x494bbcf7, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Specifies whether the pipeline applies mark-in at this node. Mark-in is the point where a
        /// presentation starts. If pipeline components generate data before the mark-in point, the data is not
        /// rendered. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// <strong>Note</strong> Most applications do not need to use this attribute. The <c>Media Session</c>
        /// automatically sets this attribute if needed. 
        /// <para/>
        /// This attribute applies to all node types. If the attribute is <strong>TRUE</strong>, the Media
        /// Foundation pipeline trims the output samples from this node to match the start time for the
        /// presentation. The topology loader sets this attribute when it resolves a topology. 
        /// <para/>
        /// It is recommended that exactly one node in every branch of the topology should have this attribute
        /// set to <strong>TRUE</strong>. A topology branch is defined as the path from a source node to an
        /// output node. Within a branch, the <see cref="MFAttributesClsid.MF_TOPONODE_MARKOUT_HERE"/> and
        /// MF_TOPONODE_MARKIN_HERE attributes must be set on the same node in the branch. They cannot be set
        /// on different nodes within the same branch. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/406145E8-E00E-460D-B282-85FACE457605(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/406145E8-E00E-460D-B282-85FACE457605(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_MARKIN_HERE = new Guid(0x494bbd00, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Specifies whether the pipeline applies mark-out at this node. Mark-out is the point where a
        /// presentation ends. If pipeline components generate data past the mark-out point, the data is not
        /// rendered. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute applies to all node types.
        /// <para/>
        /// If this attribute is <strong>TRUE</strong>, the Media Foundation pipeline trims the output samples
        /// from this node to match the stop time for the presentation. The topology loader sets this attribute
        /// when it resolves a topology. Most applications do not need to set or retrieve this attribute. 
        /// <para/>
        /// It is recommended that exactly one node in every branch of the topology should have this attribute
        /// set to <strong>TRUE</strong>. A topology branch is defined as the path from a source node to an
        /// output node. Within a branch, the MF_TOPONODE_MARKOUT_HERE and 
        /// <see cref="MFAttributesClsid.MF_TOPONODE_MARKIN_HERE"/> attributes must be set on the same node in
        /// the branch. They cannot be set on different nodes within the same branch. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/ADF2361A-90C7-4650-A486-5C450A41AB54(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ADF2361A-90C7-4650-A486-5C450A41AB54(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_MARKOUT_HERE = new Guid(0x494bbd01, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Specifies the start time of the presentation.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// Treat as a <strong>LONGLONG</strong> value. 
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT64"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT64"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFTopologyNode"/>
        /// </summary>
        /// <remarks>
        /// This attribute specifies the position in the source where playback starts, in 100-nanosecond units,
        /// relative to the start the source. If the attribute is not set, playback starts at zero (the start
        /// of the file). For example, to start playback at the 5-second mark, set this attribute to 50000000.
        /// Set the attribute on the source nodes in the topology (nodes with type equal to <strong>
        /// MF_TOPOLOGY_SOURCESTREAM_NODE</strong>). Set the attribute before calling 
        /// <see cref="IMFMediaSession.SetTopology"/>. 
        /// <para/>
        /// <strong>Note</strong> If you manually insert a decoder into the topology, you must also set the 
        /// <see cref="MFAttributesClsid.MF_TOPONODE_MARKIN_HERE"/> and 
        /// <see cref="MFAttributesClsid.MF_TOPONODE_MARKOUT_HERE"/> attributes on the decoder node. 
        /// <para/>
        /// This attribute is a signed value, although it is stored as a <strong>UINT64</strong>. However,
        /// negative values are not meaningful. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A2A64CAC-0DC1-41B0-B59C-A477C7304BA1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A2A64CAC-0DC1-41B0-B59C-A477C7304BA1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_MEDIASTART = new Guid(0x835c58ea, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6);
        /// <summary>
        /// Specifies the stop time of the presentation.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// Treat as a <strong>LONGLONG</strong> value. 
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT64"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT64"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFTopologyNode"/>
        /// </summary>
        /// <remarks>
        /// This attribute specifies the position in the source where playback stops, in 100-nanosecond units,
        /// relative to the start the source. If the attribute is not set, playback stops at the end of the
        /// source. For example, to stop playback at the 5-second mark, set this attribute to 50000000. Set the
        /// attribute on the source nodes in the topology (nodes with type equal to <strong>
        /// MF_TOPOLOGY_SOURCESTREAM_NODE</strong>). Set the attribute before calling 
        /// <see cref="IMFMediaSession.SetTopology"/>. 
        /// <para/>
        /// <strong>Note</strong> If you manually insert a decoder into the topology, you must also set the 
        /// <see cref="MFAttributesClsid.MF_TOPONODE_MARKIN_HERE"/> and 
        /// <see cref="MFAttributesClsid.MF_TOPONODE_MARKOUT_HERE"/> attributes on the decoder node. 
        /// <para/>
        /// After the topology is set, setting this attribute has no effect.
        /// <para/>
        /// This attribute is a signed value, although it is stored as a <strong>UINT64</strong>. However,
        /// negative values are not meaningful. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C1022538-EA9F-41E9-9075-C106E8B16B7B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C1022538-EA9F-41E9-9075-C106E8B16B7B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_MEDIASTOP = new Guid(0x835c58eb, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6);
        /// <summary>
        /// Specifies how the Media Session shuts down an object in the topology.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute applies to the following types of toplogy node: 
        /// <para/>
        /// <para>* Output nodes</para><para>* Any transform node that contains an <em>asynchronous</em> Media
        /// Foundation transform (MFT). </para>
        /// <para/>
        /// The attribute can have the following values:
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term><strong>TRUE</strong></term><description>When the Media Session switches to a new topology or clears the current topology, it does not shut down the object that belongs to this topology node.</description></item>
        /// <item><term><strong>FALSE</strong></term><description>When the Media Session switches to a new topology or clears the current topology, it shuts down the node object, as follows: <para>* Output nodes: The session calls <see cref="IMFMediaSink.Shutdown"/> on the media sink. </para><para>* Transform nodes: The session calls <see cref="IMFShutdown.Shutdown"/> on the MFT. </para></description></item>
        /// </list>
        /// <para/>
        /// The default value is <strong>TRUE</strong>. 
        /// <para/>
        /// If your application queues multiple topologies, it is a good idea to set this attribute to <strong>
        /// FALSE</strong>. Otherwise, objects in the topology might not be shut down correctly. 
        /// <para/>
        /// This attribute does not apply when the application shuts down the Media Session by calling 
        /// <see cref="IMFMediaSession.Shutdown"/>. When the Media Session shuts down, it always shuts down the
        /// media sinks and asynchronous MFTs in the current topology. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/53B4FABA-860F-4D6C-A145-09EA4AE63B8B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/53B4FABA-860F-4D6C-A145-09EA4AE63B8B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_NOSHUTDOWN_ON_REMOVE = new Guid(0x14932f9c, 0x9087, 0x4bb4, 0x84, 0x12, 0x51, 0x67, 0x14, 0x5c, 0xbe, 0x04);
        /// <summary>
        /// Contains a pointer to the presentation descriptor for the media source. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to source nodes ( <strong>MF_TOPOLOGY_SOURCESTREAM_NODE</strong>). 
        /// <para/>
        /// The value of the attribute is a pointer to the presentation descriptor's 
        /// <see cref="IMFPresentationDescriptor"/> interface. This attribute is required. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4F2C1AD8-FDA9-482F-B82A-9838D15D2785(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4F2C1AD8-FDA9-482F-B82A-9838D15D2785(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_PRESENTATION_DESCRIPTOR = new Guid(0x835c58ed, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6);
        /// <summary>
        /// Indicates which output is the primary output on a tee node. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to tee nodes ( <strong>MF_TOPOLOGY_TEE_NODE</strong>). 
        /// <para/>
        /// The value of this attribute is the zero-based index of an output connection on this tee node. This
        /// value indicates which output is the primary output stream. The pipeline waits for a request from
        /// the primary output before processing requests from the other outputs.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F7D98837-75DA-48CC-8307-091BE2D95392(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F7D98837-75DA-48CC-8307-091BE2D95392(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_PRIMARYOUTPUT = new Guid(0x6304ef99, 0x16b2, 0x4ebe, 0x9d, 0x67, 0xe4, 0xc5, 0x39, 0xb3, 0xa2, 0x59);
        /// <summary>
        /// Specifies whether the media sink associated with this topology node is rateless. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute applies to output nodes ( <strong>MF_TOPOLOGY_OUTPUT_NODE</strong>). 
        /// <para/>
        /// If the value of this attribute is nonzero, the Media Session treats the media sink as a rateless
        /// sink, regardless of whether the media sink returns the <strong>MEDIASINK_RATELESS</strong>
        /// characteristic. If this attribute is not set, the media sink is assumed not to be rateless. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/81EF7005-A9AB-4F26-BC39-68B27C4F92AA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/81EF7005-A9AB-4F26-BC39-68B27C4F92AA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_RATELESS = new Guid(0x14932f9d, 0x9087, 0x4bb4, 0x84, 0x12, 0x51, 0x67, 0x14, 0x5c, 0xbe, 0x04);
        /// <summary>
        /// Specifies the element that contains this source node. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to source nodes ( <strong>MF_TOPOLOGY_SOURCESTREAM_NODE</strong>). 
        /// <para/>
        /// The media pipeline uses this attribute to discover when media sources are part of the same element.
        /// The pipeline treats all source nodes that are part of the same element as having the same clock.
        /// <para/>
        /// When the pipeline queues up a new topology that contains source nodes that are part of an element
        /// that is present in the previous topology, the pipeline treats these source nodes as having the same
        /// clock as the source nodes from that element in the previous topology.
        /// <para/>
        /// <strong>Note</strong> The media pipeline does not correct time stamps for source nodes with
        /// different clock rates. 
        /// <para/>
        /// A media source that can provide topologies should implement the 
        /// <see cref="IMFMediaSourceTopologyProvider"/> interface or the <see cref="IMFSequencerSource"/>
        /// interface. A media source that provides topologies should set the <strong>
        /// MF_TOPONODE_SEQUENCE_ELEMENTID</strong> attribute on every source node that it creates. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F5FA5C10-8F30-43BD-8054-A39996F807A3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F5FA5C10-8F30-43BD-8054-A39996F807A3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_SEQUENCE_ELEMENTID = new Guid(0x835c58ef, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6);
        /// <summary>
        /// Contains a pointer to the media source associated with a topology node. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to source nodes ( <strong>MF_TOPOLOGY_SOURCESTREAM_NODE</strong>). 
        /// <para/>
        /// The value of the atttribute is a pointer to the media source's <see cref="IMFMediaSource"/>
        /// interface. This attribute is required. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/73B84AB6-BDC2-4B22-9CE4-B79B954476E5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/73B84AB6-BDC2-4B22-9CE4-B79B954476E5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_SOURCE = new Guid(0x835c58ec, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6);
        /// <summary>
        /// Contains a pointer to the stream descriptor for the media source. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to source nodes ( <strong>MF_TOPOLOGY_SOURCESTREAM_NODE</strong>). 
        /// <para/>
        /// The value of the attribute is a pointer to the stream descriptor's 
        /// <see cref="IMFStreamDescriptor"/> interface. This attribute is required. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5ACAFBC1-823F-4B6D-8737-04B3A6A0CF87(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5ACAFBC1-823F-4B6D-8737-04B3A6A0CF87(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_STREAM_DESCRIPTOR = new Guid(0x835c58ee, 0xe075, 0x4bc7, 0xbc, 0xba, 0x4d, 0xe0, 0x00, 0xdf, 0x9a, 0xe6);
        /// <summary>
        /// The stream identifier of the stream sink associated with this topology node. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to output nodes ( <strong>MF_TOPOLOGY_OUTPUT_NODE</strong>). 
        /// <para/>
        /// When the Media Session loads the topology, it queries the media sink for a stream sink with the
        /// specified identifier. If that fails, it attempts to add a new stream sink to the media sink.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0B8060AB-1463-45C2-8277-D15122561248(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0B8060AB-1463-45C2-8277-D15122561248(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_STREAMID = new Guid(0x14932f9b, 0x9087, 0x4bb4, 0x84, 0x12, 0x51, 0x67, 0x14, 0x5c, 0xbe, 0x04);
        /// <summary>
        /// The class identifier (CLSID) of the Media Foundation transform (MFT) associated with this topology
        /// node. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to transform nodes ( <strong>MF_TOPOLOGY_TRANSFORM_NODE</strong>). 
        /// <para/>
        /// Applications can use this attribute to initialize a transfrom node. If you set this attribute, you
        /// do not have to call <see cref="IMFTopologyNode.SetObject"/> with a pointer to an MFT or activation
        /// object. Conversely, if you call <strong>SetObject</strong>, you do not need to set this attribute.
        /// For more information, see <c>Creating Topologies</c>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6AA6E649-D23D-4D8D-BE80-2B8814B07A57(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6AA6E649-D23D-4D8D-BE80-2B8814B07A57(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_TRANSFORM_OBJECTID = new Guid(0x88dcc0c9, 0x293e, 0x4e8b, 0x9a, 0xeb, 0xa, 0xd6, 0x4c, 0xc0, 0x16, 0xb0);
        /// <summary>
        /// Specifies a work queue for a topology branch.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to source nodes ( <strong>MF_TOPOLOGY_SOURCESTREAM_NODE</strong>). The
        /// attribute is optional. 
        /// <para/>
        /// The value of the attribute is an application-defined identifier for the work queue. 
        /// <para/>
        /// Applications can use this attribute to assign work queues to branches of the topology. Each source
        /// node in the topology defines one branch. The branch includes every topology node that receives data
        /// from that node. 
        /// <para/>
        /// If you set this attribute, call the 
        /// <see cref="IMFWorkQueueServices.BeginRegisterTopologyWorkQueuesWithMMCSS"/> method on the resolved
        /// topology. Multiple branches in the topology can share the same work queue, and work queues can be
        /// re-used across topologies. 
        /// <para/>
        /// <strong>Note</strong> The value of this attribute is not the same as the identifier that is
        /// returned by the <see cref="MFExtern.MFAllocateWorkQueue"/> function. The value of the attribute is
        /// an application-defined identifier, and is used to associate topology branches with work queues.
        /// When the Media Session allocates a new work queue, it stores the actual work-queue identifier
        /// internally. 
        /// <para/>
        /// If this attribute it set, the application can also assign the branch to a Multimedia Class
        /// Scheduler Service (MMCSS) task, by setting the 
        /// <see cref="MFAttributesClsid.MF_TOPONODE_WORKQUEUE_MMCSS_CLASS"/> attribute. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5BC7E2DB-CFD2-4B94-B4D6-FE2B9EA9DAF8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5BC7E2DB-CFD2-4B94-B4D6-FE2B9EA9DAF8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_WORKQUEUE_ID = new Guid(0x494bbcf8, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Specifies a <c>Multimedia Class Scheduler Service</c> (MMCSS) task for a topology branch. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Wide-character string
        /// </summary>
        /// <remarks>
        /// This attribute applies to source nodes ( <strong>MF_TOPOLOGY_SOURCESTREAM_NODE</strong>). This
        /// attribute is optional. 
        /// <para/>
        /// This attribute requires the <see cref="MFAttributesClsid.MF_TOPONODE_WORKQUEUE_ID"/> attribute. If
        /// you set this attribute, also set the <strong>MF_TOPONODE_WORKQUEUE_ID</strong> attribute is set on
        /// the same node. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8668D0F1-9D54-4C56-BB19-09498252BEC4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8668D0F1-9D54-4C56-BB19-09498252BEC4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_WORKQUEUE_MMCSS_CLASS = new Guid(0x494bbcf9, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);
        /// <summary>
        /// Specifies a Multimedia Class Scheduler Service (MMCSS) task identifier for a topology branch. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to source nodes ( <strong>MF_TOPOLOGY_SOURCESTREAM_NODE</strong>). This
        /// attribute is optional. 
        /// <para/>
        /// This attribute is ignored unless the following attributes are also set:
        /// <para/>
        /// <para>* <see cref="MFAttributesClsid.MF_TOPONODE_WORKQUEUE_ID"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_TOPONODE_WORKQUEUE_MMCSS_CLASS"/></para>
        /// <para/>
        /// If the application registers one of its own threads with MMCSS, you can use this attribute to
        /// associate the topology work queue with the application's MMCSS group. Set the attribute value equal
        /// to the task identifier that the application received when it registered with MMCSS. (The task
        /// identifier is returned in the <em>TaskIndex</em> parameter of the 
        /// <c>AvSetMmThreadCharacteristics</c> function. For more information, see the topic 
        /// <c>Process and Thread Functions</c>.) 
        /// <para/>
        /// If you want MMCSS to assign a new task identifier for the topology, set the 
        /// <see cref="MFAttributesClsid.MF_TOPONODE_WORKQUEUE_MMCSS_CLASS"/> attribute, but do not set the 
        /// <strong>MF_TOPONODE_WORKQUEUE_MMCSS_TASKID</strong> attribute. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CCECC1E6-2D30-4E89-849F-C3ACAD97F312(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CCECC1E6-2D30-4E89-849F-C3ACAD97F312(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_WORKQUEUE_MMCSS_TASKID = new Guid(0x494bbcff, 0xb031, 0x4e38, 0x97, 0xc4, 0xd5, 0x42, 0x2d, 0xd6, 0x18, 0xdc);

        #endregion

        #region Transform Attributes

        /// <summary>
        /// Specifies whether the Topology Loader will change the media types on a Media Foundation transform
        /// (MFT). Applications typically do not use this attribute. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// If value of this attribute is nonzero, the topology loader will not change the media types on the
        /// MFT. The topology loader sets this attribute after it loads the topology.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/96A99F35-F9DB-407E-A4E3-7ADC3CACCB19(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/96A99F35-F9DB-407E-A4E3-7ADC3CACCB19(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_ACTIVATE_MFT_LOCKED = new Guid(0xc1f6093c, 0x7f65, 0x4fbd, 0x9e, 0x39, 0x5f, 0xae, 0xc3, 0xc4, 0xfb, 0xd7);
        /// <summary>
        /// Specifies whether a Media Foundation transform (MFT) supports DirectX Video Acceleration (DXVA).
        /// This attribute applies only to video MFTs. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// To query this attribute, call <see cref="Transform.IMFTransform.GetAttributes"/> to get the global
        /// attribute store of the MFT. If <strong>GetAttributes</strong> succeeds, call 
        /// <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// This attribute tells the client whether the MFT can use Direct3D 9 video:
        /// <para/>
        /// <para>* If the attribute is nonzero, the client can give the MFT a pointer to the 
        /// <c>IDirect3DDeviceManager9</c> interface before streaming starts. To do so, the client sends the 
        /// <c>MFT_MESSAGE_SET_D3D_MANAGER</c> message to the MFT. The client is not required to send this
        /// message. </para><para>* If this attribute is zero ( <strong>FALSE</strong>), the MFT does not
        /// support Direct3D 9 video, and the client should not send the <c>MFT_MESSAGE_SET_D3D_MANAGER</c>
        /// message to the MFT. </para>
        /// <para/>
        /// The default value of this attribute is <strong>FALSE</strong>. Treat this attribute as read-only.
        /// Do not change the value; the MFT will ignore any changes to the value. 
        /// <para/>
        /// For more information about implementing this attribute in a custom MFT, see 
        /// <c>Direct3D-Aware MFTs</c>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DB6A8B20-FDA0-4FFE-B1B5-A77B7604D290(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DB6A8B20-FDA0-4FFE-B1B5-A77B7604D290(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SA_D3D_AWARE = new Guid(0xeaa35c29, 0x775e, 0x488e, 0x9b, 0x61, 0xb3, 0x28, 0x3e, 0x49, 0x58, 0x3b);
        /// <summary>
        /// Specifies whether a Media Foundation transform (MFT) supports 3D stereoscopic video.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// To query this attribute, call <see cref="Transform.IMFTransform.GetAttributes"/> to get the global
        /// attribute store of the MFT. If <strong>GetAttributes</strong> succeeds, call 
        /// <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// The default value of this attribute is <strong>FALSE</strong>. Treat this attribute as read-only.
        /// Do not change the value; the MFT will ignore any changes to the value. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DE96FD14-5C7E-4560-99AC-B1EBDA1EBB2B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DE96FD14-5C7E-4560-99AC-B1EBDA1EBB2B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_SUPPORT_3DVIDEO = new Guid(0x93f81b1, 0x4f2e, 0x4631, 0x81, 0x68, 0x79, 0x34, 0x3, 0x2a, 0x1, 0xd3);

        // {53476A11-3F13-49fb-AC42-EE2733C96741} MFT_SUPPORT_DYNAMIC_FORMAT_CHANGE {UINT32 (BOOL)}
        /// <summary>
        /// Specifies whether a Media Foundation transform (MFT) supports dynamic format changes. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute can have the following values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term><strong>TRUE</strong></term><description>The client can change the input format during streaming.</description></item>
        /// <item><term><strong>FALSE</strong></term><description>The MFT must be drained before the client can change the input format.</description></item>
        /// </list>
        /// <para/>
        /// To get this attribute, first call <see cref="Transform.IMFTransform.GetAttributes"/> to get the
        /// global attribute store for the MFT. Then call <see cref="IMFAttributes.GetUINT32"/> to get the
        /// attribute value. 
        /// <para/>
        /// If <c>GetAttributes</c> fails or the attribute is not present, the default value if <strong>FALSE
        /// </strong>. 
        /// <para/>
        /// <c>Asynchronous MFTs</c> must return the value <strong>TRUE</strong>. 
        /// <para/>
        /// For more information, see <c>Handling Stream Changes</c>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/64D32C78-8BEE-4D3C-A770-5A097CB71B13(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/64D32C78-8BEE-4D3C-A770-5A097CB71B13(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_SUPPORT_DYNAMIC_FORMAT_CHANGE = new Guid(0x53476a11, 0x3f13, 0x49fb, 0xac, 0x42, 0xee, 0x27, 0x33, 0xc9, 0x67, 0x41);

        /// <summary>
        /// Specifies whether the H.264 video remux MFT should mark I pictures as clean point for better seek-ability. 
        /// This has the potential for corruptions on seeks in non-conforming final MP4 files. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>Bool</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302175(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302175(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_REMUX_MARK_I_PICTURE_AS_CLEAN_POINT = new Guid(0x364e8f85, 0x3f2e, 0x436c, 0xb2, 0xa2, 0x44, 0x40, 0xa0, 0x12, 0xa9, 0xe8);

        /// <summary>
        /// Specifies that the MFT encoder supports receiving <see cref="MediaEventType.MEEncodingParameters"/> events while streaming.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>Bool</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302174(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302174(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_ENCODER_SUPPORTS_CONFIG_EVENT = new Guid(0x86a355ae, 0x3a77, 0x4ec4, 0x9f, 0x31, 0x1, 0x14, 0x9a, 0x4e, 0x92, 0xde);

        #endregion

        #region Presentation Descriptor Attributes

        /// <summary>
        /// Contains a pointer to the presentation descriptor from the Protected Media Path (PMP). 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// The media source proxy, which is created in the PMP process, uses this attribute to store the
        /// remote presentation descriptor on the application's presentation descriptor.
        /// <para/>
        /// The value of this attribute is a pointer to the <see cref="IMFPresentationDescriptor"/> interface. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CF12552E-0963-46FA-9A26-44DD601AB68C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CF12552E-0963-46FA-9A26-44DD601AB68C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_APP_CONTEXT = new Guid(0x6c990d32, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);
        /// <summary>
        /// Specifies the duration of a presentation, in 100-nanosecond units. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// Treat as a <strong>LONGLONG</strong> value. 
        /// </summary>
        /// <remarks>
        /// Media sources can set this attribute on a presentation descriptor to indicate the duration of the
        /// presentation.
        /// <para/>
        /// This attribute is a signed value, although it is stored as a <strong>UINT64</strong>. However, the
        /// attribute should never contain a negative value. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/ABC21696-EA97-41FF-9341-6D9E9DCB19EC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ABC21696-EA97-41FF-9341-6D9E9DCB19EC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_DURATION = new Guid(0x6c990d33, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);
        /// <summary>
        /// Specifies when a presentation was last modified. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// Media sources can set this attribute on a presentation descriptor. The value of the attribute is a 
        /// <strong>FILETIME</strong> structure, which is documented in the Windows SDK. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/12990DE2-7656-4781-943B-C46F42A0E38D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/12990DE2-7656-4781-943B-C46F42A0E38D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_LAST_MODIFIED_TIME = new Guid(0x6c990d38, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);
        /// <summary>
        /// Specifies the MIME type of the content. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Wide-character string
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BBCFB3E6-A86A-4621-B8D9-92ACE60E8C10(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BBCFB3E6-A86A-4621-B8D9-92ACE60E8C10(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_MIME_TYPE = new Guid(0x6c990d37, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);
        /// <summary>
        /// Contains a pointer to the proxy object for the application's presentation descriptor. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// The Protected Media Path (PMP) host uses this attribute to store the application's presentation
        /// descriptor on the remote presentation descriptor. The attribute value is a pointer to the 
        /// <see cref="IMFRemoteProxy"/> interface. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0CD83204-0D32-417C-8911-1D3358EB0802(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0CD83204-0D32-417C-8911-1D3358EB0802(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_PMPHOST_CONTEXT = new Guid(0x6c990d31, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);
        /// <summary>
        /// Contains the friendly names of the Synchronized Accessible Media Interchange (SAMI) styles defined
        /// in the SAMI file.
        /// <para/>
        /// The <c>SAMI Media Source</c> sets this attribute on the presentation descriptor that it creates. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// The attribute blob has the following structure: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data Type</term><description>Description</description><description>Size (bytes)</description></listheader>
        /// <item><term><strong>DWORD</strong></term><description>Number of style strings.</description><description>4</description></item>
        /// <item><term>For each style string:</term></item>
        /// <item><term><strong>DWORD</strong></term><description>Size of the string in bytes, including the <strong>NULL</strong> character. </description><description>4</description></item>
        /// <item><term><strong>LPWSTR</strong></term><description>Null-terminated wide-character string containing the name of the style.</description><description>Varies</description></item>
        /// </list>
        /// <para/>
        /// To set the style or retrieve the current style, use the <see cref="IMFSAMIStyle"/> interface. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BC679F0E-17F6-455C-8A00-1D435538EF86(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BC679F0E-17F6-455C-8A00-1D435538EF86(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_SAMI_STYLELIST = new Guid(0xe0b73c7f, 0x486d, 0x484e, 0x98, 0x72, 0x4d, 0xe5, 0x19, 0x2a, 0x7b, 0xf8);
        /// <summary>
        /// Specifies the total size of the source file, in bytes. This attribute applies to presentation
        /// descriptors. A media source can optionally set this attribute. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// </summary>
        /// <remarks>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/722EBB14-C3E8-4F83-8FA2-E006B1094A59(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/722EBB14-C3E8-4F83-8FA2-E006B1094A59(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_TOTAL_FILE_SIZE = new Guid(0x6c990d34, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);
        /// <summary>
        /// Specifies the audio encoding bit rate for the presentation, in bits per second. This attribute
        /// applies to presentation descriptors. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The attribute is optional. Some formats have more complex encoding schemes that cannot be
        /// summarized by using this attribute. For Advanced Systems Format (ASF) files, the following
        /// attributes collectively describe the encoding bit rate:
        /// <para/>
        /// <para>* <see cref="MFAttributesClsid.MF_PD_ASF_FILEPROPERTIES_MAX_BITRATE"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_SD_ASF_EXTSTRMPROP_AVG_DATA_BITRATE"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_SD_ASF_EXTSTRMPROP_MAX_DATA_BITRATE"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_SD_ASF_STREAMBITRATES_BITRATE"/></para>
        /// <para/>
        /// Third-party formats might use other custom attributes.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/700F61F4-A0D7-4B69-ACE5-356E4E29B93D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/700F61F4-A0D7-4B69-ACE5-356E4E29B93D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_AUDIO_ENCODING_BITRATE = new Guid(0x6c990d35, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);
        /// <summary>
        /// Specifies the video encoding bit rate for the presentation, in bits per second. This attribute
        /// applies to presentation descriptors. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute is optional. Some formats have more complex encoding schemes that cannot be
        /// summarized by using this attribute. For Advanced Systems Format (ASF) files, the following
        /// attributes collectively describe the encoding bit rate:
        /// <para/>
        /// <para>* <see cref="MFAttributesClsid.MF_PD_ASF_FILEPROPERTIES_MAX_BITRATE"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_SD_ASF_EXTSTRMPROP_AVG_DATA_BITRATE"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_SD_ASF_EXTSTRMPROP_MAX_DATA_BITRATE"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_SD_ASF_STREAMBITRATES_BITRATE"/></para>
        /// <para/>
        /// Third-party formats might use other custom attributes.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0FE8CF64-2256-4E48-9853-2C734F97F3C7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0FE8CF64-2256-4E48-9853-2C734F97F3C7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_VIDEO_ENCODING_BITRATE = new Guid(0x6c990d36, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);

        #endregion

        #region wmcontainer.h Attributes

        /// <summary>
        /// Specifies the file identifier of an Advanced Systems Format (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/096C2E1A-7FD7-49AB-AA24-7D7C779D9E79(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/096C2E1A-7FD7-49AB-AA24-7D7C779D9E79(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_FILEPROPERTIES_FILE_ID = new Guid(0x3de649b4, 0xd76d, 0x4e66, 0x9e, 0xc9, 0x78, 0x12, 0xf, 0xb4, 0xc7, 0xe3);
        /// <summary>
        /// Specifies the date and time when an Advanced Systems Format (ASF) file was created. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content. The value of the attribute is a
        /// <strong>FILETIME</strong> structure, which is documented in the Windows SDK. 
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/97F80584-9D74-4BA5-80F4-DDB6F2BC4625(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/97F80584-9D74-4BA5-80F4-DDB6F2BC4625(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_FILEPROPERTIES_CREATION_TIME = new Guid(0x3de649b6, 0xd76d, 0x4e66, 0x9e, 0xc9, 0x78, 0x12, 0xf, 0xb4, 0xc7, 0xe3);
        /// <summary>
        /// Specifies the number of packets in the data section of an Advanced Systems Format (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/29CF2412-0A9A-4CF5-B0C3-668204C1C352(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/29CF2412-0A9A-4CF5-B0C3-668204C1C352(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_FILEPROPERTIES_PACKETS = new Guid(0x3de649b7, 0xd76d, 0x4e66, 0x9e, 0xc9, 0x78, 0x12, 0xf, 0xb4, 0xc7, 0xe3);
        /// <summary>
        /// Specifies the time needed to play an Advanced Systems Format (ASF) file, in 100-nanosecond units.
        /// <para/>
        /// This value includes the preroll time. To retrieve the actual playback duration, get the value of
        /// the <see cref="MFAttributesClsid.MF_PD_DURATION"/> attribute. However, if the preroll value is
        /// greater than the play duration, the value of <strong>MF_PD_DURATION</strong> is zero. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content. 
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3D36808B-AA13-4205-AD92-97E951EE827E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3D36808B-AA13-4205-AD92-97E951EE827E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_FILEPROPERTIES_PLAY_DURATION = new Guid(0x3de649b8, 0xd76d, 0x4e66, 0x9e, 0xc9, 0x78, 0x12, 0xf, 0xb4, 0xc7, 0xe3);
        /// <summary>
        /// Specifies the time, in 100-nanosecond units, needed to send an Advanced Systems Format (ASF) file.
        /// A packet's <em>send time</em> is the time when the packet should be delivered over the network. It
        /// is not the presentation time of the packet. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2BD427E2-106D-4997-86AA-FAE221E429EB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2BD427E2-106D-4997-86AA-FAE221E429EB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_FILEPROPERTIES_SEND_DURATION = new Guid(0x3de649b9, 0xd76d, 0x4e66, 0x9e, 0xc9, 0x78, 0x12, 0xf, 0xb4, 0xc7, 0xe3);
        /// <summary>
        /// Specifies the amount of time, in milliseconds, to buffer data before playing an Advanced Systems
        /// Format (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6AEBE1CF-BD45-4B02-A3C8-6599BB683D7C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6AEBE1CF-BD45-4B02-A3C8-6599BB683D7C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_FILEPROPERTIES_PREROLL = new Guid(0x3de649ba, 0xd76d, 0x4e66, 0x9e, 0xc9, 0x78, 0x12, 0xf, 0xb4, 0xc7, 0xe3);
        /// <summary>
        /// Specifies whether an Advanced Systems Format (ASF) file is broadcast or seekable. This value
        /// corresponds to the Flags field of the File Properties Object, defined in the ASF specification. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content. The value of the attribute is a
        /// bitwise OR of the following flags:
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Flag</term><description>Description</description></listheader>
        /// <item><term>0x01</term><description>Broadcast flag. The file is in the process of being created.</description></item>
        /// <item><term>0x02</term><description>Seekable flag. The file is seekable.A file is seekable if an audio stream is present and the maximum data packet size equals the minimum data packet size. It can also be seekable if the file has an audio stream and a video stream with a matching Simple Index Object.</description></item>
        /// </list>
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// If the broadcast flag is set, the following attributes in the presentation descriptor are not
        /// valid:
        /// <para/>
        /// <para>* <see cref="MFAttributesClsid.MF_PD_ASF_FILEPROPERTIES_FILE_ID"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_PD_ASF_FILEPROPERTIES_CREATION_TIME"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_PD_ASF_FILEPROPERTIES_PACKETS"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_PD_ASF_FILEPROPERTIES_PLAY_DURATION"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_PD_ASF_FILEPROPERTIES_SEND_DURATION"/></para>
        /// <para/>
        /// In addition, the <see cref="MFAttributesClsid.MF_PD_ASF_FILEPROPERTIES_MAX_PACKET_SIZE"/> attribute
        /// and <see cref="MFAttributesClsid.MF_PD_ASF_FILEPROPERTIES_MIN_PACKET_SIZE"/> attribute values are
        /// set to the actual packet size. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/427F0DCA-F945-4C89-A87A-A7C86291B1C5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/427F0DCA-F945-4C89-A87A-A7C86291B1C5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_FILEPROPERTIES_FLAGS = new Guid(0x3de649bb, 0xd76d, 0x4e66, 0x9e, 0xc9, 0x78, 0x12, 0xf, 0xb4, 0xc7, 0xe3);
        /// <summary>
        /// Specifies the minimum packet size, in bytes, for an Advanced Systems Format (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8C62DB36-1332-4565-9FC0-885B9FC148E1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8C62DB36-1332-4565-9FC0-885B9FC148E1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_FILEPROPERTIES_MIN_PACKET_SIZE = new Guid(0x3de649bc, 0xd76d, 0x4e66, 0x9e, 0xc9, 0x78, 0x12, 0xf, 0xb4, 0xc7, 0xe3);
        /// <summary>
        /// Specifies the maximum packet size, in bytes, of an Advanced Systems Format (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8DCAE150-2363-47BA-B0D3-0BC182574D81(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8DCAE150-2363-47BA-B0D3-0BC182574D81(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_FILEPROPERTIES_MAX_PACKET_SIZE = new Guid(0x3de649bd, 0xd76d, 0x4e66, 0x9e, 0xc9, 0x78, 0x12, 0xf, 0xb4, 0xc7, 0xe3);
        /// <summary>
        /// Specifies the maximum instantaneous bit rate, in bits per second, for an Advanced Systems Format
        /// (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/07E94448-13A9-4EA5-9AC7-A1E35668E0A0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/07E94448-13A9-4EA5-9AC7-A1E35668E0A0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_FILEPROPERTIES_MAX_BITRATE = new Guid(0x3de649be, 0xd76d, 0x4e66, 0x9e, 0xc9, 0x78, 0x12, 0xf, 0xb4, 0xc7, 0xe3);
        /// <summary>
        /// Specifies the type of protection mechanism used in an Advanced Systems Format (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Wide-character string
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method retrieves the Protection
        /// Type field, converts it into a wide-character string, and then populates a null-terminated array of
        /// <strong>WCHAR</strong>s. If present, the value must be "DRM". The size of the array equals the
        /// Protection Type Field Length field of the Content Encryption Header. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/91CEB610-6FF4-4133-BEAB-6DEBB94EEC2C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/91CEB610-6FF4-4133-BEAB-6DEBB94EEC2C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_CONTENTENCRYPTION_TYPE = new Guid(0x8520fe3d, 0x277e, 0x46ea, 0x99, 0xe4, 0xe3, 0xa, 0x86, 0xdb, 0x12, 0xbe);
        /// <summary>
        /// Specifies the key identifier for an encrypted Advanced Systems Format (ASF) file. This attribute
        /// corresponds to the Key ID field of the Content Encryption Header, defined in the ASF specification.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Wide-character string
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method retrieves the Key ID
        /// field, converts it into a wide-character string, and then populates a null-terminated array of 
        /// <strong>WCHAR</strong>s. The size of the array equals the Key ID Length field of the Content
        /// Encryption Header. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EBADD156-28F4-499C-A182-F48A35ECBEFB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EBADD156-28F4-499C-A182-F48A35ECBEFB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_CONTENTENCRYPTION_KEYID = new Guid(0x8520fe3e, 0x277e, 0x46ea, 0x99, 0xe4, 0xe3, 0xa, 0x86, 0xdb, 0x12, 0xbe);
        /// <summary>
        /// Contains secret data for an encrypted Advanced Systems Format (ASF) file. This attribute
        /// corresponds to the Secret Data field of the Content Encryption Header, defined in the ASF
        /// specification. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method populates a byte array
        /// with the Secret Data field. The size of the array equals the Secret Data Length field of the
        /// Content Encryption Header. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E6CE71D6-59CD-42DA-906A-AB71F2BEF16F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E6CE71D6-59CD-42DA-906A-AB71F2BEF16F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_CONTENTENCRYPTION_SECRET_DATA = new Guid(0x8520fe3f, 0x277e, 0x46ea, 0x99, 0xe4, 0xe3, 0xa, 0x86, 0xdb, 0x12, 0xbe);
        /// <summary>
        /// Specifies the license acquisition URL for an encrypted Advanced Systems Format (ASF) file. This
        /// attribute corresponds to the License URL field of the Content Encryption Header, defined in the ASF
        /// specification. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Wide-character string
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method retrieves the License URL
        /// field, converts it into a wide-character string, and then populates a null-terminated array of 
        /// <strong>WCHAR</strong>s. The size of the array equals the License URL Length field of the Content
        /// Encryption Header. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FE431C38-8227-4385-AC6F-72B9982CDE62(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FE431C38-8227-4385-AC6F-72B9982CDE62(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_CONTENTENCRYPTION_LICENSE_URL = new Guid(0x8520fe40, 0x277e, 0x46ea, 0x99, 0xe4, 0xe3, 0xa, 0x86, 0xdb, 0x12, 0xbe);
        /// <summary>
        /// Contains encryption data for an Advanced Systems Format (ASF) file. This attribute corresponds to
        /// the Extended Content Encryption Object in the ASF header, defined in the ASF specification. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method creates the presentation
        /// descriptor and generates this attribute from the Extended Content Encryption Object header. The
        /// size of the blob equals the Data Size field. The byte array contained in the blob equals the Data
        /// field in the Extended Content Encryption object of the ASF header. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8BF5E7A4-073F-4B2C-8E9C-49F6F11C9093(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8BF5E7A4-073F-4B2C-8E9C-49F6F11C9093(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_CONTENTENCRYPTIONEX_ENCRYPTION_DATA = new Guid(0x62508be5, 0xecdf, 0x4924, 0xa3, 0x59, 0x72, 0xba, 0xb3, 0x39, 0x7b, 0x9d);
        /// <summary>
        /// Specifies a list of language identifiers which specifies the languages contained in an Advanced
        /// Systems Format (ASF) file. This attribute corresponds to the Language List Object, defined in the
        /// ASF specification. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method creates the presentation
        /// descriptor and generates this attribute from the Language List Object header. The following table
        /// shows the format of the blob: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Language List Object field</term><description>Data type</description><description>Size</description><description>Description</description></listheader>
        /// <item><term>Language ID Records Count</term><description><strong>DWORD</strong></description><description>4 bytes</description><description>Number of languages</description></item>
        /// <item><term>Language ID Records</term><description><strong>BYTE</strong>[] </description><description>Varies</description><description>Array of language strings (see below).</description></item>
        /// </list>
        /// <para/>
        /// The first <strong>DWORD</strong> is the number of languages, followed by an array of language
        /// identifier strings. Each string has the following format: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Language List Object field</term><description>Data type</description><description>Size</description><description>Description</description></listheader>
        /// <item><term>Language ID Length</term><description><strong>DWORD</strong></description><description>4 bytes</description><description>The length of the string in bytes, including the size of the trailing <strong>NULL</strong> character. </description></item>
        /// <item><term>Language ID</term><description><strong>WCHAR</strong>[] </description><description>Varies</description><description>A null-terminated string containing the RFC 1766 language name.</description></item>
        /// </list>
        /// <para/>
        /// Each string is a language tag compliant with RFC 1766. 
        /// <para/>
        /// To get the language tag for a particular stream in the ASF file, query the stream descriptor for
        /// the <see cref="MFAttributesClsid.MF_SD_ASF_EXTSTRMPROP_LANGUAGE_ID_INDEX"/> attribute. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/07B8A991-B392-47C1-A6D7-A1F5DCC82E5C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/07B8A991-B392-47C1-A6D7-A1F5DCC82E5C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_LANGLIST = new Guid(0xf23de43c, 0x9977, 0x460d, 0xa6, 0xec, 0x32, 0x93, 0x7f, 0x16, 0xf, 0x7d);
        /// <summary>
        /// Specifies the markers in an Advanced Systems Format (ASF) file. This attribute corresponds to the
        /// Marker Object in the ASF header, defined in the ASF specification. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method creates the presentation
        /// descriptor and generates this attribute from the Marker Object. The following table shows the
        /// format of the blob: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Marker Object field</term><description>Data type</description><description>Size</description><description>Description</description></listheader>
        /// <item><term>Markers Count</term><description><strong>DWORD</strong></description><description>4 bytes</description><description>Number of markers</description></item>
        /// <item><term>Markers</term><description><strong>BYTE</strong>[] </description><description>Varies</description><description>Array of markers</description></item>
        /// </list>
        /// <para/>
        /// The first <strong>DWORD</strong> is the number of markers, followed by an array of markers. Each
        /// marker has the following format: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Marker Object field</term><description>Data type</description><description>Size</description><description>Description</description></listheader>
        /// <item><term>Marker Description Length</term><description><strong>DWORD</strong></description><description>4 bytes</description><description>Size of the description string, in bytes, including the NULL character.</description></item>
        /// <item><term>Marker Description</term><description><strong>WCHAR</strong>[] </description><description>Varies</description><description>Null-terminated string that describes the marker.</description></item>
        /// <item><term>Presentation Time</term><description><strong>LONGLONG</strong></description><description>8 bytes</description><description>Presentation time of the marker, in 100-nanosecond units.</description></item>
        /// <item><term>Send Time</term><description><strong>LONGLONG</strong></description><description>8 bytes</description><description>Send time of the marker entry, in milliseconds.</description></item>
        /// <item><term>Offset</term><description><strong>UINT64</strong></description><description>8 bytes</description><description>Offset, in bytes, into the Data Object that specifies the position of the market.</description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6458EB5F-72A2-4723-B26B-B63516AA2DF3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6458EB5F-72A2-4723-B26B-B63516AA2DF3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_MARKER = new Guid(0x5134330e, 0x83a6, 0x475e, 0xa9, 0xd5, 0x4f, 0xb8, 0x75, 0xfb, 0x2e, 0x31);
        /// <summary>
        /// Specifies a list of script commands and the parameters for an Advanced Systems Format (ASF) file.
        /// This attribute corresponds to the Script Command Object in the ASF header, defined in the ASF
        /// specification. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method creates the presentation
        /// descriptor and generates this attribute from the Script Command Object header. The following table
        /// shows the format of the blob: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Script Command Object field</term><description>Data type</description><description>Size</description><description>Description</description></listheader>
        /// <item><term>Commands Count</term><description><strong>DWORD</strong></description><description>4 bytes</description><description>Number of script commands</description></item>
        /// <item><term>Command Type, Commands</term><description><strong>BYTE</strong>[] </description><description>Varies</description><description>Array of script commands</description></item>
        /// </list>
        /// <para/>
        /// The first <strong>DWORD</strong> is the number of script commands, followed by an array of
        /// commands. Each script command has the following format: 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Script Command Object field</term><description>Data type</description><description>Size</description><description>Description</description></listheader>
        /// <item><term>Command Name Length</term><description><strong>DWORD</strong></description><description>4 bytes</description><description>Size of the command string, in bytes, including the NULL character.</description></item>
        /// <item><term>Command Name</term><description><strong>WCHAR</strong>[] </description><description>Varies</description><description>Null-terminated string that contains the script command.</description></item>
        /// <item><term>Command Type Name Length</term><description><strong>DWORD</strong></description><description>4 bytes</description><description>Size of the command type string, in bytes, including the NULL character.</description></item>
        /// <item><term>Command Type Name</term><description><strong>WCHAR</strong>[] </description><description>Varies</description><description>Null-terminated string that contains the command type.</description></item>
        /// <item><term>Presentation Time</term><description><strong>DWORD</strong></description><description>4 bytes</description><description>Presentation time of the command in milliseconds.</description></item>
        /// </list>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C85C9DA4-F0B5-4055-A645-2A71CABBE4A3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C85C9DA4-F0B5-4055-A645-2A71CABBE4A3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_SCRIPT = new Guid(0xe29cd0d7, 0xd602, 0x4923, 0xa7, 0xfe, 0x73, 0xfd, 0x97, 0xec, 0xc6, 0x50);
        /// <summary>
        /// Contains information about the codecs and formats that were used to encode the content in an
        /// Advanced Systems Format (ASF) file. This attribute corresponds to the Codec List Object in the ASF
        /// header, defined in the ASF specification. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method creates the presentation
        /// descriptor and generates this attribute from the Codec List Object in the ASF header. An
        /// application that uses the <c>ASF Media Source</c> can get this attribute by calling 
        /// <see cref="IMFMediaSource.CreatePresentationDescriptor"/> and then getting the attribute from the
        /// presentation descriptor. 
        /// <para/>
        /// The following table shows the layout of the attribute blob. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Codec List Object field</term><description>Data type</description><description>Size</description><description>Description</description></listheader>
        /// <item><term>Codec Entries Count</term><description><strong>DWORD</strong></description><description>4 bytes</description><description>Number of codecs</description></item>
        /// <item><term>Codec Entries</term><description><strong>BYTE</strong>[] </description><description>Varies</description><description>Array of codec information structures</description></item>
        /// </list>
        /// <para/>
        /// The Code Entries field is an array of structures. The following table shows the format of each
        /// entry:
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Codec List Object field</term><description>Data type</description><description>Size</description><description>Description</description></listheader>
        /// <item><term>Type</term><description><strong>DWORD</strong></description><description>4 bytes</description><description>Codec type. This can be one of the following values:<para>*  0x0001: Audio codec </para><para>*  0x0002: Video codec </para><para>*  0xFFFF: Unknown </para></description></item>
        /// <item><term>Codec Name Length</term><description><strong>DWORD</strong></description><description>4 bytes</description><description>Size of the Codec Name string, in bytes, including the <strong>NULL</strong> character. </description></item>
        /// <item><term>Codec Name</term><description><strong>WCHAR</strong>[] </description><description>Varies</description><description>Null-terminated Unicode string that contains the name of the codec, such as "Windows Media Video 9".</description></item>
        /// <item><term>Codec Description Length</term><description><strong>DWORD</strong></description><description>4 bytes</description><description>Size of the Codec Description string, in bytes, including the <strong>NULL</strong> character. </description></item>
        /// <item><term>Codec Description</term><description><strong>WCHAR</strong>[] </description><description>Varies</description><description>A null-terminated Unicode string that contains a description of the codec.</description></item>
        /// <item><term>Codec Information Length</term><description><strong>DWORD</strong></description><description>4 bytes</description><description>Size of the Codec Information field, in bytes.</description></item>
        /// <item><term>Codec Information</term><description><strong>BYTE</strong>[] </description><description>Varies</description><description>Codec data. The meaning of this data depends on the codec. Typically, this data indicates the format.</description></item>
        /// </list>
        /// <para/>
        /// <strong>Note</strong> The layout of the attribute blob does not exactly match the layout of the
        /// Codec List Object in the ASF header. In particular, string lengths are given in bytes and include
        /// the size of the <strong>NULL</strong> terminator. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6DDE30D3-DBDC-469C-AD7E-5E670B7E0A64(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6DDE30D3-DBDC-469C-AD7E-5E670B7E0A64(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_CODECLIST = new Guid(0xe4bb3509, 0xc18d, 0x4df1, 0xbb, 0x99, 0x7a, 0x36, 0xb3, 0xcc, 0x41, 0x19);
        /// <summary>
        /// Specifies whether an Advanced Systems Format (ASF) file uses variable bit rate (VBR) encoding. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content. If the value is <strong>TRUE
        /// </strong>, the file was encoded using VBR. If the value is <strong>FALSE</strong> or the attribute
        /// is not present, the file does not use VBR encoding. 
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// and sets it on the presentation descriptor. 
        /// <para/>
        /// <strong>Note</strong> This attribute corresponds to the <strong>IsVBR</strong> attribute in the
        /// Windows Media Format SDK. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/69888D66-8E96-4A20-B8C5-A01267FF3C05(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/69888D66-8E96-4A20-B8C5-A01267FF3C05(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_METADATA_IS_VBR = new Guid(0x5fc6947a, 0xef60, 0x445d, 0xb4, 0x49, 0x44, 0x2e, 0xcc, 0x78, 0xb4, 0xc1);
        /// <summary>
        /// Specifies the highest momentary bit rate in a variable bit rate (VBR) Advanced Systems Format (ASF)
        /// file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute.
        /// <para/>
        /// <strong>Note</strong> This attribute applies only to files created by version 8 of the Windows
        /// Media Format SDK. It corresponds to the <strong>VBRPeak</strong> attribute in the Windows Media
        /// Format SDK. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A31F447D-B718-4F8D-B0D5-643497339557(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A31F447D-B718-4F8D-B0D5-643497339557(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_METADATA_V8_VBRPEAK = new Guid(0x5fc6947b, 0xef60, 0x445d, 0xb4, 0x49, 0x44, 0x2e, 0xcc, 0x78, 0xb4, 0xc1);
        /// <summary>
        /// Specifies the average buffer size needed for a variable bit rate (VBR) Advanced Systems Format
        /// (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// that applies to the presentation descriptor for ASF content. 
        /// <para/>
        /// <strong>Note</strong> This attribute applies only to files created by version 8 of the Windows
        /// Media Format SDK. It corresponds to the <strong>BufferAverage</strong> attribute in the Windows
        /// Media Format SDK. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/508D8670-5F5F-422B-9FA1-150115E2DBB8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/508D8670-5F5F-422B-9FA1-150115E2DBB8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_METADATA_V8_BUFFERAVERAGE = new Guid(0x5fc6947c, 0xef60, 0x445d, 0xb4, 0x49, 0x44, 0x2e, 0xcc, 0x78, 0xb4, 0xc1);
        /// <summary>
        /// Specifies a list of bit rates and corresponding buffer windows for a variable bit rate (VBR) Advanced Systems Format (ASF) file. 
        /// <para/>
        /// Data type: <strong>byte array</strong>.
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute 
        /// that applies to the presentation descriptor for ASF content.
        /// <para/>
        /// The value of the attribute has the following format:
        /// <para/>
        /// <code language="cpp" title="C/C++ Syntax">
        /// struct {
        ///    WORD wReserved;
        ///    WM_LEAKY_BUCKET_PAIR bucket[2];
        /// };
        /// typedef struct _WMLeakyBucketPair {
        ///    DWORD  dwBitrate;
        ///    DWORD  msBufferWindow;
        /// } WM_LEAKY_BUCKET_PAIR;
        /// </code>
        /// <para/>
        /// Online documentation: <a href="http://msdn.microsoft.com/en-US/library/windows/apps/aa376591(v=vs.85).aspx">http://msdn.microsoft.com/en-US/library/windows/apps/aa376591(v=vs.85).aspx</a>.
        /// </remarks>
        public static readonly Guid MF_PD_ASF_METADATA_LEAKY_BUCKET_PAIRS = new Guid(0x5fc6947d, 0xef60, 0x445d, 0xb4, 0x49, 0x44, 0x2e, 0xcc, 0x78, 0xb4, 0xc1);
        /// <summary>
        /// Specifies the offset, in bytes, from the start of an Advanced Systems Format (ASF) file to the
        /// start of the first data packet. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5145D952-19D9-4BF8-9046-0B5D28F5E641(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5145D952-19D9-4BF8-9046-0B5D28F5E641(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_DATA_START_OFFSET = new Guid(0xe7d5b3e7, 0x1f29, 0x45d3, 0x88, 0x22, 0x3e, 0x78, 0xfa, 0xe2, 0x72, 0xed);
        /// <summary>
        /// Specifies the size, in bytes, of the data section of an Advanced Systems Format (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/93A0BF27-23DB-4E8A-B471-A42122E8F9AA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/93A0BF27-23DB-4E8A-B471-A42122E8F9AA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_DATA_LENGTH = new Guid(0xe7d5b3e8, 0x1f29, 0x45d3, 0x88, 0x22, 0x3e, 0x78, 0xfa, 0xe2, 0x72, 0xed);
        /// <summary>
        /// Specifies the language used by a stream in an Advanced Systems Format (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to stream descriptors for ASF content. The value is an index into the
        /// language list contained in the <see cref="MFAttributesClsid.MF_PD_ASF_LANGLIST"/> attribute. 
        /// <para/>
        /// This attribute corresponds to the Stream Language ID Index field in the Extended Stream Properties
        /// object. For more information, refer to the ASF specification.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. The application can create the stream descriptor for the stream from the
        /// presentation descriptor by calling 
        /// <see cref="IMFPresentationDescriptor.GetStreamDescriptorByIndex"/>. 
        /// <para/>
        /// You can also get the language tag by querying the stream descriptor for the 
        /// <see cref="MFAttributesClsid.MF_SD_LANGUAGE"/> attribute. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/834CAC0A-0C84-49AA-BAF2-32BAE26E215B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/834CAC0A-0C84-49AA-BAF2-32BAE26E215B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SD_ASF_EXTSTRMPROP_LANGUAGE_ID_INDEX = new Guid(0x48f8a522, 0x305d, 0x422d, 0x85, 0x24, 0x25, 0x2, 0xdd, 0xa3, 0x36, 0x80);
        /// <summary>
        /// Specifies the average data bit rate, in bits per second, of a stream in an Advanced Systems Format
        /// (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to stream descriptors for ASF content. It corresponds to the Data Bit Rate
        /// field in the Extended Stream Properties object, and defines the leak rate used in the "leaky
        /// bucket" model. For more information, refer to the ASF specification.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. The application can create the stream descriptor for the stream from the
        /// presentation descriptor by calling 
        /// <see cref="IMFPresentationDescriptor.GetStreamDescriptorByIndex"/>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3A0B39AB-E9A9-49DF-A321-A88559AEC16F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3A0B39AB-E9A9-49DF-A321-A88559AEC16F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SD_ASF_EXTSTRMPROP_AVG_DATA_BITRATE = new Guid(0x48f8a523, 0x305d, 0x422d, 0x85, 0x24, 0x25, 0x2, 0xdd, 0xa3, 0x36, 0x80);
        /// <summary>
        /// Specifies the average buffer size, in bytes, needed for a stream in an Advanced Systems Format
        /// (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to stream descriptors for ASF content. It corresponds to the Buffer Size
        /// field in the Extended Stream Properties object, and defines the bucket size used in the "leaky
        /// bucket" model. For more information, refer to the ASF specification.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. The application can create the stream descriptor for the stream from the
        /// presentation descriptor by calling 
        /// <see cref="IMFPresentationDescriptor.GetStreamDescriptorByIndex"/>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9E9259A2-6FB7-4A24-8D14-841F2CC8C3EF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9E9259A2-6FB7-4A24-8D14-841F2CC8C3EF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SD_ASF_EXTSTRMPROP_AVG_BUFFERSIZE = new Guid(0x48f8a524, 0x305d, 0x422d, 0x85, 0x24, 0x25, 0x2, 0xdd, 0xa3, 0x36, 0x80);
        /// <summary>
        /// Specifies the maximum data bit rate, in bits per second, of a stream in an Advanced Systems Format
        /// (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to stream descriptors for ASF content. It corresponds to the Alternate Data
        /// Bit Rate field in the Extended Stream Properties object. For more information, refer to the ASF
        /// specification.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. The application can create the stream descriptor for the stream from the
        /// presentation descriptor by calling 
        /// <see cref="IMFPresentationDescriptor.GetStreamDescriptorByIndex"/>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D20D374A-A259-4E89-8EEB-942BBE53E959(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D20D374A-A259-4E89-8EEB-942BBE53E959(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SD_ASF_EXTSTRMPROP_MAX_DATA_BITRATE = new Guid(0x48f8a525, 0x305d, 0x422d, 0x85, 0x24, 0x25, 0x2, 0xdd, 0xa3, 0x36, 0x80);
        /// <summary>
        /// Specifies the maximum buffer size, in bytes, needed for a stream in an Advanced Systems Format
        /// (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to stream descriptors for ASF content. It corresponds to the Alternate
        /// Buffer Size field in the Extended Stream Properties object. For more information, refer to the ASF
        /// specification.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. The application can create the stream descriptor for the stream from the
        /// presentation descriptor by calling 
        /// <see cref="IMFPresentationDescriptor.GetStreamDescriptorByIndex"/>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1704A70A-A52B-4E7D-8A32-D0C4E97F8CC2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1704A70A-A52B-4E7D-8A32-D0C4E97F8CC2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SD_ASF_EXTSTRMPROP_MAX_BUFFERSIZE = new Guid(0x48f8a526, 0x305d, 0x422d, 0x85, 0x24, 0x25, 0x2, 0xdd, 0xa3, 0x36, 0x80);
        /// <summary>
        /// Specifies the average bit rate, in bits per second, of a stream in an Advanced Systems Format (ASF)
        /// file. This attribute corresponds to the Stream Bitrate Properties Object defined in the ASF
        /// specification. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// and sets it on the stream descriptor. The application can create the stream descriptor for the
        /// stream from the presentation descriptor by calling 
        /// <see cref="IMFPresentationDescriptor.GetStreamDescriptorByIndex"/>. 
        /// <para/>
        /// The attribute value equals the Average Bit Rate field in the Stream Bit Rate Properties object.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7EC6004F-C71B-413F-B2FD-DC03A5BF8C57(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7EC6004F-C71B-413F-B2FD-DC03A5BF8C57(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SD_ASF_STREAMBITRATES_BITRATE = new Guid(0xa8e182ed, 0xafc8, 0x43d0, 0xb0, 0xd1, 0xf6, 0x5b, 0xad, 0x9d, 0xa5, 0x58);
        /// <summary>
        /// Specifies the device conformance template for a stream in an Advanced Systems Format (ASF) file. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Wide-character string
        /// </summary>
        /// <remarks>
        /// This attribute applies to stream descriptors for ASF content. For more information about device
        /// conformance templates, see the topic "Device Conformance Template Parameters" in the Windows Media
        /// Format SDK.
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E0BFB393-C8DE-47CF-B80A-B0D88722E815(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E0BFB393-C8DE-47CF-B80A-B0D88722E815(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SD_ASF_METADATA_DEVICE_CONFORMANCE_TEMPLATE = new Guid(0x245e929d, 0xc44e, 0x4f7e, 0xbb, 0x3c, 0x77, 0xd4, 0xdf, 0xd2, 0x7f, 0x8a);
        /// <summary>
        /// Specifies whether an Advanced Systems Format (ASF) file contains any audio streams. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content. If the value is <strong>TRUE
        /// </strong>, the file has at least one audio stream. Otherwise, the file does not contain any audio
        /// streams. 
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B7C5CD67-FD2A-49D8-8DE5-61783A3B4577(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B7C5CD67-FD2A-49D8-8DE5-61783A3B4577(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_INFO_HAS_AUDIO = new Guid(0x80e62295, 0x2296, 0x4a44, 0xb3, 0x1c, 0xd1, 0x3, 0xc6, 0xfe, 0xd2, 0x3c);
        /// <summary>
        /// Specifies whether an Advanced Systems Format (ASF) file contains at least one video stream. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content. If the value is <strong>TRUE
        /// </strong>, the file has at least one video stream. Otherwise, the file does not contain any video
        /// streams. 
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/98411C75-519F-4ACE-999F-1EA22457ED4A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/98411C75-519F-4ACE-999F-1EA22457ED4A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_INFO_HAS_VIDEO = new Guid(0x80e62296, 0x2296, 0x4a44, 0xb3, 0x1c, 0xd1, 0x3, 0xc6, 0xfe, 0xd2, 0x3c);
        /// <summary>
        /// Specifies whether an Advanced Systems Format (ASF) file contains any streams that are not audio or
        /// video. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as a Boolean value.
        /// </summary>
        /// <remarks>
        /// This attribute applies to presentation descriptors for ASF content. If the value is <strong>TRUE
        /// </strong>, the file has at least one stream that is not audio or video. Examples include image
        /// streams, script commands, and custom arbitrary data. 
        /// <para/>
        /// The <see cref="IMFASFContentInfo.GeneratePresentationDescriptor"/> method generates this attribute
        /// from the ASF metadata. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CCD61F50-29FB-4A50-80C9-D23D71D768F3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CCD61F50-29FB-4A50-80C9-D23D71D768F3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_ASF_INFO_HAS_NON_AUDIO_VIDEO = new Guid(0x80e62297, 0x2296, 0x4a44, 0xb3, 0x1c, 0xd1, 0x3, 0xc6, 0xfe, 0xd2, 0x3c);
        /// <summary>
        /// Sets the average "leaky bucket" parameters (see Remarks) for encoding a Windows Media file. Set
        /// this attribute by using the <see cref="IMFASFStreamConfig"/> interface. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// The value of this attribute is an array of three <strong>DWORD</strong>s, in the following order: 
        /// <para/>
        /// <para>*  Bit rate, in bits per second. </para><para>*  Buffer window, in milliseconds.</para>
        /// <para>*  Initial buffer fullness, in bytes. </para>
        /// <para/>
        /// For more information about the leaky bucket concept, see the topic 
        /// <c>The Leaky Bucket Buffer Model</c> in the Windows Media Format SDK documentation. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5AA570EB-1004-4942-9A63-B8F6373D4E53(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5AA570EB-1004-4942-9A63-B8F6373D4E53(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_ASFSTREAMCONFIG_LEAKYBUCKET1 = new Guid(0xc69b5901, 0xea1a, 0x4c9b, 0xb6, 0x92, 0xe2, 0xa0, 0xd2, 0x9a, 0x8a, 0xdd);
        /// <summary>
        /// Sets the peak "leaky bucket" parameters (see Remarks) for encoding a Windows Media file. These
        /// parameters are used for the peak bit rate. Set this attribute by using the 
        /// <see cref="IMFASFStreamConfig"/> interface. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong></strong>
        /// <para/>
        /// Byte array
        /// </summary>
        /// <remarks>
        /// The value of this attribute is an array of three <strong>DWORD</strong>s, in the following order: 
        /// <para/>
        /// <para>*  Bit rate, in bits per second. </para><para>*  Buffer window, in milliseconds.</para>
        /// <para>*  Initial buffer fullness, in bytes. </para>
        /// <para/>
        /// For more information about the leaky bucket concept, see the topic 
        /// <c>The Leaky Bucket Buffer Model</c> in the Windows Media Format SDK documentation. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/422D6D1B-4D29-4156-877B-8DC3BCB7580F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/422D6D1B-4D29-4156-877B-8DC3BCB7580F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_ASFSTREAMCONFIG_LEAKYBUCKET2 = new Guid(0xc69b5902, 0xea1a, 0x4c9b, 0xb6, 0x92, 0xe2, 0xa0, 0xd2, 0x9a, 0x8a, 0xdd);

        #endregion

        #region Arbitrary

        // {9E6BD6F5-0109-4f95-84AC-9309153A19FC}   MF_MT_ARBITRARY_HEADER          {MT_ARBITRARY_HEADER}
        /// <summary>
        /// Type-specific data for a binary stream in an Advanced Systems Format (ASF) file.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong><see cref="MT_ARBITRARY_HEADER"/></strong> stored as <strong>BYTE[]</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetBlob"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetBlob"/>. 
        /// </summary>
        /// <remarks>
        /// ASF files can contain streams with binary data. The MF_MT_ARBITRARY_HEADER attribute in the media
        /// type contains an <see cref="MT_ARBITRARY_HEADER"/> structure that describes the stream. 
        /// <para/>
        /// In addition to the  MF_MT_ARBITRARY_HEADER attribute, the media type for an ASF binary stream
        /// contains the following attributes:
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_MT_MAJOR_TYPE"/></term><description>The value of the attribute is <strong>MFMediaType_Binary</strong>. </description></item>
        /// <item><term><see cref="MFAttributesClsid.MF_MT_ARBITRARY_FORMAT"/></term><description>Contains additional format data.</description></item>
        /// </list>
        /// <para/>
        /// <strong>Note</strong> In the Windows Media Format SDK, binary streams are called <em>arbitrary
        /// streams</em> or <em>arbitrary data streams</em>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/45608DDE-894B-4204-80DC-505F068FB158(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/45608DDE-894B-4204-80DC-505F068FB158(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_ARBITRARY_HEADER = new Guid(0x9e6bd6f5, 0x109, 0x4f95, 0x84, 0xac, 0x93, 0x9, 0x15, 0x3a, 0x19, 0xfc);

        // {5A75B249-0D7D-49a1-A1C3-E0D87F0CADE5}   MF_MT_ARBITRARY_FORMAT          {Blob}
        /// <summary>
        /// Additional format data for a binary stream in an Advanced Systems Format (ASF) file.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BYTE[]</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetBlob"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetBlob"/>. 
        /// </summary>
        /// <remarks>
        /// Applications can use binary streams to hold custom data types. The ASF media source treats the
        /// value of this attribute as an opaque blob. The <strong>formattype</strong> member of the 
        /// <see cref="MT_ARBITRARY_HEADER"/> structure defines the layout of the format data. 
        /// <para/>
        /// This structure corresponds to the Format Data field of the type-specific data in the Stream
        /// Properties Object, in files where the stream type is <strong>ASF_Binary_Media</strong>. For more
        /// information, see the ASF specification. 
        /// <para/>
        /// <strong>Note</strong> In the Windows Media Format SDK, binary streams are called <em>arbitrary
        /// streams</em> or <em>arbitrary data streams</em>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FC5B9890-1508-498E-B2CE-ED4FA2052F9C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FC5B9890-1508-498E-B2CE-ED4FA2052F9C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_ARBITRARY_FORMAT = new Guid(0x5a75b249, 0xd7d, 0x49a1, 0xa1, 0xc3, 0xe0, 0xd8, 0x7f, 0xc, 0xad, 0xe5);

        #endregion

        #region Image

        // {ED062CF4-E34E-4922-BE99-934032133D7C}   MF_MT_IMAGE_LOSS_TOLERANT       {UINT32 (BOOL)}
        /// <summary>
        /// Specifies whether an ASF image stream is a degradable JPEG type.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// This attribute applies to the media type for image streams in ASF. If the value is <strong>TRUE
        /// </strong>, the stream is a degradable JPEG image type. Otherwise, the stream is a JFIF image type.
        /// For more information about these stream types, see the ASF specification. 
        /// <para/>
        /// In addition to the  MF_MT_IMAGE_LOSS_TOLERANT attribute, the media type for an ASF image stream
        /// contains the following attributes:
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Attribute</term><description>Description</description></listheader>
        /// <item><term><see cref="MFAttributesClsid.MF_MT_MAJOR_TYPE"/></term><description>Contains the value <strong>MFMediaType_Image</strong>. </description></item>
        /// <item><term><see cref="MFAttributesClsid.MF_MT_FRAME_SIZE"/></term><description>Gives the image size in pixels.</description></item>
        /// </list>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E29D0893-8561-4A8C-99E2-168186BECD82(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E29D0893-8561-4A8C-99E2-168186BECD82(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_IMAGE_LOSS_TOLERANT = new Guid(0xed062cf4, 0xe34e, 0x4922, 0xbe, 0x99, 0x93, 0x40, 0x32, 0x13, 0x3d, 0x7c);

        #endregion

        #region MPEG-4 Media Type Attributes

        // {261E9D83-9529-4B8F-A111-8B9C950A81A9}   MF_MT_MPEG4_SAMPLE_DESCRIPTION   {BLOB}
        /// <summary>
        /// Contains the sample description box for an MP4 or 3GP file.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BYTE[]</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetBlob"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetBlob"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// The sample description box describes the encoding used for a stream in the file.
        /// <para/>
        /// The MPEG-4 file source sets this attribute on the media type for each stream. The value of the
        /// attribute is the raw data in the sample description box. If the MPEG-4  file source can parse the
        /// sample description, it also adds the format details to the media type. Otherwise, the application
        /// or the decoder must parse the sample description from the MF_MT_MPEG4_SAMPLE_DESCRIPTION attribute.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EA157988-BD15-465C-BD6A-6D33CC1A0323(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EA157988-BD15-465C-BD6A-6D33CC1A0323(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_MPEG4_SAMPLE_DESCRIPTION = new Guid(0x261e9d83, 0x9529, 0x4b8f, 0xa1, 0x11, 0x8b, 0x9c, 0x95, 0x0a, 0x81, 0xa9);

        // {9aa7e155-b64a-4c1d-a500-455d600b6560}   MF_MT_MPEG4_CURRENT_SAMPLE_ENTRY {UINT32}
        /// <summary>
        /// Specifies the current entry in the sample description box for an MPEG-4 media type.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// In an MP4 or 3GP file, the sample description box  describes the encoding used for a stream in the
        /// file. The sample description box can contain multiple entries. This attribute specifies which entry
        /// to use. The value is a zero-based index into the list.
        /// <para/>
        /// Currently, the only supported value is 0. The attribute has been defined for future extensibility.
        /// <para/>
        /// The MPEG-4 file source always sets the value to 0. The MP4 and 3GP file sinks ignore the value of
        /// this attribute if it is present.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C8C36ABF-6905-4874-A6D2-90DD0725421B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C8C36ABF-6905-4874-A6D2-90DD0725421B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_MPEG4_CURRENT_SAMPLE_ENTRY = new Guid(0x9aa7e155, 0xb64a, 0x4c1d, 0xa5, 0x00, 0x45, 0x5d, 0x60, 0x0b, 0x65, 0x60);

        #endregion 

        #region Save original format information for AVI and WAV files

        // {d7be3fe0-2bc7-492d-b843-61a1919b70c3}   MF_MT_ORIGINAL_4CC               (UINT32)
        /// <summary>
        /// Contains the original codec FOURCC for a video stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// Depending on the source file, the AVI media source might set this attribute on the media types that
        /// it offers.
        /// <para/>
        /// An AVI file contains a stream header for each stream in the file. The AVI media source translates
        /// the stream header into a media type. For compressed video streams, the stream header contains a
        /// FOURCC that identifies the video codec. In most cases, the AVI media source converts this FOURCC
        /// directly to a subtype GUID, as described in the topic <c>Video Subtype GUIDs</c>. In some cases,
        /// however, it maps the original FOURCC to another FOURCC that is equivalent. If so, the media source
        /// stores the original FOURCC in the media type, using the MF_MT_ORIGINAL_4CC attribute. 
        /// <para/>
        /// The FOURCC mappings are stored in the Registry under the following key: 
        /// <para/>
        /// <strong>HKEY_CLASSES_ROOT</strong>\ <strong>MediaFoundation</strong>\ <strong>MapVideo4cc</strong>
        /// <para/>
        /// <strong>DWORD</strong>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2E6EF198-5754-4DED-9FE3-61EDD0742A17(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2E6EF198-5754-4DED-9FE3-61EDD0742A17(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_ORIGINAL_4CC = new Guid(0xd7be3fe0, 0x2bc7, 0x492d, 0xb8, 0x43, 0x61, 0xa1, 0x91, 0x9b, 0x70, 0xc3);

        // {8cbbc843-9fd9-49c2-882f-a72586c408ad}   MF_MT_ORIGINAL_WAVE_FORMAT_TAG   (UINT32)
        /// <summary>
        /// Contains the original WAVE format tag for an audio stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaType"/>
        /// </summary>
        /// <remarks>
        /// Depending on the source file, the AVI media source might set this attribute on the media types that
        /// it offers.
        /// <para/>
        /// An AVI file contains a stream header for each stream in the file. The AVI media source translates
        /// the stream header into a media type. For audio streams, the stream header contains a format tag
        /// that identifies the audio format. (The format tag is contained in the <strong>wFormatTag</strong>
        /// member of the <see cref="Misc.WaveFormatEx"/> structure.) In most cases, the AVI media source
        /// converts the format tag directly to a subtype GUID, as described in the topic 
        /// <c>Audio Subtype GUIDs</c>. In some cases, however, it maps the original format tag to another
        /// format tag that is equivalent. If so, the media source stores the original format tag in the media
        /// type, using the MF_MT_ORIGINAL_WAVE_FORMAT_TAG attribute. 
        /// <para/>
        /// The format mappings are stored in the Registry under the following key: 
        /// <para/>
        /// <strong>HKEY_CLASSES_ROOT</strong>\ <strong>MediaFoundation</strong>\ <strong>MapAudioFormatTag
        /// </strong>
        /// <para/>
        /// <strong>DWORD</strong>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2B30A1C2-4A42-4B09-ACB6-B76267CC7ED0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2B30A1C2-4A42-4B09-ACB6-B76267CC7ED0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_ORIGINAL_WAVE_FORMAT_TAG = new Guid(0x8cbbc843, 0x9fd9, 0x49c2, 0x88, 0x2f, 0xa7, 0x25, 0x86, 0xc4, 0x08, 0xad);

        #endregion

        #region Video Capture Media Type Attributes

        // {D2E7558C-DC1F-403f-9A72-D28BB1EB3B5E}   MF_MT_FRAME_RATE_RANGE_MIN      {UINT64 (HI32(Numerator),LO32(Denominator))}
        /// <summary>
        /// The minimum frame rate that is supported by a video capture device, in frames per second.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <c>MFGetAttributeRatio</c>. 
        /// <para/>
        /// To set this attribute, call <c>MFSetAttributeRatio</c>. 
        /// </summary>
        /// <remarks>
        /// The frame rate is expressed as a ratio. The upper 32 bits of the attribute value contain the
        /// numerator, and the lower 32 bits contain the denominator. For example, if the frame rate is 30
        /// frames per second (fps), the ratio is 30/1. 
        /// <para/>
        /// If the capture device reports a minimum frame rate, the media source sets this attribute on the
        /// media type. The maximum frame rate is given in the 
        /// <see cref="MFAttributesClsid.MF_MT_FRAME_RATE_RANGE_MAX"/> attribute. The device is not guaranteed
        /// to support every increment within this range. 
        /// <para/>
        /// To set the device's frame rate, first modify the value of the 
        /// <see cref="MFAttributesClsid.MF_MT_FRAME_RATE"/> attribute on the media type. Then set the media
        /// type on the media source. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D3725796-F683-4CA1-A37F-22C40FFF0B76(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D3725796-F683-4CA1-A37F-22C40FFF0B76(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_FRAME_RATE_RANGE_MIN = new Guid(0xd2e7558c, 0xdc1f, 0x403f, 0x9a, 0x72, 0xd2, 0x8b, 0xb1, 0xeb, 0x3b, 0x5e);

        // {E3371D41-B4CF-4a05-BD4E-20B88BB2C4D6}   MF_MT_FRAME_RATE_RANGE_MAX      {UINT64 (HI32(Numerator),LO32(Denominator))}
        /// <summary>
        /// The maximum frame rate that is supported by a video capture device, in frames per second.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <c>MFGetAttributeRatio</c>. 
        /// <para/>
        /// To set this attribute, call <c>MFSetAttributeRatio</c>. 
        /// </summary>
        /// <remarks>
        /// The frame rate is expressed as a ratio. The upper 32 bits of the attribute value contain the
        /// numerator, and the lower 32 bits contain the denominator. For example, if the frame rate is 30
        /// frames per second (fps), the ratio is 30/1. 
        /// <para/>
        /// If the capture device reports a maximum frame rate, the media source sets this attribute on the
        /// media type. The minimum frame rate is given in the 
        /// <see cref="MFAttributesClsid.MF_MT_FRAME_RATE_RANGE_MIN"/> attribute. The device is not guaranteed
        /// to support every increment within this range. 
        /// <para/>
        /// To set the device's frame rate, first modify the value of the 
        /// <see cref="MFAttributesClsid.MF_MT_FRAME_RATE"/> attribute on the media type. Then set the media
        /// type on the media source. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8E0C4996-9F78-424E-B012-502228B6A27A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8E0C4996-9F78-424E-B012-502228B6A27A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MT_FRAME_RATE_RANGE_MAX = new Guid(0xe3371d41, 0xb4cf, 0x4a05, 0xbd, 0x4e, 0x20, 0xb8, 0x8b, 0xb2, 0xc4, 0xd6);

        /// <summary>
        /// Enables low-latency processing in the Microsoft Media Foundation pipeline.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// Low latency is defined as the smallest possible delay from when  the media data is generated (or
        /// received) to when it is rendered. Low latency is desirable for real-time communication scenarios.
        /// For other scenarios, such as local playback or transcoding, you typically should not enable
        /// low-latency mode, because it can affect quality.
        /// <para/>
        /// <strong>Note</strong> The GUID value of this attribute is identical to the 
        /// <c>CODECAPI_AVEncCommonLowLatency</c> property defined for the <c>ICodecAPI</c> interface. 
        /// <para/>
        /// Set this attribute on pipeline components as follows:
        /// <para/>
        /// <para>* Media source: Use the <see cref="IMFMediaSourceEx.GetSourceAttributes"/> method. </para>
        /// <para>* Media Foundation transform (MFT): Use the 
        /// <see cref="Transform.IMFTransform.GetAttributes"/> method. For encoders, the encoder might support
        /// low latency through the <c>ICodecAPI</c> interface. </para><para>* Media sink: Query the media sink
        /// for the <see cref="IMFAttributes"/> interface. </para>
        /// <para/>
        /// Applications typically do not set this attribute directly on the pipeline components, but instead
        /// set the attribute on one of the following objects:
        /// <para/>
        /// <para>* <c>Media Session</c>: Use the <em>pConfiguation</em> parameter of the 
        /// <see cref="MFExtern.MFCreateMediaSession"/> or <see cref="MFExtern.MFCreatePMPMediaSession"/>
        /// function, or else set the attribute on the topology. </para><para>* <c>Source Reader</c>: Set the
        /// attribute with the configuration properties when you create the Source Reader. For more
        /// information, see <c>Source Reader Attributes</c>. </para><para>* <c>Sink Writer</c>: Set the
        /// attribute with the configuration properties when you create the Sink Writer. For more information,
        /// see <c>Sink Writer Attributes</c>. </para>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4D11B4D6-8CFF-4850-BF8F-9019A1F79153(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4D11B4D6-8CFF-4850-BF8F-9019A1F79153(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_LOW_LATENCY = new Guid(0x9c27891a, 0xed7a, 0x40e1, 0x88, 0xe8, 0xb2, 0x27, 0x27, 0xa0, 0x24, 0xee);

        // {E3F2E203-D445-4B8C-9211-AE390D3BA017}  {UINT32} Maximum macroblocks per second that can be handled by MFT
        /// <summary>
        /// Specifies, on <see cref="Transform.IMFTransform"/>, the maximum macroblock processing rate, in macroblocks per second, 
        /// that is supported by the hardware encoder.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302206(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302206(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MF_VIDEO_MAX_MB_PER_SEC = new Guid(0xe3f2e203, 0xd445, 0x4b8c, 0x92, 0x11, 0xae, 0x39, 0xd, 0x3b, 0xa0, 0x17);
        /// <summary>
        /// Sets the algorithm used by the video processor. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <see cref="MF_VIDEO_PROCESSOR_ALGORITHM_TYPE"/> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302207(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302207(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MF_VIDEO_PROCESSOR_ALGORITHM = new Guid(0x4a0a1e1f, 0x272c, 0x4fb6, 0x9e, 0xb1, 0xdb, 0x33, 0xc, 0xbc, 0x97, 0xca);

        /// <summary>
        /// Specifies whether the topology loader enables Microsoft DirectX Video Acceleration (DXVA) in the
        /// topology.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong><see cref="MFTOPOLOGY_DXVA_MODE"/></strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFTopology"/>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is an <see cref="MFTOPOLOGY_DXVA_MODE"/> enumeration constant. The
        /// default value is <strong>MFTOPOLOGY_DXVA_DEFAULT</strong>. 
        /// <para/>
        /// This attribute controls which MFTs receive a pointer to the Direct3D device manager. To enable full
        /// video acceleration, set the value to <strong>MFTOPOLOGY_DXVA_FULL</strong>. The value <strong>
        /// MFTOPOLOGY_DXVA_DEFAULT</strong> is defined for backward compatibility; it matches the behavior of
        /// all earlier versions of Microsoft Media Foundation. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/03783EF3-F957-41E3-9734-94CB34ECC088(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/03783EF3-F957-41E3-9734-94CB34ECC088(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPOLOGY_DXVA_MODE = new Guid(0x1e8d34f6, 0xf5ab, 0x4e23, 0xbb, 0x88, 0x87, 0x4a, 0xa3, 0xa1, 0xa7, 0x4d);

        /// <summary>
        /// If set, topoloader will pull in video processor if necessary during non-transcode topology resolution.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>Bool</strong> stored as <strong>UINT32</strong>
        /// </summary>
        public static readonly Guid MF_TOPOLOGY_ENABLE_XVP_FOR_PLAYBACK = new Guid(0x1967731f, 0xcd78, 0x42fc, 0xb0, 0x26, 0x9, 0x92, 0xa5, 0x6e, 0x56, 0x93);

        /// <summary>
        /// Enables static optimizations in the video pipeline.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFTopology"/>
        /// </summary>
        /// <remarks>
        /// Set this attribute before loading a topology. If the attribute is <strong>TRUE</strong>, the
        /// topology loader attempts to optimize the pipeline before playback starts. 
        /// <para/>
        /// If you set this attribute, you should also set the following attributes:
        /// <para/>
        /// <para>* <see cref="MFAttributesClsid.MF_TOPOLOGY_PLAYBACK_FRAMERATE"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_TOPOLOGY_PLAYBACK_MAX_DIMS"/></para>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/62FB3F0F-AB1F-4C61-8E7F-62908B947788(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/62FB3F0F-AB1F-4C61-8E7F-62908B947788(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPOLOGY_STATIC_PLAYBACK_OPTIMIZATIONS = new Guid(0xb86cac42, 0x41a6, 0x4b79, 0x89, 0x7a, 0x1a, 0xb0, 0xe5, 0x2b, 0x4a, 0x1b);
        /// <summary>
        /// Specifies the size of the destination window for video playback.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <c>MFGetAttributeSize</c>. 
        /// <para/>
        /// To set this attribute, call <c>MFSetAttributeSize</c>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFTopology"/>
        /// </summary>
        /// <remarks>
        /// The topology loader uses this attribute to optimize the pipeline before playback starts. If you set
        /// this attribute, also set the 
        /// <see cref="MFAttributesClsid.MF_TOPOLOGY_STATIC_PLAYBACK_OPTIMIZATIONS"/> attribute to <strong>TRUE
        /// </strong>. 
        /// <para/>
        /// The upper 32 bits of the attribute value contain the width and the lower 32 bits contain the
        /// height, both in pixels.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/46AF4C11-042C-4580-BA9D-3AEE6172DE56(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/46AF4C11-042C-4580-BA9D-3AEE6172DE56(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPOLOGY_PLAYBACK_MAX_DIMS = new Guid(0x5715cf19, 0x5768, 0x44aa, 0xad, 0x6e, 0x87, 0x21, 0xf1, 0xb0, 0xf9, 0xbb);

        /// <summary>
        /// Specifies whether to load hardware-based Microsoft Media Foundation transforms (MFTs) in the
        /// topology.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong><see cref="MFTOPOLOGY_HARDWARE_MODE"/></strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFTopology"/>
        /// </summary>
        /// <remarks>
        /// This attribute is optional. Set the attribute before resolving the topology. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term><strong>MFTOPOLOGY_HWMODE_USE_HARDWARE</strong></term><description>The Topology Loader will load hardware-based MFTs, such as hardware decoders, when available.The Topology Loader automatically falls back to software decoding if no hardware decoder is found, or if a hardware decoder fails to connect for some reason.</description></item>
        /// <item><term><strong>MFTOPOLOGY_HWMODE_SOFTWARE_ONLY</strong></term><description>The Topology Loader will load only software MFTs, including software decoders.</description></item>
        /// </list>
        /// <para/>
        /// The default value is <strong>MFTOPOLOGY_HWMODE_SOFTWARE_ONLY</strong>, for compatibility with
        /// existing applications. The recommended value is <strong>MFTOPOLOGY_HWMODE_USE_HARDWARE</strong>. 
        /// <para/>
        /// If the Topology Loader inserts a hardware MFT into the topology, it sets the 
        /// <see cref="MFAttributesClsid.MFT_ENUM_HARDWARE_URL_Attribute"/> attribute on the topology node. To
        /// check whether a hardware MFT is present, enumerate the nodes in the resolved topology and check
        /// whether this attribute is present. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F7AC3C9B-C163-412F-84C0-27BF551091D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F7AC3C9B-C163-412F-84C0-27BF551091D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPOLOGY_HARDWARE_MODE = new Guid(0xd2d362fd, 0x4e4f, 0x4191, 0xa5, 0x79, 0xc6, 0x18, 0xb6, 0x67, 0x6, 0xaf);
        /// <summary>
        /// Specifies the monitor refresh rate.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <c>MFGetAttributeRatio</c>. 
        /// <para/>
        /// To set this attribute, call <c>MFSetAttributeRatio</c>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFTopology"/>
        /// </summary>
        /// <remarks>
        /// The topology loader uses this attribute to optimize the pipeline before playback starts. If you set
        /// this attribute, also set the 
        /// <see cref="MFAttributesClsid.MF_TOPOLOGY_STATIC_PLAYBACK_OPTIMIZATIONS"/> attribute to <strong>TRUE
        /// </strong>. 
        /// <para/>
        /// The frame rate is expressed as a ratio. The upper 32 bits of the attribute value contain the
        /// numerator, and the lower 32 bits contain the denominator.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DEEB780C-2DC2-4A9A-926A-23B9AE3BEDD5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DEEB780C-2DC2-4A9A-926A-23B9AE3BEDD5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPOLOGY_PLAYBACK_FRAMERATE = new Guid(0xc164737a, 0xc2b1, 0x4553, 0x83, 0xbb, 0x5a, 0x52, 0x60, 0x72, 0x44, 0x8f);
        /// <summary>
        /// Specifies whether the Media Session attempts to modify the topology when the format of a stream
        /// changes. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFTopology"/>
        /// </summary>
        /// <remarks>
        /// This attribute controls how the Media Session responds if the format of a stream changes during
        /// streaming.
        /// <para/>
        /// If the format changes and the MF_TOPOLOGY_DYNAMIC_CHANGE_NOT_ALLOWED attribute is <strong>FALSE
        /// </strong>, the Media Session might insert new nodes into the topology to match the new format. For
        /// example, if the video size changes, the Media Session might add a Media Foundation transform (MFT)
        /// that resizes the video. Otherwise, if the attribute is <strong>TRUE</strong>, the Media Session
        /// will not modify the topology. 
        /// <para/>
        /// The default value of this attribute is <strong>FALSE</strong>. The recommended value is <strong>
        /// FALSE</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8272DED7-9D27-4652-877B-40FC76426FFC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8272DED7-9D27-4652-877B-40FC76426FFC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPOLOGY_DYNAMIC_CHANGE_NOT_ALLOWED = new Guid(0xd529950b, 0xd484, 0x4527, 0xa9, 0xcd, 0xb1, 0x90, 0x95, 0x32, 0xb5, 0xb0);

        /// <summary>
        /// Specifies whether the topology loader enumerates the media types provided by the media source.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Use one of the following values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong><strong>FALSE</strong></strong></term><description>Do not enumerate the source media types.</description></item>
        /// <item><term><strong><strong>TRUE</strong></strong></term><description>Enumerate the source media types.</description></item>
        /// </list>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFTopology"/>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2675EF16-2018-47E8-BB22-2FC0D62E6681(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2675EF16-2018-47E8-BB22-2FC0D62E6681(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPOLOGY_ENUMERATE_SOURCE_TYPES = new Guid(0x6248c36d, 0x5d0b, 0x4f40, 0xa0, 0xbb, 0xb0, 0xb3, 0x05, 0xf7, 0x76, 0x98);
        /// <summary>
        /// Specifies the start time for presentations that are queued after the first presentation.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>INT64</strong> stored as <strong>UINT64</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT64"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT64"/>. 
        /// <para/>
        /// <strong>Applies To </strong>
        /// <para/>
        /// <see cref="IMFTopology"/>
        /// </summary>
        /// <remarks>
        /// When the application queues the first presentation on the Media Session, the application specifies
        /// the start time in the <em>pvarStartPosition</em> parameter of the 
        /// <see cref="IMFMediaSession.Start"/> method. For any subsequent presentations, however, the start
        /// time is given by the MF_TOPOLOGY_START_TIME_ON_PRESENTATION_SWITCH attribute on the topology. The
        /// start time is specified in 100-nanosecond units, relative to the beginning of the presentation. For
        /// example, if the value is 50000000, playback starts 5 seconds into the presentation. If this
        /// attribute is not set, the default start time is zero. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/087F5D61-B3E6-4FDF-98E6-B018DE7B237F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/087F5D61-B3E6-4FDF-98E6-B018DE7B237F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPOLOGY_START_TIME_ON_PRESENTATION_SWITCH = new Guid(0xc8cc113f, 0x7951, 0x4548, 0xaa, 0xd6, 0x9e, 0xd6, 0x20, 0x2e, 0x62, 0xb3);

        /// <summary>
        /// Contains the identifier of the playlist element in the presentation.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFPresentationDescriptor"/>
        /// </summary>
        /// <remarks>
        /// Media sources that deliver playlists can optionally set this attribute on their presentation
        /// descriptors.
        /// <para/>
        /// When a media source delivers a playlist, it sends a <c>MENewPresentation</c> event for each
        /// playlist element after the first. This event contains a presentation descriptor for the new
        /// playlist element. The media source can assign identifiers to the elements by setting the
        /// MF_PD_PLAYBACK_ELEMENT_ID attribute on each presentation descriptor, including the one created by 
        /// <see cref="IMFMediaSource.CreatePresentationDescriptor"/>. 
        /// <para/>
        /// A media source might also send the <c>MENewPresentation</c> event because of a dynamic stream
        /// switch or a change in the number of streams. In that situation, the value of
        /// MF_PD_PLAYBACK_ELEMENT_ID should remain the same across both presentations, to indicate that both
        /// presentations represent the same playlist element. If two consecutive presentations have the same
        /// value for this attribute, the Microsoft Media Foundation pipeline expects the time stamps to remain
        /// continuous across the transition. Therefore, the media source must not use the 
        /// <see cref="MFAttributesClsid.MF_EVENT_SOURCE_ACTUAL_START"/> attribute when it transitions to the
        /// next presentation. 
        /// <para/>
        /// Media sources that implement <see cref="IMFMediaSourceTopologyProvider"/> should use the 
        /// <see cref="MFAttributesClsid.MF_TOPONODE_SEQUENCE_ELEMENTID"/> attribute rather than the
        /// MF_PD_PLAYBACK_ELEMENT_ID attribute. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/355818CF-1E00-46AD-9CE1-AB3A178164F9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/355818CF-1E00-46AD-9CE1-AB3A178164F9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_PLAYBACK_ELEMENT_ID = new Guid(0x6c990d39, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);
        /// <summary>
        /// Contains the preferred RFC 1766 language of the media source.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>WCHAR</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetString"/>. 
        /// <para/>
        /// To set this attribute, call <c>IMFAttributes::Settring</c>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFPresentationDescriptor"/>
        /// </summary>
        /// <remarks>
        /// The MF_PD_PREFERRED_LANGUAGE attribute is optional. An application can set this attribute on a
        /// media source (such as a network source) to specify its preferred language.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/30F99804-6AEA-473B-9BBF-E8C715501391(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/30F99804-6AEA-473B-9BBF-E8C715501391(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_PREFERRED_LANGUAGE = new Guid(0x6c990d3A, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);
        /// <summary>
        /// Stores the time (in 100-nanoseconds units) at which the presentation must begin, relative to the
        /// start of the media source.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT64"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT64"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFPresentationDescriptor"/>
        /// </summary>
        /// <remarks>
        /// The MF_PD_PLAYBACK_BOUNDARY_TIME attribute is optional for media sources in a playlist. This value
        /// indicates the actual start time of the presentation. Consider a playlist that includes media
        /// sources <em>Element1</em>, <em>Element2</em>, and <em>Element3</em> in a sequence. 15 seconds after
        /// <em>Element1</em> starts playing, a dynamic stream change occurs. The new stream must start playing
        /// 15 seconds into the presentation. However, the keyframe nearest the presentation time of 15 seconds
        /// is at 12 seconds for the new stream. To start the new presentation at 15 seconds, a markin is
        /// required so that the decoded samples are dropped from 12 seconds to 15 seconds. 
        /// <para/>
        /// Before the transition, the <c>MENewPresentation</c> event is raised by the media source. This
        /// returns the presentation descriptor that contains the 
        /// <see cref="MFAttributesClsid.MF_PD_PLAYBACK_ELEMENT_ID"/> attribute for <em>Element1</em>.
        /// Additionally, it contains the MF_PD_PLAYBACK_BOUNDARY_TIME attribute that is set to 15 seconds to
        /// indicate the time when the transition occurred. The media source performs the markin at 15 seconds
        /// after decoding, which prevents the frames from 12 seconds to 15 seconds from being displayed. 
        /// <para/>
        /// This value affects only markin time and does not affect how the Media Session adjusts time stamps.
        /// This attribute is ignored unless the media source indicates through the 
        /// <see cref="MFAttributesClsid.MF_PD_PLAYBACK_ELEMENT_ID"/> attribute that this presentation is the
        /// same playback element as the previous one. 
        /// <para/>
        /// The MF_PD_PLAYBACK_BOUNDARY_TIME attribute is similar to the 
        /// <see cref="MFAttributesClsid.MF_TOPONODE_MEDIASTART"/> attribute that is set on the topology node.
        /// For applications running on Windows Vista, media sources that implement 
        /// <see cref="IMFMediaSourceTopologyProvider"/> should use <strong>MF_TOPONODE_MEDIASTART</strong>
        /// instead of MF_PD_PLAYBACK_BOUNDARY_TIME. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7A3DDDAD-067B-46AF-9ED9-4CCC65F9D772(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7A3DDDAD-067B-46AF-9ED9-4CCC65F9D772(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_PLAYBACK_BOUNDARY_TIME = new Guid(0x6c990d3b, 0xbb8e, 0x477a, 0x85, 0x98, 0xd, 0x5d, 0x96, 0xfc, 0xd8, 0x8a);
        /// <summary>
        /// Specifies whether the audio streams in a presentation have a variable bit rate.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies To </strong>
        /// <para/>
        /// <see cref="IMFPresentationDescriptor"/>
        /// </summary>
        /// <remarks>
        /// This is an optional attribute for presentation descriptors. If the attribute is <strong>TRUE
        /// </strong> (nonzero), the presentation contains at least one variable-bit-rate (VBR) audio stream.
        /// If the attribute is <strong>FALSE</strong>, all of the audio streams have a constant bit rate. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2BD7EEE1-5A93-4BDE-8B58-80B6395A094E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2BD7EEE1-5A93-4BDE-8B58-80B6395A094E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_PD_AUDIO_ISVARIABLEBITRATE = new Guid(0x33026ee0, 0xe387, 0x4582, 0xae, 0x0a, 0x34, 0xa2, 0xad, 0x3b, 0xaa, 0x18);

        /// <summary>
        /// Contains the name of a stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>WCHAR*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetString"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetString"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFStreamDescriptor"/>
        /// </summary>
        /// <remarks>
        /// The AVI media source sets this attribute if the AVI file contains a 'strn' chunk.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/80235820-761F-4DEB-9BF6-82EF402B3EE4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/80235820-761F-4DEB-9BF6-82EF402B3EE4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SD_STREAM_NAME = new Guid(0x4f1b099d, 0xd314, 0x41e5, 0xa7, 0x81, 0x7f, 0xef, 0xaa, 0x4c, 0x50, 0x1f);
        /// <summary>
        /// Specifies whether a stream is mutually exclusive with other streams of the same type.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFStreamDescriptor"/>
        /// </summary>
        /// <remarks>
        /// If this attribute is <strong>TRUE</strong> (nonzero), the stream is mutually exclusive with other
        /// streams of the same type, such as audio or video, within the same presentation. For example, if an
        /// AVI file contains multiple audio streams, they are marked as mutually exclusive, because only one
        /// audio stream should be played at one time. 
        /// <para/>
        /// The default value is <strong>FALSE</strong>. 
        /// <para/>
        /// <strong>Note</strong> This attribute is not used for Advanced Systems Format (ASF) files, which
        /// have a more sophisticated way to represent mutual exclusion criteria. For more information, see 
        /// <see cref="IMFASFMutualExclusion"/>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/00A426AE-297C-4FCB-8132-D9C538BC9F1A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/00A426AE-297C-4FCB-8132-D9C538BC9F1A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SD_MUTUALLY_EXCLUSIVE = new Guid(0x23ef79c, 0x388d, 0x487f, 0xac, 0x17, 0x69, 0x6c, 0xd6, 0xe3, 0xc6, 0xf5);

        /// <summary>
        /// Specifies whether the sample-grabber sink uses the presentation clock to schedule samples.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// You can set this attribute on the activation object created by the 
        /// <see cref="MFExtern.MFCreateSampleGrabberSinkActivate"/> function. Set the attribute before calling
        /// the <see cref="IMFActivate.ActivateObject"/> method on the activation object. 
        /// <para/>
        /// By default, when the sample-grabber sink receives a sample, it waits until the presentation time of
        /// the sample to invoke the application's  callback. If the MF_SAMPLEGRABBERSINK_IGNORE_CLOCK
        /// attribute is nonzero, the sample-grabber sink ignores the presentation clock and invokes the
        /// callback as soon as it receives each sample.
        /// <para/>
        /// Recommended usage:
        /// <para/>
        /// <para>* If you want to process samples as quickly as possible, set this attribute to <strong>TRUE
        /// </strong>. </para><para>* If you want the calls to the callback method to be synchronized with the
        /// clock, either do not set this attribute or set it to <strong>FALSE</strong>. You can get samples
        /// slightly ahead of the clock, while still remaining synchronized, by setting the 
        /// <see cref="MFAttributesClsid.MF_SAMPLEGRABBERSINK_SAMPLE_TIME_OFFSET"/> attribute. </para>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/780EC4A6-8E14-4B81-9D50-82B2850C70AE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/780EC4A6-8E14-4B81-9D50-82B2850C70AE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SAMPLEGRABBERSINK_IGNORE_CLOCK = new Guid(0x0efda2c0, 0x2b69, 0x4e2e, 0xab, 0x8d, 0x46, 0xdc, 0xbf, 0xf7, 0xd2, 0x5d);
        /// <summary>
        /// Specifies whether a byte-stream handler can use a byte stream that is opened for writing by another
        /// thread.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// Byte-stream handlers can support this attribute. To get or set the attribute, first query the
        /// byte-stream handler for the <see cref="IMFAttributes"/> interface. Then call 
        /// <see cref="IMFAttributes.GetUINT32"/> or <see cref="IMFAttributes.SetUINT32"/>
        /// <para/>
        /// If this attribute is <strong>TRUE</strong>, it means that the byte-stream handler can read from a
        /// stream while another thread writes to the same stream. When a stream is opened for writing by
        /// another thread, the <see cref="IMFByteStream.GetCapabilities"/> method returns the <strong>
        /// MFBYTESTREAM_SHARE_WRITE</strong> flag. 
        /// <para/>
        /// This attribute affects source resolution. If a byte stream has the <strong>MFBYTESTREAM_SHARE_WRITE
        /// </strong> flag set, the <c>Source Resolver</c> will not pass that stream to a byte-stream handler
        /// unless the handler has the MF_BYTESTREAMHANDLER_ACCEPTS_SHARE_WRITE attribute set to <strong>TRUE
        /// </strong>. 
        /// <para/>
        /// The <strong>MFBYTESTREAM_SHARE_WRITE</strong> flag is a hint that the length of the stream might
        /// change while the handler is reading from it. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D9D97880-A563-420C-B598-C3EBD1AE8B74(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D9D97880-A563-420C-B598-C3EBD1AE8B74(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_BYTESTREAMHANDLER_ACCEPTS_SHARE_WRITE = new Guid(0xa6e1f733, 0x3001, 0x4915, 0x81, 0x50, 0x15, 0x58, 0xa2, 0x18, 0xe, 0xc8);

        /// <summary>
        /// Specifies the container type of an encoded file. The container types are supported by Media
        /// Foundation.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// <para/>
        /// Possible values for the container types provided by Media Foundation are described in the following
        /// table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>MFTranscodeContainerType_ASF</strong></term><description>ASF file container.</description></item>
        /// <item><term><strong>MFTranscodeContainerType_MPEG4</strong></term><description>MP4 file container.</description></item>
        /// <item><term><strong>MFTranscodeContainerType_MP3</strong></term><description>MP3 file container.</description></item>
        /// <item><term><strong>MFTranscodeContainerType_3GP</strong></term><description>3GP file container. </description></item>
        /// <item><term><strong>MFTranscodeContainerType_AC3</strong></term><description>AC3 file container. </description></item>
        /// <item><term><strong>MFTranscodeContainerType_ADTS</strong></term><description>ADTS file container. </description></item>
        /// <item><term><strong>MFTranscodeContainerType_MPEG2</strong></term><description>MPEG2 file container. </description></item>
        /// <item><term><strong>MFTranscodeContainerType_FMPEG4</strong></term><description>FMPEG4 file container. </description></item>
        /// <item><term><strong>MFTranscodeContainerType_WAVE</strong></term><description>WAVE file container.Supported in Windows 8.1 and and later.</description></item>
        /// <item><term><strong>MFTranscodeContainerType_AVI</strong></term><description>AVI file container.Supported in Windows 8.1 and and later.</description></item>
        /// </list>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetGUID"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetGUID"/>. 
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/97FD968A-6843-4695-AECE-02F9ACD618FD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/97FD968A-6843-4695-AECE-02F9ACD618FD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TRANSCODE_CONTAINERTYPE = new Guid(0x150ff23f, 0x4abc, 0x478b, 0xac, 0x4f, 0xe1, 0x91, 0x6f, 0xba, 0x1c, 0xca);
        /// <summary>
        /// Specifies whether metadata is written to the transcoded file. This container attribute is stored in
        /// the transcode profile.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Possible values for the MF_TRANSCODE_SKIP_METADATA_TRANSFER attribute are described in the
        /// following table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0</term><description>Automatically transfers file-level metadata from the source file to the transcoded file.</description></item>
        /// <item><term>1</term><description>The source file metadata is not written to the transcoded file.</description></item>
        /// </list>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0FBFC035-C9D1-4014-A28A-93D7E6ADC718(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0FBFC035-C9D1-4014-A28A-93D7E6ADC718(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TRANSCODE_SKIP_METADATA_TRANSFER = new Guid(0x4e4469ef, 0xb571, 0x4959, 0x8f, 0x83, 0x3d, 0xcf, 0xba, 0x33, 0xa3, 0x93);
        /// <summary>
        /// Specifies for a transcode topology whether the topology loader will load hardware-based transforms.
        /// <para/>
        /// The topology mode specifies whether hardware transforms (such as hardware codecs) may be used in
        /// the transcode topology. The application can store this attribute in a transcode profile by calling 
        /// <see cref="IMFTranscodeProfile.SetContainerAttributes"/>. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong><see cref="MF_TRANSCODE_TOPOLOGYMODE_FLAGS"/></strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// This attribute is optional. It must have one of the following values.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term><strong>MF_TRANSCODE_TOPOLOGYMODE_HARDWARE_ALLOWED</strong></term><description>The Topology Loader will load hardware-based MFTs, such as hardware decoders, when available.The Topology Loader automatically falls back to software decoding if no hardware decoder is found, or if a hardware decoder fails to connect for some reason.</description></item>
        /// <item><term><strong>MF_TRANSCODE_TOPOLOGYMODE_SOFTWARE_ONLY</strong></term><description>The Topology Loader will load only software MFTs, including software decoders.</description></item>
        /// </list>
        /// <para/>
        /// The default value is <strong>MF_TRANSCODE_TOPOLOGYMODE_SOFTWARE_ONLY</strong>. 
        /// <para/>
        /// If the Topology Loader inserts a hardware MFT into the topology, it sets the 
        /// <see cref="MFAttributesClsid.MFT_ENUM_HARDWARE_URL_Attribute"/> attribute on the topology node. To
        /// check whether a hardware MFT is present, enumerate the nodes in the resolved topology and check
        /// whether this attribute is present. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/33DB8621-114A-4531-908F-F30034441973(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/33DB8621-114A-4531-908F-F30034441973(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TRANSCODE_TOPOLOGYMODE = new Guid(0x3e3df610, 0x394a, 0x40b2, 0x9d, 0xea, 0x3b, 0xab, 0x65, 0xb, 0xeb, 0xf2);
        /// <summary>
        /// Profile flags that define the stream settings for the transcode topology. The flags are defined in
        /// the <see cref="MF_TRANSCODE_ADJUST_PROFILE_FLAGS"/> enumeration. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// An application can set this attribute at the container level on the transcode profile. If this
        /// attribute is set, the <see cref="MFExtern.MFCreateTranscodeTopology"/> function changes the stream
        /// attributes during topology building, depending on the specified flag. For example, if the
        /// application specifies the <strong>MF_TRANSCODE_ADJUST_PROFILE_DEFAULT</strong> flag, the
        /// application-specified stream settings are used to create the profile. 
        /// <para/>
        /// For the video stream, the frame rate is updated based on the media source. If the application does
        /// not specify the interlaced mode, the profile is updated to use progressive frames by default.
        /// <para/>
        /// If the application specifies the <strong>MF_TRANSCODE_ADJUST_PROFILE_USE_SOURCE_ATTRIBUTES</strong>
        /// flag, then missing stream attributes are copied from the input media source to the stream settings
        /// in the transcode profile. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6782E080-284B-458D-8BC0-6E131A529E7B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6782E080-284B-458D-8BC0-6E131A529E7B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TRANSCODE_ADJUST_PROFILE = new Guid(0x9c37c21b, 0x60f, 0x487c, 0xa6, 0x90, 0x80, 0xd7, 0xf5, 0xd, 0x1c, 0x72);

        /// <summary>
        /// Specifies the device conformance profile for encoding Advanced Streaming Format (ASF) files.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>LPWSTR</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetAllocatedString"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetString"/>. 
        /// </summary>
        /// <remarks>
        /// Use this attribute when transcoding to a  device that supports Windows Media. If this attribute is
        /// set, the encoder will use the device conformance profile, or template, for Windows Media codecs.
        /// Set the attribute on the transcode profile before building the transcode topology. 
        /// <para/>
        /// The value of this attribute can be any of the  conformance template strings listed in the following
        /// topics:
        /// <para/>
        /// <para>* <c>Audio Device Conformance Templates</c></para><para>* 
        /// <c>Video Device Conformance Templates</c></para>
        /// <para/>
        /// For Windows Media Video encoding, the topology builder uses this attribute to set the 
        /// <c>MFPKEY_DECODERCOMPLEXITYREQUESTED</c> property on the encoder. The encoder will attempt to use
        /// the specified template to encode the content. To get the actual template, traverse the nodes of the
        /// transcode topology to get a pointer to the encoder node. Then get the value of the 
        /// <c>MFPKEY_DECODERCOMPLEXITYPROFILE</c> property from the encoder. 
        /// <para/>
        /// The topology builder also uses the value of this attribute to set the "DeviceConformanceTemplate"
        /// property on the ASF media sink.
        /// <para/>
        /// If this attribute is set, the metadata object of the ASF file is always generated irrespective of
        /// the application-specified value of the 
        /// <see cref="MFAttributesClsid.MF_TRANSCODE_SKIP_METADATA_TRANSFER"/> attribute. 
        /// <para/>
        /// Typical values for this attribute include the following:
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Description</description></listheader>
        /// <item><term>"AP"</term><description>Advanced profile video</description></item>
        /// <item><term>"MP"</term><description>Main profile video</description></item>
        /// <item><term>"SP"</term><description>Simple profile video</description></item>
        /// <item><term>"MP@LL"</term><description>Main profile, medium level  video</description></item>
        /// <item><term>"L2"</term><description>Audio profile, &lt;= 160 Kbps</description></item>
        /// </list>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9A6B6402-FF53-4399-8616-06B7768A8737(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9A6B6402-FF53-4399-8616-06B7768A8737(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TRANSCODE_ENCODINGPROFILE = new Guid(0x6947787c, 0xf508, 0x4ea9, 0xb1, 0xe9, 0xa1, 0xfe, 0x3a, 0x49, 0xfb, 0xc9);
        /// <summary>
        /// Specifies a number between 0 and 100 that indicates the tradeoff between encoding quality and
        /// encoding speed.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// The value of this property has the following range.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0</term><description>Lower quality, faster encoding.</description></item>
        /// <item><term>100</term><description>Higher quality, slower encoding.</description></item>
        /// </list>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// This attribute has the same GUID value as the <c>AVEncCommonQualityVsSpeed</c> property defined for
        /// <c>ICodecAPI</c>, and has the same interpretation. 
        /// <para/>
        /// The application can set this attribute on the transcode profile before building the transcode
        /// topology for Windows Media codecs. The value must be in the range from 0 to 100. For video stream,
        /// the transcode topology builder maps a value to the application-specified value and supplies the
        /// mapped value to the <strong>MFPKEY_COMPLEXITYEX</strong> property of the encoder. Lower values
        /// enable the encoder to use less complicated encoding algorithms. Using simpler algorithms produces
        /// lower-quality output, but the encoding process is faster and requires less processing power. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/872140E8-FD39-446C-A84F-1E04EA95076E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/872140E8-FD39-446C-A84F-1E04EA95076E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TRANSCODE_QUALITYVSSPEED = new Guid(0x98332df8, 0x03cd, 0x476b, 0x89, 0xfa, 0x3f, 0x9e, 0x44, 0x2d, 0xec, 0x9f);
        /// <summary>
        /// Specifies whether an encoder must be included in the transcode topology.
        /// <para/>
        /// The <see cref="MFExtern.MFCreateTranscodeTopology"/> function checks this attribute during topology
        /// building. If this attribute is not set, an encoder is inserted in the transcode topology. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term>0</term><description>An encoder is inserted in the transcode topology.</description></item>
        /// <item><term>1</term><description>An encoder is not included in the transcode topology. The source node is connected to the output node.</description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/73F23AED-D1B9-4821-B1CA-0A07F02B6913(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/73F23AED-D1B9-4821-B1CA-0A07F02B6913(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TRANSCODE_DONOT_INSERT_ENCODER = new Guid(0xf45aa7ce, 0xab24, 0x4012, 0xa1, 0x1b, 0xdc, 0x82, 0x20, 0x20, 0x14, 0x10);

        /// <summary>
        /// Specifies a device's type, such as audio capture or video capture.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// <para/>
        /// The following values are defined for this attribute:
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_GUID</strong></term><description>Audio capture device.</description></item>
        /// <item><term><strong>MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_GUID</strong></term><description>Video capture device.</description></item>
        /// </list>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetGUID"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetGUID"/>. 
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
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE = new Guid(0xc60ac5fe, 0x252a, 0x478f, 0xa0, 0xef, 0xbc, 0x8f, 0xa5, 0xf7, 0xca, 0xd3);
        /// <summary>
        /// Specifies whether a video capture source is a hardware device or a software device.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// If the value is <strong>TRUE</strong>, the capture source is a hardware device. If the value is 
        /// <strong>FALSE</strong>, it is a software device. The default value is <strong>FALSE</strong>. 
        /// <para/>
        /// This attribute is set on the activation objects returned by the following functions:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateDeviceSourceActivate"/></para><para>* 
        /// <see cref="MFExtern.MFEnumDeviceSources"/></para>
        /// <para/>
        /// The attribute applies only to video capture devices.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4A886124-54F1-4CD1-A22B-552E8C8D556F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4A886124-54F1-4CD1-A22B-552E8C8D556F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_HW_SOURCE = new Guid(0xde7046ba, 0x54d6, 0x4487, 0xa2, 0xa4, 0xec, 0x7c, 0xd, 0x1b, 0xd1, 0x63);
        /// <summary>
        /// Specifies the display name for a device. The <em>display name</em> is a human-readable string,
        /// suitable for display in a user interface. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>WCHAR*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetString"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetString"/>. 
        /// </summary>
        /// <remarks>
        /// This attribute is set on the activation objects returned by the following functions:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateDeviceSourceActivate"/></para><para>* 
        /// <see cref="MFExtern.MFEnumDeviceSources"/></para>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3F6C7FAF-2ECD-4510-ADC2-252C3619D70F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3F6C7FAF-2ECD-4510-ADC2-252C3619D70F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_FRIENDLY_NAME = new Guid(0x60d0e559, 0x52f8, 0x4fa2, 0xbb, 0xce, 0xac, 0xdb, 0x34, 0xa8, 0xec, 0x1);
        /// <summary>
        /// Specifies the output format of a device.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong><see cref="Transform.MFTRegisterTypeInfo"/></strong> stored as <strong>BYTE[]</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetBlob"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetBlob"/>. 
        /// </summary>
        /// <remarks>
        /// This attribute contains a pair of GUIDs: a major type and a subtype. These GUIDs describe the
        /// default output format of the device. The device might support additional output formats.
        /// <para/>
        /// For example, if a video capture device outputs RGB-32 video, the value of this attribute is 
        /// <c>{ MFMediaType_Video, MFVideoFormat_RGB32 }</c>. 
        /// <para/>
        /// This attribute is a hint to the application. To get the exact output format, create the media
        /// source for the device and get the media source's presentation descriptor.
        /// <para/>
        /// This attribute is set on the activation objects returned by the following functions:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateDeviceSourceActivate"/></para><para>* 
        /// <see cref="MFExtern.MFEnumDeviceSources"/></para>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/33A1B546-ECE2-44EF-A1C0-5579C32BE0BC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/33A1B546-ECE2-44EF-A1C0-5579C32BE0BC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_MEDIA_TYPE = new Guid(0x56a819ca, 0xc78, 0x4de4, 0xa0, 0xa7, 0x3d, 0xda, 0xba, 0xf, 0x24, 0xd4);
        /// <summary>
        /// Specifies the device category for a video capture device.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// <para/>
        /// The following value is defined.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>CLSID_VideoInputDeviceCategory</strong></term><description>Video capture device.</description></item>
        /// </list>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetGUID"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetGUID"/>. 
        /// </summary>
        /// <remarks>
        /// Use this attribute as input to the <see cref="MFExtern.MFEnumDeviceSources"/> function when
        /// enumerating video capture devices. 
        /// <para/>
        /// In addition, this attribute is set on the activation objects returned by the following functions:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateDeviceSourceActivate"/></para><para>* 
        /// <see cref="MFExtern.MFEnumDeviceSources"/></para>
        /// <para/>
        /// The attribute applies only to video capture devices.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/008FF9DF-EBE0-4EFD-A62C-24F4A4239EBD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/008FF9DF-EBE0-4EFD-A62C-24F4A4239EBD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_CATEGORY = new Guid(0x77f0ae69, 0xc3bd, 0x4509, 0x94, 0x1d, 0x46, 0x7e, 0x4d, 0x24, 0x89, 0x9e);
        /// <summary>
        /// Contains the symbolic link for a video capture driver.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>WCHAR*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetString"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetString"/>. 
        /// </summary>
        /// <remarks>
        /// Use this attribute as input to the <see cref="MFExtern.MFCreateDeviceSourceActivate"/> function. 
        /// <para/>
        /// In addition, this attribute is set on the activation objects returned by the following functions:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateDeviceSourceActivate"/></para><para>* 
        /// <see cref="MFExtern.MFEnumDeviceSources"/></para>
        /// <para/>
        /// The symbolic link should be considered an opaque string. The human-readable display name for a
        /// device is contained in the <see cref="MFAttributesClsid.MF_DEVSOURCE_ATTRIBUTE_FRIENDLY_NAME"/>
        /// attribute. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3D256DEC-EC8C-4C62-883B-E2C292FD90EB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3D256DEC-EC8C-4C62-883B-E2C292FD90EB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_SYMBOLIC_LINK = new Guid(0x58f0aad8, 0x22bf, 0x4f8a, 0xbb, 0x3d, 0xd2, 0xc4, 0x97, 0x8c, 0x6e, 0x2f);
        /// <summary>
        /// Specifies the maximum number of frames that the video capture source will buffer.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// By default, the video capture source buffers a maximum of one frame at a time. You can increase the
        /// buffer limit by setting this attribute. 
        /// <para/>
        /// The correct way to set this attribute depends on the function used to create the media source:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateDeviceSource"/>: Set the attribute through the <em>pAttributes
        /// </em> parameter of the function. </para><para>* <see cref="MFExtern.MFCreateDeviceSourceActivate"/>
        /// : Set the attribute through the <em>pAttributes</em> parameter of the function. </para><para>* 
        /// <see cref="MFExtern.MFEnumDeviceSources"/>: Set the attribute on the <see cref="IMFActivate"/>
        /// pointer returned by the function. Set the attribute before calling 
        /// <see cref="IMFActivate.ActivateObject"/>. </para>
        /// <para/>
        /// The attribute applies only to video capture devices.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AF30606B-F1A0-4FBF-A831-05ED891F5D53(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AF30606B-F1A0-4FBF-A831-05ED891F5D53(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_MAX_BUFFERS = new Guid(0x7dd9b730, 0x4f2d, 0x41d5, 0x8f, 0x95, 0xc, 0xc9, 0xa9, 0x12, 0xba, 0x26);
        /// <summary>
        /// Specifies the endpoint ID for an audio capture device.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>WCHAR*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetString"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetString"/>. 
        /// </summary>
        /// <remarks>
        /// The value of the attribute is an endpoint ID. This attribute is used with the following functions:
        /// <para/>
        /// <para>* It can be used as input to the <see cref="MFExtern.MFCreateDeviceSource"/> and 
        /// <see cref="MFExtern.MFCreateDeviceSourceActivate"/> functions. In this context, the attribute
        /// specifies the audio capture device for the function. You can get the endpoint ID for a given device
        /// by calling the <c>IMMDevice::GetId</c> method. See the Core Audio API documentation for more
        /// information. </para><para>* When the <see cref="MFExtern.MFEnumDeviceSources"/> function enumerates
        /// audio devices, the returned activation objects contain this attribute. The attribute is used
        /// internally by the activation object when it creates the media source. </para>
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A0D8B54B-7A05-4307-A756-A34BB22F1AFD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A0D8B54B-7A05-4307-A756-A34BB22F1AFD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ENDPOINT_ID = new Guid(0x30da9258, 0xfeb9, 0x47a7, 0xa4, 0x53, 0x76, 0x3a, 0x7a, 0x8e, 0x1c, 0x5f);
        /// <summary>
        /// Specifies the device role for an audio capture device.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>ERole</strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// The <strong>eRole</strong> enumeration type is documented in the Core Audio API documentation. 
        /// <para/>
        /// The value of the attribute specifies a device role. This attribute is used with the following
        /// functions.
        /// <para/>
        /// This attribute can be used as input to the <see cref="MFExtern.MFCreateDeviceSource"/> and 
        /// <see cref="MFExtern.MFCreateDeviceSourceActivate"/> functions. If the attribute is specified, the
        /// function creates a media source that uses the default audio capture device for the specified device
        /// role. 
        /// <para/>
        /// This attribute can also be used as input to the <see cref="MFExtern.MFEnumDeviceSources"/>
        /// function. If the attribute is specified, the enumeration is restricted to the specified device
        /// role. In addition, each activation object returned by the <strong>MFEnumDeviceSources</strong>
        /// function contains this attribute. The attribute is then used internally by the activation object
        /// when it creates the media source. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4F2885B6-C771-4577-880D-5FEEA671432E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4F2885B6-C771-4577-880D-5FEEA671432E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_ROLE = new Guid(0xbc9d118e, 0x8c67, 0x4a18, 0x85, 0xd4, 0x12, 0xd3, 0x0, 0x40, 0x5, 0x52);

        /// <summary>
        /// Contains the time stamp from the device driver.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT64"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT64"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFSample"/>
        /// </summary>
        /// <remarks>
        /// This attribute is set on media samples created by a media source for a capture device. The value of
        /// the attribute is the time stamp generated by the driver. This time stamp is correlated with the
        /// system time from the query performance counter (QPC).
        /// <para/>
        /// To get the time stamp relative to the start of streaming, call the 
        /// <see cref="IMFSample.GetSampleTime"/> method. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8904D104-EBCC-474D-B6B5-B262B6F62EE9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8904D104-EBCC-474D-B6B5-B262B6F62EE9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFSampleExtension_DeviceTimestamp = new Guid(0x8f3e35e7, 0x2dcd, 0x4887, 0x86, 0x22, 0x2a, 0x58, 0xba, 0xa6, 0x52, 0xb0);

        /// <summary>
        /// Specifies whether a Media Foundation transform (MFT) performs asynchronous processing.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// The attribute is a Boolean value:
        /// <para/>
        /// <para>* If the attribute is nonzero, the MFT performs asynchronous processing.</para><para>* If the
        /// attribute is 0 or not set, the MFT is synchronous.</para>
        /// <para/>
        /// To get this attribute, first call <see cref="Transform.IMFTransform.GetAttributes"/> to get the
        /// MFT's attribute store. If that method succeeds, call <see cref="IMFAttributes.GetUINT32"/> to get
        /// the attribute value. If either of the two methods fails, the MFT is synchronous. 
        /// <para/>
        /// For asynchronous MFTs, this attribute must be set to a nonzero value. For synchronous MFTs, this
        /// attribute is optional, but must be set to 0 if present.
        /// <para/>
        /// Asynchronous MFTs are not compatible with earlier versions of Media Foundation. To use an
        /// asynchronous MFT, the client must set the <see cref="MFAttributesClsid.MF_TRANSFORM_ASYNC_UNLOCK"/>
        /// attribute on the MFT. (The Microsoft Media Foundation pipeline performs this step automatically.) 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/FCC70282-CFAC-487C-B9FF-39E62C836F8B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FCC70282-CFAC-487C-B9FF-39E62C836F8B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TRANSFORM_ASYNC = new Guid(0xf81a699a, 0x649a, 0x497d, 0x8c, 0x73, 0x29, 0xf8, 0xfe, 0xd6, 0xad, 0x7a);
        /// <summary>
        /// Enables the use of an asynchronous Media Foundation transform (MFT).
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// Asynchronous MFTs are not compatible with earlier versions of Microsoft Media Foundation. To
        /// prevent existing applications from accidentally using an asynchronous MFT, this attribute must be
        /// set to a nonzero value before an asynchronous MFT can be used. The Media Foundation pipeline
        /// automatically sets the  attribute, so that most applications do not need to use this attribute.
        /// However, if an application uses an asynchronous MFT outside of the Media Foundation pipeline, the
        /// application must set this attribute.
        /// <para/>
        /// Synchronous MFTs do not require this attribute.
        /// <para/>
        /// To test whether an MFT is asynchronous, get the value of the 
        /// <see cref="MFAttributesClsid.MF_TRANSFORM_ASYNC"/> attribute on the MFT. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E12AB57E-EBC2-46AF-AFDF-D78D4DB16FCF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E12AB57E-EBC2-46AF-AFDF-D78D4DB16FCF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TRANSFORM_ASYNC_UNLOCK = new Guid(0xe5666d6b, 0x3422, 0x4eb6, 0xa4, 0x21, 0xda, 0x7d, 0xb1, 0xf8, 0xe2, 0x7);
        /// <summary>
        /// Contains flags for a Media Foundation transform (MFT) activation object.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// The value is a bitwise <strong>OR</strong> of flags from the <c>_MFT_ENUM_FLAG</c> enumeration. 
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// This attribute is set on the <see cref="IMFActivate"/> pointers returned by the 
        /// <see cref="MFExtern.MFTEnumEx"/> function. The attribute contains flags that describe the MFT. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DE377132-19B0-4C8C-882E-193C31420739(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DE377132-19B0-4C8C-882E-193C31420739(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TRANSFORM_FLAGS_Attribute = new Guid(0x9359bb7e, 0x6275, 0x46c4, 0xa0, 0x25, 0x1c, 0x1, 0xe4, 0x5f, 0x1a, 0x86);
        /// <summary>
        /// Specifies the category for a Media Foundation transform (MFT).
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// <para/>
        /// For a list of possible values, see <c>MFT_CATEGORY</c>. 
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetGUID"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetGUID"/>. 
        /// </summary>
        /// <remarks>
        /// This attribute is set on the <see cref="IMFActivate"/> pointers returned by the 
        /// <see cref="MFExtern.MFTEnumEx"/> function. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CEBD64EA-B20F-4CCC-805F-0DEAB3096BC3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CEBD64EA-B20F-4CCC-805F-0DEAB3096BC3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TRANSFORM_CATEGORY_Attribute = new Guid(0xceabba49, 0x506d, 0x4757, 0xa6, 0xff, 0x66, 0xc1, 0x84, 0x98, 0x7e, 0x4e);
        /// <summary>
        /// Contains the class identifier (CLSID) of a Media Foundation transform (MFT).
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetGUID"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetGUID"/>. 
        /// </summary>
        /// <remarks>
        /// This attribute is set on the <see cref="IMFActivate"/> pointers returned by the 
        /// <see cref="MFExtern.MFTEnumEx"/> function. 
        /// <para/>
        /// This attribute is used internally by the activation object when it creates the MFT. Applications
        /// should not use this CLSID directly to create the MFT, because the activation object might need to
        /// initialize the MFT. Therefore, to create an instance of the MFT, call 
        /// <see cref="IMFActivate.ActivateObject"/> on the activation object. 
        /// <para/>
        /// Note that the <see cref="MFExtern.MFTEnumEx"/> function behaves differently than the 
        /// <see cref="MFExtern.MFTEnum"/> function in this respect. The <strong>MFTEnum</strong> function
        /// returns CLSIDs, which the application passes to the <strong>CoCreateInstance</strong> function. The
        /// <strong>MFTEnumEx</strong> function returns activation objects rather than CLSIDs. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/99EE6F50-1DE7-41EA-BE5B-135730138D5D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/99EE6F50-1DE7-41EA-BE5B-135730138D5D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_TRANSFORM_CLSID_Attribute = new Guid(0x6821c42b, 0x65a4, 0x4e82, 0x99, 0xbc, 0x9a, 0x88, 0x20, 0x5e, 0xcd, 0xc);
        /// <summary>
        /// Contains the registered input types for a Media Foundation transform (MFT).
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>MFT_REGISTER_TYPE_INFO[]</strong> stored as <strong>BYTE[]</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetBlob"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetBlob"/>. 
        /// </summary>
        /// <remarks>
        /// This attribute is set on the <see cref="IMFActivate"/> pointers returned by the 
        /// <see cref="MFExtern.MFTEnumEx"/> function. 
        /// <para/>
        /// This attribute contains an array of <see cref="Transform.MFTRegisterTypeInfo"/> structures that
        /// describe one or more input formats supported by the MFT. These values are taken from the registry
        /// and are intended as a hint to the application. The MFT might support additional formats. To set the
        /// actual input format, you must create the MFT and call 
        /// <see cref="Transform.IMFTransform.SetInputType"/>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0FB1D9F2-2B57-41BC-8365-0B88BD5A2F3D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0FB1D9F2-2B57-41BC-8365-0B88BD5A2F3D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_INPUT_TYPES_Attributes = new Guid(0x4276c9b1, 0x759d, 0x4bf3, 0x9c, 0xd0, 0xd, 0x72, 0x3d, 0x13, 0x8f, 0x96);
        /// <summary>
        /// Contains the registered output types for a Media Foundation transform (MFT).
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>MFT_REGISTER_TYPE_INFO[]</strong> stored as <strong>BYTE[]</strong>
        /// </summary>
        /// <remarks>
        /// This attribute is set on the <see cref="IMFActivate"/> pointers returned by the 
        /// <see cref="MFExtern.MFTEnumEx"/> function. 
        /// <para/>
        /// This attribute contains an array of <see cref="Transform.MFTRegisterTypeInfo"/> structures that
        /// describe one or more output formats supported by the MFT. These values are taken from the registry
        /// and are intended as a hint to the application. The MFT might support additional formats. To set the
        /// actual output format, you must create the MFT and call 
        /// <see cref="Transform.IMFTransform.SetOutputType"/>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/925267A2-4421-4874-A8A2-437876C729F1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/925267A2-4421-4874-A8A2-437876C729F1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_OUTPUT_TYPES_Attributes = new Guid(0x8eae8cf3, 0xa44f, 0x4306, 0xba, 0x5c, 0xbf, 0x5d, 0xda, 0x24, 0x28, 0x18);
        /// <summary>
        /// Contains the symbolic link for a hardware-based Media Foundation transform (MFT).
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>WCHAR*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetString"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetString"/>. 
        /// </summary>
        /// <remarks>
        /// This attribute is supported by hardware-based MFTs. The value of the attribute is the symbolic link
        /// for the device driver. This attribute is also set on the <see cref="IMFActivate"/> pointers
        /// allocated by the <see cref="MFExtern.MFTEnumEx"/> function, when those pointers represent
        /// hardware-based MFTs. 
        /// <para/>
        /// The symbolic link should be considered an opaque string. To get the display name for a device,
        /// query the <c>MFT_FRIENDLY_NAME</c> attribute. 
        /// <para/>
        /// Software MFTs should not have this attribute set.
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7E153051-A167-4FF7-8178-B290D8A1345E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7E153051-A167-4FF7-8178-B290D8A1345E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_ENUM_HARDWARE_URL_Attribute = new Guid(0x2fb866ac, 0xb078, 0x4942, 0xab, 0x6c, 0x0, 0x3d, 0x5, 0xcd, 0xa6, 0x74);
        /// <summary>
        /// Contains the display name for a hardware-based Media Foundation transform (MFT).
        /// <para/>
        /// Data type: <strong>WCHAR*</strong>
        /// <para/>
        /// </summary>
        /// <remarks>
        /// This attribute is supported by hardware-based MFTs. It is also set on the IMFActivate pointers 
        /// allocated by the MFTEnumEx function, when those pointers represent hardware-based MFTs.
        /// </remarks>
        public static readonly Guid MFT_FRIENDLY_NAME_Attribute = new Guid(0x314ffbae, 0x5b41, 0x4c95, 0x9c, 0x19, 0x4e, 0x7d, 0x58, 0x6f, 0xac, 0xe3);
        /// <summary>
        /// Contains a pointer to the stream attributes of the connected stream on a hardware-based Media
        /// Foundation transform (MFT).
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IMFAttributes*</strong> stored as <strong>IUnknown*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUnknown"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUnknown"/>. 
        /// </summary>
        /// <remarks>
        /// Applications typically do not use this attribute.
        /// <para/>
        /// This attribute is used for MFTs that act as proxies to a hardware device. For details, see 
        /// <c>Hardware MFTs</c>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7E14A02E-4CBF-45AA-A6F5-2C53B2437127(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7E14A02E-4CBF-45AA-A6F5-2C53B2437127(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_CONNECTED_STREAM_ATTRIBUTE = new Guid(0x71eeb820, 0xa59f, 0x4de2, 0xbc, 0xec, 0x38, 0xdb, 0x1d, 0xd6, 0x11, 0xa4);
        /// <summary>
        /// Specifies whether a hardware-based Media Foundation transform (MFT) is connected to another
        /// hardware-based MFT.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// Applications typically do not use this attribute.
        /// <para/>
        /// This attribute is used with hardware-based MFTs. When two hardware MFTs are connected within a
        /// topology, the topology loader sets this attribute to <strong>TRUE</strong> on the following
        /// objects: 
        /// <para/>
        /// <para>* The output stream of the upstream MFT </para><para>* The input stream of the downstream 
        /// MFT </para>
        /// <para/>
        /// To get the attribute store for the output stream, the topology loader calls 
        /// <see cref="Transform.IMFTransform.GetOutputStreamAttributes"/> on the upstream MFT. To get the
        /// attribute store for the input stream, the topology loader calls 
        /// <see cref="Transform.IMFTransform.GetInputStreamAttributes"/> on the downstream MFT. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9166C43F-D2AE-4DC7-84E9-02146B67EFE2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9166C43F-D2AE-4DC7-84E9-02146B67EFE2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_CONNECTED_TO_HW_STREAM = new Guid(0x34e6e728, 0x6d6, 0x4491, 0xa5, 0x53, 0x47, 0x95, 0x65, 0xd, 0xb9, 0x12);
        /// <summary>
        /// Specifies the preferred output format for an encoder.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong><see cref="IMFAttributes"/>* </strong> stored as <strong>IUnknown*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUnknown"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUnknown"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFActivate"/>
        /// </summary>
        /// <remarks>
        /// This attribute can be set on the activation object returned by the 
        /// <see cref="MFExtern.MFCreateTransformActivate"/> function. The attribute applies only when the
        /// activation object is configured to create an encoder. The value of the attribute is a media type.
        /// The activation object sets this output type on the encoder. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/36A09696-3FE7-41A0-93F1-712220F88B04(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/36A09696-3FE7-41A0-93F1-712220F88B04(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_PREFERRED_OUTPUTTYPE_Attribute = new Guid(0x7e700499, 0x396a, 0x49ee, 0xb1, 0xb4, 0xf6, 0x28, 0x2, 0x1e, 0x8c, 0x9d);
        /// <summary>
        /// Specifies whether a Media Foundation transform (MFT) is registered only in the application's
        /// process.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E10D6378-8E85-4F73-9FA3-A2E954FC8249(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E10D6378-8E85-4F73-9FA3-A2E954FC8249(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_PROCESS_LOCAL_Attribute = new Guid(0x543186e4, 0x4649, 0x4e65, 0xb5, 0x88, 0x4a, 0xa3, 0x52, 0xaf, 0xf3, 0x79);
        /// <summary>
        /// Contains configuration properties for an encoder.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong><see cref="IMFAttributes"/>* </strong> stored as <strong>IUnknown*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUnknown"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUnknown"/>. 
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFActivate"/>
        /// </summary>
        /// <remarks>
        /// This attribute can be set on the activation object returned by the 
        /// <see cref="MFExtern.MFCreateTransformActivate"/> function. The attribute applies only when the
        /// activation object is configured to create an encoder. The value of the attribute is a pointer to an
        /// attribute store, which itself contains properties to set on the encoder. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F9BD8A50-E43E-4668-86A0-C9D5F517F4CF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F9BD8A50-E43E-4668-86A0-C9D5F517F4CF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_PREFERRED_ENCODER_PROFILE = new Guid(0x53004909, 0x1ef5, 0x46d7, 0xa1, 0x8e, 0x5a, 0x75, 0xf8, 0xb5, 0x90, 0x5f);
        /// <summary>
        /// Specifies whether a hardware device source uses the system time for time stamps.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// If this attribute is <strong>TRUE</strong>, the device source uses the system time, as returned by
        /// the <strong>QueryPerformanceCounter</strong>, for time stamps. Otherwise, the device source uses
        /// the device's clock. The default value is <strong>FALSE</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/54CDFA13-955A-4E92-B337-F645D526A1B8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/54CDFA13-955A-4E92-B337-F645D526A1B8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_HW_TIMESTAMP_WITH_QPC_Attribute = new Guid(0x8d030fb8, 0xcc43, 0x4258, 0xa2, 0x2e, 0x92, 0x10, 0xbe, 0xf8, 0x9b, 0xe4);
        /// <summary>
        /// Contains an <see cref="IMFFieldOfUseMFTUnlock"/> pointer, which can be used to unlock a Media
        /// Foundation transform (MFT). The <strong>IMFFieldOfUseMFTUnlock</strong> interface is used to unlock
        /// an MFT that has field-of-use restrictions. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong><see cref="IMFFieldOfUseMFTUnlock"/>* </strong> stored as <strong>IUnknown*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUnknown"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUnknown"/>. 
        /// </summary>
        /// <remarks>
        /// For more information about this attribute, see <c>Field of Use Restrictions</c>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7F48967E-375A-4019-B14F-2F457B616CC0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7F48967E-375A-4019-B14F-2F457B616CC0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_FIELDOFUSE_UNLOCK_Attribute = new Guid(0x8ec2e9fd, 0x9148, 0x410d, 0x83, 0x1e, 0x70, 0x24, 0x39, 0x46, 0x1a, 0x8e);
        /// <summary>
        /// Contains the merit value of a hardware codec.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// This attribute is set on the activation object for a Media Foundation transform (MFT) that
        /// represents a hardware codec. The value of the attribute is the codec's merit value.
        /// <para/>
        /// This attribute controls the order in which the <see cref="MFExtern.MFTEnumEx"/> function enumerates
        /// codecs, if the <strong>MFT_ENUM_FLAG_SORTANDFILTER</strong> flag is set. MFTs with a merit value
        /// appear higher in the list than other MFTs. 
        /// <para/>
        /// This attribute does not contain a trusted value. To verify the codec's actual merit value, call the
        /// <see cref="MFExtern.MFGetMFTMerit"/> function. 
        /// <para/>
        /// If the value of the MFT_CODEC_MERIT_Attribute attribute does not match the merit value retrieved by
        /// <see cref="MFExtern.MFGetMFTMerit"/>, the <see cref="IMFActivate.ActivateObject"/> method fails and
        /// returns <strong>MF_E_INVALID_CODEC_MERIT</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1DF40A42-4C02-473F-A87F-2AE2D42E4F4E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1DF40A42-4C02-473F-A87F-2AE2D42E4F4E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_CODEC_MERIT_Attribute = new Guid(0x88a7cb15, 0x7b07, 0x4a34, 0x91, 0x28, 0xe6, 0x4c, 0x67, 0x3, 0xc4, 0xd3);
        /// <summary>
        /// Specifies whether a decoder is optimized for transcoding rather than for playback.
        /// <para/>
        /// Currently, this attribute applies only to hardware-based decoders that use the AVStream
        /// mini-driver. The attribute is stored in the registry under the decoder's capabilities information.
        /// For more information, see the documentation for <c>IGetCapabilitiesKey</c>. 
        /// <para/>
        /// Applications typically do not use this attribute.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>REG_DWORD</strong>
        /// </summary>
        /// <remarks>
        /// If this registry entry is present and equal to 1, the <see cref="MFExtern.MFTEnumEx"/> function
        /// skips the decoder unless the caller specified the <strong>MFT_ENUM_FLAG_TRANSCODE_ONLY</strong>
        /// flag in <strong>MFTEnumEx</strong>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0E05CB05-87A8-4174-A3C6-A0A0C7765024(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0E05CB05-87A8-4174-A3C6-A0A0C7765024(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_ENUM_TRANSCODE_ONLY_ATTRIBUTE = new Guid(0x111ea8cd, 0xb62a, 0x4bdb, 0x89, 0xf6, 0x67, 0xff, 0xcd, 0xc2, 0x45, 0x8b);

        /// <summary>
        /// Specifies whether the Digital Living Network Alliance (DLNA) media sink uses the Multimedia Class
        /// Scheduler Service (MMCSS).
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// To set this attribute on the DLNA media sink, query the media sink for the 
        /// <see cref="IMFAttributes"/> interface. Set the attribute before streaming begins. 
        /// <para/>
        /// If this attribute is <strong>TRUE</strong>, the DLNA media sink registers itself with MMCSS. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4C27E2EC-624A-4B1F-BEA9-3AAAD1534C9B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4C27E2EC-624A-4B1F-BEA9-3AAAD1534C9B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MP2DLNA_USE_MMCSS = new Guid(0x54f3e2ee, 0xa2a2, 0x497d, 0x98, 0x34, 0x97, 0x3a, 0xfd, 0xe5, 0x21, 0xeb);
        /// <summary>
        /// Specifies the maximum video bit rate for the Digital Living Network Alliance (DLNA) media sink.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// The value is the target maximum bit rate for the encoded video stream, in bits per second. The
        /// maximum value is 9800000 (9.8 Mbps), which is also the default value.
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// To set this attribute on the DLNA media sink, query the media sink for the 
        /// <see cref="IMFAttributes"/> interface. Set the attribute before streaming begins. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5805F930-6CBD-4089-A052-522B4D152CC1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5805F930-6CBD-4089-A052-522B4D152CC1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MP2DLNA_VIDEO_BIT_RATE = new Guid(0xe88548de, 0x73b4, 0x42d7, 0x9c, 0x75, 0xad, 0xfa, 0xa, 0x2a, 0x6e, 0x4c);
        /// <summary>
        /// Specifies the maximum audio bit rate for the Digital Living Network Alliance (DLNA) media sink.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// The value is the target maximum bit rate for the encoded audio stream, in bits per second. The
        /// value must be one of the bit rates allowed for MPEG-2 layer 2 audio for DLNA. The default value is
        /// 192000 (192 Kbps).
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// To set this attribute on the DLNA media sink, query the media sink for the 
        /// <see cref="IMFAttributes"/> interface. Set the attribute before streaming begins. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D0AE573A-7CE3-49E8-9609-F72D067F1CE1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D0AE573A-7CE3-49E8-9609-F72D067F1CE1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MP2DLNA_AUDIO_BIT_RATE = new Guid(0x2d1c070e, 0x2b5f, 0x4ab3, 0xa7, 0xe6, 0x8d, 0x94, 0x3b, 0xa8, 0xd0, 0x0a);
        /// <summary>
        /// Specifies the encoding quality for the Digital Living Network Alliance (DLNA) media sink.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Range: 0–18
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// Higher numbers indicate better encoding quality. Lower numbers indicate faster encoding, but lower
        /// encoding quality. The default value is 9.
        /// <para/>
        /// To set this attribute on the DLNA media sink, query the media sink for the 
        /// <see cref="IMFAttributes"/> interface. Set the attribute before streaming begins. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4CF745AB-66AE-40F2-B5C4-3F72F1B9BADB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4CF745AB-66AE-40F2-B5C4-3F72F1B9BADB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MP2DLNA_ENCODE_QUALITY = new Guid(0xb52379d7, 0x1d46, 0x4fb6, 0xa3, 0x17, 0xa4, 0xa5, 0xf6, 0x09, 0x59, 0xf8);
        /// <summary>
        /// Gets statistics from the Digital Living Network Alliance (DLNA) media sink.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong><see cref="MFMPEG2DLNASINKSTATS"/></strong> stored as <strong>BYTE[]</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetBlob"/>. 
        /// </summary>
        /// <remarks>
        /// During streaming, the DLNA media sink updates this attribute with statistics about the encoding and
        /// multiplexing of the MPEG-2 streams. The application can query this attribute at any time to get the
        /// latest values.
        /// <para/>
        /// Setting this attribute on the DLNA media sink has no effect.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1FA6EA9F-FD30-4FA2-A0E6-1647273BCC35(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1FA6EA9F-FD30-4FA2-A0E6-1647273BCC35(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MP2DLNA_STATISTICS = new Guid(0x75e488a3, 0xd5ad, 0x4898, 0x85, 0xe0, 0xbc, 0xce, 0x24, 0xa7, 0x22, 0xd7);

        /// <summary>
        /// Contains a pointer to the application's callback interface for the sink writer.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong><see cref="ReadWrite.IMFSinkWriterCallback"/>* </strong> stored as <strong>IUnknown*
        /// </strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUnknown"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUnknown"/>. 
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a pointer to the application's 
        /// <see cref="ReadWrite.IMFSinkWriterCallback"/> interface. 
        /// <para/>
        /// Use this attribute with the following functions:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateSinkWriterFromMediaSink"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSinkWriterFromURL"/></para>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/22DF1FA0-469D-4501-AAF0-A0379B7ED096(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/22DF1FA0-469D-4501-AAF0-A0379B7ED096(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SINK_WRITER_ASYNC_CALLBACK = new Guid(0x48cb183e, 0x7b0b, 0x46f4, 0x82, 0x2e, 0x5e, 0x1d, 0x2d, 0xda, 0x43, 0x54);
        /// <summary>
        /// Specifies whether the sink writer limits the rate of incoming data.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// By default, the sink writer's <see cref="ReadWrite.IMFSinkWriter.WriteSample"/> method limits the
        /// data rate by blocking the calling thread. This prevents the application from delivering samples too
        /// quickly. To disable this behavior, set the MF_SINK_WRITER_DISABLE_THROTTLING attribute to <strong>
        /// TRUE</strong> when you create the sink writer. 
        /// <para/>
        /// Use this attribute with the following functions:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateSinkWriterFromMediaSink"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSinkWriterFromURL"/></para>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EB79BDA7-ECE0-4977-A0F9-D40BD5D220AB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EB79BDA7-ECE0-4977-A0F9-D40BD5D220AB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SINK_WRITER_DISABLE_THROTTLING = new Guid(0x08b845d8, 0x2b74, 0x4afe, 0x9d, 0x53, 0xbe, 0x16, 0xd2, 0xd5, 0xae, 0x4f);
        /// <summary>
        /// Contains a pointer to the DXGI Device Manager for the <c>Sink Writer</c>. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IMFDXGIDeviceManager*</strong> stored as <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a pointer to the <see cref="IMFDXGIDeviceManager"/> interface. 
        /// <para/>
        /// Use this attribute to provide a Direct3D device for any video encoders or media sinks loaded by the
        /// Sink Writer. 
        /// <para/>
        /// Use this attribute with the following functions:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateSinkWriterFromMediaSink"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSinkWriterFromURL"/></para>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0328FC02-2D32-480B-BB03-9C78BF317AF5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0328FC02-2D32-480B-BB03-9C78BF317AF5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SINK_WRITER_D3D_MANAGER = new Guid(0xec822da2, 0xe1e9, 0x4b29, 0xa0, 0xd8, 0x56, 0x3c, 0x71, 0x9f, 0x52, 0x69);
        /// <summary>
        /// Contains a pointer to a property store with encoding properties.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/28AC864C-C63C-4BD4-9770-B7B48A2815C6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/28AC864C-C63C-4BD4-9770-B7B48A2815C6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SINK_WRITER_ENCODER_CONFIG = new Guid(0xad91cd04, 0xa7cc, 0x4ac7, 0x99, 0xb6, 0xa5, 0x7b, 0x9a, 0x4a, 0x7c, 0x70);
        /// <summary>
        /// Enables or disables format conversions by the source reader or sink writer.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// By default, the source reader and sink writer can perform some format conversions on uncompressed
        /// audio and video streams. To disable this behavior, set this attribute to <strong>TRUE</strong> when
        /// you create the source reader or sink writer. 
        /// <para/>
        /// Use this attribute with the following functions:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateSourceReaderFromByteStream"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSourceReaderFromMediaSource"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSourceReaderFromURL"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSinkWriterFromMediaSink"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSinkWriterFromURL"/></para>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/282B70C3-C81C-47DD-BFA2-7E77138CCB91(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/282B70C3-C81C-47DD-BFA2-7E77138CCB91(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_READWRITE_DISABLE_CONVERTERS = new Guid(0x98d5b065, 0x1374, 0x4847, 0x8d, 0x5d, 0x31, 0x52, 0x0f, 0xee, 0x71, 0x56);
        /// <summary>
        /// Enables the source reader or sink writer to use hardware-based Media Foundation transforms (MFTs).
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// By default, the source reader and sink writer do not use hardware decoders or encoders. To enable
        /// the use of hardware MFTs, set this attribute to <strong>TRUE</strong> when you create the source
        /// reader or sink writer. 
        /// <para/>
        /// Use this attribute with the following functions: 
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateSourceReaderFromByteStream"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSourceReaderFromMediaSource"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSourceReaderFromURL"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSinkWriterFromMediaSink"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSinkWriterFromURL"/></para>
        /// <para/>
        /// There is one exception to the default behavior. The source reader and sink writer automatically use
        /// MFTs that are registered locally in the caller's process. To register an MFT locally, call 
        /// <see cref="MFExtern.MFTRegisterLocal"/> or <see cref="MFExtern.MFTRegisterLocalByCLSID"/>. Hardware
        /// MFTs that are registered locally are used even if the <strong>
        /// MF_READWRITE_ENABLE_HARDWARE_TRANSFORMS</strong> attribute is not set. 
        /// <para/>
        /// This attribute does not affect hardware-accelerated video decoding that uses DirectX Video
        /// Acceleration (DXVA). To enable DXVA decoding in the source reader, set the 
        /// <see cref="MFAttributesClsid.MF_SOURCE_READER_D3D_MANAGER"/> attribute. 
        /// <para/>
        /// If this attribute is <strong>TRUE</strong>, do not set the 
        /// <see cref="MFAttributesClsid.MF_READWRITE_DISABLE_CONVERTERS"/> attribute. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/03F2FA76-B828-40B1-929D-60E7D5AB49BB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/03F2FA76-B828-40B1-929D-60E7D5AB49BB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_READWRITE_ENABLE_HARDWARE_TRANSFORMS = new Guid(0xa634a91c, 0x822b, 0x41b9, 0xa4, 0x94, 0x4d, 0xe4, 0x64, 0x36, 0x12, 0xb0);
        /// <summary>
        /// Specifies a <c>Multimedia Class Scheduler Service</c> (MMCSS) class for the Source Reader or Sink
        /// Writer. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>LPWSTR</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetString"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetString"/>. 
        /// </summary>
        /// <remarks>
        /// Optionally set this attribute when you create an instance of the <c>Source Reader</c> or 
        /// <c>Sink Writer</c>. The value of the attribute must be a valid MMCSS class name. 
        /// <para/>
        /// If this attribute is set, the Source Reader or Sink Writer registers all of its threads with the
        /// specified MMCSS class. The MMCSS ensures that data processing in the Source Reader or Sink Writer
        /// has priority over other system tasks.
        /// <para/>
        /// To specify the base priority, set the <see cref="MFAttributesClsid.MF_READWRITE_MMCSS_PRIORITY"/>
        /// attribute. If that attribute is not set, the base priority is zero. 
        /// <para/>
        /// For audio-processing threads, the <see cref="MFAttributesClsid.MF_READWRITE_MMCSS_CLASS_AUDIO"/>
        /// attribute (if set) overrides this attribute. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A3A295E8-AC9C-4641-ADDA-B97D5AB13A9A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A3A295E8-AC9C-4641-ADDA-B97D5AB13A9A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_READWRITE_MMCSS_CLASS = new Guid(0x39384300, 0xd0eb, 0x40b1, 0x87, 0xa0, 0x33, 0x18, 0x87, 0x1b, 0x5a, 0x53);
        /// <summary>
        /// Sets the base thread priority for the Source Reader or Sink Writer.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>INT32</strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// Optionally set this attribute when you create an instance of the <c>Source Reader</c> or 
        /// <c>Sink Writer</c>. If you set this attribute, also set the 
        /// <see cref="MFAttributesClsid.MF_READWRITE_MMCSS_CLASS"/> attribute. Otherwise, this attribute is
        /// ignored. 
        /// <para/>
        /// When the Source Reader or Sink Writer registers threads with the 
        /// <c>Multimedia Class Scheduler Service</c>, the value of this attribute specifies the base thread
        /// priority. If this attribute is not set, the default value is zero. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9513AE28-2AF4-45EC-AC19-C0718540E26F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9513AE28-2AF4-45EC-AC19-C0718540E26F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_READWRITE_MMCSS_PRIORITY = new Guid(0x43ad19ce, 0xf33f, 0x4ba9, 0xa5, 0x80, 0xe4, 0xcd, 0x12, 0xf2, 0xd1, 0x44);
        /// <summary>
        /// Specifies a <c>Multimedia Class Scheduler Service</c> (MMCSS) class for audio-processing threads in
        /// the Source Reader or Sink Writer. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>LPWSTR</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetString"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetString"/>. 
        /// </summary>
        /// <remarks>
        /// Optionally set this attribute when you create an instance of the <c>Source Reader</c> or 
        /// <c>Sink Writer</c>. The value of the attribute must be a valid MMCSS class name. 
        /// <para/>
        /// If this attribute is set, the Source Reader or Sink Writer registers its audio-processing threads
        /// with the specified MMCSS class. The MMCSS ensures that data processing in the Source Reader or Sink
        /// Writer has priority over other system tasks. 
        /// <para/>
        /// To specify the base priority for audio threads, set the 
        /// <see cref="MFAttributesClsid.MF_READWRITE_MMCSS_PRIORITY_AUDIO"/> attribute. If that attribute is
        /// not set, the base priority for audio threads is zero. 
        /// <para/>
        /// This attribute overrides the <see cref="MFAttributesClsid.MF_READWRITE_MMCSS_CLASS"/> attribute for
        /// audio-processing threads. If neither attribute is set, audio threads are not registered with MCSS. 
        /// <para/>
        /// For most applications, audio glitching is much more noticeable to the user than video glitching,
        /// and therefore less acceptable. For this reason, an application should typically set
        /// MF_READWRITE_MMCSS_CLASS_AUDIO to a higher-priority MMCSS class than 
        /// <see cref="MFAttributesClsid.MF_READWRITE_MMCSS_CLASS"/>. This ensures that audio processing is
        /// given higher priority than other tasks. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F1B8A8C8-2E41-4321-A94D-C50447C69941(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F1B8A8C8-2E41-4321-A94D-C50447C69941(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_READWRITE_MMCSS_CLASS_AUDIO = new Guid(0x430847da, 0x0890, 0x4b0e, 0x93, 0x8c, 0x05, 0x43, 0x32, 0xc5, 0x47, 0xe1);
        /// <summary>
        /// Sets the base priority for audio-processing threads created by the Source Reader or Sink Writer.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>INT32</strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// Optionally set this attribute when you create an instance of the <c>Source Reader</c> or 
        /// <c>Sink Writer</c>. If you set this attribute, also set the 
        /// <see cref="MFAttributesClsid.MF_READWRITE_MMCSS_CLASS_AUDIO"/> attribute. Otherwise, this attribute
        /// is ignored. 
        /// <para/>
        /// When the Source Reader or Sink Writer registers audio-processing threads with the 
        /// <c>Multimedia Class Scheduler Service</c>, the value of this attribute specifies the base thread
        /// priority. If this attribute is not set, the default value is zero. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C0E3A472-959F-4F74-8906-03630DE4CB8C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C0E3A472-959F-4F74-8906-03630DE4CB8C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_READWRITE_MMCSS_PRIORITY_AUDIO = new Guid(0x273db885, 0x2de2, 0x4db2, 0xa6, 0xa7, 0xfd, 0xb6, 0x6f, 0xb4, 0x0b, 0x61);
        /// <summary>
        /// Specifies whether the application requires Microsoft Direct3D support in the <c>Source Reader</c>
        /// or <c>Sink Writer</c>. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies only if the application enables Direct3D support using the 
        /// <see cref="MFAttributesClsid.MF_SOURCE_READER_D3D_MANAGER"/> or 
        /// <see cref="MFAttributesClsid.MF_SINK_WRITER_D3D_MANAGER"/> attribute. 
        /// <para/>
        /// If the application enables Direct3D support, the Source Reader and Sink Writer will both try to
        /// allocate Direct3D surfaces for video. If this fails, and the MF_READWRITE_D3D_OPTIONAL attribute is
        /// <strong>TRUE</strong>, the Source Reader/Sink Writer will fall back to allocating video surfaces in
        /// system memory. Otherwise, if Direct3D surfaces cannot be allocated and MF_READWRITE_D3D_OPTIONAL is
        /// <strong>FALSE</strong>, an error occurs during processing. 
        /// <para/>
        /// If the application does not enable Direct3D support, the Source Reader/Sink Writer uses system
        /// memory, and ignores the value of MF_READWRITE_D3D_OPTIONAL.
        /// <para/>
        /// This attribute is optional. The default value is <strong>FALSE</strong>. Set the attribute when you
        /// create the Source Reader or Sink Writer. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3844ED7B-E1E5-4CD7-B080-FE7EC7B28AC5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3844ED7B-E1E5-4CD7-B080-FE7EC7B28AC5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_READWRITE_D3D_OPTIONAL = new Guid(0x216479d9, 0x3071, 0x42ca, 0xbb, 0x6c, 0x4c, 0x22, 0x10, 0x2e, 0x1d, 0x18);

        /// <summary>
        /// Contains a pointer to the application's callback interface for the <c>Source Reader</c>. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IMFSourceReaderCallback*</strong> stored as <strong>IUnknown*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUnknown"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUnknown"/>. 
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a pointer to the application's 
        /// <see cref="ReadWrite.IMFSourceReaderCallback"/> interface. 
        /// <para/>
        /// Use this attribute with the following functions:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateSourceReaderFromByteStream"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSourceReaderFromMediaSource"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSourceReaderFromURL"/></para>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DE226A5A-03C0-4BFE-BB20-8969CE43CF53(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DE226A5A-03C0-4BFE-BB20-8969CE43CF53(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SOURCE_READER_ASYNC_CALLBACK = new Guid(0x1e3dbeac, 0xbb43, 0x4c35, 0xb5, 0x07, 0xcd, 0x64, 0x44, 0x64, 0xc9, 0x65);
        /// <summary>
        /// Contains a pointer to the Microsoft <c>Direct3D Device Manager</c> for the <c>Source Reader</c>. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IDirect3DDeviceManager9*</strong> stored as <strong>IUnknown*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUnknown"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUnknown"/>. 
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a pointer to the <c>IDirect3DDeviceManager9</c> interface. 
        /// <para/>
        /// Use this attribute to provide a Direct3D device for any video decoders loaded by the source reader.
        /// If you set this attribute and the decoder supports Microsoft DirectX Video Acceleration (DXVA), the
        /// source reader uses the Direct3D device to allocate video buffers. These buffers are compatible with
        /// the DXVA 2 video processor. (See <c>DXVA Video Processing</c>.) 
        /// <para/>
        /// Use this attribute with the following functions:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateSourceReaderFromByteStream"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSourceReaderFromMediaSource"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSourceReaderFromURL"/></para>
        /// <para/>
        /// Typically you would set this attribute if you are using the source reader to get decoded video
        /// frames and using Direct3D to display the frames. Setting this attribute enables the decoder to use
        /// DXVA.
        /// <para/>
        /// You would not set this attribute if:
        /// <para/>
        /// <para>* You are using the source reader to process audio only and not video.</para><para>* You are
        /// getting compressed video from the source reader. In that case, the source reader does not create a
        /// decoder.</para>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/507D350E-DA0C-42D0-8A8D-77618EE5A1DD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/507D350E-DA0C-42D0-8A8D-77618EE5A1DD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SOURCE_READER_D3D_MANAGER = new Guid(0xec822da2, 0xe1e9, 0x4b29, 0xa0, 0xd8, 0x56, 0x3c, 0x71, 0x9f, 0x52, 0x69);
        /// <summary>
        /// Specifies whether the <c>Source Reader</c> enables DirectX Video Acceleration (DXVA) on the video
        /// decoder. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// This attribute applies if the following conditions are true:
        /// <para/>
        /// <para>* The source reader decodes a video stream.</para><para>* The video decoder supports DXVA
        /// decoding.</para><para>* The application uses the 
        /// <see cref="MFAttributesClsid.MF_SOURCE_READER_D3D_MANAGER"/> attribute to set the 
        /// <c>Direct3D Device Manager</c> on the source reader. </para>
        /// <para/>
        /// This attribute enables the application to disable DXVA while still decoding to Direct3D surfaces.
        /// <para/>
        /// By default, the source reader uses the <c>Direct3D Device Manager</c> for two purposes: 
        /// <para/>
        /// <para>* To enable DXVA decoding in the video decoder. </para><para>* To allocate Direct3D surfaces
        /// for the video samples.</para>
        /// <para/>
        /// If the value of the MF_SOURCE_READER_DISABLE_DXVA attribute is <strong>TRUE</strong>, the source
        /// reader does disables DXVA decoding, although it still uses the <c>Direct3D Device Manager</c> to
        /// allocate Direct3D surfaces. 
        /// <para/>
        /// If the <see cref="MFAttributesClsid.MF_SOURCE_READER_D3D_MANAGER"/> attribute is not set, the
        /// MF_SOURCE_READER_DISABLE_DXVA attribute is ignored. 
        /// <para/>
        /// The default value of this attribute is <strong>FALSE</strong>, meaning that DXVA decoding is
        /// enabled when available. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EC539038-3FD3-41B7-A0E6-E75E3F2828A7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EC539038-3FD3-41B7-A0E6-E75E3F2828A7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SOURCE_READER_DISABLE_DXVA = new Guid(0xaa456cfd, 0x3943, 0x4a1e, 0xa7, 0x7d, 0x18, 0x38, 0xc0, 0xea, 0x2e, 0x35);
        /// <summary>
        /// Contains configuration properties for the <c>Source Reader</c>. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IPropertyStore*</strong> stored as <strong>IUnknown*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUnknown"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUnknown"/>. 
        /// </summary>
        /// <remarks>
        /// The value of this attribute is a pointer to the <strong>IPropertyStore</strong> interface of a
        /// property store. You can use this attribute to pass configuration properties to the media source. 
        /// <para/>
        /// Use this attribute with the following functions:
        /// <para/>
        /// <para>* <see cref="MFExtern.MFCreateSourceReaderFromByteStream"/></para><para>* 
        /// <see cref="MFExtern.MFCreateSourceReaderFromURL"/></para>
        /// <para/>
        /// Internally, the source reader passes the <strong>IPropertyStore</strong> pointer to the source
        /// resolver. For more information, see <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F7E5EF6A-5FC3-4F39-ACC0-61CE79030211(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F7E5EF6A-5FC3-4F39-ACC0-61CE79030211(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SOURCE_READER_MEDIASOURCE_CONFIG = new Guid(0x9085abeb, 0x0354, 0x48f9, 0xab, 0xb5, 0x20, 0x0d, 0xf8, 0x38, 0xc6, 0x8e);
        /// <summary>
        /// Gets the characteristics of the media source from the <c>Source Reader</c>. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// The value is a bitwise <strong>OR</strong> of flags from the 
        /// <see cref="MFMediaSourceCharacteristics"/> enumeration. 
        /// </summary>
        /// <remarks>
        /// To get this attribute, call the <see cref="ReadWrite.IMFSourceReader.GetPresentationAttribute"/>
        /// method on the source reader. Set the <em>dwStreamIndex</em> parameter to <strong>
        /// MF_SOURCE_READER_MEDIASOURCE</strong> and the <em>guidAttribute</em> parameter to
        /// MF_SOURCE_READER_MEDIASOURCE_CHARACTERISTICS. 
        /// <para/>
        /// The <strong>PROPVARIANT</strong> type for this attribute is <strong>VT_UI4</strong>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4CD48B69-6F7B-4B13-86F3-B38969025F70(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4CD48B69-6F7B-4B13-86F3-B38969025F70(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SOURCE_READER_MEDIASOURCE_CHARACTERISTICS = new Guid(0x6d23f5c8, 0xc5d7, 0x4a9b, 0x99, 0x71, 0x5d, 0x11, 0xf8, 0xbc, 0xa8, 0x80);
        /// <summary>
        /// Enables video processing by the <c>Source Reader</c>. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>Nonzero</strong></term><description>Enable video processing.</description></item>
        /// <item><term><strong>Zero</strong></term><description>Disable video processing. (Default)</description></item>
        /// </list>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// If this attribute is <strong>TRUE</strong> (nonzero), the source reader can perform the following
        /// limited video processing on uncompressed video frames: 
        /// <para/>
        /// <para>* Conversion from YUV to RGB-32.</para><para>* Deinterlacing.</para>
        /// <para/>
        /// These operations are performed in software, and are not optimized for playback. This feature is
        /// intended for applications that process a small number of frames—for example, to create a video
        /// thumbnail—or applications that do not decode frames in real time. The deinterlace operation
        /// interpolates data from a single field, so it is lossy.
        /// <para/>
        /// Avoid this setting if  you are using Direct3D to display the video frames, because the GPU
        /// generally provides better video processing capabilities.
        /// <para/>
        /// If this attribute is <strong>TRUE</strong>, the following attributes must be <strong>FALSE</strong>
        /// : 
        /// <para/>
        /// <para>* <see cref="MFAttributesClsid.MF_SOURCE_READER_D3D_MANAGER"/></para><para>* 
        /// <see cref="MFAttributesClsid.MF_READWRITE_DISABLE_CONVERTERS"/></para>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B1EC1C0E-8042-4486-822F-EB106577C0B1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B1EC1C0E-8042-4486-822F-EB106577C0B1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SOURCE_READER_ENABLE_VIDEO_PROCESSING = new Guid(0xfb394f3d, 0xccf1, 0x42ee, 0xbb, 0xb3, 0xf9, 0xb8, 0x45, 0xd5, 0x68, 0x1d);
        /// <summary>
        /// Specifies whether the <c>Source Reader</c> shuts down the media source. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT32"/>. 
        /// </summary>
        /// <remarks>
        /// This attribute applies only when the application creates the source reader from an existing media
        /// source object, either by calling <see cref="MFExtern.MFCreateSourceReaderFromMediaSource"/> or by
        /// calling <see cref="ReadWrite.IMFReadWriteClassFactory.CreateInstanceFromObject"/>. 
        /// <para/>
        /// By default, when the application releases the source reader, the source reader shuts down the media
        /// source by calling <see cref="IMFMediaSource.Shutdown"/> on the media source. At that point, the
        /// application can no longer use the media source. 
        /// <para/>
        /// However, if the MF_SOURCE_READER_DISCONNECT_MEDIASOURCE_ON_SHUTDOWN attribute is <strong>TRUE
        /// </strong>, the source reader does not shut down the media source. That means the application can
        /// still use the media source after the application releases the source reader. It also means the
        /// application is responsible for calling <see cref="IMFMediaSource.Shutdown"/> on the media source. 
        /// <para/>
        /// If the application creates the source reader from a URL or from a byte stream, the source reader
        /// always shuts down the media source. The MF_SOURCE_READER_DISCONNECT_MEDIASOURCE_ON_SHUTDOWN
        /// attribute is ignored in this case.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C85F5994-8005-48C9-8A05-0316F48F4142(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C85F5994-8005-48C9-8A05-0316F48F4142(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SOURCE_READER_DISCONNECT_MEDIASOURCE_ON_SHUTDOWN = new Guid(0x56b67165, 0x219e, 0x456d, 0xa2, 0x2e, 0x2d, 0x30, 0x04, 0xc7, 0xfe, 0x56);
        /// <summary>
        /// Enables advanced video processing by the <c>Source Reader</c>. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// If this attribute is <strong>TRUE</strong>, the Source Reader can insert a video processor into the
        /// processing pipeline, which enables the following types of format conversion: 
        /// <para/>
        /// <para>* Color space conversion (YUV to RGB-32)</para><para>* Deinterlacing</para><para>* Video
        /// resizing</para><para>* Frame-rate conversion</para>
        /// <para/>
        /// If this attribute is <strong>TRUE</strong>, the 
        /// <see cref="MFAttributesClsid.MF_READWRITE_DISABLE_CONVERTERS"/> attribute must be <strong>FALSE
        /// </strong>. 
        /// <para/>
        /// The Source Reader looks for video processors that are registered in the <strong>
        /// MFT_CATEGORY_VIDEO_PROCESSOR</strong> category, including MFTs that are registered for the local
        /// process. (See <see cref="MFExtern.MFTRegisterLocal"/> for more information about local registration
        /// of MFTs.) The Source Reader uses the Transcode Video Processor (XVP) if no other suitable video
        /// processor is found. 
        /// <para/>
        /// The application specifies the desired output type by calling 
        /// <see cref="ReadWrite.IMFSourceReader.SetCurrentMediaType"/>. When the Source Reader configures the
        /// video processor, it attempts to match the following attributes of the output type: 
        /// <para/>
        /// <para>* Frame rate ( <see cref="MFAttributesClsid.MF_MT_FRAME_RATE"/>) </para><para>* Frame size ( 
        /// <see cref="MFAttributesClsid.MF_MT_FRAME_SIZE"/>) </para><para>* Interlace mode ( 
        /// <see cref="MFAttributesClsid.MF_MT_INTERLACE_MODE"/>) </para><para>* Pixel aspect ratio ( 
        /// <see cref="MFAttributesClsid.MF_MT_PIXEL_ASPECT_RATIO"/>) </para><para>* Subtype ( 
        /// <see cref="MFAttributesClsid.MF_MT_SUBTYPE"/>) </para>
        /// <para/>
        /// This attribute is similar to the 
        /// <see cref="MFAttributesClsid.MF_SOURCE_READER_ENABLE_VIDEO_PROCESSING"/> attribute, but offers the
        /// following advantages: 
        /// <para/>
        /// <para>* A greater range of format conversions is supported.</para><para>* Applications can register
        /// their own converters.</para><para>* Some conversions can be performed in hardware using the GPU.
        /// </para>
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1055CD55-4B25-4EEC-AF1B-C84C52287F8F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1055CD55-4B25-4EEC-AF1B-C84C52287F8F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SOURCE_READER_ENABLE_ADVANCED_VIDEO_PROCESSING = new Guid(0xf81da2c, 0xb537, 0x4672, 0xa8, 0xb2, 0xa6, 0x81, 0xb1, 0x73, 0x7, 0xa3);
        /// <summary>
        /// Disables the use of post-processing camera plug-ins by the <c>Source Reader</c>. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies when the Source Reader is used with a video capture source. If this
        /// attribute is <strong>TRUE</strong>, it prevents the Source Reader from loading any post-processing
        /// plug-ins that the camera might provide. Otherwise, by default the Source Reader will load them. 
        /// <para/>
        /// The default value of this attribute is <strong>FALSE</strong>. Set the attribute when you create
        /// the source reader. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/837A6BA8-9C79-4B0A-B40D-C094009BFF2C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/837A6BA8-9C79-4B0A-B40D-C094009BFF2C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SOURCE_READER_DISABLE_CAMERA_PLUGINS = new Guid(0x9d3365dd, 0x58f, 0x4cfb, 0x9f, 0x97, 0xb3, 0x14, 0xcc, 0x99, 0xc8, 0xad);
        /// <summary>
        /// Enables the <c>Source Reader</c> to use Media Foundation transforms (MFTs) that are optimized for
        /// transcoding. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// <para/>
        /// Treat as Boolean.
        /// </summary>
        /// <remarks>
        /// Some MFTs, particularly decoders, are optimized for transcoding rather than playback. By default,
        /// the Source Reader will not load such transforms. Set this attribute to <strong>TRUE</strong> if you
        /// want to use transcoding MFTs with the Source Reader. 
        /// <para/>
        /// An application might set this attribute if it does not process the data in real time (for
        /// transcoding or similar scenarios). Otherwise, for real-time playback, use the default behavior.
        /// <para/>
        /// Internally, this attribute causes the Source Reader to include the <strong>
        /// MFT_ENUM_FLAG_TRANSCODE_ONLY</strong> flag when it calls <see cref="MFExtern.MFTEnumEx"/>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9463EB8C-2CA3-4F8F-8A2A-B1292879DD1B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9463EB8C-2CA3-4F8F-8A2A-B1292879DD1B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SOURCE_READER_ENABLE_TRANSCODE_ONLY_TRANSFORMS = new Guid(0xdfd4f008, 0xb5fd, 0x4e78, 0xae, 0x44, 0x62, 0xa1, 0xe6, 0x7b, 0xbe, 0x27);

        #endregion

        #region Misc W8 attributes

        /// <summary>
        /// Specifies how a Media Foundation transform (MFT) should output a 3D stereoscopic video stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The value of the attribute is a member of the <see cref="Transform.MF3DVideoOutputType"/>
        /// enumeration. 
        /// <para/>
        /// This attribute applies only if the MFT returns <strong>TRUE</strong> for the 
        /// <see cref="MFAttributesClsid.MFT_SUPPORT_3DVIDEO"/> attribute. 
        /// <para/>
        /// To get or set this attribute call <see cref="Transform.IMFTransform.GetAttributes"/> to get the
        /// global attribute store of the MFT. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AA75A2FB-DEAC-44E9-93E9-4AC2D9F03B39(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AA75A2FB-DEAC-44E9-93E9-4AC2D9F03B39(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_ENABLE_3DVIDEO_OUTPUT = new Guid(0xbdad7bca, 0xe5f, 0x4b10, 0xab, 0x16, 0x26, 0xde, 0x38, 0x1b, 0x62, 0x93);
        /// <summary>
        /// Specifies the binding flags to use when allocating Microsoft Direct3D 11 surfaces for media
        /// samples.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C3B475B1-9A44-47EA-BCE7-D3D0FB56DDAC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C3B475B1-9A44-47EA-BCE7-D3D0FB56DDAC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SA_D3D11_BINDFLAGS = new Guid(0xeacf97ad, 0x065c, 0x4408, 0xbe, 0xe3, 0xfd, 0xcb, 0xfd, 0x12, 0x8b, 0xe2);
        /// <summary>
        /// Specifies how to allocate Microsoft Direct3D 11 surfaces for media samples. The usage directly
        /// reflects whether a sample is accessible by the CPU or GPU.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>D3D11_USAGE</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E9A415FA-74BF-4822-BB0E-D8AAA7D73664(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E9A415FA-74BF-4822-BB0E-D8AAA7D73664(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SA_D3D11_USAGE = new Guid(0xe85fe442, 0x2ca3, 0x486e, 0xa9, 0xc7, 0x10, 0x9d, 0xda, 0x60, 0x98, 0x80);
        /// <summary>
        /// Specifies whether a Media Foundation transform (MFT) supports Microsoft Direct3D 11.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies only to video MFTs. To query this attribute, call 
        /// <see cref="Transform.IMFTransform.GetAttributes"/> to get the MFT attribute store. If <strong>
        /// GetAttributes</strong> succeeds, call <see cref="IMFAttributes.GetUINT32"/>. 
        /// <para/>
        /// <para>* If the attribute is nonzero, the client can give the MFT a pointer to the 
        /// <see cref="IMFDXGIDeviceManager"/> interface before streaming starts. To do so, the client sends
        /// the <c>MFT_MESSAGE_SET_D3D_MANAGER</c> message to the MFT. The client is not required to send this
        /// message. </para><para>* If this attribute is zero ( <strong>FALSE</strong>), the MFT does not
        /// support Direct3D 11, and the client should not send the <c>MFT_MESSAGE_SET_D3D_MANAGER</c> message
        /// to the MFT. </para>
        /// <para/>
        /// The default value of this attribute is <strong>FALSE</strong>. Treat this attribute as read-only.
        /// Do not change the value; the MFT will ignore any changes to the value. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/23482B8A-58F3-4B39-9C6D-54EC27D36C01(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23482B8A-58F3-4B39-9C6D-54EC27D36C01(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SA_D3D11_AWARE = new Guid(0x206b4fc8, 0xfcf9, 0x4c51, 0xaf, 0xe3, 0x97, 0x64, 0x36, 0x9e, 0x33, 0xa0);
        /// <summary>
        /// Indicates to the video sample allocator to create textures as  shareable using keyed-mutex.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/798CA474-3B1A-4795-81B7-563749197104(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/798CA474-3B1A-4795-81B7-563749197104(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SA_D3D11_SHARED = new Guid(0x7b8f32c3, 0x6d96, 0x4b89, 0x92, 0x3, 0xdd, 0x38, 0xb6, 0x14, 0x14, 0xf3);

        /// <summary>
        /// Indicates to the video sample allocator to create textures as shareable using the legacy mechanism.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/jj553487(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/jj553487(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SA_D3D11_SHARED_WITHOUT_MUTEX = new Guid(0x39dbd44d, 0x2e44, 0x4931, 0xa4, 0xc8, 0x35, 0x2d, 0x3d, 0xc4, 0x21, 0x15);

        /// <summary>
        /// Specifies how many buffers the video-sample allocator creates for each video sample. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// If you use the <see cref="IMFVideoSampleAllocatorEx"/> interface to allocate video samples, you can
        /// use this attribute to create video samples that contain multiple buffers. For example, if the
        /// attribute value is 2, the allocator creates two video buffers for each video sample. Set the
        /// attribute in the <em>pAttributes</em> parameter of the 
        /// <see cref="IMFVideoSampleAllocatorEx.InitializeSampleAllocatorEx"/> method. 
        /// <para/>
        /// The default value is 1. If the attribute is not set, the allocator creates video samples that
        /// contain a single buffer per sample.
        /// <para/>
        /// This attribute is primarily intended for Media Foundation transforms (MFTs) that support stereo 3D
        /// output, in the following situation: 
        /// <para/>
        /// <para>* The MFT supports Microsoft DirectX Graphics Infrastructure (DXGI).</para><para>* The MFT
        /// allocates its own output samples.</para><para>* The MFT uses the 
        /// <see cref="IMFVideoSampleAllocatorEx"/> interface to allocate the output samples. </para><para>* 
        /// The 3D video format uses a separate buffer for each view. </para>
        /// <para/>
        /// If all of these criteria are true, the MFT should set the attribute value to 2 (one buffer per
        /// view).
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A782BF8A-822A-407D-A30A-F2045BBB0BC0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A782BF8A-822A-407D-A30A-F2045BBB0BC0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_SA_BUFFERS_PER_SAMPLE = new Guid(0x873c5171, 0x1e3d, 0x4e25, 0x98, 0x8d, 0xb4, 0x33, 0xce, 0x04, 0x19, 0x83);
        /// <summary>
        /// Specifies whether a decoder exposes IYUV/I420 output types (suitable for transcoding) before other
        /// formats.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8505CFA1-210A-4DA8-B92A-FCE62F0310E5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8505CFA1-210A-4DA8-B92A-FCE62F0310E5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_DECODER_EXPOSE_OUTPUT_TYPES_IN_NATIVE_ORDER = new Guid(0xef80833f, 0xf8fa, 0x44d9, 0x80, 0xd8, 0x41, 0xed, 0x62, 0x32, 0x67, 0xc);
        /// <summary>
        /// Specifies the final output resolution of the decoded image, after video processing.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT64</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/067867D8-155C-4406-BE07-720016B2AEBC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/067867D8-155C-4406-BE07-720016B2AEBC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_DECODER_FINAL_VIDEO_RESOLUTION_HINT = new Guid(0xdc2f8496, 0x15c4, 0x407a, 0xb6, 0xf0, 0x1b, 0x66, 0xab, 0x5f, 0xbf, 0x53);
        /// <summary>
        /// Specifies the vendor ID for a hardware-based Microsoft Media Foundation transform (MFT).
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>WCHAR*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetString"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetString"/>. 
        /// </summary>
        /// <remarks>
        /// This attribute is informational and optional.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AA31639F-EF70-4454-AC61-60755CAA684A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AA31639F-EF70-4454-AC61-60755CAA684A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFT_ENUM_HARDWARE_VENDOR_ID_Attribute = new Guid(0x3aecb0cc, 0x35b, 0x4bcc, 0x81, 0x85, 0x2b, 0x8d, 0x55, 0x1e, 0xf3, 0xaf);

        /// <summary>
        /// This attribute is set to 1 if it is certain that all video frames in the WVC1 content use progressive and 
        /// single slice encoding. Media Source can set this attribute on the IMFMediaType for WVC1 streams.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        public static readonly Guid MF_WVC1_PROG_SINGLE_SLICE_CONTENT = new Guid(0x67EC2559, 0x0F2F, 0x4420, 0xA4, 0xDD, 0x2F, 0x8E, 0xE7, 0xA5, 0x73, 0x8B);

        /// <summary>
        /// This attribute is set to 1 if it is certain that all video frames in the content use progressive encoding.  
        /// The MP4 Media Source can set this attribute on the IMFMediaType for H.264 streams after examining the SPS 
        /// available in the MP4 'moov' box.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        public static readonly Guid MF_PROGRESSIVE_CODING_CONTENT = new Guid(0x8F020EEA, 0x1508, 0x471F, 0x9D, 0xA6, 0x50, 0x7D, 0x7C, 0xFA, 0x40, 0xDB);

        /// <summary>
        /// Indicates that NALU length information will be sent as a blob with each compressed H.264 sample.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// Set this attribute on media of type MEDIASUBTYPE_H264.
        /// <para/>
        /// The blob containing the NALU length information can be retrieved from 
        /// <see cref="MFAttributesClsid.MF_NALU_LENGTH_INFORMATION"/> attribute. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/71B50B44-6025-4EEC-8B37-53D80CF37B07(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/71B50B44-6025-4EEC-8B37-53D80CF37B07(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_NALU_LENGTH_SET = new Guid(0xA7911D53, 0x12A4, 0x4965, 0xAE, 0x70, 0x6E, 0xAD, 0xD6, 0xFF, 0x05, 0x51);
        /// <summary>
        /// Indicates the lengths of NALUs in the sample.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BLOB</strong>
        /// </summary>
        /// <remarks>
        /// In order for this attribute to be set, the media must be of type MEDIASUBTYPE_H264 and the 
        /// <see cref="MFAttributesClsid.MF_NALU_LENGTH_SET"/> attribute must be set. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/09F54504-A6CF-4385-BDD7-8D23B1D0125C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/09F54504-A6CF-4385-BDD7-8D23B1D0125C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_NALU_LENGTH_INFORMATION = new Guid(0x19124E7C, 0xAD4B, 0x465F, 0xBB, 0x18, 0x20, 0x18, 0x62, 0x87, 0xB6, 0xAF);
        /// <summary>
        /// Sets whether to include a user data payload with the output sample.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BLOB</strong>
        /// </summary>
        /// <remarks>
        /// User data could contain data such as close caption data or bar data.
        /// <para/>
        /// User data is passed through without any decoding.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1F2B8275-9D4C-4732-9905-8ADE4CFD7496(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1F2B8275-9D4C-4732-9905-8ADE4CFD7496(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_USER_DATA_PAYLOAD = new Guid(0xd1d4985d, 0xdc92, 0x457a, 0xb3, 0xa0, 0x65, 0x1a, 0x33, 0xa3, 0x10, 0x47);
        /// <summary>
        /// Specifies whether the <c>MPEG-4 File Sink</c> filters out sequence parameter set (SPS) and picture
        /// parameter set (PPS) NALUs. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// <para/>
        /// <strong>Applies to</strong>
        /// <para/>
        /// <see cref="IMFMediaSink"/>
        /// </summary>
        /// <remarks>
        /// The <c>MPEG-4 File Sink</c> writes the SPS and PPS parameters into the sample description box of
        /// the MP4 file. By default, it filters out the SPS and PPS NALUs from the video stream. To override
        /// this behavior, set the MF_MPEG4SINK_SPSPPS_PASSTHROUGH attribute to <strong>TRUE</strong>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B2574BE5-6334-4ED2-A008-86326CDC13B8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B2574BE5-6334-4ED2-A008-86326CDC13B8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MPEG4SINK_SPSPPS_PASSTHROUGH = new Guid(0x5601a134, 0x2005, 0x4ad2, 0xb3, 0x7d, 0x22, 0xa6, 0xc5, 0x54, 0xde, 0xb2);
        /// <summary>
        /// Indicates that 'moov' will be written  before 'mdat' box in the generated file.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The default behavior of the mpeg4 media sink is to write 'moov' after 'mdat' box. Setting this
        /// attribute causes the generated file to write 'moov'  before 'mdat' box.
        /// <para/>
        /// In order for the mpeg4 sink to use this attribute, the byte stream passed in must not be slow seek
        /// or remote for .
        /// <para/>
        /// This feature involves an additional file copying/remuxing.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/97B68B0A-8266-4FCF-8CD9-35890E1AC774(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/97B68B0A-8266-4FCF-8CD9-35890E1AC774(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_MPEG4SINK_MOOV_BEFORE_MDAT = new Guid(0xf672e3ac, 0xe1e6, 0x4f10, 0xb5, 0xec, 0x5f, 0x3b, 0x30, 0x82, 0x88, 0x16);
        /// <summary>
        /// Indicates whether a media sink supports hardware data flow.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/15838467-D253-4ECE-B9E7-AFD3A21B3AF2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/15838467-D253-4ECE-B9E7-AFD3A21B3AF2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_STREAM_SINK_SUPPORTS_HW_CONNECTION = new Guid(0x9b465cbf, 0x597, 0x4f9e, 0x9f, 0x3c, 0xb9, 0x7e, 0xee, 0xf9, 0x3, 0x59);
        /// <summary>
        /// Indicates whether the stream sink supports video rotation.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/6CE17F9D-3BBB-4F4F-9F1A-495188F1815F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6CE17F9D-3BBB-4F4F-9F1A-495188F1815F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_STREAM_SINK_SUPPORTS_ROTATION = new Guid(0xb3e96280, 0xbd05, 0x41a5, 0x97, 0xad, 0x8a, 0x7f, 0xee, 0x24, 0xb9, 0x12);
        /// <summary>
        /// Specifies if locally registered plugins are disabled.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// Set this attribute to <strong>TRUE</strong> to prevent the MF Topology Loader from inserting
        /// locally registered transforms. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/67108955-1EDF-4AAB-8B9A-25926F8B5E62(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/67108955-1EDF-4AAB-8B9A-25926F8B5E62(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DISABLE_LOCALLY_REGISTERED_PLUGINS = new Guid(0x66b16da9, 0xadd4, 0x47e0, 0xa1, 0x6b, 0x5a, 0xf1, 0xfb, 0x48, 0x36, 0x34);
        /// <summary>
        /// Specifies a local plugin control policy.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// Set this attribute to one of the <see cref="MF_PLUGIN_CONTROL_POLICY"/> values. 
        /// <para/>
        /// This attributes allows the app to specify a more restrictive local policy than the process-wide
        /// policy configured by <see cref="IMFPluginControl"/>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2936F3C9-3BCB-452A-8C03-35D73A200CE2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2936F3C9-3BCB-452A-8C03-35D73A200CE2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_LOCAL_PLUGIN_CONTROL_POLICY = new Guid(0xd91b0085, 0xc86d, 0x4f81, 0x88, 0x22, 0x8c, 0x68, 0xe1, 0xd7, 0xfa, 0x04);
        /// <summary>
        /// Specifies the relative thread priority for a branch of the topology.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to source nodes ( <strong>MF_TOPOLOGY_SOURCESTREAM_NODE</strong>). The
        /// attribute is optional. 
        /// <para/>
        /// This attribute requires the <see cref="MFAttributesClsid.MF_TOPONODE_WORKQUEUE_ID"/> and 
        /// <see cref="MFAttributesClsid.MF_TOPONODE_WORKQUEUE_MMCSS_CLASS"/> attributes on the same node. 
        /// <para/>
        /// The value of the attribute is the relative thread priority of the work queue for this branch of the
        /// topology. The <c>Multimedia Class Scheduler Service</c> (MMCSS) uses the relative priority when it
        /// sets the thread priority. For more information, see <c>AvSetMmThreadPriority</c>. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7BCD2EE0-94FB-4438-9B6A-7B26DBFB5978(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7BCD2EE0-94FB-4438-9B6A-7B26DBFB5978(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_WORKQUEUE_MMCSS_PRIORITY = new Guid(0x5001f840, 0x2816, 0x48f4, 0x93, 0x64, 0xad, 0x1e, 0xf6, 0x61, 0xa1, 0x23);
        /// <summary>
        /// Specifies the work-item priority for a branch of the topology.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute applies to source nodes ( <strong>MF_TOPOLOGY_SOURCESTREAM_NODE</strong>). The
        /// attribute is optional. 
        /// <para/>
        /// This attribute requires the <see cref="MFAttributesClsid.MF_TOPONODE_WORKQUEUE_ID"/> attribute on
        /// the same node. 
        /// <para/>
        /// The GUID constant for this attribute is exported from mfuuid.lib.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B2FA1151-08D3-46F9-A38D-AC8908EFA6A2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B2FA1151-08D3-46F9-A38D-AC8908EFA6A2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_TOPONODE_WORKQUEUE_ITEM_PRIORITY = new Guid(0xa1ff99be, 0x5e97, 0x4a53, 0xb4, 0x94, 0x56, 0x8c, 0x64, 0x2c, 0x0f, 0xf3);
        /// <summary>
        /// Specifies the audio stream category for the <c>Streaming Audio Renderer</c> (SAR). 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// You can use this attribute to configure the audio renderer. The usage depends on which function you
        /// call to create the audio renderer.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Function</term><description>How to Set the attribute</description></listheader>
        /// <item><term><see cref="MFExtern.MFCreateAudioRenderer"/></term><description>Use the <see cref="IMFAttributes"/> pointer specified in the <em>pAudioAttributes</em> parameter. </description></item>
        /// <item><term><see cref="MFExtern.MFCreateAudioRendererActivate"/></term><description>Use the <see cref="IMFActivate"/> pointer returned in the <em>ppActivate</em> parameter. Set the attribute before calling <see cref="IMFActivate.ActivateObject"/>. </description></item>
        /// </list>
        /// <para/>
        /// The value of the attribute is a member of the <c>AUDIO_STREAM_CATEGORY</c> enumeration. The audio
        /// service uses the stream category to determine audio policies when multiple applications play audio
        /// at the same time. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/88E79DE6-2062-4471-A939-D1D4DD2EC42D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/88E79DE6-2062-4471-A939-D1D4DD2EC42D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_AUDIO_RENDERER_ATTRIBUTE_STREAM_CATEGORY = new Guid(0xa9770471, 0x92ec, 0x4df4, 0x94, 0xfe, 0x81, 0xc3, 0x6f, 0xc, 0x3a, 0x7a);
        /// <summary>
        /// Use this service GUID to retrieve IMFSimpleAudioVolume through <see cref="IMFGetService.GetService"/>. 
        /// The retrieved interface will control capture volume.
        /// </summary>
        public static readonly Guid MR_CAPTURE_POLICY_VOLUME_SERVICE = new Guid(0x24030acd, 0x107a, 0x4265, 0x97, 0x5c, 0x41, 0x4e, 0x33, 0xe6, 0x5f, 0x2a);
        /// <summary>
        /// Enables private download mode in the network source.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>BOOL</strong></term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// If this property is <strong>TRUE</strong>, the cache is cleared when the session ends. 
        /// <para/>
        /// The <strong>MFNETSOURCE_CLIENTGUID</strong> constant defines the GUID for the property key. The
        /// property identifier (PID) is zero. To set this property on the network source, pass an <strong>
        /// IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/679661A7-1D31-43F3-A64E-16ADCB5414B0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/679661A7-1D31-43F3-A64E-16ADCB5414B0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_ENABLE_PRIVATEMODE = new Guid(0x824779d8, 0xf18b, 0x4405, 0x8c, 0xf1, 0x46, 0x4f, 0xb5, 0xaa, 0x8f, 0x71);
        /// <summary>
        /// Specifies a friendly name for the identification of the client.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Wide-character string ( <strong>WCHAR</strong>*) </term><description>VT_LPWSTR</description><description><strong>pwszVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/04DEFC2A-6870-4C22-B55D-5514C87C1908(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/04DEFC2A-6870-4C22-B55D-5514C87C1908(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PEERMANAGER = new Guid(0x48b29adb, 0xfebf, 0x45ee, 0xa9, 0xbf, 0xef, 0xb8, 0x1c, 0x49, 0x2e, 0xfc);
        /// <summary>
        /// Specifies the string that identifies the UPnP ConnectionManager service.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Wide-character string ( <strong>WCHAR</strong>*) </term><description>VT_LPWSTR</description><description><strong>pwszVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DEB9C310-0AFF-463F-82C2-52CE1B7BB55C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DEB9C310-0AFF-463F-82C2-52CE1B7BB55C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_FRIENDLYNAME = new Guid(0x5b2a7757, 0xbc6b, 0x447e, 0xaa, 0x06, 0x0d, 0xda, 0x1c, 0x64, 0x6e, 0x2f);
        /// <summary>
        /// Specifies a protected surface.
        /// <para/>
        /// Data type: <strong>GUID</strong>
        /// </summary>
        public static readonly Guid MFPROTECTION_PROTECTED_SURFACE = new Guid(0x4f5d9566, 0xe742, 0x4a25, 0x8d, 0x1f, 0xd2, 0x87, 0xb5, 0xfa, 0x0a, 0xde);
        /// <summary>
        /// Specifies disable screen scrap protection.
        /// <para/>
        /// Data type: <strong>GUID</strong>
        /// </summary>
        public static readonly Guid MFPROTECTION_DISABLE_SCREEN_SCRAPE = new Guid(0xa21179a4, 0xb7cd, 0x40d8, 0x96, 0x14, 0x8e, 0xf2, 0x37, 0x1b, 0xa7, 0x8d);
        /// <summary>
        /// Specifies if an application is allowed access to uncompressed video frames.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// A value of 0 indicates that the  application is allowed access to the frames. This might be
        /// determined as a result of a private agreement between the application and the particular content
        /// protection system in use. 
        /// <para/>
        /// A value of 1 indicates that the application is allowed access to frames if a valid application
        /// certificate is provided by the application (see 
        /// <see cref="IMFMediaEngineProtectedContent.SetApplicationCertificate"/>). 
        /// <para/>
        /// A value of 0xFFFFFFFF, which is the default value, indicates no applications are allowed access to
        /// uncompressed  frames. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7D2A9003-B36E-4082-877E-8AC7F5645E89(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7D2A9003-B36E-4082-877E-8AC7F5645E89(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFPROTECTION_VIDEO_FRAMES = new Guid(0x36a59cbc, 0x7401, 0x4a8c, 0xbc, 0x20, 0x46, 0xa7, 0xc9, 0xe5, 0x97, 0xf0);
        /// <summary>
        /// Set as an attribute for an <see cref="IMFOutputSchema"/> object. If this attribute is present, a
        /// failed attempt to apply the protection is ignored. If the associated attribute value is <strong>
        /// TRUE</strong>, the protection schema with the 
        /// <see cref="MFAttributesClsid.MFPROTECTIONATTRIBUTE_FAIL_OVER"/> attribute should be applied. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// If <strong>TRUE</strong>, enforce the protection schema with the 
        /// <see cref="MFAttributesClsid.MFPROTECTIONATTRIBUTE_FAIL_OVER"/> attribute if setting this
        /// protection fails. 
        /// <para/>
        /// Set as an attribute for an <see cref="IMFOutputSchema"/> object. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0CCCAB27-DEB0-41D8-A70C-D6CCEFE0601F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0CCCAB27-DEB0-41D8-A70C-D6CCEFE0601F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFPROTECTIONATTRIBUTE_BEST_EFFORT = new Guid(0xc8e06331, 0x75f0, 0x4ec1, 0x8e, 0x77, 0x17, 0x57, 0x8f, 0x77, 0x3b, 0x46);
        /// <summary>
        /// Indicates whether the protection fails over to this if the best effort fails. This attribute can be
        /// used with <see cref="IMFOutputSchema"/> objects. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// This attribute can be used with <see cref="IMFOutputSchema"/> objects. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8F541BDB-6801-49BC-A825-03FDE2409099(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8F541BDB-6801-49BC-A825-03FDE2409099(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFPROTECTIONATTRIBUTE_FAIL_OVER = new Guid(0x8536abc5, 0x38f1, 0x4151, 0x9c, 0xce, 0xf5, 0x5d, 0x94, 0x12, 0x29, 0xac);
        /// <summary>
        /// Specifies AES DXVA encryption for DXVA decoders.
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
        /// <a href="http://msdn.microsoft.com/en-US/library/8E270C97-E073-40D3-8D33-7BBFE1833940(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8E270C97-E073-40D3-8D33-7BBFE1833940(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFPROTECTION_GRAPHICS_TRANSFER_AES_ENCRYPTION = new Guid(0xc873de64, 0xd8a5, 0x49e6, 0x88, 0xbb, 0xfb, 0x96, 0x3f, 0xd3, 0xd4, 0xce);
        /// <summary>
        /// AC3 file container. 
        /// <para/>
        /// This specifies the container type of an encoded file. See <see cref="MF_TRANSCODE_CONTAINERTYPE"/>.
        /// </summary>
        public static readonly Guid MFTranscodeContainerType_AC3 = new Guid(0x6d8d91c3, 0x8c91, 0x4ed1, 0x87, 0x42, 0x8c, 0x34, 0x7d, 0x5b, 0x44, 0xd0);
        /// <summary>
        /// ADTS file container. 
        /// <para/>
        /// This specifies the container type of an encoded file. See <see cref="MF_TRANSCODE_CONTAINERTYPE"/>.
        /// </summary>
        public static readonly Guid MFTranscodeContainerType_ADTS = new Guid(0x132fd27d, 0x0f02, 0x43de, 0xa3, 0x01, 0x38, 0xfb, 0xbb, 0xb3, 0x83, 0x4e);
        /// <summary>
        /// MP4 file container. 
        /// <para/>
        /// This specifies the container type of an encoded file. See <see cref="MF_TRANSCODE_CONTAINERTYPE"/>.
        /// </summary>
        public static readonly Guid MFTranscodeContainerType_MPEG2 = new Guid(0xbfc2dbf9, 0x7bb4, 0x4f8f, 0xaf, 0xde, 0xe1, 0x12, 0xc4, 0x4b, 0xa8, 0x82);

        /// <summary>
        /// Specifies the container type of an encoded file. The container types are supported by Media
        /// Foundation.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// <para/>
        /// Possible values for the container types provided by Media Foundation are described in the following
        /// table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>MFTranscodeContainerType_ASF</strong></term><description>ASF file container.</description></item>
        /// <item><term><strong>MFTranscodeContainerType_MPEG4</strong></term><description>MP4 file container.</description></item>
        /// <item><term><strong>MFTranscodeContainerType_MP3</strong></term><description>MP3 file container.</description></item>
        /// <item><term><strong>MFTranscodeContainerType_3GP</strong></term><description>3GP file container. </description></item>
        /// <item><term><strong>MFTranscodeContainerType_AC3</strong></term><description>AC3 file container. </description></item>
        /// <item><term><strong>MFTranscodeContainerType_ADTS</strong></term><description>ADTS file container. </description></item>
        /// <item><term><strong>MFTranscodeContainerType_MPEG2</strong></term><description>MPEG2 file container. </description></item>
        /// <item><term><strong>MFTranscodeContainerType_FMPEG4</strong></term><description>FMPEG4 file container. </description></item>
        /// </list>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetGUID"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetGUID"/>. 
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/97FD968A-6843-4695-AECE-02F9ACD618FD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/97FD968A-6843-4695-AECE-02F9ACD618FD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFTranscodeContainerType_WAVE = new Guid(0x64c3453c, 0x0f26, 0x4741, 0xbe, 0x63, 0x87, 0xbd, 0xf8, 0xbb, 0x93, 0x5b);
        /// <summary>
        /// Specifies the container type of an encoded file. The container types are supported by Media
        /// Foundation.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// <para/>
        /// Possible values for the container types provided by Media Foundation are described in the following
        /// table.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>MFTranscodeContainerType_ASF</strong></term><description>ASF file container.</description></item>
        /// <item><term><strong>MFTranscodeContainerType_MPEG4</strong></term><description>MP4 file container.</description></item>
        /// <item><term><strong>MFTranscodeContainerType_MP3</strong></term><description>MP3 file container.</description></item>
        /// <item><term><strong>MFTranscodeContainerType_3GP</strong></term><description>3GP file container. </description></item>
        /// <item><term><strong>MFTranscodeContainerType_AC3</strong></term><description>AC3 file container. </description></item>
        /// <item><term><strong>MFTranscodeContainerType_ADTS</strong></term><description>ADTS file container. </description></item>
        /// <item><term><strong>MFTranscodeContainerType_MPEG2</strong></term><description>MPEG2 file container. </description></item>
        /// <item><term><strong>MFTranscodeContainerType_FMPEG4</strong></term><description>FMPEG4 file container. </description></item>
        /// </list>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetGUID"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetGUID"/>. 
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/97FD968A-6843-4695-AECE-02F9ACD618FD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/97FD968A-6843-4695-AECE-02F9ACD618FD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFTranscodeContainerType_AVI = new Guid(0x7edfe8af, 0x402f, 0x4d76, 0xa3, 0x3c, 0x61, 0x9f, 0xd1, 0x57, 0xd0, 0xf1);

        /// <summary>
        /// FMPEG4 file container. 
        /// <para/>
        /// This specifies the container type of an encoded file. See <see cref="MF_TRANSCODE_CONTAINERTYPE"/>.
        /// </summary>
        public static readonly Guid MFTranscodeContainerType_FMPEG4 = new Guid(0x9ba876f1, 0x419f, 0x4b77, 0xa1, 0xe0, 0x35, 0x95, 0x9d, 0x9d, 0x40, 0x4);
        /// <summary>
        /// Disables frame-rate conversion in the <c>Video Processor MFT</c>. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/98AA7B3A-281C-427D-805E-5C4EE1EFAE21(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/98AA7B3A-281C-427D-805E-5C4EE1EFAE21(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_XVP_DISABLE_FRC = new Guid(0x2c0afa19, 0x7a97, 0x4d5a, 0x9e, 0xe8, 0x16, 0xd4, 0xfc, 0x51, 0x8d, 0x8c);
        /// <summary>
        /// This service GUID should be used to get direct access to a wrapped object. 
        /// For example: When an <see cref="IMFByteStream"/> is wrapped into a <c>IRandomAccessStream</c>,
        /// the wrapped <see cref="IMFByteStream"/> can be retrieved from the <c>IRandomAccessStream</c> using this service.
        /// </summary>
        public static readonly Guid MF_WRAPPED_OBJECT = new Guid(0x2b182c4c, 0xd6ac, 0x49f4, 0x89, 0x15, 0xf7, 0x18, 0x87, 0xdb, 0x70, 0xcd);
        /// <summary>
        /// Symbolic link for a audio capture source.
        /// <para/>
        /// Data type: <strong>STRING</strong>
        /// </summary>
        public static readonly Guid MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_AUDCAP_SYMBOLIC_LINK = new Guid(0x98d24b5e, 0x5930, 0x4614, 0xb5, 0xa1, 0xf6, 0x0, 0xf9, 0x35, 0x5a, 0x78);
        /// <summary>
        /// Specifies whether a stream on a video capture source is a still-image stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/52251A45-3603-41C7-A869-7F6319BD337F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/52251A45-3603-41C7-A869-7F6319BD337F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVICESTREAM_IMAGE_STREAM = new Guid(0xa7ffb865, 0xe7b2, 0x43b0, 0x9f, 0x6f, 0x9a, 0xf2, 0xa0, 0xe5, 0xf, 0xc0);
        /// <summary>
        /// Specifies whether the image stream on a video capture source is independent of the video stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>BOOL</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DC4ED612-593B-40BF-BB42-946149042D1F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DC4ED612-593B-40BF-BB42-946149042D1F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVICESTREAM_INDEPENDENT_IMAGE_STREAM = new Guid(0x3eeec7e, 0xd605, 0x4576, 0x8b, 0x29, 0x65, 0x80, 0xb4, 0x90, 0xd7, 0xd3);
        /// <summary>
        /// Specifies the kernel streaming (KS) identifier for a stream on a video capture device.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/03C48CBA-FAD0-4127-89E5-3F1874BF32DB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/03C48CBA-FAD0-4127-89E5-3F1874BF32DB(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVICESTREAM_STREAM_ID = new Guid(0x11bd5120, 0xd124, 0x446b, 0x88, 0xe6, 0x17, 0x6, 0x2, 0x57, 0xff, 0xf9);
        /// <summary>
        /// Represents the stream category.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// </summary>
        /// <remarks>
        /// This attribute represents the GUID that identifies the stream category defined in ksmedia.h. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/673FB138-574C-4A98-A88C-496F17B4E095(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/673FB138-574C-4A98-A88C-496F17B4E095(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVICESTREAM_STREAM_CATEGORY = new Guid(0x2939e7b8, 0xa62e, 0x4579, 0xb6, 0x74, 0xd4, 0x7, 0x3d, 0xfa, 0xbb, 0xba);
        /// <summary>
        /// Represents the Microsoft Media Foundation Transform (MFT) stream id of the stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2C2590DC-8031-400D-8D48-A61D46F14618(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2C2590DC-8031-400D-8D48-A61D46F14618(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVICESTREAM_TRANSFORM_STREAM_ID = new Guid(0xe63937b7, 0xdaaf, 0x4d49, 0x81, 0x5f, 0xd8, 0x26, 0xf8, 0xad, 0x31, 0xe7);
        /// <summary>
        /// Specifies the CLSID of a post-processing plug-in for a video capture device.
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
        /// <a href="http://msdn.microsoft.com/en-US/library/8F626FAA-C7B8-4DBA-BD65-7CE97CBF3A86(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8F626FAA-C7B8-4DBA-BD65-7CE97CBF3A86(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVICESTREAM_EXTENSION_PLUGIN_CLSID = new Guid(0x048e6558, 0x60c4, 0x4173, 0xbd, 0x5b, 0x6a, 0x3c, 0xa2, 0x89, 0x6a, 0xee);
        /// <summary>
        /// Represents a extension plugin connection point.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IUnkown</strong>
        /// </summary>
        /// <remarks>
        /// Represents a filter KSControl pointer.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AA95639E-8B20-4714-AFD3-1A492F13FF12(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AA95639E-8B20-4714-AFD3-1A492F13FF12(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVICESTREAM_EXTENSION_PLUGIN_CONNECTION_POINT = new Guid(0x37f9375c, 0xe664, 0x4ea4, 0xaa, 0xe4, 0xcb, 0x6d, 0x1d, 0xac, 0xa1, 0xf4);
        /// <summary>
        /// Specifies if the take photo trigger is encapsulated into the device source.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// Set this attribute to non-zero to encapsulate the take photo trigger into the device source. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E20AB303-A8C6-4CD1-B3DC-3FE5C5D95678(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E20AB303-A8C6-4CD1-B3DC-3FE5C5D95678(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVICESTREAM_TAKEPHOTO_TRIGGER = new Guid(0x1d180e34, 0x538c, 0x4fbb, 0xa7, 0x5a, 0x85, 0x9a, 0xf7, 0xd2, 0x61, 0xa6);
        /// <summary>
        /// Specifies the maximum number of frames that the video capture source will buffer for this stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5AB109D8-1033-4DD9-B267-E66BE82DCB16(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5AB109D8-1033-4DD9-B267-E66BE82DCB16(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MF_DEVICESTREAM_MAX_FRAME_BUFFERS = new Guid(0x1684cebe, 0x3175, 0x4985, 0x88, 0x2c, 0x0e, 0xfd, 0x3e, 0x8a, 0xc1, 0x1e);

        #endregion

#endif
    }
}
