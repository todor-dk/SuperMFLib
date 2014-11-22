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

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation
{


    /// <summary>
    /// Describes a video format.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MFVIDEOFORMAT {
    ///   DWORD                 dwSize;
    ///   MFVideoInfo           videoInfo;
    ///   GUID                  guidFormat;
    ///   MFVideoCompressedInfo compressedInfo;
    ///   MFVideoSurfaceInfo    surfaceInfo;
    /// } MFVIDEOFORMAT;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/7FBC4A35-117C-4F0C-9E9B-FF44E30A1618(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/7FBC4A35-117C-4F0C-9E9B-FF44E30A1618(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 8), UnmanagedName("MFVIDEOFORMAT")]
    public class MFVideoFormat
    {
        /// <summary>
        /// Size of the structure, in bytes. This value includes the size of the palette entries that may
        /// appear after the <strong>surfaceInfo</strong> member. 
        /// </summary>
        public int dwSize;
        /// <summary>
        /// <see cref="MFVideoInfo"/> structure. This structure contains information that applies to both
        /// compressed and uncompressed formats. 
        /// </summary>
        public MFVideoInfo videoInfo;
        /// <summary>
        /// Video subtype. See <c>Video Subtype GUIDs</c>. 
        /// </summary>
        public Guid guidFormat;
        /// <summary>
        /// <see cref="MFVideoCompressedInfo"/> structure. This structure contains information that applies
        /// only to compressed formats. 
        /// </summary>
        public MFVideoCompressedInfo compressedInfo;
        /// <summary>
        /// <see cref="MFVideoSurfaceInfo"/> structure. This structure contains information that applies only
        /// to uncompressed formats. 
        /// </summary>
        public MFVideoSurfaceInfo surfaceInfo;
    }

}
