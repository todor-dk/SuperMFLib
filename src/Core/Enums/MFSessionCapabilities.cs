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
    /// Flags used in conjunction with the <see cref="IMFMediaSession.GetSessionCapabilities"/> method.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online:
    /// <a href="http://msdn.microsoft.com/en-US/library/3534CFB9-23FF-42A6-A3DB-B5032D427CF2(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/3534CFB9-23FF-42A6-A3DB-B5032D427CF2(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [Flags]
    [UnmanagedName("MFSESSIONCAP_* defines")]
    public enum MFSessionCapabilities
    {
        /// <summary>
        /// Default value / no flags are set.
        /// </summary>
        None = 0x00000000,

        /// <summary>
        /// The Media Session can be started.
        /// </summary>
        Start = 0x00000001,

        /// <summary>
        /// The Media Session can be seeked.
        /// </summary>
        Seek = 0x00000002,

        /// <summary>
        /// The Media Session can be paused.
        /// </summary>
        Pause = 0x00000004,

        /// <summary>
        /// The Media Session supports forward playback at rates faster than 1.0.
        /// </summary>
        RateForward = 0x00000010,

        /// <summary>
        /// The Media Session supports reverse playback.
        /// </summary>
        RateReverse = 0x00000020,

        /// <summary>
        /// <i>***** Documentation Missing *****</i>.
        /// </summary>
        DoesNotUseNetwork = 0x00000040
    }
}
