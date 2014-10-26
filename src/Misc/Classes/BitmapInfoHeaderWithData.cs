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
using System.Collections;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

using MediaFoundation.Misc;
using MediaFoundation.Transform;

namespace MediaFoundation.Misc
{



    /// <summary>
    /// The BITMAPINFO structure defines the dimensions and color information for a Windows device-independent bitmap (DIB). 
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct tagBITMAPINFO {
    ///    BITMAPINFOHEADER bmiHeader;
    ///    RGBQUAD bmiColors[1];
    /// } BITMAPINFO;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para />
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/A00CAA49-E4DF-419F-89A7-AB03C13A1B5B(v=VS.110,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A00CAA49-E4DF-419F-89A7-AB03C13A1B5B(v=VS.110,d=hv.2).aspx</a></remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 4), UnmanagedName("BITMAPINFO")]
    public class BitmapInfoHeaderWithData : BitmapInfoHeader
    {
        /// <summary>
        /// Specifies an array of RGBQUAD or DWORD data types that define the colors in the bitmap. 
        /// </summary>
        public int[] bmiColors;
    }

}
