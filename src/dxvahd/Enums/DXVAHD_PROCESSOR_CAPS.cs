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
    /// Specifies the processing capabilities of a Microsoft DirectX Video Acceleration High Definition
    /// (DXVA-HD) video processor.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6FE6B1FE-4EEF-427A-B28F-A359B066E552(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6FE6B1FE-4EEF-427A-B28F-A359B066E552(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("DXVAHD_PROCESSOR_CAPS")]
    public enum DXVAHD_PROCESSOR_CAPS
    {
        /// <summary>
        /// The video processor can perform blend deinterlacing.
        /// <para/>
        /// In <em>blend deinterlacing</em>, the two fields from an interlaced frame are blended into a single
        /// progressive frame. A video processor uses blend deinterlacing when it deinterlaces at half rate, as
        /// when converting 60i to 30p. Blend deinterlacing does not require reference frames. 
        /// </summary>
        DeinterlaceBlend = 0x1,
        /// <summary>
        /// The video processor can perform bob deinterlacing. 
        /// <para/>
        /// In <em>bob deinterlacing</em>, missing field lines are interpolated from the lines above and below.
        /// Bob deinterlacing does not require reference frames. 
        /// </summary>
        DeinterlaceBob = 0x2,
        /// <summary>
        /// The video processor can perform adaptive deinterlacing.
        /// <para/>
        /// <em>Adaptive deinterlacing</em> uses spatial or temporal interpolation, and switches between the
        /// two on a field-by-field basis, depending on the amount of motion. If the video processor does not
        /// receive enough reference frames to perform adaptive deinterlacing, it falls back to bob
        /// deinterlacing. 
        /// </summary>
        DeinterlaceAdaptive = 0x4,
        /// <summary>
        /// The video processor  can perform motion-compensated deinterlacing.
        /// <para/>
        /// <em>Motion-compensated deinterlacing</em> uses motion vectors to recreate missing lines. If the
        /// video processor does not receive enough reference frames to perform motion-compensated
        /// deinterlacing, it falls back to bob deinterlacing. 
        /// </summary>
        DeinterlaceMotionCompensation = 0x8,
        /// <summary>
        /// The video processor can perform inverse telecine (IVTC).
        /// <para/>
        /// If the video processor supports this capability, the <strong>ITelecineCaps</strong> member of the 
        /// <see cref="dxvahd.DXVAHD_VPCAPS"/> structure specifies which IVTC modes are supported. 
        /// </summary>
        InverseTelecine = 0x10,
        /// <summary>
        /// The video processor can convert the frame rate by interpolating frames.
        /// </summary>
        FrameRateConversion = 0x20
    }

#endif

}
