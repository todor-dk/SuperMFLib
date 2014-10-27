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
    /// Static class that contains constant GUIDs that are attributes keys used with the MF Media Engine.
    /// </summary>
    public static class MF_MEDIA_ENGINE
    {
        // MF_MEDIA_ENGINE_CALLBACK
        /// <summary>
        /// Contains a pointer to the callback interface for the Media Engine. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IMFMediaEngineNotify*</strong> stored as <strong>IUnknown*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUnknown"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUnknown"/>. 
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5FAEF29A-B978-410A-8F5B-EB6F7E35EE6D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5FAEF29A-B978-410A-8F5B-EB6F7E35EE6D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid CALLBACK = new Guid(0xc60381b8, 0x83a4, 0x41f8, 0xa3, 0xd0, 0xde, 0x05, 0x07, 0x68, 0x49, 0xa9);

        // MF_MEDIA_ENGINE_DXGI_MANAGER
        /// <summary>
        /// Sets the Microsoft DirectX Graphics Infrastructure (DXGI) Device Manager on the Media Engine.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IMFDXGIDeviceManager*</strong> stored as <strong>IUnknown*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUnknown"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUnknown"/>. 
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CB952492-0ACF-4501-BD8B-133E26FCE8F7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CB952492-0ACF-4501-BD8B-133E26FCE8F7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid DXGI_MANAGER = new Guid(0x065702da, 0x1094, 0x486d, 0x86, 0x17, 0xee, 0x7c, 0xc4, 0xee, 0x46, 0x48);

        // MF_MEDIA_ENGINE_EXTENSION
        /// <summary>
        /// Contains a pointer to the <see cref="IMFMediaEngineExtension"/> interface. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IMFMediaEngineExtension*</strong> stored as <strong>IUnknown*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUnknown"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUnknown"/>. 
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D2F3F41D-086A-4DEB-99D0-07574BC8F0D7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D2F3F41D-086A-4DEB-99D0-07574BC8F0D7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid EXTENSION = new Guid(0x3109fd46, 0x060d, 0x4b62, 0x8d, 0xcf, 0xfa, 0xff, 0x81, 0x13, 0x18, 0xd2);

        // MF_MEDIA_ENGINE_PLAYBACK_HWND
        /// <summary>
        /// Sets a handle to a video playback window for the Media Engine.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>HWND</strong> stored as <strong>UINT64</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUINT64"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUINT64"/>. 
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/63889D81-12C5-47C1-B52A-6358E68830C3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/63889D81-12C5-47C1-B52A-6358E68830C3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid PLAYBACK_HWND = new Guid(0xd988879b, 0x67c9, 0x4d92, 0xba, 0xa7, 0x6e, 0xad, 0xd4, 0x46, 0x03, 0x9d);

        // MF_MEDIA_ENGINE_OPM_HWND
        /// <summary>
        /// Specifies a window for the Media Engine to apply <c>Output Protection Manager</c> (OPM)
        /// protections. 
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>HWND</strong> stored as <strong>UINT64</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E5271D72-FE16-4D28-9BBA-1440C7CE0921(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E5271D72-FE16-4D28-9BBA-1440C7CE0921(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_HWND = new Guid(0xa0be8ee7, 0x0572, 0x4f2c, 0xa8, 0x01, 0x2a, 0x15, 0x1b, 0xd3, 0xe7, 0x26);

        // MF_MEDIA_ENGINE_PLAYBACK_VISUAL
        /// <summary>
        /// Sets a Microsoft DirectComposition visual as the playback region for the Media Engine.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IDCompositionVisual*</strong> stored as <strong>IUnknown*</strong>
        /// <para/>
        /// <strong>Get/set</strong>
        /// <para/>
        /// To get this attribute, call <see cref="IMFAttributes.GetUnknown"/>. 
        /// <para/>
        /// To set this attribute, call <see cref="IMFAttributes.SetUnknown"/>. 
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C381D28E-B7A1-4A1A-9F8D-42A4ABB1C633(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C381D28E-B7A1-4A1A-9F8D-42A4ABB1C633(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid PLAYBACK_VISUAL = new Guid(0x6debd26f, 0x6ab9, 0x4d7e, 0xb0, 0xee, 0xc6, 0x1a, 0x73, 0xff, 0xad, 0x15);

        // MF_MEDIA_ENGINE_COREWINDOW
        /// <summary>
        /// Core window.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>ICoreWindow*</strong> stored as <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B18E322C-7954-473D-81A2-F181FBA9BDAC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B18E322C-7954-473D-81A2-F181FBA9BDAC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid COREWINDOW = new Guid(0xfccae4dc, 0x0b7f, 0x41c2, 0x9f, 0x96, 0x46, 0x59, 0x94, 0x8a, 0xcd, 0xdc);

        // MF_MEDIA_ENGINE_VIDEO_OUTPUT_FORMAT
        /// <summary>
        /// Sets the render-target format for the Media Engine.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>DXGI_FORMAT</strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/70FFDD44-9FDE-4D86-AD65-60019AC4A2BC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/70FFDD44-9FDE-4D86-AD65-60019AC4A2BC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid VIDEO_OUTPUT_FORMAT = new Guid(0x5066893c, 0x8cf9, 0x42bc, 0x8b, 0x8a, 0x47, 0x22, 0x12, 0xe5, 0x27, 0x26);

        // MF_MEDIA_ENGINE_CONTENT_PROTECTION_FLAGS
        /// <summary>
        /// Specifies whether the Media Engine will play protected content.
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
        /// <a href="http://msdn.microsoft.com/en-US/library/2A593499-BF40-440E-AF1D-3B0E7732489A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2A593499-BF40-440E-AF1D-3B0E7732489A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid CONTENT_PROTECTION_FLAGS = new Guid(0xe0350223, 0x5aaf, 0x4d76, 0xa7, 0xc3, 0x06, 0xde, 0x70, 0x89, 0x4d, 0xb4);

        // MF_MEDIA_ENGINE_CONTENT_PROTECTION_MANAGER
        /// <summary>
        /// Enables the Media Engine to play protected content.
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
        /// <a href="http://msdn.microsoft.com/en-US/library/F6F17EC7-6553-4127-B691-C20C945DD4D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F6F17EC7-6553-4127-B691-C20C945DD4D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid CONTENT_PROTECTION_MANAGER = new Guid(0xfdd6dfaa, 0xbd85, 0x4af3, 0x9e, 0x0f, 0xa0, 0x1d, 0x53, 0x9d, 0x87, 0x6a);

        // MF_MEDIA_ENGINE_AUDIO_ENDPOINT_ROLE
        /// <summary>
        /// Specifies the device role for the audio stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong><c>ERole</c></strong> stored as <strong>UINT32</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E4B7660D-5F41-495A-B77D-94B7981F4C2C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E4B7660D-5F41-495A-B77D-94B7981F4C2C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid AUDIO_ENDPOINT_ROLE = new Guid(0xd2cb93d1, 0x116a, 0x44f2, 0x93, 0x85, 0xf7, 0xd0, 0xfd, 0xa2, 0xfb, 0x46);

        // MF_MEDIA_ENGINE_AUDIO_CATEGORY
        /// <summary>
        /// Specifies the category of the audio stream.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong><c>AUDIO_STREAM_CATEGORY</c></strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0F2DB9A7-64ED-4952-BCB3-F2B15BA37D2A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0F2DB9A7-64ED-4952-BCB3-F2B15BA37D2A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid AUDIO_CATEGORY = new Guid(0xc8d4c51d, 0x350e, 0x41f2, 0xba, 0x46, 0xfa, 0xeb, 0xbb, 0x08, 0x57, 0xf6);

        // MF_MEDIA_ENGINE_STREAM_CONTAINS_ALPHA_CHANNEL
        /// <summary>
        /// Specifies if the stream contains an alpha channel.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>VT_BOOL</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D2CD976F-1F07-4864-8CEC-1AA8E1D9ED45(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D2CD976F-1F07-4864-8CEC-1AA8E1D9ED45(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid STREAM_CONTAINS_ALPHA_CHANNEL = new Guid(0x5cbfaf44, 0xd2b2, 0x4cfb, 0x80, 0xa7, 0xd4, 0x29, 0xc7, 0x4c, 0x78, 0x9d);

        // MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE
        /// <summary>
        /// Specifies the browser compatibility mode.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>GUID</strong>
        /// <para/>
        /// Set MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE to one of the following values:
        /// <para/>
        /// <para>* <strong>MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE9</strong></para><para>* <strong>
        /// MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE10</strong></para>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9F850CDE-D862-4E72-8B55-5FAFDA43E399(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9F850CDE-D862-4E72-8B55-5FAFDA43E399(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid BROWSER_COMPATIBILITY_MODE = new Guid(0x4e0212e2, 0xe18f, 0x41e1, 0x95, 0xe5, 0xc0, 0xe7, 0xe9, 0x23, 0x5b, 0xc3);


        /// <summary>
        /// Specifies the browser compatibility mode IE9.
        /// <para/>
        /// 	<strong>Data type</strong>
        /// 	<para/>
        /// 	<strong>GUID</strong>
        /// 	<para/>
        /// Set MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE to one of the following values:
        /// <para/>
        /// 	<para>* <strong>MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE9</strong></para><para>* <strong>
        /// MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE10</strong></para>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9F850CDE-D862-4E72-8B55-5FAFDA43E399(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9F850CDE-D862-4E72-8B55-5FAFDA43E399(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid BROWSER_COMPATIBILITY_MODE_IE9 = new Guid(0x052c2d39, 0x40c0, 0x4188, 0xab, 0x86, 0xf8, 0x28, 0x27, 0x3b, 0x75, 0x22);

        /// <summary>
        /// Specifies the browser compatibility mode IE10.
        /// <para/>
        /// 	<strong>Data type</strong>
        /// 	<para/>
        /// 	<strong>GUID</strong>
        /// 	<para/>
        /// Set MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE to one of the following values:
        /// <para/>
        /// 	<para>* <strong>MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE9</strong></para><para>* <strong>
        /// MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE10</strong></para>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9F850CDE-D862-4E72-8B55-5FAFDA43E399(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9F850CDE-D862-4E72-8B55-5FAFDA43E399(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid BROWSER_COMPATIBILITY_MODE_IE10 = new Guid(0x11a47afd, 0x6589, 0x4124, 0xb3, 0x12, 0x61, 0x58, 0xec, 0x51, 0x7f, 0xc3);

        /// <summary>
        /// Specifies the browser compatibility mode IE11.
        /// <para/>
        /// 	<strong>Data type</strong>
        /// 	<para/>
        /// 	<strong>GUID</strong>
        /// 	<para/>
        /// Set MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE to one of the following values:
        /// <para/>
        /// 	<para>* <strong>MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE9</strong></para><para>* <strong>
        /// MF_MEDIA_ENGINE_BROWSER_COMPATIBILITY_MODE_IE10</strong></para>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9F850CDE-D862-4E72-8B55-5FAFDA43E399(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9F850CDE-D862-4E72-8B55-5FAFDA43E399(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid BROWSER_COMPATIBILITY_MODE_IE11 = new Guid(0x1cf1315f, 0xce3f, 0x4035, 0x93, 0x91, 0x16, 0x14, 0x2f, 0x77, 0x51, 0x89);


        // MF_MEDIA_ENGINE_SOURCE_RESOLVER_CONFIG_STORE
        /// <summary>
        /// Gets the source resolver config store.
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
        /// <a href="http://msdn.microsoft.com/en-US/library/112B9CC2-DC0E-4AA4-978F-604ACD807E9D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/112B9CC2-DC0E-4AA4-978F-604ACD807E9D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid SOURCE_RESOLVER_CONFIG_STORE = new Guid(0x0ac0c497, 0xb3c4, 0x48c9, 0x9c, 0xde, 0xbb, 0x8c, 0xa2, 0x44, 0x2c, 0xa3);

        // MF_MEDIA_ENGINE_NEEDKEY_CALLBACK
        /// <summary>
        /// Attribute which is passed in the <see cref="IMFMediaEngineNeedKeyNotify"/> to the media engine on creation.
        /// <para/>
        /// <strong>Data type</strong>
        /// <para/>
        /// <strong>IMFMediaEngineNeedKeyNotify*</strong> stored as <strong>IUnknown*</strong>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302189(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302189(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid NEEDKEY_CALLBACK = new Guid(0x7ea80843, 0xb6e4, 0x432c, 0x8e, 0xa4, 0x78, 0x48, 0xff, 0xe4, 0x22, 0x0e);

        // MF_MEDIA_ENGINE_TRACK_ID
        /// <summary>
        /// Specifies the track id.
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn449735(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn449735(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid TRACK_ID = new Guid(0x65bea312, 0x4043, 0x4815, 0x8e, 0xab, 0x44, 0xdc, 0xe2, 0xef, 0x8f, 0x2a);
    }

}
