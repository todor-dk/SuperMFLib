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
    /// Represents a ratio.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _MFRatio {
    ///   DWORD Numerator;
    ///   DWORD Denominator;
    /// } MFRatio;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/315D31D6-BF68-4495-9BAE-1F624F497C1A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/315D31D6-BF68-4495-9BAE-1F624F497C1A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 4), UnmanagedName("MFRatio")]
    public struct MFRatio
    {
        /// <summary>
        /// Numerator of the ratio.
        /// </summary>
        public int Numerator;
        /// <summary>
        /// Denominator of the ratio.
        /// </summary>
        public int Denominator;

        /// <summary>
        /// Initializes a new instance of the <see cref="MFRatio" /> struct.
        /// </summary>
        /// <param name="n">Numerator of the ratio.</param>
        /// <param name="d">Denominator of the ratio.</param>
        public MFRatio(int n, int d)
        {
            Numerator = n;
            Denominator = d;
        }
    }

}
