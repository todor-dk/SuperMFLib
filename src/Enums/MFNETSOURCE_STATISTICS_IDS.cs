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

#if ALLOW_UNTESTED_INTERFACES


    [UnmanagedName("MFNETSOURCE_STATISTICS_IDS")]
    public enum MFNETSOURCE_STATISTICS_IDS
    {
        RECVPACKETS_ID = 0,
        LOSTPACKETS_ID,
        RESENDSREQUESTED_ID,
        RESENDSRECEIVED_ID,
        RECOVEREDBYECCPACKETS_ID,
        RECOVEREDBYRTXPACKETS_ID,
        OUTPACKETS_ID,
        RECVRATE_ID,
        AVGBANDWIDTHBPS_ID,
        BYTESRECEIVED_ID,
        PROTOCOL_ID,
        TRANSPORT_ID,
        CACHE_STATE_ID,
        LINKBANDWIDTH_ID,
        CONTENTBITRATE_ID,
        SPEEDFACTOR_ID,
        BUFFERSIZE_ID,
        BUFFERPROGRESS_ID,
        LASTBWSWITCHTS_ID,
        SEEKRANGESTART_ID,
        SEEKRANGEEND_ID,
        BUFFERINGCOUNT_ID,
        INCORRECTLYSIGNEDPACKETS_ID,
        SIGNEDSESSION_ID,
        MAXBITRATE_ID,
        RECEPTION_QUALITY_ID,
        RECOVEREDPACKETS_ID,
        VBR_ID,
        DOWNLOADPROGRESS_ID,
        UNPREDEFINEDPROTOCOLNAME_ID
    }

#endif

}
