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
using System.Collections;
using System.Text;
using System.Drawing;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security;

using MediaFoundation.Misc;
using MediaFoundation.Transform;

namespace MediaFoundation.Misc
{


    [StructLayout(LayoutKind.Explicit, Pack = 1), UnmanagedName("WAVEFORMATEXTENSIBLE")]
    public class WaveFormatExtensible : WaveFormatEx
    {
        [FieldOffset(0)]
        public short wValidBitsPerSample;
        [FieldOffset(0)]
        public short wSamplesPerBlock;
        [FieldOffset(0)]
        public short wReserved;
        [FieldOffset(2)]
        public WaveMask dwChannelMask;
        [FieldOffset(6)]
        public Guid SubFormat;

        public static bool operator ==(WaveFormatExtensible a, WaveFormatExtensible b)
        {
            bool bRet = ((WaveFormatEx)a) == ((WaveFormatEx)b);

            if (bRet)
            {
                bRet = (a.wValidBitsPerSample == b.wValidBitsPerSample &&
                    a.dwChannelMask == b.dwChannelMask &&
                    a.SubFormat == b.SubFormat);
            }

            return bRet;
        }

        public static bool operator !=(WaveFormatExtensible a, WaveFormatExtensible b)
        {
            return !(a == b);
        }

        public override bool Equals(object obj)
        {
            return this == (obj as WaveFormatExtensible);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
