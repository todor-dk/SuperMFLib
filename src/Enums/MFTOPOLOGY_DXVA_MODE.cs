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
using System.Runtime.InteropServices.ComTypes;

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Specifies whether the topology loader enables Microsoft DirectX Video Acceleration (DXVA) in the
    /// topology.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C47F505A-1B98-4309-B462-5B911E1F591F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C47F505A-1B98-4309-B462-5B911E1F591F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MFTOPOLOGY_DXVA_MODE")]
    public enum MFTOPOLOGY_DXVA_MODE
    {
        /// <summary>
        /// The topology loader enables DXVA on the decoder if possible, and drops optional Media Foundation
        /// transforms (MFTs) that do not support DXVA.
        /// </summary>
        Default = 0,
        /// <summary>
        /// The topology loader disables all video acceleration. This setting forces software processing, even
        /// when the decoder supports DXVA.
        /// </summary>
        None = 1,
        /// <summary>
        /// The topology loader enables DXVA on every MFT that supports it.
        /// </summary>
        Full = 2
    }

#endif

}
