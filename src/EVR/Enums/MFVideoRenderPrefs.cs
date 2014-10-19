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
    /// Contains flags that define how the enhanced video renderer (EVR) displays the video.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/A56E7E09-23AF-4AD3-9846-4102233ED3C4(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A56E7E09-23AF-4AD3-9846-4102233ED3C4(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MFVideoRenderPrefs")]
    public enum MFVideoRenderPrefs
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// If this flag is set, the EVR does not draw the border color. By default, the EVR draws a border on
        /// areas of the destination rectangle that have no video. See 
        /// <see cref="EVR.IMFVideoDisplayControl.SetBorderColor"/>. 
        /// </summary>
        DoNotRenderBorder = 0x00000001,
        /// <summary>
        /// If this flag is set, the EVR does not clip the video when the video window straddles two monitors.
        /// By default, if the video window straddles two monitors, the EVR clips the video to the monitor that
        /// contains the largest area of video. 
        /// </summary>
        DoNotClipToDevice = 0x00000002,
        /// <summary>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// <para/>
        /// Allow the EVR to limit its output to match GPU bandwidth.
        /// </summary>
        AllowOutputThrottling = 0x00000004,
        /// <summary>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// <para/>
        /// Force the EVR to limit its output to match GPU bandwidth.
        /// </summary>
        ForceOutputThrottling = 0x00000008,
        /// <summary>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// <para/>
        /// Force the EVR to batch Direct3D <strong>Present</strong> calls. This optimization enables the
        /// system to enter to idle states more frequently, which can reduce power consumption. 
        /// </summary>
        ForceBatching = 0x00000010,
        /// <summary>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// <para/>
        /// Allow the EVR to batch Direct3D <strong>Present</strong> calls. 
        /// </summary>
        AllowBatching = 0x00000020,
        /// <summary>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// <para/>
        /// Force the EVR to mix the video inside a rectangle that is smaller than the output rectangle. The
        /// EVR will then scale the result to the correct output size. The effective resolution will be lower
        /// if this setting is applied.
        /// </summary>
        ForceScaling = 0x00000040,
        /// <summary>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// <para/>
        /// Allow the EVR to mix the video inside a rectangle that is smaller than the output rectangle. 
        /// </summary>
        AllowScaling = 0x00000080,
        /// <summary>
        /// <strong>Note</strong> Requires Windows 7 or later. 
        /// <para/>
        /// Prevent the EVR from repainting the video window after a stop command. By default, the EVR repaints
        /// the video window black after a stop command.
        /// </summary>
        DoNotRepaintOnStop = 0x00000100,
        /// <summary>
        /// Bitmask to validate flag values. This value is not a valid flag. 
        /// </summary>
        Mask = 0x000001ff,
    }

}
