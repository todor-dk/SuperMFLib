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

    /// <summary>
    /// Defines the type of a topology node.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/73EA1F48-0D86-4104-860C-83A4F9189920(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/73EA1F48-0D86-4104-860C-83A4F9189920(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_TOPOLOGY_TYPE")]
    internal enum MFTopologyType
    {
        /// <summary>
        /// Reserved.
        /// </summary>
        Max = -1,
        /// <summary>
        /// Output node. Represents a media sink in the topology.
        /// </summary>
        OutputNode = 0,
        /// <summary>
        /// Source node. Represents a media stream in the topology.
        /// </summary>
        SourcestreamNode = 1,
        /// <summary>
        /// Tee node. A tee node does not hold a pointer to an object. Instead, it represents a fork in the
        /// stream. A tee node has one input and multiple outputs, and samples from the upstream node are
        /// delivered to all of the downstream nodes.
        /// </summary>
        TeeNode = 3,
        /// <summary>
        /// Transform node. Represents a Media Foundation Transform (MFT) in the topology.
        /// </summary>
        TransformNode = 2
    }

}
