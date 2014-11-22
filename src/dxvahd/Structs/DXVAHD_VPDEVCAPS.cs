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
    /// Specifies the capabilities of a Microsoft DirectX Video Acceleration High Definition (DXVA-HD)
    /// device.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_VPDEVCAPS {
    ///   DXVAHD_DEVICE_TYPE DeviceType;
    ///   UINT               DeviceCaps;
    ///   UINT               FeatureCaps;
    ///   UINT               FilterCaps;
    ///   UINT               InputFormatCaps;
    ///   D3DPOOL            InputPool;
    ///   UINT               OutputFormatCount;
    ///   UINT               InputFormatCount;
    ///   UINT               VideoProcessorCount;
    ///   UINT               MaxInputStreams;
    ///   UINT               MaxStreamStates;
    /// } DXVAHD_VPDEVCAPS;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/340669D4-2A84-4030-83C3-A61469FDFD61(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/340669D4-2A84-4030-83C3-A61469FDFD61(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_VPDEVCAPS")]
    public struct DXVAHD_VPDEVCAPS
    {
        /// <summary>
        /// Specifies the device type, as a member of the <see cref="dxvahd.DXVAHD_DEVICE_TYPE"/> enumeration. 
        /// </summary>
        public DXVAHD_DEVICE_TYPE DeviceType;
        /// <summary>
        /// A bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="dxvahd.DXVAHD_DEVICE_CAPS"/> enumeration. 
        /// </summary>
        public int DeviceCaps;
        /// <summary>
        /// A bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="dxvahd.DXVAHD_FEATURE_CAPS"/> enumeration. 
        /// </summary>
        public int FeatureCaps;
        /// <summary>
        /// A bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="dxvahd.DXVAHD_FILTER_CAPS"/> enumeration. 
        /// </summary>
        public int FilterCaps;
        /// <summary>
        /// A bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="dxvahd.DXVAHD_INPUT_FORMAT_CAPS"/> enumeration. 
        /// </summary>
        public int InputFormatCaps;
        /// <summary>
        /// The memory pool that is required for the input video surfaces.
        /// </summary>
        public int InputPool;
        /// <summary>
        /// The number of supported output formats. To get the list of output formats, call the 
        /// <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorOutputFormats"/> method. 
        /// </summary>
        public int OutputFormatCount;
        /// <summary>
        /// The number of supported input formats. To get the list of input formats, call the 
        /// <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorInputFormats"/> method. 
        /// </summary>
        public int InputFormatCount;
        /// <summary>
        /// The number of video processors. Each video processor represents a distinct set of processing
        /// capabilities. To get the capabilities of each video processor, call the 
        /// <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorCaps"/> method. To create a video processor, call
        /// the <see cref="dxvahd.IDXVAHD_Device.CreateVideoProcessor"/> method. 
        /// </summary>
        public int VideoProcessorCount;
        /// <summary>
        /// The maximum number of input streams that can be enabled at the same time.
        /// </summary>
        public int MaxInputStreams;
        /// <summary>
        /// The maximum number of input streams for which the device can store state data. 
        /// </summary>
        public int MaxStreamStates;
    }

#endif

}
