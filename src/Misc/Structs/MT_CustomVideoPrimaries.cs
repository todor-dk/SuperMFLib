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
    /// Defines custom color primaries for a video source. The color primaries define how to convert colors
    /// from RGB color space to CIE XYZ color space.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/2C26E906-E428-4A76-B10A-10A18F300EBE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2C26E906-E428-4A76-B10A-10A18F300EBE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MT_CUSTOM_VIDEO_PRIMARIES"), StructLayout(LayoutKind.Sequential)]
    public struct MT_CustomVideoPrimaries
    {
        /// <summary>
        /// Red x-coordinate.
        /// </summary>
        public float fRx;
        /// <summary>
        /// Red y-coordinate.
        /// </summary>
        public float fRy;
        /// <summary>
        /// Green x-coordinate.
        /// </summary>
        public float fGx;
        /// <summary>
        /// Green y-coordinate.
        /// </summary>
        public float fGy;
        /// <summary>
        /// Blue x-coordinate.
        /// </summary>
        public float fBx;
        /// <summary>
        /// Blue y-coordinate.
        /// </summary>
        public float fBy;
        /// <summary>
        /// White point x-coordinate.
        /// </summary>
        public float fWx;
        /// <summary>
        /// White point y-coordinate.
        /// </summary>
        public float fWy;
    }

}
