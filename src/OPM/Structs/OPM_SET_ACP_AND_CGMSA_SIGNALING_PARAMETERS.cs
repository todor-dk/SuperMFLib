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
    /// Contains information for the <see cref="OPM.MFOpmStatusRequests.OPM_SET_ACP_AND_CGMSA_SIGNALING" />
    /// command in <c>Output Protection Manager</c> (OPM).
    /// <para />
    /// This command causes the driver to insert Wide Screen Signaling (WSS) codes or other data packets in
    /// the television signal, as required by some Analog Copy Protection (ACP) and Copy Generation
    /// Management System — Analog (CGMS-A) specifications. For example:
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _OPM_SET_ACP_AND_CGMSA_SIGNALING_PARAMETERS {
    ///   ULONG ulNewTVProtectionStandard;
    ///   ULONG ulAspectRatioChangeMask1;
    ///   ULONG ulAspectRatioData1;
    ///   ULONG ulAspectRatioChangeMask2;
    ///   ULONG ulAspectRatioData2;
    ///   ULONG ulAspectRatioChangeMask3;
    ///   ULONG ulAspectRatioData3;
    ///   ULONG ulReserved[4];
    ///   ULONG ulReserved2[4];
    ///   ULONG ulReserved3;
    /// } OPM_SET_ACP_AND_CGMSA_SIGNALING_PARAMETERS;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BB7CAEDD-CD9E-4B36-B1A1-A457DE44AFB1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BB7CAEDD-CD9E-4B36-B1A1-A457DE44AFB1(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public struct OPM_SET_ACP_AND_CGMSA_SIGNALING_PARAMETERS
    {
        /// <summary>
        /// Specifies the protection standard and format that is currently active. The value is a bitwise
        /// <strong>OR</strong> of <c>TV Protection Standard Flags</c>.
        /// </summary>
        public int ulNewTVProtectionStandard;
        /// <summary>
        /// A bitmask indicating which bits from <strong>ulAspectRatioData1</strong> to set in the signal.
        /// </summary>
        public int ulAspectRatioChangeMask1;
        /// <summary>
        /// Specifies the aspect ratio value to be set for the current protection standard. For EN 300 294, use
        /// the <see cref="OPM.OPM_IMAGE_ASPECT_RATIO_EN300294" /> enumeration.
        /// </summary>
        public int ulAspectRatioData1;
        /// <summary>
        /// A bitmask indicating which bits from <strong>ulAspectRatioData2</strong> to set in the signal.
        /// </summary>
        public int ulAspectRatioChangeMask2;
        /// <summary>
        /// An additional data element related to aspect ratio. The presence and meaning of this data depends
        /// on the protection standard. This field can be used to convey End and Q0 bits for EIA-608-B, or the
        /// active format description for CEA-805-A.
        /// </summary>
        public int ulAspectRatioData2;
        /// <summary>
        /// A bitmask indicating which bits from <strong>ulAspectRatioData3</strong> to set in the signal.
        /// </summary>
        public int ulAspectRatioChangeMask3;
        /// <summary>
        /// An additional data element related to aspect ratio for the current protection standard. The
        /// presence and meaning of this data depends on the protection standard.
        /// </summary>
        public int ulAspectRatioData3;
        /// <summary>
        /// Reserved for future use. Set the entire array to zero.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] ulReserved;
        /// <summary>
        /// Reserved for future use. Set the entire array to zero.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] ulReserved2;
        /// <summary>
        /// Reserved for future use. Set to zero.
        /// </summary>
        public int ulReserved3;
    }

#endif

}
