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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.dxvahd
{

#if ALLOW_UNTESTED_INTERFACES


    [Flags, UnmanagedName("DXVAHD_ITELECINE_CAPS")]
    public enum DXVAHD_ITELECINE_CAPS
    {
        CAPS_32 = 0x1,
        CAPS_22 = 0x2,
        CAPS_2224 = 0x4,
        CAPS_2332 = 0x8,
        CAPS_32322 = 0x10,
        CAPS_55 = 0x20,
        CAPS_64 = 0x40,
        CAPS_87 = 0x80,
        CAPS_222222222223 = 0x100,
        CAPS_OTHER = unchecked((int)0x80000000)
    }

#endif

}
