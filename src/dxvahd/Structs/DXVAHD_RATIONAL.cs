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
using System.Security;

using MediaFoundation.Misc;
using System.Drawing;

namespace MediaFoundation.dxvahd
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains a rational number (ratio).
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVAHD_RATIONAL {
    ///   UINT Numerator;
    ///   UINT Denominator;
    /// } DXVAHD_RATIONAL;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8064820E-533E-4B40-8EEB-E3AD6A6B1FF7(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8064820E-533E-4B40-8EEB-E3AD6A6B1FF7(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("DXVAHD_RATIONAL")]
    public struct DXVAHD_RATIONAL
    {
        /// <summary>
        /// The numerator of the ratio.
        /// </summary>
        public int Numerator;
        /// <summary>
        /// The denominator of the ratio.
        /// </summary>
        public int Denominator;
    }

#endif

}
