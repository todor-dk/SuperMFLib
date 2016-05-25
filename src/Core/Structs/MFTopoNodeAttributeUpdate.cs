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
    /// Specifies a new attribute value for a topology node.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MFTOPONODE_ATTRIBUTE_UPDATE {
    ///   TOPOID            NodeId;
    ///   GUID              guidAttributeKey;
    ///   MF_ATTRIBUTE_TYPE attrType;
    ///   union {
    ///     UINT32 u32;
    ///     UINT32 u64;
    ///     double d;
    ///   };
    /// } MFTOPONODE_ATTRIBUTE_UPDATE;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/94C89067-9B3E-4D24-9192-A68E284C5D99(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/94C89067-9B3E-4D24-9192-A68E284C5D99(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 8), UnmanagedName("MFTOPONODE_ATTRIBUTE_UPDATE")]
    internal struct MFTopoNodeAttributeUpdate
    {
        /// <summary>
        /// The identifier of the topology node to update. To get the identifier of a topology node, call
        /// <see cref="IMFTopologyNode.GetTopoNodeID" />.
        /// </summary>
        public long NodeId;
        /// <summary>
        /// GUID that specifies the attribute to update.
        /// </summary>
        public Guid guidAttributeKey;
        /// <summary>
        /// Attribute type, specified as a member of the <see cref="MFAttributeType" /> enumeration.
        /// </summary>
        public MFAttributeType attrType;
        /// <summary>
        /// Contains the <c>d</c>, <c>u32</c> and <c>u64</c> fields.
        /// </summary>
        public Unnamed1 u1;
    }

#endif

}
