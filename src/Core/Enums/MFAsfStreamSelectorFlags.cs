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
    /// <summary>
    /// Defines the ASF stream selector options.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/2ECECB4A-9516-4066-BF01-0924252F93EE(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/2ECECB4A-9516-4066-BF01-0924252F93EE(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags]
    [UnmanagedName("MFASF_STREAMSELECTOR_FLAGS")]
    internal enum MFAsfStreamSelectorFlags
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0x00000000,

        /// <summary>
        /// The stream selector will not set thinning. Thinning is the process of removing samples from a
        /// stream to reduce the bit rate.
        /// </summary>
        DisableThinning = 0x00000001,

        /// <summary>
        /// The stream selector will use the average bit rate of streams when selecting streams.
        /// </summary>
        UseAverageBitrate = 0x00000002
    }
}
