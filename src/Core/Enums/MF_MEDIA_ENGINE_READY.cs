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
using System.Runtime.InteropServices;

using MediaFoundation.Misc;
using MediaFoundation.EVR;
using MediaFoundation.Transform;

namespace MediaFoundation.Core.Enums
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Defines ready-state values for the Media Engine.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/ADA5BBD6-B831-4C19-8770-318F0C5FDD6F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ADA5BBD6-B831-4C19-8770-318F0C5FDD6F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_MEDIA_ENGINE_READY")]
    internal enum MF_MEDIA_ENGINE_READY : short
    {
        /// <summary>
        /// No data is available.
        /// </summary>
        HaveNothing = 0,
        /// <summary>
        /// Some metadata is available, including the duration and, for video files, the video dimensions. No
        /// media data is available.
        /// </summary>
        HaveMetadata = 1,
        /// <summary>
        /// There is media data  for the current playback position, but not enough data for playback or
        /// seeking.
        /// </summary>
        HaveCurrentData = 2,
        /// <summary>
        /// There is enough media data to enable some playback or seeking. The amount of data might be a little
        /// as the next video frame.
        /// </summary>
        HaveFutureData = 3,
        /// <summary>
        /// There is enough data to play the resource, based on the current rate at which the resource is being
        /// fetched. 
        /// </summary>
        HaveEnoughData = 4
    }

#endif

}
