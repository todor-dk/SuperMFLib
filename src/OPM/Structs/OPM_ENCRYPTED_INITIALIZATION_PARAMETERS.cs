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
    /// Contains initialization parameters for an <c>Output Protection Manager</c> (OPM) session.
    /// </summary>
    /// <remarks>
    /// <code language="cpp" title="C/C++ Syntax">
    /// typedef struct _OPM_ENCRYPTED_INITIALIZATION_PARAMETERS {
    ///   BYTE abEncryptedInitializationParameters[OPM_ENCRYPTED_INITIALIZATION_PARAMETERS_SIZE];
    /// } OPM_ENCRYPTED_INITIALIZATION_PARAMETERS;
    /// </code>
    /// <para/>
    /// The above documentation is © Microsoft Corporation. It is reproduced here 
    /// with the sole purpose to increase usability and add IntelliSense support.
    /// <para/>
    /// View the original documentation topic online: 
    /// <a href="http://msdn.microsoft.com/en-US/library/ABCF0B84-7370-48DA-B4DD-4FADED6BE343(v=VS.85,d=hv.2).aspx">http://msdn.microsoft.com/en-US/library/ABCF0B84-7370-48DA-B4DD-4FADED6BE343(v=VS.85,d=hv.2).aspx</a>
    /// </remarks>
    internal struct OPM_ENCRYPTED_INITIALIZATION_PARAMETERS
    {
        /// <summary>
        /// Pointer to a buffer that contains encrypted initialization parameters for the session. For more
        /// information, see <see cref="OPM.IOPMVideoOutput.FinishInitialization" />.
        /// </summary>
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
        public byte[] abEncryptedInitializationParameters;
    }

#endif

}
