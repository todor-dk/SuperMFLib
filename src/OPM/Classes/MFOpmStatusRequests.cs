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

// This file is a mess.  While technically part of MF, I'm in no hurry 
// to try to get this to work.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MediaFoundation.OPM
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// This class contains the available status requests for Output Protection Manager (OPM). 
    /// To send an OPM status request, call <see cref="IOPMVideoOutput.GetInformation"/>. 
    /// </summary>
    public static class MFOpmStatusRequests
    {
        /// <summary>
        /// Returns the version number of the system renewability message (SRM) currently used by the video
        /// output.
        /// <para/>
        /// <list type="table">
        /// <item><term>Request GUID</term><description>OPM_GET_CURRENT_HDCP_SRM_VERSION</description></item>
        /// <item><term>Input data</term><description>None</description></item>
        /// <item><term>Return data</term><description> An <see cref="OPM.OPM_STANDARD_INFORMATION"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/65D4B98B-369F-4863-A28C-F9E3B4C2B55D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/65D4B98B-369F-4863-A28C-F9E3B4C2B55D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_GET_CURRENT_HDCP_SRM_VERSION = new Guid(0x99c5ceff, 0x5f1d, 0x4879, 0x81, 0xc1, 0xc5, 0x24, 0x43, 0xc9, 0x48, 0x2b);
        /// <summary>
        /// Gets information about a High-Bandwidth Digital Content Protection (HDCP) device attached to the
        /// video output. The following information is returned:
        /// <para/>
        /// <para>* The device's HDCP key selection vector (KSV).</para><para>* Whether the device is an HDCP
        /// repeater.</para>
        /// <para/>
        /// <list type="table">
        /// <item><term>Request GUID</term><description>OPM_GET_CONNECTED_HDCP_DEVICE_INFORMATION</description></item>
        /// <item><term>Input data</term><description>None</description></item>
        /// <item><term>Return data</term><description> An <see cref="OPM.OPM_CONNECTED_HDCP_DEVICE_INFORMATION"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/71FA9A99-83E4-4B27-9FD1-5A9DC3070820(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/71FA9A99-83E4-4B27-9FD1-5A9DC3070820(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_GET_CONNECTED_HDCP_DEVICE_INFORMATION = new Guid(0x0db59d74, 0xa992, 0x492e, 0xa0, 0xbd, 0xc2, 0x3f, 0xda, 0x56, 0x4e, 0x00);
        /// <summary>
        /// Returns the following information about a video output:
        /// <para/>
        /// <para>* A list of  television protection standards supported by the driver.</para><para>* The
        /// standard that is currently active.</para><para>* The current aspect ratio or other signaling data.
        /// </para>
        /// <para/>
        /// <list type="table">
        /// <item><term>Request GUID</term><description>OPM_GET_ACP_AND_CGMSA_SIGNALING</description></item>
        /// <item><term>Input data</term><description>None</description></item>
        /// <item><term>Return data</term><description> An <see cref="OPM.OPM_ACP_AND_CGMSA_SIGNALING"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D477FE3E-4498-450B-93B7-CE74AE9ED005(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D477FE3E-4498-450B-93B7-CE74AE9ED005(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_GET_ACP_AND_CGMSA_SIGNALING = new Guid(0x6629a591, 0x3b79, 0x4cf3, 0x92, 0x4a, 0x11, 0xe8, 0xe7, 0x81, 0x16, 0x71);
        /// <summary>
        /// Returns the physical connector type of the video output.
        /// <para/>
        /// <list type="table">
        /// <item><term>Request GUID</term><description>OPM_GET_CONNECTOR_TYPE</description></item>
        /// <item><term>Input data</term><description>None</description></item>
        /// <item><term>Return data</term><description> An <see cref="OPM.OPM_STANDARD_INFORMATION"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C5862758-0125-4DBE-AF72-5ED4A85BD702(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C5862758-0125-4DBE-AF72-5ED4A85BD702(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_GET_CONNECTOR_TYPE = new Guid(0x81d0bfd5, 0x6afe, 0x48c2, 0x99, 0xc0, 0x95, 0xa0, 0x8f, 0x97, 0xc5, 0xda);
        /// <summary>
        /// Returns the list of protection mechanisms that are supported by the connector.
        /// <para/>
        /// <list type="table">
        /// <item><term>Request GUID</term><description>OPM_GET_SUPPORTED_PROTECTION_TYPES</description></item>
        /// <item><term>Input data</term><description>None</description></item>
        /// <item><term>Return data</term><description> An <see cref="OPM.OPM_STANDARD_INFORMATION"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DD4CDD3C-6BB5-4427-827D-F3E909E752E5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DD4CDD3C-6BB5-4427-827D-F3E909E752E5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_GET_SUPPORTED_PROTECTION_TYPES = new Guid(0x38f2a801, 0x9a6c, 0x48bb, 0x91, 0x07, 0xb6, 0x69, 0x6e, 0x6f, 0x17, 0x97);
        /// <summary>
        /// Returns the virtual protection level for a specified protection mechanism. 
        /// <para/>
        /// The <em>virtual</em> protection level is the level requested by the application during the current
        /// Output Protection Manager (OPM) session. The driver might apply a higher level, due to events
        /// outside of this OPM session. To find the actual protection level that is in effect, send the 
        /// <see cref="OPM.MFOpmStatusRequests.OPM_GET_ACTUAL_PROTECTION_LEVEL"/> query. 
        /// <para/>
        /// <list type="table">
        /// <item><term>Request GUID</term><description>OPM_GET_VIRTUAL_PROTECTION_LEVEL</description></item>
        /// <item><term>Input data</term><description>The protection mechanism to query, specified as a 32-bit integer. The value is interpreted as a member of the <c>OPM Protection Type Flags</c>. </description></item>
        /// <item><term>Return data</term><description> An <see cref="OPM.OPM_STANDARD_INFORMATION"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/635D54DE-2735-4390-8BAC-BA63B9503909(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/635D54DE-2735-4390-8BAC-BA63B9503909(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_GET_VIRTUAL_PROTECTION_LEVEL = new Guid(0xb2075857, 0x3eda, 0x4d5d, 0x88, 0xdb, 0x74, 0x8f, 0x8c, 0x1a, 0x05, 0x49);
        /// <summary>
        /// Returns the global protection level for a specified protection mechanism.
        /// <para/>
        /// <list type="table">
        /// <item><term>Request GUID</term><description>OPM_GET_ACTUAL_PROTECTION_LEVEL</description></item>
        /// <item><term>Input data</term><description>The protection mechanism to query, specified as a 32-bit integer. The value is interpreted as a member of the <c>OPM Protection Type Flags</c>. </description></item>
        /// <item><term>Return data</term><description> An <see cref="OPM.OPM_STANDARD_INFORMATION"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3DD4F6F0-2305-4470-BBD4-7737FA2D8EAE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3DD4F6F0-2305-4470-BBD4-7737FA2D8EAE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_GET_ACTUAL_PROTECTION_LEVEL = new Guid(0x1957210a, 0x7766, 0x452a, 0xb9, 0x9a, 0xd2, 0x7a, 0xed, 0x54, 0xf0, 0x3a);
        /// <summary>
        /// Returns a description of the video signal that is being transmitted over the connector.
        /// <para/>
        /// <list type="table">
        /// <item><term>Request GUID</term><description>OPM_GET_ACTUAL_OUTPUT_FORMAT</description></item>
        /// <item><term>Input data</term><description>None</description></item>
        /// <item><term>Return data</term><description> An <see cref="OPM.OPM_ACTUAL_OUTPUT_FORMAT"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8464470F-49DB-4559-80B2-02CFC473E30E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8464470F-49DB-4559-80B2-02CFC473E30E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_GET_ACTUAL_OUTPUT_FORMAT = new Guid(0xd7bf1ba3, 0xad13, 0x4f8e, 0xaf, 0x98, 0x0d, 0xcb, 0x3c, 0xa2, 0x04, 0xcc);
        /// <summary>
        /// Returns the type of I/O bus used by the video output.
        /// <para/>
        /// <list type="table">
        /// <item><term>Request GUID</term><description>OPM_GET_ADAPTER_BUS_TYPE</description></item>
        /// <item><term>Input data</term><description>None</description></item>
        /// <item><term>Return data</term><description> An <see cref="OPM.OPM_STANDARD_INFORMATION"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1AFF4C81-FFA0-4116-B7EA-60B1B83042DF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1AFF4C81-FFA0-4116-B7EA-60B1B83042DF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_GET_ADAPTER_BUS_TYPE = new Guid(0xc6f4d673, 0x6174, 0x4184, 0x8e, 0x35, 0xf6, 0xdb, 0x52, 0x0, 0xbc, 0xba);
        /// <summary>
        /// Returns the unique identifier of the monitor associated with this video output.
        /// <para/>
        /// <list type="table">
        /// <item><term>Request GUID</term><description>OPM_GET_OUTPUT_ID</description></item>
        /// <item><term>Input data</term><description>None</description></item>
        /// <item><term>Return data</term><description>An <see cref="OPM.OPM_OUTPUT_ID_DATA"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D34D68FF-C513-483E-8619-4A9BAA2A40BA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D34D68FF-C513-483E-8619-4A9BAA2A40BA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_GET_OUTPUT_ID = new Guid(0x72cb6df3, 0x244f, 0x40ce, 0xb0, 0x9e, 0x20, 0x50, 0x6a, 0xf6, 0x30, 0x2f);
        /// <summary>
        /// Queries whether a digital video interface (DVI) connector supports DVI version 1.1 or later.
        /// <para/>
        /// <list type="table">
        /// <item><term>Request GUID</term><description>OPM_GET_DVI_CHARACTERISTICS</description></item>
        /// <item><term>Input data</term><description>None</description></item>
        /// <item><term>Return data</term><description> An <see cref="OPM.OPM_STANDARD_INFORMATION"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B6C450C0-E97F-472D-AE09-FA1E062AEB9E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B6C450C0-E97F-472D-AE09-FA1E062AEB9E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_GET_DVI_CHARACTERISTICS = new Guid(0xa470b3bb, 0x5dd7, 0x4172, 0x83, 0x9c, 0x3d, 0x37, 0x76, 0xe0, 0xeb, 0xf5);
        /// <summary>
        /// Gets the merit value of a hardware codec.
        /// <para/>
        /// <list type="table">
        /// <item><term>Request GUID</term><description><strong>OPM_GET_CODEC_INFO</strong></description></item>
        /// <item><term>Input data</term><description>An <see cref="OPM.OPM_GET_CODEC_INFO_PARAMETERS"/> structure </description></item>
        /// <item><term>Return data</term><description>An <see cref="OPM.OPM_GET_CODEC_INFO_INFORMATION"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/51987A79-78BF-41B2-8349-8C2725DD89D6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/51987A79-78BF-41B2-8349-8C2725DD89D6(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_GET_CODEC_INFO = new Guid(0x4f374491, 0x8f5f, 0x4445, 0x9d, 0xba, 0x95, 0x58, 0x8f, 0x6b, 0x58, 0xb4);
        /// <summary>
        /// Sets the protection level for an output protection mechanism.
        /// <para/>
        /// <list type="table">
        /// <item><term>Command GUID</term><description>OPM_SET_PROTECTION_LEVEL</description></item>
        /// <item><term>Input data</term><description> An <see cref="OPM.OPM_SET_PROTECTION_LEVEL_PARAMETERS"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F4E63BF5-0749-4054-9F86-7FD88F2881AD(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F4E63BF5-0749-4054-9F86-7FD88F2881AD(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_SET_PROTECTION_LEVEL = new Guid(0x9bb9327c, 0x4eb5, 0x4727, 0x9f, 0x00, 0xb4, 0x2b, 0x09, 0x19, 0xc0, 0xda);
        /// <summary>
        /// Specifies information about the video signal, other than the protection level.
        /// <para/>
        /// <list type="table">
        /// <item><term>Command GUID</term><description>OPM_SET_ACP_AND_CGMSA_SIGNALING</description></item>
        /// <item><term>Input data</term><description> An <see cref="OPM.OPM_SET_ACP_AND_CGMSA_SIGNALING_PARAMETERS"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/ED78B7EB-BF15-4068-AB86-AE42A5E62096(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ED78B7EB-BF15-4068-AB86-AE42A5E62096(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_SET_ACP_AND_CGMSA_SIGNALING = new Guid(0x09a631a5, 0xd684, 0x4c60, 0x8e, 0x4d, 0xd3, 0xbb, 0x0f, 0x0b, 0xe3, 0xee);
        /// <summary>
        /// Updates the system renewability message (SRM) for High-Bandwidth Digital Content Protection (HDCP).
        /// <para/>
        /// <list type="table">
        /// <item><term>Command GUID</term><description>OPM_SET_HDCP_SRM</description></item>
        /// <item><term>Input data</term><description>An <see cref="OPM.OPM_SET_HDCP_SRM_PARAMETERS"/> structure </description></item>
        /// </list>
        /// <para/>
        /// The <em>pbAdditionalParameters</em> parameter of <see cref="OPM.IOPMVideoOutput.Configure"/> must
        /// point to a buffer that contains the SRM. The format of an HDCP SRM is documented in the HDCP
        /// specification. Set the <em>ulAdditionalParametersSize</em> parameter equal to the size of the
        /// buffer, in bytes. 
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EA18BABA-0E03-4471-AF0E-A588773C98D2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EA18BABA-0E03-4471-AF0E-A588773C98D2(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_SET_HDCP_SRM = new Guid(0x8b5ef5d1, 0xc30d, 0x44ff, 0x84, 0xa5, 0xea, 0x71, 0xdc, 0xe7, 0x8f, 0x13);
        /// <summary>
        /// Sets the HDCP protection level for DVD playback, following DVD Content Scramble System (CSS) rules.
        /// <para/>
        /// <list type="table">
        /// <item><term>Command GUID</term><description>OPM_SET_PROTECTION_LEVEL_ACCORDING_TO_CSS_DVD</description></item>
        /// <item><term>Input data</term><description> An <see cref="OPM.OPM_SET_PROTECTION_LEVEL_PARAMETERS"/> structure </description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8D9ECB9B-8528-4B23-AB2F-234BA2CB7ED0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8D9ECB9B-8528-4B23-AB2F-234BA2CB7ED0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid OPM_SET_PROTECTION_LEVEL_ACCORDING_TO_CSS_DVD = new Guid(0x39ce333e, 0x4cc0, 0x44ae, 0xbf, 0xcc, 0xda, 0x50, 0xb5, 0xf8, 0x2e, 0x72);
    }

#endif

}
