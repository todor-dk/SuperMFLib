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

using MediaFoundation.Misc;
using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Defines the status of the Output Protection Manager (OPM).
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302190(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302190(v=vs.85).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_MEDIA_ENGINE_OPM_STATUS")]
    public enum MF_MEDIA_ENGINE_OPM_STATUS
    {
        /// <summary>
        /// Default status. Used to return the correct status when the content is unprotected.
        /// </summary>
        NotRequested = 0,
        /// <summary>
        /// OPM successfully established.
        /// </summary>
        Established = 1,
        /// <summary>
        /// OPM failed because running in a virtual machined (VM).
        /// </summary>
        FailedVM = 2,
        /// <summary>
        /// OPM failed because there is no graphics driver and the system is using Broadcast Driver Architecture (BDA).
        /// </summary>
        FailedBDA = 3,
        /// <summary>
        /// OPM failed because the graphics driver is not PE signed, falling back to WARP.
        /// </summary>
        FailedUnsignedDriver = 4,
        /// <summary>
        /// OPM failed for other reasons.
        /// </summary>
        Failed = 5,
    }

#endif
}