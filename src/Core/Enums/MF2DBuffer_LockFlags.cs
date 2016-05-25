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

namespace MediaFoundation.Core.Enums
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains flags for the <see cref="IMF2DBuffer2.Lock2DSize"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/298E3FBE-1902-4AA1-9CC8-5B8D65A48ECF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/298E3FBE-1902-4AA1-9CC8-5B8D65A48ECF(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF2DBuffer_LockFlags")]
    internal enum MF2DBuffer_LockFlags
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None,
        /// <summary>
        /// Reserved.
        /// </summary>
        LockTypeMask = 0x1 | 0x2 | 0x3,
        /// <summary>
        /// Lock the buffer for reading.
        /// </summary>
        Read = 0x1,
        /// <summary>
        /// Lock the buffer for writing.
        /// </summary>
        Write = 0x2,
        /// <summary>
        /// Lock the buffer for both reading and writing.
        /// </summary>
        ReadWrite = 0x3,

        /// <summary>
        /// Reserved. This member forces the enumeration type to compile as a <strong>DWORD</strong> value. 
        /// </summary>
        ForceDWORD = 0x7FFFFFFF
    }

#endif

}
