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
    /// <summary>
    /// Represents a FOURCC Code.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal class FourCC
    {
        /// <summary>
        /// Integer containing the four character code.
        /// </summary>
        private int m_fourCC;

        /// <summary>
        /// Initializes a new instance of the <see cref="FourCC"/> class.
        /// </summary>
        /// <param name="fcc">Four character code.</param>
        /// <exception cref="System.ArgumentException"></exception>
        public FourCC(string fcc)
        {
            if (fcc.Length != 4)
            {
                throw new ArgumentException(fcc + " is not a valid FourCC");
            }

            byte[] asc = Encoding.ASCII.GetBytes(fcc);

            this.LoadFromBytes(asc[0], asc[1], asc[2], asc[3]);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FourCC"/> class.
        /// </summary>
        /// <param name="a">First character.</param>
        /// <param name="b">Second character.</param>
        /// <param name="c">Third character.</param>
        /// <param name="d">Fourth character.</param>
        public FourCC(char a, char b, char c, char d)
        {
            this.LoadFromBytes((byte)a, (byte)b, (byte)c, (byte)d);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FourCC"/> class.
        /// </summary>
        /// <param name="fcc">Integer containing the four character code.</param>
        public FourCC(int fcc)
        {
            this.m_fourCC = fcc;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FourCC"/> class.
        /// </summary>
        /// <param name="a">First character.</param>
        /// <param name="b">Second character.</param>
        /// <param name="c">Third character.</param>
        /// <param name="d">Fourth character.</param>
        public FourCC(byte a, byte b, byte c, byte d)
        {
            this.LoadFromBytes(a, b, c, d);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FourCC"/> class.
        /// </summary>
        /// <param name="g">Guid containing a Four CC media subtype.</param>
        /// <exception cref="System.Exception">If the given Guid does not contain a Four CC media subtype.</exception>
        public FourCC(Guid g)
        {
            if (!IsA4ccSubtype(g))
            {
                throw new ArgumentException("Not a FourCC Guid");
            }

            byte[] asc;
            asc = g.ToByteArray();

            this.LoadFromBytes(asc[0], asc[1], asc[2], asc[3]);
        }

        /// <summary>
        /// Fill this Four CC from the given 4 characters.
        /// </summary>
        /// <param name="a">First character.</param>
        /// <param name="b">Second character.</param>
        /// <param name="c">Third character.</param>
        /// <param name="d">Fourth character.</param>
        public void LoadFromBytes(byte a, byte b, byte c, byte d)
        {
            this.m_fourCC = a | (b << 8) | (c << 16) | (d << 24);
        }

        /// <summary>
        /// Converts the Four CC to an integer (DWORD).
        /// </summary>
        /// <returns>Integer containing the four character code.</returns>
        public int ToInt32()
        {
            return this.m_fourCC;
        }

        /// <summary>
        /// Convert a Four CC instance to an integer containing the four character code.
        /// </summary>
        /// <param name="f">FourCC to convert to an integer containing the four character code.</param>
        /// <returns>Integer containing the four character code.</returns>
        public static explicit operator int(FourCC f)
        {
            return f.ToInt32();
        }

        /// <summary>
        /// Convert a Four CC instance to a Four CC media subtype Guid.
        /// </summary>
        /// <param name="f">FourCC to convert to a guid containing the Four CC media subtype.</param>
        /// <returns>Guid containing the Four CC media subtype.</returns>
        public static explicit operator Guid(FourCC f)
        {
            return f.ToMediaSubtype();
        }

        /// <summary>
        /// Convert this Four CC instance to a Four CC media subtype Guid.
        /// </summary>
        /// <returns>Guid containing the Four CC media subtype.</returns>
        public Guid ToMediaSubtype()
        {
            return new Guid(this.m_fourCC, 0x0000, 0x0010, 0x80, 0x00, 0x00, 0xaa, 0x00, 0x38, 0x9b, 0x71);
        }

        /// <summary>
        /// Implements the equality operator.
        /// </summary>
        /// <param name="fcc1">The left operand to compare for equality.</param>
        /// <param name="fcc2">The right operand to compare for equality.</param>
        /// <returns>The result of the equality comparison operator.</returns>
        public static bool operator ==(FourCC fcc1, FourCC fcc2)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(fcc1, fcc2))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)fcc1 == null) || ((object)fcc2 == null))
            {
                return false;
            }

            return fcc1.m_fourCC == fcc2.m_fourCC;
        }

        /// <summary>
        /// Implements the inequality operator.
        /// </summary>
        /// <param name="fcc1">The left operand to compare for inequality.</param>
        /// <param name="fcc2">The right operand to compare for inequality.</param>
        /// <returns>The result of the inequality comparison operator.</returns>
        public static bool operator !=(FourCC fcc1, FourCC fcc2)
        {
            return !(fcc1 == fcc2);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (!(obj is FourCC))
                return false;

            return (obj as FourCC).m_fourCC == this.m_fourCC;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return this.m_fourCC.GetHashCode();
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> that represents this instance.
        /// </summary>
        /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
        public override string ToString()
        {
            char c;
            char[] ca = new char[4];

            c = Convert.ToChar(this.m_fourCC & 255);
            if (!Char.IsLetterOrDigit(c))
            {
                c = ' ';
            }

            ca[0] = c;

            c = Convert.ToChar((this.m_fourCC >> 8) & 255);
            if (!Char.IsLetterOrDigit(c))
            {
                c = ' ';
            }

            ca[1] = c;

            c = Convert.ToChar((this.m_fourCC >> 16) & 255);
            if (!Char.IsLetterOrDigit(c))
            {
                c = ' ';
            }

            ca[2] = c;

            c = Convert.ToChar((this.m_fourCC >> 24) & 255);
            if (!Char.IsLetterOrDigit(c))
            {
                c = ' ';
            }

            ca[3] = c;

            string s = new string(ca);

            return s;
        }

        /// <summary>
        /// Determines if the given Guid is a Four CC media subtype.
        /// </summary>
        /// <param name="g">Guid to test if it represents a Four CC media subtype.</param>
        /// <returns>True of the the given Guid is a Four CC media subtype, otherwise false.</returns>
        public static bool IsA4ccSubtype(Guid g)
        {
            return (g.ToString().EndsWith("-0000-0010-8000-00aa00389b71"));
        }
    }
}
