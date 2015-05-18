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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation.ReadWrite.Enums
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// This enumerator contains special stream index values 
    /// that are used with functions that expect stream indexes.
    /// </summary>
    [UnmanagedName("Unnamed enum")]
    internal enum MF_SOURCE_READER
    {
        /// <summary>
        /// Indicates an invalid stream index.
        /// </summary>
        InvalidStreamIndex = unchecked((int)0xFFFFFFFF),
        /// <summary>
        /// All streams.
        /// </summary>
        AllStreams = unchecked((int)0xFFFFFFFE),
        /// <summary>
        /// Get the next available sample, regardless of which stream.
        /// </summary>
        AnyStream = unchecked((int)0xFFFFFFFE),
        /// <summary>
        /// The first audio stream.
        /// </summary>
        FirstAudioStream = unchecked((int)0xFFFFFFFD),
        /// <summary>
        /// The first video stream.
        /// </summary>
        FirstVideoStream = unchecked((int)0xFFFFFFFC),

        /// <summary>
        /// <i>***** Documentation Missing *****</i>.
        /// </summary>
        FirstSourcePhotoStream = unchecked((int)0xFFFFFFFB),
        /// <summary>
        /// The preferred stream for previewing video.
        /// </summary>
        PreferredSourceVideoStreamForPreview = unchecked((int)0xFFFFFFFA),
        /// <summary>
        /// The preferred stream for recording video.
        /// </summary>
        PreferredSourceVideoStreamForRecord = unchecked((int)0xFFFFFFF9),
        /// <summary>
        /// Same as <see cref="PreferredSourceStreamForPhoto"/>.
        /// </summary>
        FirstSourceIndependentPhotoStream = unchecked((int)0xFFFFFFF8),
        /// <summary>
        /// The preferred stream for recording video.
        /// </summary>
        PreferredSourceStreamForVideoRecord = unchecked((int)0xFFFFFFF9),
        /// <summary>
        /// The first independent photo stream if present, or else the same stream chosen by 
        /// <see cref="PreferredSourceVideoStreamForPreview"/>.
        /// </summary>
        PreferredSourceStreamForPhoto = unchecked((int)0xFFFFFFF8),
        /// <summary>
        /// The first available audio stream.
        /// </summary>
        PreferredSourceStreamForAudio = unchecked((int)0xFFFFFFF7),

        /// <summary>
        /// If this flag is set, the method queries the media source. 
        /// </summary>
        MediaSource = unchecked((int)0xFFFFFFFF),
    }

#endif

}
