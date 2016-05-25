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

namespace MediaFoundation
{
    /// <summary>
    /// Specifies how to open or create a file.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/0C0E94FA-CBCC-4ABC-9020-AF6D36A4D3B6(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/0C0E94FA-CBCC-4ABC-9020-AF6D36A4D3B6(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_FILE_OPENMODE")]
    public enum MFFileOpenMode
    {
        /// <summary>
        /// Open an existing file. Fail if the file does not exist.
        /// </summary>
        FailIfNotExist = 0,

        /// <summary>
        /// Create a new file. Fail if the file already exists.
        /// </summary>
        FailIfExist = 1,

        /// <summary>
        /// Open an existing file and truncate it, so that the size is zero bytes. Fail if the file does not
        /// already exist.
        /// </summary>
        ResetIfExist = 2,

        /// <summary>
        /// If the file does not exist, create a new file. If the file exists, open it.
        /// </summary>
        AppendIfExist = 3,

        /// <summary>
        /// Create a new file. If the file exists, overwrite the file.
        /// </summary>
        DeleteIfExist = 4
    }
}
