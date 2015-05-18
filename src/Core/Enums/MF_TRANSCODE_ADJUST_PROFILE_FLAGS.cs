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
    /// Defines the profile flags that are set in the 
    /// <see cref="MFAttributesClsid.MF_TRANSCODE_ADJUST_PROFILE"/> attribute. 
    /// <para/>
    /// These flags are checked by <see cref="MFExtern.MFCreateTranscodeTopology"/> during topology
    /// building. Based on these flags, <strong>MFCreateTranscodeTopology</strong> adjusts the transcode
    /// profile by modifying the configuration settings for the streams according to the input requirements
    /// of the encoder used in the topology. 
    /// <para/>
    /// For more information about the stream settings that an application can specify, see 
    /// <c>Using the Transcode API</c>. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/65D7350F-A9D9-43C0-B3B6-C6169A727B4E(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/65D7350F-A9D9-43C0-B3B6-C6169A727B4E(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MF_TRANSCODE_ADJUST_PROFILE_FLAGS")]
    internal enum MF_TRANSCODE_ADJUST_PROFILE_FLAGS
    {
        /// <summary>
        /// Media Foundation uses the application-specified settings for audio and video streams. If the
        /// required settings are not provided by the application, the topology is created but the encoding
        /// session fails. For the video stream, the frame rate and the interlace mode settings are modified.
        /// For more information, see Remarks. 
        /// </summary>
        Default = 0,
        /// <summary>
        /// For both audio and video streams, the missing stream settings are filled by copying the input
        /// source attributes. This flag ensures the transcoded output file is the closest match to the input
        /// file.
        /// </summary>
        UseSourceAttributes = 1
    }

#endif

}
