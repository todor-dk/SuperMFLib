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


    [UnmanagedName("DXVAHD_STREAM_STATE")]
    public enum DXVAHD_STREAM_STATE
    {
        D3DFormat = 0,
        FrameFormat = 1,
        InputColorSpace = 2,
        OutputRate = 3,
        SourceRect = 4,
        DestinationRect = 5,
        Alpha = 6,
        Palette = 7,
        LumaKey = 8,
        AspectRatio = 9,
        FilterBrightness = 100,
        FilterContrast = 101,
        FilterHue = 102,
        FilterSaturation = 103,
        FilterNoiseReduction = 104,
        FilterEdgeEnhancement = 105,
        FilterAnamorphicScaling = 106,
        Private = 1000
    }

#endif

}
