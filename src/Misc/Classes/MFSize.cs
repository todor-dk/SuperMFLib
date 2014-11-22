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
    /// The SIZE structure defines the width and height of a rectangle.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct tagSIZE {
    ///   LONG cx;
    ///   LONG cy;
    /// } SIZE, *PSIZE, *LPSIZE;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/08D81096-069F-4554-9BB9-D4A37C0950AC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/08D81096-069F-4554-9BB9-D4A37C0950AC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 4), UnmanagedName("SIZE")]
    public class MFSize
    {
        /// <summary>
        /// Specifies the rectangle's width. The units depend on which function uses this structure. 
        /// </summary>
        public int cx;
        /// <summary>
        /// Specifies the rectangle's height. The units depend on which function uses this structure.
        /// </summary>
        public int cy;

        /// <summary>
        /// Initializes a new instance of the <see cref="MFSize"/> class.
        /// </summary>
        public MFSize()
        {
            cx = 0;
            cy = 0;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MFSize"/> class.
        /// </summary>
        /// <param name="iWidth">The width. The units depend on which function uses this structure. </param>
        /// <param name="iHeight">The height. The units depend on which function uses this structure.</param>
        public MFSize(int iWidth, int iHeight)
        {
            cx = iWidth;
            cy = iHeight;
        }

        /// <summary>
        /// Specifies the rectangle's width. The units depend on which function uses this structure. 
        /// </summary>
        public int Width
        {
            get
            {
                return cx;
            }
            set
            {
                cx = value;
            }
        }

        /// <summary>
        /// Specifies the rectangle's height. The units depend on which function uses this structure.
        /// </summary>
        public int Height
        {
            get
            {
                return cy;
            }
            set
            {
                cy = value;
            }
        }
    }

}
