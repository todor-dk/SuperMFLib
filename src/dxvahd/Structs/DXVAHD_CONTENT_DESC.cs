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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.dxvahd
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Describes a video stream for a Microsoft DirectX Video Acceleration High Definition (DXVA-HD) video
    /// processor.
    /// <para />
    /// The display driver can use the information in this structure to optimize the capabilities of the
    /// video processor. For example, some capabilities might not be exposed for high-definition (HD)
    /// content, for performance reasons.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_CONTENT_DESC {
    ///   DXVAHD_FRAME_FORMAT InputFrameFormat;
    ///   DXVAHD_RATIONAL     InputFrameRate;
    ///   UINT                InputWidth;
    ///   UINT                InputHeight;
    ///   DXVAHD_RATIONAL     OutputFrameRate;
    ///   UINT                OutputWidth;
    ///   UINT                OutputHeight;
    /// } DXVAHD_CONTENT_DESC;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9319A98D-8F43-4F29-8787-18DEC53DFF88(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9319A98D-8F43-4F29-8787-18DEC53DFF88(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_CONTENT_DESC")]
    public struct DXVAHD_CONTENT_DESC
    {
        /// <summary>
        /// A member of the <see cref="dxvahd.DXVAHD_FRAME_FORMAT" /> enumeration that describes how the video
        /// stream is interlaced.
        /// </summary>
        public DXVAHD_FRAME_FORMAT InputFrameFormat;
        /// <summary>
        /// The frame rate of the input video stream, specified as a <see cref="dxvahd.DXVAHD_RATIONAL" />
        /// structure.
        /// </summary>
        public DXVAHD_RATIONAL InputFrameRate;
        /// <summary>
        /// The width of the input frames, in pixels.
        /// </summary>
        public int InputWidth;
        /// <summary>
        /// The height of the input frames, in pixels.
        /// </summary>
        public int InputHeight;
        /// <summary>
        /// The frame rate of the output video stream, specified as a <see cref="dxvahd.DXVAHD_RATIONAL" />
        /// structure.
        /// </summary>
        public DXVAHD_RATIONAL OutputFrameRate;
        /// <summary>
        /// The width of the output frames, in pixels.
        /// </summary>
        public int OutputWidth;
        /// <summary>
        /// The height of the output frames, in pixels.
        /// </summary>
        public int OutputHeight;
    }

#endif

}
