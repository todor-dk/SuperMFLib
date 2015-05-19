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
    /// Defines the data type for a key/value pair.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/1844FBE2-0A07-4C0C-9FFE-4C59FC01F793(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/1844FBE2-0A07-4C0C-9FFE-4C59FC01F793(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_ATTRIBUTE_TYPE")]
    public enum MFAttributeType
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0x0,
        /// <summary>
        /// Byte array.
        /// </summary>
        Blob = 0x1011,
        /// <summary>
        /// Floating-point number.
        /// </summary>
        Double = 0x5,
        /// <summary>
        /// <strong>GUID</strong> value. 
        /// </summary>
        Guid = 0x48,
        /// <summary>
        /// <strong>IUnknown</strong> pointer. 
        /// </summary>
        IUnknown = 13,
        /// <summary>
        /// NULL-terminated wide-character string.
        /// </summary>
        String = 0x1f,
        /// <summary>
        /// Unsigned 32-bit integer.
        /// </summary>
        Uint32 = 0x13,
        /// <summary>
        /// Unsigned 64-bit integer.
        /// </summary>
        Uint64 = 0x15
    }

}
