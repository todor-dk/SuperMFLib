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

namespace MediaFoundation.Core.Enums
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Defines network status codes for the Media Engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A2A73A54-C360-452C-8887-D3065274358A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A2A73A54-C360-452C-8887-D3065274358A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_MEDIA_ENGINE_NETWORK")]
    internal enum MF_MEDIA_ENGINE_NETWORK : short
    {
        /// <summary>
        /// The initial state.
        /// </summary>
        Empty = 0,
        /// <summary>
        /// The Media Engine has started the resource selection algorithm, and has selected a media resource,
        /// but is not using the network.
        /// </summary>
        Idle = 1,
        /// <summary>
        /// The Media Engine is loading a media resource.
        /// </summary>
        Loading = 2,
        /// <summary>
        /// The Media Engine has started the resource selection algorithm, but has not selected a media
        /// resource.
        /// </summary>
        NoSource = 3
    }

#endif

}
