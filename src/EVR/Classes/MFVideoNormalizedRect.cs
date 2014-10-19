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

using MediaFoundation;
using MediaFoundation.Misc;
using MediaFoundation.Transform;
using System.Drawing;

namespace MediaFoundation.EVR
{


    /// <summary>
    /// Defines a normalized rectangle, which is used to specify sub-rectangles in a video rectangle. When
    /// a rectangle N is <em>normalized</em> relative to some other rectangle R, it means the following: 
    /// <para/>
    /// Any coordinates of N that fall outside the range [0...1] are mapped to positions outside the
    /// rectangle R. A normalized rectangle can be used to specify a region within a video rectangle
    /// without knowing the resolution or even the aspect ratio of the video. For example, the upper-left
    /// quadrant is defined as {0.0, 0.0, 0.5, 0.5}.
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct MFVideoNormalizedRect {
    ///   float left;
    ///   float top;
    ///   float right;
    ///   float bottom;
    /// } MFVideoNormalizedRect;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/C1DD42CA-64A0-4F30-82E1-EDA3F4721526(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/C1DD42CA-64A0-4F30-82E1-EDA3F4721526(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 4), UnmanagedName("MFVideoNormalizedRect")]
    public class MFVideoNormalizedRect
    {
        /// <summary>
        /// X-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        public float left;
        /// <summary>
        /// Y-coordinate of the upper-left corner of the rectangle.
        /// </summary>
        public float top;
        /// <summary>
        /// X-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        public float right;
        /// <summary>
        /// Y-coordinate of the lower-right corner of the rectangle.
        /// </summary>
        public float bottom;

        /// <summary>
        /// Initializes a new instance of the <see cref="MFVideoNormalizedRect"/> class.
        /// </summary>
        public MFVideoNormalizedRect()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MFVideoNormalizedRect"/> class.
        /// </summary>
        /// <param name="l">X-coordinate of the upper-left corner of the rectangle.</param>
        /// <param name="t">Y-coordinate of the upper-left corner of the rectangle.</param>
        /// <param name="r">X-coordinate of the lower-right corner of the rectangle.</param>
        /// <param name="b">Y-coordinate of the lower-right corner of the rectangle.</param>
        public MFVideoNormalizedRect(float l, float t, float r, float b)
        {
            left = l;
            top = t;
            right = r;
            bottom = b;
        }


        public override string ToString()
        {
            return string.Format("left = {0}, top = {1}, right = {2}, bottom = {3}", left, top, right, bottom);
        }


        public override int GetHashCode()
        {
            return left.GetHashCode() |
                top.GetHashCode() |
                right.GetHashCode() |
                bottom.GetHashCode();
        }


        public override bool Equals(object obj)
        {
            if (obj is MFVideoNormalizedRect)
            {
                MFVideoNormalizedRect cmp = (MFVideoNormalizedRect)obj;

                return right == cmp.right && bottom == cmp.bottom && left == cmp.left && top == cmp.top;
            }

            return false;
        }

        public bool IsEmpty()
        {
            return (right <= left || bottom <= top);
        }

        public void CopyFrom(MFVideoNormalizedRect from)
        {
            left = from.left;
            top = from.top;
            right = from.right;
            bottom = from.bottom;
        }
    }

}
