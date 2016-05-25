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
    /// Flags used in conjunction with the <see cref="IMFByteStream.Seek"/> method.
    /// </summary>
    /// <remarks>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/512C67A5-E87D-4A81-8577-E64DAC868C40(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/512C67A5-E87D-4A81-8577-E64DAC868C40(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags]
    [UnmanagedName("MFBYTESTREAM_SEEK_FLAG_ defines")]
    public enum MFByteStreamSeekingFlags
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,

        /// <summary>
        /// All pending I/O requests are canceled after the seek request completes successfully.
        /// </summary>
        CancelPendingIO = 1
    }
}
