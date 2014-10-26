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

namespace MediaFoundation.OPM
{

#if ALLOW_UNTESTED_INTERFACES

    /// <summary>
    /// This class contains constants used by the OPM API.
    /// </summary>
    public static class OpmConstants
    {
        /// <summary>
        /// Output Protection Manager (OPM) One Key CBC MAC (OMAC) Size.
        /// See: http://msdn.microsoft.com/en-gb/library/windows/desktop/dd388945(v=vs.85).aspx
        /// </summary>
        public const int OPM_OMAC_SIZE = 16;
        /// <summary>
        /// Constant used by the <see cref="OPM_RANDOM_NUMBER"/> structure.
        /// </summary>
        public const int OPM_128_BIT_RANDOM_NUMBER_SIZE = 16;
        /// <summary>
        /// Constant used by the <see cref="OPM_ENCRYPTED_INITIALIZATION_PARAMETERS"/> structure.
        /// </summary>
        public const int OPM_ENCRYPTED_INITIALIZATION_PARAMETERS_SIZE = 256;
        /// <summary>
        /// Constant used by the <see cref="OPM_CONFIGURE_PARAMETERS"/> structure.
        /// </summary>
        public const int OPM_CONFIGURE_SETTING_DATA_SIZE = 4056;
        /// <summary>
        /// Constant used by the <see cref="OPM_COPP_COMPATIBLE_GET_INFO_PARAMETERS"/> structure.
        /// </summary>
        public const int OPM_GET_INFORMATION_PARAMETERS_SIZE = 4056;
        /// <summary>
        /// Constant used by the <see cref="OPM_REQUESTED_INFORMATION"/> structure.
        /// </summary>
        public const int OPM_REQUESTED_INFORMATION_SIZE = 4076;

        /// <summary>
        /// Constant used by the <see cref="OPM_HDCP_KEY_SELECTION_VECTOR"/> structure.
        /// </summary>
        public const int OPM_HDCP_KEY_SELECTION_VECTOR_SIZE = 5;

        /// <summary>
        /// OPM protection type size.
        /// </summary>
        public const int OPM_PROTECTION_TYPE_SIZE = 4;

        /// <summary>
        /// Flag mask for the <strong>bus type</strong> flags.
        /// </summary>
        public const int OPM_BUS_TYPE_MASK = 0xffff;

        /// <summary>
        /// Flag mask for the <strong>bus implementation</strong> flags.
        /// </summary>
        public const int OPM_BUS_IMPLEMENTATION_MODIFIER_MASK = 0x7fff;
    }

#endif

}
