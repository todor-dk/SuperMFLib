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

namespace MediaFoundation.Dxvahd.Enums
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Specifies the inverse telecine (IVTC) capabilities of a Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD) video processor.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/BF3E0D24-2671-4E79-9CFE-D776D8E5FB47(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/BF3E0D24-2671-4E79-9CFE-D776D8E5FB47(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("DXVAHD_ITELECINE_CAPS")]
    internal enum DXVAHD_ITELECINE_CAPS
    {
        /// <summary>
        /// The video processor can reverse 3:2 pulldown.
        /// </summary>
        CAPS_32 = 0x1,
        /// <summary>
        /// The video processor can reverse 2:2 pulldown.
        /// </summary>
        CAPS_22 = 0x2,
        /// <summary>
        /// The video processor can reverse 2:2:2:4 pulldown.
        /// </summary>
        CAPS_2224 = 0x4,
        /// <summary>
        /// The video processor can reverse 2:3:3:2 pulldown.
        /// </summary>
        CAPS_2332 = 0x8,
        /// <summary>
        /// The video processor can reverse 3:2:3:2:2 pulldown.
        /// </summary>
        CAPS_32322 = 0x10,
        /// <summary>
        /// The video processor can reverse 5:5 pulldown.
        /// </summary>
        CAPS_55 = 0x20,
        /// <summary>
        /// The video processor can reverse 6:4 pulldown.
        /// </summary>
        CAPS_64 = 0x40,
        /// <summary>
        /// The video processor can reverse 8:7 pulldown.
        /// </summary>
        CAPS_87 = 0x80,
        /// <summary>
        /// The video processor can reverse 2:2:2:2:2:2:2:2:2:2:2:3 pulldown.
        /// </summary>
        CAPS_222222222223 = 0x100,
        /// <summary>
        /// The video processor can reverse other telecine modes not listed here.
        /// </summary>
        CAPS_OTHER = unchecked((int)0x80000000)
    }

#endif

}
