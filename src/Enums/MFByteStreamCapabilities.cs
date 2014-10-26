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

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation
{

    /// <summary>
    /// This enumeration defines values used by the <see cref="IMFByteStream.GetCapabilities"/> method.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/ms698962(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/ms698962(v=vs.85).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MFBYTESTREAM_* defines")]
    public enum MFByteStreamCapabilities
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0x00000000,
        /// <summary>
        /// The byte stream can be read. 
        /// </summary>
        IsReadable = 0x00000001,
        /// <summary>
        /// The byte stream can be written to. 
        /// </summary>
        IsWritable = 0x00000002,
        /// <summary>
        /// The byte stream can be seeked. 
        /// </summary>
        IsSeekable = 0x00000004,
        /// <summary>
        /// The byte stream is from a remote source, such as a network. 
        /// </summary>
        IsRemote = 0x00000008,
        /// <summary>
        /// The byte stream represents a file directory. 
        /// </summary>
        IsDirectory = 0x00000080,
        /// <summary>
        /// Seeking within this stream might be slow. For example, the byte stream might download from a network.
        /// </summary>
        HasSlowSeek = 0x00000100,
        /// <summary>
        /// The byte stream is currently downloading data to a local cache. 
        /// Read operations on the byte stream might take longer until the data is completely downloaded.
        /// <para/>
        /// This flag is cleared after all of the data has been downloaded.
        /// <para/>
        /// If the <see cref="HasSlowSeek"/> flag is also set, it means the byte stream must download 
        /// the entire file sequentially. Otherwise, the byte stream can respond to seek requests by 
        /// restarting the download from a new point in the stream.
        /// </summary>
        IsPartiallyDownloaded = 0x00000200,
        /// <summary>
        /// Another thread or process can open this byte stream for writing. 
        /// If this flag is present, the length of the byte stream could change while it is being read. 
        /// <para/>
        /// This flag can affect the behavior of byte-stream handlers. For more information, 
        /// see <c>MF_BYTESTREAMHANDLER_ACCEPTS_SHARE_WRITE</c>.
        /// <para/>
        /// Note  Requires Windows 7 or later.
        /// </summary>
        ShareWrite = 0x00000400,
        /// <summary>
        /// The byte stream is not currently using the network to receive the content.  
        /// Networking hardware may enter a power saving state when this bit is set.
        /// <para/>
        /// Note  Requires Windows 8 or later.
        /// </summary>
        DoesNotUseNetwork= 0x00000800
    }

}
