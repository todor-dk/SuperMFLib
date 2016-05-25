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

namespace MediaFoundation.Core.Structs
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Contains information about the audio and video streams for the transcode sink activation object.
    /// <para />
    /// To get the information stored in this structure, call
    /// <see cref="IMFTranscodeSinkInfoProvider.GetSinkInfo" />.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MF_TRANSCODE_SINK_INFO {
    ///   DWORD        dwVideoStreamID;
    ///   IMFMediaType *pVideoMediaType;
    ///   DWORD        dwAudioStreamID;
    ///   IMFMediaType *pAudioMediaType;
    /// } MF_TRANSCODE_SINK_INFO;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B8F66128-88D5-4FE0-99F3-59621080BE5C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B8F66128-88D5-4FE0-99F3-59621080BE5C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MF_TRANSCODE_SINK_INFO")]
    internal struct MFTranscodeSinkInfo
    {
        /// <summary>
        /// The stream identifier of the video stream.
        /// </summary>
        public int dwVideoStreamID;
        /// <summary>
        /// A pointer to the <see cref="IMFMediaType" /> interface of the media type for the video stream. This
        /// member can be <strong>NULL</strong>.
        /// </summary>
        public IMFMediaType pVideoMediaType;
        /// <summary>
        /// The stream identifier of the audio stream.
        /// </summary>
        public int dwAudioStreamID;
        /// <summary>
        /// A pointer to the <see cref="IMFMediaType" /> interface of the media type for the audio stream. This
        /// member can be <strong>NULL</strong>.
        /// </summary>
        public IMFMediaType pAudioMediaType;
    }

#endif

}
