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
    /// Specifies a rectangular area within a video frame. 
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _MFVideoArea {
    ///   MFOffset OffsetX;
    ///   MFOffset OffsetY;
    ///   SIZE     Area;
    /// } MFVideoArea;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/D22B8B9C-399B-4FCE-A173-833005B5BF03(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/D22B8B9C-399B-4FCE-A173-833005B5BF03(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 4), UnmanagedName("MFVideoArea")]
    public class MFVideoArea
    {
        /// <summary>
        /// An <see cref="MFOffset"/> structure that contains the x-coordinate of the upper-left corner of the
        /// rectangle. This coordinate might have a fractional value. 
        /// </summary>
        public MFOffset OffsetX;
        /// <summary>
        /// An <see cref="MFOffset"/> structure that contains the y-coordinate of the upper-left corner of the
        /// rectangle. This coordinate might have a fractional value. 
        /// </summary>
        public MFOffset OffsetY;
        /// <summary>
        /// A <see cref="Misc.MFSize"/> structure that contains the width and height of the rectangle. 
        /// </summary>
        public MFSize Area;

        /// <summary>
        /// Initializes a new instance of the <see cref="MFVideoArea"/> class.
        /// </summary>
        public MFVideoArea()
        {
            OffsetX = new MFOffset();
            OffsetY = new MFOffset();
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="MFVideoArea"/> class.
        /// </summary>
        /// <param name="x">The x-coordinate of the upper-left corner of the rectangle.</param>
        /// <param name="y">The y-coordinate of the upper-left corner of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        public MFVideoArea(float x, float y, int width, int height)
        {
            OffsetX = new MFOffset(x);
            OffsetY = new MFOffset(y);
            Area = new MFSize(width, height);
        }

        /// <summary>
        /// Fill the coordinates of the this MFVideoArea instance with the given values.
        /// </summary>
        /// <param name="x">The x-coordinate of the upper-left corner of the rectangle.</param>
        /// <param name="y">The y-coordinate of the upper-left corner of the rectangle.</param>
        /// <param name="width">The width of the rectangle.</param>
        /// <param name="height">The height of the rectangle.</param>
        public void MakeArea(float x, float y, int width, int height)
        {
            OffsetX.MakeOffset(x);
            OffsetY.MakeOffset(y);
            Area.Width = width;
            Area.Height = height;
        }
    }

}
