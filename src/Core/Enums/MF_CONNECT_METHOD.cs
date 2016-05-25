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
    /// Specifies how the topology loader connects a topology node. This enumeration is used with the 
    /// <see cref="MFAttributesClsid.MF_TOPONODE_CONNECT_METHOD"/> attribute. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/881045BF-EA3B-46E2-AAE0-B26E35882DA1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/881045BF-EA3B-46E2-AAE0-B26E35882DA1(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MF_CONNECT_METHOD")]
    internal enum MF_CONNECT_METHOD
    {
        /// <summary>
        /// Connect the node directly to its upstream neighbor. Fail otherwise. 
        /// </summary>
        Direct = 0x00000000,
        /// <summary>
        /// Add a converter transform upstream from this node, if needed to complete the connection. Converter
        /// transforms include color-space converters for video, and audio resamplers for audio. 
        /// </summary>
        AllowConverter = 0x00000001,
        /// <summary>
        /// Add a decoder transform upstream upstream from this node, if needed to complete the connection. The
        /// numeric value of this flag includes the <strong>MF_CONNECT_ALLOW_CONVERTER</strong> flag.
        /// Therefore, setting the <strong>MF_CONNECT_ALLOW_DECODER</strong> flag sets the <strong>
        /// MF_CONNECT_ALLOW_CONVERTER</strong> flag as well. 
        /// </summary>
        AllowDecoder = 0x00000003,
        /// <summary>
        /// Controls the order in which the topology loader attempts to use different output types from this
        /// node. Currently, this flag applies only to source nodes. For more information, see 
        /// <see cref="MFAttributesClsid.MF_TOPOLOGY_ENUMERATE_SOURCE_TYPES"/>. 
        /// <para/>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// </summary>
        ResolveIndependentOutputTypes = 0x00000004,
        /// <summary>
        /// This node is optional. If the topology loader cannot connect this node, it will skip the node and
        /// continue. 
        /// </summary>
        AsOptional = 0x00010000,
        /// <summary>
        /// The entire topology branch starting at this node is optional. If the topology loader cannot resolve
        /// this branch, it will skip the branch and continue. 
        /// </summary>
        AsOptionalBranch = 0x00020000,
    }

#endif

}
