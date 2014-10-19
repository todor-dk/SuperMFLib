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
    /// Defines the range of supported values for an image filter.
    /// </summary>
    /// <remarks>
    /// <strong>C/C++ Syntax</strong>
    /// <code>
    /// typedef struct _DXVAHD_FILTER_RANGE_DATA {
    ///   INT   Minimum;
    ///   INT   Maximum;
    ///   INT   Default;
    ///   FLOAT Multiplier;
    /// } DXVAHD_FILTER_RANGE_DATA;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/CD349AC5-9825-4DC8-8735-5D846ABB353B(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/CD349AC5-9825-4DC8-8735-5D846ABB353B(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [StructLayout(LayoutKind.Sequential), UnmanagedName("DXVAHD_FILTER_RANGE_DATA")]
    public struct DXVAHD_FILTER_RANGE_DATA
    {
        /// <summary>
        /// The minimum value of the filter.
        /// </summary>
        public int Minimum;
        /// <summary>
        /// The maximum value of the filter.
        /// </summary>
        public int Maximum;
        /// <summary>
        /// The default value of the filter.
        /// </summary>
        public int Default;
        /// <summary>
        /// A multiplier. Use the following formula to translate the filter setting into the actual filter
        /// value: <em>Actual Value</em> = <em>Set Value</em> × <em>Multiplier</em>.
        /// </summary>
        public float Multiplier;
    }

#endif

}
