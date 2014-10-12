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
using System.Runtime.InteropServices;

using MediaFoundation.Misc;

namespace MediaFoundation.Transform
{

#if ALLOW_UNTESTED_INTERFACES


    [Flags, UnmanagedName("MFT_ENUM_FLAG")]
    public enum MFT_EnumFlag
    {
        None = 0x00000000,
        SyncMFT = 0x00000001,   // Enumerates V1 MFTs. This is default.
        AsyncMFT = 0x00000002,   // Enumerates only software async MFTs also known as V2 MFTs
        Hardware = 0x00000004,   // Enumerates V2 hardware async MFTs
        FieldOfUse = 0x00000008,   // Enumerates MFTs that require unlocking
        LocalMFT = 0x00000010,   // Enumerates Locally (in-process) registered MFTs
        TranscodeOnly = 0x00000020,   // Enumerates decoder MFTs used by transcode only    
        SortAndFilter = 0x00000040,   // Apply system local, do not use and preferred sorting and filtering
        SortAndFilterApprovedOnly = 0x000000C0,   // Similar to MFT_ENUM_FLAG_SORTANDFILTER, but apply a local policy of: MF_PLUGIN_CONTROL_POLICY_USE_APPROVED_PLUGINS
        SortAndFilterWebOnly = 0x00000140,   // Similar to MFT_ENUM_FLAG_SORTANDFILTER, but apply a local policy of: MF_PLUGIN_CONTROL_POLICY_USE_WEB_PLUGINS
        All = 0x0000003F    // Enumerates all MFTs including SW and HW MFTs and applies filtering
    }

#endif

}
