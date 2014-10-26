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

namespace MediaFoundation.Misc
{


    /// <summary>
    /// Specifies which channels are present in the multichannel audio stream. 
    /// Least significant bit corresponds with the front left speaker, 
    /// the next least significant bit corresponds to the front right speaker, and so on. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-gb/library/windows/desktop/dd390971(v=vs.85).aspx">http://msdn.microsoft.com/en-gb/library/windows/desktop/dd390971(v=vs.85).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("SPEAKER_* defines")]
    public enum WaveMask
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0x0,
        /// <summary>
        /// Front left
        /// </summary>
        FrontLeft = 0x1,
        /// <summary>
        /// Front right
        /// </summary>
        FrontRight = 0x2,
        /// <summary>
        /// Front center
        /// </summary>
        FrontCenter = 0x4,
        /// <summary>
        /// Low frequency
        /// </summary>
        LowFrequency = 0x8,
        /// <summary>
        /// Back left
        /// </summary>
        BackLeft = 0x10,
        /// <summary>
        /// Back right
        /// </summary>
        BackRight = 0x20,
        /// <summary>
        /// Front left of center
        /// </summary>
        FrontLeftOfCenter = 0x40,
        /// <summary>
        /// Front right of center
        /// </summary>
        FrontRightOfCenter = 0x80,
        /// <summary>
        /// Back center
        /// </summary>
        BackCenter = 0x100,
        /// <summary>
        /// Side left
        /// </summary>
        SideLeft = 0x200,
        /// <summary>
        /// Side right
        /// </summary>
        SideRight = 0x400,
        /// <summary>
        /// Top center
        /// </summary>
        TopCenter = 0x800,
        /// <summary>
        /// Top front left
        /// </summary>
        TopFrontLeft = 0x1000,
        /// <summary>
        /// Top front center
        /// </summary>
        TopFrontCenter = 0x2000,
        /// <summary>
        /// Top front right
        /// </summary>
        TopFrontRight = 0x4000,
        /// <summary>
        /// Top back left
        /// </summary>
        TopBackLeft = 0x8000,
        /// <summary>
        /// Top back center
        /// </summary>
        TopBackCenter = 0x10000,
        /// <summary>
        /// Top back right
        /// </summary>
        TopBackRight = 0x20000
    }

}
