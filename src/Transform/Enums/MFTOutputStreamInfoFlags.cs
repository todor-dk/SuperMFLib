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

using MediaFoundation.Misc;

namespace MediaFoundation.Transform
{


    [Flags, UnmanagedName("_MFT_OUTPUT_STREAM_INFO_FLAGS")]
    public enum MFTOutputStreamInfoFlags
    {
        None = 0,
        WholeSamples = 0x00000001,
        SingleSamplePerBuffer = 0x00000002,
        FixedSampleSize = 0x00000004,
        Discardable = 0x00000008,
        Optional = 0x00000010,
        ProvidesSamples = 0x00000100,
        CanProvideSamples = 0x00000200,
        LazyRead = 0x00000400,
        Removable = 0x00000800
    }

}
