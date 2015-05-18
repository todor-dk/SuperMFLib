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

namespace MediaFoundation.dxvahd.Enums
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Specifies state parameters for an input stream to a Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD) video processor.
    /// <para/>
    /// To set a state parameter, call 
    /// <see cref="dxvahd.IDXVAHD_VideoProcessor.SetVideoProcessStreamState"/>. This method takes a 
    /// <strong>DXVAHD_STREAM_STATE</strong> value and a byte array as input. The byte array contains state
    /// data, the structure of which is defined by the <strong>DXVAHD_STREAM_STATE</strong> value. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/75036101-7498-4D66-AFC3-DF76AE3CCA39(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/75036101-7498-4D66-AFC3-DF76AE3CCA39(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("DXVAHD_STREAM_STATE")]
    internal enum DXVAHD_STREAM_STATE
    {
        /// <summary>
        /// Specifies the video format of the input stream. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_D3DFORMAT_DATA"/> structure. 
        /// </summary>
        D3DFormat = 0,
        /// <summary>
        /// Specifies how the input stream is interlaced. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_FRAME_FORMAT_DATA"/> structure. 
        /// </summary>
        FrameFormat = 1,
        /// <summary>
        /// Specifies the color space for the input stream. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_INPUT_COLOR_SPACE_DATA"/> structure. 
        /// </summary>
        InputColorSpace = 2,
        /// <summary>
        /// Specifies the output frame rate. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_OUTPUT_RATE_DATA"/> structure. 
        /// </summary>
        OutputRate = 3,
        /// <summary>
        /// Specifies the source rectangle. The source rectangle defines which portion of the input sample is
        /// blitted to the destination surface. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_SOURCE_RECT_DATA"/> structure. 
        /// </summary>
        SourceRect = 4,
        /// <summary>
        /// Specifies the destination rectangle. The destination rectangle defines which portion of the
        /// destination rectangle receives the blit. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_DESTINATION_RECT_DATA"/> structure. 
        /// </summary>
        DestinationRect = 5,
        /// <summary>
        /// Specifies the planar alpha value for this input stream. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_ALPHA_DATA"/> structure. 
        /// </summary>
        Alpha = 6,
        /// <summary>
        /// Specifies the color-palette entries. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_PALETTE_DATA"/> structure. 
        /// <para/>
        /// This setting is used for palettized input formats, such as AI44 and IA44. 
        /// </summary>
        Palette = 7,
        /// <summary>
        /// Specifies the luma key. The state data is a <see cref="dxvahd.DXVAHD_STREAM_STATE_LUMA_KEY_DATA"/>
        /// structure. 
        /// <para/>
        /// This state is applicable only if the device supports luma keying. To find out if the device
        /// supports luma keying, check for the <strong>DXVAHD_FEATURE_CAPS_LUMA_KEY</strong> flag in the 
        /// <strong>FeatureCaps </strong> member of the <see cref="dxvahd.DXVAHD_VPDEVCAPS"/> capabilities
        /// structure. 
        /// </summary>
        LumaKey = 8,
        /// <summary>
        /// Specifies the pixel aspect ratio of the source and destination surfaces. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_ASPECT_RATIO_DATA"/> structure. 
        /// </summary>
        AspectRatio = 9,
        /// <summary>
        /// Specifies the brightness filter. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_FILTER_DATA"/> structure. 
        /// </summary>
        FilterBrightness = 100,
        /// <summary>
        /// Specifies the contrast filter. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_FILTER_DATA"/> structure. 
        /// </summary>
        FilterContrast = 101,
        /// <summary>
        /// Specifies the hue filter. The state data is a <see cref="dxvahd.DXVAHD_STREAM_STATE_FILTER_DATA"/>
        /// structure. 
        /// </summary>
        FilterHue = 102,
        /// <summary>
        /// Specifies the saturation filter. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_FILTER_DATA"/> structure. 
        /// </summary>
        FilterSaturation = 103,
        /// <summary>
        /// Specifies the noise-reduction filter. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_FILTER_DATA"/> structure. 
        /// </summary>
        FilterNoiseReduction = 104,
        /// <summary>
        /// Specifies the edge-enhancement filter. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_FILTER_DATA"/> structure. 
        /// </summary>
        FilterEdgeEnhancement = 105,
        /// <summary>
        /// Specifies the anamorphic-scaling value. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_FILTER_DATA"/> structure. 
        /// </summary>
        FilterAnamorphicScaling = 106,
        /// <summary>
        /// Specifies that the state data contains a private DXVA-HD stream state. The state data is a 
        /// <see cref="dxvahd.DXVAHD_STREAM_STATE_PRIVATE_DATA"/> structure. 
        /// <para/>
        /// Use this state for proprietary or device-specific parameters.
        /// </summary>
        Private = 1000
    }

#endif

}
