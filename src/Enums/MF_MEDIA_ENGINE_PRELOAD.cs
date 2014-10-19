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
    /// Defines preload hints for the Media Engine. These values correspond to the <strong>preload</strong>
    /// attribute of the <strong>HTMLMediaElement</strong> interface in HTML5. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/784B3B3F-0A9E-4E34-9197-CE20E2F3FF78(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/784B3B3F-0A9E-4E34-9197-CE20E2F3FF78(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_MEDIA_ENGINE_PRELOAD")]
    public enum MF_MEDIA_ENGINE_PRELOAD
    {
        /// <summary>
        /// The <strong>preload</strong> attribute is missing. 
        /// </summary>
        Missing = 0,
        /// <summary>
        /// The <strong>preload</strong> attribute is an empty string. This value is equivalent to <strong>
        /// MF_MEDIA_ENGINE_PRELOAD_AUTOMATIC</strong>. 
        /// </summary>
        Empty = 1,
        /// <summary>
        /// The <strong>preload</strong> attribute is "none". This value is a hint to the user agent not to
        /// preload the resource. 
        /// </summary>
        None = 2,
        /// <summary>
        /// The <strong>preload</strong> attribute is "metadata". This value is a hint to the user agent to
        /// fetch the resource metadata. 
        /// </summary>
        Metadata = 3,
        /// <summary>
        /// The <strong>preload</strong> attribute is "auto". This value is a hint to the user agent to preload
        /// the entire resource. 
        /// </summary>
        Automatic = 4
    }

#endif

}
