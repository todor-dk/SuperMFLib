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

    [UnmanagedName("MF_TOPOSTATUS")]
    public enum MFTopoStatus
    {
        // MF_TOPOSTATUS_INVALID: Invalid value; will not be sent
        Invalid = 0,

        // READY: The topology has been put in place and is
        // ready to start.  All GetService calls to the Media Session will use
        // this topology.
        Ready = 100,

        // STARTED_SOURCE: The Media Session has started to read
        // and process data from the Media Source(s) in this topology.
        StartedSource = 200,

        // MF_TOPOSTATUS_DYNAMIC_CHANGED: The topology has been dynamic changed
        // due to the format change.
        DynamicChanged = 210,

        // SINK_SWITCHED: The Media Sinks in the pipeline have
        // switched from a previous topology to this topology.
        // Note that this status does not get sent for the first topology;
        // applications can assume that the sinks are playing the first
        // topology when they receive MESessionStarted.
        SinkSwitched = 300,

        // ENDED: Playback of this topology is complete.
        // Before deleting this topology, however, the application should wait
        // for either MESessionEnded or the STARTED_SOURCE status
        // on the next topology to ensure that the Media Session is no longer
        // using this topology.
        Ended = 400,
    }

}
