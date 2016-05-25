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
    /// Specifies the type of Microsoft DirectX Video Acceleration High Definition (DXVA-HD) device.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C472F2C6-214D-4BB0-BA9D-8DD04FF2A646(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C472F2C6-214D-4BB0-BA9D-8DD04FF2A646(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("DXVAHD_DEVICE_TYPE")]
    internal enum DXVAHD_DEVICE_TYPE
    {
        /// <summary>
        /// Hardware device. Video processing is performed in the GPU by the driver.
        /// </summary>
        Hardware = 0,
        /// <summary>
        /// Software device. Video processing is performed in the CPU by a software plug-in.
        /// </summary>
        Software = 1,
        /// <summary>
        /// Reference device. Video processing is performed in the CPU by a software plug-in.
        /// </summary>
        Reference = 2,
        /// <summary>
        /// Other. The device is neither a hardware device nor a software plug-in.
        /// </summary>
        Other = 3
    }

#endif

}
