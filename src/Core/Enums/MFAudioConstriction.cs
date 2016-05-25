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
    /// Specifies values for audio constriction.
    /// </summary>
    /// <remarks>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/EAFE3AA5-EF63-471A-9A67-A2EB298B0C0F(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/EAFE3AA5-EF63-471A-9A67-A2EB298B0C0F(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    [UnmanagedName("MFAudioConstriction")]
    internal enum MFAudioConstriction
    {
        /// <summary>
        /// Audio is not constricted. 
        /// </summary>
        Off = 0,
        /// <summary>
        /// Audio is down sampled to 48 kHz/16-bit.
        /// </summary>
        C48_16 = (Off + 1),
        /// <summary>
        /// Audio is down sampled to 44 kHz/16-bit.
        /// </summary>
        C44_16 = (C48_16 + 1),
        /// <summary>
        /// Audio is down sampled to 14hKz/16-bit.
        /// </summary>
        C14_14 = (C44_16 + 1),
        /// <summary>
        /// Audio is muted.
        /// </summary>
        Mute = (C14_14 + 1)
    }

#endif

}
