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

    [UnmanagedName("MF_OPM_CGMSA_PROTECTION_LEVEL")]
    public enum MF_OPM_CGMSA_PROTECTION_LEVEL
    {
        Off = 0x00,
        CopyFreely = 0x01,
        CopyNoMore = 0x02,
        CopyOneGeneration = 0x03,
        CopyNever = 0x04,
        RedistributionControlRequired = 0x08,
    }

#endif
}
