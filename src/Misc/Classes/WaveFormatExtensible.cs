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


    /// <summary>
    /// The <strong>WAVEFORMATEXTENSIBLE</strong> structure defines the format of waveform-audio data for
    /// formats having more than two channels or higher sample resolutions than allowed by 
    /// <see cref="Misc.WaveFormatEx"/>. 
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct {
    ///   WAVEFORMATEX Format;
    ///   union {
    ///     WORD wValidBitsPerSample;
    ///     WORD wSamplesPerBlock;
    ///     WORD wReserved;
    ///   } Samples;
    ///   DWORD        dwChannelMask;
    ///   GUID         SubFormat;
    /// } WAVEFORMATEXTENSIBLE, *PWAVEFORMATEXTENSIBLE;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/B16CDCAB-FA4F-4C9A-B1F3-AF459BD33245(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B16CDCAB-FA4F-4C9A-B1F3-AF459BD33245(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Explicit, Pack = 1), UnmanagedName("WAVEFORMATEXTENSIBLE")]
    public class WaveFormatExtensible : WaveFormatEx
    {
        /// <summary>
        /// Number of bits of precision in the signal. Usually equal to <see cref="WaveFormatEx.wBitsPerSample"/>. 
        /// However, <see cref="WaveFormatEx.wBitsPerSample"/> is the container size and must be a multiple of 8, 
        /// whereas <see cref="wValidBitsPerSample"/> can be any value not exceeding the container size. 
        /// For example, if the format uses 20-bit samples, <see cref="WaveFormatEx.wBitsPerSample"/> must be at least 24, 
        /// but <see cref="wValidBitsPerSample"/> is 20.
        /// </summary>
        [FieldOffset(0)]
        public short wValidBitsPerSample;
        /// <summary>
        /// Number of samples contained in one compressed block of audio data. This value is used in buffer estimation. 
        /// This value is used with compressed formats that have a fixed number of samples within each block. 
        /// This value can be set to zero if a variable number of samples is contained in each block of compressed audio data. 
        /// In this case, buffer estimation and position information needs to be obtained in other ways.
        /// </summary>
        [FieldOffset(0)]
        public short wSamplesPerBlock;
        /// <summary>
        /// Reserved. Set to zero. 
        /// </summary>
        [FieldOffset(0)]
        public short wReserved;
        /// <summary>
        /// Bitmask specifying the assignment of channels in the stream to speaker positions. See Remarks. 
        /// </summary>
        [FieldOffset(2)]
        public WaveMask dwChannelMask;
        /// <summary>
        /// A GUID that specifies the format of the audio data. 
        /// </summary>
        [FieldOffset(6)]
        public Guid SubFormat;

        /// <summary>
        /// Implements the equality operator.
        /// </summary>
        /// <param name="a">The left operand to compare for equality.</param>
        /// <param name="b">The right operand to compare for equality.</param>
        /// <returns>The result of the equality comparison operator.</returns>
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

        /// <summary>
        /// Implements the inequality operator.
        /// </summary>
        /// <param name="a">The left operand to compare for inequality.</param>
        /// <param name="b">The right operand to compare for inequality.</param>
        /// <returns>The result of the inequality comparison operator.</returns>
        public static bool operator !=(WaveFormatExtensible a, WaveFormatExtensible b)
        {
            return !(a == b);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            return this == (obj as WaveFormatExtensible);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }

}
