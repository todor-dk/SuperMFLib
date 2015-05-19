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
    /// Contains flags that describe the characteristics of a clock. These flags are returned by the 
    /// <see cref="IMFClock.GetClockCharacteristics"/> method. 
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/8064CE25-6C79-479B-A1A8-BDCC2C29AD54(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/8064CE25-6C79-479B-A1A8-BDCC2C29AD54(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MFCLOCK_CHARACTERISTICS_FLAGS")]
    public enum MFClockCharacteristicsFlags
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0,
        /// <summary>
        /// The clock times returned by the <see cref="IMFClock.GetCorrelatedTime"/> method are in units of 100
        /// nanoseconds. If this flag is absent, call <see cref="IMFClock.GetProperties"/> to get the clock
        /// frequency. The clock frequency is given in the <strong>qwClockFrequency</strong> member of the 
        /// <see cref="MFClockProperties"/> structure returned by that method. 
        /// </summary>
        Frequency10Mhz = 0x2,
        /// <summary>
        /// The clock is always running. If this flag is present, the clock cannot be paused or stopped. If
        /// this flag is absent, call the <see cref="IMFClock.GetState"/> method to get the current state. 
        /// </summary>
        AlwaysRunning = 0x4,
        /// <summary>
        /// The clock times are generated from the system clock.
        /// </summary>
        IsSystemClock = 0x8
    }

}
