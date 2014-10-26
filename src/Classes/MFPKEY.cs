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
    /// Media Foundation Property Keys.
    /// </summary>
    public static class MFPKEY 
    {
        /// <summary>
        /// Contains the category GUID for a Media Foundation transform (MFT).
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>GUID</strong> ( <strong>CLSID</strong>*) </term><description>VT_CLSID</description><description><strong>puuid</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3C0948FC-42EA-4E43-A312-C98038020214(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3C0948FC-42EA-4E43-A312-C98038020214(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey CATEGORY = new PropertyKey(new Guid(0xc57a84c0, 0x1a80, 0x40a3, 0x97, 0xb5, 0x92, 0x72, 0xa4, 0x3, 0xc8, 0xae), 0x02);
        /// <summary>
        /// Contains the CLSID for a Media Foundation transform (MFT).
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>GUID</strong> ( <strong>CLSID</strong>*) </term><description>VT_CLSID</description><description><strong>puuid</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/ADB10FE8-760B-4AFF-A582-254E11BB76AF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ADB10FE8-760B-4AFF-A582-254E11BB76AF(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey CLSID = new PropertyKey(new Guid(0xc57a84c0, 0x1a80, 0x40a3, 0x97, 0xb5, 0x92, 0x72, 0xa4, 0x3, 0xc8, 0xae), 0x01);
        /// <summary>
        /// Specifies whether a Media Foundation transform (MFT) copies attributes from input samples to output
        /// samples.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>VARIANT_BOOL</strong></term><description>VT_BOOL</description><description><strong>boolVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/039ECB35-9AA9-4E8A-BBBC-042B9C4C874C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/039ECB35-9AA9-4E8A-BBBC-042B9C4C874C(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey EXATTRIBUTE_SUPPORTED = new PropertyKey(new Guid(0x456fe843, 0x3c87, 0x40c0, 0x94, 0x9d, 0x14, 0x9, 0xc9, 0x7d, 0xab, 0x2c), 0x01);
        /// <summary>
        /// Contains a pointer to the application's <see cref="IMFSourceOpenMonitor"/> interface. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>IUnknown</strong> pointer </term><description>VT_UNKNOWN</description><description><strong>punkVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5B94AE87-91FC-49D6-9355-83327CFDB3F3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5B94AE87-91FC-49D6-9355-83327CFDB3F3(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey SourceOpenMonitor = new PropertyKey(new Guid(0x074d4637, 0xb5ae, 0x465d, 0xaf, 0x17, 0x1a, 0x53, 0x8d, 0x28, 0x59, 0xdd), 0x02);
        /// <summary>
        /// Specifies whether the ASF media source uses approximate seeking. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>VARIANT_BOOL</strong></term><description>VT_BOOL</description><description><strong>boolVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/4877B67C-524C-4717-A90F-6DE21918D3D8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4877B67C-524C-4717-A90F-6DE21918D3D8(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey ASFMediaSource_ApproxSeek = new PropertyKey(new Guid(0xb4cd270f, 0x244d, 0x4969, 0xbb, 0x92, 0x3f, 0x0f, 0xb8, 0x31, 0x6f, 0x10), 0x01);
        /// <summary>
        /// Audio Multichannel.
        /// </summary>
        public static readonly PropertyKey MULTICHANNEL_CHANNEL_MASK = new PropertyKey(new Guid(0x58bdaf8c, 0x3224, 0x4692, 0x86, 0xd0, 0x44, 0xd6, 0x5c, 0x5b, 0xf8, 0x2b), 0x01);
        /// <summary>
        /// Configures the ASF media source to use iterative seeking if the source file has no index.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>VARIANT_BOOL</strong></term><description>VT_BOOL</description><description><strong>boolVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/0DD6F202-CDBC-4A28-8907-5530A0A2141B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0DD6F202-CDBC-4A28-8907-5530A0A2141B(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey ASFMediaSource_IterativeSeekIfNoIndex = new PropertyKey(new Guid(0x170b65dc, 0x4a4e, 0x407a, 0xac, 0x22, 0x57, 0x7f, 0x50, 0xe4, 0xa3, 0x7c), 0x01);
        /// <summary>
        /// Sets the maximum number of search iterations the ASF media source will use when it performs
        /// iterative seeking.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>ULONG</strong></term><description>VT_UI4</description><description><strong>ulVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/5B596FAF-1217-424D-AE16-8C9EC6F31AF1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5B596FAF-1217-424D-AE16-8C9EC6F31AF1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey ASFMediaSource_IterativeSeek_Max_Count = new PropertyKey(new Guid(0x170b65dc, 0x4a4e, 0x407a, 0xac, 0x22, 0x57, 0x7f, 0x50, 0xe4, 0xa3, 0x7c), 0x02);
        /// <summary>
        /// Sets the tolerance, in milliseconds, that is used when the ASF media source performs iterative
        /// seeking.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>ULONG</strong></term><description>VT_UI4</description><description><strong>ulVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/3EE4410F-857C-4978-A308-87DECFBA0E2F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3EE4410F-857C-4978-A308-87DECFBA0E2F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey ASFMediaSource_IterativeSeek_Tolerance_In_MilliSecond = new PropertyKey(new Guid(0x170b65dc, 0x4a4e, 0x407a, 0xac, 0x22, 0x57, 0x7f, 0x50, 0xe4, 0xa3, 0x7c), 0x03);
        /// <summary>
        /// Contains the Digital Living Network Alliance (DLNA) profile identifier for a media source. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>wchar_t*</strong></term><description>VT_LPWSTR</description><description><strong>pwszVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/940ED0DF-0912-4C13-A490-0C6BE82C9743(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/940ED0DF-0912-4C13-A490-0C6BE82C9743(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey Content_DLNA_Profile_ID = new PropertyKey(new Guid(0xcfa31b45, 0x525d, 0x4998, 0xbb, 0x44, 0x3f, 0x7d, 0x81, 0x54, 0x2f, 0xa4), 0x01);
        /// <summary>
        /// Enables or disables read-ahead in a media source.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>VARIANT_BOOL</strong></term><description>VT_BOOL</description><description><strong>boolVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B2B8711F-BA63-4FBA-BB88-8D254135EB21(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B2B8711F-BA63-4FBA-BB88-8D254135EB21(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey MediaSource_DisableReadAhead = new PropertyKey(new Guid(0x26366c14, 0xc5bf, 0x4c76, 0x88, 0x7b, 0x9f, 0x17, 0x54, 0xdb, 0x5f, 0x9), 0x01);

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Contains the zero-based index of a media stream for an MFPlay event.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>ULONG</strong></term><description>VT_UI4</description><description><strong>ulVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/086FCB1E-F75A-4F38-9FE1-77D30F64BC89(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/086FCB1E-F75A-4F38-9FE1-77D30F64BC89(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [Obsolete("Applications should use the Media Session for playback.")]
        public static readonly PropertyKey MFP_PKEY_StreamIndex = new PropertyKey(new Guid(0xa7cf9740, 0xe8d9, 0x4a87, 0xbd, 0x8e, 0x29, 0x67, 0x0, 0x1f, 0xd3, 0xad), 0x00);

        /// <summary>
        /// <strong>Important</strong> Deprecated. This API may be removed from future releases of Windows.
        /// Applications should use the <c>Media Session</c> for playback. 
        /// <para/>
        /// Specifies which streams were connected successfully to a media sink.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term>Array of <strong>DWORD</strong> values ( <strong>CAUL</strong>) </term><description>VT_VECTOR | VT_UI4</description><description><strong>caul</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/B5E45BFC-D91D-41B8-AAA4-72B3A23D869E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B5E45BFC-D91D-41B8-AAA4-72B3A23D869E(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        [Obsolete("Applications should use the Media Session for playback.")]
        public static readonly PropertyKey MFP_PKEY_StreamRenderingResults = new PropertyKey(new Guid(0xa7cf9740, 0xe8d9, 0x4a87, 0xbd, 0x8e, 0x29, 0x67, 0x0, 0x1f, 0xd3, 0xad), 0x01);

        /// <summary>
        /// Sets the stream configuration for the WTV media source.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>INT</strong></term><description>VT_INT</description><description><strong>intVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/2181723A-C6E8-42BD-979C-5C26FE3986C4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2181723A-C6E8-42BD-979C-5C26FE3986C4(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey SBESourceMode = new PropertyKey(new Guid(0x3fae10bb, 0xf859, 0x4192, 0xb5, 0x62, 0x18, 0x68, 0xd3, 0xda, 0x3a, 0x02), 0x01);
        /// <summary>
        /// Sets a callback that creates the <c>PMP Media Session</c> during source resolution. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>IUnknown*</strong></term><description>VT_UNKNOWN</description><description><strong>punkVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/7277C5E0-BB91-4EEA-9529-64E66D179CDC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7277C5E0-BB91-4EEA-9529-64E66D179CDC(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey PMP_Creation_Callback = new PropertyKey(new Guid(0x28bb4de2, 0x26a2, 0x4870, 0xb7, 0x20, 0xd2, 0x6b, 0xbe, 0xb1, 0x49, 0x42), 0x01);
        /// <summary>
        /// Enables the Microsoft Media Foundation HTTP byte stream to use URL monikers (also called <em>Urlmon
        /// </em>). 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>VARIANT_BOOL</strong></term><description>VT_BOOL</description><description><strong>boolVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/8B7D2FF7-D8A8-49E9-8CED-D37853B97A8F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8B7D2FF7-D8A8-49E9-8CED-D37853B97A8F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey HTTP_ByteStream_Enable_Urlmon = new PropertyKey(new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92), 0x01);
        /// <summary>
        /// Sets the moniker binding flags for the Microsoft Media Foundation HTTP byte stream.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>ULONG</strong></term><description>VT_UI4</description><description><strong>ulVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/9426D235-65E1-40BA-94E9-CF0C49263E6F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9426D235-65E1-40BA-94E9-CF0C49263E6F(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey HTTP_ByteStream_Urlmon_Bind_Flags = new PropertyKey(new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92), 0x02);
        /// <summary>
        /// Sets the root security identifier for the Microsoft Media Foundation HTTP byte stream.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>CAUB</strong></term><description>VT_VECTOR | VT_UI1</description><description><strong>caub</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/DD2B9487-53B0-4753-8C47-4D6BFE113109(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DD2B9487-53B0-4753-8C47-4D6BFE113109(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey HTTP_ByteStream_Urlmon_Security_Id = new PropertyKey(new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92), 0x03);
        /// <summary>
        /// Sets a window for the Microsoft Media Foundation HTTP byte stream. The window is used to present
        /// information in the user interface during a bind operation. 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>IUnknown*</strong></term><description>VT_UNKNOWN</description><description><strong>punkVal</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/52761AC1-4974-4087-B5EE-A797F5BAD86D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/52761AC1-4974-4087-B5EE-A797F5BAD86D(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey HTTP_ByteStream_Urlmon_Window = new PropertyKey(new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92), 0x04);

        /// <summary>
        /// When MFPKEY_HTTP_ByteStream_Enable_Urlmon is turned on, this value specifies an
        /// implementation of IServiceProvider that can be used to obtain services for the urlmon protocol handler.
        /// <para/>
        /// TYPE: VT_UNKNOWN
        /// </summary>
        public static readonly PropertyKey HTTP_ByteStream_Urlmon_Callback_QueryService = new PropertyKey(new Guid(0xeda8afdf, 0xc171, 0x417f, 0x8d, 0x17, 0x2e, 0x09, 0x18, 0x30, 0x32, 0x92), 0x05);
        
        /// <summary>
        /// Specifies the media protection system to use for the content.
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/jj128337(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/jj128337(v=vs.85).aspx</a>
        /// </remarks>
        public static readonly PropertyKey MediaProtectionSystemId = new PropertyKey(new Guid(0x636b271d, 0xddc7, 0x49e9, 0xa6, 0xc6, 0x47, 0x38, 0x59, 0x62, 0xe5, 0xbd), 0x01);
        /// <summary>
        /// Specifies a BLOB that contains the context to use when initializing a media protection system's
        /// trusted input module.
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Data type</term><description>PROPVARIANT type (vt)</description><description>PROPVARIANT member</description></listheader>
        /// <item><term><strong>BLOB</strong></term><description>VT_BLOB</description><description><strong>blob</strong></description></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// The above documentation is © Microsoft Corporation. It is reproduced here 
        /// with the sole purpose to increase usability and add IntelliSense support.
        /// <para/>
        /// View the original documentation topic online: 
        /// <a href="http://msdn.microsoft.com/en-US/library/A1B1E088-72D3-4B5F-B868-64896AF04EF1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A1B1E088-72D3-4B5F-B868-64896AF04EF1(v=VS.85,d=hv.2).aspx</a>
        /// </remarks>
        public static readonly PropertyKey MediaProtectionSystemContext = new PropertyKey(new Guid(0x636b271d, 0xddc7, 0x49e9, 0xa6, 0xc6, 0x47, 0x38, 0x59, 0x62, 0xe5, 0xbd), 0x02);
    }

}
