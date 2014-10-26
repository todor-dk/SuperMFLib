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

namespace MediaFoundation.dxvahd
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
    /// </summary>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHDETW_VIDEOPROCESSBLTSTATE")]
    public struct DXVAHDETW_VIDEOPROCESSBLTSTATE
    {
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public long pObject;
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public DXVAHD_BLT_STATE State;
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public int DataSize;
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        [MarshalAs(UnmanagedType.Bool)]
        public bool SetState;
    }

#endif

}
