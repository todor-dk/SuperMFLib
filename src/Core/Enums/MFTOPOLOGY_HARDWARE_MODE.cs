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

namespace MediaFoundation.Core.Enums
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Specifies whether the topology loader will insert hardware-based Media Foundation transforms (MFTs)
    /// into the topology.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FDAA13A5-9B23-440E-BE04-AE926E1B0FF5(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FDAA13A5-9B23-440E-BE04-AE926E1B0FF5(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFTOPOLOGY_HARDWARE_MODE")]
    internal enum MFTOPOLOGY_HARDWARE_MODE
    {
        /// <summary>
        /// Use only software  MFTs. Do not use hardware-based MFTs. This mode is the default, for backward
        /// compatibility with existing applications.
        /// </summary>
        SoftwareOnly = 0,
        /// <summary>
        /// Use hardware-based MFTs when possible, and software MFTs otherwise. This mode is the recommended
        /// one.
        /// </summary>
        UseHardware = 1,
        /// <summary>
        /// If hardware-based MFTs are available, the topoloader will insert them. If not, the connection will fail.
        /// <para/>
        /// Supported in Windows 8.1 and later.
        /// </summary>
        UseOnlyHardware = 2,
    }

#endif

}
