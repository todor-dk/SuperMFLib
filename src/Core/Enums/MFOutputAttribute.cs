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
    /// Flags used in conjunction with the <see cref="IMFOutputPolicy.GenerateRequiredSchemas"/> method.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/23F5F0DF-E2CC-4593-8C3E-DCA3638161E2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MFOUTPUTATTRIBUTE_ *")]
    internal enum MFOutputAttribute
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// The output sends a digital signal. If this flag is absent, the output sends an analog signal.
        /// </summary>
        Digital = 0x00000001,
        /// <summary>
        /// Reserved. Do not use. 
        /// </summary>
        NonstandardImplementation = 0x00000002,
        /// <summary>
        /// The output sends video data. If this flag is absent, the output sends audio data. 
        /// </summary>
        Video = 0x00000004,
        /// <summary>
        /// The output sends compressed data. If this flag is absent, the output sends uncompressed data. 
        /// </summary>
        Compressed = 0x00000008,
        /// <summary>
        /// Reserved. Do not use. 
        /// </summary>
        Software = 0x00000010,
        /// <summary>
        /// Hardware bus. 
        /// </summary>
        Bus = 0x00000020,
        /// <summary>
        /// Reserved. Do not use. 
        /// </summary>
        BusImplementation = 0x0000FF00
    }

#endif

}
