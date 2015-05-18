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

namespace MediaFoundation.OPM.Enums
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// TV Protection Standard Flags.
    /// <para/>
    /// The constants in this enumeration specify television standards and formats for Output Protection
    /// Manager (OPM).
    /// </summary>
    /// <remarks>
    /// These flags are numerically equivalent to the <strong>COPP_TVProtectionStandard</strong>
    /// enumeration used in Certified Output Protection Protocol (COPP). 
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8F26AA92-ED40-483E-AC78-C071619F0E12(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8F26AA92-ED40-483E-AC78-C071619F0E12(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    internal enum h
    {
        /// <summary>
        /// The protection standard is unknown.
        /// </summary>
        OPM_PROTECTION_STANDARD_OTHER = unchecked((int)0x80000000),
        /// <summary>
        /// No protection standard is in place.
        /// </summary>
        OPM_PROTECTION_STANDARD_NONE = 0,
        /// <summary>
        /// The protection standard is IEC 61880, 525i.
        /// </summary>
        OPM_PROTECTION_STANDARD_IEC61880_525I = 0x1,
        /// <summary>
        /// The protection standard is IEC 61880-2, 525i.
        /// </summary>
        OPM_PROTECTION_STANDARD_IEC61880_2_525I = 0x2,
        /// <summary>
        /// The protection standard is IEC 62375, 625p.
        /// </summary>
        OPM_PROTECTION_STANDARD_IEC62375_625P = 0x4,
        /// <summary>
        /// The protection standard is EIA/CEA-608-B, 525i.
        /// </summary>
        OPM_PROTECTION_STANDARD_EIA608B_525 = 0x8,
        /// <summary>
        /// The protection standard is ETSI EN 300 294, 625i.
        /// </summary>
        OPM_PROTECTION_STANDARD_EN300294_625I = 0x10,
        /// <summary>
        /// The protection standard is CEA-805-A Type A, 525p.
        /// </summary>
        OPM_PROTECTION_STANDARD_CEA805A_TYPEA_525P = 0x20,
        /// <summary>
        /// The protection standard is CEA-805-A Type A, 750p.
        /// </summary>
        OPM_PROTECTION_STANDARD_CEA805A_TYPEA_750P = 0x40,
        /// <summary>
        /// The protection standard is CEA-805-A Type A, 1125i.
        /// </summary>
        OPM_PROTECTION_STANDARD_CEA805A_TYPEA_1125I = 0x80,
        /// <summary>
        /// The protection standard is CEA-805-A Type B, 525p.
        /// </summary>
        OPM_PROTECTION_STANDARD_CEA805A_TYPEB_525P = 0x100,
        /// <summary>
        /// The protection standard is CEA-805-A Type B, 750p.
        /// </summary>
        OPM_PROTECTION_STANDARD_CEA805A_TYPEB_750P = 0x200,
        /// <summary>
        /// The protection standard is CEA-805-A Type B, 1125i.
        /// </summary>
        OPM_PROTECTION_STANDARD_CEA805A_TYPEB_1125I = 0x400,
        /// <summary>
        /// The protection standard is ARIB TR-B15, 525i.
        /// </summary>
        OPM_PROTECTION_STANDARD_ARIBTRB15_525I = 0x800,
        /// <summary>
        /// The protection standard is ARIB TR-B15, 525p.
        /// </summary>
        OPM_PROTECTION_STANDARD_ARIBTRB15_525P = 0x1000,
        /// <summary>
        /// The protection standard is ARIB TR-B15, 750p.
        /// </summary>
        OPM_PROTECTION_STANDARD_ARIBTRB15_750P = 0x2000,
        /// <summary>
        /// The protection standard is ARIB TR-B15, 1125i.
        /// </summary>
        OPM_PROTECTION_STANDARD_ARIBTRB15_1125I = 0x4000
    }

#endif

}
