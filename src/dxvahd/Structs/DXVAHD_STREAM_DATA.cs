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
    /// Contains per-stream data for the <see cref="dxvahd.IDXVAHD_VideoProcessor.VideoProcessBltHD" />
    /// method.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_STREAM_DATA {
    ///   BOOL              Enable;
    ///   UINT              OutputIndex;
    ///   UINT              InputFrameOrField;
    ///   UINT              PastFrames;
    ///   UINT              FutureFrames;
    ///   IDirect3DSurface9 **ppPastSurfaces;
    ///   IDirect3DSurface9 *pInputSurface;
    ///   IDirect3DSurface9 **ppFutureSurfaces;
    /// } DXVAHD_STREAM_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/95D74C87-5884-4004-926F-108E9BBB012D(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/95D74C87-5884-4004-926F-108E9BBB012D(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_STREAM_DATA")]
    public struct DXVAHD_STREAM_DATA
    {
        /// <summary>
        /// Specifies whether this input stream is enabled. If the value is <strong>TRUE</strong>, the
        /// <c>VideoProcessBltHD</c> method blits this stream to the output surface <strong></strong>.
        /// Otherwise, the stream is not blitted. The maximum number of streams that can be enabled at one time
        /// is given in the <strong>MaxInputStreams</strong> member of the
        /// <see cref="dxvahd.DXVAHD_VPDEVCAPS" /> structure.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool Enable;
        /// <summary>
        /// The zero-based index number of the output frame. See Remarks.
        /// </summary>
        public int OutputIndex;
        /// <summary>
        /// The zero-based index number of the input frame or field. See Remarks.
        /// </summary>
        public int InputFrameOrField;
        /// <summary>
        /// The number of past reference frames. This value must be less than or equal to the value of the
        /// <strong>PastFrames</strong> member of the <see cref="dxvahd.DXVAHD_VPCAPS" /> structure.
        /// </summary>
        public int PastFrames;
        /// <summary>
        /// The number of future reference frames. This value must be less than or equal to the value of the
        /// <strong>FutureFrames</strong> member of the <see cref="dxvahd.DXVAHD_VPCAPS" /> structure.
        /// </summary>
        public int FutureFrames;
        /// <summary>
        /// A pointer to an array of <see cref="dxvahd.IDirect3DSurface9" /> pointers, allocated by the caller.
        /// This array contains the past reference frames for the video processing operation. The number of
        /// elements in the array is equal to the value of the <strong>PastFrames</strong> member.
        /// </summary>
        public IDirect3DSurface9[] ppPastSurfaces;
        /// <summary>
        /// A pointer to the <see cref="dxvahd.IDirect3DSurface9" /> interface of a Microsoft Direct3D surface
        /// that contains the current input frame.
        /// </summary>
        public IDirect3DSurface9 pInputSurface;
        /// <summary>
        /// A pointer to an array of <see cref="dxvahd.IDirect3DSurface9" /> pointers, allocated by the caller.
        /// This array contains the future reference frames for the video processing operation. The number of
        /// elements in the array is equal to the value of the <strong>FutureFrames</strong> member.
        /// </summary>
        public IDirect3DSurface9[] ppFutureSurfaces;
    }

#endif

}
