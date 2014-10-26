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

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.Transform;
using System.Drawing;

namespace MediaFoundation.EVR
{


    /// <summary>
    /// The following flags define DirectX Video Acceleration (DXVA) filter settings..
    /// <para/>
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6514992E-8188-4D28-879C-547E9B340B28(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6514992E-8188-4D28-879C-547E9B340B28(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("Unnamed enum")]
    public enum DXVA2Filters
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// Luma noise filter, level.
        /// </summary>
        NoiseFilterLumaLevel = 1,
        /// <summary>
        /// Luma noise filter, threshold.
        /// </summary>
        NoiseFilterLumaThreshold = 2,
        /// <summary>
        /// Luma noise filter, radius.
        /// </summary>
        NoiseFilterLumaRadius = 3,
        /// <summary>
        /// Chroma noise filter, level.
        /// </summary>
        NoiseFilterChromaLevel = 4,
        /// <summary>
        /// Chroma noise filter, threshold.
        /// </summary>
        NoiseFilterChromaThreshold = 5,
        /// <summary>
        /// Chroma noise filter, radius.
        /// </summary>
        NoiseFilterChromaRadius = 6,
        /// <summary>
        /// Luma detail filter, level.
        /// </summary>
        DetailFilterLumaLevel = 7,
        /// <summary>
        /// Luma detail filter, threshold.
        /// </summary>
        DetailFilterLumaThreshold = 8,
        /// <summary>
        /// Luma detail filter, radius.
        /// </summary>
        DetailFilterLumaRadius = 9,
        /// <summary>
        /// Chroma detail filter, level.
        /// </summary>
        DetailFilterChromaLevel = 10,
        /// <summary>
        /// Chroma detail filter, threshold.
        /// </summary>
        DetailFilterChromaThreshold = 11,
        /// <summary>
        /// Chroma detail filter, radius.
        /// </summary>
        DetailFilterChromaRadius = 12
    }

}
