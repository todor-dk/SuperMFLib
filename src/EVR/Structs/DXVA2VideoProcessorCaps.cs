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

namespace MediaFoundation.EVR.Structs
{
#if NOT_IN_USE

    /// <summary>
    /// Describes the capabilities of a DirectX Video Acceleration (DVXA) video processor mode.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVA2_VideoProcessorCaps {
    ///   UINT    DeviceCaps;
    ///   D3DPOOL InputPool;
    ///   UINT    NumForwardRefSamples;
    ///   UINT    NumBackwardRefSamples;
    ///   UINT    Reserved;
    ///   UINT    DeinterlaceTechnology;
    ///   UINT    ProcAmpControlCaps;
    ///   UINT    VideoProcessorOperations;
    ///   UINT    NoiseFilterTechnology;
    ///   UINT    DetailFilterTechnology;
    /// } DXVA2_VideoProcessorCaps;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/CFF01719-E653-4EA1-A177-9A6948B0DA56(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CFF01719-E653-4EA1-A177-9A6948B0DA56(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVA2_VideoProcessorCaps")]
    internal struct DXVA2VideoProcessorCaps
    {
        /// <summary>
        /// Identifies the type of device. The following values are defined.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term><strong>DXVA2_VPDev_EmulatedDXVA1</strong></term><description>DXVA 2.0 video processing is emulated by using DXVA 1.0. An emulated device may be missing significant processing capabilities and have lower image quality and performance.</description></item><item><term><strong>DXVA2_VPDev_HardwareDevice</strong></term><description>Hardware device.</description></item><item><term><strong>DXVA2_VPDev_SoftwareDevice</strong></term><description>Software device.</description></item></list>
        /// </summary>
        public int DeviceCaps;
        /// <summary>
        /// The Direct3D memory pool used by the device.
        /// </summary>
        public int InputPool;
        /// <summary>
        /// Number of forward reference samples the device needs to perform deinterlacing. For the bob,
        /// progressive scan, and software devices, the value is zero.
        /// </summary>
        public int NumForwardRefSamples;
        /// <summary>
        /// Number of backward reference samples the device needs to perform deinterlacing. For the bob,
        /// progressive scan, and software devices, the value is zero.
        /// </summary>
        public int NumBackwardRefSamples;
        /// <summary>
        /// Reserved. Must be zero.
        /// </summary>
        public int Reserved;
        /// <summary>
        /// Identifies the deinteracing technique used by the device. This value is a bitwise <strong>OR
        /// </strong> of one or more of the following flags.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term><strong>DXVA2_DeinterlaceTech_Unknown</strong></term><description>The algorithm is unknown or proprietary.</description></item><item><term><strong>DXVA2_DeinterlaceTech_BOBLineReplicate</strong></term><description>The algorithm creates missing lines by repeating the line either above or below the missing line. This algorithm produces a jagged image and is not recommended.</description></item><item><term><strong>DXVA2_DeinterlaceTech_BOBVerticalStretch</strong></term><description>The algorithm creates missing lines by averaging two lines. Slight vertical adjustments are made so that the resulting image does not bob up and down.</description></item><item><term><strong>DXVA2_DeinterlaceTech_BOBVerticalStretch4Tap</strong></term><description>The algorithm creates missing lines by applying a [?1, 9, 9, ?1]/16 filter across four lines. Slight vertical adjustments are made so that the resulting image does not bob up and down.</description></item><item><term><strong>DXVA2_DeinterlaceTech_MedianFiltering</strong></term><description>The algorithm uses median filtering to recreate the pixels in the missing lines.</description></item><item><term><strong>DXVA2_DeinterlaceTech_EdgeFiltering</strong></term><description>The algorithm uses an edge filter to create the missing lines. In this process, spatial directional filters are applied to determine the orientation of edges in the picture content. Missing pixels are created by filtering along (rather than across) the detected edges.</description></item><item><term><strong>DXVA2_DeinterlaceTech_FieldAdaptive</strong></term><description>The algorithm uses spatial or temporal interpolation, switching between the two on a field-by-field basis, depending on the amount of motion.</description></item><item><term><strong>DXVA2_DeinterlaceTech_PixelAdaptive</strong></term><description>The algorithm uses spatial or temporal interpolation, switching between the two on a pixel-by-pixel basis, depending on the amount of motion.</description></item><item><term><strong>DXVA2_DeinterlaceTech_MotionVectorSteered</strong></term><description>The algorithm identifies objects within a sequence of video fields. Before it recreates the missing pixels, it aligns the movement axes of the individual objects in the scene to make them parallel with the time axis.</description></item><item><term><strong>DXVA2_DeinterlaceTech_InverseTelecine</strong></term><description>The device can undo the 3:2 pulldown process used in telecine.</description></item></list>
        /// </summary>
        public int DeinterlaceTechnology;
        /// <summary>
        /// Specifies the available video processor (ProcAmp) operations. The value is a bitwise OR of
        /// <c>ProcAmp Settings</c> constants.
        /// </summary>
        public int ProcAmpControlCaps;
        /// <summary>
        /// Specifies operations that the device can perform concurrently with the
        /// <c>IDirectXVideoProcessor::VideoProcessBlt</c> operation. The value is a bitwise <strong>OR
        /// </strong> of the following flags.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term><strong>DXVA2_VideoProcess_YUV2RGB</strong></term><description>The device can convert the video from YUV color space to RGB color space, with at least 8 bits of precision for each RGB component.</description></item><item><term><strong>DXVA2_VideoProcess_StretchX</strong></term><description>The device can stretch or shrink the video horizontally. If this capability is present, aspect ratio correction can be performed at the same time as deinterlacing.</description></item><item><term><strong>DXVA2_VideoProcess_StretchY</strong></term><description>The device can stretch or shrink the video vertically. If this capability is present, image resizing and aspect ratio correction can be performed at the same time.</description></item><item><term><strong>DXVA2_VideoProcess_AlphaBlend</strong></term><description>The device can alpha blend the video.</description></item><item><term><strong>DXVA2_VideoProcess_SubRects</strong></term><description>The device can operate on a subrectangle of the video frame. If this capability is present, source images can be cropped before further processing occurs.</description></item><item><term><strong>DXVA2_VideoProcess_SubStreams</strong></term><description>The device can accept substreams in addition to the primary video stream, and can composite them.</description></item><item><term><strong>DXVA2_VideoProcess_SubStreamsExtended</strong></term><description>The device can perform color adjustments on the primary video stream and substreams, at the same time that it deinterlaces the video and composites the substreams. The destination color space is defined in the <strong>DestFormat</strong> member of the <c>DXVA2_VideoProcessBltParams</c> structure. The source color space for each stream is defined in the SampleFormat member of the <c>DXVA2_VideoSample</c> structure. </description></item><item><term><strong>DXVA2_VideoProcess_YUV2RGBExtended</strong></term><description>The device can convert the video from YUV to RGB color space when it writes the deinterlaced and composited pixels to the destination surface.An RGB destination surface could be an off-screen surface, texture, Direct3D render target, or combined texture/render target surface. An RGB destination surface must use at least 8 bits for each color channel.</description></item><item><term><strong>DXVA2_VideoProcess_AlphaBlendExtended</strong></term><description>The device can perform an alpha blend operation with the destination surface when it writes the deinterlaced and composited pixels to the destination surface.</description></item><item><term><strong>DXVA2_VideoProcess_Constriction</strong></term><description>The device can downsample the output frame, as specified by the <strong>ConstrictionSize</strong> member of the <c>DXVA2_VideoProcessBltParams</c> structure. </description></item><item><term><strong>DXVA2_VideoProcess_NoiseFilter</strong></term><description>The device can perform noise filtering.</description></item><item><term><strong>DXVA2_VideoProcess_DetailFilter</strong></term><description>The device can perform detail filtering.</description></item><item><term><strong>DXVA2_VideoProcess_PlanarAlpha</strong></term><description>The device can perform a constant alpha blend to the entire video stream when it composites the video stream and substreams.</description></item><item><term><strong>DXVA2_VideoProcess_LinearScaling</strong></term><description>The device can perform accurate linear RGB scaling, rather than performing them in nonlinear gamma space.</description></item><item><term><strong>DXVA2_VideoProcess_GammaCompensated</strong></term><description>The device can correct the image to compensate for artifacts introduced when performing scaling in nonlinear gamma space.</description></item><item><term><strong>DXVA2_VideoProcess_MaintainsOriginalFieldData</strong></term><description>The deinterlacing algorithm preserves the original field lines from the interlaced field picture, unless scaling is also applied.For example, in deinterlacing algorithms such as bob and median filtering, the device copies the original field into every other scan line and then applies a filter to reconstruct the missing scan lines. As a result, the original field can be recovered by discarding the scan lines that were interpolated.If the image is scaled vertically, however, the original field lines cannot be recovered. If the image is scaled horizontally (but not vertically), the resulting field lines will be equivalent to scaling the original field picture. (In other words, discarding the interpolated scan lines will yield the same result as stretching the original picture without deinterlacing.)</description></item></list>
        /// </summary>
        public int VideoProcessorOperations;
        /// <summary>
        /// Specifies the supported noise filters. The value is a bitwise <strong>OR</strong> of the following
        /// flags.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term><strong>DXVA2_NoiseFilterTech_Unsupported</strong></term><description>Noise filtering is not supported.</description></item><item><term><strong>DXVA2_NoiseFilterTech_Unknown</strong></term><description>Unknown or proprietary filter.</description></item><item><term><strong>DXVA2_NoiseFilterTech_Median</strong></term><description>Median filter.</description></item><item><term><strong>DXVA2_NoiseFilterTech_Temporal</strong></term><description>Temporal filter.</description></item><item><term><strong>DXVA2_NoiseFilterTech_BlockNoise</strong></term><description>Block noise filter.</description></item><item><term><strong>DXVA2_NoiseFilterTech_MosquitoNoise</strong></term><description>Mosquito noise filter.</description></item></list>
        /// </summary>
        public int NoiseFilterTechnology;
        /// <summary>
        /// Specifies the supported detail filters. The value is a bitwise <strong>OR</strong> of the following
        /// flags.
        /// <para /><list type="table"><listheader><term>Value</term><description>Meaning</description></listheader><item><term><strong>DXVA2_DetailFilterTech_Unsupported</strong></term><description>Detail filtering is not supported.</description></item><item><term><strong>DXVA2_DetailFilterTech_Unknown</strong></term><description>Unknown or proprietary filter.</description></item><item><term><strong>DXVA2_DetailFilterTech_Edge</strong></term><description>Edge filter.</description></item><item><term><strong>DXVA2_DetailFilterTech_Sharpening</strong></term><description>Sharpen filter.</description></item></list>
        /// </summary>
        public int DetailFilterTechnology;
    }

#endif
}
