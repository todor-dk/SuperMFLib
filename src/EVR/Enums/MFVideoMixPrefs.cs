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

namespace MediaFoundation.EVR.Enums
{
    #if NOT_IN_USE


    /// <summary>
    /// Contains flags that are used to configure how the enhanced video renderer (EVR) performs 
    /// deinterlacing.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/28DCC8B1-684E-4178-9606-118E77D8FF58(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/28DCC8B1-684E-4178-9606-118E77D8FF58(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MFVideoMixPrefs")]
    internal enum MFVideoMixPrefs
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// Force the EVR  to skip the second field (in temporal order) of every interlaced frame. 
        /// </summary>
        ForceHalfInterlace = 0x00000001,
        /// <summary>
        /// If the EVR is falling behind, allow it to skip the second field (in temporal order) of every
        /// interlaced frame.
        /// </summary>
        AllowDropToHalfInterlace = 0x00000002,
        /// <summary>
        /// If the EVR is falling behind, allow it to use bob deinterlacing, even if the driver supports a
        /// higher-quality deinterlacing mode.
        /// </summary>
        AllowDropToBob = 0x00000004,
        /// <summary>
        /// Force the EVR to use bob deinterlacing, even if the driver supports a higher-quality mode.
        /// </summary>
        ForceBob = 0x00000008,
        /// <summary>
        /// The bitmask of valid flag values. This constant is not itself a valid flag. 
        /// </summary>
        Mask = 0x0000000f
    }
#endif
}
