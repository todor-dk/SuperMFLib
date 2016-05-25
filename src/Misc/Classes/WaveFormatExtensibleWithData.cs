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

namespace MediaFoundation.Misc.Classes
{
#if NOT_IN_USE

    /// <summary>
    /// Extends the <see cref="WaveFormatExtensible"/> class with additional data.
    /// </summary>
    /// <remarks>
    /// Online Documentation:
    /// <a href="http://msdn.microsoft.com/en-US/library/B16CDCAB-FA4F-4C9A-B1F3-AF459BD33245(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/B16CDCAB-FA4F-4C9A-B1F3-AF459BD33245(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    /// <seealso cref="WaveFormatExtensible"/>
    [StructLayout(LayoutKind.Sequential, Pack = 1), UnmanagedName("WAVEFORMATEXTENSIBLE")]
    internal class  WaveFormatExtensibleWithData : WaveFormatExtensible
    {
        /// <summary>
        /// Data that immediately follows the <c>WAVEFORMATEXTENSIBLE</c> structure.
        /// </summary>
        public byte[] byteData;

        /// <summary>
        /// Implements the equality operator.
        /// </summary>
        /// <param name="a">The left operand to compare for equality.</param>
        /// <param name="b">The right operand to compare for equality.</param>
        /// <returns>The result of the equality comparison operator.</returns>
        public static bool operator ==(WaveFormatExtensibleWithData a, WaveFormatExtensibleWithData b)
        {
            bool bRet = ((WaveFormatExtensible)a) == ((WaveFormatExtensible)b);

            if (bRet)
            {
                if (b.byteData == null)
                {
                    bRet = a.byteData == null;
                }
                else
                {
                    if (b.byteData.Length == a.byteData.Length)
                    {
                        for (int x = 0; x < b.byteData.Length; x++)
                        {
                            if (b.byteData[x] != a.byteData[x])
                            {
                                bRet = false;
                                break;
                            }
                        }
                    }
                    else
                    {
                        bRet = false;
                    }
                }
            }

            return bRet;
        }

        /// <summary>
        /// Implements the inequality operator.
        /// </summary>
        /// <param name="a">The left operand to compare for inequality.</param>
        /// <param name="b">The right operand to compare for inequality.</param>
        /// <returns>The result of the inequality comparison operator.</returns>
        public static bool operator !=(WaveFormatExtensibleWithData a, WaveFormatExtensibleWithData b)
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
            return this == (obj as WaveFormatExtensibleWithData);
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

#endif
}
