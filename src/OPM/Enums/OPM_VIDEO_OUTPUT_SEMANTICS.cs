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

namespace MediaFoundation.OPM.Enums
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Specifies whether the <see cref="OPM.IOPMVideoOutput"/> interface will use Output Protection
    /// Manager (OPM) semantics or Certified Output Protection Protocol (COPP) semantics. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D52FBC40-072B-4B7A-87C2-B928563100BB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D52FBC40-072B-4B7A-87C2-B928563100BB(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    internal enum OPM_VIDEO_OUTPUT_SEMANTICS
    {
        /// <summary>
        /// The interface will use COPP semantics.
        /// </summary>
        OPM_VOS_COPP_SEMANTICS = 0,
        /// <summary>
        /// The interface will use OPM semantics.
        /// </summary>
        OPM_VOS_OPM_SEMANTICS = 1
    }

#endif

}
