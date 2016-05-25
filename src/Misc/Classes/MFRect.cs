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

namespace MediaFoundation
{
    /// <summary>
    /// MFRect is a managed representation of the Win32 RECT structure.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct tagRECT {
    ///   LONG left;
    ///   LONG top;
    ///   LONG right;
    ///   LONG bottom;
    /// } RECT, *PRECT, NEAR *NPRECT, FAR *LPRECT;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/A44F33F4-49B2-4A36-A7BD-FC4A9D3A3943(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/A44F33F4-49B2-4A36-A7BD-FC4A9D3A3943(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential)]
    public class MFRect
    {
        /// <summary>
        /// Specifies the <em>x</em>-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        public int left;

        /// <summary>
        /// Specifies the <em>y</em>-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        public int top;

        /// <summary>
        /// Specifies the <em>x</em>-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        public int right;

        /// <summary>
        /// Specifies the <em>y</em>-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        public int bottom;

        /// <summary>
        /// Empty constructor. Initialize all fields to 0
        /// </summary>
        public MFRect()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MFRect"/> class with given values.
        /// </summary>
        /// <param name="l">The <em>x</em>-coordinate of the upper-left corner of the rectangle.</param>
        /// <param name="t">The <em>y</em>-coordinate of the upper-left corner of the rectangle.</param>
        /// <param name="r">The <em>x</em>-coordinate of the lower-right corner of the rectangle.</param>
        /// <param name="b">The <em>y</em>-coordinate of the lower-right corner of the rectangle.</param>
        public MFRect(int l, int t, int r, int b)
        {
            this.left = l;
            this.top = t;
            this.right = r;
            this.bottom = b;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MFRect"/> class with given <see cref="System.Drawing.Rectangle"/>.
        /// </summary>
        /// <param name="rectangle">A <see cref="System.Drawing.Rectangle"/></param>
        /// <remarks>
        /// Warning, MFRect define a rectangle by defining two of its corners and <see cref="System.Drawing.Rectangle"/>
        /// define a rectangle with his upper/left corner, its width and height.
        /// </remarks>
        public MFRect(Rectangle rectangle)
        {
            this.left = rectangle.Left;
            this.top = rectangle.Top;
            this.right = rectangle.Right;
            this.bottom = rectangle.Bottom;
        }

        /// <summary>
        /// Provide the string representation of this MFRect instance.
        /// </summary>
        /// <returns>A string formated like this : [left, top - right, bottom]</returns>
        public override string ToString()
        {
            return string.Format("[{0}, {1}] - [{2}, {3}]", this.left, this.top, this.right, this.bottom);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            return this.left.GetHashCode() |
                this.top.GetHashCode() |
                this.right.GetHashCode() |
                this.bottom.GetHashCode();
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
        {
            if (obj is MFRect)
            {
                MFRect cmp = (MFRect)obj;

                return this.right == cmp.right && this.bottom == cmp.bottom && this.left == cmp.left && this.top == cmp.top;
            }

            if (obj is Rectangle)
            {
                Rectangle cmp = (Rectangle)obj;

                return this.right == cmp.Right && this.bottom == cmp.Bottom && this.left == cmp.Left && this.top == cmp.Top;
            }

            return false;
        }

        /// <summary>
        /// Checks to see if the rectangle is empty.
        /// </summary>
        /// <remarks>
        /// An empty rectangle is a rectangle where <see cref="right"/> &lt;= <see cref="left"/>,
        /// or where <see cref="bottom"/> &lt;= <see cref="top"/>.
        /// </remarks>
        /// <returns>Returns true if the rectangle is empty</returns>
        public bool IsEmpty()
        {
            return (this.right <= this.left || this.bottom <= this.top);
        }

        /// <summary>
        /// Define implicit cast between MFRect and System.Drawing.Rectangle for languages supporting this feature.
        /// VB.Net doesn't support implicit cast. <see cref="MFRect.ToRectangle"/> for similar functionality.
        /// <code>
        ///   // Define a new Rectangle instance
        ///   Rectangle r = new Rectangle(0, 0, 100, 100);
        ///   // Do implicit cast between Rectangle and MFRect
        ///   MFRect mfR = r;
        ///
        ///   Console.WriteLine(mfR.ToString());
        /// </code>
        /// </summary>
        /// <param name="r">a MFRect to be cast</param>
        /// <returns>A casted System.Drawing.Rectangle</returns>
        public static implicit operator Rectangle(MFRect r)
        {
            return r.ToRectangle();
        }

        /// <summary>
        /// Define implicit cast between System.Drawing.Rectangle and MFRect for languages supporting this feature.
        /// VB.Net doesn't support implicit cast. <see cref="MFRect.FromRectangle"/> for similar functionality.
        /// <code>
        ///   // Define a new MFRect instance
        ///   MFRect mfR = new MFRect(0, 0, 100, 100);
        ///   // Do implicit cast between MFRect and Rectangle
        ///   Rectangle r = mfR;
        ///
        ///   Console.WriteLine(r.ToString());
        /// </code>
        /// </summary>
        /// <param name="r">A System.Drawing.Rectangle to be cast</param>
        /// <returns>A casted MFRect</returns>
        public static implicit operator MFRect(Rectangle r)
        {
            return new MFRect(r);
        }

        /// <summary>
        /// Get the System.Drawing.Rectangle equivalent to this MFRect instance.
        /// </summary>
        /// <returns>A System.Drawing.Rectangle</returns>
        public Rectangle ToRectangle()
        {
            return new Rectangle(this.left, this.top, (this.right - this.left), (this.bottom - this.top));
        }

        /// <summary>
        /// Get a new MFRect instance for a given <see cref="System.Drawing.Rectangle"/>
        /// </summary>
        /// <param name="r">The <see cref="System.Drawing.Rectangle"/> used to initialize this new MFGuid</param>
        /// <returns>A new instance of MFGuid</returns>
        public static MFRect FromRectangle(Rectangle r)
        {
            return new MFRect(r);
        }

        /// <summary>
        /// Copy the members from an MFRect into this object
        /// </summary>
        /// <param name="from">The rectangle from which to copy the values.</param>
        public void CopyFrom(MFRect from)
        {
            this.left = from.left;
            this.top = from.top;
            this.right = from.right;
            this.bottom = from.bottom;
        }
    }
}
