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

namespace MediaFoundation
{
    /// <summary>
    /// Defines the state of a clock.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/90E04807-C3BE-4F38-A508-9DFE62700869(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/90E04807-C3BE-4F38-A508-9DFE62700869(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFCLOCK_STATE")]
    public enum MFClockState
    {
        /// <summary>
        /// The clock is invalid. A clock might be invalid for several reasons. Some clocks return this state
        /// before the first start. This state can also occur if the underlying device is lost.
        /// </summary>
        Invalid,

        /// <summary>
        /// The clock is running. While the clock is running, the time advances at the clock's frequency and
        /// current rate.
        /// </summary>
        Running,

        /// <summary>
        /// The clock is stopped. While stopped, the clock reports a time of 0.
        /// </summary>
        Stopped,

        /// <summary>
        /// The clock is paused. While paused, the clock reports the time it was paused.
        /// </summary>
        Paused
    }
}
