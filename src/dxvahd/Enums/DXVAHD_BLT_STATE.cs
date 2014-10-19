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
    /// Specifies state parameters for blit operations when using Microsoft DirectX Video Acceleration High
    /// Definition (DXVA-HD).
    /// <para/>
    /// To set a state parameter, call the 
    /// <see cref="dxvahd.IDXVAHD_VideoProcessor.SetVideoProcessBltState"/> method. This method takes a 
    /// <strong>DXVAHD_BLT_STATE</strong> value and a byte array as input. The byte array contains state
    /// data, the structure of which is defined by the <strong>DXVAHD_BLT_STATE</strong> value. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/CD5F56FF-61D7-49DF-8114-F6A14DE8E06B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CD5F56FF-61D7-49DF-8114-F6A14DE8E06B(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("DXVAHD_BLT_STATE")]
    public enum DXVAHD_BLT_STATE
    {
        /// <summary>
        /// Specifies the target rectangle, which is the area within the destination surface where the output
        /// will be drawn. The state data is a <see cref="dxvahd.DXVAHD_BLT_STATE_TARGET_RECT_DATA"/>
        /// structure. 
        /// </summary>
        TargetRect = 0,
        /// <summary>
        /// Specifies the background color. The state data is a 
        /// <see cref="dxvahd.DXVAHD_BLT_STATE_BACKGROUND_COLOR_DATA"/> structure. 
        /// </summary>
        BackgroundColor = 1,
        /// <summary>
        /// Specifies the output color space. The state data is a 
        /// <see cref="dxvahd.DXVAHD_BLT_STATE_OUTPUT_COLOR_SPACE_DATA"/> structure. 
        /// </summary>
        OutputColorSpace = 2,
        /// <summary>
        /// Specifies how DXVA-HD device calculates output alpha values. The state data is a 
        /// <see cref="dxvahd.DXVAHD_BLT_STATE_ALPHA_FILL_DATA"/> structure. 
        /// </summary>
        AlphaFill = 3,
        /// <summary>
        /// Specifies the amount of downsampling to perform on the output. The state data is a 
        /// <see cref="dxvahd.DXVAHD_BLT_STATE_CONSTRICTION_DATA"/> structure. 
        /// </summary>
        Constriction = 4,
        /// <summary>
        /// Specifies that the state data contains a private DXVA-HD blit state. Use this state for proprietary
        /// or device-specific parameters. The state data is a 
        /// <see cref="dxvahd.DXVAHD_BLT_STATE_PRIVATE_DATA"/> structure. 
        /// </summary>
        Private = 1000
    }

#endif

}
