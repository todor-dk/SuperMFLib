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


    public enum c
    {
        OPM_CONNECTOR_TYPE_OTHER = -1,
        OPM_CONNECTOR_TYPE_VGA = 0,
        OPM_CONNECTOR_TYPE_SVIDEO = 1,
        OPM_CONNECTOR_TYPE_COMPOSITE_VIDEO = 2,
        OPM_CONNECTOR_TYPE_COMPONENT_VIDEO = 3,
        OPM_CONNECTOR_TYPE_DVI = 4,
        OPM_CONNECTOR_TYPE_HDMI = 5,
        OPM_CONNECTOR_TYPE_LVDS = 6,
        OPM_CONNECTOR_TYPE_D_JPN = 8,
        OPM_CONNECTOR_TYPE_SDI = 9,
        OPM_CONNECTOR_TYPE_DISPLAYPORT_EXTERNAL = 10,
        OPM_CONNECTOR_TYPE_DISPLAYPORT_EMBEDDED = 11,
        OPM_CONNECTOR_TYPE_UDI_EXTERNAL = 12,
        OPM_CONNECTOR_TYPE_UDI_EMBEDDED = 13,
        OPM_COPP_COMPATIBLE_CONNECTOR_TYPE_INTERNAL = unchecked((int)0x80000000)
    }

#endif

}
