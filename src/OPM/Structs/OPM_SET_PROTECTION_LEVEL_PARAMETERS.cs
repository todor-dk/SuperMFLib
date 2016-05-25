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
    /// Contains data for the <see cref="OPM.MFOpmStatusRequests.OPM_SET_PROTECTION_LEVEL" /> command in
    /// <c>Output Protection Manager</c> (OPM).
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _OPM_SET_PROTECTION_LEVEL_PARAMETERS {
    ///   ULONG ulProtectionType;
    ///   ULONG ulProtectionLevel;
    ///   ULONG Reserved;
    ///   ULONG Reserved2;
    /// } OPM_SET_PROTECTION_LEVEL_PARAMETERS;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/074C30B2-AD79-4ACE-89FB-859FAC016EBF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/074C30B2-AD79-4ACE-89FB-859FAC016EBF(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    internal struct OPM_SET_PROTECTION_LEVEL_PARAMETERS
    {
        /// <summary>
        /// Identifies the protection mechanism. For a list of possible values, see
        /// <c>OPM Protection Type Flags</c>.
        /// </summary>
        public int ulProtectionType;
        /// <summary>
        /// Specifies the protection level. The meaning of this value depends on the protection mechanism that
        /// is queried. For each protection mechanism, the value is a flag from a different enumeration, as
        /// shown in the following table.
        /// <para /><list type="table"><listheader><term>Protection mechanism</term><description>Enumeration</description></listheader><item><term>ACP</term><description><see cref="OPM.OPM_ACP_PROTECTION_LEVEL" /></description></item><item><term>CGMS-A</term><description><c>CGMS-A Protection Flags</c></description></item><item><term>DPCP</term><description><see cref="OPM.OPM_DPCP_PROTECTION_LEVEL" /></description></item><item><term>HDCP</term><description><see cref="OPM.OPM_HDCP_PROTECTION_LEVEL" /></description></item></list>
        /// </summary>
        public int ulProtectionLevel;
        /// <summary>
        /// Reserved for future use. Set to zero.
        /// </summary>
        public int Reserved;
        /// <summary>
        /// Reserved for future use. Set to zero.
        /// </summary>
        public int Reserved2;
    }

#endif

}
