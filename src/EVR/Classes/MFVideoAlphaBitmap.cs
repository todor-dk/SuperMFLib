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

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.Transform;
using System.Drawing;

namespace MediaFoundation.EVR
{


    /// <summary>
    /// Specifies a bitmap for the enhanced video renderer (EVR) to alpha-blend with the video.
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct MFVideoAlphaBitmap {
    ///   BOOL                     GetBitmapFromDC;
    ///   union {
    ///     HDC               hdc;
    ///     IDirect3DSurface9 *pDDs;
    ///   } bitmap;
    ///   MFVideoAlphaBitmapParams params;
    /// } MFVideoAlphaBitmap;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/609041F2-7BA4-4157-819B-4AC21612DCA2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/609041F2-7BA4-4157-819B-4AC21612DCA2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MFVideoAlphaBitmap")]
    public class MFVideoAlphaBitmap
    {
        /// <summary>
        /// If <c>TRUE</c>, the hdc member is used. Otherwise, the <c>pDDs</c> member is used.
        /// </summary>
        public bool GetBitmapFromDC;
        /// <summary>
        /// A union that contains the following members.
        /// <para/>
        /// <c>hdc</c> Handle to the device context (DC) of a GDI bitmap. 
        /// If <see cref="GetBitmapFromDC"/> is <c>FALSE</c>, this member is ignored.
        /// <para/>
        /// <c>pDDs</c> Pointer to the <see cref="dxvahd.IDirect3DSurface9"/> interface of a Direct3D surface that 
        /// contains the bitmap. If <see cref="GetBitmapFromDC"/> is <c>TRUE</c>, this member is ignored.
        /// </summary>
        public IntPtr stru;
        /// <summary>
        /// <see cref="MFVideoAlphaBitmapParams"/> structure that specifies the parameters for the alpha-blending operation.
        /// </summary>
        public MFVideoAlphaBitmapParams @paras;
    }

}
