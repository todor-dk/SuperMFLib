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
using System.Runtime.InteropServices.ComTypes;

using MediaFoundation.Misc;
using MediaFoundation;
using System.Drawing;

namespace MediaFoundation.Core.Structs
{
#if NOT_IN_USE

    /// <summary>
    /// Describes a 4:4:4:4 Y'Cb'Cr' sample.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct __MFAYUVSample {
    ///   BYTE bCrValue;
    ///   BYTE bCbValue;
    ///   BYTE bYValue;
    ///   BYTE bSampleAlpha8;
    /// } MFAYUVSample;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/9784B561-3B87-4DF9-A434-55E12F97B05A(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/9784B561-3B87-4DF9-A434-55E12F97B05A(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential, Pack = 1), UnmanagedName("MFAYUVSample")]
    internal struct MFAYUVSample
    {
        /// <summary>
        /// Cr (chroma difference) value.
        /// </summary>
        public byte bCrValue;
        /// <summary>
        /// Cb (chroma difference) value.
        /// </summary>
        public byte bCbValue;
        /// <summary>
        /// Y (luma) value.
        /// </summary>
        public byte bYValue;
        /// <summary>
        /// Alpha value.
        /// </summary>
        public byte bSampleAlpha8;
    }

#endif
}
