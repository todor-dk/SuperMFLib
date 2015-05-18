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
    /// Specifies how the output alpha values are calculated for blit operations when using Microsoft
    /// DirectX Video Acceleration High Definition (DXVA-HD).
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_BLT_STATE_ALPHA_FILL_DATA {
    ///   DXVAHD_ALPHA_FILL_MODE Mode;
    ///   UINT                   StreamNumber;
    /// } DXVAHD_BLT_STATE_ALPHA_FILL_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/DCD42210-D5F8-42C7-AAC0-08F0CE4B7AC9(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/DCD42210-D5F8-42C7-AAC0-08F0CE4B7AC9(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_BLT_STATE_ALPHA_FILL_DATA")]
    internal struct DXVAHD_BLT_STATE_ALPHA_FILL_DATA
    {
        /// <summary>
        /// Specifies the alpha fill mode, as a member of the <see cref="dxvahd.DXVAHD_ALPHA_FILL_MODE" />
        /// enumeration.
        /// <para />
        /// If the <strong>FeatureCaps</strong> member of the <see cref="dxvahd.DXVAHD_VPDEVCAPS" /> structure
        /// does not contain the <strong>DXVAHD_FEATURE_CAPS_ALPHA_FILL</strong> flag, the alpha fill mode must
        /// be set to <strong>DXVAHD_ALPHA_FILL_MODE_OPAQUE</strong>.
        /// <para />
        /// The default state value is <strong>DXVAHD_ALPHA_FILL_MODE_OPAQUE</strong>.
        /// </summary>
        public DXVAHD_ALPHA_FILL_MODE Mode;
        /// <summary>
        /// Zero-based index of the input stream to use for the alpha values. This member is used when the
        /// alpha fill mode is <strong>DXVAHD_ALPHA_FILL_MODE_SOURCE_STREAM</strong>; otherwise, the value is
        /// ignored.
        /// <para />
        /// To get the maximum number of streams, call
        /// <see cref="dxvahd.IDXVAHD_Device.GetVideoProcessorDeviceCaps" /> and check the <strong>
        /// MaxStreamStates</strong> member of the <see cref="dxvahd.DXVAHD_VPDEVCAPS" /> structure.
        /// </summary>
        public int StreamNumber;
    }

#endif

}
