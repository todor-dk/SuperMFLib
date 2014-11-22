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
    /// Defines the range of supported values for a DirectX Video Acceleration (DXVA) operation.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _DXVA2_ValueRange {
    ///   DXVA2_Fixed32 MinValue;
    ///   DXVA2_Fixed32 MaxValue;
    ///   DXVA2_Fixed32 DefaultValue;
    ///   DXVA2_Fixed32 StepSize;
    /// } DXVA2_ValueRange;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E01328BB-9069-4874-AA35-B3C9BC1C6094(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E01328BB-9069-4874-AA35-B3C9BC1C6094(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVA2_ValueRange")]
    public struct DXVA2ValueRange
    {
        /// <summary>
        /// Minimum supported value.
        /// </summary>
        public int MinValue;
        /// <summary>
        /// Maximum supported value.
        /// </summary>
        public int MaxValue;
        /// <summary>
        /// Default value.
        /// </summary>
        public int DefaultValue;
        /// <summary>
        /// Minimum increment between values.
        /// </summary>
        public int StepSize;
    }

}
