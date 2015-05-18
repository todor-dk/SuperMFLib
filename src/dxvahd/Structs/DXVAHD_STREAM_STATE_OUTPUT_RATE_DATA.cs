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
    /// Specifies the output frame rate for an input stream when using Microsoft DirectX Video Acceleration
    /// High Definition (DXVA-HD).
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_STREAM_STATE_OUTPUT_RATE_DATA {
    ///   BOOL               RepeatFrame;
    ///   DXVAHD_OUTPUT_RATE OutputRate;
    ///   DXVAHD_RATIONAL    CustomRate;
    /// } DXVAHD_STREAM_STATE_OUTPUT_RATE_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9CCA24F0-5FFF-4125-B1FE-D2F9278B5181(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9CCA24F0-5FFF-4125-B1FE-D2F9278B5181(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_STREAM_STATE_OUTPUT_RATE_DATA")]
    internal struct DXVAHD_STREAM_STATE_OUTPUT_RATE_DATA
    {
        /// <summary>
        /// Specifies how the device performs frame-rate conversion, if required. The default state value is 
        /// <strong>FALSE</strong> (interpolation). 
        /// <para/>
        /// <list type="table">
        /// <listheader><term>Value</term><description>Meaning</description></listheader>
        /// <item><term><strong>TRUE</strong></term><description>The device repeats frames.</description></item>
        /// <item><term><strong>FALSE</strong></term><description>The device interpolates frames.</description></item>
        /// </list>
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool RepeatFrame;
        /// <summary>
        /// Specifies the output rate, as a member of the <see cref="dxvahd.DXVAHD_OUTPUT_RATE"/> enumeration. 
        /// </summary>
        public DXVAHD_OUTPUT_RATE OutputRate;
        /// <summary>
        /// Specifies a custom output rate, as a <see cref="dxvahd.DXVAHD_RATIONAL"/> structure. This member is
        /// ignored unless <strong>OutputRate</strong> equals <strong>DXVAHD_OUTPUT_RATE_CUSTOM</strong>. The
        /// default state value is 1/1. 
        /// <para/>
        /// To get the list of custom rates supported by the video processor, call 
        /// <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorCustomRates"/>. If a custom rate is used, it must
        /// be taken from this list. 
        /// </summary>
        public DXVAHD_RATIONAL CustomRate;
    }

#endif

}
