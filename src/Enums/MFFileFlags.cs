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
    /// Specifies the behavior when opening a file. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1E1C906E-C832-4DF1-96F5-86E690C3C34E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1E1C906E-C832-4DF1-96F5-86E690C3C34E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MF_FILE_FLAGS")]
    public enum MFFileFlags
    {
        /// <summary>
        /// Use the default behavior. 
        /// </summary>
        None = 0,
        /// <summary>
        /// Open the file with no system caching. 
        /// </summary>
        NoBuffering = 0x1,
        /// <summary>
        /// Subsequent open operations can have write access to the file. 
        /// <para/>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// </summary>
        AllowWriteSharing = 0x2
    }

}
