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
    /// Defines protection levels for <strong>MFPROTECTION_ACP</strong>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/82D289EE-7A81-4FBB-A259-6CF0CBD0D76A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/82D289EE-7A81-4FBB-A259-6CF0CBD0D76A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_OPM_ACP_PROTECTION_LEVEL")]
    public enum MF_OPM_ACP_PROTECTION_LEVEL
    {
        /// <summary>
        /// Specifies ACP is disabled.
        /// </summary>
        Off = 0,
        /// <summary>
        /// Specifies ACP is level one.
        /// </summary>
        LevelOne = 1,
        /// <summary>
        /// Specifies ACP is level two.
        /// </summary>
        LevelTwo = 2,
        /// <summary>
        /// Specifies ACP is level three.
        /// </summary>
        LevelThree = 3,
        /// <summary>
        /// Reserved.
        /// </summary>
        ForceULong = 0x7fffffff
    }

#endif
}
