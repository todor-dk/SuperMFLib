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

namespace MediaFoundation.Dxvahd.Structs
{
#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
    /// </summary>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHDETW_VIDEOPROCESSBLTHD_STREAM")]
    internal struct DXVAHDETW_VIDEOPROCESSBLTHD_STREAM
    {
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public long pObject;
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public long pInputSurface;
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public MFRect SourceRect;
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public MFRect DestinationRect;
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public int InputFormat; // D3DFORMAT
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public DXVAHD_FRAME_FORMAT FrameFormat;
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public int ColorSpace;
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public int StreamNumber;
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public int OutputIndex;
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public int InputFrameOrField;
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public int PastFrames;
        /// <summary>
        /// <i>***** Documentation Missing *****</i>. This is part of <strong>DXVA-HD API ETW</strong>.
        /// </summary>
        public int FutureFrames;
    }

#endif

}
