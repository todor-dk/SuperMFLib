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
    /// Defines media key error codes for the media engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302188(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302188(v=vs.85).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_MEDIA_ENGINE_KEYERR")]
    public enum MF_MEDIA_ENGINE_KEYERR
    {
        /// <summary>
        /// Unknown error occurred.
        /// </summary>
        Unknown = 1,
        /// <summary>
        /// An error with the client occurred.
        /// </summary>
        Client = 2,
        /// <summary>
        /// An error with the service occurred.
        /// </summary>
        Service = 3,
        /// <summary>
        /// An error with the output occurred.
        /// </summary>
        Output = 4,
        /// <summary>
        /// An error occurred related to a hardware change.
        /// </summary>
        HardwareChange = 5,
        /// <summary>
        /// An error with the domain occurred.
        /// </summary>
        Domain = 6,
    }

#endif
}