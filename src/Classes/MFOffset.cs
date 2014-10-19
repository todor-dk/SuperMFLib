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
    /// Specifies an offset as a fixed-point real number. 
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _MFOffset {
    ///   WORD  fract;
    ///   short value;
    /// } MFOffset;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E93539FE-3E4A-4B34-8D6A-B3F300A70FFC(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E93539FE-3E4A-4B34-8D6A-B3F300A70FFC(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 2), UnmanagedName("MFOffset")]
    public class MFOffset
    {
        /// <summary>
        /// The fractional part of the number. 
        /// </summary>
        public short fract;
        /// <summary>
        /// The integer part of the number. 
        /// </summary>
        public short Value;

        /// <summary>
        /// Initializes a new instance of the <see cref="MFOffset"/> class.
        /// </summary>
        public MFOffset()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MFOffset"/> class.
        /// </summary>
        /// <param name="v">The integer part of the number.</param>
        public MFOffset(float v)
        {
            Value = (short)v;
            fract = (short)(65536 * (v - Value));
        }

        public void MakeOffset(float v)
        {
            Value = (short)v;
            fract = (short)(65536 * (v-Value));
        }

        public float GetOffset()
        {
            return ((float)Value) + (((float)fract) / 65536.0f);
        }
    }

}
