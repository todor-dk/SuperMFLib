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
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation.Core.Enums
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Indicates the type of control protocol that is used in streaming or downloading. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/DD628B9E-3C52-4C14-AA0F-5E0B811D3F57(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DD628B9E-3C52-4C14-AA0F-5E0B811D3F57(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFNETSOURCE_PROTOCOL_TYPE")]
    internal enum MFNetSourceProtocolType
    {
        /// <summary>
        /// The protocol type has not yet been determined. 
        /// </summary>
        Undefined,
        /// <summary>
        /// The protocol type is HTTP. This includes HTTPv9, WMSP, and HTTP download. 
        /// </summary>
        Http,
        /// <summary>
        /// The protocol type is Real Time Streaming Protocol (RTSP). 
        /// </summary>
        Rtsp,
        /// <summary>
        /// The content is read from a file. The file might be local or on a remote share. 
        /// </summary>
        File,
        /// <summary>
        /// The protocol type is multicast.
        /// <para/>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// </summary>
        MultiCast
    }

#endif

}
