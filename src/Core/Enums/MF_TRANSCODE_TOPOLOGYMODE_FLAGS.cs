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
    /// Defines flags for the <see cref="MFAttributesClsid.MF_TRANSCODE_TOPOLOGYMODE"/> attribute. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9A98A052-9FB0-4C63-BC9C-8E112E37973F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9A98A052-9FB0-4C63-BC9C-8E112E37973F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MF_TRANSCODE_TOPOLOGYMODE_FLAGS")]
    internal enum MF_TRANSCODE_TOPOLOGYMODE_FLAGS
    {
        /// <summary>
        /// The topology loader will exclude hardware-based transforms (such as codecs and color converters)
        /// from the topology. It will use only software transforms.
        /// </summary>
        SoftwareOnly = 0,
        /// <summary>
        /// The topology loader may insert hardware-based transforms into the transcode topology.
        /// </summary>
        HardwareAllowed = 1
    }

#endif

}
