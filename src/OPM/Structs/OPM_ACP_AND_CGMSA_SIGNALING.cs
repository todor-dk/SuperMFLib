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


    public struct OPM_ACP_AND_CGMSA_SIGNALING
    {
        public OPM_RANDOM_NUMBER rnRandomNumber;
        public int ulStatusFlags;
        public int ulAvailableTVProtectionStandards;
        public int ulActiveTVProtectionStandard;
        public int ulReserved;
        public int ulAspectRatioValidMask1;
        public int ulAspectRatioData1;
        public int ulAspectRatioValidMask2;
        public int ulAspectRatioData2;
        public int ulAspectRatioValidMask3;
        public int ulAspectRatioData3;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] ulReserved2;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public int[] ulReserved3;
    }

#endif

}
