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
    /// Specifies how the enhanced video renderer (EVR) alpha-blends a bitmap with the video.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct MFVideoAlphaBitmapParams {
    ///   DWORD                 dwFlags;
    ///   COLORREF              clrSrcKey;
    ///   RECT                  rcSrc;
    ///   MFVideoNormalizedRect nrcDest;
    ///   FLOAT                 fAlpha;
    ///   DWORD                 dwFilterMode;
    /// } MFVideoAlphaBitmapParams;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3A7F67FA-CA54-4B6F-9CFC-E8EBA57F00CE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3A7F67FA-CA54-4B6F-9CFC-E8EBA57F00CE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("MFVideoAlphaBitmapParams")]
    public class MFVideoAlphaBitmapParams
    {
        /// <summary>
        /// Bitwise OR of one or more flags from the <see cref="EVR.MFVideoAlphaBitmapFlags"/> enumeration.
        /// These flags indicate which of the other structure members contain valid information. 
        /// </summary>
        public MFVideoAlphaBitmapFlags dwFlags;
        /// <summary>
        /// Source color key. This member is used if the <strong>dwFlags</strong> member contains the
        /// MFVideoAlphaBitmap_SrcColorKey flag. Any pixels in the bitmap that match the color key are rendered
        /// as transparent pixels. 
        /// <para/>
        /// You cannot specify a color key if you are alpha-blending a Direct3D surface with per-pixel alpha
        /// (D3DFMT_A8R8G8B8).
        /// </summary>
        public int clrSrcKey;
        /// <summary>
        /// Source rectangle. The source rectangle defines the region of the bitmap that is alpha-blended with
        /// the video. The source rectangle is given in pixels and is relative to the original bitmap.
        /// <para/>
        /// If you are alpha-blending a GDI bitmap, you must fill in this structure when you call 
        /// <see cref="EVR.IMFVideoMixerBitmap.SetAlphaBitmap"/>. 
        /// <para/>
        /// If you are alpha-blending a Direct3D surface and the <strong>dwFlags</strong> member contains the
        /// MFVideoAlphaBitmap_EntireDDS flag, the <strong>rcSrc</strong> member is ignored. If the flag is
        /// absent, you must fill in the <strong>rcSrc</strong> member. 
        /// <para/>
        /// After setting the initiali bitmap, you can update the source rectangle by calling 
        /// <see cref="EVR.IMFVideoMixerBitmap.UpdateAlphaBitmapParameters"/>. To update the source rectangle,
        /// set the MFVideoAlphaBitmap_SrcColorKey flag in the <strong>dwFlags</strong> member. 
        /// <para/>
        /// The source rectangle cannot be an empty rectangle, and cannot exceed the bounds of the bitmap.
        /// </summary>
        public MFRect rcSrc;
        /// <summary>
        /// Destination rectangle. The destination rectangle defines the region of the composited video image
        /// that receives the alpha-blended bitmap. The destination rectangle is specified as a normalized
        /// rectangle using the <see cref="EVR.MFVideoNormalizedRect"/> structure. 
        /// <para/>
        /// This member is used if the <strong>dwFlags</strong> member contains the MFVideoAlphaBitmap_DestRect
        /// flag. Otherwise, the default destination rectangle is {0, 0, 1, 1}. 
        /// </summary>
        public MFVideoNormalizedRect nrcDest;
        /// <summary>
        /// Alpha blending value. This member is used if the <strong>dwFlags</strong> member contains the
        /// MFVideoAlphaBitmap_Alpha flag. Otherwise, the default value is 1.0 (opaque). The valid range is 0.0
        /// to 1.0, inclusive. 
        /// <para/>
        /// This value is applied to the entire bitmap image. To create transparent regions, use the <strong>
        /// clrSrcKey</strong> member or use a DirectDraw surface with per-pixel alpha. 
        /// </summary>
        public float fAlpha;
        /// <summary>
        /// Direct3D filtering mode to use when performing the alpha-blend operation. Specify the filter mode
        /// as a D3DTEXTUREFILTERTYPE value. For more information, see the Direct3D documentation.
        /// <para/>
        /// This member is used if the <strong>dwFlags</strong> member contains the
        /// MFVideoAlphaBitmap_FilterMode flag. Otherwise, the default value is D3DTEXF_POINT. 
        /// <para/>
        /// Point filtering is particularly useful for images that contain text and will not be stretched.
        /// </summary>
        public int dwFilterMode;
    }

}
