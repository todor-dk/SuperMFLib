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

// This file is a mess.  While technically part of MF, I'm in no hurry 
// to try to get this to work.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MediaFoundation.OPM.Enums
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Specifies the aspect ratio for ETSI EN 300 294.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/3C0FC524-B75F-4397-BD01-25BE44062E8C(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3C0FC524-B75F-4397-BD01-25BE44062E8C(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    internal enum OPM_IMAGE_ASPECT_RATIO_EN300294
    {
        /// <summary>
        /// Full format 4:3.
        /// </summary>
        OPM_ASPECT_RATIO_EN300294_FULL_FORMAT_4_BY_3 = 0,
        /// <summary>
        /// Box 14:9 center.
        /// </summary>
        OPM_ASPECT_RATIO_EN300294_BOX_14_BY_9_CENTER = 1,
        /// <summary>
        /// Box 14:9 top.
        /// </summary>
        OPM_ASPECT_RATIO_EN300294_BOX_14_BY_9_TOP = 2,
        /// <summary>
        /// Box 16:9 center.
        /// </summary>
        OPM_ASPECT_RATIO_EN300294_BOX_16_BY_9_CENTER = 3,
        /// <summary>
        /// Box 16:9 top.
        /// </summary>
        OPM_ASPECT_RATIO_EN300294_BOX_16_BY_9_TOP = 4,
        /// <summary>
        /// Box > 16:9 center.
        /// </summary>
        OPM_ASPECT_RATIO_EN300294_BOX_GT_16_BY_9_CENTER = 5,
        /// <summary>
        /// Full format 4:3 (shoot and protect 14:9 center). 
        /// </summary>
        OPM_ASPECT_RATIO_EN300294_FULL_FORMAT_4_BY_3_PROTECTED_CENTER = 6,
        /// <summary>
        /// Full format 16:9 (anamorphic).
        /// </summary>
        OPM_ASPECT_RATIO_EN300294_FULL_FORMAT_16_BY_9_ANAMORPHIC = 7,
        /// <summary>
        /// Reserved.
        /// </summary>
        OPM_ASPECT_RATIO_FORCE_ULONG = 0x7fffffff
    }

#endif

}
