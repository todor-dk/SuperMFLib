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
    /// Describes the intended aspect ratio for a video stream.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6166B880-36BC-4AC3-9D66-D3DD17C29AE7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6166B880-36BC-4AC3-9D66-D3DD17C29AE7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFVideoSrcContentHintFlags")]
    internal enum  MFVideoSrcContentHintFlags
    {
        /// <summary>
        /// The aspect ratio is unknown.
        /// </summary>
        None  = 0,
        /// <summary>
        /// The source is 16×9 content encoded within a 4×3 area.
        /// </summary>
        F16x9  = 1,
        /// <summary>
        /// The source is 2.35:1 content encoded within a 16×9 or 4×3 area.
        /// </summary>
        F235_1 = 2
    }
#endif
}
