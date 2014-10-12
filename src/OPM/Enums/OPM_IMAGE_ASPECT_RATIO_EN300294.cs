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

namespace MediaFoundation.OPM
{

#if ALLOW_UNTESTED_INTERFACES


    public enum OPM_IMAGE_ASPECT_RATIO_EN300294
    {
        OPM_ASPECT_RATIO_EN300294_FULL_FORMAT_4_BY_3 = 0,
        OPM_ASPECT_RATIO_EN300294_BOX_14_BY_9_CENTER = 1,
        OPM_ASPECT_RATIO_EN300294_BOX_14_BY_9_TOP = 2,
        OPM_ASPECT_RATIO_EN300294_BOX_16_BY_9_CENTER = 3,
        OPM_ASPECT_RATIO_EN300294_BOX_16_BY_9_TOP = 4,
        OPM_ASPECT_RATIO_EN300294_BOX_GT_16_BY_9_CENTER = 5,
        OPM_ASPECT_RATIO_EN300294_FULL_FORMAT_4_BY_3_PROTECTED_CENTER = 6,
        OPM_ASPECT_RATIO_EN300294_FULL_FORMAT_16_BY_9_ANAMORPHIC = 7,
        OPM_ASPECT_RATIO_FORCE_ULONG = 0x7fffffff
    }

#endif

}
