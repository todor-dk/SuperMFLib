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

namespace MediaFoundation.Core.Enums
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Specifies how aggressively a pipeline component should drop samples.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E40751D2-9ABF-4FE6-8829-9B1FBF4531E8(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E40751D2-9ABF-4FE6-8829-9B1FBF4531E8(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MF_QUALITY_DROP_MODE")]
    internal enum MFQualityDropMode
    {
        /// <summary>
        /// Normal processing of samples. Drop mode is disabled.
        /// </summary>
        None,
        /// <summary>
        /// First drop mode (least aggressive).
        /// </summary>
        Mode1,
        /// <summary>
        /// Second drop mode.
        /// </summary>
        Mode2,
        /// <summary>
        /// Third drop mode.
        /// </summary>
        Mode3,
        /// <summary>
        /// Fourth drop mode.
        /// </summary>
        Mode4,
        /// <summary>
        /// Fifth drop mode (most aggressive, if it is supported; see Remarks).
        /// </summary>
        Mode5,
        /// <summary>
        /// Maximum number of drop modes. This value is not a valid flag.
        /// </summary>
        NumDropModes
    }

#endif

}
