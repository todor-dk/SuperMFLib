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

namespace MediaFoundation.Misc.Enums
{
    #if NOT_IN_USE

    /// <summary>
    /// Specifies whether to pad a video image so that it fits within a specified aspect ratio.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C68FDD6E-4FC9-4D70-91F0-DAB70315EC21(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C68FDD6E-4FC9-4D70-91F0-DAB70315EC21(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFVideoPadFlags")]
    internal enum MFVideoPadFlags
    {
        /// <summary>
        /// Do not pad the image.
        /// </summary>
        PAD_TO_None = 0,
        /// <summary>
        /// Pad the image so that it can be displayed in a 4×3 area.
        /// </summary>
        PAD_TO_4x3 = 1,
        /// <summary>
        /// Pad the image so that it can be displayed in a 16×9 area.
        /// </summary>
        PAD_TO_16x9 = 2
    }

#endif
}
