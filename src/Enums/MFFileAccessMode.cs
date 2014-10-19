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
    /// Specifies the requested access mode for opening a file.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/38108686-5378-4844-8D5A-A433E89F62BB(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/38108686-5378-4844-8D5A-A433E89F62BB(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_FILE_ACCESSMODE")]
    public enum MFFileAccessMode
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// Read mode.
        /// </summary>
        Read = 1,
        /// <summary>
        /// Write mode.
        /// </summary>
        Write = 2,
        /// <summary>
        /// Read and write mode.
        /// </summary>
        ReadWrite = 3
    }

}
