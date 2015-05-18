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

namespace MediaFoundation.dxvahd.Enums
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Specifies the output frame rates for an input stream, when using Microsoft DirectX Video
    /// Acceleration High Definition (DXVA-HD).
    /// <para/>
    /// This enumeration type is used in the <see cref="dxvahd.DXVAHD_STREAM_STATE_OUTPUT_RATE_DATA"/>
    /// structure. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F96184D8-C5C2-4767-899F-323935FA9E89(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F96184D8-C5C2-4767-899F-323935FA9E89(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("DXVAHD_OUTPUT_RATE")]
    internal enum DXVAHD_OUTPUT_RATE
    {
        /// <summary>
        /// The frame output is at the normal rate.
        /// <para/>
        /// For progressive input, every frame produces one output frame. For interlaced input, every frame
        /// (two fields) produces two progressive output frames.
        /// </summary>
        Normal = 0,
        /// <summary>
        /// The frame output is at half rate.
        /// <para/>
        /// For progressive input, every frame produces one output frame, just as with <strong>
        /// DXVAHD_OUTPUT_RATE_NORMAL</strong>. For interlaced input, every frame produces one progressive
        /// output frame. 
        /// </summary>
        Half = 1,
        /// <summary>
        /// Frame output is at a custom rate.
        /// <para/>
        /// Use this value for frame-rate conversion or inverse telecine. The exact rate is given in the 
        /// <strong>OutputRate</strong> member of the <see cref="dxvahd.DXVAHD_STREAM_STATE_OUTPUT_RATE_DATA"/>
        /// structure. To get the list of custom rates supported by the video processor, call the 
        /// <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorCustomRates"/> method. 
        /// </summary>
        Custom = 2
    }

#endif

}
