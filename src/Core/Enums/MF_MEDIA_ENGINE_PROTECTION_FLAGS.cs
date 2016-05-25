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
    /// Contains flags that specify whether the Media Engine will play protected content, and whether the
    /// Media Engine will use the <c>Protected Media Path</c> (PMP). 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/02326325-F122-4D6A-8CA7-3B201378BC15(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/02326325-F122-4D6A-8CA7-3B201378BC15(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MF_MEDIA_ENGINE_PROTECTION_FLAGS")]
    internal enum MF_MEDIA_ENGINE_PROTECTION_FLAGS
    {
        /// <summary>
        /// Enable playback of protected content. The Media Engine will not play DRM-protected content unless
        /// this flag is set. If you set this flag, also set the 
        /// <see cref="MF_MEDIA_ENGINE.CONTENT_PROTECTION_MANAGER"/> attribute. 
        /// </summary>
        EnableProtectedContent = 1,
        /// <summary>
        /// Use the <c>Protected Media Path</c> (PMP) for all playback, including clear (non-protected)
        /// content. 
        /// </summary>
        UsePMPForAllContent = 2,
        /// <summary>
        /// Create the PMP inside an unprotected process. You can use this option to play clear content, but
        /// not to play protected content.
        /// </summary>
        UseUnprotectedPMP = 4

    }

#endif

}
