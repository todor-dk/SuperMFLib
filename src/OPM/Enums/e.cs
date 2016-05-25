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

// <summary>
// The OPM namespace contains types regarding the Output Protection Manager.
// <para/>
// Output Protection Manager (OPM) enables an application to protect video content
// as it travels over a physical connector to a display device.
// </summary>
namespace MediaFoundation.OPM.Enums
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// OPM Bus Type Flags
    /// <para/>
    /// The flags listed in the following table specify the type of I/O bus used by the graphics adapter.
    /// <para/>
    /// </summary>
    /// <remarks>
    /// Up to three flags can be set, using a bitwise <strong>OR</strong>. Flags in the range 0x00 through
    /// 0x04 ( <strong>OPM_BUS_TYPE_Xxx</strong>) give the basic bus type. Flags in the range 0x10000
    /// through 0x50000 ( <strong>OPM_BUS_IMPLEMENTATION_MODIFIER_Xxx</strong>) modify the basic
    /// description. The driver sets one bus-type flag, and can optionally set up to one modifier flag. In
    /// addition, the driver can optionally set the <strong>OPM_BUS_IMPLEMENTATION_MODIFIER_NON_STANDARD
    /// </strong> flag. 
    /// <para/>
    /// In COPP emulation mode, the driver does not use the modifier flags, but it might set the <strong>
    /// OPM_COPP_COMPATIBLE_BUS_TYPE_INTEGRATED</strong> flag. 
    /// <para/>
    /// The OPM_BUG_TYPE_Xxxx flags and the <strong>OPM_COPP_COMPATIBLE_BUS_TYPE_INTEGRATED</strong> flag
    /// are equivalent to values from the <c>COPP_BusType</c> enumeration used in Certified Output
    /// Protection Protocol (COPP). 
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6C8EC020-5F12-453B-BBEB-3BAABB1CA213(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6C8EC020-5F12-453B-BBEB-3BAABB1CA213(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    internal enum e
    {
        /// <summary>
        /// Indicates a type of bus other than the types listed here.
        /// </summary>
        OPM_BUS_TYPE_OTHER = 0,
        /// <summary>
        /// PCI bus.
        /// </summary>
        OPM_BUS_TYPE_PCI = 0x1,
        /// <summary>
        /// PCI-X bus.
        /// </summary>
        OPM_BUS_TYPE_PCIX = 0x2,
        /// <summary>
        /// PCI Express bus.
        /// </summary>
        OPM_BUS_TYPE_PCIEXPRESS = 0x3,
        /// <summary>
        /// Accelerated Graphics Port (AGP) bus.
        /// </summary>
        OPM_BUS_TYPE_AGP = 0x4,
        /// <summary>
        /// The implementation for the graphics adapter is in a motherboard chipset's north bridge. 
        /// This flag implies that data never goes over an expansion bus (such as PCI or AGP) when 
        /// it is transferred from main memory to the graphics adapter. 
        /// </summary>
        OPM_BUS_IMPLEMENTATION_MODIFIER_INSIDE_OF_CHIPSET = 0x10000,
        /// <summary>
        /// The graphics adapter is connected to a motherboard chipset's north bridge by tracks on the motherboard, 
        /// and all of the graphics adapter's chips (integrated circuits) are soldered to the motherboard. 
        /// </summary>
        OPM_BUS_IMPLEMENTATION_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_CHIP = 0x20000,
        /// <summary>
        /// The graphics adapter is connected to a motherboard chipset's north bridge by tracks on the motherboard, 
        /// and all of the graphics adapter's chips are connected through sockets to the motherboard.
        /// </summary>
        OPM_BUS_IMPLEMENTATION_MODIFIER_TRACKS_ON_MOTHER_BOARD_TO_SOCKET = 0x30000,
        /// <summary>
        /// The graphics adapter is connected to the motherboard through a daughterboard connector.
        /// </summary>
        OPM_BUS_IMPLEMENTATION_MODIFIER_DAUGHTER_BOARD_CONNECTOR = 0x40000,
        /// <summary>
        /// The graphics adapter is connected to the motherboard through a daughterboard connector, 
        /// and the graphics adapter is inside an enclosure that is not user accessible.
        /// </summary>
        OPM_BUS_IMPLEMENTATION_MODIFIER_DAUGHTER_BOARD_CONNECTOR_INSIDE_OF_NUAE = 0x50000,
        /// <summary>
        /// Nonstandard modifier. (Optional.)
        /// </summary>
        OPM_BUS_IMPLEMENTATION_MODIFIER_NON_STANDARD = unchecked((int)0x80000000),
        /// <summary>
        /// Integrated bus. This flag is used only in COPP emulation mode. 
        /// It indicates that the command and status signals between the graphics adapter and other subsystems 
        /// on the computer are not available on an expansion bus that has a public specification and 
        /// standard connector type, unless it is a memory bus. This flag can be combined with an OPM_BUS_TYPE_Xxx flag.
        /// </summary>
        OPM_COPP_COMPATIBLE_BUS_TYPE_INTEGRATED = unchecked((int)0x80000000)
    }

#endif

}
