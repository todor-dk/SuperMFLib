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

namespace MediaFoundation.EVR.Enums
{
    #if NOT_IN_USE


    /// <summary>
    /// Defines flags for the <see cref="EVR.MFVideoAlphaBitmapParams"/> structure. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D9989C44-8A3C-4F8B-A63D-E39E26797935(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D9989C44-8A3C-4F8B-A63D-E39E26797935(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MFVideoAlphaBitmapFlags")]
    internal enum MFVideoAlphaBitmapFlags
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// Alpha-blend the entire DirectDraw suface.
        /// <para/>
        /// If you are alpha-blending a DirectDraw surface, you can set this flag when you call 
        /// <see cref="EVR.IMFVideoMixerBitmap.SetAlphaBitmap"/>. If this flag is set, the mixer ignores the 
        /// <strong>rcSrc</strong> member of the <see cref="EVR.MFVideoAlphaBitmapParams"/> structure. If this
        /// flag is absent, the <strong>rcSrc</strong> member specifies the source rectangle. 
        /// <para/>
        /// This flag cannot be used if you specify a GDI bitmap for alpha-blending. For a GDI bitmap, you must
        /// fill in the <strong>rcSrc</strong> member when you call <c>SetAlphaBitmap</c>. 
        /// <para/>
        /// This flag does not apply to the <see cref="EVR.IMFVideoMixerBitmap.UpdateAlphaBitmapParameters"/>
        /// method. 
        /// </summary>
        EntireDDS = 0x00000001,
        /// <summary>
        /// If this flag is set, the <strong>clrSrcKey</strong> member of the 
        /// <see cref="EVR.MFVideoAlphaBitmapParams"/> structure specifies a color key for alpha-blending. If
        /// this flag is absent, the <strong>clrSrcKey</strong> member is ignored. 
        /// <para/>
        /// This flag is not valid if you are alpha-blending a Direct3D surface with per-pixel alpha
        /// (D3DFMT_A8R8G8B8). When the DirectDraw surface has per-pixel alpha, the pixel alpha values are used
        /// for the alpha-blending operation.
        /// </summary>
        SrcColorKey = 0x00000002,
        /// <summary>
        /// Update the source rectangle.
        /// <para/>
        /// This flag applies to the <c>UpdateAlphaBitmapParameters</c> method. If this flag is set, the 
        /// <strong>rcSrc</strong> member of the <see cref="EVR.MFVideoAlphaBitmapParams"/> structure updates
        /// the source rectangle. If this flag is absent, the <strong>rcSrc</strong> member is ignored. By
        /// setting this flag, you can animate the image by selecting different portions of the bitmap. 
        /// <para/>
        /// This flag does not apply to the <c>SetAlphaBitmap</c> method. 
        /// </summary>
        SrcRect = 0x00000004,
        /// <summary>
        /// If this flag is set, the <strong>nrcDest</strong> member of the 
        /// <see cref="EVR.MFVideoAlphaBitmapParams"/> structure specifies a normalized rectangle for scaling
        /// the bitmap. If this flag is absent, the <strong>nrcDest</strong> member is ignored. 
        /// </summary>
        DestRect = 0x00000008,
        /// <summary>
        /// If this flag is set, the <strong>dwFilterMode</strong> member of the 
        /// <see cref="EVR.MFVideoAlphaBitmapParams"/> structure specifies a Direct3D filtering mode. If this
        /// flag is absent, the <strong>dwFilterMode</strong> member is ignored. 
        /// </summary>
        FilterMode = 0x00000010,
        /// <summary>
        /// If this flag is set, the <strong>fAlpha</strong> member of the 
        /// <see cref="EVR.MFVideoAlphaBitmapParams"/> structure specifies an alpha value to apply to the
        /// entire image. If this flag is absent, the <strong>fAlpha</strong> member is ignored. 
        /// </summary>
        Alpha = 0x00000020,
        /// <summary>
        /// Bitmask to validate flag values. This value is not a valid flag.
        /// </summary>
        BitMask = 0x0000003f
    }
#endif
}
