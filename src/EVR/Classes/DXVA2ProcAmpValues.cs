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
    /// Contains values for DirectX Video Acceleration (DXVA) video processing operations.
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _DXVA2_ProcAmpValues {
    ///   DXVA2_Fixed32 Brightness;
    ///   DXVA2_Fixed32 Contrast;
    ///   DXVA2_Fixed32 Hue;
    ///   DXVA2_Fixed32 Saturation;
    /// } DXVA2_ProcAmpValues;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C84ACD34-E922-46BB-9913-0F94C7C47155(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C84ACD34-E922-46BB-9913-0F94C7C47155(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVA2_ProcAmpValues")]
    public class DXVA2ProcAmpValues
    {
        /// <summary>
        /// Brightness value.
        /// </summary>
        public int Brightness;
        /// <summary>
        /// Contrast value.
        /// </summary>
        public int Contrast;
        /// <summary>
        /// Hue value.
        /// </summary>
        public int Hue;
        /// <summary>
        /// Saturation value.
        /// </summary>
        public int Saturation;
    }

}
