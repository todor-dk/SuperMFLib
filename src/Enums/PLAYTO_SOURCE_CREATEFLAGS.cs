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

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Contains flags for the <see cref="IPlayToSourceClassFactory.CreateInstance"/> method.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/windows/desktop/hh162910(v=vs.85).aspx">http://msdn.microsoft.com/en-US/library/windows/desktop/hh162910(v=vs.85).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("PLAYTO_SOURCE_CREATEFLAGS")]
    public enum PLAYTO_SOURCE_CREATEFLAGS  // PLAYTO_SOURCE_CREATEFLAGS
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0x0,
        /// <summary>
        /// Share images.
        /// </summary>
        Image = 0x1,
        /// <summary>
        /// Share audio.
        /// </summary>
        Audio = 0x2,
        /// <summary>
        /// Share video.
        /// </summary>
        Video = 0x4,
        /// <summary>
        /// Share DRM protected media.
        /// <para/>
        /// Supported in Windows 8.1 and later.
        /// </summary>
        Protected = 0x8
    }

#endif

}
