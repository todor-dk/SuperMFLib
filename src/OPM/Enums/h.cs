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


    public enum h
    {
        OPM_PROTECTION_STANDARD_OTHER = unchecked((int)0x80000000),
        OPM_PROTECTION_STANDARD_NONE = 0,
        OPM_PROTECTION_STANDARD_IEC61880_525I = 0x1,
        OPM_PROTECTION_STANDARD_IEC61880_2_525I = 0x2,
        OPM_PROTECTION_STANDARD_IEC62375_625P = 0x4,
        OPM_PROTECTION_STANDARD_EIA608B_525 = 0x8,
        OPM_PROTECTION_STANDARD_EN300294_625I = 0x10,
        OPM_PROTECTION_STANDARD_CEA805A_TYPEA_525P = 0x20,
        OPM_PROTECTION_STANDARD_CEA805A_TYPEA_750P = 0x40,
        OPM_PROTECTION_STANDARD_CEA805A_TYPEA_1125I = 0x80,
        OPM_PROTECTION_STANDARD_CEA805A_TYPEB_525P = 0x100,
        OPM_PROTECTION_STANDARD_CEA805A_TYPEB_750P = 0x200,
        OPM_PROTECTION_STANDARD_CEA805A_TYPEB_1125I = 0x400,
        OPM_PROTECTION_STANDARD_ARIBTRB15_525I = 0x800,
        OPM_PROTECTION_STANDARD_ARIBTRB15_525P = 0x1000,
        OPM_PROTECTION_STANDARD_ARIBTRB15_750P = 0x2000,
        OPM_PROTECTION_STANDARD_ARIBTRB15_1125I = 0x4000
    }

#endif

}
