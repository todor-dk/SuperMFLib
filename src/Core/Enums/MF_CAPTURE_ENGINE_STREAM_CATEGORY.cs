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
using MediaFoundation.EVR;

namespace MediaFoundation.Core.Enums
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Defines the values for the source stream category.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/F82CFF90-CFA5-4000-A0E6-547042EDE02F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F82CFF90-CFA5-4000-A0E6-547042EDE02F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_CAPTURE_ENGINE_STREAM_CATEGORY")]
    internal enum MF_CAPTURE_ENGINE_STREAM_CATEGORY
    {
        /// <summary>
        /// Specifies a video preview stream.
        /// </summary>
        VideoPreview = 0x00000000,
        /// <summary>
        /// Specifies a video capture stream.
        /// </summary>
        VideoCapture = 0x00000001,
        /// <summary>
        /// Specifies an independent photo stream.
        /// </summary>
        PhotoIndependent = 0x00000002,
        /// <summary>
        /// Specifies a dependent photo stream.
        /// </summary>
        PhotoDependent = 0x00000003,
        /// <summary>
        /// Specifies an audio stream.
        /// </summary>
        Audio = 0x00000004,
        /// <summary>
        /// Specifies an unsupported stream.
        /// </summary>
        Unsupported = 0x00000005
    }

#endif

}
