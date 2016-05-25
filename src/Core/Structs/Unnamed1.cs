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

namespace MediaFoundation.Core.Structs
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Contains the <c>d</c>, <c>u32</c> and <c>u64</c> members of the <see cref="MFAttributeType"/> structure.
    /// </summary>
    [StructLayout(LayoutKind.Explicit, Pack = 8), UnmanagedName("unnamed internal struct")]
    internal struct Unnamed1
    {
        /// <summary>
        /// Attribute value (floating point). This member is used when <see cref="MFTopoNodeAttributeUpdate.attrType"/> equals MF_ATTRIBUTE_DOUBLE. 
        /// </summary>
        [FieldOffset(0)]
        public double d;
        /// <summary>
        /// Attribute value (unsigned 32-bit integer). This member is used when <see cref="MFTopoNodeAttributeUpdate.attrType"/> equals MF_ATTRIBUTE_UINT32. 
        /// </summary>
        [FieldOffset(0)]
        public int u32;
        /// <summary>
        /// Attribute value (unsigned 32-bit integer). This member is used when <see cref="MFTopoNodeAttributeUpdate.attrType"/> equals MF_ATTRIBUTE_UINT64. See Remarks. 
        /// </summary>
        [FieldOffset(0)]
        public long u64;
    }

#endif

}
