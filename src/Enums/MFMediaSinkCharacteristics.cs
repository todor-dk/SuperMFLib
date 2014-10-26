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
    /// Flags used in conjunction with the <see cref="IMFMediaSink.GetCharacteristics"/> method.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A7E8E2AF-8B10-47F5-8B09-A7147ACE5BA1(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A7E8E2AF-8B10-47F5-8B09-A7147ACE5BA1(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MEDIASINK_ defines")]
    public enum MFMediaSinkCharacteristics
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// The media sink has a fixed number of streams. It does not support the <see cref="IMFMediaSink.AddStreamSink"/> 
        /// and <see cref="IMFMediaSink.RemoveStreamSink"/> methods. This flag is a hint to the application.
        /// </summary>
        FixedStreams = 0x00000001,
        /// <summary>
        /// The media sink cannot match rates with an external clock.
        /// <para/>
        /// For best results, this media sink should be used as the time source for the presentation clock. 
        /// If any other time source is used, the media sink cannot match rates with the clock, 
        /// with poor results (for example, glitching).
        /// <para/>
        /// This flag should be used sparingly, because it limits how the pipeline can be configured.
        /// <para/>
        /// For more information about the presentation clock, see <c>Presentation Clock</c>.
        /// </summary>
        CannotMatchClock = 0x00000002,
        /// <summary>
        /// The media sink is rateless. It consumes samples as quickly as possible, and does not synchronize itself 
        /// to a presentation clock.
        /// <para/>
        /// Most archiving sinks are rateless.
        /// </summary>
        Rateless = 0x00000004,
        /// <summary>
        /// The media sink requires a presentation clock. The presentation clock is set by calling the media sink's 
        /// <see cref="IMFMediaSink.SetPresentationClock"/> method. 
        /// <para/>
        /// This flag is obsolete, because all media sinks must support the <c>SetPresentationClock</c> method, 
        /// even if the media sink ignores the clock (as in a rateless media sink).
        /// </summary>
        ClockRequired = 0x00000008,
        /// <summary>
        /// The media sink can accept preroll samples before the presentation clock starts. The media sink exposes 
        /// the <see cref="IMFMediaSinkPreroll"/> interface.
        /// </summary>
        CanPreroll = 0x00000010,
        /// <summary>
        /// The first stream sink (index 0) is a reference stream. The reference stream must have a media type before 
        /// the media types can be set on the other stream sinks.
        /// </summary>
        RequireReferenceMediaType = 0x00000020
    }

}
