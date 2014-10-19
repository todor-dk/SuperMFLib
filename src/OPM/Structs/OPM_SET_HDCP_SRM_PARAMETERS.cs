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

namespace MediaFoundation.OPM
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains parameters for the <see cref="OPM.MFOpmStatusRequests.OPM_SET_HDCP_SRM" /> command. This
    /// command updates the system renewability message (SRM) for High-Bandwidth Digital Content Protection
    /// (HDCP).
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _OPM_SET_HDCP_SRM_PARAMETERS {
    ///   ULONG ulSRMVersion;
    /// } OPM_SET_HDCP_SRM_PARAMETERS;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/0689E132-8DEF-43D1-965F-A6F652AD0FBE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0689E132-8DEF-43D1-965F-A6F652AD0FBE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    public struct OPM_SET_HDCP_SRM_PARAMETERS
    {
        /// <summary>
        /// Contains the SRM version number in little-endian format. This number is contained in the <strong>
        /// SRM Version</strong> field of the SRM. For more information, see the HDCP specification.
        /// </summary>
        public int ulSRMVersion;
    }

#endif

}
