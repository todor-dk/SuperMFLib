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
    /// Defines protection levels for <strong>MFPROTECTION_CGMSA</strong>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/EEFE04F7-E878-4F09-B973-B0FD3E9431AA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EEFE04F7-E878-4F09-B973-B0FD3E9431AA(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_OPM_CGMSA_PROTECTION_LEVEL")]
    public enum MF_OPM_CGMSA_PROTECTION_LEVEL
    {
        /// <summary>
        /// CGMS-A is disabled.
        /// </summary>
        Off = 0x00,
        /// <summary>
        /// The protection level is Copy Freely.
        /// </summary>
        CopyFreely = 0x01,
        /// <summary>
        /// The protection level is Copy No More.
        /// </summary>
        CopyNoMore = 0x02,
        /// <summary>
        /// The protection level is Copy One Generation.
        /// </summary>
        CopyOneGeneration = 0x03,
        /// <summary>
        /// The protection level is Copy Never.
        /// </summary>
        CopyNever = 0x04,
        /// <summary>
        /// Redistribution control (also called the broadcast flag) is required. This flag can be combined with
        /// the other flags.
        /// </summary>
        RedistributionControlRequired = 0x08,
    }

#endif
}
