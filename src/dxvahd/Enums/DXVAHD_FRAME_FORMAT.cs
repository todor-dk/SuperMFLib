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

namespace MediaFoundation.Dxvahd.Enums
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Describes how a video stream is interlaced.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/FC720DD3-E9C1-4B92-AC09-8E53CFF44BEC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/FC720DD3-E9C1-4B92-AC09-8E53CFF44BEC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("DXVAHD_FRAME_FORMAT")]
    internal enum DXVAHD_FRAME_FORMAT
    {
        /// <summary>
        /// Frames are progressive.
        /// </summary>
        Progressive = 0,
        /// <summary>
        /// Frames are interlaced. The top field of each frame is displayed first.
        /// </summary>
        InterlacedTopFieldFirst = 1,
        /// <summary>
        /// Frame are interlaced. The bottom field of each frame is displayed first.
        /// </summary>
        InterlacedBottomFieldFirst = 2
    }

#endif

}
