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

namespace MediaFoundation.Transform.Enums
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains flags for registering and enumeration Media Foundation transforms (MFTs).
    /// <para/>
    /// These flags are used in the following functions:
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BA39FB66-D8B6-49C1-8312-18EBDCB012C9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BA39FB66-D8B6-49C1-8312-18EBDCB012C9(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("_MFT_ENUM_FLAG")]
    internal enum MFT_EnumFlag
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0x00000000,
        /// <summary>
        /// The MFT performs synchronous data processing in software. 
        /// <para/>
        /// This flag does not apply to hardware transforms.
        /// </summary>
        SyncMFT = 0x00000001,   // Enumerates V1 MFTs. This is default.
        /// <summary>
        /// The MFT performs asynchronous data processing in software. See <c>Asynchronous MFTs</c>. 
        /// <para/>
        /// This flag does not apply to hardware transforms.
        /// </summary>
        AsyncMFT = 0x00000002,   // Enumerates only software async MFTs also known as V2 MFTs
        /// <summary>
        /// The MFT performs hardware-based data processing, using either the AVStream driver or a GPU-based
        /// proxy MFT. MFTs in this category always process data asynchronously. See <c>Hardware MFTs</c>. 
        /// <para/>
        /// <strong>Note</strong> This flag applies to video codecs and video processors that perform their
        /// work entirely in hardware. It does not apply to software decoders that use DirectX Video
        /// Acceleration to assist decoding. 
        /// </summary>
        Hardware = 0x00000004,   // Enumerates V2 hardware async MFTs
        /// <summary>
        /// The MFT that must be unlocked by the application before use. Unlocking is performed using the 
        /// <see cref="IMFFieldOfUseMFTUnlock"/> interface. For more information, see 
        /// <c>Field of Use Restrictions</c>. 
        /// <para/>
        /// This flag does not apply to hardware transforms.
        /// </summary>
        FieldOfUse = 0x00000008,   // Enumerates MFTs that require unlocking
        /// <summary>
        /// For enumeration, include MFTs that were registered in the caller's process. To register an MFT in
        /// the caller's process, call the either the <see cref="MFExtern.MFTRegisterLocal"/> or 
        /// <see cref="MFExtern.MFTRegisterLocalByCLSID"/> function. 
        /// <para/>
        /// This flag does not apply to hardware transforms.
        /// <para/>
        /// Do not set this flag in the <see cref="MFExtern.MFTRegister"/> function. 
        /// </summary>
        LocalMFT = 0x00000010,   // Enumerates Locally (in-process) registered MFTs
        /// <summary>
        /// The MFT is optimized for transcoding rather than playback.
        /// </summary>
        TranscodeOnly = 0x00000020,   // Enumerates decoder MFTs used by transcode only    
        /// <summary>
        /// For enumeration, sort and filter the results. For more information, see the Remarks section of 
        /// <see cref="MFExtern.MFTEnumEx"/>. 
        /// <para/>
        /// Do not set this flag in the <see cref="MFExtern.MFTRegister"/> function. 
        /// </summary>
        SortAndFilter = 0x00000040,   // Apply system local, do not use and preferred sorting and filtering
        /// <summary>
        /// Similar to <see cref="SortAndFilter"/>, but apply a local policy of: <c>MF_PLUGIN_CONTROL_POLICY_USE_APPROVED_PLUGINS</c>.
        /// </summary>
        SortAndFilterApprovedOnly = 0x000000C0,   // Similar to MFT_ENUM_FLAG_SORTANDFILTER, but apply a local policy of: MF_PLUGIN_CONTROL_POLICY_USE_APPROVED_PLUGINS
        /// <summary>
        /// Similar to <see cref="SortAndFilter"/>, but apply a local policy of: <c>MF_PLUGIN_CONTROL_POLICY_USE_WEB_PLUGINS</c>.
        /// </summary>
        SortAndFilterWebOnly = 0x00000140,   // Similar to MFT_ENUM_FLAG_SORTANDFILTER, but apply a local policy of: MF_PLUGIN_CONTROL_POLICY_USE_WEB_PLUGINS
        /// <summary>
        /// Bitwise <strong>OR</strong> of all the flags, excluding <strong>MFT_ENUM_FLAG_SORTANDFILTER
        /// </strong>. 
        /// <para/>
        /// Do not set this flag in the <see cref="MFExtern.MFTRegister"/> function. 
        /// </summary>
        All = 0x0000003F    // Enumerates all MFTs including SW and HW MFTs and applies filtering
    }

#endif

}
