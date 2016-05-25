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

// This file is a mess.  While technically part of MF, I'm in no hurry
// to try to get this to work.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MediaFoundation.OPM.Structs
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains the result from an <c>Output Protection Manager</c> (OPM) status request.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _OPM_STANDARD_INFORMATION {
    ///   OPM_RANDOM_NUMBER rnRandomNumber;
    ///   ULONG             ulStatusFlags;
    ///   ULONG             ulInformation;
    ///   ULONG             ulReserved;
    ///   ULONG             ulReserved2;
    /// } OPM_STANDARD_INFORMATION;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/4C1B6803-0015-4DEF-ACB0-295193BA0E17(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/4C1B6803-0015-4DEF-ACB0-295193BA0E17(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    internal struct OPM_STANDARD_INFORMATION
    {
        /// <summary>
        /// An <see cref="OPM.OPM_RANDOM_NUMBER" /> structure. This structure contains the same 128-bit random
        /// number that the application sent to the driver in the <see cref="OPM.OPM_GET_INFO_PARAMETERS" /> or
        /// <see cref="OPM.OPM_COPP_COMPATIBLE_GET_INFO_PARAMETERS" /> structure.
        /// </summary>
        public OPM_RANDOM_NUMBER rnRandomNumber;
        /// <summary>
        /// A bitwise <strong>OR</strong> of <c>OPM Status Flags</c>.
        /// </summary>
        public int ulStatusFlags;
        /// <summary>
        /// Response data. The meaning of this value depends on the status request. For more information, see
        /// <c>OPM Status Requests</c>.
        /// </summary>
        public int ulInformation;
        /// <summary>
        /// Reserved for future use. Set to zero.
        /// </summary>
        public int ulReserved;
        /// <summary>
        /// Reserved for future use. Set to zero.
        /// </summary>
        public int ulReserved2;
    }

#endif

}
