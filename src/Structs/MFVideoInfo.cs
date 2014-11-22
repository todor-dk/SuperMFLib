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
    /// Contains video format information that applies to both compressed and uncompressed formats.
    /// <para />
    /// This structure is used in the <see cref="MFVideoFormat" /> structure.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MFVideoInfo {
    ///   DWORD                    dwWidth;
    ///   DWORD                    dwHeight;
    ///   MFRatio                  PixelAspectRatio;
    ///   MFVideoChromaSubsampling SourceChromaSubsampling;
    ///   MFVideoInterlaceMode     InterlaceMode;
    ///   MFVideoTransferFunction  TransferFunction;
    ///   MFVideoPrimaries         ColorPrimaries;
    ///   MFVideoTransferMatrix    TransferMatrix;
    ///   MFVideoLighting          SourceLighting;
    ///   MFRatio                  FramesPerSecond;
    ///   MFNominalRange           NominalRange;
    ///   MFVideoArea              GeometricAperture;
    ///   MFVideoArea              MinimumDisplayAperture;
    ///   MFVideoArea              PanScanAperture;
    ///   unsigned __int64         VideoFlags;
    /// } MFVideoInfo;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/746FD84F-58F8-42AB-BCF7-8FD18DCD02AF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/746FD84F-58F8-42AB-BCF7-8FD18DCD02AF(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 8), UnmanagedName("MFVideoInfo")]
    public struct MFVideoInfo
    {
        /// <summary>
        /// Width of the decoded image, in pixels.
        /// </summary>
        public int dwWidth;
        /// <summary>
        /// Height of the decoded image, in pixels.
        /// </summary>
        public int dwHeight;
        /// <summary>
        /// Pixel aspect ratio, specified as an <see cref="MFRatio" /> structure.
        /// </summary>
        public MFRatio PixelAspectRatio;
        /// <summary>
        /// Chroma sub-sampling of the original image, specified as a member of the
        /// <see cref="MFVideoChromaSubsampling" /> enumeration.
        /// </summary>
        public MFVideoChromaSubsampling SourceChromaSubsampling;
        /// <summary>
        /// Image interlacing, specified as a member of the <see cref="MFVideoInterlaceMode" /> enumeration.
        /// </summary>
        public MFVideoInterlaceMode InterlaceMode;
        /// <summary>
        /// R'G'B' gamma curve function, specified as a member of the <see cref="MFVideoTransferFunction" />
        /// enumeration.
        /// </summary>
        public MFVideoTransferFunction TransferFunction;
        /// <summary>
        /// Color primaries of the video source, specified as a member of the <see cref="MFVideoPrimaries" />
        /// enumeration. This value provides the conversion from R'G'B' to linear RGB.
        /// </summary>
        public MFVideoPrimaries ColorPrimaries;
        /// <summary>
        /// Conversion matrix from Y'Cb'Cr' to R'G'B, specified as a member of the
        /// <see cref="MFVideoTransferMatrix" /> enumeration.
        /// </summary>
        public MFVideoTransferMatrix TransferMatrix;
        /// <summary>
        /// Intended viewing conditions, specified as a member of the <see cref="MFVideoLighting" />
        /// enumeration.
        /// </summary>
        public MFVideoLighting SourceLighting;
        /// <summary>
        /// Frames per second, specified as an <see cref="MFRatio" /> structure. If the frame rate is unknown or
        /// variable, the numerator and denominator should both be set to zero. It is invalid for only one
        /// member of the <strong>MFRatio</strong> structure to be zero.
        /// </summary>
        public MFRatio FramesPerSecond;
        /// <summary>
        /// Range of valid RGB values, specified as a member of the <see cref="MFNominalRange" /> enumeration.
        /// The value indicates whether color values contain headroom and toeroom.
        /// </summary>
        public MFNominalRange NominalRange;
        /// <summary>
        /// Geometric aperture, specified as an <see cref="MFVideoArea" /> structure. For more information, see
        /// <see cref="MFAttributesClsid.MF_MT_GEOMETRIC_APERTURE" />.
        /// </summary>
        public MFVideoArea GeometricAperture;
        /// <summary>
        /// The display aperture, specified as an <see cref="MFVideoArea" /> structure. The display aperture is
        /// the region of the video image that is intended to be shown. Any data outside of this area is the
        /// overscan region. For more information, see
        /// <see cref="MFAttributesClsid.MF_MT_MINIMUM_DISPLAY_APERTURE" />.
        /// </summary>
        public MFVideoArea MinimumDisplayAperture;
        /// <summary>
        /// Pan-scan rectangle, specified as an <see cref="MFVideoArea" /> structure. The pan-scan rectangle
        /// defines a region of the image that is displayed in pan-and-scan mode. It can be used when
        /// wide-screen content is shown on a 4 x 3 display. The value is valid only when the <strong>
        /// VideoFlags</strong> member contains the MFVideoFlag_PanScanEnabled flag.
        /// </summary>
        public MFVideoArea PanScanAperture;
        /// <summary>
        /// Bitwise <strong>OR</strong> of zero or more flags from the <see cref="MFVideoFlags" /> enumeration.
        /// </summary>
        public MFVideoFlags VideoFlags;
    }

}
