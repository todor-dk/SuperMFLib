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

namespace MediaFoundation.Core.Enums
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Defines the ASF multiplexer options.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/6989AC24-F25F-4BC8-A4B9-3E41434A0D44(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/6989AC24-F25F-4BC8-A4B9-3E41434A0D44(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MFASF_MULTIPLEXERFLAGS")]
    internal enum MFASFMultiplexerFlags
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// The multiplexer automatically adjusts the bit rate of the ASF content in response to the
        /// characteristics of the streams being multiplexed.
        /// </summary>
        AutoAdjustBitrate = 0x00000001
    }

#endif

}
