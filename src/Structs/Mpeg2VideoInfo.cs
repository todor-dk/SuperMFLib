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
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation
{

#if ALLOW_UNTESTED_INTERFACES

    [StructLayout(LayoutKind.Sequential), UnmanagedName("MPEG2VIDEOINFO")]
    public struct Mpeg2VideoInfo
    {
        VideoInfoHeader2 hdr;
        int dwStartTimeCode;        //  ?? not used for DVD ??
        int cbSequenceHeader;       // is 0 for DVD (no sequence header)
        int dwProfile;              // use enum MPEG2Profile
        int dwLevel;                // use enum MPEG2Level
        int dwFlags;                // use AMMPEG2_* defines.  Reject connection if undefined bits are not 0
        int[] dwSequenceHeader;     // DWORD instead of Byte for alignment purposes
        //   For MPEG-2, if a sequence_header is included, the sequence_extension
        //   should also be included
    }

#endif

}
