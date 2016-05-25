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
    /// <summary>
    /// Defines stream marker information for the <see cref="IMFStreamSink.PlaceMarker"/> method. The
    /// <c>PlaceMarker</c> method places a marker on the stream between samples. The <strong>
    /// MFSTREAMSINK_MARKER_TYPE</strong> enumeration defines the marker type and the type of information
    /// associated with the marker.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/D1C5F8EE-A451-44AF-BF43-7623CEA2BE37(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D1C5F8EE-A451-44AF-BF43-7623CEA2BE37(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFSTREAMSINK_MARKER_TYPE")]
    public enum MFStreamSinkMarkerType
    {
        /// <summary>
        /// This marker is for the application's use and does not convey any information to the stream sink.
        /// </summary>
        Default,

        /// <summary>
        /// This marker indicates the end of a segment within a presentation. There might be a gap in the
        /// stream until the next segment starts. There is no data associated with this marker.
        /// </summary>
        EndOfSegment,

        /// <summary>
        /// This marker indicates that there is a gap in the stream. The marker data is a <strong>LONGLONG
        /// </strong> value (VT_I8) that specifies the time for the missing sample. The next sample received
        /// after this marker will have the discontinuity flag. This marker corresponds to an
        /// <c>MEStreamTick</c> event from the stream.
        /// </summary>
        Tick,

        /// <summary>
        /// This marker contains a media event. The marker data is a pointer to the event's
        /// <see cref="IMFMediaEvent"/> interface (VT_UNKNOWN).
        /// </summary>
        Event
    }
}
