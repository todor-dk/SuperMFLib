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

namespace MediaFoundation.dxvahd.Structs
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Specifies the capabilities of the Microsoft DirectX Video Acceleration High Definition (DXVA-HD)
    /// video processor.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_VPCAPS {
    ///   GUID VPGuid;
    ///   UINT PastFrames;
    ///   UINT FutureFrames;
    ///   UINT ProcessorCaps;
    ///   UINT ITelecineCaps;
    ///   UINT CustomRateCount;
    /// } DXVAHD_VPCAPS;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/25EC6802-CA6E-42D4-B1D5-DE7597E3D042(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/25EC6802-CA6E-42D4-B1D5-DE7597E3D042(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_VPCAPS")]
    internal struct DXVAHD_VPCAPS
    {
        /// <summary>
        /// A GUID that identifies the video processor. This GUID is defined by the device, and is used in
        /// various <see cref="dxvahd.IDXVAHD_Device"/> methods to specify the video processor. 
        /// </summary>
        public Guid VPGuid;
        /// <summary>
        /// The number of past reference frames required to perform the optimal video processing.
        /// </summary>
        public int PastFrames;
        /// <summary>
        /// The number of future reference frames required to perform the optimal video processing.
        /// </summary>
        public int FutureFrames;
        /// <summary>
        /// A bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="dxvahd.DXVAHD_PROCESSOR_CAPS"/> enumeration. 
        /// </summary>
        public int ProcessorCaps;
        /// <summary>
        /// A bitwise <strong>OR</strong> of zero or more flags from the 
        /// <see cref="dxvahd.DXVAHD_ITELECINE_CAPS"/> enumeration. 
        /// </summary>
        public int ITelecineCaps;
        /// <summary>
        /// The number of custom output frame rates. To get the list of custom frame rates, call the 
        /// <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorCustomRates"/> method. Custom frame rates are
        /// used for frame-rate conversion and inverse telecine. 
        /// </summary>
        public int CustomRateCount;
    }

#endif

}
