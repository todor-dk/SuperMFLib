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

namespace MediaFoundation.OPM.Structs
{

#if ALLOW_UNTESTED_INTERFACES


    /// <summary>
    /// Contains an <c>Output Protection Manager</c> (OPM) or Certified Output Protection Manager (COPP)
    /// command.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _OPM_CONFIGURE_PARAMETERS {
    ///   OPM_OMAC omac;
    ///   GUID     guidSetting;
    ///   ULONG    ulSequenceNumber;
    ///   ULONG    cbParametersSize;
    ///   BYTE     abParameters[OPM_CONFIGURE_SETTING_DATA_SIZE];
    /// } OPM_CONFIGURE_PARAMETERS;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/60D13945-740F-46BD-9602-BACD0DAC5E32(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/60D13945-740F-46BD-9602-BACD0DAC5E32(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    internal struct OPM_CONFIGURE_PARAMETERS
    {
        /// <summary>
        /// An <c>OPM_MAC</c> structure. Fill in this structure with the Message Authentication Code (MAC) of
        /// the command data. Use AES-based one-key CBC MAC (OMAC) to calculate this value.
        /// </summary>
        public OPM_OMAC omac;
        /// <summary>
        /// A GUID that specifies the command. For more information, see <c>OPM Commands</c>.
        /// </summary>
        public Guid guidSetting;
        /// <summary>
        /// A command sequence number. The application must keep a running count of the commands issued. For
        /// each command, increment the sequence number by one.
        /// <para />
        /// On the first call to <see cref="OPM.IOPMVideoOutput.Configure" />, set <strong>ulSequenceNumber
        /// </strong> equal to the starting command 	sequence number, which is specified when the application
        /// calls <see cref="OPM.IOPMVideoOutput.FinishInitialization" />. On each subsequent call, increment
        /// <strong>ulSequenceNumber</strong> by 1.
        /// <para />
        /// Exception: If the <see cref="OPM.IOPMVideoOutput.Configure" /> method fails, do not increment the
        /// sequence number. Instead, re-use the same number for the next command.
        /// </summary>
        public int ulSequenceNumber;
        /// <summary>
        /// The number of bytes of valid data in the <strong>abParameters</strong> member.
        /// </summary>
        public int cbParametersSize;
        /// <summary>
        /// The data for the command. The meaning of the data depends on the command. For more information, see
        /// <c>OPM Commands</c>.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4056)]
        public byte[] abParameters;
    }

#endif

}
