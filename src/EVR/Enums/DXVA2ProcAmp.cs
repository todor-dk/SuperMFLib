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
    /// These flags define video processor (ProcAmp) settings.
    /// <para/>
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/60D97B9E-D77C-4E53-94EA-EBD59C2601DF(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/60D97B9E-D77C-4E53-94EA-EBD59C2601DF(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("DXVA2_ProcAmp_* defines")]
    public enum DXVA2ProcAmp
    {
        /// <summary>
        /// None.
        /// </summary>
        None = 0,
        /// <summary>
        /// Brightness.
        /// </summary>
        Brightness = 0x0001,
        /// <summary>
        /// Contrast.
        /// </summary>
        Contrast = 0x0002,
        /// <summary>
        /// Hue.
        /// </summary>
        Hue = 0x0004,
        /// <summary>
        /// Saturation.
        /// </summary>
        Saturation = 0x0008
    }

}
