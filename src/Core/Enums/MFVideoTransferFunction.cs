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

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation
{
    /// <summary>
    /// Specifies the conversion function from linear RGB to non-linear RGB (R'G'B').
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/F9AFF1D5-E9F7-48FD-9C86-8DC597D37DFA(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/F9AFF1D5-E9F7-48FD-9C86-8DC597D37DFA(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFVideoTransferFunction")]
    public enum MFVideoTransferFunction
    {
        /// <summary>
        /// Unknown. Treat as MFVideoTransFunc_709.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Linear RGB (gamma = 1.0).
        /// </summary>
        Func10 = 1,

        /// <summary>
        /// True 1.8 gamma, L' = L^1/1.8.
        /// </summary>
        Func18 = 2,

        /// <summary>
        /// True 2.0 gamma, L' = L^1/2.0.
        /// </summary>
        Func20 = 3,

        /// <summary>
        /// True 2.2 gamma, L' = L^1/2.2. This transfer function is used in ITU-R BT.470-2 System M (NTSC).
        /// </summary>
        Func22 = 4,

        /// <summary>
        /// SPMTE 240M transfer function. Gamma 2.2 curve with a linear segment in the lower range.
        /// </summary>
        Func240M = 6,

        /// <summary>
        /// True 2.8 gamma. L' = L^1/2.8. This transfer function is used in ITU-R BT.470-2 System B, G (PAL).
        /// </summary>
        Func28 = 8,

        /// <summary>
        /// ITU-R BT.709 transfer function. Gamma 2.2 curve with a linear segment in the lower range.
        /// This transfer function is used in BT.709, BT.601, SMPTE 296M, SMPTE 170M, BT.470, and SPMTE 274M.
        /// In addition BT-1361 uses this function within the range [0...1].
        /// </summary>
        Func709 = 5,

        /// <summary>
        /// Reserved. This member forces the enumeration type to compile as a <strong>DWORD</strong> value.
        /// </summary>
        ForceDWORD = 0x7fffffff,

        /// <summary>
        /// Reserved.
        /// </summary>
        Last = 9,

        /// <summary>
        /// sRGB transfer function. Gamma 2.4 curve with a linear segment in the lower range.
        /// </summary>
        sRGB = 7,

        /// <summary>
        /// Logarithmic transfer (100:1 range); for example, as used in H.264 video.
        /// <para/>
        /// <strong>Note</strong> Requires Windows 7 or later.
        /// </summary>
        Log_100 = 9,

        /// <summary>
        /// Logarithmic transfer (316.22777:1 range); for example, as used in H.264 video.
        /// <para/>
        /// <strong>Note</strong> Requires Windows 7 or later.
        /// </summary>
        Log_316 = 10,

        /// <summary>
        /// Logarithmic transfer (316.22777:1 range); for example, as used in H.264 video.
        /// Note: Requires Windows 7 or later.
        /// </summary>
        x709_sym = 11 // symmetric 709
    }
}
