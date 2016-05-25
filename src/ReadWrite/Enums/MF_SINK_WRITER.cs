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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation.ReadWrite.Enums
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Enumeration used with many methods of among others the <see cref="IMFSinkWriter"/>
    /// to indicate different predefined streams.
    /// </summary>
    [UnmanagedName("Unnamed enum")]
    internal enum MF_SINK_WRITER
    {
        /// <summary>
        /// Invalid stream index.
        /// </summary>
        InvalidStreamIndex = unchecked((int)0xFFFFFFFF),
        /// <summary>
        /// All streams.
        /// </summary>
        AllStreams = unchecked((int)0xFFFFFFFE),
        /// <summary>
        /// Query the media sink for the stream index.
        /// </summary>
        MediaSink = unchecked((int)0xFFFFFFFF)
    }

#endif

}
