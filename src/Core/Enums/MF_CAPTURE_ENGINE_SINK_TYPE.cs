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
using MediaFoundation.EVR;

namespace MediaFoundation.Core.Enums
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Specifies a type of capture sink.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/186F99D3-4C33-4749-88DB-86A356808CCC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/186F99D3-4C33-4749-88DB-86A356808CCC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_CAPTURE_ENGINE_SINK_TYPE")]
    internal enum MF_CAPTURE_ENGINE_SINK_TYPE
    {
        /// <summary>
        /// A recording sink, for capturing audio and video to a file.
        /// </summary>
        Record = 0x00000000,
        /// <summary>
        /// A preview sink, for previewing live audio or video.
        /// </summary>
        Preview = 0x00000001,
        /// <summary>
        /// A photo sink, for capturing still images.
        /// </summary>
        Photo = 0x00000002
    }

#endif

}
