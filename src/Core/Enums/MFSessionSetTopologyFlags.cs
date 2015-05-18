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
    /// Defines the behavior of the <see cref="IMFMediaSession.SetTopology"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/2993BDF9-CF28-4E20-9F38-F51FB0F6429E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2993BDF9-CF28-4E20-9F38-F51FB0F6429E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MFSESSION_SETTOPOLOGY_FLAGS")]
    internal enum MFSessionSetTopologyFlags
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0x0,
        /// <summary>
        /// Stop the current presentation, clear all pending presentations, and immediately queue the new
        /// topology (specified by the <em>pTopology</em> parameter). 
        /// <para/>
        /// If the <em>pTopology</em> parameter is <strong>NULL</strong>, this flag has no effect. 
        /// </summary>
        Immediate = 0x1,
        /// <summary>
        /// The topology does not need to be resolved. Use this flag if you are setting a full topology. 
        /// </summary>
        NoResolution = 0x2,
        /// <summary>
        /// <strong>Note</strong> Requires Windows 7. 
        /// <para/>
        /// Clear the current topology, as follows:
        /// <para/>
        /// <para>* If <em>pTopology</em> is not <strong>NULL</strong>, the topology is cleared only if <em>
        /// pTopology</em> matches the current topology (that is, only if <em>pTopology</em> points to the
        /// current topology). </para><para>* If the <em>pTopology</em> parameter is <strong>NULL</strong>, the
        /// current topology is cleared, regardless of which topology is current. </para>
        /// <para/>
        /// Pending topologies are not removed from the playback queue. If there is a pending topology on the
        /// queue, that topology will be loaded after the current topology is cleared. Otherwise, playback
        /// simply stops.
        /// <para/>
        /// To remove all of the pending topologies from the queue, call 
        /// <see cref="IMFMediaSession.ClearTopologies"/>. 
        /// </summary>
        ClearCurrent = 0x4
    }

}
