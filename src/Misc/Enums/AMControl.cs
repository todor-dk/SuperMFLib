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

namespace MediaFoundation.Misc.Enums
{
#if NOT_IN_USE

    /// <summary>
    /// This enumeration contains options for the <see cref="VideoInfoHeader2.ControlFlags"/> field.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/5E3D5BF0-435F-45DA-8409-A1463B56A7AE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/5E3D5BF0-435F-45DA-8409-A1463B56A7AE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("From AMCONTROL_*"), Flags]
    internal enum AMControl
    {

        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// Indicates the dwControlFlags flags are used.
        /// </summary>
        Used = 0x00000001,
        /// <summary>
        /// The image should be padded and displayed in a 4 x 3 area.
        /// </summary>
        PadTo4x3 = 0x00000002,
        /// <summary>
        /// The image should be padded and displayed in a 16 x 9 area.
        /// </summary>
        PadTo16x9 = 0x00000004,
        /// <summary>
        /// Additional DXVA color information is contained in the upper 24 bits of the <see cref="VideoInfoHeader2.ControlFlags"/> field.
        /// </summary>
        ColorinfoPresent = 0x00000080
    }

#endif
}
