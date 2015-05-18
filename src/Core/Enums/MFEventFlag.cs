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

namespace MediaFoundation.Core.Enums
{

    /// <summary>
    /// Flags used in conjunction with the <c>GetEvent</c> method implemented by several Media Foundation interfaces.
    /// </summary>
    /// <remarks>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/512C67A5-E87D-4A81-8577-E64DAC868C40(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/512C67A5-E87D-4A81-8577-E64DAC868C40(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags, UnmanagedName("MF_EVENT_FLAG_* defines")]
    internal enum MFEventFlag
    {
        /// <summary>
        /// The method blocks until the event generator queues an event.
        /// </summary>
        /// <remarks>
        /// This is same as <see cref="None"/>.
        /// </remarks>
        Wait = 0,
        /// <summary>
        /// The method blocks until the event generator queues an event.
        /// </summary>
        None = 0,
        /// <summary>
        /// The method returns immediately.
        /// </summary>
        NoWait = 0x00000001
    }

}
