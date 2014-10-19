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

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation
{


    /// <summary>
    /// Specifies whether color data includes headroom and toeroom. Headroom allows for values beyond 1.0
    /// white ("whiter than white"), and toeroom allows for values below reference 0.0 black ("blacker than
    /// black"). 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FE7547F8-84CD-461A-8D33-DBC0B90ADD37(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FE7547F8-84CD-461A-8D33-DBC0B90ADD37(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFNominalRange")]
    public enum MFNominalRange
    {
        /// <summary>
        /// Unknown nominal range. 
        /// </summary>
        MFNominalRange_Unknown = 0,
        /// <summary>
        /// Equivalent to MFNominalRange_0_255. 
        /// </summary>
        MFNominalRange_Normal = 1,
        /// <summary>
        /// Equivalent to MFNominalRange_16_235. 
        /// </summary>
        MFNominalRange_Wide = 2,

        /// <summary>
        /// The normalized range [0...1] maps to [0...255] for 8-bit samples or [0...1023] for 10-bit samples. 
        /// </summary>
        MFNominalRange_0_255 = 1,
        /// <summary>
        /// The normalized range [0...1] maps to [16...235] for 8-bit samples or [64...940] for 10-bit samples.
        /// </summary>
        MFNominalRange_16_235 = 2,
        /// <summary>
        /// The normalized range [0..1] maps to [48...208] for 8-bit samples or [64...940] for 10-bit samples. 
        /// </summary>
        MFNominalRange_48_208 = 3,
        /// <summary>
        /// The normalized range [0..1] maps to [64...127] for 8-bit samples or [256...508] for 10-bit samples.
        /// This range is used in the xRGB color space.
        /// <para/>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// </summary>
        MFNominalRange_64_127 = 4,


        MFNominalRange_Last,

        MFNominalRange_ForceDWORD = 0x7fffffff,
    }

}
