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
    /// Media Foundation Properties.
    /// </summary>
    public static class MFProperties
    {
        // Media Foundation Properties
        /// <summary>
        /// Duration of accelerated streaming for the network source, in milliseconds. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>DWORD</strong> (stored as <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_ACCELERATEDSTREAMINGDURATION</strong> defines the GUID for this
        /// property key. The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> object to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// This property applies to the Fast Start feature of Windows Media Services, which plays content
        /// quickly without waiting for lengthy initial buffering. When using Fast Start, the server running
        /// Windows Media Services will send some data at the beginning of the content at a faster rate than
        /// that specified by the bit rate of the content.
        /// <para/>
        /// The default value of this property is 10,000 milliseconds.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3F9CD762-F393-4130-BA25-D16DA0642093(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3F9CD762-F393-4130-BA25-D16DA0642093(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_ACCELERATEDSTREAMINGDURATION = new Guid(0x3cb1f277, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// The number of times the network source tries to reconnect to the server and resume streaming if the
        /// connection is lost. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>DWORD</strong> (stored as <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_AUTORECONNECTLIMIT</strong> defines the GUID for this property
        /// key. The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> object to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/185E15C6-910B-4E27-9087-CFE30A174194(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/185E15C6-910B-4E27-9087-CFE30A174194(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_AUTORECONNECTLIMIT = new Guid(0x3cb1f27a, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// The number of times the network source has attempted to reconnect to the network.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>DWORD</strong> (stored as <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_AUTORECONNECTPROGRESS</strong> defines the GUID for this property
        /// key. The property identifier (PID) is zero. 
        /// <para/>
        /// This property is read-only. To retrieve this property, query the network source for the <strong>
        /// IPropertyStore</strong> interface and call <strong>IPropertyStore::GetValue</strong>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E3410E68-6358-4F00-8039-833A4CCDF7FA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E3410E68-6358-4F00-8039-833A4CCDF7FA(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_AUTORECONNECTPROGRESS = new Guid(0x3cb1f282, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// The value of the first portion of the "cs(User-Agent)" field that the network source uses for
        /// logging. Applications can set this property to any string value. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Wide-character string ( <strong>WCHAR</strong>*) </term><description>VT_LPWSTR</description><description><strong>pwszVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_BROWSERUSERAGENT</strong> defines the GUID for this property key.
        /// The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B6C33CC8-FF43-4A19-A333-51A7F9B265A9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B6C33CC8-FF43-4A19-A333-51A7F9B265A9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_BROWSERUSERAGENT = new Guid(0x3cb1f28b, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// The value of the "cs(Referer)" field that the network source uses for logging. Applications can set
        /// this property to the URL of the webpage in which the application was embedded. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Wide-character string ( <strong>WCHAR</strong>*) </term><description>VT_LPWSTR</description><description><strong>pwszVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_BROWSERWEBPAGE</strong> defines the GUID for this property key.
        /// The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/328544B3-0D5F-4D1A-9AD1-AC38402D5898(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/328544B3-0D5F-4D1A-9AD1-AC38402D5898(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_BROWSERWEBPAGE = new Guid(0x3cb1f28c, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Number of seconds of data that the network source buffers at startup. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>DWORD</strong> (stored as <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_BUFFERINGTIME</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The default value of this property is 5 seconds.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/186B55FC-D1B1-4187-A748-EFAEE114ECA9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/186B55FC-D1B1-4187-A748-EFAEE114ECA9(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_BUFFERINGTIME = new Guid(0x3cb1f276, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies whether the network source caches content. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Boolean ( <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_CACHEENABLED</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The default value of this property is <strong>TRUE</strong>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/F9A36315-083C-4EBB-9D36-D55FC1F21621(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F9A36315-083C-4EBB-9D36-D55FC1F21621(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_CACHEENABLED = new Guid(0x3cb1f279, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies the link bandwidth for the network source, in bits per second. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>DWORD</strong> (stored as <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_CONNECTIONBANDWIDTH</strong> defines the GUID for this property
        /// key. The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/1B71DCE1-8744-4114-9629-2A9D0AFB7C43(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1B71DCE1-8744-4114-9629-2A9D0AFB7C43(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_CONNECTIONBANDWIDTH = new Guid(0x3cb1f278, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Contains a pointer to the <see cref="IMFNetCredentialManager"/> interface. Use this property to
        /// pass the application's implementation of <see cref="IMFNetCredentialManager"/> to the network
        /// source. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>IUnknown</strong> pointer </term><description>VT_UNKNOWN</description><description><strong>punkVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_CREDENTIAL_MANAGER</strong> defines the <strong>GUID</strong> for
        /// the property key. The property identifier (PID) is zero. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C0826956-9DF1-40EC-8AD1-9E0DCA34D847(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C0826956-9DF1-40EC-8AD1-9E0DCA34D847(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_CREDENTIAL_MANAGER = new Guid(0x3cb1f280, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Stores an array of bytes that represents the DRM license associated with the byte stream. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Byte array ( <strong>BLOB</strong>) </term><description>VT_BLOB</description><description><strong>blob</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_DRMNET_LICENSE_REPRESENTATION</strong> defines the GUID for this
        /// property key. The property identifier (PID) is zero. 
        /// <para/>
        /// This property is read-only. To get the property value from the network byte stream, call <strong>
        /// IPropertyStore::GetValue</strong> and pass the <strong>PROPERTYKEY</strong> structure in the <em>
        /// key</em> parameter. The <strong>fmtid</strong> member of <strong>PROPERTYKEY</strong> must be set
        /// to the property GUID. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/866A9706-0B0A-4675-AF61-5F55A5A69014(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/866A9706-0B0A-4675-AF61-5F55A5A69014(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_DRMNET_LICENSE_REPRESENTATION = new Guid(0x47eae1bd, 0xbdfe, 0x42e2, 0x82, 0xf3, 0x54, 0xa4, 0x8c, 0x17, 0x96, 0x2d);
        /// <summary>
        /// Specifies whether all download protocols are enabled. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Boolean ( <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_ENABLE_DOWNLOAD</strong> defines the GUID for this property key.
        /// The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C178693F-44EA-481E-B7F2-2EC94EEA1994(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C178693F-44EA-481E-B7F2-2EC94EEA1994(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_ENABLE_DOWNLOAD = new Guid(0x3cb1f29d, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies whether HTTP protocol is enabled in the network source. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Boolean ( <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_ENABLE_HTTP</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DCC4DB5C-0274-4A8A-89A4-66CDA62E1520(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DCC4DB5C-0274-4A8A-89A4-66CDA62E1520(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_ENABLE_HTTP = new Guid(0x3cb1f299, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies whether Real-Time Streaming Protocol (RTSP) transport is enabled in the network source. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Boolean ( <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_ENABLE_RTSP</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/299393D2-7949-48EF-A36D-19BB8760FC4E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/299393D2-7949-48EF-A36D-19BB8760FC4E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_ENABLE_RTSP = new Guid(0x3cb1f298, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies whether all streaming protocols are enabled. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Boolean ( <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_ENABLE_STREAMING</strong> defines the GUID for this property key.
        /// The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CF072572-58F7-429A-954A-8808D05248F0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CF072572-58F7-429A-954A-8808D05248F0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_ENABLE_STREAMING = new Guid(0x3cb1f29c, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies whether TCP transport is enabled for the network source. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Boolean ( <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_ACCELERATEDSTREAMINGDURATION</strong> defines the GUID for this
        /// property key. The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BA655505-DCAC-4CEA-8AD5-CCD1B55EE9D4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA655505-DCAC-4CEA-8AD5-CCD1B55EE9D4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_ENABLE_TCP = new Guid(0x3cb1f295, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies whether User Datagram Protocol (UDP) transport is enabled in the network source. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Boolean ( <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_ENABLE_UDP</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D46A59E6-8ABC-484B-AECC-EDF57FFFF512(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D46A59E6-8ABC-484B-AECC-EDF57FFFF512(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_ENABLE_UDP = new Guid(0x3cb1f294, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// The value of the "c-hostexe" field that the network source uses for logging. Applications can set
        /// this property to the name of the host application. For example, the value could be "iexplore.exe"
        /// if the application is hosted in a webpage. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Wide-character string ( <strong>WCHAR</strong>*) </term><description>VT_LPWSTR</description><description><strong>pwszVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_HOSTEXE</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/82A49719-B9B3-4868-BBCF-9E376F35D4C4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/82A49719-B9B3-4868-BBCF-9E376F35D4C4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_HOSTEXE = new Guid(0x3cb1f28f, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// The value of the "c-hostexever" field that the network source uses for logging. Applications can
        /// set this property to the version number of the host application. The host application is the .exe
        /// file identified by the c-hostexe field. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>LONGLONG</strong></term><description>VT_I8</description><description><strong>hVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_HOSTVERSION</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the Source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/EEE93457-483D-41DC-91C5-C12382D03152(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EEE93457-483D-41DC-91C5-C12382D03152(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_HOSTVERSION = new Guid(0x3cb1f291, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// List of URLs to which the network source will send logging information. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Array of wide-character strings ( <strong>CALPWSTR</strong>) </term><description>VT_VECTOR | VT_LPWSTR</description><description><strong>calpwstr</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_LOGURL</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/772C5B57-273D-4289-9229-EF7A199C6473(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/772C5B57-273D-4289-9229-EF7A199C6473(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_LOGURL = new Guid(0x3cb1f293, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Maximum amount of data the network source buffers, in milliseconds. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>DWORD</strong> (stored as <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_MAXBUFFERTIMEMS</strong> defines the GUID for this property key.
        /// The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The default value of this property is 40,000 milliseconds.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/BD776DC2-341A-4D87-8A06-8063DAF53EDE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BD776DC2-341A-4D87-8A06-8063DAF53EDE(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_MAXBUFFERTIMEMS = new Guid(0x408b24e6, 0x4038, 0x4401, 0xb5, 0xb2, 0xfe, 0x70, 0x1a, 0x9e, 0xbf, 0x10);
        /// <summary>
        /// Maximum duration of accelerated streaming, in milliseconds, when the network source uses UDP
        /// transport. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>DWORD</strong> (stored as <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_MAXUDPACCELERATEDSTREAMINGDURATION</strong> defines the GUID for
        /// this property key. The property identifier (PID) is zero. 
        /// <para/>
        /// For UDP transport, this property overrides the 
        /// <see cref="MFProperties.MFNETSOURCE_ACCELERATEDSTREAMINGDURATION"/> property if the value of this
        /// property is lower. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The default value of this property is 8,000 milliseconds.
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/D5F3064A-B222-4F72-B889-CD88C14A239C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D5F3064A-B222-4F72-B889-CD88C14A239C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_MAXUDPACCELERATEDSTREAMINGDURATION = new Guid(0x4aab2879, 0xbbe1, 0x4994, 0x9f, 0xf0, 0x54, 0x95, 0xbd, 0x25, 0x1, 0x29);
        /// <summary>
        /// The value of the "c-playerid" field that the network source uses for logging. Applications can set
        /// this property to any string value. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Wide-character string ( <strong>WCHAR</strong>*) </term><description>VT_LPWSTR</description><description><strong>pwszVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_PLAYERID</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DE52CC34-9B88-41AE-B8B8-EF5DFF85892C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DE52CC34-9B88-41AE-B8B8-EF5DFF85892C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PLAYERID = new Guid(0x3cb1f28e, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// The value of the second portion of the "cs(User-Agent)" field that the network source uses for
        /// logging. Applications can set this property to any string value. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Wide-character string ( <strong>WCHAR</strong>*) </term><description>VT_LPWSTR</description><description><strong>pwszVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_PLAYERUSERAGENT</strong> defines the GUID for this property key.
        /// The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/C662A6D6-5E0B-4C28-841D-5774D4103D4B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C662A6D6-5E0B-4C28-841D-5774D4103D4B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PLAYERUSERAGENT = new Guid(0x3cb1f292, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// The value of the "c-playerversion" field that the network source uses for logging. Applications can
        /// set this property to the version number of the application.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>LONGLONG</strong></term><description>VT_I8</description><description><strong>hVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_PLAYERVERSION</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Source Resolver</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7BC485DE-345B-475C-BBAE-0776AA63C93A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7BC485DE-345B-475C-BBAE-0776AA63C93A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PLAYERVERSION = new Guid(0x3cb1f28d, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies the packet-pair bandwidth and run-time bandwidth detected by the network source. The
        /// property value is a array of two values:
        /// <para/>
        /// <para>*  Packet-pair bandwidth, in bits per second. </para><para>*  Run-time bandwidth, in bits per
        /// second. </para>
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Array of <strong>ULONG</strong> values ( <strong>CAUL</strong>) </term><description>VT_VECTOR | VT_UI4</description><description><strong>caul</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_PPBANDWIDTH</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// This property is read-only. To retrieve this property, query the network source for the <strong>
        /// IPropertyStore</strong> interface and call <strong>IPropertyStore::GetValue</strong>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/430DE7FC-FE62-4B89-B3FC-7CD956E40892(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/430DE7FC-FE62-4B89-B3FC-7CD956E40892(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PPBANDWIDTH = new Guid(0x3cb1f281, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies the control protocol used by the network source. The value of this property is a member
        /// of the <see cref="MFNetSourceProtocolType"/> enumeration. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>LONG</strong></term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_PROTOCOL</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// This property is read-only. To retrieve this property, query the network source for the <strong>
        /// IPropertyStore</strong> interface and call <strong>IPropertyStore::GetValue</strong>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4DE8B8BA-97D9-4269-A16C-1853DC02F674(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4DE8B8BA-97D9-4269-A16C-1853DC02F674(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PROTOCOL = new Guid(0x3cb1f27d, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies whether the proxy locator should use a proxy server for local addresses. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Boolean ( <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_PROXYBYPASSFORLOCAL</strong> defines the GUID for this property
        /// key. The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the proxy locator when creating the proxy locator
        /// object. To set the property, pass an <strong>IPropertyStore</strong> pointer in the <em>
        /// pProxyConfig</em> parameter of the <see cref="MFExtern.MFCreateProxyLocator"/> function. The value
        /// must be set to 0 if the proxy server is to be used for local addresses; otherwise a nonzero value
        /// configures the default proxy locator to skip the proxy server for local addresses. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/384343F5-5919-44DA-B8EA-0C994B4743A8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/384343F5-5919-44DA-B8EA-0C994B4743A8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PROXYBYPASSFORLOCAL = new Guid(0x3cb1f286, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies a semicolon-delimited list of media servers that can accept connections from client
        /// applications without using a proxy server.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Wide-character string ( <strong>WCHAR</strong>*) </term><description>VT_LPWSTR</description><description><strong>pwszVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_PROXYEXCEPTIONLIST</strong> defines the GUID for this property
        /// key. The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the proxy locator when creating the proxy locator
        /// object. To set the property, pass an <strong>IPropertyStore</strong> pointer in the <em>
        /// pProxyConfig</em> parameter of the <see cref="MFExtern.MFCreateProxyLocator"/> function. The proxy
        /// locator does not perform proxy detection for these addresses. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/218883C5-9A26-4733-8308-1827CF1F2CD7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/218883C5-9A26-4733-8308-1827CF1F2CD7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PROXYEXCEPTIONLIST = new Guid(0x3cb1f285, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies the host name of the proxy server. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Wide-character string ( <strong>WCHAR</strong>*) </term><description>VT_LPWSTR</description><description><strong>pwszVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_PROXYHOSTNAME</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the default proxy locator when creating the proxy
        /// locator object. To set the property, pass an <strong>IPropertyStore</strong> pointer in the <em>
        /// pProxyConfig</em> parameter of the <see cref="MFExtern.MFCreateProxyLocator"/> function. This
        /// property must be set by the application when the proxy locator is configured to operate in the
        /// manual mode. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/E53C86E9-C326-41C9-AA86-C80A750B9CE3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E53C86E9-C326-41C9-AA86-C80A750B9CE3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PROXYHOSTNAME = new Guid(0x3cb1f284, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Stores the host name and the port of the proxy server used by the network source. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Wide-character string ( <strong>WCHAR</strong>*) </term><description>VT_LPWSTR</description><description><strong>pwszVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_PROXYINFO</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// This property is read-only. To get the property value from the network source, call <strong>
        /// IPropertyStore::GetValue</strong> and pass the <strong>PROPERTYKEY</strong> structure in the <em>
        /// key</em> parameter. The <strong>fmtid</strong> member of <strong>PROPERTYKEY</strong> must be set
        /// to the property GUID. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/164F8AC3-08CE-40A8-AC8D-4C2A267D9DB5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/164F8AC3-08CE-40A8-AC8D-4C2A267D9DB5(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PROXYINFO = new Guid(0x3cb1f29b, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Contains a pointer to the <see cref="IMFNetProxyLocatorFactory"/> interface. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>IUnknown</strong> pointer </term><description>VT_UNKNOWN</description><description><strong>punkVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_PROXYLOCATORFACTORY</strong> defines the GUID for this property
        /// key. The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to provide a custom proxy locator for the network source. To set
        /// the property, pass an <strong>IPropertyStore</strong> pointer to the source resolver. For more
        /// information, see <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/455325C0-5116-4E81-9729-FAB9C6A367C7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/455325C0-5116-4E81-9729-FAB9C6A367C7(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PROXYLOCATORFACTORY = new Guid(0x3cb1f283, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies the port number of the proxy server. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>DWORD</strong> (stored as <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_PROXYPORT</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the proxy locator when creating the proxy locator
        /// object. To set the property, pass an <strong>IPropertyStore</strong> pointer in the <em>
        /// pProxyConfig</em> parameter of the <see cref="MFExtern.MFCreateProxyLocator"/> function. If this
        /// property is not set for HTTP, then by default the proxy locator uses a value of 80. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/CD84911B-3658-489F-B454-23EDED0CBFA0(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CD84911B-3658-489F-B454-23EDED0CBFA0(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PROXYPORT = new Guid(0x3cb1f288, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies whether the default proxy locator should force proxy auto-detection. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Boolean ( <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_PROXYSETTINGS</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the proxy locator when creating the proxy locator
        /// object. To set the property, pass an <strong>IPropertyStore</strong> pointer in the <em>
        /// pProxyConfig</em> parameter of the <see cref="MFExtern.MFCreateProxyLocator"/> function. In
        /// auto-detect mode, the proxy locator uses the WinInet proxy detection mechanism. To force
        /// auto-detection, set the value to 0. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/AB547A92-94A2-482E-B7AC-AEB3FDFB6B91(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/AB547A92-94A2-482E-B7AC-AEB3FDFB6B91(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PROXYRERUNAUTODETECTION = new Guid(0x3cb1f289, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies the configuration setting for the default proxy locator. The value of this property is a
        /// member of the <c>MFNET_PROXYSETTINGS</c> enumeration. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>LONG</strong></term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_PROXYSETTINGS</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the proxy locator when creating the default proxy
        /// locator object. To set the property, pass an <strong>IPropertyStore</strong> pointer in the <em>
        /// pProxyConfig</em> parameter of the <see cref="MFExtern.MFCreateProxyLocator"/> function. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/85F2BD02-8A2F-46B5-B765-1A0BC5B6CCC3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/85F2BD02-8A2F-46B5-B765-1A0BC5B6CCC3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PROXYSETTINGS = new Guid(0x3cb1f287, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies whether the network source sends UDP resend requests in response to lost packets. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Boolean ( <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_RESENDSENABLED</strong> defines the GUID for this property key.
        /// The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The default value of this property is <strong>TRUE</strong>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7956536D-9F3D-4875-8006-17E2CD577B61(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7956536D-9F3D-4875-8006-17E2CD577B61(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_RESENDSENABLED = new Guid(0x3cb1f27b, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Contains network statistics for the network source.
        /// </summary>
        /// <remarks>
        /// Online documentation: <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms694864(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/ms694864(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_STATISTICS = new Guid(0x3cb1f274, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies whether stream switching is enabled on the network source. Stream switching enables the
        /// media server to change streams in a multiple bit-rate (MBR) file, based on available bandwidth.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Boolean ( <strong>LONG</strong>) </term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_THINNINGENABLED</strong> defines the GUID for this property key.
        /// The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The default value of this property is <strong>TRUE</strong>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/691A3549-EAF8-4E3D-AD0E-E5B013658F78(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/691A3549-EAF8-4E3D-AD0E-E5B013658F78(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_THINNINGENABLED = new Guid(0x3cb1f27c, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Specifies the transport protocol used by the network source. The value of this property is a member
        /// of the <c>MFNETSOURCE_TRANSPORT_TYPE</c> enumeration. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>LONG</strong></term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_TRANSPORT</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// This property is read-only. To retrieve this property, query the network source for the <strong>
        /// IPropertyStore</strong> interface and call <strong>IPropertyStore::GetValue</strong>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7C8598FF-F408-42D0-9EEE-3EF1E82F0466(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7C8598FF-F408-42D0-9EEE-3EF1E82F0466(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_TRANSPORT = new Guid(0x3cb1f27e, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// The range of valid UDP ports that the network source can use to receive streaming content. The
        /// value of this property is a string with the form " <em>m</em>– <em>n</em> " where <em>m</em> and 
        /// <em>n</em> are port numbers. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Wide-character string ( <strong>WCHAR</strong>*) </term><description>VT_LPWSTR</description><description><strong>pwszVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_UDP_PORT_RANGE</strong> defines the GUID for this property key.
        /// The property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/97FE2D11-70F7-4BAA-B49F-513D90146591(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/97FE2D11-70F7-4BAA-B49F-513D90146591(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_UDP_PORT_RANGE = new Guid(0x3cb1f29a, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);

        /// <summary>
        /// Stores the <strong>IUnknown</strong> pointer of the class that implements the 
        /// <see cref="IMFSSLCertificateManager"/> interface. The client implemention provides methods to get
        /// the client SSL certificate when it is requested by the server. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>IUnknown pointer</strong></term><description>VT_UNKNOWN</description><description><strong>punkVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The <strong>MFNETSOURCE_SSLCERTIFICATE_MANAGER</strong> constant defines the GUID for the property
        /// key. The property identifier (PID) is zero. To set this property on the network source, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/13E05BDA-96C2-4095-A266-74185760F33A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/13E05BDA-96C2-4095-A266-74185760F33A(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_SSLCERTIFICATE_MANAGER = new Guid(0x55e6cb27, 0xe69b, 0x4267, 0x94, 0x0c, 0x2d, 0x7e, 0xc5, 0xbb, 0x8a, 0x0f);

        /// <summary>
        /// Enables or disables  preview mode, which enables the application to overwrite the initial buffering
        /// logic.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>BOOL</strong></term><description>VT_BOOL</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_PREVIEWMODEENABLED</strong> defines the GUID for the property key.
        /// The property identifier (PID) is zero. This property is set on the network source by passing an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8AA8C6AC-8746-4BF6-9F57-B1426495A275(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8AA8C6AC-8746-4BF6-9F57-B1426495A275(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_PREVIEWMODEENABLED = new Guid(0x3cb1f27f, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Unique identifier by which the server identifies the client. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>GUID</strong></term><description>VT_CLSID</description><description><strong>puuid</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The <strong>MFNETSOURCE_CLIENTGUID</strong> constant defines the GUID for the property key. The
        /// property identifier (PID) is zero. To set this property on the network source, pass an <strong>
        /// IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// If not set or set as <strong>GUID_NULL</strong>, Microsoft Media Foundation generates an anonymous
        /// GUID per session that ensures the user's privacy. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/490A2B03-ABA8-4510-80C5-CA12F4037747(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/490A2B03-ABA8-4510-80C5-CA12F4037747(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_CLIENTGUID = new Guid(0x60a2c4a6, 0xf197, 0x4c14, 0xa5, 0xbf, 0x88, 0x83, 0xd, 0x24, 0x58, 0xaf);
        /// <summary>
        /// Specifies whether the Media Stream Broadcast (MSB) multicast protocol is enabled in the network
        /// source. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>LONG</strong></term><description>VT_I4</description><description><strong>lVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The constant <strong>MFNETSOURCE_ENABLE_MSB</strong> defines the GUID for this property key. The
        /// property identifier (PID) is zero. 
        /// <para/>
        /// Applications can use this property to configure the network source. To set the property, pass an 
        /// <strong>IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A46E3B4C-60BE-4470-B9DC-041902C2563C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A46E3B4C-60BE-4470-B9DC-041902C2563C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_ENABLE_MSB = new Guid(0x3cb1f296, 0x0505, 0x4c5d, 0xae, 0x71, 0x0a, 0x55, 0x63, 0x44, 0xef, 0xa1);
        /// <summary>
        /// Stores the string sent in the Accept-Language header.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>WCHAR*</strong></term><description>VT_LPWSTR</description><description><strong>pwszVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The MFNETSOURCE_STREAM_LANGUAGE constant defines the GUID for the property key. The property
        /// identifier (PID) is zero. To set this property on the network source, pass an <strong>
        /// IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B6AC613C-099B-4415-84AD-C0F8AD5F667B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B6AC613C-099B-4415-84AD-C0F8AD5F667B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_STREAM_LANGUAGE = new Guid(0x9ab44318, 0xf7cd, 0x4f2d, 0x8d, 0x6d, 0xfa, 0x35, 0xb4, 0x92, 0xce, 0xcb);
        /// <summary>
        /// Array of strings with the parameters to send to the log server.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>WCHAR*</strong></term><description>VT_LPWSTR</description><description><strong>pwszVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The <strong>MFNETSOURCE_LOGPARAMS</strong> constant defines the GUID for the property key. The
        /// property identifier (PID) is zero. To set this property on the network source, pass an <strong>
        /// IPropertyStore</strong> pointer to the source resolver. For more information, see 
        /// <c>Configuring a Media Source</c>. 
        /// <para/>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/36D711C7-A1FF-4EF2-B633-5F9F1662801E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/36D711C7-A1FF-4EF2-B633-5F9F1662801E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly Guid MFNETSOURCE_LOGPARAMS = new Guid(0x64936ae8, 0x9418, 0x453a, 0x8c, 0xda, 0x3e, 0xa, 0x66, 0x8b, 0x35, 0x3b);
    }
}
