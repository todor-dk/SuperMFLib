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
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Defines a regions of interest. 
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _ROI_AREA {
    ///   RECT   rect;
    ///   INT32  QPDelta;
    /// } ROI_AREA, *PROI_AREA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302212(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302212(v=vs.85).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("ROI_AREA")]
    public struct ROI_AREA
    {
        /// <summary>
        /// The bounds of the region.
        /// </summary>
        public MFRect rect;
        /// <summary>
        /// Specifies the quantization parameter delta for the specified region from the rest of the frame.
        /// </summary>
        public int QPDelta;
    }

#endif
}
