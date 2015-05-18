﻿#region license

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

namespace MediaFoundation.Core.Enums
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Defines algorithms for the video processor which is use by <see cref="MFAttributesClsid.MF_VIDEO_PROCESSOR_ALGORITHM"/>.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-us/library/windows/desktop/dn302208(v=vs.85).aspx">http://msdn.microsoft.com/en-us/library/windows/desktop/dn302208(v=vs.85).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_VIDEO_PROCESSOR_ALGORITHM_TYPE")]
    internal enum MF_VIDEO_PROCESSOR_ALGORITHM_TYPE
    {
        /// <summary>
        /// Default mode favors a balance of quality and speed.
        /// </summary>
        Default = 0,
        /// <summary>
        /// The video processor will always internally process in AYUV and use high quality filters.
        /// </summary>
        MrfCrf444 = 1
    }

#endif
}
