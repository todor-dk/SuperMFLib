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

// This file is a mess.  While technically part of MF, I'm in no hurry
// to try to get this to work.

using System;
using System.Runtime.InteropServices;
using System.Security;

using MediaFoundation.Misc;

namespace MediaFoundation.Core.Structs
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains encoding statistics from the Digital Living Network Alliance (DLNA) media sink.
    /// <para />
    /// This structure is used with the <see cref="MFAttributesClsid.MF_MP2DLNA_STATISTICS" /> attribute.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MFMPEG2DLNASINKSTATS {
    ///   DWORDLONG cBytesWritten;
    ///   BOOL      fPAL;
    ///   DWORD     fccVideo;
    ///   DWORD     dwVideoWidth;
    ///   DWORD     dwVideoHeight;
    ///   DWORDLONG cVideoFramesReceived;
    ///   DWORDLONG cVideoFramesEncoded;
    ///   DWORDLONG cVideoFramesSkipped;
    ///   DWORDLONG cBlackVideoFramesEncoded;
    ///   DWORDLONG cVideoFramesDuplicated;
    ///   DWORD     cAudioSamplesPerSec;
    ///   DWORD     cAudioChannels;
    ///   DWORDLONG cAudioBytesReceived;
    ///   DWORDLONG cAudioFramesEncoded;
    /// } MFMPEG2DLNASINKSTATS;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/40D7DB61-CF27-4C27-8774-D565EBEE2C93(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/40D7DB61-CF27-4C27-8774-D565EBEE2C93(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MFMPEG2DLNASINKSTATS")]
    internal struct MFMPEG2DLNASINKSTATS
    {
        /// <summary>
        /// Total number of bytes written to the byte stream.
        /// </summary>
        long cBytesWritten;
        /// <summary>
        /// If <strong>TRUE</strong>, the video stream is a PAL format. Otherwise, the video stream is an NTSC
        /// format.
        /// </summary>
        bool fPAL;
        /// <summary>
        /// A FOURCC code that specifies the video format.
        /// </summary>
        int fccVideo;
        /// <summary>
        /// The width of the video frame, in pixels.
        /// </summary>
        int dwVideoWidth;
        /// <summary>
        /// The height of the video frame, in pixels.
        /// </summary>
        int dwVideoHeight;
        /// <summary>
        /// The number of video frames received.
        /// </summary>
        long cVideoFramesReceived;
        /// <summary>
        /// The number of video frames that have been encoded.
        /// </summary>
        long cVideoFramesEncoded;
        /// <summary>
        /// The number of video frames that have been skipped.
        /// </summary>
        long cVideoFramesSkipped;
        /// <summary>
        /// The number of black frames that have been encoded.
        /// </summary>
        long cBlackVideoFramesEncoded;
        /// <summary>
        /// The number of duplicated video frames.
        /// </summary>
        long cVideoFramesDuplicated;
        /// <summary>
        /// The audio sample rate, in samples per second.
        /// </summary>
        int cAudioSamplesPerSec;
        /// <summary>
        /// The number of audio channels.
        /// </summary>
        int cAudioChannels;
        /// <summary>
        /// The total amount of audio data received, in bytes.
        /// </summary>
        long cAudioBytesReceived;
        /// <summary>
        /// The number of audio frames that have been encoded.
        /// </summary>
        long cAudioFramesEncoded;
    }

#endif

}
