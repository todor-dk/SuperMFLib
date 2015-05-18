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
    /// Specifies the status of a topology during playback. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7CF2A4F2-C115-4DEE-AB91-6A3FAB33365F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7CF2A4F2-C115-4DEE-AB91-6A3FAB33365F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_TOPOSTATUS")]
    internal enum MFTopoStatus
    {
        // MF_TOPOSTATUS_INVALID: Invalid value; will not be sent
        /// <summary>
        /// This value is not used. 
        /// </summary>
        Invalid = 0,

        // READY: The topology has been put in place and is
        // ready to start.  All GetService calls to the Media Session will use
        // this topology.
        /// <summary>
        /// The topology is ready to start. After this status flag is received, you can use the Media Session's
        /// <see cref="IMFGetService.GetService"/> method to query the topology for services, such as rate
        /// control. 
        /// </summary>
        Ready = 100,

        // STARTED_SOURCE: The Media Session has started to read
        // and process data from the Media Source(s) in this topology.
        /// <summary>
        /// The Media Session has started to read data from the media sources in the topology. 
        /// </summary>
        StartedSource = 200,

        // MF_TOPOSTATUS_DYNAMIC_CHANGED: The topology has been dynamic changed
        // due to the format change.
        /// <summary>
        /// The Media Session modified the topology, because the format of a stream changed.
        /// </summary>
        DynamicChanged = 210,

        // SINK_SWITCHED: The Media Sinks in the pipeline have
        // switched from a previous topology to this topology.
        // Note that this status does not get sent for the first topology;
        // applications can assume that the sinks are playing the first
        // topology when they receive MESessionStarted.
        /// <summary>
        /// The media sinks have switched from the previous topology to this topology. This status value is not
        /// sent for the first topology that is played. For the first topology, the <c>MESessionStarted</c>
        /// event indicates that the media sinks have started receiving data. 
        /// </summary>
        SinkSwitched = 300,

        // ENDED: Playback of this topology is complete.
        // Before deleting this topology, however, the application should wait
        // for either MESessionEnded or the STARTED_SOURCE status
        // on the next topology to ensure that the Media Session is no longer
        // using this topology.
        /// <summary>
        /// Playback of this topology is complete. The Media Session might still use the topology internally.
        /// The Media Session does not completely release the topology until it sends the next <strong>
        /// MF_TOPOSTATUS_STARTED_SOURCE</strong> status event or the <c>MESessionEnded</c> event. 
        /// </summary>
        Ended = 400,
    }

}
