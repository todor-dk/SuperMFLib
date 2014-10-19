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
    /// Contains the result from an <see cref="OPM.MFOpmStatusRequests.OPM_GET_ACP_AND_CGMSA_SIGNALING" />
    /// query.
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _OPM_ACP_AND_CGMSA_SIGNALING {
    ///   OPM_RANDOM_NUMBER rnRandomNumber;
    ///   ULONG             ulStatusFlags;
    ///   ULONG             ulAvailableTVProtectionStandards;
    ///   ULONG             ulActiveTVProtectionStandard;
    ///   ULONG             ulReserved;
    ///   ULONG             ulAspectRatioValidMask1;
    ///   ULONG             ulAspectRatioData1;
    ///   ULONG             ulAspectRatioValidMask2;
    ///   ULONG             ulAspectRatioData2;
    ///   ULONG             ulAspectRatioValidMask3;
    ///   ULONG             ulAspectRatioData3;
    ///   ULONG             ulReserved2[4];
    ///   ULONG             ulReserved3[4];
    /// } OPM_ACP_AND_CGMSA_SIGNALING;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7388BDD9-A8BC-45F4-8539-A175190FB3C3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7388BDD9-A8BC-45F4-8539-A175190FB3C3(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public struct OPM_ACP_AND_CGMSA_SIGNALING
    {
        /// <summary>
        /// An <see cref="OPM.OPM_RANDOM_NUMBER" /> structure. This structure contains the same 128-bit random
        /// number that the application sent to the driver in the <see cref="OPM.OPM_GET_INFO_PARAMETERS" /> or
        /// <see cref="OPM.OPM_COPP_COMPATIBLE_GET_INFO_PARAMETERS" /> structure.
        /// </summary>
        public OPM_RANDOM_NUMBER rnRandomNumber;
        /// <summary>
        /// A bitwise <strong>OR</strong> of <c>OPM Status Flags</c>.
        /// </summary>
        public int ulStatusFlags;
        /// <summary>
        /// A bitwise <strong>OR</strong> of zero or more <c>TV Protection Standard Flags</c>. The driver will
        /// return flags for all of the protection standards and resolutions that it supports, regardless of
        /// which are now active.
        /// </summary>
        public int ulAvailableTVProtectionStandards;
        /// <summary>
        /// One value from the <c>TV Protection Standard Flags</c>, indicating the protection standard that is
        /// currently active.
        /// </summary>
        public int ulActiveTVProtectionStandard;
        /// <summary>
        /// Reserved for future use. Set to zero.
        /// </summary>
        public int ulReserved;
        /// <summary>
        /// A bitmask indicating which bits of <strong>ulAspectRatioData1</strong> are valid.
        /// </summary>
        public int ulAspectRatioValidMask1;
        /// <summary>
        /// The current aspect ratio. For EN 300 294, the value is a member of the
        /// <see cref="OPM.OPM_IMAGE_ASPECT_RATIO_EN300294" /> enumeration.
        /// </summary>
        public int ulAspectRatioData1;
        /// <summary>
        /// A bitmask indicating which bits of <strong>ulAspectRatioData2</strong> are valid.
        /// </summary>
        public int ulAspectRatioValidMask2;
        /// <summary>
        /// An additional data element related to aspect ratio for the current protection standard. The
        /// presence and meaning of this data depends on the protection standard. This field can be used to
        /// convey End and Q0 bits for EIA-608-B, or the active format description for CEA-805-A.
        /// </summary>
        public int ulAspectRatioData2;
        /// <summary>
        /// A bitmask indicating which bits of <strong>ulAspectRatioData3</strong> are valid.
        /// </summary>
        public int ulAspectRatioValidMask3;
        /// <summary>
        /// An additional data element related to aspect ratio for the current protection standard. The
        /// presence and meaning of this data depends on the protection standard.
        /// </summary>
        public int ulAspectRatioData3;
        /// <summary>
        /// Reserved for future use. Fill this array with zeros.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] ulReserved2;
        /// <summary>
        /// Reserved for future use.Fill this array with zeros.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] ulReserved3;
    }

#endif

}
