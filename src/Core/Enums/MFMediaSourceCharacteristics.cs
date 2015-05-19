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
    /// Defines the characteristics of a media source. These flags are retrieved by the 
    /// <see cref="IMFMediaSource.GetCharacteristics"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/115F4A6B-99C2-436E-9483-C44003E61A7D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/115F4A6B-99C2-436E-9483-C44003E61A7D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MFMEDIASOURCE_CHARACTERISTICS")]
    public enum MFMediaSourceCharacteristics
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// This flag indicates a data source that runs constantly, such as a live presentation. If the source
        /// is stopped and then restarted, there will be a gap in the content. 
        /// </summary>
        IsLive = 0x1,
        /// <summary>
        /// The media source supports seeking. 
        /// </summary>
        CanSeek = 0x2,
        /// <summary>
        /// The source can pause. 
        /// </summary>
        CanPause = 0x4,
        /// <summary>
        /// The media source downloads content. It might take a long time to seek to parts of the content that
        /// have not been downloaded. 
        /// </summary>
        HasSlowSeek = 0x8,
        /// <summary>
        /// The media source delivers a playlist, which might contain more than one entry. After the first
        /// playlist entry has completed, the media source signals the start of each new playlist entry by
        /// sending an <c>MENewPresentation</c> event. The event contains a presentation descriptor for the
        /// entry. 
        /// <para/>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// </summary>
        HasMultiplePresentations = 0x10,
        /// <summary>
        /// The media source can skip forward in the playlist. Applies only if the
        /// MFMEDIASOURCE_HAS_MULTIPLE_PRESENTATIONS flag is present. 
        /// <para/>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// </summary>
        CanSkipForward = 0x20,
        /// <summary>
        /// The media source can skip backward in the playlist.
        /// <para/>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// </summary>
        CanSkipBackward = 0x40,
        /// <summary>
        /// The media source is not currently using the network to receive the content. Networking hardware may
        /// enter a power saving state when this bit is set.
        /// <para/>
        /// <strong>Note</strong> Requires Windows 8 or later. 
        /// </summary>
        DoesNotUseNetwork = 0x80
    }
}
