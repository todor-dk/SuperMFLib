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
    /// Defines the behavior of the source resolver. These flags are also used by 
    /// scheme handlers and byte stream handlers.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/windows/desktop/ms705656(v=vs.85).aspx">http://msdn.microsoft.com/en-US/library/windows/desktop/ms705656(v=vs.85).aspx</a>
    /// </remarks>
    /// <seealso cref="MFResolution"/>
    // NB: Same enum as MFResolution!!!
    [Flags, UnmanagedName("Source Resolver Flags")]
    internal enum MF_RESOLUTION
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// Attempt to create a media source.
        /// </summary>
        MediaSource = 0x1,
        /// <summary>
        /// Attempt to create a byte stream.
        /// </summary>
        ByteStream = 0x2,
        /// <summary>
        /// If source resolution fails using the byte-stream handler that is registered for the MIME type or 
        /// file name extension, the source resolver enumerates through all of the registered byte-stream handlers.
        /// <para/>
        /// Byte-stream handlers are registered by file name extension or MIME type. Initially, the source resolver 
        /// attempts to use a handler that matches the file name extension or the MIME type. If that fails, 
        /// then by default the entire source resolution fails and the source resolver returns an error code 
        /// to the application. If this flag is specified, however, the source resolver continues to enumerates 
        /// through all of the registered byte-stream handlers. Possibly a mis-matched handler can successfully 
        /// create the media source.
        /// <para/>This flag cannot be combined with the <see cref="KeepByteStreamAliveOnFail"/> flag. 
        /// See Remarks for more information.
        /// </summary>
        ContentDoesNotHaveToMatchExtensionOrMimeType = 0x10,
        /// <summary>
        /// If the source resolution fails, the source resolver does not close the byte stream. 
        /// By default, the source resolver closes the byte stream on failure.
        /// <para/>
        /// If this flag is used and the source resolution fails, the caller should call the method 
        /// again and set the <see cref="ContentDoesNotHaveToMatchExtensionOrMimeType"/> flag.
        /// <para/>
        /// This flag cannot be combined with the <see cref="ContentDoesNotHaveToMatchExtensionOrMimeType"/> flag. 
        /// See Remarks for more information.
        /// </summary>
        KeepByteStreamAliveOnFail = 0x20,
        /// <summary>
        /// The source resolver will not use locally registered scheme or bytestream handler plugins.
        /// <para/>
        /// Requires Windows 8.
        /// </summary>
        DisableLocalPlugins = 0x40,
        /// <summary>
        /// This flag causes the source resolver to use a local plugin control policy that only allows use of approved plugins.
        /// </summary>
        PluginControlPolicyApprovedOnly = 0x80,
        /// <summary>
        /// This flag causes the source resolver to use a local plugin control policy that only allows use of web approved plugins.
        /// </summary>
        PluginControlPolicyWebOnly = 0x100,
        /// <summary>
        /// Requests read access to the source.
        /// </summary>
        Read = 0x10000,
        /// <summary>
        /// Requests write access to the source.
        /// </summary>
        Write = 0x20000
    }

#endif

}
