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

// This file is a mess.  While technically part of MF, I'm in no hurry
// to try to get this to work.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace MediaFoundation.OPM.Enums
{
#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// Defines values for the KSPROPSETID_OPMVideoOutput property.
    /// </summary>
    /// <remarks>
    /// See: http://msdn.microsoft.com/en-us/library/windows/hardware/ff568687(v=vs.85).aspx
    /// </remarks>
    internal enum KSMETHOD_OPMVIDEOOUTPUT
    {
        /// <summary>
        /// Output is OPM_RANDOM_NUMBER followed by certificate.
        /// </summary>
        KSMETHOD_OPMVIDEOOUTPUT_STARTINITIALIZATION = 0,

        /// <summary>
        /// Input OPM_ENCRYPTED_INITIALIZATION_PARAMETERS, output OPM_STANDARD_INFORMATION
        /// </summary>
        KSMETHOD_OPMVIDEOOUTPUT_FINISHINITIALIZATION = 1,

        /// <summary>
        /// Input is OPM_GET_INFO_PARAMETERS, output is OPM_REQUESTED_INFORMATION.
        ///  Use KsMethod - both input and output in the buffer (not after the KSMETHOD structure)
        /// </summary>
        KSMETHOD_OPMVIDEOOUTPUT_GETINFORMATION = 2
    }

#endif

}
