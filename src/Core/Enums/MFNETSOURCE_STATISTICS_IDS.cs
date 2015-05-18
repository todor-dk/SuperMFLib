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

namespace MediaFoundation.Core.Enums
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Defines statistics collected by the network source. The values in this enumeration define property
    /// identifiers (PIDs) for the <see cref="MFProperties.MFNETSOURCE_STATISTICS"/> property. 
    /// <para/>
    /// To retrieve statistics from the network source, call <see cref="IMFGetService.GetService"/> with
    /// the service identifier <strong>MFNETSOURCE_STATISTICS_SERVICE</strong> and the interface identifier
    /// IID_IPropertyStore. The retrieved pointer is an <strong>IPropertyStore</strong> pointer. To get the
    /// value of a network statistic, construct a <strong>PROPERTYKEY</strong> with <strong>fmtid</strong>
    /// equal to <strong>MFNETSOURCE_STATISTICS</strong> and <strong>pid</strong> equal to a value from
    /// this enumeration. Then call <strong>IPropertyStore::GetValue</strong> with the property key to
    /// retrieve the value of the statistic as a <c>PROPVARIANT</c>. 
    /// <para/>
    /// In the descriptions that follow, the data type and value-type tag for the <c>PROPVARIANT</c> are
    /// listed in parentheses. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/4956E003-7F52-40AF-8F6B-B1B73BA2A897(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4956E003-7F52-40AF-8F6B-B1B73BA2A897(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFNETSOURCE_STATISTICS_IDS")]
    internal enum MFNETSOURCE_STATISTICS_IDS
    {
        /// <summary>
        /// The number of packets received ( <strong>LONG</strong>, <strong>VT_I4</strong>). 
        /// </summary>
        RECVPACKETS_ID = 0,
        /// <summary>
        /// The number of packets lost ( <strong>LONG</strong>, <strong>VT_I4</strong>). 
        /// </summary>
        LOSTPACKETS_ID,
        /// <summary>
        /// The number of requests to resend packets ( <strong>LONG</strong>, <strong>VT_I4</strong>). 
        /// </summary>
        RESENDSREQUESTED_ID,
        /// <summary>
        /// The number of resent packets received ( <strong>LONG</strong>) ( <strong>VT_I4</strong>). 
        /// </summary>
        RESENDSRECEIVED_ID,
        /// <summary>
        /// The total number of packets recovered by error correction ( <strong>LONG</strong>, <strong>VT_I4
        /// </strong>). 
        /// </summary>
        RECOVEREDBYECCPACKETS_ID,
        /// <summary>
        /// The total number of packets recovered by retransmission ( <strong>LONG</strong>, <strong>VT_I4
        /// </strong>). 
        /// </summary>
        RECOVEREDBYRTXPACKETS_ID,
        /// <summary>
        /// The total number of packets returned to user, including recovered packets ( <strong>LONG</strong>, 
        /// <strong>VT_I4</strong>). 
        /// </summary>
        OUTPACKETS_ID,
        /// <summary>
        /// The 10-second average receiving rate ( <strong>LONG</strong>, <strong>VT_I4</strong>). 
        /// </summary>
        RECVRATE_ID,
        /// <summary>
        /// The average bandwidth of the clip ( <strong>LONG</strong>, <strong>VT_I4</strong>). 
        /// </summary>
        AVGBANDWIDTHBPS_ID,
        /// <summary>
        /// The total number of bytes received ( <strong>ULONGLONG</strong>, <strong>VT_UI8</strong>). 
        /// </summary>
        BYTESRECEIVED_ID,
        /// <summary>
        /// The type of control protocol used to receive the data ( <strong>LONG</strong>, <strong>VT_I4
        /// </strong>). The value is a member of the <see cref="MFNetSourceProtocolType"/> enumeration. 
        /// </summary>
        PROTOCOL_ID,
        /// <summary>
        /// The type of control protocol used to receive the data ( <strong>LONG</strong>, <strong>VT_I4
        /// </strong>). The value is a member of the <c>MFNETSOURCE_TRANSPORT_TYPE</c> enumeration. 
        /// </summary>
        TRANSPORT_ID,
        /// <summary>
        /// The status of cache for a media file or entry ( <strong>LONG</strong>, <strong>VT_I4</strong>). The
        /// value is a member of the <c>MFNETSOURCE_CACHE_STATE</c> enumeration. 
        /// </summary>
        CACHE_STATE_ID,
        /// <summary>
        /// The current link bandwidth, in bits per second ( <strong>LONG</strong>, <strong>VT_I4</strong>). 
        /// </summary>
        LINKBANDWIDTH_ID,
        /// <summary>
        /// The current bit rate of the content ( <strong>LONG</strong>, <strong>VT_I4</strong>). 
        /// </summary>
        CONTENTBITRATE_ID,
        /// <summary>
        /// The negotiated speed factor used in data transmission ( <strong>LONG</strong>, <strong>VT_I4
        /// </strong>). The sender transmits data at the rate of the speed factor multiplied by the bit rate of
        /// the content. 
        /// </summary>
        SPEEDFACTOR_ID,
        /// <summary>
        /// The playout buffer size, in milliseconds ( <strong>LONG</strong>, <strong>VT_I4</strong>). 
        /// </summary>
        BUFFERSIZE_ID,
        /// <summary>
        /// The percentage of the playout buffer filled during buffering. The value is an integer in the range
        /// 0–100. ( <strong>LONG</strong>, <strong>VT_I4</strong>). 
        /// </summary>
        BUFFERPROGRESS_ID,
        /// <summary>
        /// The number of ticks since the last bandwidth switch ( <strong>LONG</strong>, <strong>VT_I4</strong>
        /// ). 
        /// </summary>
        LASTBWSWITCHTS_ID,
        /// <summary>
        /// The start of the seekable range, in 100-nanosecond units ( <strong>ULONGLONG</strong>, <strong>
        /// VT_UI8</strong>). 
        /// </summary>
        SEEKRANGESTART_ID,
        /// <summary>
        /// The end of the seekable range, in 100-nanosecond units ( <strong>ULONGLONG</strong>, <strong>VT_UI8
        /// </strong>). 
        /// </summary>
        SEEKRANGEEND_ID,
        /// <summary>
        /// The number of times buffering has occurred, including the initial buffering ( <strong>LONG</strong>
        /// , <strong>VT_I4</strong>). 
        /// </summary>
        BUFFERINGCOUNT_ID,
        /// <summary>
        /// The number of packets that had incorrect signatures ( <strong>LONG</strong>, <strong>VT_I4</strong>
        /// ). 
        /// </summary>
        INCORRECTLYSIGNEDPACKETS_ID,
        /// <summary>
        /// Boolean value indicating whether the current session is signed ( <strong>VARIANT_BOOL</strong>, 
        /// <strong>VT_BOOL</strong>). 
        /// </summary>
        SIGNEDSESSION_ID,
        /// <summary>
        /// The current maximum bit rate of the content ( <strong>LONG</strong>, <strong>VT_I4</strong>). 
        /// </summary>
        MAXBITRATE_ID,
        /// <summary>
        /// The reception quality ( <strong>LONG</strong>, <strong>VT_I4</strong>). 
        /// </summary>
        RECEPTION_QUALITY_ID,
        /// <summary>
        /// The total number of recovered packets ( <strong>LONG</strong>, <strong>VT_I4</strong>). 
        /// </summary>
        RECOVEREDPACKETS_ID,
        /// <summary>
        /// Boolean value indicating whether the content has a variable bit rate ( <strong>VARIANT_BOOL
        /// </strong>, <strong>VT_BOOL</strong>). 
        /// </summary>
        VBR_ID,
        /// <summary>
        /// The percentage of the content that has been downloaded. The value is an integer in the range 0–100.
        /// ( <strong>LONG</strong>, <strong>VT_I4</strong>). 
        /// </summary>
        DOWNLOADPROGRESS_ID,
        /// <summary>
        /// The name of protocol when MFNETSOURCE_PROTOCOL_ID is MFNETSOURCE_UNDEFINED.
        /// Data type: STRING
        /// </summary>
        UNPREDEFINEDPROTOCOLNAME_ID
    }

#endif

}
