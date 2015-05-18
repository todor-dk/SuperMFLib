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
    /// Defines the ASF indexer options.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/E5794835-218D-4759-BF3E-A573B24424C3(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/E5794835-218D-4759-BF3E-A573B24424C3(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MFASF_INDEXER_FLAGS")]
    internal enum MFAsfIndexerFlags
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0x0,
        /// <summary>
        /// The indexer creates a new index object.
        /// </summary>
        WriteNewIndex = 0x00000001,
        /// <summary>
        /// The indexer returns values for reverse playback.
        /// </summary>
        ReadForReversePlayback = 0x00000004,
        /// <summary>
        /// The indexer creates an index object for a live ASF stream.
        /// </summary>
        WriteForLiveRead = 0x00000008
    }

}
