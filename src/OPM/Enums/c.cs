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
    /// OPM Connector Type Flags.
    /// <para/>
    /// The values in the following table specify the type of physical connector for a video output.
    /// <para/>
    /// </summary>
    /// <remarks>
    /// If a connector is described as <em>embedded</em> or <em>integrated</em>, it implies that the
    /// connector is internal. These connectors have "EMBEDDED" in the name of the enumeration constant. 
    /// <para/>
    /// Applications should ignore the <strong>OPM_COPP_COMPATIBLE_CONNECTOR_TYPE_INTERNAL</strong> flag
    /// and instead check for connector types with "EMBEDDED" in the constant name. 
    /// <para/>
    /// With the exception of <strong>OPM_COPP_COMPATIBLE_CONNECTOR_TYPE_INTERNAL</strong>, the values
    /// listed here are not bit flags, and cannot be combined. 
    /// <para/>
    /// Some of these values are equivalent to values from the <strong>COPP_ConnectorType</strong>
    /// enumeration used in Certified Output Protection Protocol (COPP). 
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/93E816FB-1B40-4865-9C0C-24D96C83FB7F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/93E816FB-1B40-4865-9C0C-24D96C83FB7F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public enum c
    {
        /// <summary>
        /// Indicates a type of physical connector that is not on this list.
        /// </summary>
        OPM_CONNECTOR_TYPE_OTHER = -1,
        /// <summary>
        /// Video Graphics Array (VGA) connector.
        /// </summary>
        OPM_CONNECTOR_TYPE_VGA = 0,
        /// <summary>
        /// S-Video connector.
        /// </summary>
        OPM_CONNECTOR_TYPE_SVIDEO = 1,
        /// <summary>
        /// Composite video connector.
        /// </summary>
        OPM_CONNECTOR_TYPE_COMPOSITE_VIDEO = 2,
        /// <summary>
        /// Component video connector.
        /// </summary>
        OPM_CONNECTOR_TYPE_COMPONENT_VIDEO = 3,
        /// <summary>
        /// Digital video interface (DVI) connector.
        /// </summary>
        OPM_CONNECTOR_TYPE_DVI = 4,
        /// <summary>
        /// High-definition multimedia interface (HDMI) connector.
        /// </summary>
        OPM_CONNECTOR_TYPE_HDMI = 5,
        /// <summary>
        /// Low voltage differential signaling (LVDS) connector or MIPI Digital Serial Interface (DSI).
        /// <para/>
        /// A connector using the LVDS or MIPI Digital Serial Interface (DSI) interface to 
        /// connect internally to a display device. The connection between the graphics adapter and 
        /// the display device is permanent, non-removable, and not accessible to the user. 
        /// Applications should not enable High-Bandwidth Digital Content Protection (HDCP) for this connector.
        /// </summary>
        OPM_CONNECTOR_TYPE_LVDS = 6,
        /// <summary>
        /// Japanese D connector. (A connector conforming to the EIAJ RC-5237 standard.)
        /// </summary>
        OPM_CONNECTOR_TYPE_D_JPN = 8,
        /// <summary>
        /// SDI (serial digital image) connector.
        /// </summary>
        OPM_CONNECTOR_TYPE_SDI = 9,
        /// <summary>
        /// A display port that connects externally to a display device.
        /// </summary>
        OPM_CONNECTOR_TYPE_DISPLAYPORT_EXTERNAL = 10,
        /// <summary>
        /// An embedded display port that connects internally to a display device. 
        /// Also known as an integrated display port.
        /// <para/>
        /// Applications should not enable High-Bandwidth Digital Content 
        /// Protection (HDCP) for embedded display ports.
        /// </summary>
        OPM_CONNECTOR_TYPE_DISPLAYPORT_EMBEDDED = 11,
        /// <summary>
        /// A Unified Display Interface (UDI) that connects externally to a display device.
        /// </summary>
        OPM_CONNECTOR_TYPE_UDI_EXTERNAL = 12,
        /// <summary>
        /// An embedded UDI that connects internally to a display device. Also known as an integrated UDI.
        /// </summary>
        OPM_CONNECTOR_TYPE_UDI_EMBEDDED = 13,
        /// <summary>
        /// Internal connector. The connection between the graphics adapter and the 
        /// display device is permanent and not accessible to the user. This flag is 
        /// used only in COPP emulation mode. It can be combined with the other values.
        /// </summary>
        OPM_COPP_COMPATIBLE_CONNECTOR_TYPE_INTERNAL = unchecked((int)0x80000000)
    }

#endif

}
