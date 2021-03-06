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
using System.Runtime.InteropServices;
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.Dxvahd.Classes
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
    /// </summary>
    public static class DXVAHDETWGUID
    {
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public static readonly Guid CREATEVIDEOPROCESSOR = new Guid(0x681e3d1e, 0x5674, 0x4fb3, 0xa5, 0x03, 0x2f, 0x20, 0x55, 0xe9, 0x1f, 0x60);
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public static readonly Guid VIDEOPROCESSBLTSTATE = new Guid(0x76c94b5a, 0x193f, 0x4692, 0x94, 0x84, 0xa4, 0xd9, 0x99, 0xda, 0x81, 0xa8);
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public static readonly Guid VIDEOPROCESSBLTHD = new Guid(0xbef3d435, 0x78c7, 0x4de3, 0x97, 0x07, 0xcd, 0x1b, 0x08, 0x3b, 0x16, 0x0a);
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public static readonly Guid VIDEOPROCESSBLTHD_STREAM = new Guid(0x27ae473e, 0xa5fc, 0x4be5, 0xb4, 0xe3, 0xf2, 0x49, 0x94, 0xd3, 0xc4, 0x95);
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public static readonly Guid DESTROYVIDEOPROCESSOR = new Guid(0xf943f0a0, 0x3f16, 0x43e0, 0x80, 0x93, 0x10, 0x5a, 0x98, 0x6a, 0xa5, 0xf1);
   }

#endif

}
